using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1BAD324816BA6A1E, NameHash = 0x30CD85DD787F512A)]
    public class GcTileTypeSet : NMSTemplate
    {
        [NMS(Index = 1, Size = 0xC)]
        /* 0x00 */ public TkPaletteTexture[] Colours;
        [NMS(Index = 0)]
        /* 0x60 */ public float Probability;
    }
}
