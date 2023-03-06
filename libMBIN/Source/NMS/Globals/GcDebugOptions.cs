using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x86806EC3D3B6EF4B, NameHash = 0x13FED27DF728C38)]
    public class GcDebugOptions : NMSTemplate
    {
        /* 0x0000 */ public bool ForceScanEventsToGoPrime;
        /* 0x0001 */ public bool SkipAbandonedFreighterUnlocking;
        /* 0x0002 */ public bool AllowSavingOnAbandonedFreighters;
        /* 0x0003 */ public bool DisableAbandonedFreighterRoomsOptimisation;
        /* 0x0008 */ public ulong OverrideAbandonedFreighterSeed;
        /* 0x0010 */ public bool ThirdPersonIsDefaultCameraForPlayer;
        /* 0x0011 */ public bool ThirdPersonIsDefaultCameraForShipAndVehicles;
        /* 0x0012 */ public bool SkipIntro;
        /* 0x0013 */ public bool SkipLogos;
        /* 0x0014 */ public bool SkipUITimers;
        /* 0x0018 */ public int BootDirectlyIntoSaveSlot;
        /* 0x001C */ public bool BootDirectlyIntoLastSave;
        /* 0x0020 */ public GcGameMode NewSaveGameMode;
        /* 0x0024 */ public bool SkipPlanetDiscoverOnBoot;
        /* 0x0025 */ public bool VideoCaptureMode;
        /* 0x0026 */ public bool GodMode;
        /* 0x0027 */ public bool TakeNoDamage;
        /* 0x0028 */ public bool SuperKillGuns;
        /* 0x0029 */ public bool AlwaysHaveFocus;
        /* 0x002A */ public bool DisableVibration;
        /* 0x002B */ public bool DebugGalaxyMapInQuickMenu;
        /* 0x002C */ public bool MapWarpCheckIgnoreFuel;
        /* 0x002D */ public bool MapWarpCheckIgnoreDrive;
        /* 0x002E */ public bool EverythingIsFree;
        /* 0x002F */ public bool EverythingIsKnown;
        /* 0x0030 */ public bool EverythingIsStar;
        /* 0x0031 */ public bool InfiniteStamina;
        /* 0x0032 */ public bool DisableHazards;
        /* 0x0033 */ public bool IgnoreMissionRank;
        /* 0x0034 */ public bool CanLeaveDialogs;
        /* 0x0035 */ public bool DisableOldMissions;
        /* 0x0036 */ public bool UseScreenEffects;
        /* 0x0037 */ public bool UseGunImpactEffect;
        /* 0x0038 */ public bool RenderCreatureDetails;
        /* 0x0039 */ public bool SkipTutorial;
        /* 0x003A */ public bool IgnoreFreighterSpawnWarpRequirement;
        /* 0x003B */ public bool MaximumFreighterSpawns;
        /* 0x003C */ public bool DisableSaveSlotSorting;
        /* 0x003D */ public bool DisableSaving;
        /* 0x003E */ public bool DisableContinuousSaving;
        /* 0x003F */ public bool DisableInvalidSaveVersion;
        /* 0x0040 */ public bool DisableStorms;
        /* 0x0041 */ public bool ForceEnableClothComponent;
        /* 0x0042 */ public bool ForceDisableClothComponent;
        /* 0x0043 */ public bool ClothForcePositionExtrapolationOff;
        /* 0x0044 */ public bool ClothForcePositionExtrapolationOn;
        /* 0x0045 */ public bool ClothForcePositionExtrapolationBackOn;
        /* 0x0046 */ public bool ClothForcePositionExtrapolationUpdateOrderDependent;
        /* 0x0047 */ public bool ClothForcePositionExtrapolationSyncWithFpsLock;
        /* 0x0048 */ public bool ClothForcePositionExtrapolationAntiSyncWithFpsLock;
        /* 0x0049 */ public bool ClothForceAsyncSimulationOff;
        /* 0x004A */ public bool ClothForceAsyncSimulationOn;
        /* 0x004B */ public bool ForceEnableSpringAttachmentComponent;
        /* 0x004C */ public bool ForceDisableSpringAttachmentComponent;
        /* 0x004D */ public bool ForceEnableSplitIkOptimisation;
        /* 0x004E */ public bool ForceDisableSplitIkOptimisation;
        /* 0x004F */ public bool SampleCollisionWithCamera;
        /* 0x0050 */ public bool ShowPlayerCollisions;
        /* 0x0051 */ public bool DisableNPCs;
        /* 0x0052 */ public bool AlternateControls;
        /* 0x0053 */ public bool AlwaysShowURI;
        /* 0x0054 */ public bool MPMissionsAlwaysEPIC;
        /* 0x0055 */ public bool ShowFireteamMembersUA;
        /* 0x0056 */ public bool RevealAllTitles;
        /* 0x0057 */ public bool UnlockAllTitles;
        /* 0x0058 */ public bool LockAllTitles;
        /* 0x0059 */ public bool AlwaysAllowShipOperations;
        /* 0x005A */ public bool AlwaysAllowVehicleOperations;
        /* 0x005B */ public bool AlwaysAllowFreighterInventoryAccess;
        /* 0x005C */ public NMSString0x200 SeasonalDataOverrideFile;
        /* 0x025C */ public bool UnlockAllSeasonRewards;
        /* 0x025D */ public bool UnlockAllTwitchRewards;
        /* 0x025E */ public bool UnlockAllPlatformRewards;
        /* 0x025F */ public NMSString0x400 DebugTwitchRewards;
        /* 0x065F */ public bool AllowPause;
        /* 0x0660 */ public bool AllSettlementsAreCompleted;
        /* 0x0661 */ public bool DisableSettlements;
        /* 0x0662 */ public bool PlaceOnGroundWhenLeavingDebugCamera;
        /* 0x0663 */ public bool OctahedralImpostersEnable;
        /* 0x0664 */ public bool OctahedralImpostersDisable;
        /* 0x0665 */ public bool OctahedralImpostersViewFromSpace;
        /* 0x0668 */ public int OctahedralImpostersViewCount;
        /* 0x066C */ public bool EnableMemoryPoolAllocPrint;
        /* 0x066D */ public bool UseDebugScreenSettings;
        /* 0x0670 */ public int ScreenWidth;
        /* 0x0674 */ public int ScreenHeight;
        /* 0x0678 */ public bool DisableVSync;
        // size: 0x3
        public enum GameWindowModeEnum : uint {
            Bordered,
            Borderless,
            Fullscreen,
        }
        /* 0x067C */ public GameWindowModeEnum GameWindowMode;
        /* 0x0680 */ public int Monitor;
        /* 0x0684 */ public int TiledWindowsSplitCount;
        /* 0x0688 */ public int TiledWindowsIndex;
        /* 0x068C */ public NMSString0x100 ForceUniverseAddress;
        /* 0x078C */ public NMSString0x100 ForcePlayerPosition;
        /* 0x088C */ public bool ForceInitialShip;
        /* 0x088D */ public bool ForceInitialWeapon;
        // size: 0x3
        public enum GameStateModeEnum : uint {
            LoadPreset,
            UserStorage,
            FreshStart,
        }
        /* 0x0890 */ public GameStateModeEnum GameStateMode;
        // size: 0x7
        public enum BootModeEnum : uint {
            MinimalSolarSystem,
            SolarSystem,
            GalaxyMap,
            SmokeTest,
            SmokeTestGalaxyMap,
            Scratchpad,
            UnitTest,
        }
        /* 0x0894 */ public BootModeEnum BootMode;
        // size: 0x7
        public enum PlayerSpawnLocationOverrideEnum : uint {
            None,
            FromSettings,
            Space,
            SpaceStation,
            RandomPlanet,
            GameStartPlanet,
            SpecificLocation,
        }
        /* 0x0898 */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        /* 0x089C */ public NMSString0x80 SceneSettings;
        /* 0x091C */ public NMSString0x100 WorkingDirectory;
        /* 0x0A1C */ public NMSString0x80 DebugScene;
        // size: 0x2
        public enum SolarSystemBootEnum : uint {
            FromSettings,
            Generate,
        }
        /* 0x0A9C */ public SolarSystemBootEnum SolarSystemBoot;
        // size: 0x2
        public enum ShaderPreloadEnum : uint {
            Off,
            Full,
        }
        /* 0x0AA0 */ public ShaderPreloadEnum ShaderPreload;
        /* 0x0AA4 */ public bool ShaderPreloadListExport;
        /* 0x0AA5 */ public bool ShaderPreloadListImport;
        /* 0x0AA6 */ public bool ShaderCaching;
        // size: 0x3
        public enum BootLoadDelayEnum : uint {
            LoadAll,
            WaitForPlanet,
            WaitForNothing,
        }
        /* 0x0AA8 */ public BootLoadDelayEnum BootLoadDelay;
        /* 0x0AAC */ public bool MemCsv;
        /* 0x0AB0 */ public float ForceTimeOfDay;
        /* 0x0AB4 */ public float ForceInitialTimeOfDay;
        /* 0x0AB8 */ public bool ForceSunDirectionFromPhotoMode;
        /* 0x0ABC */ public float ForceSunAngle;
        /* 0x0AC0 */ public bool ResetForcedSaveSlotOnLoad;
        /* 0x0AC1 */ public bool EnableFrontendPreload;
        /* 0x0AC2 */ public bool MissionMessageLoggingEnabled;
        /* 0x0AC3 */ public bool MissionNGUIShowsConditionResults;
        /* 0x0AC4 */ public bool UseParticles;
        /* 0x0AC5 */ public bool UseVolumetrics;
        /* 0x0AC6 */ public bool UseClouds;
        /* 0x0AC7 */ public bool EnableCloudAnimation;
        /* 0x0AC8 */ public bool UseTerrain;
        /* 0x0AC9 */ public bool UseInstances;
        /* 0x0ACA */ public bool UseObjects;
        /* 0x0ACB */ public bool UseBuildings;
        /* 0x0ACC */ public bool UseCreatures;
        /* 0x0ACD */ public bool UseElevation;
        /* 0x0ACE */ public bool UseLegacyFreighters;
        /* 0x0ACF */ public bool UseLegacyBuildingTable;
        /* 0x0AD0 */ public bool EnableDayNightCycle;
        /* 0x0AD1 */ public bool SpawnPirates;
        /* 0x0AD2 */ public bool SpawnRobots;
        /* 0x0AD3 */ public bool SpawnShips;
        /* 0x0AD4 */ public bool SpawnPulseEncounters;
        /* 0x0AD5 */ public bool InstanceCollision;
        /* 0x0AD6 */ public bool LoadMissions;
        /* 0x0AD7 */ public bool MPMissions;
        /* 0x0AD8 */ public bool SpecialsShop;
        /* 0x0AD9 */ public bool MultiplePlayerFreightersInASystem;
        /* 0x0ADA */ public bool ForceNexusInQuickMenu;
        /* 0x0ADB */ public bool MissionSurveyEnabled;
        /* 0x0ADC */ public bool AllSeasonMilestonesShowComplete;
        /* 0x0ADD */ public bool EnableGalaxyRecolouring;
        /* 0x0ADE */ public bool IgnoreSteamDev;
        /* 0x0ADF */ public bool EnableBaseBuildingExpandables;
        /* 0x0AE0 */ public bool MouseLookEnabled;
        /* 0x0AE1 */ public bool StartPaused;
        /* 0x0AE2 */ public bool DisableDebugControls;
        /* 0x0AE3 */ public bool FixedFramerate;
        /* 0x0AE4 */ public bool ScreenshotMode;
        /* 0x0AE5 */ public bool RenderHud;
        /* 0x0AE6 */ public bool DisableDiscoveryNaming;
        /* 0x0AE7 */ public bool DebugDrawPlayerInteract;
        /* 0x0AE8 */ public bool ForceInteractionToSettings;
        /* 0x0AEC */ public int ForceInteractionIndex;
        /* 0x0AF0 */ public bool InteractionsAllwaysGivesTech;
        /* 0x0AF1 */ public bool InfiniteInteractions;
        /* 0x0AF2 */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x0AF4 */ public TkLanguages DebugLanguage;
        /* 0x0AF8 */ public NMSString0x20 AllowedLanguagesFile;
        /* 0x0B18 */ public bool DoAlienLanguage;
        /* 0x0B1C */ public GcAlienRace ForceInteractionRaceTo;
        // size: 0x2
        public enum RealityModeEnum : uint {
            LoadPreset,
            Generate,
        }
        /* 0x0B20 */ public RealityModeEnum RealityMode;
        /* 0x0B24 */ public bool DebugPersistentInteractions;
        /* 0x0B25 */ public bool UseHighlightedOptionStyle;
        /* 0x0B26 */ public bool DisableMissionShop;
        /* 0x0B27 */ public NMSString0x80 RealityPresetFile;
        /* 0x0BA8 */ public ushort RealityGenerationIteration;
        /* 0x0BB0 */ public List<NMSString0x20> LocTableList;
        /* 0x0BC0 */ public NMSString0x80 DefaultSaveData;
        /* 0x0C40 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x0C41 */ public bool ForceBasicLoadScreen;
        /* 0x0C44 */ public float BootLogoFadeRate;
        /* 0x0C48 */ public bool BootMusic;
        /* 0x0C4C */ public float WeaponScale3P;
        /* 0x0C50 */ public bool LogMissingLocalisedText;
        /* 0x0C51 */ public bool FleetDirectorAutoMode;
        /* 0x0C54 */ public float _3dTextDistance;
        /* 0x0C58 */ public float _3dTextMinScale;
        // size: 0x3
        public enum RecordSettingEnum : uint {
            None,
            Record,
            Playback,
        }
        /* 0x0C5C */ public RecordSettingEnum RecordSetting;
        /* 0x0C60 */ public bool DebugBuildingSpawns;
        /* 0x0C61 */ public bool StressTestLongNameDisplay;
        /* 0x0C62 */ public bool ShowLongestStrings;
        /* 0x0C63 */ public NMSString0x20 SaveTestingCommand;
        /* 0x0C83 */ public bool NeverUseBanks;
        /* 0x0C84 */ public bool DisableProfanityFilter;
        /* 0x0C85 */ public bool DisableFileWatcher;
        /* 0x0C86 */ public bool DisableShaderReload;
        /* 0x0C88 */ public int RecurrenceTimeOffset;
        /* 0x0C90 */ public ulong ForceTimeToEpoch;
        /* 0x0C98 */ public NMSString0x80 CrashDumpPath;
        /* 0x0D18 */ public NMSString0x20 CrashDumpIdentifier;
        /* 0x0D38 */ public bool EnableLivePP;
        /* 0x0D39 */ public bool DebugThreatLevels;
        /* 0x0D3A */ public bool DumpManifestContents;
        /* 0x0D3B */ public bool ShowDebugMessages;
        /* 0x0D3C */ public bool ShowFramerate;
        /* 0x0D3D */ public bool ShowGPURenderTime;
        /* 0x0D3E */ public bool ShowDynamicResScale;
        /* 0x0D3F */ public bool PrintAvgFrameTimes;
        /* 0x0D40 */ public bool ShowPositionDebug;
        /* 0x0D41 */ public bool ShowGPUMemory;
        /* 0x0D42 */ public bool ShowMempoolOverlay;
        /* 0x0D43 */ public bool ShowMouseSmoothing;
        /* 0x0D44 */ public NMSString0x100 ShowUniverseAddressOnGalaxyMap;
        /* 0x0E44 */ public bool ShowGraphs;
        /* 0x0E48 */ public int ShowSpecificGraph;
        /* 0x0E4C */ public bool GraphCommandBuffer;
        /* 0x0E4D */ public bool GraphGeneration;
        /* 0x0E4E */ public bool GraphFPS;
        /* 0x0E4F */ public bool GraphTexStreaming;
        /* 0x0E50 */ public bool SmokeTestDumpStatsMode;
        // size: 0x7
        public enum SmokeTestCycleModeEnum : uint {
            None,
            TourPlanet,
            TourSolarSystem,
            TourGalaxy,
            TourUDAs,
            TourShortUDAs,
            TourRandomWarps,
        }
        /* 0x0E54 */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
        // size: 0x8
        public enum SmokeTestScenarioEnum : uint {
            None,
            TerrainSnapShotFromAltitude,
            BelowCloudLayerSnapShot,
            Flying,
            UltraBiomeSnapShot,
            Walking,
            LeakDetector,
            WalkingSnapshot,
        }
        /* 0x0E58 */ public SmokeTestScenarioEnum SmokeTestScenario;
        /* 0x0E5C */ public bool SmokeTestLegacyOutput;
        /* 0x0E60 */ public int SmokeTestConfigPlanetPositionCount;
        /* 0x0E64 */ public float SmokeTestConfigScenarioPreambleLength;
        /* 0x0E68 */ public float SmokeTestConfigScenarioLength;
        /* 0x0E6C */ public bool SmokeTestFastExit;
        /* 0x0E6D */ public bool SmokeTestCameraFly;
        /* 0x0E6E */ public bool SmokeTestOutputOnly;
        /* 0x0E6F */ public bool SmokeTestPureFlight;
        /* 0x0E70 */ public int SmokeTestConfigCaptureCycles;
        /* 0x0E74 */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x0E78 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x0E7C */ public bool SmokeTestConfigRandomizePlanetSeed;
        /* 0x0E7D */ public bool SmokeTestSmokeBotEnabled;
        /* 0x0E7E */ public bool SmokeTestSmokeBotAutoStart;
        /* 0x0E80 */ public int SmokeTestSmokeBotTargetWarps;
        /* 0x0E84 */ public bool SmokeTestPostBandwidthStats;
        /* 0x0E85 */ public NMSString0x20 SmokeTestForcePlanetDetail;
        /* 0x0EA5 */ public NMSString0x20 SmokeTestRunFolder;
        /* 0x0EC5 */ public bool CreatureChatter;
        /* 0x0EC6 */ public bool CreatureErrors;
        /* 0x0EC7 */ public bool CreatureDrawVocals;
        /* 0x0EC8 */ public bool DrawCreaturesInRoutines;
        /* 0x0EC9 */ public bool CompressTextures;
        /* 0x0ECA */ public bool DebugIBL;
        /* 0x0ECB */ public bool DebugSpotlights;
        /* 0x0ECC */ public bool DebugTerrainTextures;
        /* 0x0ECD */ public bool DisableShadowSwitching;
        /* 0x0ECE */ public NMSString0x80 PipelineFile;
        /* 0x0F4E */ public NMSString0x80 PipelineFilePS4;
        /* 0x0FCE */ public NMSString0x80 PipelineFileXboxOne;
        /* 0x104E */ public NMSString0x80 PipelineFileVR;
        /* 0x10CE */ public NMSString0x80 PipelineFileVRPS4;
        /* 0x114E */ public NMSString0x80 PipelineFileFrontend;
        /* 0x11CE */ public NMSString0x80 PipelineFileEditor;
        /* 0x124E */ public NMSString0x80 PipelineFileSwitch;
        /* 0x12CE */ public bool RenderLowFramerate;
        /* 0x12CF */ public bool EnableComputePost;
        /* 0x12D0 */ public bool EnableEvenOddRender;
        /* 0x12D1 */ public bool MinGPUMode;
        /* 0x12D2 */ public bool Proto2DevKit;
        /* 0x12D3 */ public bool AlwaysIncludeLocalPlayerInChatMessage;
        /* 0x12D4 */ public bool SimulateNoNetworkConnection;
        // size: 0x3
        public enum ProxyTypeEnum : uint {
            None,
            ManualURI,
            InetProxy,
        }
        /* 0x12D8 */ public ProxyTypeEnum ProxyType;
        /* 0x12DC */ public NMSString0x80 ProxyURI;
        // size: 0x8
        public enum ServerEnvEnum : uint {
            Default,
            dev,
            qa,
            prodqa,
            prod,
            custom,
            pentest,
            merged,
        }
        /* 0x135C */ public ServerEnvEnum ServerEnv;
        /* 0x1360 */ public NMSString0x80 AuthBaseUrl;
        /* 0x13E0 */ public bool CertificateSecurityBypass;
        /* 0x13E1 */ public NMSString0x20 OverrideUsernameForDev;
        /* 0x1404 */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0x1408 */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0x1409 */ public bool AutoJoinUserEnabled;
        /* 0x140A */ public NMSString0x800 AutoJoinUserNames;
        /* 0x1C0A */ public bool AlwaysSaveGameAsClient;
        /* 0x1C0B */ public bool DisableMonumentDownloads;
        /* 0x1C0C */ public bool UsePadOnUnfocusedWindow;
        /* 0x1C10 */ public int OverrideMatchmakingVersion;
        /* 0x1C14 */ public NMSString0x200 LoadToBase;
        /* 0x1E14 */ public bool IgnoreTransactionTimeouts;
        /* 0x1E15 */ public bool AutoJoinRandomGames;
        /* 0x1E16 */ public NMSString0x100 GOGLogin;
        /* 0x1F16 */ public bool RecordNetworkStatsOnBoot;
        /* 0x1F17 */ public bool FakeHandsInMultiplayer;
        /* 0x1F18 */ public bool ForceSmallLobby;
        /* 0x1F19 */ public bool ForceTinyLobby;
        /* 0x1F1C */ public int OverrideServerSeasonNumber;
        /* 0x1F20 */ public int OverrideServerSeasonEndTime;
        /* 0x1F24 */ public bool EnableSynergy;
        /* 0x1F25 */ public NMSString0x20 SynergyServer;
        /* 0x1F48 */ public int SynergyPort;
        /* 0x1F4C */ public bool ShowEditorPlacementPreview;
        /* 0x1F50 */ public int MaxNumDebugMessages;
        /* 0x1F54 */ public bool PreloadToolbox;
        /* 0x1F58 */ public int DebugTextureSize;
        /* 0x1F5C */ public bool UseProcTextureDebugger;
        /* 0x1F60 */ public int ProceduralModelsShown;
        /* 0x1F64 */ public int ProceduralModelBatchSize;
        /* 0x1F68 */ public int ProceduralModelFilterMatchretryCount;
        /* 0x1F6C */ public bool ProceduralModelsDeterministicSequence;
        /* 0x1F70 */ public int ProceduralModelsThumbnailSize;
        /* 0x1F74 */ public NMSString0x80 DebugFont;
        /* 0x1FF4 */ public NMSString0x80 DebugFontTexture;
        /* 0x2074 */ public NMSString0x80 CursorTexture;
        /* 0x20F4 */ public NMSString0x80 PauseTexture;
        /* 0x2174 */ public NMSString0x80 PlayTexture;
        /* 0x21F4 */ public NMSString0x80 StepTexture;
        /* 0x2274 */ public NMSString0x80 RenderToTexture;
        /* 0x22F4 */ public bool HmdEnable;
        /* 0x22F8 */ public int HmdPreviewScale;
        /* 0x22FC */ public bool HmdTracking;
        /* 0x22FD */ public bool HmdStereoRender;
        /* 0x22FE */ public bool HmdDistortionPassthru;
        /* 0x2300 */ public int HmdMonitor;
        /* 0x2304 */ public int HmdEyeBufferWidth;
        /* 0x2308 */ public int HmdEyeBufferHeight;
        /* 0x230C */ public float HmdEyeScalePos;
        /* 0x2310 */ public float HmdHeadScalePos;
        /* 0x2314 */ public bool HmdFrameShiftEnabled;
        /* 0x2315 */ public bool HmdUseSolidGuiPointer;
        /* 0x2316 */ public bool BodyTurning;
        /* 0x2318 */ public float HmdImmersionFactor;
        /* 0x231C */ public bool ShowHmdHandControllers;
        /* 0x231D */ public bool ShowTeleportEffectLocally;
        /* 0x231E */ public bool DisableLeftHand;
        /* 0x231F */ public bool DisableHeadConstraints;
        /* 0x2320 */ public bool EnablePhotomodeVR;
        /* 0x2321 */ public bool AllowNGuiVR;
        /* 0x2322 */ public bool ForceExtremeWeather;
        /* 0x2323 */ public bool ForceExtremeSentinels;
        /* 0x2324 */ public bool ForceStarType;
        /* 0x2325 */ public bool ForceLoadAllWeather;
        /* 0x2328 */ public GcGalaxyStarTypes ForceStarTypeTo;
        /* 0x232C */ public bool ForceBiome;
        /* 0x2330 */ public GcBiomeType ForceBiomeTo;
        /* 0x2334 */ public bool ForceScreenFilter;
        /* 0x2338 */ public GcScreenFilters ForceScreenFilterTo;
        /* 0x233C */ public GcBiomeSubType ForceBiomeSubTypeTo;
        /* 0x2340 */ public bool ForceBuildingRace;
        /* 0x2344 */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x2348 */ public bool ForceLifeLevel;
        /* 0x234C */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x2350 */ public bool ForceCreatureLifeLevel;
        /* 0x2351 */ public bool ForceDefaultCreatureFile;
        /* 0x2358 */ public NMSString0x10 DefaultGroundCreatureTable;
        /* 0x2368 */ public NMSString0x10 DefaultAirCreatureTable;
        /* 0x2378 */ public NMSString0x10 DefaultWaterCreatureTable;
        /* 0x2388 */ public NMSString0x10 DefaultCaveCreatureTable;
        /* 0x2398 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x239C */ public GcPlanetLife ForceTerrainSettings;
        /* 0x23A0 */ public bool ForceTerrainType;
        /* 0x23A4 */ public TkVoxelGeneratorSettingsTypes ForceTerrainTypeTo;
        /* 0x23A8 */ public bool ForcePirateSystem;
        /* 0x23A9 */ public bool ForcePrimeTerrain;
        /* 0x23AA */ public bool ForceBinaryStar;
        /* 0x23AB */ public bool ForceTernaryStar;
        /* 0x23AC */ public GcGalaxyStarAnomaly ForceAnomalyTo;
        /* 0x23B0 */ public bool ForcePlanetsToHaveWater;
        /* 0x23B4 */ public int ForceWaterObjectFileIndex;
        /* 0x23B8 */ public int ForceSkyColourIndex;
        /* 0x23BC */ public int ForceSpaceSkyColourIndex;
        /* 0x23C0 */ public bool ForceSpaceSkyColourRare;
        /* 0x23C4 */ public int ForceWaterColourIndex;
        /* 0x23C8 */ public int ForceGrassColourIndex;
        /* 0x23CC */ public bool ModifyPlanetsInInitialSystems;
        /* 0x23CD */ public bool ForcePlanetsToHaveNoWater;
        /* 0x23CE */ public bool ForcePlanetsToHaveNoCaves;
        /* 0x23CF */ public bool ForcePlanetsToHaveNoNoiseLayers;
        /* 0x23D0 */ public bool ForcePlanetsToHaveNoTerrainFeatures;
        /* 0x23D1 */ public bool ForceRareAsteroidSystem;
        /* 0x23D4 */ public int ForceAsteroidSystemIndex;
        /* 0x23D8 */ public bool DisableLimits;
        /* 0x23D9 */ public bool LimitPerRegionInstances;
        /* 0x23DA */ public bool LimitPerRegionBodies;
        /* 0x23DB */ public bool LimitGlobalInstances;
        /* 0x23DC */ public bool LimitGlobalBodies;
        /* 0x23E0 */ public int GenerateFarLodBuildingDist;
        /* 0x23E4 */ public bool DeferRegionBodies;
        /* 0x23E8 */ public float GenerateCostDistance;
        /* 0x23EC */ public float GenerateCostAngle;
        /* 0x23F0 */ public float GenerateCostLOD;
        /* 0x23F4 */ public float GenerateCostWait;
        /* 0x23F8 */ public bool DChecksEnabled;
        /* 0x23F9 */ public bool DChecksOutputJson;
        /* 0x23FA */ public bool DChecksOutputBinary;
        /* 0x23FB */ public bool DChecksOutputFileLine;
        /* 0x23FC */ public int FrameFlipRateDefault;
        /* 0x2400 */ public int FrameFlipRateLoad;
        /* 0x2404 */ public int FrameFlipRateGame;
        /* 0x2408 */ public float MaxFrameRate;
        /* 0x240C */ public bool DisableBaseBuilding;
        /* 0x240D */ public bool DisableBaseBuildingLimits;
        /* 0x240E */ public bool AllowGlobalPartSnapping;
        /* 0x2410 */ public float BaseDownloadTimeout;
        /* 0x2414 */ public bool DisableBasePowerRequirements;
        /* 0x2415 */ public bool EnableBaseMovingOption;
        /* 0x2418 */ public int MoveBaseIndex;
        /* 0x241C */ public NMSString0x20 AutomaticPartSpawnID;
        /* 0x243C */ public GcBaseBuildingPartStyle AutomaticPartSpawnStyle;
        /* 0x2440 */ public bool AutomaticPartSpawnInactive;
        /* 0x2444 */ public int ProfilerPartIndexPhase;
        /* 0x2448 */ public int ProfilerPartIndexStride;
        /* 0x244C */ public int ProfilerPartIteration;
        /* 0x2450 */ public bool BaseAdmin;
        /* 0x2451 */ public NMSString0x20 BaseServerPlatform;
        /* 0x2474 */ public uint BasePayloadMultiplier;
        /* 0x2478 */ public bool CrossPlatformFeaturedBases;
        /* 0x2479 */ public bool ShowMissionIdInTitle;
        /* 0x247C */ public TkGlobals ToolkitGlobals;
        /* 0x26AC */ public bool AllowOverrideSettlementOwnership;
        /* 0x26AD */ public NMSString0x40 OverrideSettlementOwnershipUsername;
        /* 0x26ED */ public NMSString0x40 OverrideSettlementOwnershipOnlineId;
        /* 0x272D */ public bool BlockSettlementsNetwork;
        /* 0x272E */ public bool EnableAccessibleUI;
        /* 0x272F */ public bool DisablePartialStories;
        /* 0x2730 */ public bool UnlockAllStories;
        /* 0x2731 */ public bool UnlockAllWords;
    }
}
