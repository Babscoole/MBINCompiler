namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D93A002C61202AA, NameHash = 0x29C73977774C3241)]
    public class GcStateTimeEvent : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float RandomSeconds;
        [NMS(Index = 0)]
        /* 0x4 */ public float Seconds;
        [NMS(Index = 2)]
        /* 0x8 */ public bool UseMissionClock;
    }
}
