namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8A2194B184BA1590, NameHash = 0xFA340B19)]
    public class GcWeightingCurve : NMSTemplate
    {
        // size: 0x7
        public enum WeightingCurveEnum : uint {
            NoWeighting,
            MaxIsUncommon,
            MaxIsRare,
            MaxIsSuperRare,
            MinIsUncommon,
            MinIsRare,
            MinIsSuperRare,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WeightingCurveEnum WeightingCurve;
    }
}
