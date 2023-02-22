using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x150A3F080C5CF432, NameHash = 0x42869E79D40A84C1)]
    public class GcCreatureNearbyEvent : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureAlertData> AlertTable;
        /* 0x10 */ public bool Inverse;
    }
}
