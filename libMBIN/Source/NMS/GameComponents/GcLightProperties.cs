namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5ECAAC50617EAB79, NameHash = 0x34A4221AAD19DAAE)]
    public class GcLightProperties : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Colour BounceColour;
        [NMS(Index = 1)]
        /* 0x10 */ public Colour LightColour;
        [NMS(Index = 0)]
        /* 0x20 */ public Colour SunColour;
    }
}
