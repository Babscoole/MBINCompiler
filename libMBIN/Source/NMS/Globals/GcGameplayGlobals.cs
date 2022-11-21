using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x80A397BCC7D3308F, NameHash = 0x71CAF682B6986E6E)]
    public class GcGameplayGlobals : NMSTemplate
    {
        /* 0x0000 */ public GcDifficultyConfig DifficultyConfig;
        /* 0x2688 */ public NMSString0x10 PirateMissionPrimaryReward;
        /* 0x2698 */ public NMSString0x10 PirateMissionSecondReward;
        /* 0x26A8 */ public bool UseSecondaryBiomeSubstances;
        /* 0x26A9 */ public bool TechMustBeInTechInventory;
        /* 0x26AC */ public float SpecialTechSlotBonus;
        /* 0x26B0 */ public int RocketLockerFuelUse;
        /* 0x26B4 */ public bool EnableTechPackaging;
        /* 0x26B8 */ public float CargoShieldStrength;
        /* 0x26BC */ public float TechDamageChanceShieldedMax;
        /* 0x26C0 */ public float TechDamageChanceShieldLevelMin;
        /* 0x26C4 */ public float TechDamageChanceShieldLevelMax;
        /* 0x26C8 */ public float TechDamageChanceToSelectPrimary;
        /* 0x26CC */ public float PirateRaidAccelerator;
        /* 0x26D0 */ public float PirateGroundAccelerator;
        /* 0x26D4 */ public float PirateGroundInventoryAccelerator;
        /* 0x26D8 */ public float PoliceAcceleratorStationLockOn;
        /* 0x26DC */ public float PoliceAcceleratorPulseExtra;
        /* 0x26E0 */ public int PoliceAcceleratorSmugglingItemsMax;
        /* 0x26E4 */ public float PoliceAcceleratorSmugglingMulMax;
        /* 0x26E8 */ public float PoliceAcceleratorNoCargoWealthy;
        /* 0x26EC */ public float PoliceAcceleratorNoCargoNormal;
        /* 0x26F0 */ public float PoliceAcceleratorNoCargoSkipScanOdds;
        /* 0x26F4 */ public float ShipInterestAcceleratorInAsteroidField;
        /* 0x26F8 */ public float InfestedPlanetDeepSpaceFlybyMultiplier;
        /* 0x26FC */ public float SmugglerSellingMarkup;
        /* 0x2700 */ public float IllegalTechProductTradingMod;
        /* 0x2704 */ public float CombatLevelBestWeaponBias;
        /* 0x2708 */ public float CombatLevelBaseValueBoltcaster;
        /* 0x270C */ public float CombatLevelBaseValueShotgun;
        /* 0x2710 */ public float CombatLevelBaseValueRailgun;
        /* 0x2714 */ public float CombatLevelBaseValueSMG;
        /* 0x2718 */ public float CombatLevelBaseValueCannon;
        /* 0x271C */ public float CombatLevelBaseValueGrenade;
        /* 0x2720 */ public float CombatLevelSClassValue;
        /* 0x2728 */ public NMSString0x10 NexusRecipeCostType;
        /* 0x2738 */ public int NexusRecipeCostNaniteMultiplier;
        /* 0x273C */ public float ShipScanPlanetRechargeMultiplier;
        /* 0x2740 */ public float ShipScanSpaceRechargeMultiplier;
        /* 0x2748 */ public NMSString0x10 FreeSuitSlotID;
        /* 0x2758 */ public float InitialLocationProtectionRadiusMultiplier;
        /* 0x275C */ public float PartyPlanetSearchDistance;
        /* 0x2760 */ public float UnderwaterLightningDamageDistanceMultiplier;
        /* 0x2764 */ public int MaxActiveWeatherHazardGifts;
        /* 0x2768 */ public float WeatherHazardGiftMaxDistance;
        /* 0x276C */ public float WeatherHazardGiftLifeTime;
        /* 0x2770 */ public GcTechnologyCategory TechnologyOverrideForSmuggler;
        /* 0x2774 */ public float MaxMeteorSurfaceAngle;
        /* 0x2778 */ public float StormGravityChangeTime;
        /* 0x277C */ public float StormBonusJetpackMod;
        /* 0x2780 */ public float StormBonusSprintMod;
        /* 0x2784 */ public float StormBonusMiningHeatMod;
        /* 0x2788 */ public float StormBonusMiningAmountMod;
        /* 0x278C */ public GcPlayerHazardType StormBonusJetpackWeather;
        /* 0x2790 */ public GcPlayerHazardType StormBonusSprintWeather;
        /* 0x2794 */ public GcPlayerHazardType StormBonusMiningHeatWeather;
        /* 0x2798 */ public GcPlayerHazardType StormBonusMiningAmountWeather;
        /* 0x279C */ public float AlienPodThreshold2;
        /* 0x27A0 */ public float AlienPodThreshold1;
        /* 0x27B0 */ public Colour BulletTraceLineColour;
        /* 0x27C0 */ public float BulletTraceLineWidth;
        /* 0x27C4 */ public float ShipBulletTraceLineWidth;
        /* 0x27C8 */ public float VehicleAllIconScanTime;
        /* 0x27CC */ public int GPSRandomChangeTimeWide;
        /* 0x27D0 */ public int GPSRandomChangeTimeMid;
        /* 0x27D4 */ public int GPSRandomChangeTimeNarrow;
        /* 0x27D8 */ public float SalvageValueAsProds;
        /* 0x27DC */ public int SalvageSubstanceValueThreshold;
        [NMS(Size = 0x4)]
        /* 0x27E0 */ public NMSString0x10[] SalvageRewardsShuttle;
        [NMS(Size = 0x4)]
        /* 0x2820 */ public NMSString0x10[] SalvageRewardsDropship;
        [NMS(Size = 0x4)]
        /* 0x2860 */ public NMSString0x10[] SalvageRewardsFighter;
        [NMS(Size = 0x4)]
        /* 0x28A0 */ public NMSString0x10[] SalvageRewardsScience;
        [NMS(Size = 0x5)]
        /* 0x28E0 */ public NMSString0x10[] SalvageTechList;
        /* 0x2930 */ public List<NMSString0x10> SalvageProdsList;
        /* 0x2940 */ public List<NMSString0x10> SalvageSubstancesList;
        /* 0x2950 */ public bool AlwaysSpaceBattle;
        /* 0x2954 */ public float MultidimensionalFadeTime;
        /* 0x2958 */ public float TeleporterDistanceTravelledMultiplier;
        /* 0x2960 */ public GcScanEffectData BinocularSelectedEffect;
        /* 0x29B0 */ public Colour BinocularSelectedColour;
        /* 0x29C0 */ public Colour BinocularSelectedUnknownColour;
        /* 0x29D0 */ public float CockpitScale;
        /* 0x29D4 */ public float MaxDistanceForLadderTeleport;
        /* 0x29D8 */ public float AngleFromBaseComputerWhenTeleporting;
        /* 0x29DC */ public float DistanceFromBaseComputerWhenTeleporting;
        /* 0x29E0 */ public float AutoTranslateWordChance;
        /* 0x29E4 */ public bool MissionSurveySuggestSurveyForNearScannables;
        /* 0x29E8 */ public float MissionSurveyMaxGuidanceDistance;
        /* 0x29EC */ public float MissionSurveyMaxGuidanceDistanceWorms;
        /* 0x29F0 */ public NMSString0x10 MissionSurveyWormID;
        /* 0x2A00 */ public float MissionSurveyMarkerAutoHideTime;
        /* 0x2A04 */ public float MissionSurveyScanRangeMultiplier;
        /* 0x2A08 */ public float MissionSurveyMaxScanAngle;
        /* 0x2A0C */ public float MissionSurveyMaxScanAngleScannableComp;
        /* 0x2A10 */ public float MissionSurveyBeginScanPercentageScannable;
        /* 0x2A14 */ public float MissionSurveyBeginScanPercentageEvent;
        /* 0x2A18 */ public float MissionSurveyScanSpeed;
        /* 0x2A1C */ public float MissionSurveyScanSpeedScannableComp;
        /* 0x2A20 */ public float MissionSurveyRevealWithoutScanDistance;
        /* 0x2A24 */ public float MissionSurveyAutoScanDistance;
        /* 0x2A28 */ public float MissionSurveyAutoScanFlattenRadiusMul;
        /* 0x2A2C */ public float MissionSurveySonarMinPulseSpeed;
        /* 0x2A30 */ public float MissionSurveySonarMaxPulseSpeed;
        /* 0x2A34 */ public float MissionSurveySonarPulseSpeedBandCount;
        /* 0x2A38 */ public float MissionSurveyMaxAngleOffset;
        /* 0x2A3C */ public float MissionSurveyMaxSignalConeAngle;
        /* 0x2A40 */ public float MissionSurveyInShipArrivedDistance;
        /* 0x2A44 */ public float SurveyBeginScanPercentage;
        /* 0x2A48 */ public float SurveyScanMinSpeed;
        /* 0x2A4C */ public float SurveyScanMaxSpeed;
        /* 0x2A50 */ public float SurveySonarPulseSpeedBandCount;
        /* 0x2A54 */ public float SurveySonarMinPulseSpeed;
        /* 0x2A58 */ public float SurveySonarMaxPulseSpeed;
        /* 0x2A5C */ public float SurveySonarMiddleRangeMin;
        /* 0x2A60 */ public float SurveySonarMiddleRangeMax;
        /* 0x2A64 */ public float SurveyMaxDistance;
        /* 0x2A68 */ public int CreaturesToBaitForTutorial;
        /* 0x2A6C */ public int CreaturesToFeedForTutorial;
        /* 0x2A70 */ public bool DisableGalaxyMapInQuickMenu;
        /* 0x2A71 */ public bool DisableNexusInQuickMenu;
        /* 0x2A72 */ public bool EnableTeleporters;
        /* 0x2A73 */ public bool AllowSpaceScanEvents;
        /* 0x2A74 */ public bool CanMoveTechnology;
        /* 0x2A78 */ public float NormalModeHeatBonus;
        /* 0x2A7C */ public float BaseLaserHeatTime;
        /* 0x2A80 */ public float HeatAlertTime;
        /* 0x2A84 */ public float HeatDamageBoost;
        /* 0x2A88 */ public float HeatWidthBoost;
        /* 0x2A8C */ public float HeatWidthBoostAlt;
        /* 0x2A90 */ public float OverheatGenerosity;
        /* 0x2A94 */ public float HeatMaxPowerPoint;
        /* 0x2A98 */ public float OverheatDecay;
        /* 0x2A9C */ public TkCurveType OverheatCurve;
        /* 0x2AA0 */ public bool UseOverheatColour;
        /* 0x2AB0 */ public Colour OverHeatColour;
        /* 0x2AC0 */ public Colour OverHeatBarColour;
        /* 0x2AD0 */ public TkCurveType OverheatColourCurveShip;
        /* 0x2AD4 */ public TkCurveType OverheatColourCurve;
        /* 0x2AD8 */ public int RefinerProductsMadeInTime;
        /* 0x2ADC */ public int RefinerSubsMadeInTime;
        /* 0x2AE0 */ public int RefinerProductsMadeInTimeSurvival;
        /* 0x2AE4 */ public int RefinerSubsMadeInTimeSurvival;
        /* 0x2AE8 */ public List<NMSString0x10> HyperdriveAccess;
        /* 0x2AF8 */ public List<NMSString0x10> FreighterHyperdriveAccess;
        /* 0x2B08 */ public float SeasonalMessageModuleAttractDistanceMul;
        /* 0x2B0C */ public float HmdInteractionRangeMinRange;
        /* 0x2B10 */ public float HmdInteractionRangeMinDistance;
        /* 0x2B14 */ public float HmdInteractionRangeMultiplier;
        /* 0x2B18 */ public bool InstallTechWithInteraction;
        /* 0x2B19 */ public bool FreighterRequiresRGBHyperdriveUpgrades;
        /* 0x2B1A */ public bool DisableAnomalyAmbientSpawn;
        /* 0x2B1B */ public bool AllowDeconstruct;
        /* 0x2B1C */ public bool AllowBinocularMarker;
        /* 0x2B1D */ public bool EveryMaintenanceIsBroken;
        /* 0x2B1E */ public bool SpawnResourceBlobsOnPartDelete;
        /* 0x2B1F */ public bool EnableShootHitEffect;
        /* 0x2B20 */ public int MaxNumSameGroupTech;
        /* 0x2B24 */ public float ShootableArmourHighlightHitTime;
        /* 0x2B28 */ public float ShootableAggroMinStartTime;
        /* 0x2B2C */ public float ShootableAggroForgetTime;
        /* 0x2B30 */ public Colour RefinerColour1A;
        /* 0x2B40 */ public Colour RefinerColour1B;
        /* 0x2B50 */ public Colour RefinerColour1C;
        /* 0x2B60 */ public Colour RefinerColour1D;
        /* 0x2B70 */ public float AtmosphereEntryTime;
        /* 0x2B74 */ public float AtmosphereEntryFadeTimeFactor;
        /* 0x2B78 */ public float AtmosphereEntryOffset;
        /* 0x2B7C */ public TkCurveType AtmosphereEntryCurve;
        /* 0x2B80 */ public float AtmosphereEntryErrorTime;
        /* 0x2B84 */ public int AsteroidScanMaxShown;
        /* 0x2B88 */ public float AsteroidScanTime;
        /* 0x2B8C */ public float AsteroidScanRange;
        /* 0x2B90 */ public float TerrainResourceScanTime;
        /* 0x2B94 */ public float TerrainResourceScanRange;
        /* 0x2B98 */ public float TerrainResourceCompassRange;
        /* 0x2B9C */ public bool BinocsDisplayUnknownCreatures;
        /* 0x2BA0 */ public float BinocularScanTargetMinHeight;
        /* 0x2BA4 */ public float BinocularScanTargetHeightRange;
        /* 0x2BA8 */ public float BinocTimeBeforeScan;
        /* 0x2BAC */ public float BinocMinScanTime;
        /* 0x2BB0 */ public float BinocScanTime;
        /* 0x2BB4 */ public float BinocCreatureScanTime;
        /* 0x2BB8 */ public TkCurveType BinocularScanTargetHeightCurve;
        /* 0x2BBC */ public float BinocularScanTargetInitialFadeTime;
        /* 0x2BC0 */ public float BinocularScanTargetScaler;
        /* 0x2BC4 */ public float BinocularScanTargetLineWidth;
        /* 0x2BC8 */ public float BinocularScanTargetFadeTime;
        /* 0x2BD0 */ public Colour BinocularScanTargetColour;
        /* 0x2BE0 */ public GcScanEffectData BinocularScanEffect;
        /* 0x2C30 */ public float ScannerIconsClumpRadius;
        /* 0x2C34 */ public float ScannableComponentMarkerOffset;
        /* 0x2C38 */ public float ScannableComponentPlaceMarkerOffset;
        /* 0x2C3C */ public float MissionEventAllowResetDistance;
        /* 0x2C40 */ public float AllRecipesKnownNanitesMin;
        /* 0x2C44 */ public float AllRecipesKnownNanitesMax;
        /* 0x2C48 */ public float MaxPossibleShipDamagePotential;
        /* 0x2C4C */ public float BuildingPlayerBaseIconOffset;
        /* 0x2C50 */ public float CriticalHitMultiplier;
        /* 0x2C54 */ public float HitEffectMinTime;
        /* 0x2C58 */ public float GrabPlayerCooldownTime;
        /* 0x2C5C */ public float TapInteractionIncreaseAmount;
        /* 0x2C60 */ public float TapInteractionDecay;
        /* 0x2C70 */ public GcScanEffectData DeconstructEffect;
        /* 0x2CC0 */ public GcScanEffectData HitEffect;
        /* 0x2D10 */ public GcScanEffectData HitEffectCritical;
        /* 0x2D60 */ public float CommunicatorSpawnOffset;
        /* 0x2D64 */ public float CommunicatorSpawnHeightOffset;
        /* 0x2D70 */ public Vector3f CommunicatorShipSpawnOffset;
        /* 0x2D80 */ public float CommunicatorSpawnScale;
        /* 0x2D84 */ public float CommunicatorSpawnRotation;
        /* 0x2D88 */ public float CommunicatorCargoScanDroneScale;
        /* 0x2D8C */ public float CommunicatorCargoScanDroneScaleFallback;
        /* 0x2D90 */ public float CommunicatorCargoScanDroneUpOffset;
        /* 0x2D94 */ public float CommunicatorCargoScanDroneUpOffsetFallback;
        /* 0x2D98 */ public float CommunicatorCargoScanDroneAtOffsetFallback;
        /* 0x2D9C */ public float CommunicatorCargoScanDronePitch;
        /* 0x2DA0 */ public float CommunicatorCargoScanDroneRoll;
        /* 0x2DA4 */ public float CommunicatorCargoScanDroneYaw;
        /* 0x2DA8 */ public float CommunicatorFadeTime;
        /* 0x2DB0 */ public List<GcScanEffectData> CommunicatorEffectTable;
        /* 0x2DC0 */ public int MaxNumMissionsFromMissionGiver;
        /* 0x2DC4 */ public float InteractionMinTimeBeforeHighlightedOptionSelection;
        /* 0x2DC8 */ public float InteractionMinTimeBetweenStickOptionHighlights;
        /* 0x2DCC */ public float InteractionStickOptionStrength;
        /* 0x2DD0 */ public float InteractionMessageModuleDisplayTime;
        /* 0x2DD4 */ public float InteractionAttractTime;
        /* 0x2DD8 */ public float InteractionDescriptionTextTime;
        /* 0x2DDC */ public float InteractionMinTimeForResponseText;
        /* 0x2DE0 */ public bool InteractionOverride;
        /* 0x2DE4 */ public GcInteractionType InteractionOverrideFrom;
        /* 0x2DE8 */ public GcInteractionType InteractionOverrideTo;
        /* 0x2DEC */ public float DestroyEffectHeight;
        /* 0x2DF0 */ public float DestroyEffectMaxScale;
        /* 0x2DF4 */ public float EventTargetSpeed;
        /* 0x2DF8 */ public int SpecialMiningAmount;
        /* 0x2DFC */ public float SpecialMiningTime;
        /* 0x2E00 */ public int HardModeTechDamageMidNum;
        /* 0x2E04 */ public int HardModeTechDamageMidPercent;
        /* 0x2E08 */ public int HardModeTechDamageHighPercent;
        /* 0x2E0C */ public int EarlyPiratesToBeKilled;
        /* 0x2E10 */ public int PlanetPirateFlybyMaxRepeatCounter;
        /* 0x2E14 */ public int PirateInterestOverride;
        /* 0x2E18 */ public float PirateInterestDistance;
        /* 0x2E1C */ public float PirateInterestDistanceMPMission;
        [NMS(Size = 0x3)]
        /* 0x2E20 */ public int[] PirateInterestLevels;
        [NMS(Size = 0x3)]
        /* 0x2E2C */ public int[] PirateInterestLevelsSurvival;
        /* 0x2E38 */ public int PoliceInterestOverride;
        /* 0x2E3C */ public float PoliceInterestDistance;
        /* 0x2E40 */ public float PoliceInterestDistanceMPMission;
        [NMS(Size = 0x3)]
        /* 0x2E44 */ public int[] PoliceInterestLevels;
        [NMS(Size = 0x3)]
        /* 0x2E50 */ public int[] PoliceInterestLevelsSurvival;
        /* 0x2E5C */ public float SpaceCombatRadius;
        /* 0x2E60 */ public int WarpsBetweenBattles;
        /* 0x2E64 */ public float HoursBetweenBattles;
        /* 0x2E68 */ public float SpaceBattleRadius;
        /* 0x2E6C */ public float SpaceBattleAnyHostileShipsRadius;
        /* 0x2E70 */ public float FreighterBattleRadius;
        /* 0x2E74 */ public float MissileMaxTurnAngle;
        /* 0x2E78 */ public float MissileLockTime;
        /* 0x2E7C */ public float MissileReloadTime;
        /* 0x2E80 */ public float MissileRotateMin;
        /* 0x2E84 */ public float MissileRotateMax;
        /* 0x2E88 */ public float MissileMaxSpeed;
        /* 0x2E8C */ public float MissileForceMin;
        /* 0x2E90 */ public float MissileForceMax;
        /* 0x2E94 */ public float MissileBrakeForceMin;
        /* 0x2E98 */ public float MissileBrakeForceMax;
        /* 0x2E9C */ public float MissileThreatTime;
        /* 0x2EA0 */ public float MissileBrakeTime;
        /* 0x2EA4 */ public float MissileHitRadius;
        /* 0x2EA8 */ public float MissileOffset;
        /* 0x2EAC */ public float MissileMinCircleTime;
        /* 0x2EB0 */ public float MissileApproachTime;
        /* 0x2EB4 */ public float MissileRotateSpeed;
        /* 0x2EB8 */ public float ScanStartTimeDelayMinDist;
        /* 0x2EBC */ public float ScanStartTimeDelayRange;
        /* 0x2EC0 */ public float ScanStartTimeDistanceDelayTime;
        /* 0x2EC4 */ public float ScanStickyDecay;
        /* 0x2EC8 */ public float CreatureScanStickyDecay;
        /* 0x2ECC */ public float CreatureScanAngle;
        /* 0x2ED0 */ public float CreatureMinScanTime;
        /* 0x2ED4 */ public float ScanAngle;
        /* 0x2ED8 */ public float NewDiscoveryDisplayTime;
        /* 0x2EDC */ public bool FailToFindBuildings;
        /* 0x2EE0 */ public float WaterLandingDamageMultiplier;
        /* 0x2EE4 */ public int CritDamage;
        /* 0x2EE8 */ public float CritScale;
        /* 0x2EEC */ public int NumMissionsPerSolarSystem;
        /* 0x2EF0 */ public float EmergencyBuildingScanEventDistance;
        /* 0x2EF4 */ public float EmergencyBuildingScanEventTime;
        /* 0x2EF8 */ public float ProjectileLightIntensity;
        /* 0x2EFC */ public float AggressiveSentinelProbability;
        /* 0x2F00 */ public float AggressiveSentinelProbabilitySurvival;
        /* 0x2F04 */ public float LowSentinelProbability;
        /* 0x2F08 */ public float LowSentinelProbabilitySurvival;
        /* 0x2F0C */ public float NonAggressiveLushSurvivalProbabability;
        /* 0x2F10 */ public int MaxDronesLow;
        /* 0x2F14 */ public int MaxDronesLowSurvival;
        /* 0x2F18 */ public int MaxDronesNormal;
        /* 0x2F1C */ public int MaxDronesNormalSurvival;
        /* 0x2F20 */ public int MaxDronesAggressive;
        /* 0x2F24 */ public int MaxDronesAggressiveSurvival;
        /* 0x2F28 */ public GcExperienceTimers SentinelTimersLow;
        /* 0x2F48 */ public GcExperienceTimers SentinelTimersNormal;
        /* 0x2F68 */ public int FreighterStartPecent;
        /* 0x2F6C */ public GcExperienceTimers FreighterTimers;
        /* 0x2F8C */ public GcExperienceTimers PlanetPirateTimers;
        /* 0x2FAC */ public GcExperienceTimers SpacePirateTimers;
        /* 0x2FD0 */ public List<float> PirateEarlySpawnChances;
        /* 0x2FE0 */ public float PirateEarlySpawnTime;
        /* 0x2FE4 */ public GcExperienceTimers FlybyTimers;
        /* 0x3004 */ public GcExperienceTimers SpaceFlybyTimers;
        /* 0x3024 */ public GcExperienceTimers PoliceTimers;
        [NMS(Size = 0x6)]
        /* 0x3044 */ public int[] FreighterTechQualityWeightings;
        /* 0x305C */ public int SentinelsHigh;
        /* 0x3060 */ public int SentinelsLow;
        /* 0x3064 */ public float AsteroidHitForce;
        /* 0x3068 */ public float AsteroidTorqueForce;
        /* 0x306C */ public float AsteroidCarveRadius;
        /* 0x3070 */ public int DeathMoneyPenalty;
        /* 0x3074 */ public int MaxResourceCrystalBlobSize;
        /* 0x3078 */ public float BuildingBeamDistance;
        /* 0x307C */ public float WaypointScanTime;
        /* 0x3080 */ public int RareSubstanceEffectiveness;
        /* 0x3084 */ public int CommonProductEffectiveness;
        /* 0x3088 */ public int RareProductEffectiveness;
        /* 0x308C */ public int AsteroidResourceReducer;
        /* 0x3090 */ public int TunnelStatReducer;
        /* 0x3094 */ public float VoxelAsteroidResourceChance;
        /* 0x3098 */ public int ResourceReducer;
        /* 0x309C */ public int ResourceMinAmount;
        /* 0x30A0 */ public int ResourceMaxAmount;
        /* 0x30A4 */ public int ResourceCommonReducer;
        /* 0x30A8 */ public int ResourceCommonMinAmount;
        /* 0x30AC */ public int ResourceCommonMaxAmount;
        /* 0x30B0 */ public int ResourceDirtReducer;
        /* 0x30B4 */ public int ResourceDirtMinAmount;
        /* 0x30B8 */ public int ResourceDirtMaxAmount;
        /* 0x30C0 */ public NMSString0x10 ResourceDirtSubstanceID;
        /* 0x30D0 */ public NMSString0x10 SandwormTerrainResource;
        /* 0x30E0 */ public NMSString0x10 BioShipTerrainResource;
        /* 0x30F0 */ public NMSString0x20 RobotResource;
        /* 0x3110 */ public NMSString0x20 DepotResource;
        /* 0x3130 */ public float DockNodeBuyRadius;
        /* 0x3134 */ public float BeaconInteractRange;
        /* 0x3138 */ public float ShipInteractRadius;
        /* 0x313C */ public GcResourceCollectEffect AsteroidResourceCollect;
        /* 0x3170 */ public float ScanAngleCutoff;
        /* 0x3174 */ public GcScanData ToolScan;
        /* 0x3188 */ public GcScanData ToolScanHardMode;
        /* 0x319C */ public GcScanData WaypointScan;
        /* 0x31B0 */ public GcScanData BeaconScan;
        /* 0x31C4 */ public GcScanData RadioTowerScan;
        /* 0x31D8 */ public GcScanData ObservatoryScan;
        /* 0x31EC */ public GcScanData DistressSignalScan;
        /* 0x3200 */ public GcScanData DebugScanPlanet;
        /* 0x3214 */ public GcScanData DebugScanSpace;
        /* 0x3228 */ public GcScanData ShipScan;
        /* 0x323C */ public GcScanData VisualScan;
        /* 0x3250 */ public float ZoomFindBuildingRange;
        /* 0x3254 */ public float TimeToDisplayScanResults;
        /* 0x3258 */ public float HoverTimeToScan;
        /* 0x325C */ public float HoverTimeToScanCreatures;
        /* 0x3260 */ public int HoverVisiblePointsNeeded;
        /* 0x3268 */ public List<GcZoomData> ZoomLevels;
        /* 0x3280 */ public GcScanEffectData PassiveScanEffect;
        /* 0x32D0 */ public GcScanEffectData BuildingScanEffect;
        /* 0x3320 */ public GcScanEffectData TargetShipScanEffect;
        /* 0x3370 */ public GcScanEffectData HUDShipScanEffect;
        /* 0x33C0 */ public GcScanEffectData CreatureScanEffect;
        /* 0x3410 */ public GcScanEffectData ObjectsScanEffect;
        /* 0x3460 */ public GcScanEffectData VRGhostScanEffect;
        /* 0x34B0 */ public GcScanEffectData BlankScanEffect;
        /* 0x3500 */ public GcScanEffectData BaseBuildingValidScanEffect;
        /* 0x3550 */ public GcScanEffectData BaseBuildingPreviewSelectionScanEffect;
        /* 0x35A0 */ public GcScanEffectData BaseBuildingSelectionScanEffect;
        /* 0x35F0 */ public GcScanEffectData BaseBuildingDeleteScanEffect;
        /* 0x3640 */ public GcScanEffectData BaseBuildingGhostScanEffect;
        /* 0x3690 */ public GcScanEffectData BaseBuildingSpawnStaticEffect;
        /* 0x36E0 */ public GcScanEffectData BaseBuildingVisionScanEffect;
        /* 0x3730 */ public GcScanEffectData BaseBuildingErrorInsideScanEffect;
        /* 0x3780 */ public GcScanEffectData BaseBuildingErrorCollisionScanEffect;
        /* 0x37D0 */ public GcScanEffectData BaseBuildingErrorImpossibleScanEffect;
        /* 0x3820 */ public GcScanEffectData BaseBuildingErrorUnaffordableScanEffect;
        /* 0x3870 */ public GcScanEffectData BaseBuildingErrorAboveWaterScanEffect;
        /* 0x38C0 */ public GcScanEffectData BaseBuildingErrorBelowWaterScanEffect;
        /* 0x3910 */ public GcScanEffectData BaseBuildingRemotePlayerValidScanEffect;
        /* 0x3960 */ public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect;
        /* 0x39B0 */ public float BaseBuildingRemotePlayerErrorAlphaScanEffect;
        /* 0x39B4 */ public bool UseDebugScan;
        /* 0x39B5 */ public bool DebugScanForceBuilding;
        /* 0x39B8 */ public GcBuildingClassification DebugScanForceBuildingType;
        /* 0x39BC */ public float ShipScanOffset;
        /* 0x39C0 */ public float ShipScanOffsetGap;
        /* 0x39C4 */ public TkCurveType ShipScanCurve;
        /* 0x39C8 */ public float ScannerMarkerFadeTime;
        /* 0x39CC */ public float ScannerSmallMarkerFadeTime;
        /* 0x39D0 */ public float ScannerPhysicsProbeAABBSize;
        /* 0x39D4 */ public float ScannerAnalyzeFXRate;
        /* 0x39D8 */ public float ScannerSubstanceTimePerTrigger;
        /* 0x39DC */ public float ScannerTuningA;
        /* 0x39E0 */ public float ScannerTuningB;
        /* 0x39E4 */ public float ScannerTuningC;
        /* 0x39E8 */ public float ScannerTuningD;
        /* 0x39EC */ public float ScannerTuningResourceOffset1;
        /* 0x39F0 */ public float ScannerTuningResourceOffset2;
        /* 0x39F4 */ public float ScannerTuningSmoothStepAmount;
        /* 0x39F8 */ public float ScannerTuningTrailingEdge;
        /* 0x39FC */ public bool Autolevel;
        /* 0x3A00 */ public Colour ScannerColour1;
        /* 0x3A10 */ public Colour ScannerColour2;
        /* 0x3A20 */ public float HUDStoreFlashTime;
        /* 0x3A24 */ public float ExcitingViewAngle;
        /* 0x3A28 */ public float ExcitingViewRange;
        /* 0x3A2C */ public float ExcitingNearRange;
        /* 0x3A30 */ public float ProjectileSpeedBoost;
        /* 0x3A34 */ public float LineWidth;
        /* 0x3A38 */ public float LockOffFactor;
        /* 0x3A3C */ public float OffscreenFadeDistance;
        /* 0x3A40 */ public float OffscreenMinDot;
        /* 0x3A44 */ public bool HUDUpdateFromData;
        /* 0x3A48 */ public float HUDLockOnAudioTime;
        /* 0x3A4C */ public float HUDArrowPrimaryScaler;
        /* 0x3A50 */ public Vector2f HUDDamageSize;
        /* 0x3A58 */ public Vector2f HUDDamageSplatSize;
        /* 0x3A60 */ public Colour HUDDamageSplatShieldColour;
        /* 0x3A70 */ public Colour HUDDamageSplatPainColour;
        /* 0x3A80 */ public float HUDDamageOffset;
        /* 0x3A84 */ public float HUDDamageScaler;
        /* 0x3A88 */ public float HUDDamageRadius;
        /* 0x3A90 */ public GcShipHUDTargetData HUDTarget;
        /* 0x3EC0 */ public float HUDLabelTime;
        /* 0x3EC4 */ public float HUDLabelAngle;
        /* 0x3EC8 */ public float HUDLabelAngleOffset;
        /* 0x3ECC */ public float HUDLabelOffsetX;
        /* 0x3ED0 */ public float HUDLabelOffsetY;
        /* 0x3ED4 */ public float HUDLabelOffsetZ;
        /* 0x3ED8 */ public float HUDLabelScale;
        /* 0x3EDC */ public bool PlayHitEffectsOnZeroDamage;
        /* 0x3EE0 */ public float MaxSpawnTime;
        /* 0x3EE4 */ public NMSString0x80 ResourceParticleFile;
        /* 0x3F64 */ public float ResourceParticleSpeed;
        /* 0x3F68 */ public float ResourceParticleSpread;
        /* 0x3F6C */ public int ResourceParticleMaxNum;
        /* 0x3F70 */ public int ResourceParticleMinNum;
        /* 0x3F74 */ public float MapHeight;
        /* 0x3F78 */ public float MapOffset;
        /* 0x3F7C */ public float MapTargetOffset;
        /* 0x3F80 */ public float MapFOV;
        /* 0x3F84 */ public float MapRadius;
        /* 0x3F88 */ public float HUDScaleAdd;
        /* 0x3F8C */ public float HUDScaleRadius;
        /* 0x3F90 */ public float HUDScaleMin;
        /* 0x3F94 */ public float HUDScaleMinAim;
        /* 0x3F98 */ public float HUDScaleMax;
        /* 0x3F9C */ public float HUDScaleFarTarget;
        /* 0x3FA0 */ public float HUDReticuleMoveBack;
        /* 0x3FA4 */ public float HUDReticuleMoveAim;
        /* 0x3FA8 */ public float MouseSensitivity;
        /* 0x3FAC */ public float MouseSensitivityShip;
        /* 0x3FB0 */ public float MouseSensitivityVehicle;
        /* 0x3FB4 */ public float PainTime;
        /* 0x3FB8 */ public TkCurveType PainCurve;
        /* 0x3FC0 */ public Colour PainColour;
        /* 0x3FD0 */ public float GunOffsetX;
        /* 0x3FD4 */ public float GunOffsetY;
        /* 0x3FD8 */ public float GunOffsetZ;
        /* 0x3FDC */ public float GunOffsetAggressiveX;
        /* 0x3FE0 */ public float GunOffsetAggressiveY;
        /* 0x3FE4 */ public float GunOffsetAggressiveZ;
        /* 0x3FE8 */ public float GunDownAngle;
        /* 0x3FEC */ public float GunUpAngle;
        /* 0x3FF0 */ public float BarrelOffset;
        /* 0x3FF4 */ public float HitOffset;
        /* 0x3FF8 */ public GcTracerData BulletTracer;
        /* 0x4010 */ public GcTracerData ShipTracer;
        /* 0x4028 */ public NMSString0x10 DefaultAnim;
        /* 0x4038 */ public bool DebugDrawTriggerBoxes;
        /* 0x403C */ public float SpeedReadoutMultiplier;
        /* 0x4040 */ public float SpaceSpeedReadoutMultiplier;
        /* 0x4044 */ public float CombatSpeedReadoutMultiplier;
        /* 0x4048 */ public int TorchCookieIndex;
        /* 0x404C */ public float TorchFoV;
        /* 0x4050 */ public float TorchStrength;
        /* 0x4054 */ public int TorchDimCookieIndex;
        /* 0x4058 */ public float TorchDimFoV;
        /* 0x405C */ public float TorchDimStrength;
        /* 0x4060 */ public float InteractionTorchFoV;
        /* 0x4064 */ public float InteractionTorchStrength;
        /* 0x4068 */ public float UndergroundTorchFoV;
        /* 0x406C */ public float UndergroundTorchFoVFar;
        /* 0x4070 */ public float UndergroundTorchStrength;
        /* 0x4074 */ public float UndergroundTorchStrengthFar;
        /* 0x4078 */ public float TorchOffsetX;
        /* 0x407C */ public float TorchOffsetY;
        /* 0x4080 */ public float TorchOffsetZ;
        /* 0x4084 */ public float TorchOffsetZMin;
        /* 0x4088 */ public float TorchOffsetZSpeedRange;
        /* 0x408C */ public float TorchOffsetZMinSpeed;
        /* 0x4090 */ public float TorchHandOffsetX;
        /* 0x4094 */ public float TorchHandOffsetY;
        /* 0x4098 */ public float TorchHandOffsetZ;
        /* 0x409C */ public bool TorchDisabledInTheDay;
        /* 0x40A0 */ public float TorchRotation;
        /* 0x40A4 */ public float TorchFollowCameraPitch;
        /* 0x40A8 */ public float TorchFollowCameraTime;
        /* 0x40B0 */ public Colour TorchColour;
        /* 0x40C0 */ public float PlayerAmbientSpotLightIntensity;
        /* 0x40D0 */ public Colour PlayerAmbientSpotLightColour;
        /* 0x40E0 */ public float PlayerAmbientSpotLightOffsetY;
        /* 0x40E4 */ public float PlayerAmbientSpotLightOffsetZ;
        /* 0x40E8 */ public float SimpleInteractionPickupAngle;
        /* 0x40EC */ public float SimpleInteractionPickupRadius;
        /* 0x40F0 */ public float SimpleInteractionMessageTime;
        /* 0x40F4 */ public float InteractionPickupAngle;
        /* 0x40F8 */ public float InteractionPickupRadius;
        /* 0x40FC */ public float ExplosionRadiusMultiplier;
        /* 0x4100 */ public float ExplosionForce;
        /* 0x4104 */ public float ExplosionForceMaxForceRadius;
        /* 0x4108 */ public float LaserExplosionForceRadius;
        /* 0x410C */ public float LaserExplosionForce;
        /* 0x4110 */ public float LaserExplosionForceMaxForceRadius;
        /* 0x4114 */ public NMSString0x80 InitialDebrisScene;
        /* 0x4194 */ public float BonusSameTypeElementsAdd;
        /* 0x4198 */ public float BonusSameTypeElementsMultiply;
        /* 0x419C */ public float BonusChildTypeElementsAdd;
        /* 0x41A0 */ public float BonusChildTypeElementsMultiply;
        /* 0x41A4 */ public float InteractionComponentUpdateDistance;
        /* 0x41A8 */ public float GoalGapVoxelDist;
        /* 0x41AC */ public float BlackHoleJumpVoxelDist;
        /* 0x41B0 */ public float BlackHoleJumpVoxelVariation;
        /* 0x41B4 */ public float JumpToCenterFuelCost;
        /* 0x41B8 */ public int WarpsBetweenMiniStation;
        /* 0x41BC */ public float HoursBetweenMiniStation;
        /* 0x41C0 */ public NMSString0x80 LegacyBaseBuildingTable;
        /* 0x4240 */ public NMSString0x80 BaseBuildingTable;
        /* 0x42C0 */ public float BaseBuildingHoverTimeToKnowPart;
        /* 0x42C8 */ public ulong NPCWorkerInteractionCooldown;
        /* 0x42D0 */ public float LightStrength;
        /* 0x42D4 */ public float AirLockDoorRange;
        /* 0x42D8 */ public bool DisableBasePowerHUDOverlay;
        /* 0x42D9 */ public bool KeepAttackingMaxWantedLevel;
        /* 0x42DA */ public bool UseMultiplierBonus;
        /* 0x42DC */ public float ShipDisplayDamageMultiplier;
        /* 0x42E0 */ public bool UseTradingCostTable;
        /* 0x42E1 */ public bool ChangePricesLocally;
        /* 0x42E2 */ public bool ShowPriceMarkupsAsPercentages;
        /* 0x42E4 */ public int ProductItemStockDecayTime;
        /* 0x42E8 */ public int ProductItemStockReplenishTime;
        /* 0x42EC */ public int SubstanceItemStockDecayTime;
        /* 0x42F0 */ public int SubstanceItemStockReplenishTime;
        /* 0x42F4 */ public GcPortalData Portal;
        /* 0x42FC */ public int FourthRaceSpawnPercentage;
        /* 0x4300 */ public int NonDominantRaceSpawnPercentage;
        /* 0x4304 */ public int NonDominantRaceSpawnPercentagePirate;
        /* 0x4308 */ public float ViciousSentinelProbability;
        /* 0x430C */ public float ViciousStormProbability;
        /* 0x4310 */ public float ViciousWeatherProbability;
        /* 0x4314 */ public float ScrapDroneProbability;
        /* 0x4318 */ public float MaxRespawnOnGroundHeight;
        /* 0x431C */ public float DeadPlanetGravityFactor;
        /* 0x4320 */ public GcScanEffectData ShipSalvageScanEffect;
        /* 0x4370 */ public float SalvageShipPitch;
        /* 0x4374 */ public float SalvageShipHeightOffset;
        /* 0x4378 */ public float SalvageShipExplodeSpeed;
        /* 0x437C */ public float SalvageShipShowShipSpeed;
        /* 0x4380 */ public float SalvageShipShowShipDistance;
        /* 0x4384 */ public float SalvageShipExplodeShipDistance;
        /* 0x4388 */ public float SalvageShipOneRevolutionTime;
        /* 0x4390 */ public NMSString0x20A CommunicatorFireteamNexusExitDialog;
        /* 0x43B0 */ public NMSString0x20A CommunicatorNexusExitAbandonWarningDialog;
        /* 0x43D0 */ public float BackgroundSpaceEncounterCheckTimer;
        /* 0x43D4 */ public float PulseEncounterCheckTimer;
        /* 0x43D8 */ public float PulseEncounterChance;
        /* 0x43DC */ public float PulseEncounterChanceStandard;
        /* 0x43E0 */ public float PulseEncounterChanceRed;
        /* 0x43E4 */ public float PulseEncounterChanceGreen;
        /* 0x43E8 */ public float PulseEncounterChanceBlue;
        /* 0x43EC */ public float PulseEncounterStopPower;
        /* 0x43F0 */ public float PulseEncounterStopSpeed;
        /* 0x43F4 */ public float DerelictPulseEncounterAtmosphericEffectChance;
        [NMS(Size = 0x6)]
        /* 0x43F8 */ public int[] AlienShipEvolveCosts;
        /* 0x4410 */ public float SpawnerWeaponRange;
        /* 0x4414 */ public TkModelResource WeaponSpawnObject;
        /* 0x4498 */ public TkModelResource WeaponSpawnAltObject;
        /* 0x451C */ public bool UseCustomSaveDirectory;
        /* 0x4520 */ public Vector2f FrigateFlybyTimer;
        /* 0x4528 */ public int PersonalInventoryMinWidthMax;
        /* 0x452C */ public int PersonalInventoryMinHeightMax;
        /* 0x4530 */ public int PersonalTechInventoryMinWidthMax;
        /* 0x4534 */ public int PersonalTechInventoryMinHeightMax;
        /* 0x4538 */ public int ShipInventoryMinWidthMax;
        /* 0x453C */ public int ShipInventoryMinHeightMax;
        /* 0x4540 */ public int ShipTechInventoryMinWidthMax;
        /* 0x4544 */ public int ShipTechInventoryMinHeightMax;
        /* 0x4548 */ public int VehicleInventoryMinWidthMax;
        /* 0x454C */ public int VehicleInventoryMinHeightMax;
        /* 0x4550 */ public int WeaponInventoryMinWidthMax;
        /* 0x4554 */ public int WeaponInventoryMinHeightMax;
    }
}
