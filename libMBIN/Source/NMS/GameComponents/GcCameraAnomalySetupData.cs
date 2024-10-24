namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC139D1B965EBA3B7, NameHash = 0x2D5B7153)]
    public class GcCameraAnomalySetupData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector4f CameraAt;
        [NMS(Index = 2)]
        /* 0x10 */ public Vector4f CameraOffset;
        [NMS(Index = 1)]
        /* 0x20 */ public Vector4f CameraUp;
        [NMS(Index = 3)]
        /* 0x30 */ public Vector4f SunDirection;
    }
}
