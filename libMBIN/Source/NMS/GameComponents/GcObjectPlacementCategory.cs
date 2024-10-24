namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD8E71D1E344A2D0, NameHash = 0x48FE1D41)]
    public class GcObjectPlacementCategory : NMSTemplate
    {
        // size: 0x5
        public enum ObjectPlacementEnum : uint {
            None,
            ResourceSmall,
            ResourceMedium,
            ResourceLarge,
            ResourceDebris,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ObjectPlacementEnum ObjectPlacement;
    }
}
