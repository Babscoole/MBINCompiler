namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8B954AFB7658126B, NameHash = 0x8F4800F7EA8399A7)]
    public class GcPlanetWeatherColourIndex : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int Index;
        // size: 0x2
        public enum WeatherColourSetEnum : uint {
            Common,
            Rare,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public WeatherColourSetEnum WeatherColourSet;
    }
}
