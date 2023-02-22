using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD01E8D3C598026F4, NameHash = 0x5930542B7B565329)]
    public class GcRealityManagerData : NMSTemplate
    {
        /* 0x00000 */ public ushort HomeRealityIteration;
        /* 0x00002 */ public ushort RealityIteration;
        [NMS(Size = 0x11, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x00004 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x001E0 */ public float[] CreatureDiscoverySizeMultiplier;
        /* 0x001F0 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        /* 0x00200 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        /* 0x00400 */ public NMSString0x80 TechnologyTable;
        /* 0x00480 */ public NMSString0x80 SubstanceTable;
        /* 0x00500 */ public NMSString0x80 ProductTable;
        /* 0x00580 */ public NMSString0x80 ProceduralProductTable;
        /* 0x00600 */ public NMSString0x80 ProceduralTechnologyTable;
        /* 0x00680 */ public NMSString0x80 LegacyItemConversionTable;
        /* 0x00700 */ public List<TkRawID> LegacyRepairTable;
        /* 0x00710 */ public NMSString0x80 ConsumableItemTable;
        /* 0x00790 */ public NMSString0x80 RecipeTable;
        /* 0x00810 */ public NMSString0x80 StoriesTable;
        /* 0x00890 */ public NMSString0x80 DialogClearanceTable;
        /* 0x00910 */ public NMSString0x80 AlienWordsTable;
        /* 0x00990 */ public List<NMSString0x80> AlienPuzzleTables;
        [NMS(Size = 0x83, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x009A0 */ public bool[] LoopInteractionPuzzles;
        [NMS(Size = 0x83, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x00A24 */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        [NMS(Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x00C30 */ public TkCurveType[] WeightingCurves;
        /* 0x00C38 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        /* 0x00C48 */ public NMSString0x80 RewardTable;
        /* 0x00CC8 */ public NMSString0x80 DiscoveryRewardTable;
        /* 0x00D48 */ public NMSString0x80 InventoryTable;
        /* 0x00DC8 */ public NMSString0x80 DamageTable;
        /* 0x00E48 */ public NMSString0x80 PurchaseableBuildingBlueprintsTable;
        /* 0x00EC8 */ public NMSString0x80 PurchaseableSpecialsTable;
        /* 0x00F48 */ public NMSString0x80 UnlockableSeasonRewardsTable;
        /* 0x00FC8 */ public NMSString0x80 UnlockableTwitchRewardsTable;
        /* 0x01048 */ public NMSString0x80 UnlockablePlatformRewardsTable;
        /* 0x010C8 */ public NMSString0x80 CostTable;
        /* 0x01148 */ public NMSString0x80 TradingCostTable;
        /* 0x011C8 */ public NMSString0x80 TradingClassDataTable;
        /* 0x01248 */ public NMSString0x80 MaintenanceGroupsTable;
        /* 0x012C8 */ public NMSString0x80 UnlockableItemTrees;
        /* 0x01348 */ public NMSString0x80 SettlementPerksTable;
        /* 0x013C8 */ public NMSString0x80 PlayerWeaponPropertiesTable;
        /* 0x01448 */ public NMSString0x80 CombatEffectsTable;
        /* 0x014C8 */ public NMSString0x80 TechBoxTable;
        /* 0x01548 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x01558 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Size = 0x13, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x01718 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x01848 */ public TkIdArray[] DefaultVehicleLoadout;
        [NMS(Size = 0x9, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x018B8 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Size = 0x9, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x01948 */ public NMSString0x20A[] FactionNames;
        [NMS(Size = 0x9, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x01A68 */ public GcNumberedTextList[] FactionClients;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x01BAC */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x01D38 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x01EC4 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Size = 0xB, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x02050 */ public TkIdArray[] MissionBoardRewardOptions;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x02100 */ public float[] WeightedTextWeights;
        /* 0x02110 */ public GcRealityIconTable Icons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x080C0 */ public Colour[] HazardColours;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x08120 */ public Colour[] RarityColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x08150 */ public Colour[] SubstanceCategoryColours;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x081E0 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Size = 0xBD, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x08684 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Size = 0xBD, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x0E7F8 */ public TkTextureResource[] StatTechPackageIcons;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle,
        }
        [NMS(Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0x14970 */ public GcStats[] Stats;
        /* 0x149C0 */ public GcTechList StationTechShops;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x149D0 */ public GcTechList[] PlanetTechShops;
        /* 0x14AD0 */ public GcTradeSettings TradeSettings;
        /* 0x15CB0 */ public List<NMSString0x10> PirateStationExtraProds;
        /* 0x15CC0 */ public GcInventoryLayout SuitStartingSlotLayout;
        /* 0x15CE0 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        /* 0x15D00 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        /* 0x15D20 */ public GcInventoryLayout ShipStartingLayout;
        /* 0x15D40 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        /* 0x15D60 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        /* 0x15D80 */ public List<int> SuitUpgradePrices;
        /* 0x15D90 */ public List<int> SuitTechOnlyUpgradePrices;
        /* 0x15DA0 */ public List<int> SuitCargoUpgradePrices;
        /* 0x15DB0 */ public List<NMSString0x10> NeverSellableItems;
        /* 0x15DC0 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Size = 0x5)]
        /* 0x15DD0 */ public float[] NormalisedPriceLimits;
        /* 0x15DE8 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        /* 0x15DF8 */ public List<GcIDPair> FreighterBaseItemPairs;
        [NMS(Size = 0x5, EnumType = typeof(GcCatalogueGroups.CatalogueGroupEnum))]
        /* 0x15E08 */ public NMSString0x80[] Catalogues;
    }
}
