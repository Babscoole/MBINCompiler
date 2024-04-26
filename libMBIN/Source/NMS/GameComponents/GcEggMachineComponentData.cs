using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE5F05572122DAD11, NameHash = 0x54575BF82BE5C4BA)]
    public class GcEggMachineComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        [NMS(Index = 1)]
        /* 0x3E0 */ public int NumInputs;
    }
}
