namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDCFA575FE29DF1DD, NameHash = 0x57A99A9F)]
    public class GcShipMessage : NMSTemplate
    {
        // size: 0x2
        public enum MessageTypeEnum : uint {
            Leave,
            Fight,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MessageTypeEnum MessageType;
    }
}
