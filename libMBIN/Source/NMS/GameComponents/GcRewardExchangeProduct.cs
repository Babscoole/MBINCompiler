namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x69149CDB2CCDF8F, NameHash = 0x16DE6ECD)]
    public class GcRewardExchangeProduct : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 IDToGive;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 IDToTake;
        [NMS(Index = 3)]
        /* 0x20 */ public int AmountToGiveMax;
        [NMS(Index = 2)]
        /* 0x24 */ public int AmountToGiveMin;
        [NMS(Index = 4)]
        /* 0x28 */ public int AmountToTakeMax;
        [NMS(Index = 6)]
        /* 0x2C */ public bool ForceSpecialMessage;
        [NMS(Index = 5)]
        /* 0x2D */ public bool HideNewProduct;
    }
}
