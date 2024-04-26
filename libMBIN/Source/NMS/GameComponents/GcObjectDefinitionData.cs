namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFCD04DEEE7D62DFD, NameHash = 0xF6BC04E88CDBB164)]
    public class GcObjectDefinitionData : NMSTemplate
    {
        // size: 0x4
        public enum LifeTypeEnum : uint {
            Rock,
            DryPlant,
            LushPlant,
            Artificial,
        }
        [NMS(Index = 6)]
        /* 0x00 */ public LifeTypeEnum LifeType;
        // size: 0x4
        public enum LocationTypeEnum : uint {
            AboveGround,
            UnderGround,
            WaterSurface,
            UnderWater,
        }
        [NMS(Index = 7)]
        /* 0x04 */ public LocationTypeEnum LocationType;
        // size: 0x6
        public enum ObjectAlignmentEnum : uint {
            Upright,
            SlightOffsetFromUpright,
            LargeOffsetFromUpright,
            ToNormal,
            SlightOffsetFromNormal,
            LargeOffsetFromNormal,
        }
        [NMS(Index = 8)]
        /* 0x08 */ public ObjectAlignmentEnum ObjectAlignment;
        // size: 0x3
        public enum ObjectCoverageTypeEnum : uint {
            Blanket,
            Cluster,
            Solo,
        }
        [NMS(Index = 5)]
        /* 0x0C */ public ObjectCoverageTypeEnum ObjectCoverageType;
        // size: 0x2
        public enum ObjectRenderTypeEnum : uint {
            Instanced,
            Single,
        }
        [NMS(Index = 1)]
        /* 0x10 */ public ObjectRenderTypeEnum ObjectRenderType;
        // size: 0x5
        public enum SizeClassEnum : uint {
            Tiny,
            Small,
            Medium,
            Large,
            Massive,
        }
        [NMS(Index = 4)]
        /* 0x14 */ public SizeClassEnum SizeClass;
        [NMS(Index = 0)]
        /* 0x18 */ public NMSString0x80 Filename;
        [NMS(Index = 2)]
        /* 0x98 */ public bool AutoCollision;
        [NMS(Index = 3)]
        /* 0x99 */ public bool MatchGroundColour;
    }
}
