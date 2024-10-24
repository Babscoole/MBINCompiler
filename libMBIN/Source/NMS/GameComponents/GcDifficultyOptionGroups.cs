namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8F65E41AFFAD2F8C, NameHash = 0xA4D7D241)]
    public class GcDifficultyOptionGroups : NMSTemplate
    {
        // size: 0x4
        public enum DifficultyOptionGroupEnum : uint {
            Survival,
            Crafting,
            Combat,
            Ease,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DifficultyOptionGroupEnum DifficultyOptionGroup;
    }
}
