namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8A1D47261D6E618E, NameHash = 0x2A70A589)]
    public class GcMissionConditionInCombat : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A OverrideOSDMessage;
        // size: 0x9
        public enum CombatTypeEnum : uint {
            GroundCombat,
            SpaceCombat,
            FiendCombat,
            BigFishFiendCombat,
            CorruptedSentinelCombat,
            GroundWormCombat,
            RewardEncounter,
            BugQueen,
            JellyBoss,
        }
        [NMS(Index = 0)]
        /* 0x20 */ public CombatTypeEnum CombatType;
        [NMS(Index = 2)]
        /* 0x24 */ public bool CheckAllFireteamMembers;
        [NMS(Index = 3)]
        /* 0x25 */ public bool EncouragesFightingSentinels;
        [NMS(Index = 5)]
        /* 0x26 */ public bool SpaceCombatTextCountsPirates;
        [NMS(Index = 4)]
        /* 0x27 */ public bool SpaceCombatTextCountsSentinels;
    }
}
