using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E931346CFC5A9A5, NameHash = 0x80953B08573D31B6)]
    public class GcCustomisationDescriptorGroup : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x000 */ public NMSString0x20A Tip;
        [NMS(Index = 1)]
        /* 0x020 */ public NMSString0x20A Title;
        [NMS(Index = 3)]
        /* 0x040 */ public List<NMSString0x20> Descriptors;
        [NMS(Index = 0)]
        /* 0x050 */ public NMSString0x10 GroupID;
        [NMS(Index = 5)]
        /* 0x060 */ public NMSString0x10 LinkedSpecialID;
        [NMS(Index = 4)]
        /* 0x070 */ public List<NMSString0x20> SuffixInclusionList;
        [NMS(Index = 2)]
        /* 0x080 */ public NMSString0x80 Image;
        [NMS(Index = 7)]
        /* 0x100 */ public bool HiddenInCustomiser;
    }
}
