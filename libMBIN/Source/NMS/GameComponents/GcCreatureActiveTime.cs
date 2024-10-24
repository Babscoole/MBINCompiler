namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x25FB62A959721723, NameHash = 0x1E3DFA8A)]
    public class GcCreatureActiveTime : NMSTemplate
    {
        // size: 0x5
        public enum CreatureActiveTimeEnum : uint {
            OnlyDay,
            MostlyDay,
            AnyTime,
            MostlyNight,
            OnlyNight,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CreatureActiveTimeEnum CreatureActiveTime;
    }
}
