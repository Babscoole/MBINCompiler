using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD3F352CAAE1C6AA, NameHash = 0xE866662BD040EDFB)]
    public class GcSentinelWaveGroup : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x10> ExtremeWaves;
        [NMS(Index = 0)]
        /* 0x10 */ public List<NMSString0x10> Waves;
    }
}
