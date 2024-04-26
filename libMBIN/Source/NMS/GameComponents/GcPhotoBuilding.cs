namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27529A5C3BAF0D45, NameHash = 0x2535C1B3F76633D)]
    public class GcPhotoBuilding : NMSTemplate
    {
        // size: 0xD
        public enum PhotoBuildingTypeEnum : uint {
            Shelter,
            Abandoned,
            Shop,
            Outpost,
            RadioTower,
            Observatory,
            Depot,
            Monolith,
            Factory,
            Portal,
            Ruin,
            MissionTower,
            LargeBuilding,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PhotoBuildingTypeEnum PhotoBuildingType;
    }
}
