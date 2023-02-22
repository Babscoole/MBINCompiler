using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4BE89D8B8314E3BD, NameHash = 0xC1A3BA40B3A88476)]
    public class TkActionButtonMap : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ActionId;
        /* 0x10 */ public bool ScaleToFitFont;
        /* 0x14 */ public TkInputEnum PadButtonId;
        /* 0x18 */ public List<TkPlatformButtonPair> Platforms;
    }
}
