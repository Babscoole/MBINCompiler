using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD8AF927BA86DC334, NameHash = 0x4BE4494B)]
    public class GcProjectileDataTable : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcLaserBeamData> Lasers;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcProjectileData> Table;
    }
}
