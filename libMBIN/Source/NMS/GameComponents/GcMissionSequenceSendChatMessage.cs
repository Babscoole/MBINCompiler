namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE3079CC0394E99F2, NameHash = 0xFE8960194373227E)]
    public class GcMissionSequenceSendChatMessage : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A CustomText;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 StatusMessageId;
    }
}
