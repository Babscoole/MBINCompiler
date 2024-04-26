using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA5615B57503AB, NameHash = 0x87BC5043F293743D)]
    public class GcNPCSettlementBehaviourData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x5, EnumType = typeof(GcNPCSettlementBehaviourState.NPCSettlementBehaviourStateEnum))]
        /* 0x000 */ public GcNPCSettlementBehaviourEntry[] BehaviourOverrides;
        [NMS(Index = 0)]
        /* 0x168 */ public GcNPCSettlementBehaviourEntry BaseBehaviour;
    }
}
