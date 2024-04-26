using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9EB487CAB4D10F3F, NameHash = 0x6316491205B3FC32)]
    public class TkAnimJointLODData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x40> JointNames;
        [NMS(Index = 0)]
        /* 0x10 */ public int LOD;
    }
}
