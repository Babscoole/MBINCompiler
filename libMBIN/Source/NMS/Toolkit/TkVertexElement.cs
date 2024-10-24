namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE9C836BE3FD03AC9, NameHash = 0xC4D67634)]
    public class TkVertexElement : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public long PlatformData;
        // size: 0x2
        public enum InstancingEnum : uint {
            PerVertex,
            PerModel,
        }
        [NMS(Index = 5)]
        /* 0x08 */ public InstancingEnum Instancing;
        [NMS(Index = 4)]
        /* 0x0C */ public int Normalise;
        [NMS(Index = 3)]
        /* 0x10 */ public int Offset;
        [NMS(Index = 0)]
        /* 0x14 */ public int SemanticID;
        [NMS(Index = 1)]
        /* 0x18 */ public int Size;
        [NMS(Index = 2)]
        /* 0x1C */ public int Type;
    }
}
