using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA9D290FD12C9A030, NameHash = 0xD679E7C47BC9313C)]
    public class GcCustomisationBannerGroup : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcPaletteData BackgroundColours;
        [NMS(Index = 1)]
        /* 0x410 */ public GcPaletteData MainColours;
        [NMS(Index = 4)]
        /* 0x820 */ public GcCustomisationColourPaletteExtraData BackgroundColoursExtraData;
        [NMS(Index = 2)]
        /* 0x840 */ public GcCustomisationColourPaletteExtraData MainColoursExtraData;
        [NMS(Index = 0)]
        /* 0x860 */ public List<GcCustomisationBannerImageData> BannerImages;
    }
}
