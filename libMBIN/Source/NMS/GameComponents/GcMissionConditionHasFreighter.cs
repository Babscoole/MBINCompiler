namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3FFE0FC90CC639, NameHash = 0xA0B37A86)]
    public class GcMissionConditionHasFreighter : NMSTemplate
    {
        // size: 0x3
        public enum FreighterInCurrentSystemEnum : uint {
            DontCare,
            Yes,
            No,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FreighterInCurrentSystemEnum FreighterInCurrentSystem;
    }
}
