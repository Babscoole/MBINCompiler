namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC7EAA7B8B8B89D7, NameHash = 0x7C883BFCF9D557D5)]
    public class GcMissionCategory : NMSTemplate
    {
        // size: 0x4
        public enum MissionCategoryEnum {
            Info,
            Mission,
            Danger,
            Urgent,
        }
        /* 0x0 */ public MissionCategoryEnum MissionCategory;
    }
}
