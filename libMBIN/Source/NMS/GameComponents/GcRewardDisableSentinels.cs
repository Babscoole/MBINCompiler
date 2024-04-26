namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x800851CF8D9528D4, NameHash = 0x231FFA8B84C504B1)]
    public class GcRewardDisableSentinels : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A OSDMessage;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A WantedBarMessage;
        [NMS(Index = 0)]
        /* 0x40 */ public float Duration;
    }
}
