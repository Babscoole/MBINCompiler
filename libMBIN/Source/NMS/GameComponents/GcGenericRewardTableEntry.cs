using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x65E997C3D51B3B4D, NameHash = 0xB457288101712FB5)]
    public class GcGenericRewardTableEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcRewardTableItemList List;
        [NMS(Index = 0)]
        /* 0x28 */ public NMSString0x10 Id;
    }
}
