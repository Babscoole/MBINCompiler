﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xB163F9DDA2B02D54, NameHash = 0x92D4879C17049BD7)]
    public class GcAudioWwiseRTPCs : NMSTemplate
    {
        // size: 0x5A
        public enum AkRTPCEnum : uint {
            INVALID_RTPC = 0x0, BASE_BATTERY_CHARGING = 0x7C13B3BA, BASE_SPHERE_ROLLSPEED = 0xB7D53D81, BINOCULARS_EFFECT = 0x65306505, BURN_INTENSITY = 0x8B1E9F48,
            BYTEBEAT_FX = 0xDC013338, BYTEBEAT_VOLUME = 0x71703CA8, COMMS_CHATTER_DISTANCE = 0x7A371A94, COMMS_CHATTER_FREIGHTERATTACKED = 0x46A238DC, COMMS_CHATTER_PIRATES = 0x54E82B11,
            COMMS_CHATTER_POLICE = 0xD547E7BB, CREATURE_EXISTENCE = 0xBBAE19A3, CREATURES_STEP_SIZE = 0xE1067D02, DOPPLER_DROID_SMALL = 0x1F092F38, GAMEOBJECT_DISTANCE = 0x8EB54518,
            GLOBAL_HAZARD_LEVEL = 0xFDD1B808, GLOBAL_HEALTH_LEVEL = 0x2A61033E, GLOBAL_SHIELD_LEVEL = 0xEA9FE763, HG_VA_EMOTE = 0x181937FF, HG_VA_GAMEOBJECTS = 0x8904C9A1,
            HG_VA_HEADBODYRATIO = 0xF6293C64, HG_VA_SEED = 0x232F7C0E, HG_VA_SIZE = 0x2E25003A, INTERACT_TIMER = 0x1EE7B825, JETPACK_HEIGHT = 0x70B5E6C1,
            MAP_STAR_WOOSH = 0xBC7AB0AD, MASTER_CHAT_LEVEL = 0x5B8E4667, MASTER_MUSIC_LEVEL = 0xF8F6ACB4, MASTER_SFX_LEVEL = 0xC9C3F2F8, MECH_IDLE = 0xBB021D37,
            METEORITE_INCOMING = 0xCFBF792E, MOTION_DRIVER_A = 0x732F78BC, MOTION_DRIVER_B = 0x732F78BF, NPC_SHIP_DISTANCE = 0x810FD033, NPC_SHIP_DOPPLER = 0xD8BAE8F6,
            NPC_SHIP_SPEED = 0x925EFD57, PL_AMB_HEIGHT = 0x12F4388A, PL_CAVE_ENCLOSED = 0x99475573, PL_EXERTION = 0x9C64F46C, PL_FALL_SPEED = 0x76233CFB,
            PL_FOLEY_CLOTHING_LOCO_SPEED = 0x8B826A1A, PL_HAZARD_PROTECTION = 0x7EF62492, PL_SHIP_HEIGHT = 0xFEF18CB4, PL_SHIP_LANDINGDISTANCE = 0xC99A4E93, PL_SHIP_SPEED = 0xD26BA1DA,
            PL_SHIP_SPEED_REV = 0x9407EEA4, PL_SHIP_SURFACE_WATER = 0xC99CF8A6, PL_SHIP_THRUST = 0xE61896C3, PL_SHIP_VR_EXIT = 0x88814C78, PL_SHIP_YAW = 0x9142CD7A,
            PL_UNDERWATER_DEPTH = 0x72C84A65, PL_WALK_SPEED = 0x5BF0E7CB, PL_WPN_LASER_RESOURCEGATHER = 0x767BB3A5, PL_WPN_LASERPOWER = 0x9918F44C, PL_WPN_NUMBEROFBULLETS = 0x3CF9013F,
            PL_WPN_OVERHEAT = 0x96D534DC, PLANET_TIME = 0x4C034D71, PLAYER_VR_FOLEY_ARMS = 0xBA619E61, POD_SQUISH = 0x47DC0016, PROTOROLLER = 0x98F8B9B1,
            PS5_HEADPHONES = 0x6B9EA36F, PULSE_BUS01_MASTER_VOLUME = 0x42E24B14, PULSE_EVENT_PANFR = 0xF714E8C1, PULSE_EVENT_PANLR = 0x114F803, PULSE_EVENT_PITCH = 0x70C3F202,
            PULSE_EVENT_SENDBUS_00 = 0xB0196737, PULSE_EVENT_SENDBUS_01 = 0xB0196736, PULSE_EVENT_SENDBUS_02 = 0xB0196735, PULSE_EVENT_SENDBUS_03 = 0xB0196734, PULSE_EVENT_VOLUME = 0xCE889A56,
            QUAD_LASERBUILDUP = 0x84FF38B3, RAIN_INTENSITY = 0x9637D55D, RAIN_INTENSITY_BUILDING = 0x83ACB2F0, RAIN_ROOF = 0xFAC73584, RAIN_SHIP_EXTERIOR = 0xCB736AFD,
            RUMBLE_INTENSITY = 0x81780120, SENTINEL_DETECTOR = 0x8157313E, SHORELINE = 0x1A1A962, STORM = 0x648999E0, THEREMIN_PITCH = 0xD774D3B8,
            THEREMIN_VOLUME = 0x26294964, VEHICLE_EXIT = 0xF4378552, VEHICLE_IMPACTS = 0x855298E7, VEHICLE_JUMP = 0x1E1DDD32, VEHICLE_SKID = 0xA1303CF3,
            VEHICLE_SPEED = 0x5979CECB, VEHICLE_SUSPENSION = 0x3016F2FD, VEHICLE_TORQUE = 0x480D482C, WALKER_MOOD = 0xFB1B461B, WPN_PL_JAVELIN_CHARGE = 0xF04467B0
        }
        public AkRTPCEnum AkRTPC;
    }
}
