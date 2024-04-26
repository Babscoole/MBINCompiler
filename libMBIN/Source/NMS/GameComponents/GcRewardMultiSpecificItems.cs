using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAEE8EDDE03DEC00E, NameHash = 0x26C3924987148B0B)]
    public class GcRewardMultiSpecificItems : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcMultiSpecificItemEntry> Items;
        [NMS(Index = 0)]
        /* 0x10 */ public bool Silent;
    }
}
