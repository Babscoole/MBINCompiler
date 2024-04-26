namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x95D7E51CBBB0370B, NameHash = 0x27C076F10CE0DEC2)]
    public class GcBlackboardValueDecoratorData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSTemplate Child;
        [NMS(Index = 0)]
        /* 0x50 */ public NMSString0x10 Key;
        [NMS(Index = 1)]
        /* 0x60 */ public bool ClearOnSuccess;
    }
}
