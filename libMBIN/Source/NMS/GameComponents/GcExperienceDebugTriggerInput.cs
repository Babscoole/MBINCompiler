using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8336B6EC1C32F9, NameHash = 0xBCDA670B36E2534)]
    public class GcExperienceDebugTriggerInput : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcExperienceDebugTriggerAction> Actions;
        // size: 0xD
        public enum KeyPressEnum : uint {
            _1,
            _2,
            _3,
            _4,
            _5,
            _6,
            _7,
            _8,
            _9,
            PadUp,
            PadDown,
            PadLeft,
            PadRight,
        }
        [NMS(Index = 0)]
        /* 0x10 */ public KeyPressEnum KeyPress;
    }
}
