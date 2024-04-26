using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x46D508F9992D3331, NameHash = 0x3454C9AB7AAC46D9)]
    public class GcGalaxySolarSystemParams : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcGalaxySolarSystemOrbitParams MoonParameters;
        [NMS(Index = 0)]
        /* 0x1C */ public GcGalaxySolarSystemOrbitParams PlanetParameters;
        [NMS(Index = 2, Size = 0x4, EnumType = typeof(GcPlanetSize.PlanetSizeEnum))]
        /* 0x38 */ public float[] PlanetRadii;
        [NMS(Index = 4)]
        /* 0x48 */ public float DefaultDistance;
        [NMS(Index = 6)]
        /* 0x4C */ public float NonVisitedPlanetAlpha;
        [NMS(Index = 3)]
        /* 0x50 */ public float SystemTilt;
        [NMS(Index = 5)]
        /* 0x54 */ public float VisitedPlanetAlpha;
    }
}
