namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA03F3B9092603FE, NameHash = 0xB67612C9)]
    public class GcDailyRecurrence : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int RecurrenceHour;
        [NMS(Index = 0)]
        /* 0x4 */ public int RecurrenceMinute;
        [NMS(Index = 2)]
        /* 0x8 */ public NMSString0x80 DebugText;
    }
}
