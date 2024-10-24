using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x33DF3B54518AEEBE, NameHash = 0x57A67E4E)]
    public class GcByteBeatTemplate : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public List<GcByteBeatTemplate> Children;
        [NMS(Index = 3)]
        /* 0x10 */ public int MaxValue;
        [NMS(Index = 2)]
        /* 0x14 */ public int MinValue;
        [NMS(Index = 1)]
        /* 0x18 */ public GcByteBeatToken TokenType;
        [NMS(Index = 0)]
        /* 0x1C */ public float Weight;
    }
}
