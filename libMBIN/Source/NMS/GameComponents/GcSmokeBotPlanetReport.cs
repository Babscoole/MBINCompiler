using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB78ADBB2DCAB52F2, NameHash = 0x778378F86BB2392C)]
    public class GcSmokeBotPlanetReport : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcSmokeBotStats PlanetStats;
        [NMS(Index = 0)]
        /* 0x90 */ public ulong UA;
    }
}
