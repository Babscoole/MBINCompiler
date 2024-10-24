namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF461E5617022E546, NameHash = 0x8711E4A9)]
    public class GcPlayerExperienceAsteroidCreatureSpawnData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 4)]
        /* 0x10 */ public Vector2f LargeMinMax;
        [NMS(Index = 3)]
        /* 0x18 */ public Vector2f MediumMinMax;
        [NMS(Index = 2)]
        /* 0x20 */ public Vector2f SmallMinMax;
        [NMS(Index = 1)]
        /* 0x28 */ public float Weight;
    }
}
