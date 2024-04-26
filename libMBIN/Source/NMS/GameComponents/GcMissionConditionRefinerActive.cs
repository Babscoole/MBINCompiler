namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD73F36F557B264E8, NameHash = 0x1B95D5FDE04FECD9)]
    public class GcMissionConditionRefinerActive : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A ActiveRecipe;
        [NMS(Index = 2)]
        /* 0x20 */ public int AmountToMake;
        [NMS(Index = 0)]
        /* 0x24 */ public bool HasFuel;
    }
}
