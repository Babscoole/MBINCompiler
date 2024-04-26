using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x95757206A198C, NameHash = 0x5BD84E5380495165)]
    public class GcCostGameMode : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A CostStringCantAfford;
        [NMS(Index = 1)]
        /* 0x20 */ public GcGameMode Mode;
        [NMS(Index = 0)]
        /* 0x24 */ public bool InvertMode;
    }
}
