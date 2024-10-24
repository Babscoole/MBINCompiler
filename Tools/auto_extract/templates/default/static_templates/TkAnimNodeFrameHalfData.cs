using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD5472A0D4EFF6E62, NameHash = 0xFD9A1D5E0981C57C)]
    public class TkAnimNodeFrameHalfData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<Quaternion> Rotations;
        [NMS(Index = 2)]
        /* 0x10 */ public List<Vector4f> Scales;
        [NMS(Index = 1)]
        /* 0x20 */ public List<Vector4f> Translations;

        public override object CustomDeserialize(BinaryReader reader, Type field, NMSAttribute settings, FieldInfo fieldInfo) {
            var fieldName = fieldInfo.Name;

            switch (fieldName)
                {
                case nameof(Rotations):
                    // sort out reading of list
                    long listPosition = reader.BaseStream.Position;

                    long listStartOffset = reader.ReadInt64();
                    int numEntries = reader.ReadInt32() / 3;
                    uint listMagic = reader.ReadUInt32();
                    if ((listMagic & 0xFF) != 1) throw new InvalidListException(listMagic, reader.BaseStream.Position);

                    long listEndPosition = reader.BaseStream.Position;

                    reader.BaseStream.Position = listPosition + listStartOffset;
                    // output data
                    List<Quaternion> data = new List<Quaternion>();
                    // worker values
                    UInt16 c_x, c_y, c_z;
                    UInt16 i_x, i_y;
                    // The scaling factor. This is slightly different to the one in the exe.
                    // The value in the exe is 0.000030518509 times some other factors,
                    // however using this decimal value results in decompiled values which are much more messy.
                    double scale = 1.0f / (0x3FFF * Math.Sqrt(2.0f));
                    // now, iterate over the input data.
                    // We will read in the data in chunks of 6 bytes
                    for (int i = 0; i < numEntries; i++)
                        {
                        // assign the variables
                        c_x = reader.ReadUInt16();
                        c_y = reader.ReadUInt16();
                        c_z = reader.ReadUInt16();

                        // determine most significant bit (0 or 1)
                        i_x = (UInt16)(c_x >> 0xE);
                        i_y = (UInt16)(c_y >> 0xF);

                        /* dropcomponent indicates which component of the quaternion has been dropped
                        3 -> x
                        2 -> y
                        1 -> z
                        0 -> w */
                        ushort dropcomponent = (ushort)(i_y | i_x & 2);

                        //Mask Values (strip most significant bit)
                        double qx = scale * ((c_x & 0x7FFF) - 0x3FFF);
                        double qy = scale * ((c_y & 0x7FFF) - 0x3FFF);
                        double qz = scale * (c_z - 0x3FFF);

                        //I assume that W is positive by default
                        double qw = Math.Sqrt(Math.Max(Math.Min(1.0f - qx * qx - qy * qy - qz * qz, 1.0), 0.0));
                        // output Quaternion
                        Quaternion qo;

                        switch (dropcomponent)
                            {
                            case 3:     // qx was dropped
                                qo = new Quaternion(qw, qx, qy, qz, 3 - dropcomponent);
                                break;
                            case 2:     // qy was dropped
                                qo = new Quaternion(qx, qw, qy, qz, 3 - dropcomponent);
                                break;
                            case 1:     // qz was dropped
                                qo = new Quaternion(qx, qy, qw, qz, 3 - dropcomponent);
                                break;
                            case 0:     // qw was dropped
                                qo = new Quaternion(qx, qy, qz, qw, 3 - dropcomponent);
                                break;
                            default:
                                qo = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f, 0);        // shouldn't ever get here
                                break;
                        }
                        data.Add(qo);
                    }

                    // the padding bytes are just ignored...

                    reader.BaseStream.Position = listEndPosition;
                    return data;
            }
            return null;
        }

        public override bool CustomSerialize(BinaryWriter writer, Type field, object fieldData, NMSAttribute settings, FieldInfo fieldInfo, ref List<Tuple<long, object>> additionalData, ref int addtDataIndex)
            {
            if (field == null || fieldInfo == null)
                return false;

            var fieldName = fieldInfo.Name;
            switch (fieldName)
                {
                case nameof(Rotations):

                    IList<Quaternion> data = (IList<Quaternion>)fieldData;

                    List<UInt16> outputData = new List<UInt16>();

                    // write empty list header
                    long listPos = writer.BaseStream.Position;
                    writer.Write((Int64)0); // listPosition
                    writer.Write((Int32)0); // listCount
                    writer.Write((UInt32)0x00000001);

                    if (data == null) return true;

                    foreach (Quaternion q in data)
                        {
                        List<UInt16> convertedQ = new List<UInt16>
                        {
                            ConvertQuat(q.x),
                            ConvertQuat(q.y),
                            ConvertQuat(q.z),
                            ConvertQuat(q.w),
                        };

                        // Get the drop component from the value stored in the exml.
                        // For more details see the comment above the DetermineDropComponent method.
                        int dropcomponent = q.dropComponent;
                        // int dropcomponent = DetermineDropComponent(convertedQ);

                        // remove the element we wish to discard
                        convertedQ.RemoveAt(dropcomponent);

                        dropcomponent = 3 - dropcomponent;      // flip the number to correspond to the correct component

                        int i_x = dropcomponent >> 1;
                        int i_y = dropcomponent & 1;

                        convertedQ[0] = (UInt16)((i_x << 0xF) + (int)convertedQ[0]);
                        convertedQ[1] = (UInt16)((i_y << 0xF) + (int)convertedQ[1]);

                        // extend the ouput data
                        outputData.AddRange(convertedQ);

                    }

                    additionalData.Insert(addtDataIndex, new Tuple<long, object>(listPos, outputData));
                    addtDataIndex++;
                    return true;
            }

            return false;
        }

        // Note: This function doesn't quite work. There are a few edge cases that it doesn't quite handle.
        // To get around this we'll just store the dropped component, but if these edge cases can be fixed,
        // then we can stop storing the drop component and just determine it from the data.
        // Some bytes which cannot have their drop component determined correctly (little endian):
        // e475 b01b 601f
        // ee80 deca 107f
        // f4e6 388d c672
        // f3e6 398d c572
        private UInt16 DetermineDropComponent(List<UInt16> arr)
            {
            UInt16 max_loc = 0;        // x by default
            HashSet<UInt16> doubled_elements = new HashSet<UInt16>();
            HashSet<UInt16> condensed_arr = new HashSet<UInt16>();
            // add all the elements in arr to the set version
            foreach (UInt16 i in arr)
                {
                if (condensed_arr.Contains(i))
                    {
                    doubled_elements.Add(i);
                }
                condensed_arr.Add(i);
            }
            if (condensed_arr.Count == 4)
                {
                // in this case we simply want the max
                UInt16 max_val = arr.Max();
                max_loc = (UInt16)arr.IndexOf(max_val);
            }
            else
            {
                // we have a doubled element
                if (!doubled_elements.Contains(0x3FFF))
                    {
                    max_loc = 0;        // remove x
                }
                else
                {
                    UInt16 max_val = arr.Max();
                    max_loc = (UInt16)arr.IndexOf(max_val);
                }
            }

            return max_loc;
        }

        private UInt16 ConvertQuat(double qi)
            {
            return (UInt16)Math.Round(0x3FFF * (Math.Sqrt(2) * qi + 1));
        }
    }
}