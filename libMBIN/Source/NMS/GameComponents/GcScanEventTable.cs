using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4F6D61D80DD34DFC, NameHash = 0xEE47CB18)]
    public class GcScanEventTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcScanEventData> Events;
    }
}
