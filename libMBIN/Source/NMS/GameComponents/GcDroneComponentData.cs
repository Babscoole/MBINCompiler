using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEB03AD540A0AA980, NameHash = 0xC10BA45)]
    public class GcDroneComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public GcCreatureHealthData Health;
        [NMS(Index = 5)]
        /* 0x68 */ public List<GcDroneGun> Guns;
        [NMS(Index = 0)]
        /* 0x78 */ public NMSString0x10 Id;
        [NMS(Index = 4)]
        /* 0x88 */ public List<NMSString0x10> ProjectileChoices;
        [NMS(Index = 1)]
        /* 0x98 */ public GcPrimaryAxis Axis;
        [NMS(Index = 2)]
        /* 0x9C */ public float Scaler;
    }
}
