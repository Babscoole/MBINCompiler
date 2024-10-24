using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA44117CFCED4A89, NameHash = 0xE2296648)]
    public class GcMissionConditionSystemPlanetTest : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public GcBiomeType PlanetBiomeRequirement;
        [NMS(Index = 1)]
        /* 0x4 */ public GcPlayerHazardType PlanetWeatherRequirement;
        [NMS(Index = 0)]
        /* 0x8 */ public bool RequiresExtremePlanet;
    }
}
