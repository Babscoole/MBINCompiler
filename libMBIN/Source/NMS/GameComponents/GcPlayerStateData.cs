using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEFC6D7CA1A742B52, NameHash = 0x6C4510BB243EFA64)]
    public class GcPlayerStateData : NMSTemplate
    {
        /* 0x00000 */ public GcUniverseAddressData UniverseAddress;
        /* 0x00018 */ public GcUniverseAddressData PreviousUniverseAddress;
        /* 0x00030 */ public int HomeRealityIteration;
        /* 0x00034 */ public NMSString0x80 SaveName;
        /* 0x000B4 */ public NMSString0x80 SaveSummary;
        /* 0x00134 */ public GcDifficultyStateData DifficultyState;
        /* 0x00198 */ public GcInventoryContainer Inventory;
        /* 0x002F0 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x00448 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x005A0 */ public GcInventoryContainer ShipInventory;
        /* 0x006F8 */ public GcInventoryContainer WeaponInventory;
        /* 0x00850 */ public List<GcInWorldUIScreenData> WristScreenData;
        [NMS(Size = 0x6)]
        /* 0x00860 */ public GcMultitoolData[] Multitools;
        /* 0x02420 */ public int ActiveMultioolIndex;
        /* 0x02428 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Size = 0x12)]
        /* 0x03E30 */ public GcPetData[] Pets;
        [NMS(Size = 0x12)]
        /* 0x06470 */ public GcPetData[] Eggs;
        [NMS(Size = 0x12)]
        /* 0x08AB0 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Size = 0x12)]
        /* 0x09D40 */ public bool[] UnlockedPetSlots;
        /* 0x09D58 */ public GcInventoryContainer GraveInventory;
        /* 0x09EB0 */ public bool SpawnGrave;
        /* 0x09EB1 */ public bool SpaceGrave;
        /* 0x09EB4 */ public GcUniverseAddressData GraveUniverseAddress;
        /* 0x09ED0 */ public Vector4f GravePosition;
        /* 0x09EE0 */ public Vector4f GraveMatrixLookAt;
        /* 0x09EF0 */ public Vector4f GraveMatrixUp;
        /* 0x09F00 */ public GcInventoryLayout ShipLayout;
        /* 0x09F20 */ public GcInventoryLayout WeaponLayout;
        /* 0x09F40 */ public GcResourceElement CurrentShip;
        /* 0x0A1E8 */ public GcExactResource CurrentWeapon;
        /* 0x0A278 */ public List<NMSString0x10> KnownTech;
        /* 0x0A288 */ public List<NMSString0x10> KnownProducts;
        /* 0x0A298 */ public List<NMSString0x10> KnownSpecials;
        /* 0x0A2A8 */ public List<NMSString0x20A> KnownRefinerRecipes;
        /* 0x0A2B8 */ public List<GcWordKnowledge> KnownWords;
        /* 0x0A2C8 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        /* 0x0A2D8 */ public List<GcPlayerMissionProgress> MissionProgress;
        /* 0x0A2E8 */ public int PostMissionIndex;
        /* 0x0A2F0 */ public NMSString0x10 CurrentMissionID;
        /* 0x0A300 */ public ulong CurrentMissionSeed;
        /* 0x0A308 */ public NMSString0x10 PreviousMissionID;
        /* 0x0A318 */ public ulong PreviousMissionSeed;
        /* 0x0A320 */ public int MissionVersion;
        /* 0x0A328 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        /* 0x0A340 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x0A360 */ public GcInteractionData HoloScepticInteraction;
        /* 0x0A380 */ public GcInteractionData HoloNooneInteraction;
        /* 0x0A3A0 */ public int Health;
        /* 0x0A3A4 */ public int ShipHealth;
        /* 0x0A3A8 */ public int Shield;
        /* 0x0A3AC */ public int ShipShield;
        /* 0x0A3B0 */ public int Energy;
        /* 0x0A3B4 */ public int Units;
        /* 0x0A3B8 */ public int Nanites;
        /* 0x0A3BC */ public int Specials;
        /* 0x0A3C0 */ public bool ThirdPersonShip;
        /* 0x0A3C8 */ public ulong TimeAlive;
        /* 0x0A3D0 */ public ulong TotalPlayTime;
        /* 0x0A3D8 */ public List<GcScanEventSave> MarkerStack;
        /* 0x0A3E8 */ public List<GcScanEventSave> NewMPMarkerStack;
        /* 0x0A3F8 */ public List<Vector3f> SurveyedEventPositions;
        /* 0x0A408 */ public int NextSurveyedEventPositionIndex;
        /* 0x0A410 */ public List<GcPlayerStatsGroup> Stats;
        /* 0x0A420 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Size = 0xB, EnumType = typeof(GcInteractionBufferType.InteractionBufferTypeEnum))]
        /* 0x0A430 */ public GcInteractionBuffer[] StoredInteractions;
        /* 0x0A538 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x0A548 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x0A558 */ public List<ulong> VisitedSystems;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0A568 */ public float[] Hazard;
        /* 0x0A580 */ public int BoltAmmo;
        /* 0x0A584 */ public int ScatterAmmo;
        /* 0x0A588 */ public int PulseAmmo;
        /* 0x0A58C */ public int LaserAmmo;
        /* 0x0A590 */ public Vector4f FirstSpawnPosition;
        [NMS(Size = 0x85, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0A5A0 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        /* 0x0BA68 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x0BA78 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Size = 0xA)]
        /* 0x0BA88 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x0BB78 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        /* 0x0BC80 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        /* 0x0BC90 */ public bool FirstAtlasStationDiscovered;
        /* 0x0BC91 */ public bool UsesThirdPersonCharacterCam;
        /* 0x0BC94 */ public int ProgressionLevel;
        /* 0x0BC98 */ public int ProcTechIndex;
        /* 0x0BC9C */ public bool IsNew;
        /* 0x0BC9D */ public bool UseSmallerBlackholeJumps;
        /* 0x0BCA0 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Size = 0x10)]
        /* 0x0BCB0 */ public Vector3f[] PlanetPositions;
        [NMS(Size = 0x10)]
        /* 0x0BDB0 */ public GcSeed[] PlanetSeeds;
        /* 0x0BEB0 */ public int PrimaryPlanet;
        /* 0x0BEB8 */ public ulong TimeLastSpaceBattle;
        /* 0x0BEC0 */ public int WarpsLastSpaceBattle;
        /* 0x0BEC8 */ public ulong ActiveSpaceBattleUA;
        /* 0x0BED0 */ public ulong TimeLastMiniStation;
        /* 0x0BED8 */ public int WarpsLastMiniStation;
        /* 0x0BEE0 */ public ulong MiniStationUA;
        /* 0x0BEF0 */ public Vector4f AnomalyPositionOverride;
        /* 0x0BF00 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x0BF18 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Size = 0x10)]
        /* 0x0BF30 */ public bool[] GalacticMapRequests;
        /* 0x0BF40 */ public Vector4f FirstShipPosition;
        /* 0x0BF50 */ public ulong HazardTimeAlive;
        /* 0x0BF58 */ public bool RevealBlackHoles;
        /* 0x0BF60 */ public GcSeed CurrentFreighterHomeSystemSeed;
        /* 0x0BF70 */ public GcResourceElement CurrentFreighter;
        /* 0x0C218 */ public GcInventoryLayout FreighterLayout;
        /* 0x0C238 */ public GcInventoryLayout FreighterCargoLayout;
        /* 0x0C258 */ public GcInventoryContainer FreighterInventory;
        /* 0x0C3B0 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x0C508 */ public GcInventoryContainer FreighterInventory_Cargo;
        /* 0x0C660 */ public ulong FreighterLastSpawnTime;
        /* 0x0C668 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x0C680 */ public bool FreighterDismissed;
        /* 0x0C690 */ public Vector3f FreighterMatrixAt;
        /* 0x0C6A0 */ public Vector3f FreighterMatrixUp;
        /* 0x0C6B0 */ public Vector3f FreighterMatrixPos;
        [NMS(Size = 0x4)]
        /* 0x0C6C0 */ public bool[] SquadronUnlockedPilotSlots;
        [NMS(Size = 0x4)]
        /* 0x0C6C8 */ public GcSquadronPilotData[] SquadronPilots;
        /* 0x0DC48 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        /* 0x0DC58 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x0DC70 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x4A3F0 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x4B250 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x4B260 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        /* 0x4B270 */ public GcInventoryLayout Chest1Layout;
        /* 0x4B290 */ public GcInventoryContainer Chest1Inventory;
        /* 0x4B3E8 */ public GcInventoryLayout Chest2Layout;
        /* 0x4B408 */ public GcInventoryContainer Chest2Inventory;
        /* 0x4B560 */ public GcInventoryLayout Chest3Layout;
        /* 0x4B580 */ public GcInventoryContainer Chest3Inventory;
        /* 0x4B6D8 */ public GcInventoryLayout Chest4Layout;
        /* 0x4B6F8 */ public GcInventoryContainer Chest4Inventory;
        /* 0x4B850 */ public GcInventoryLayout Chest5Layout;
        /* 0x4B870 */ public GcInventoryContainer Chest5Inventory;
        /* 0x4B9C8 */ public GcInventoryLayout Chest6Layout;
        /* 0x4B9E8 */ public GcInventoryContainer Chest6Inventory;
        /* 0x4BB40 */ public GcInventoryLayout Chest7Layout;
        /* 0x4BB60 */ public GcInventoryContainer Chest7Inventory;
        /* 0x4BCB8 */ public GcInventoryLayout Chest8Layout;
        /* 0x4BCD8 */ public GcInventoryContainer Chest8Inventory;
        /* 0x4BE30 */ public GcInventoryLayout Chest9Layout;
        /* 0x4BE50 */ public GcInventoryContainer Chest9Inventory;
        /* 0x4BFA8 */ public GcInventoryLayout Chest10Layout;
        /* 0x4BFC8 */ public GcInventoryContainer Chest10Inventory;
        /* 0x4C120 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x4C140 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x4C298 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x4C2B8 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x4C410 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x4C430 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x4C588 */ public GcInventoryLayout RocketLockerLayout;
        /* 0x4C5A8 */ public GcInventoryContainer RocketLockerInventory;
        /* 0x4C700 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x4C9B0 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x4FB90 */ public int PrimaryVehicle;
        [NMS(Size = 0xC)]
        /* 0x4FBA0 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x55120 */ public int PrimaryShip;
        /* 0x55124 */ public bool MultiShipEnabled;
        /* 0x55125 */ public bool VehicleAIControlEnabled;
        /* 0x55126 */ public NMSString0x20 PlayerFreighterName;
        /* 0x55150 */ public Vector4f StartGameShipPosition;
        /* 0x55160 */ public bool ShipNeedsTerrainPositioning;
        /* 0x55164 */ public int TradingSupplyDataIndex;
        /* 0x55168 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x55178 */ public List<GcPortalSaveData> LastPortal;
        /* 0x55188 */ public GcPortalSaveData VisitedPortal;
        /* 0x551A8 */ public int KnownPortalRunes;
        /* 0x551AC */ public bool OnOtherSideOfPortal;
        /* 0x551B0 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x55240 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x55250 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x55260 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x55264 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0x17, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x55268 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0xC)]
        /* 0x55A50 */ public bool[] ShipUsesLegacyColours;
        [NMS(Size = 0x3)]
        /* 0x55A60 */ public GcCharacterCustomisationData[] Outfits;
        /* 0x55B38 */ public NMSString0x10 JetpackEffect;
        /* 0x55B48 */ public NMSString0x10 FreighterEngineEffect;
        /* 0x55B58 */ public GcSeed FleetSeed;
        /* 0x55B68 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x55B78 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x55B88 */ public List<ulong> ExpeditionSeedsSelectedToday;
        /* 0x55B98 */ public ulong LastKnownDay;
        /* 0x55BA0 */ public ulong SunTimer;
        /* 0x55BA8 */ public ulong MultiplayerLobbyID;
        /* 0x55BB0 */ public GcUniverseAddressData MultiplayerUA;
        /* 0x55BD0 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x55CA0 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x55CB0 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x55CB8 */ public GcHotActionsSaveData[] HotActions;
        /* 0x56168 */ public ulong LastUABeforePortalWarp;
        /* 0x56170 */ public ulong StoryPortalSeed;
        /* 0x56178 */ public ushort ShopNumber;
        /* 0x5617A */ public ushort ShopTier;
        /* 0x5617C */ public bool HasAccessToNexus;
        /* 0x56180 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x561A0 */ public Vector3f NexusMatrixAt;
        /* 0x561B0 */ public Vector3f NexusMatrixUp;
        /* 0x561C0 */ public Vector3f NexusMatrixPos;
        /* 0x561D0 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x56220 */ public int BannerIcon;
        /* 0x56224 */ public int BannerMainColour;
        /* 0x56228 */ public int BannerBackgroundColour;
        /* 0x56230 */ public NMSString0x10 BannerTitleId;
        /* 0x56240 */ public int TelemetryUploadVersion;
        /* 0x56244 */ public bool UsesThirdPersonVehicleCam;
        /* 0x56248 */ public float VRCameraOffset;
        /* 0x56250 */ public GcSeasonalGameModeData SeasonData;
        /* 0x59720 */ public GcSeasonStateData SeasonState;
        /* 0x59778 */ public bool RestartAllInactiveSeasonalMissions;
        /* 0x59780 */ public List<NMSString0x10> RedeemedSeasonRewards;
        /* 0x59790 */ public List<NMSString0x10> RedeemedTwitchRewards;
        /* 0x597A0 */ public List<NMSString0x10> RedeemedPlatformRewards;
        [NMS(Size = 0x64)]
        /* 0x597B0 */ public GcSettlementState[] SettlementStatesV2;
        /* 0x78BB0 */ public int SettlementStateRingBufferIndexV2;
        /* 0x78BB4 */ public bool NextLoadSpawnsWithFreshStart;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x78BB8 */ public GcStoryPageSeenDataArray[] SeenStories;
        [NMS(Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x78C38 */ public GcWonderRecord[] WonderPlanetRecords;
        [NMS(Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x78D40 */ public GcWonderRecord[] WonderCreatureRecords;
        [NMS(Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x78EA8 */ public GcWonderRecord[] WonderFloraRecords;
        [NMS(Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x78F68 */ public GcWonderRecord[] WonderMineralRecords;
        [NMS(Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x79028 */ public GcWonderRecord[] WonderTreasureRecords;
        [NMS(Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x79160 */ public GcWonderRecord[] WonderWeirdBasePartRecords;
        [NMS(Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x79268 */ public GcWonderRecord[] WonderCustomRecords;
        [NMS(Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x79388 */ public GcWonderRecordCustomData[] WonderCustomRecordsExtraData;
        [NMS(Size = 0x4, EnumType = typeof(GcSynchronisedBufferType.SyncBufferTypeEnum))]
        /* 0x796B8 */ public GcSyncBufferSaveDataArray[] SyncBuffersData;
        /* 0x796F8 */ public List<GcMaintenanceSaveKey> RefinerBufferKeys;
        /* 0x79708 */ public List<GcMaintenanceContainer> RefinerBufferData;
    }
}
