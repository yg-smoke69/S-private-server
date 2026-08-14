using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D4D")]
public class AkSoundEngine
{
	[Token(Token = "0x2003D4E")]
	public delegate ulong GameObjectHashFunction(GameObject gameObject);

	[Token(Token = "0x2003D4F")]
	private class AutoObject
	{
		[Token(Token = "0x401A14E")]
		[FieldOffset(Offset = "0x8")]
		private readonly GameObject gameObject;

		[Token(Token = "0x60189D4")]
		[Address(RVA = "0x46B59F8", Offset = "0x46B59F8", VA = "0x46B59F8")]
		public AutoObject(GameObject go)
		{
		}

		[Token(Token = "0x60189D5")]
		[Address(RVA = "0x46B5B5C", Offset = "0x46B5B5C", VA = "0x46B5B5C", Slot = "1")]
		~AutoObject()
		{
		}
	}

	[Token(Token = "0x4019FF7")]
	public const int AK_SIMD_ALIGNMENT = 16;

	[Token(Token = "0x4019FF8")]
	public const int AK_BUFFER_ALIGNMENT = 16;

	[Token(Token = "0x4019FF9")]
	public const int AK_MAX_PATH = 260;

	[Token(Token = "0x4019FFA")]
	public const int AK_BANK_PLATFORM_DATA_ALIGNMENT = 16;

	[Token(Token = "0x4019FFB")]
	public const uint AK_INVALID_PLUGINID = uint.MaxValue;

	[Token(Token = "0x4019FFC")]
	public const ulong AK_INVALID_GAME_OBJECT = ulong.MaxValue;

	[Token(Token = "0x4019FFD")]
	public const uint AK_INVALID_UNIQUE_ID = 0u;

	[Token(Token = "0x4019FFE")]
	public const uint AK_INVALID_RTPC_ID = 0u;

	[Token(Token = "0x4019FFF")]
	public const uint AK_INVALID_LISTENER_INDEX = uint.MaxValue;

	[Token(Token = "0x401A000")]
	public const uint AK_INVALID_PLAYING_ID = 0u;

	[Token(Token = "0x401A001")]
	public const uint AK_DEFAULT_SWITCH_STATE = 0u;

	[Token(Token = "0x401A002")]
	public const int AK_INVALID_POOL_ID = -1;

	[Token(Token = "0x401A003")]
	public const int AK_DEFAULT_POOL_ID = -1;

	[Token(Token = "0x401A004")]
	public const uint AK_INVALID_AUX_ID = 0u;

	[Token(Token = "0x401A005")]
	public const uint AK_INVALID_FILE_ID = uint.MaxValue;

	[Token(Token = "0x401A006")]
	public const uint AK_INVALID_DEVICE_ID = uint.MaxValue;

	[Token(Token = "0x401A007")]
	public const uint AK_INVALID_BANK_ID = 0u;

	[Token(Token = "0x401A008")]
	public const uint AK_FALLBACK_ARGUMENTVALUE_ID = 0u;

	[Token(Token = "0x401A009")]
	public const uint AK_INVALID_CHANNELMASK = 0u;

	[Token(Token = "0x401A00A")]
	public const uint AK_INVALID_OUTPUT_DEVICE_ID = 0u;

	[Token(Token = "0x401A00B")]
	public const uint AK_MIXER_FX_SLOT = uint.MaxValue;

	[Token(Token = "0x401A00C")]
	public const ulong AK_DEFAULT_LISTENER_OBJ = 0uL;

	[Token(Token = "0x401A00D")]
	public const uint AK_DEFAULT_PRIORITY = 50u;

	[Token(Token = "0x401A00E")]
	public const uint AK_MIN_PRIORITY = 0u;

	[Token(Token = "0x401A00F")]
	public const uint AK_MAX_PRIORITY = 100u;

	[Token(Token = "0x401A010")]
	public const uint AK_DEFAULT_BANK_IO_PRIORITY = 50u;

	[Token(Token = "0x401A011")]
	public const double AK_DEFAULT_BANK_THROUGHPUT = 1048.576;

	[Token(Token = "0x401A012")]
	public const uint AKCOMPANYID_AUDIOKINETIC = 0u;

	[Token(Token = "0x401A013")]
	public const uint AK_LISTENERS_MASK_ALL = uint.MaxValue;

	[Token(Token = "0x401A014")]
	public const int NULL = 0;

	[Token(Token = "0x401A015")]
	public const int AKCURVEINTERPOLATION_NUM_STORAGE_BIT = 5;

	[Token(Token = "0x401A016")]
	public const int AK_MAX_LANGUAGE_NAME_SIZE = 32;

	[Token(Token = "0x401A017")]
	public const int AKCOMPANYID_PLUGINDEV_MIN = 64;

	[Token(Token = "0x401A018")]
	public const int AKCOMPANYID_PLUGINDEV_MAX = 255;

	[Token(Token = "0x401A019")]
	public const int AKCOMPANYID_AUDIOKINETIC_EXTERNAL = 1;

	[Token(Token = "0x401A01A")]
	public const int AKCOMPANYID_MCDSP = 256;

	[Token(Token = "0x401A01B")]
	public const int AKCOMPANYID_WAVEARTS = 257;

	[Token(Token = "0x401A01C")]
	public const int AKCOMPANYID_PHONETICARTS = 258;

	[Token(Token = "0x401A01D")]
	public const int AKCOMPANYID_IZOTOPE = 259;

	[Token(Token = "0x401A01E")]
	public const int AKCOMPANYID_CRANKCASEAUDIO = 261;

	[Token(Token = "0x401A01F")]
	public const int AKCOMPANYID_IOSONO = 262;

	[Token(Token = "0x401A020")]
	public const int AKCOMPANYID_AUROTECHNOLOGIES = 263;

	[Token(Token = "0x401A021")]
	public const int AKCOMPANYID_DOLBY = 264;

	[Token(Token = "0x401A022")]
	public const int AKCOMPANYID_TWOBIGEARS = 265;

	[Token(Token = "0x401A023")]
	public const int AKCOMPANYID_OCULUS = 266;

	[Token(Token = "0x401A024")]
	public const int AKCOMPANYID_BLUERIPPLESOUND = 267;

	[Token(Token = "0x401A025")]
	public const int AKCOMPANYID_ENZIEN = 268;

	[Token(Token = "0x401A026")]
	public const int AKCOMPANYID_KROTOS = 269;

	[Token(Token = "0x401A027")]
	public const int AKCOMPANYID_NURULIZE = 270;

	[Token(Token = "0x401A028")]
	public const int AKCOMPANYID_SUPERPOWERED = 271;

	[Token(Token = "0x401A029")]
	public const int AKCOMPANYID_GOOGLE = 272;

	[Token(Token = "0x401A02A")]
	public const int AKCOMPANYID_VISISONICS = 277;

	[Token(Token = "0x401A02B")]
	public const int AKCODECID_BANK = 0;

	[Token(Token = "0x401A02C")]
	public const int AKCODECID_PCM = 1;

	[Token(Token = "0x401A02D")]
	public const int AKCODECID_ADPCM = 2;

	[Token(Token = "0x401A02E")]
	public const int AKCODECID_XMA = 3;

	[Token(Token = "0x401A02F")]
	public const int AKCODECID_VORBIS = 4;

	[Token(Token = "0x401A030")]
	public const int AKCODECID_WIIADPCM = 5;

	[Token(Token = "0x401A031")]
	public const int AKCODECID_PCMEX = 7;

	[Token(Token = "0x401A032")]
	public const int AKCODECID_EXTERNAL_SOURCE = 8;

	[Token(Token = "0x401A033")]
	public const int AKCODECID_XWMA = 9;

	[Token(Token = "0x401A034")]
	public const int AKCODECID_AAC = 10;

	[Token(Token = "0x401A035")]
	public const int AKCODECID_FILE_PACKAGE = 11;

	[Token(Token = "0x401A036")]
	public const int AKCODECID_ATRAC9 = 12;

	[Token(Token = "0x401A037")]
	public const int AKCODECID_VAG = 13;

	[Token(Token = "0x401A038")]
	public const int AKCODECID_PROFILERCAPTURE = 14;

	[Token(Token = "0x401A039")]
	public const int AKCODECID_ANALYSISFILE = 15;

	[Token(Token = "0x401A03A")]
	public const int AKCODECID_MIDI = 16;

	[Token(Token = "0x401A03B")]
	public const int AKCODECID_OPUSNX = 17;

	[Token(Token = "0x401A03C")]
	public const int AKCODECID_CAF = 18;

	[Token(Token = "0x401A03D")]
	public const int AKCODECID_AKOPUS = 19;

	[Token(Token = "0x401A03E")]
	public const int AKPLUGINID_METER = 129;

	[Token(Token = "0x401A03F")]
	public const int AKPLUGINID_RECORDER = 132;

	[Token(Token = "0x401A040")]
	public const int AKEXTENSIONID_SPATIALAUDIO = 800;

	[Token(Token = "0x401A041")]
	public const int AKEXTENSIONID_INTERACTIVEMUSIC = 801;

	[Token(Token = "0x401A042")]
	public const int AKEXTENSIONID_EVENTMGRTHREAD = 900;

	[Token(Token = "0x401A043")]
	public const int AK_WAVE_FORMAT_VAG = 65531;

	[Token(Token = "0x401A044")]
	public const int AK_WAVE_FORMAT_AT9 = 65532;

	[Token(Token = "0x401A045")]
	public const int AK_WAVE_FORMAT_VORBIS = 65535;

	[Token(Token = "0x401A046")]
	public const int AK_WAVE_FORMAT_AAC = 43712;

	[Token(Token = "0x401A047")]
	public const int AK_WAVE_FORMAT_OPUSNX = 12345;

	[Token(Token = "0x401A048")]
	public const int AK_WAVE_FORMAT_OPUS = 12352;

	[Token(Token = "0x401A049")]
	public const int WAVE_FORMAT_XMA2 = 358;

	[Token(Token = "0x401A04A")]
	public const int AK_PANNER_NUM_STORAGE_BITS = 3;

	[Token(Token = "0x401A04B")]
	public const int AK_POSSOURCE_NUM_STORAGE_BITS = 3;

	[Token(Token = "0x401A04C")]
	public const int AK_SPAT_NUM_STORAGE_BITS = 3;

	[Token(Token = "0x401A04D")]
	public const int AK_MAX_BITS_METERING_FLAGS = 5;

	[Token(Token = "0x401A04E")]
	public const int AK_OS_STRUCT_ALIGN = 4;

	[Token(Token = "0x401A04F")]
	public const int AK_64B_OS_STRUCT_ALIGN = 8;

	[Token(Token = "0x401A050")]
	public const bool AK_ASYNC_OPEN_DEFAULT = false;

	[Token(Token = "0x401A051")]
	public const int AK_COMM_DEFAULT_DISCOVERY_PORT = 24024;

	[Token(Token = "0x401A052")]
	public const int AK_MIDI_EVENT_TYPE_INVALID = 0;

	[Token(Token = "0x401A053")]
	public const int AK_MIDI_EVENT_TYPE_NOTE_OFF = 128;

	[Token(Token = "0x401A054")]
	public const int AK_MIDI_EVENT_TYPE_NOTE_ON = 144;

	[Token(Token = "0x401A055")]
	public const int AK_MIDI_EVENT_TYPE_NOTE_AFTERTOUCH = 160;

	[Token(Token = "0x401A056")]
	public const int AK_MIDI_EVENT_TYPE_CONTROLLER = 176;

	[Token(Token = "0x401A057")]
	public const int AK_MIDI_EVENT_TYPE_PROGRAM_CHANGE = 192;

	[Token(Token = "0x401A058")]
	public const int AK_MIDI_EVENT_TYPE_CHANNEL_AFTERTOUCH = 208;

	[Token(Token = "0x401A059")]
	public const int AK_MIDI_EVENT_TYPE_PITCH_BEND = 224;

	[Token(Token = "0x401A05A")]
	public const int AK_MIDI_EVENT_TYPE_SYSEX = 240;

	[Token(Token = "0x401A05B")]
	public const int AK_MIDI_EVENT_TYPE_ESCAPE = 247;

	[Token(Token = "0x401A05C")]
	public const int AK_MIDI_EVENT_TYPE_META = 255;

	[Token(Token = "0x401A05D")]
	public const int AK_MIDI_CC_BANK_SELECT_COARSE = 0;

	[Token(Token = "0x401A05E")]
	public const int AK_MIDI_CC_MOD_WHEEL_COARSE = 1;

	[Token(Token = "0x401A05F")]
	public const int AK_MIDI_CC_BREATH_CTRL_COARSE = 2;

	[Token(Token = "0x401A060")]
	public const int AK_MIDI_CC_CTRL_3_COARSE = 3;

	[Token(Token = "0x401A061")]
	public const int AK_MIDI_CC_FOOT_PEDAL_COARSE = 4;

	[Token(Token = "0x401A062")]
	public const int AK_MIDI_CC_PORTAMENTO_COARSE = 5;

	[Token(Token = "0x401A063")]
	public const int AK_MIDI_CC_DATA_ENTRY_COARSE = 6;

	[Token(Token = "0x401A064")]
	public const int AK_MIDI_CC_VOLUME_COARSE = 7;

	[Token(Token = "0x401A065")]
	public const int AK_MIDI_CC_BALANCE_COARSE = 8;

	[Token(Token = "0x401A066")]
	public const int AK_MIDI_CC_CTRL_9_COARSE = 9;

	[Token(Token = "0x401A067")]
	public const int AK_MIDI_CC_PAN_POSITION_COARSE = 10;

	[Token(Token = "0x401A068")]
	public const int AK_MIDI_CC_EXPRESSION_COARSE = 11;

	[Token(Token = "0x401A069")]
	public const int AK_MIDI_CC_EFFECT_CTRL_1_COARSE = 12;

	[Token(Token = "0x401A06A")]
	public const int AK_MIDI_CC_EFFECT_CTRL_2_COARSE = 13;

	[Token(Token = "0x401A06B")]
	public const int AK_MIDI_CC_CTRL_14_COARSE = 14;

	[Token(Token = "0x401A06C")]
	public const int AK_MIDI_CC_CTRL_15_COARSE = 15;

	[Token(Token = "0x401A06D")]
	public const int AK_MIDI_CC_GEN_SLIDER_1 = 16;

	[Token(Token = "0x401A06E")]
	public const int AK_MIDI_CC_GEN_SLIDER_2 = 17;

	[Token(Token = "0x401A06F")]
	public const int AK_MIDI_CC_GEN_SLIDER_3 = 18;

	[Token(Token = "0x401A070")]
	public const int AK_MIDI_CC_GEN_SLIDER_4 = 19;

	[Token(Token = "0x401A071")]
	public const int AK_MIDI_CC_CTRL_20_COARSE = 20;

	[Token(Token = "0x401A072")]
	public const int AK_MIDI_CC_CTRL_21_COARSE = 21;

	[Token(Token = "0x401A073")]
	public const int AK_MIDI_CC_CTRL_22_COARSE = 22;

	[Token(Token = "0x401A074")]
	public const int AK_MIDI_CC_CTRL_23_COARSE = 23;

	[Token(Token = "0x401A075")]
	public const int AK_MIDI_CC_CTRL_24_COARSE = 24;

	[Token(Token = "0x401A076")]
	public const int AK_MIDI_CC_CTRL_25_COARSE = 25;

	[Token(Token = "0x401A077")]
	public const int AK_MIDI_CC_CTRL_26_COARSE = 26;

	[Token(Token = "0x401A078")]
	public const int AK_MIDI_CC_CTRL_27_COARSE = 27;

	[Token(Token = "0x401A079")]
	public const int AK_MIDI_CC_CTRL_28_COARSE = 28;

	[Token(Token = "0x401A07A")]
	public const int AK_MIDI_CC_CTRL_29_COARSE = 29;

	[Token(Token = "0x401A07B")]
	public const int AK_MIDI_CC_CTRL_30_COARSE = 30;

	[Token(Token = "0x401A07C")]
	public const int AK_MIDI_CC_CTRL_31_COARSE = 31;

	[Token(Token = "0x401A07D")]
	public const int AK_MIDI_CC_BANK_SELECT_FINE = 32;

	[Token(Token = "0x401A07E")]
	public const int AK_MIDI_CC_MOD_WHEEL_FINE = 33;

	[Token(Token = "0x401A07F")]
	public const int AK_MIDI_CC_BREATH_CTRL_FINE = 34;

	[Token(Token = "0x401A080")]
	public const int AK_MIDI_CC_CTRL_3_FINE = 35;

	[Token(Token = "0x401A081")]
	public const int AK_MIDI_CC_FOOT_PEDAL_FINE = 36;

	[Token(Token = "0x401A082")]
	public const int AK_MIDI_CC_PORTAMENTO_FINE = 37;

	[Token(Token = "0x401A083")]
	public const int AK_MIDI_CC_DATA_ENTRY_FINE = 38;

	[Token(Token = "0x401A084")]
	public const int AK_MIDI_CC_VOLUME_FINE = 39;

	[Token(Token = "0x401A085")]
	public const int AK_MIDI_CC_BALANCE_FINE = 40;

	[Token(Token = "0x401A086")]
	public const int AK_MIDI_CC_CTRL_9_FINE = 41;

	[Token(Token = "0x401A087")]
	public const int AK_MIDI_CC_PAN_POSITION_FINE = 42;

	[Token(Token = "0x401A088")]
	public const int AK_MIDI_CC_EXPRESSION_FINE = 43;

	[Token(Token = "0x401A089")]
	public const int AK_MIDI_CC_EFFECT_CTRL_1_FINE = 44;

	[Token(Token = "0x401A08A")]
	public const int AK_MIDI_CC_EFFECT_CTRL_2_FINE = 45;

	[Token(Token = "0x401A08B")]
	public const int AK_MIDI_CC_CTRL_14_FINE = 46;

	[Token(Token = "0x401A08C")]
	public const int AK_MIDI_CC_CTRL_15_FINE = 47;

	[Token(Token = "0x401A08D")]
	public const int AK_MIDI_CC_CTRL_20_FINE = 52;

	[Token(Token = "0x401A08E")]
	public const int AK_MIDI_CC_CTRL_21_FINE = 53;

	[Token(Token = "0x401A08F")]
	public const int AK_MIDI_CC_CTRL_22_FINE = 54;

	[Token(Token = "0x401A090")]
	public const int AK_MIDI_CC_CTRL_23_FINE = 55;

	[Token(Token = "0x401A091")]
	public const int AK_MIDI_CC_CTRL_24_FINE = 56;

	[Token(Token = "0x401A092")]
	public const int AK_MIDI_CC_CTRL_25_FINE = 57;

	[Token(Token = "0x401A093")]
	public const int AK_MIDI_CC_CTRL_26_FINE = 58;

	[Token(Token = "0x401A094")]
	public const int AK_MIDI_CC_CTRL_27_FINE = 59;

	[Token(Token = "0x401A095")]
	public const int AK_MIDI_CC_CTRL_28_FINE = 60;

	[Token(Token = "0x401A096")]
	public const int AK_MIDI_CC_CTRL_29_FINE = 61;

	[Token(Token = "0x401A097")]
	public const int AK_MIDI_CC_CTRL_30_FINE = 62;

	[Token(Token = "0x401A098")]
	public const int AK_MIDI_CC_CTRL_31_FINE = 63;

	[Token(Token = "0x401A099")]
	public const int AK_MIDI_CC_HOLD_PEDAL = 64;

	[Token(Token = "0x401A09A")]
	public const int AK_MIDI_CC_PORTAMENTO_ON_OFF = 65;

	[Token(Token = "0x401A09B")]
	public const int AK_MIDI_CC_SUSTENUTO_PEDAL = 66;

	[Token(Token = "0x401A09C")]
	public const int AK_MIDI_CC_SOFT_PEDAL = 67;

	[Token(Token = "0x401A09D")]
	public const int AK_MIDI_CC_LEGATO_PEDAL = 68;

	[Token(Token = "0x401A09E")]
	public const int AK_MIDI_CC_HOLD_PEDAL_2 = 69;

	[Token(Token = "0x401A09F")]
	public const int AK_MIDI_CC_SOUND_VARIATION = 70;

	[Token(Token = "0x401A0A0")]
	public const int AK_MIDI_CC_SOUND_TIMBRE = 71;

	[Token(Token = "0x401A0A1")]
	public const int AK_MIDI_CC_SOUND_RELEASE_TIME = 72;

	[Token(Token = "0x401A0A2")]
	public const int AK_MIDI_CC_SOUND_ATTACK_TIME = 73;

	[Token(Token = "0x401A0A3")]
	public const int AK_MIDI_CC_SOUND_BRIGHTNESS = 74;

	[Token(Token = "0x401A0A4")]
	public const int AK_MIDI_CC_SOUND_CTRL_6 = 75;

	[Token(Token = "0x401A0A5")]
	public const int AK_MIDI_CC_SOUND_CTRL_7 = 76;

	[Token(Token = "0x401A0A6")]
	public const int AK_MIDI_CC_SOUND_CTRL_8 = 77;

	[Token(Token = "0x401A0A7")]
	public const int AK_MIDI_CC_SOUND_CTRL_9 = 78;

	[Token(Token = "0x401A0A8")]
	public const int AK_MIDI_CC_SOUND_CTRL_10 = 79;

	[Token(Token = "0x401A0A9")]
	public const int AK_MIDI_CC_GENERAL_BUTTON_1 = 80;

	[Token(Token = "0x401A0AA")]
	public const int AK_MIDI_CC_GENERAL_BUTTON_2 = 81;

	[Token(Token = "0x401A0AB")]
	public const int AK_MIDI_CC_GENERAL_BUTTON_3 = 82;

	[Token(Token = "0x401A0AC")]
	public const int AK_MIDI_CC_GENERAL_BUTTON_4 = 83;

	[Token(Token = "0x401A0AD")]
	public const int AK_MIDI_CC_REVERB_LEVEL = 91;

	[Token(Token = "0x401A0AE")]
	public const int AK_MIDI_CC_TREMOLO_LEVEL = 92;

	[Token(Token = "0x401A0AF")]
	public const int AK_MIDI_CC_CHORUS_LEVEL = 93;

	[Token(Token = "0x401A0B0")]
	public const int AK_MIDI_CC_CELESTE_LEVEL = 94;

	[Token(Token = "0x401A0B1")]
	public const int AK_MIDI_CC_PHASER_LEVEL = 95;

	[Token(Token = "0x401A0B2")]
	public const int AK_MIDI_CC_DATA_BUTTON_P1 = 96;

	[Token(Token = "0x401A0B3")]
	public const int AK_MIDI_CC_DATA_BUTTON_M1 = 97;

	[Token(Token = "0x401A0B4")]
	public const int AK_MIDI_CC_NON_REGISTER_COARSE = 98;

	[Token(Token = "0x401A0B5")]
	public const int AK_MIDI_CC_NON_REGISTER_FINE = 99;

	[Token(Token = "0x401A0B6")]
	public const int AK_MIDI_CC_ALL_SOUND_OFF = 120;

	[Token(Token = "0x401A0B7")]
	public const int AK_MIDI_CC_ALL_CONTROLLERS_OFF = 121;

	[Token(Token = "0x401A0B8")]
	public const int AK_MIDI_CC_LOCAL_KEYBOARD = 122;

	[Token(Token = "0x401A0B9")]
	public const int AK_MIDI_CC_ALL_NOTES_OFF = 123;

	[Token(Token = "0x401A0BA")]
	public const int AK_MIDI_CC_OMNI_MODE_OFF = 124;

	[Token(Token = "0x401A0BB")]
	public const int AK_MIDI_CC_OMNI_MODE_ON = 125;

	[Token(Token = "0x401A0BC")]
	public const int AK_MIDI_CC_OMNI_MONOPHONIC_ON = 126;

	[Token(Token = "0x401A0BD")]
	public const int AK_MIDI_CC_OMNI_POLYPHONIC_ON = 127;

	[Token(Token = "0x401A0BE")]
	public const int AK_SPEAKER_FRONT_LEFT = 1;

	[Token(Token = "0x401A0BF")]
	public const int AK_SPEAKER_FRONT_RIGHT = 2;

	[Token(Token = "0x401A0C0")]
	public const int AK_SPEAKER_FRONT_CENTER = 4;

	[Token(Token = "0x401A0C1")]
	public const int AK_SPEAKER_LOW_FREQUENCY = 8;

	[Token(Token = "0x401A0C2")]
	public const int AK_SPEAKER_BACK_LEFT = 16;

	[Token(Token = "0x401A0C3")]
	public const int AK_SPEAKER_BACK_RIGHT = 32;

	[Token(Token = "0x401A0C4")]
	public const int AK_SPEAKER_BACK_CENTER = 256;

	[Token(Token = "0x401A0C5")]
	public const int AK_SPEAKER_SIDE_LEFT = 512;

	[Token(Token = "0x401A0C6")]
	public const int AK_SPEAKER_SIDE_RIGHT = 1024;

	[Token(Token = "0x401A0C7")]
	public const int AK_SPEAKER_TOP = 2048;

	[Token(Token = "0x401A0C8")]
	public const int AK_SPEAKER_HEIGHT_FRONT_LEFT = 4096;

	[Token(Token = "0x401A0C9")]
	public const int AK_SPEAKER_HEIGHT_FRONT_CENTER = 8192;

	[Token(Token = "0x401A0CA")]
	public const int AK_SPEAKER_HEIGHT_FRONT_RIGHT = 16384;

	[Token(Token = "0x401A0CB")]
	public const int AK_SPEAKER_HEIGHT_BACK_LEFT = 32768;

	[Token(Token = "0x401A0CC")]
	public const int AK_SPEAKER_HEIGHT_BACK_CENTER = 65536;

	[Token(Token = "0x401A0CD")]
	public const int AK_SPEAKER_HEIGHT_BACK_RIGHT = 131072;

	[Token(Token = "0x401A0CE")]
	public const int AK_SPEAKER_SETUP_MONO = 4;

	[Token(Token = "0x401A0CF")]
	public const int AK_SPEAKER_SETUP_0POINT1 = 8;

	[Token(Token = "0x401A0D0")]
	public const int AK_SPEAKER_SETUP_1POINT1 = 12;

	[Token(Token = "0x401A0D1")]
	public const int AK_SPEAKER_SETUP_STEREO = 3;

	[Token(Token = "0x401A0D2")]
	public const int AK_SPEAKER_SETUP_2POINT1 = 11;

	[Token(Token = "0x401A0D3")]
	public const int AK_SPEAKER_SETUP_3STEREO = 7;

	[Token(Token = "0x401A0D4")]
	public const int AK_SPEAKER_SETUP_3POINT1 = 15;

	[Token(Token = "0x401A0D5")]
	public const int AK_SPEAKER_SETUP_4 = 1539;

	[Token(Token = "0x401A0D6")]
	public const int AK_SPEAKER_SETUP_4POINT1 = 1547;

	[Token(Token = "0x401A0D7")]
	public const int AK_SPEAKER_SETUP_5 = 1543;

	[Token(Token = "0x401A0D8")]
	public const int AK_SPEAKER_SETUP_5POINT1 = 1551;

	[Token(Token = "0x401A0D9")]
	public const int AK_SPEAKER_SETUP_6 = 1587;

	[Token(Token = "0x401A0DA")]
	public const int AK_SPEAKER_SETUP_6POINT1 = 1595;

	[Token(Token = "0x401A0DB")]
	public const int AK_SPEAKER_SETUP_7 = 1591;

	[Token(Token = "0x401A0DC")]
	public const int AK_SPEAKER_SETUP_7POINT1 = 1599;

	[Token(Token = "0x401A0DD")]
	public const int AK_SPEAKER_SETUP_SURROUND = 259;

	[Token(Token = "0x401A0DE")]
	public const int AK_SPEAKER_SETUP_DPL2 = 1539;

	[Token(Token = "0x401A0DF")]
	public const int AK_SPEAKER_SETUP_HEIGHT_4 = 184320;

	[Token(Token = "0x401A0E0")]
	public const int AK_SPEAKER_SETUP_HEIGHT_5 = 192512;

	[Token(Token = "0x401A0E1")]
	public const int AK_SPEAKER_SETUP_HEIGHT_ALL = 258048;

	[Token(Token = "0x401A0E2")]
	public const int AK_SPEAKER_SETUP_AURO_222 = 22019;

	[Token(Token = "0x401A0E3")]
	public const int AK_SPEAKER_SETUP_AURO_8 = 185859;

	[Token(Token = "0x401A0E4")]
	public const int AK_SPEAKER_SETUP_AURO_9 = 185863;

	[Token(Token = "0x401A0E5")]
	public const int AK_SPEAKER_SETUP_AURO_9POINT1 = 185871;

	[Token(Token = "0x401A0E6")]
	public const int AK_SPEAKER_SETUP_AURO_10 = 187911;

	[Token(Token = "0x401A0E7")]
	public const int AK_SPEAKER_SETUP_AURO_10POINT1 = 187919;

	[Token(Token = "0x401A0E8")]
	public const int AK_SPEAKER_SETUP_AURO_11 = 196103;

	[Token(Token = "0x401A0E9")]
	public const int AK_SPEAKER_SETUP_AURO_11POINT1 = 196111;

	[Token(Token = "0x401A0EA")]
	public const int AK_SPEAKER_SETUP_AURO_11_740 = 185911;

	[Token(Token = "0x401A0EB")]
	public const int AK_SPEAKER_SETUP_AURO_11POINT1_740 = 185919;

	[Token(Token = "0x401A0EC")]
	public const int AK_SPEAKER_SETUP_AURO_13_751 = 196151;

	[Token(Token = "0x401A0ED")]
	public const int AK_SPEAKER_SETUP_AURO_13POINT1_751 = 196159;

	[Token(Token = "0x401A0EE")]
	public const int AK_SPEAKER_SETUP_DOLBY_5_0_2 = 22023;

	[Token(Token = "0x401A0EF")]
	public const int AK_SPEAKER_SETUP_DOLBY_5_1_2 = 22031;

	[Token(Token = "0x401A0F0")]
	public const int AK_SPEAKER_SETUP_DOLBY_6_0_2 = 22067;

	[Token(Token = "0x401A0F1")]
	public const int AK_SPEAKER_SETUP_DOLBY_6_1_2 = 22075;

	[Token(Token = "0x401A0F2")]
	public const int AK_SPEAKER_SETUP_DOLBY_6_0_4 = 185907;

	[Token(Token = "0x401A0F3")]
	public const int AK_SPEAKER_SETUP_DOLBY_6_1_4 = 185915;

	[Token(Token = "0x401A0F4")]
	public const int AK_SPEAKER_SETUP_DOLBY_7_0_2 = 22071;

	[Token(Token = "0x401A0F5")]
	public const int AK_SPEAKER_SETUP_DOLBY_7_1_2 = 22079;

	[Token(Token = "0x401A0F6")]
	public const int AK_SPEAKER_SETUP_DOLBY_7_0_4 = 185911;

	[Token(Token = "0x401A0F7")]
	public const int AK_SPEAKER_SETUP_DOLBY_7_1_4 = 185919;

	[Token(Token = "0x401A0F8")]
	public const int AK_SPEAKER_SETUP_ALL_SPEAKERS = 261951;

	[Token(Token = "0x401A0F9")]
	public const int AK_IDX_SETUP_FRONT_LEFT = 0;

	[Token(Token = "0x401A0FA")]
	public const int AK_IDX_SETUP_FRONT_RIGHT = 1;

	[Token(Token = "0x401A0FB")]
	public const int AK_IDX_SETUP_CENTER = 2;

	[Token(Token = "0x401A0FC")]
	public const int AK_IDX_SETUP_NOCENTER_BACK_LEFT = 2;

	[Token(Token = "0x401A0FD")]
	public const int AK_IDX_SETUP_NOCENTER_BACK_RIGHT = 3;

	[Token(Token = "0x401A0FE")]
	public const int AK_IDX_SETUP_NOCENTER_SIDE_LEFT = 4;

	[Token(Token = "0x401A0FF")]
	public const int AK_IDX_SETUP_NOCENTER_SIDE_RIGHT = 5;

	[Token(Token = "0x401A100")]
	public const int AK_IDX_SETUP_WITHCENTER_BACK_LEFT = 3;

	[Token(Token = "0x401A101")]
	public const int AK_IDX_SETUP_WITHCENTER_BACK_RIGHT = 4;

	[Token(Token = "0x401A102")]
	public const int AK_IDX_SETUP_WITHCENTER_SIDE_LEFT = 5;

	[Token(Token = "0x401A103")]
	public const int AK_IDX_SETUP_WITHCENTER_SIDE_RIGHT = 6;

	[Token(Token = "0x401A104")]
	public const int AK_IDX_SETUP_0_LFE = 0;

	[Token(Token = "0x401A105")]
	public const int AK_IDX_SETUP_1_CENTER = 0;

	[Token(Token = "0x401A106")]
	public const int AK_IDX_SETUP_1_LFE = 1;

	[Token(Token = "0x401A107")]
	public const int AK_IDX_SETUP_2_LEFT = 0;

	[Token(Token = "0x401A108")]
	public const int AK_IDX_SETUP_2_RIGHT = 1;

	[Token(Token = "0x401A109")]
	public const int AK_IDX_SETUP_2_LFE = 2;

	[Token(Token = "0x401A10A")]
	public const int AK_IDX_SETUP_3_LEFT = 0;

	[Token(Token = "0x401A10B")]
	public const int AK_IDX_SETUP_3_RIGHT = 1;

	[Token(Token = "0x401A10C")]
	public const int AK_IDX_SETUP_3_CENTER = 2;

	[Token(Token = "0x401A10D")]
	public const int AK_IDX_SETUP_3_LFE = 3;

	[Token(Token = "0x401A10E")]
	public const int AK_IDX_SETUP_4_FRONTLEFT = 0;

	[Token(Token = "0x401A10F")]
	public const int AK_IDX_SETUP_4_FRONTRIGHT = 1;

	[Token(Token = "0x401A110")]
	public const int AK_IDX_SETUP_4_REARLEFT = 2;

	[Token(Token = "0x401A111")]
	public const int AK_IDX_SETUP_4_REARRIGHT = 3;

	[Token(Token = "0x401A112")]
	public const int AK_IDX_SETUP_4_LFE = 4;

	[Token(Token = "0x401A113")]
	public const int AK_IDX_SETUP_5_FRONTLEFT = 0;

	[Token(Token = "0x401A114")]
	public const int AK_IDX_SETUP_5_FRONTRIGHT = 1;

	[Token(Token = "0x401A115")]
	public const int AK_IDX_SETUP_5_CENTER = 2;

	[Token(Token = "0x401A116")]
	public const int AK_IDX_SETUP_5_REARLEFT = 3;

	[Token(Token = "0x401A117")]
	public const int AK_IDX_SETUP_5_REARRIGHT = 4;

	[Token(Token = "0x401A118")]
	public const int AK_IDX_SETUP_5_LFE = 5;

	[Token(Token = "0x401A119")]
	public const int AK_IDX_SETUP_6_FRONTLEFT = 0;

	[Token(Token = "0x401A11A")]
	public const int AK_IDX_SETUP_6_FRONTRIGHT = 1;

	[Token(Token = "0x401A11B")]
	public const int AK_IDX_SETUP_6_REARLEFT = 2;

	[Token(Token = "0x401A11C")]
	public const int AK_IDX_SETUP_6_REARRIGHT = 3;

	[Token(Token = "0x401A11D")]
	public const int AK_IDX_SETUP_6_SIDELEFT = 4;

	[Token(Token = "0x401A11E")]
	public const int AK_IDX_SETUP_6_SIDERIGHT = 5;

	[Token(Token = "0x401A11F")]
	public const int AK_IDX_SETUP_6_LFE = 6;

	[Token(Token = "0x401A120")]
	public const int AK_IDX_SETUP_7_FRONTLEFT = 0;

	[Token(Token = "0x401A121")]
	public const int AK_IDX_SETUP_7_FRONTRIGHT = 1;

	[Token(Token = "0x401A122")]
	public const int AK_IDX_SETUP_7_CENTER = 2;

	[Token(Token = "0x401A123")]
	public const int AK_IDX_SETUP_7_REARLEFT = 3;

	[Token(Token = "0x401A124")]
	public const int AK_IDX_SETUP_7_REARRIGHT = 4;

	[Token(Token = "0x401A125")]
	public const int AK_IDX_SETUP_7_SIDELEFT = 5;

	[Token(Token = "0x401A126")]
	public const int AK_IDX_SETUP_7_SIDERIGHT = 6;

	[Token(Token = "0x401A127")]
	public const int AK_IDX_SETUP_7_LFE = 7;

	[Token(Token = "0x401A128")]
	public const int AK_SPEAKER_SETUP_0_1 = 8;

	[Token(Token = "0x401A129")]
	public const int AK_SPEAKER_SETUP_1_0_CENTER = 4;

	[Token(Token = "0x401A12A")]
	public const int AK_SPEAKER_SETUP_1_1_CENTER = 12;

	[Token(Token = "0x401A12B")]
	public const int AK_SPEAKER_SETUP_2_0 = 3;

	[Token(Token = "0x401A12C")]
	public const int AK_SPEAKER_SETUP_2_1 = 11;

	[Token(Token = "0x401A12D")]
	public const int AK_SPEAKER_SETUP_3_0 = 7;

	[Token(Token = "0x401A12E")]
	public const int AK_SPEAKER_SETUP_3_1 = 15;

	[Token(Token = "0x401A12F")]
	public const int AK_SPEAKER_SETUP_FRONT = 7;

	[Token(Token = "0x401A130")]
	public const int AK_SPEAKER_SETUP_4_0 = 1539;

	[Token(Token = "0x401A131")]
	public const int AK_SPEAKER_SETUP_4_1 = 1547;

	[Token(Token = "0x401A132")]
	public const int AK_SPEAKER_SETUP_5_0 = 1543;

	[Token(Token = "0x401A133")]
	public const int AK_SPEAKER_SETUP_5_1 = 1551;

	[Token(Token = "0x401A134")]
	public const int AK_SPEAKER_SETUP_6_0 = 1587;

	[Token(Token = "0x401A135")]
	public const int AK_SPEAKER_SETUP_6_1 = 1595;

	[Token(Token = "0x401A136")]
	public const int AK_SPEAKER_SETUP_7_0 = 1591;

	[Token(Token = "0x401A137")]
	public const int AK_SPEAKER_SETUP_7_1 = 1599;

	[Token(Token = "0x401A138")]
	public const int AK_SPEAKER_SETUP_DEFAULT_PLANE = 1599;

	[Token(Token = "0x401A139")]
	public const int AK_SUPPORTED_STANDARD_CHANNEL_MASK = 261951;

	[Token(Token = "0x401A13A")]
	public const int AK_STANDARD_MAX_NUM_CHANNELS = 8;

	[Token(Token = "0x401A13B")]
	public const int AK_NUM_SAMPLED_SPHERE_POINTS = 32;

	[Token(Token = "0x401A13C")]
	public const int AK_MAX_NUM_TEXTURE = 4;

	[Token(Token = "0x401A13D")]
	public const int AK_MAX_REFLECT_ORDER = 4;

	[Token(Token = "0x401A13E")]
	public const int AK_MAX_REFLECTION_PATH_LENGTH = 6;

	[Token(Token = "0x401A13F")]
	public const int AK_MAX_SOUND_PROPAGATION_DEPTH = 8;

	[Token(Token = "0x401A140")]
	public const double AK_DEFAULT_DIFFR_SHADOW_DEGREES = 30.0;

	[Token(Token = "0x401A141")]
	public const double AK_DEFAULT_DIFFR_SHADOW_ATTEN = 2.0;

	[Token(Token = "0x401A142")]
	public const double AK_DEFAULT_MOVEMENT_THRESHOLD = 1.0;

	[Token(Token = "0x401A143")]
	public const double AK_SA_EPSILON = 0.001;

	[Token(Token = "0x401A144")]
	public const double AK_SA_DIFFRACTION_EPSILON = 0.1;

	[Token(Token = "0x401A145")]
	public const double AK_SA_PLANE_THICKNESS_RATIO = 0.005;

	[Token(Token = "0x401A146")]
	[FieldOffset(Offset = "0x0")]
	private static GameObjectHashFunction gameObjectHash;

	[Token(Token = "0x401A147")]
	public const string Deprecation_2018_1_2 = "This functionality is deprecated as of Wwise v2018.1.2 and will be removed in a future release.";

	[Token(Token = "0x401A148")]
	public const string Deprecation_2018_1_6 = "This functionality is deprecated as of Wwise v2018.1.6 and will be removed in a future release.";

	[Token(Token = "0x401A149")]
	public const string Deprecation_2019_1_1 = "This functionality is deprecated as of Wwise v2019.1.1 and will be removed in a future release.";

	[Token(Token = "0x401A14A")]
	public const string Deprecation_2019_1_8 = "This functionality is deprecated as of Wwise v2019.1.8 and will be removed in a future release.";

	[Token(Token = "0x401A14B")]
	[FieldOffset(Offset = "0x4")]
	private static readonly HashSet<ulong> RegisteredGameObjects;

	[Token(Token = "0x401A14C")]
	[FieldOffset(Offset = "0x8")]
	private static GameObjectHashFunction _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x401A14D")]
	[FieldOffset(Offset = "0xC")]
	private static GameObjectHashFunction _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x17001A00")]
	public static uint AK_SOUNDBANK_VERSION
	{
		[Token(Token = "0x6018868")]
		[Address(RVA = "0x36CB540", Offset = "0x36CB540", VA = "0x36CB540")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001A01")]
	public static ushort AK_INT
	{
		[Token(Token = "0x6018869")]
		[Address(RVA = "0x36CB5BC", Offset = "0x36CB5BC", VA = "0x36CB5BC")]
		get
		{
			return default(ushort);
		}
	}

	[Token(Token = "0x17001A02")]
	public static ushort AK_FLOAT
	{
		[Token(Token = "0x601886A")]
		[Address(RVA = "0x36CB638", Offset = "0x36CB638", VA = "0x36CB638")]
		get
		{
			return default(ushort);
		}
	}

	[Token(Token = "0x17001A03")]
	public static byte AK_INTERLEAVED
	{
		[Token(Token = "0x601886B")]
		[Address(RVA = "0x36CB6B4", Offset = "0x36CB6B4", VA = "0x36CB6B4")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x17001A04")]
	public static byte AK_NONINTERLEAVED
	{
		[Token(Token = "0x601886C")]
		[Address(RVA = "0x36CB730", Offset = "0x36CB730", VA = "0x36CB730")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x17001A05")]
	public static uint AK_LE_NATIVE_BITSPERSAMPLE
	{
		[Token(Token = "0x601886D")]
		[Address(RVA = "0x36CB7AC", Offset = "0x36CB7AC", VA = "0x36CB7AC")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001A06")]
	public static uint AK_LE_NATIVE_SAMPLETYPE
	{
		[Token(Token = "0x601886E")]
		[Address(RVA = "0x36CB828", Offset = "0x36CB828", VA = "0x36CB828")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001A07")]
	public static uint AK_LE_NATIVE_INTERLEAVE
	{
		[Token(Token = "0x601886F")]
		[Address(RVA = "0x36CB8A4", Offset = "0x36CB8A4", VA = "0x36CB8A4")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001A08")]
	public static byte AK_INVALID_MIDI_CHANNEL
	{
		[Token(Token = "0x6018941")]
		[Address(RVA = "0x36D64BC", Offset = "0x36D64BC", VA = "0x36D64BC")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x17001A09")]
	public static byte AK_INVALID_MIDI_NOTE
	{
		[Token(Token = "0x6018942")]
		[Address(RVA = "0x36D6538", Offset = "0x36D6538", VA = "0x36D6538")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x17001A0A")]
	public static float kDefaultMaxPathLength
	{
		[Token(Token = "0x6018977")]
		[Address(RVA = "0x36D8AD0", Offset = "0x36D8AD0", VA = "0x36D8AD0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001A0B")]
	public static uint kDefaultDiffractionMaxEdges
	{
		[Token(Token = "0x6018978")]
		[Address(RVA = "0x36D8B4C", Offset = "0x36D8B4C", VA = "0x36D8B4C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001A0C")]
	public static uint kDefaultDiffractionMaxPaths
	{
		[Token(Token = "0x6018979")]
		[Address(RVA = "0x36D8BC8", Offset = "0x36D8BC8", VA = "0x36D8BC8")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001A0D")]
	public static float kMaxDiffraction
	{
		[Token(Token = "0x601897A")]
		[Address(RVA = "0x36D8C44", Offset = "0x36D8C44", VA = "0x36D8C44")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001A0E")]
	public static uint kListenerDiffractionMaxEdges
	{
		[Token(Token = "0x601897B")]
		[Address(RVA = "0x36D8CC0", Offset = "0x36D8CC0", VA = "0x36D8CC0")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001A0F")]
	public static uint kListenerDiffractionMaxPaths
	{
		[Token(Token = "0x601897C")]
		[Address(RVA = "0x36D8D3C", Offset = "0x36D8D3C", VA = "0x36D8D3C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001A10")]
	public static uint kPortalToPortalDiffractionMaxPaths
	{
		[Token(Token = "0x601897D")]
		[Address(RVA = "0x36D8DB8", Offset = "0x36D8DB8", VA = "0x36D8DB8")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001A11")]
	public static int g_SpatialAudioPoolId
	{
		[Token(Token = "0x601897F")]
		[Address(RVA = "0x36D8EB8", Offset = "0x36D8EB8", VA = "0x36D8EB8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x601897E")]
		[Address(RVA = "0x36D8E34", Offset = "0x36D8E34", VA = "0x36D8E34")]
		set
		{
		}
	}

	[Token(Token = "0x17001A12")]
	public static GameObjectHashFunction GameObjectHash
	{
		[Token(Token = "0x60189BD")]
		[Address(RVA = "0x36DB68C", Offset = "0x36DB68C", VA = "0x36DB68C")]
		set
		{
		}
	}

	[Token(Token = "0x6018867")]
	[Address(RVA = "0x36CB538", Offset = "0x36CB538", VA = "0x36CB538")]
	public AkSoundEngine()
	{
	}

	[Token(Token = "0x6018870")]
	[Address(RVA = "0x36CB920", Offset = "0x36CB920", VA = "0x36CB920")]
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, AkDynamicSequenceType in_eDynamicSequenceType)
	{
		return default(uint);
	}

	[Token(Token = "0x6018871")]
	[Address(RVA = "0x36CBAC8", Offset = "0x36CBAC8", VA = "0x36CBAC8")]
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie)
	{
		return default(uint);
	}

	[Token(Token = "0x6018872")]
	[Address(RVA = "0x36CBC6C", Offset = "0x36CBC6C", VA = "0x36CBC6C")]
	public static uint DynamicSequenceOpen(GameObject in_gameObjectID)
	{
		return default(uint);
	}

	[Token(Token = "0x6018873")]
	[Address(RVA = "0x36CBD88", Offset = "0x36CBD88", VA = "0x36CBD88")]
	public static AKRESULT DynamicSequenceClose(uint in_playingID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018874")]
	[Address(RVA = "0x36CBE0C", Offset = "0x36CBE0C", VA = "0x36CBE0C")]
	public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018875")]
	[Address(RVA = "0x36CBEA0", Offset = "0x36CBEA0", VA = "0x36CBEA0")]
	public static AKRESULT DynamicSequencePlay(uint in_playingID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018876")]
	[Address(RVA = "0x36CBF2C", Offset = "0x36CBF2C", VA = "0x36CBF2C")]
	public static AKRESULT DynamicSequencePlay(uint in_playingID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018877")]
	[Address(RVA = "0x36CBFB0", Offset = "0x36CBFB0", VA = "0x36CBFB0")]
	public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018878")]
	[Address(RVA = "0x36CC044", Offset = "0x36CC044", VA = "0x36CC044")]
	public static AKRESULT DynamicSequencePause(uint in_playingID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018879")]
	[Address(RVA = "0x36CC0D0", Offset = "0x36CC0D0", VA = "0x36CC0D0")]
	public static AKRESULT DynamicSequencePause(uint in_playingID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601887A")]
	[Address(RVA = "0x36CC154", Offset = "0x36CC154", VA = "0x36CC154")]
	public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601887B")]
	[Address(RVA = "0x36CC1E8", Offset = "0x36CC1E8", VA = "0x36CC1E8")]
	public static AKRESULT DynamicSequenceResume(uint in_playingID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601887C")]
	[Address(RVA = "0x36CC274", Offset = "0x36CC274", VA = "0x36CC274")]
	public static AKRESULT DynamicSequenceResume(uint in_playingID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601887D")]
	[Address(RVA = "0x36CC2F8", Offset = "0x36CC2F8", VA = "0x36CC2F8")]
	public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601887E")]
	[Address(RVA = "0x36CC38C", Offset = "0x36CC38C", VA = "0x36CC38C")]
	public static AKRESULT DynamicSequenceStop(uint in_playingID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601887F")]
	[Address(RVA = "0x36CC418", Offset = "0x36CC418", VA = "0x36CC418")]
	public static AKRESULT DynamicSequenceStop(uint in_playingID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018880")]
	[Address(RVA = "0x36CC49C", Offset = "0x36CC49C", VA = "0x36CC49C")]
	public static AKRESULT DynamicSequenceBreak(uint in_playingID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018881")]
	[Address(RVA = "0x36CC520", Offset = "0x36CC520", VA = "0x36CC520")]
	public static AKRESULT DynamicSequenceGetPauseTimes(uint in_playingID, out uint out_uTime, out uint out_uDuration)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018882")]
	[Address(RVA = "0x36CC5B4", Offset = "0x36CC5B4", VA = "0x36CC5B4")]
	public static AkPlaylist DynamicSequenceLockPlaylist(uint in_playingID)
	{
		return null;
	}

	[Token(Token = "0x6018883")]
	[Address(RVA = "0x36CC67C", Offset = "0x36CC67C", VA = "0x36CC67C")]
	public static AKRESULT DynamicSequenceUnlockPlaylist(uint in_playingID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018884")]
	[Address(RVA = "0x36CC700", Offset = "0x36CC700", VA = "0x36CC700")]
	public static bool IsInitialized()
	{
		return default(bool);
	}

	[Token(Token = "0x6018885")]
	[Address(RVA = "0x36CC77C", Offset = "0x36CC77C", VA = "0x36CC77C")]
	public static AKRESULT GetAudioSettings(AkAudioSettings out_audioSettings)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018886")]
	[Address(RVA = "0x36CC810", Offset = "0x36CC810", VA = "0x36CC810")]
	public static AkChannelConfig GetSpeakerConfiguration(ulong in_idOutput)
	{
		return null;
	}

	[Token(Token = "0x6018887")]
	[Address(RVA = "0x36CC8CC", Offset = "0x36CC8CC", VA = "0x36CC8CC")]
	public static AkChannelConfig GetSpeakerConfiguration()
	{
		return null;
	}

	[Token(Token = "0x6018888")]
	[Address(RVA = "0x36CC978", Offset = "0x36CC978", VA = "0x36CC978")]
	public static AKRESULT GetPanningRule(out int out_ePanningRule, ulong in_idOutput)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018889")]
	[Address(RVA = "0x36CCA18", Offset = "0x36CCA18", VA = "0x36CCA18")]
	public static AKRESULT GetPanningRule(out int out_ePanningRule)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601888A")]
	[Address(RVA = "0x36CCA9C", Offset = "0x36CCA9C", VA = "0x36CCA9C")]
	public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule, ulong in_idOutput)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601888B")]
	[Address(RVA = "0x36CCB3C", Offset = "0x36CCB3C", VA = "0x36CCB3C")]
	public static AKRESULT SetPanningRule(AkPanningRule in_ePanningRule)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601888C")]
	[Address(RVA = "0x36CCBC0", Offset = "0x36CCBC0", VA = "0x36CCBC0")]
	public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle, ulong in_idOutput)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601888D")]
	[Address(RVA = "0x36CCC6C", Offset = "0x36CCC6C", VA = "0x36CCC6C")]
	public static AKRESULT GetSpeakerAngles(float[] io_pfSpeakerAngles, ref uint io_uNumAngles, out float out_fHeightAngle)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601888E")]
	[Address(RVA = "0x36CCD00", Offset = "0x36CCD00", VA = "0x36CCD00")]
	public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle, ulong in_idOutput)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601888F")]
	[Address(RVA = "0x36CCDAC", Offset = "0x36CCDAC", VA = "0x36CCDAC")]
	public static AKRESULT SetSpeakerAngles(float[] in_pfSpeakerAngles, uint in_uNumAngles, float in_fHeightAngle)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018890")]
	[Address(RVA = "0x36CCE40", Offset = "0x36CCE40", VA = "0x36CCE40")]
	public static AKRESULT SetVolumeThreshold(float in_fVolumeThresholdDB)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018891")]
	[Address(RVA = "0x36CCEC4", Offset = "0x36CCEC4", VA = "0x36CCEC4")]
	public static AKRESULT SetMaxNumVoicesLimit(ushort in_maxNumberVoices)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018892")]
	[Address(RVA = "0x36CCF48", Offset = "0x36CCF48", VA = "0x36CCF48")]
	public static AKRESULT RenderAudio(bool in_bAllowSyncRender)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018893")]
	[Address(RVA = "0x36CCFCC", Offset = "0x36CCFCC", VA = "0x36CCFCC")]
	public static AKRESULT RenderAudio()
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018894")]
	[Address(RVA = "0x36CD048", Offset = "0x36CD048", VA = "0x36CD048")]
	public static AKRESULT RegisterPluginDLL(string in_DllName, string in_DllPath)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018895")]
	[Address(RVA = "0x36CD0D4", Offset = "0x36CD0D4", VA = "0x36CD0D4")]
	public static AKRESULT RegisterPluginDLL(string in_DllName)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018896")]
	[Address(RVA = "0x36CD158", Offset = "0x36CD158", VA = "0x36CD158")]
	public static uint GetIDFromString(string in_pszString)
	{
		return default(uint);
	}

	[Token(Token = "0x6018897")]
	[Address(RVA = "0x36CD1DC", Offset = "0x36CD1DC", VA = "0x36CD1DC")]
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID)
	{
		return default(uint);
	}

	[Token(Token = "0x6018898")]
	[Address(RVA = "0x36CD3C8", Offset = "0x36CD3C8", VA = "0x36CD3C8")]
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
	{
		return default(uint);
	}

	[Token(Token = "0x6018899")]
	[Address(RVA = "0x36CD5AC", Offset = "0x36CD5AC", VA = "0x36CD5AC")]
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie)
	{
		return default(uint);
	}

	[Token(Token = "0x601889A")]
	[Address(RVA = "0x36CD754", Offset = "0x36CD754", VA = "0x36CD754")]
	public static uint PostEvent(uint in_eventID, GameObject in_gameObjectID)
	{
		return default(uint);
	}

	[Token(Token = "0x601889B")]
	[Address(RVA = "0x36CD87C", Offset = "0x36CD87C", VA = "0x36CD87C")]
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources, uint in_PlayingID)
	{
		return default(uint);
	}

	[Token(Token = "0x601889C")]
	[Address(RVA = "0x36CDA68", Offset = "0x36CDA68", VA = "0x36CDA68")]
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
	{
		return default(uint);
	}

	[Token(Token = "0x601889D")]
	[Address(RVA = "0x36CDC4C", Offset = "0x36CDC4C", VA = "0x36CDC4C")]
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID, uint in_uFlags, AkCallbackManager.EventCallback in_pfnCallback, object in_pCookie)
	{
		return default(uint);
	}

	[Token(Token = "0x601889E")]
	[Address(RVA = "0x36CDDF4", Offset = "0x36CDDF4", VA = "0x36CDDF4")]
	public static uint PostEvent(string in_pszEventName, GameObject in_gameObjectID)
	{
		return default(uint);
	}

	[Token(Token = "0x601889F")]
	[Address(RVA = "0x36CDF1C", Offset = "0x36CDF1C", VA = "0x36CDF1C")]
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188A0")]
	[Address(RVA = "0x36CE020", Offset = "0x36CE020", VA = "0x36CE020")]
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188A1")]
	[Address(RVA = "0x36CE11C", Offset = "0x36CE11C", VA = "0x36CE11C")]
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188A2")]
	[Address(RVA = "0x36CE214", Offset = "0x36CE214", VA = "0x36CE214")]
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188A3")]
	[Address(RVA = "0x36CE304", Offset = "0x36CE304", VA = "0x36CE304")]
	public static AKRESULT ExecuteActionOnEvent(uint in_eventID, AkActionOnEventType in_ActionType)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188A4")]
	[Address(RVA = "0x36CE390", Offset = "0x36CE390", VA = "0x36CE390")]
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188A5")]
	[Address(RVA = "0x36CE494", Offset = "0x36CE494", VA = "0x36CE494")]
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188A6")]
	[Address(RVA = "0x36CE590", Offset = "0x36CE590", VA = "0x36CE590")]
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID, int in_uTransitionDuration)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188A7")]
	[Address(RVA = "0x36CE688", Offset = "0x36CE688", VA = "0x36CE688")]
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188A8")]
	[Address(RVA = "0x36CE778", Offset = "0x36CE778", VA = "0x36CE778")]
	public static AKRESULT ExecuteActionOnEvent(string in_pszEventName, AkActionOnEventType in_ActionType)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188A9")]
	[Address(RVA = "0x36CE804", Offset = "0x36CE804", VA = "0x36CE804")]
	public static AKRESULT PostMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID, AkMIDIPostArray in_pPosts, ushort in_uNumPosts)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188AA")]
	[Address(RVA = "0x36CE90C", Offset = "0x36CE90C", VA = "0x36CE90C")]
	public static AKRESULT StopMIDIOnEvent(uint in_eventID, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188AB")]
	[Address(RVA = "0x36CE9F4", Offset = "0x36CE9F4", VA = "0x36CE9F4")]
	public static AKRESULT StopMIDIOnEvent(uint in_eventID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188AC")]
	[Address(RVA = "0x36CEA78", Offset = "0x36CEA78", VA = "0x36CEA78")]
	public static AKRESULT StopMIDIOnEvent()
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188AD")]
	[Address(RVA = "0x36CEAF4", Offset = "0x36CEAF4", VA = "0x36CEAF4")]
	public static AKRESULT PinEventInStreamCache(uint in_eventID, sbyte in_uActivePriority, sbyte in_uInactivePriority)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188AE")]
	[Address(RVA = "0x36CEB88", Offset = "0x36CEB88", VA = "0x36CEB88")]
	public static AKRESULT PinEventInStreamCache(string in_pszEventName, sbyte in_uActivePriority, sbyte in_uInactivePriority)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188AF")]
	[Address(RVA = "0x36CEC1C", Offset = "0x36CEC1C", VA = "0x36CEC1C")]
	public static AKRESULT UnpinEventInStreamCache(uint in_eventID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188B0")]
	[Address(RVA = "0x36CECA0", Offset = "0x36CECA0", VA = "0x36CECA0")]
	public static AKRESULT UnpinEventInStreamCache(string in_pszEventName)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188B1")]
	[Address(RVA = "0x36CED24", Offset = "0x36CED24", VA = "0x36CED24")]
	public static AKRESULT GetBufferStatusForPinnedEvent(uint in_eventID, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188B2")]
	[Address(RVA = "0x36CEDB8", Offset = "0x36CEDB8", VA = "0x36CEDB8")]
	public static AKRESULT GetBufferStatusForPinnedEvent(string in_pszEventName, out float out_fPercentBuffered, out int out_bCachePinnedMemoryFull)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188B3")]
	[Address(RVA = "0x36CEE4C", Offset = "0x36CEE4C", VA = "0x36CEE4C")]
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188B4")]
	[Address(RVA = "0x36CEF44", Offset = "0x36CEF44", VA = "0x36CEF44")]
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188B5")]
	[Address(RVA = "0x36CF038", Offset = "0x36CF038", VA = "0x36CF038")]
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, int in_iPosition)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188B6")]
	[Address(RVA = "0x36CF128", Offset = "0x36CF128", VA = "0x36CF128")]
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188B7")]
	[Address(RVA = "0x36CF220", Offset = "0x36CF220", VA = "0x36CF220")]
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition, bool in_bSeekToNearestMarker)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188B8")]
	[Address(RVA = "0x36CF314", Offset = "0x36CF314", VA = "0x36CF314")]
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, int in_iPosition)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188B9")]
	[Address(RVA = "0x36CF404", Offset = "0x36CF404", VA = "0x36CF404")]
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188BA")]
	[Address(RVA = "0x36CF50C", Offset = "0x36CF50C", VA = "0x36CF50C")]
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188BB")]
	[Address(RVA = "0x36CF610", Offset = "0x36CF610", VA = "0x36CF610")]
	public static AKRESULT SeekOnEvent(uint in_eventID, GameObject in_gameObjectID, float in_fPercent)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188BC")]
	[Address(RVA = "0x36CF70C", Offset = "0x36CF70C", VA = "0x36CF70C")]
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker, uint in_PlayingID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188BD")]
	[Address(RVA = "0x36CF814", Offset = "0x36CF814", VA = "0x36CF814")]
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent, bool in_bSeekToNearestMarker)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188BE")]
	[Address(RVA = "0x36CF918", Offset = "0x36CF918", VA = "0x36CF918")]
	public static AKRESULT SeekOnEvent(string in_pszEventName, GameObject in_gameObjectID, float in_fPercent)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188BF")]
	[Address(RVA = "0x36CFA14", Offset = "0x36CFA14", VA = "0x36CFA14")]
	public static void CancelEventCallbackCookie(object in_pCookie)
	{
	}

	[Token(Token = "0x60188C0")]
	[Address(RVA = "0x36CFA98", Offset = "0x36CFA98", VA = "0x36CFA98")]
	public static void CancelEventCallbackGameObject(GameObject in_gameObjectID)
	{
	}

	[Token(Token = "0x60188C1")]
	[Address(RVA = "0x36CFB74", Offset = "0x36CFB74", VA = "0x36CFB74")]
	public static void CancelEventCallback(uint in_playingID)
	{
	}

	[Token(Token = "0x60188C2")]
	[Address(RVA = "0x36CFBF8", Offset = "0x36CFBF8", VA = "0x36CFBF8")]
	public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition, bool in_bExtrapolate)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188C3")]
	[Address(RVA = "0x36CFC8C", Offset = "0x36CFC8C", VA = "0x36CFC8C")]
	public static AKRESULT GetSourcePlayPosition(uint in_PlayingID, out int out_puPosition)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188C4")]
	[Address(RVA = "0x36CFD18", Offset = "0x36CFD18", VA = "0x36CFD18")]
	public static AKRESULT GetSourceStreamBuffering(uint in_PlayingID, out int out_buffering, out int out_bIsBuffering)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188C5")]
	[Address(RVA = "0x36CFDAC", Offset = "0x36CFDAC", VA = "0x36CFDAC")]
	public static void StopAll(GameObject in_gameObjectID)
	{
	}

	[Token(Token = "0x60188C6")]
	[Address(RVA = "0x36CFE88", Offset = "0x36CFE88", VA = "0x36CFE88")]
	public static void StopAll()
	{
	}

	[Token(Token = "0x60188C7")]
	[Address(RVA = "0x36CFF04", Offset = "0x36CFF04", VA = "0x36CFF04")]
	public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
	}

	[Token(Token = "0x60188C8")]
	[Address(RVA = "0x36CFF98", Offset = "0x36CFF98", VA = "0x36CFF98")]
	public static void StopPlayingID(uint in_playingID, int in_uTransitionDuration)
	{
	}

	[Token(Token = "0x60188C9")]
	[Address(RVA = "0x36D0024", Offset = "0x36D0024", VA = "0x36D0024")]
	public static void StopPlayingID(uint in_playingID)
	{
	}

	[Token(Token = "0x60188CA")]
	[Address(RVA = "0x36D00A8", Offset = "0x36D00A8", VA = "0x36D00A8")]
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration, AkCurveInterpolation in_eFadeCurve)
	{
	}

	[Token(Token = "0x60188CB")]
	[Address(RVA = "0x36D0150", Offset = "0x36D0150", VA = "0x36D0150")]
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID, int in_uTransitionDuration)
	{
	}

	[Token(Token = "0x60188CC")]
	[Address(RVA = "0x36D01E4", Offset = "0x36D01E4", VA = "0x36D01E4")]
	public static void ExecuteActionOnPlayingID(AkActionOnEventType in_ActionType, uint in_playingID)
	{
	}

	[Token(Token = "0x60188CD")]
	[Address(RVA = "0x36D0270", Offset = "0x36D0270", VA = "0x36D0270")]
	public static void SetRandomSeed(uint in_uSeed)
	{
	}

	[Token(Token = "0x60188CE")]
	[Address(RVA = "0x36D02F4", Offset = "0x36D02F4", VA = "0x36D02F4")]
	public static void MuteBackgroundMusic(bool in_bMute)
	{
	}

	[Token(Token = "0x60188CF")]
	[Address(RVA = "0x36D0378", Offset = "0x36D0378", VA = "0x36D0378")]
	public static bool GetBackgroundMusicMute()
	{
		return default(bool);
	}

	[Token(Token = "0x60188D0")]
	[Address(RVA = "0x36D03F4", Offset = "0x36D03F4", VA = "0x36D03F4")]
	public static AKRESULT SendPluginCustomGameData(uint in_busID, GameObject in_busObjectID, AkPluginType in_eType, uint in_uCompanyID, uint in_uPluginID, IntPtr in_pData, uint in_uSizeInBytes)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188D1")]
	[Address(RVA = "0x36D04FC", Offset = "0x36D04FC", VA = "0x36D04FC")]
	public static AKRESULT UnregisterAllGameObj()
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188D2")]
	[Address(RVA = "0x36D0578", Offset = "0x36D0578", VA = "0x36D0578")]
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188D3")]
	[Address(RVA = "0x36D0674", Offset = "0x36D0674", VA = "0x36D0674")]
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkPositionArray in_pPositions, ushort in_NumPositions)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188D4")]
	[Address(RVA = "0x36D0768", Offset = "0x36D0768", VA = "0x36D0768")]
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions, AkMultiPositionType in_eMultiPositionType)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188D5")]
	[Address(RVA = "0x36D0864", Offset = "0x36D0864", VA = "0x36D0864")]
	public static AKRESULT SetMultiplePositions(GameObject in_GameObjectID, AkChannelEmitterArray in_pPositions, ushort in_NumPositions)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188D6")]
	[Address(RVA = "0x36D0958", Offset = "0x36D0958", VA = "0x36D0958")]
	public static AKRESULT SetScalingFactor(GameObject in_GameObjectID, float in_fAttenuationScalingFactor)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188D7")]
	[Address(RVA = "0x36D0A24", Offset = "0x36D0A24", VA = "0x36D0A24")]
	public static AKRESULT ClearBanks()
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188D8")]
	[Address(RVA = "0x36D0AA0", Offset = "0x36D0AA0", VA = "0x36D0AA0")]
	public static AKRESULT SetBankLoadIOSettings(float in_fThroughput, sbyte in_priority)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188D9")]
	[Address(RVA = "0x36D0B2C", Offset = "0x36D0B2C", VA = "0x36D0B2C")]
	public static AKRESULT LoadBank(string in_pszString, int in_memPoolId, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188DA")]
	[Address(RVA = "0x36D0BC0", Offset = "0x36D0BC0", VA = "0x36D0BC0")]
	public static AKRESULT LoadBank(uint in_bankID, int in_memPoolId)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188DB")]
	[Address(RVA = "0x36B946C", Offset = "0x36B946C", VA = "0x36B946C")]
	public static AKRESULT LoadBank(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188DC")]
	[Address(RVA = "0x36D0C4C", Offset = "0x36D0C4C", VA = "0x36D0C4C")]
	public static AKRESULT LoadBank(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, int in_uPoolForBankMedia, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188DD")]
	[Address(RVA = "0x36D0CF4", Offset = "0x36D0CF4", VA = "0x36D0CF4")]
	public static AKRESULT LoadBank(string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, int in_memPoolId, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188DE")]
	[Address(RVA = "0x36D0DF8", Offset = "0x36D0DF8", VA = "0x36D0DF8")]
	public static AKRESULT LoadBank(uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, int in_memPoolId)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188DF")]
	[Address(RVA = "0x36D0EF4", Offset = "0x36D0EF4", VA = "0x36D0EF4")]
	public static AKRESULT LoadBank(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188E0")]
	[Address(RVA = "0x36D0FF8", Offset = "0x36D0FF8", VA = "0x36D0FF8")]
	public static AKRESULT LoadBank(IntPtr in_pInMemoryBankPtr, uint in_uInMemoryBankSize, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, int in_uPoolForBankMedia, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188E1")]
	[Address(RVA = "0x36D1104", Offset = "0x36D1104", VA = "0x36D1104")]
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, out int out_pMemPoolId)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188E2")]
	[Address(RVA = "0x36D1198", Offset = "0x36D1198", VA = "0x36D1198")]
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188E3")]
	[Address(RVA = "0x36D1224", Offset = "0x36D1224", VA = "0x36D1224")]
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, out int out_pMemPoolId)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188E4")]
	[Address(RVA = "0x36B9114", Offset = "0x36B9114", VA = "0x36B9114")]
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188E5")]
	[Address(RVA = "0x36D12B8", Offset = "0x36D12B8", VA = "0x36D12B8")]
	public static AKRESULT UnloadBank(string in_pszString, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188E6")]
	[Address(RVA = "0x36D13B4", Offset = "0x36D13B4", VA = "0x36D13B4")]
	public static AKRESULT UnloadBank(uint in_bankID, IntPtr in_pInMemoryBankPtr, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188E7")]
	[Address(RVA = "0x36D14B0", Offset = "0x36D14B0", VA = "0x36D14B0")]
	public static void CancelBankCallbackCookie(object in_pCookie)
	{
	}

	[Token(Token = "0x60188E8")]
	[Address(RVA = "0x36D1534", Offset = "0x36D1534", VA = "0x36D1534")]
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkBankContent in_uFlags)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188E9")]
	[Address(RVA = "0x36D15C8", Offset = "0x36D15C8", VA = "0x36D15C8")]
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188EA")]
	[Address(RVA = "0x36D1654", Offset = "0x36D1654", VA = "0x36D1654")]
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkBankContent in_uFlags)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188EB")]
	[Address(RVA = "0x36D16E8", Offset = "0x36D16E8", VA = "0x36D16E8")]
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188EC")]
	[Address(RVA = "0x36D1774", Offset = "0x36D1774", VA = "0x36D1774")]
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188ED")]
	[Address(RVA = "0x36D1878", Offset = "0x36D1878", VA = "0x36D1878")]
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, string in_pszString, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188EE")]
	[Address(RVA = "0x36D1974", Offset = "0x36D1974", VA = "0x36D1974")]
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie, AkBankContent in_uFlags)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188EF")]
	[Address(RVA = "0x36D1A78", Offset = "0x36D1A78", VA = "0x36D1A78")]
	public static AKRESULT PrepareBank(AkPreparationType in_PreparationType, uint in_bankID, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188F0")]
	[Address(RVA = "0x36D1B74", Offset = "0x36D1B74", VA = "0x36D1B74")]
	public static AKRESULT ClearPreparedEvents()
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188F1")]
	[Address(RVA = "0x36D1BF0", Offset = "0x36D1BF0", VA = "0x36D1BF0")]
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188F2")]
	[Address(RVA = "0x36D1F70", Offset = "0x36D1F70", VA = "0x36D1F70")]
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188F3")]
	[Address(RVA = "0x36D2004", Offset = "0x36D2004", VA = "0x36D2004")]
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, string[] in_ppszString, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188F4")]
	[Address(RVA = "0x36D23FC", Offset = "0x36D23FC", VA = "0x36D23FC")]
	public static AKRESULT PrepareEvent(AkPreparationType in_PreparationType, uint[] in_pEventID, uint in_uNumEvent, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188F5")]
	[Address(RVA = "0x36D2500", Offset = "0x36D2500", VA = "0x36D2500")]
	public static AKRESULT SetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188F6")]
	[Address(RVA = "0x36D25B8", Offset = "0x36D25B8", VA = "0x36D25B8")]
	public static AKRESULT UnsetMedia(AkSourceSettingsArray in_pSourceSettings, uint in_uNumSourceSettings)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188F7")]
	[Address(RVA = "0x36D2670", Offset = "0x36D2670", VA = "0x36D2670")]
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188F8")]
	[Address(RVA = "0x36D2A04", Offset = "0x36D2A04", VA = "0x36D2A04")]
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188F9")]
	[Address(RVA = "0x36D2AB4", Offset = "0x36D2AB4", VA = "0x36D2AB4")]
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, string in_pszGroupName, string[] in_ppszGameSyncName, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188FA")]
	[Address(RVA = "0x36D2E9C", Offset = "0x36D2E9C", VA = "0x36D2E9C")]
	public static AKRESULT PrepareGameSyncs(AkPreparationType in_PreparationType, AkGroupType in_eGameSyncType, uint in_GroupID, uint[] in_paGameSyncID, uint in_uNumGameSyncs, AkCallbackManager.BankCallback in_pfnBankCallback, object in_pCookie)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188FB")]
	[Address(RVA = "0x36D2FAC", Offset = "0x36D2FAC", VA = "0x36D2FAC")]
	public static AKRESULT AddListener(GameObject in_emitterGameObj, GameObject in_listenerGameObj)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188FC")]
	[Address(RVA = "0x36D30B8", Offset = "0x36D30B8", VA = "0x36D30B8")]
	public static AKRESULT RemoveListener(GameObject in_emitterGameObj, GameObject in_listenerGameObj)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188FD")]
	[Address(RVA = "0x36D31C4", Offset = "0x36D31C4", VA = "0x36D31C4")]
	public static AKRESULT AddDefaultListener(GameObject in_listenerGameObj)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188FE")]
	[Address(RVA = "0x36D32A0", Offset = "0x36D32A0", VA = "0x36D32A0")]
	public static AKRESULT RemoveDefaultListener(GameObject in_listenerGameObj)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60188FF")]
	[Address(RVA = "0x36D337C", Offset = "0x36D337C", VA = "0x36D337C")]
	public static AKRESULT ResetListenersToDefault(GameObject in_emitterGameObj)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018900")]
	[Address(RVA = "0x36D3458", Offset = "0x36D3458", VA = "0x36D3458")]
	public static AKRESULT SetListenerSpatialization(GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig, float[] in_pVolumeOffsets)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018901")]
	[Address(RVA = "0x36D3560", Offset = "0x36D3560", VA = "0x36D3560")]
	public static AKRESULT SetListenerSpatialization(GameObject in_uListenerID, bool in_bSpatialized, AkChannelConfig in_channelConfig)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018902")]
	[Address(RVA = "0x36D3660", Offset = "0x36D3660", VA = "0x36D3660")]
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018903")]
	[Address(RVA = "0x36D3764", Offset = "0x36D3764", VA = "0x36D3764")]
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018904")]
	[Address(RVA = "0x36D3860", Offset = "0x36D3860", VA = "0x36D3860")]
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018905")]
	[Address(RVA = "0x36D3958", Offset = "0x36D3958", VA = "0x36D3958")]
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018906")]
	[Address(RVA = "0x36D3A48", Offset = "0x36D3A48", VA = "0x36D3A48")]
	public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018907")]
	[Address(RVA = "0x36D3AD4", Offset = "0x36D3AD4", VA = "0x36D3AD4")]
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018908")]
	[Address(RVA = "0x36D3BD8", Offset = "0x36D3BD8", VA = "0x36D3BD8")]
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018909")]
	[Address(RVA = "0x36D3CD4", Offset = "0x36D3CD4", VA = "0x36D3CD4")]
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601890A")]
	[Address(RVA = "0x36D3DCC", Offset = "0x36D3DCC", VA = "0x36D3DCC")]
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601890B")]
	[Address(RVA = "0x36D3EBC", Offset = "0x36D3EBC", VA = "0x36D3EBC")]
	public static AKRESULT SetRTPCValue(string in_pszRtpcName, float in_value)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601890C")]
	[Address(RVA = "0x36D3F48", Offset = "0x36D3F48", VA = "0x36D3F48")]
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601890D")]
	[Address(RVA = "0x36D4000", Offset = "0x36D4000", VA = "0x36D4000")]
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601890E")]
	[Address(RVA = "0x36D40B0", Offset = "0x36D40B0", VA = "0x36D40B0")]
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601890F")]
	[Address(RVA = "0x36D4158", Offset = "0x36D4158", VA = "0x36D4158")]
	public static AKRESULT SetRTPCValueByPlayingID(uint in_rtpcID, float in_value, uint in_playingID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018910")]
	[Address(RVA = "0x36D41EC", Offset = "0x36D41EC", VA = "0x36D41EC")]
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018911")]
	[Address(RVA = "0x36D42A4", Offset = "0x36D42A4", VA = "0x36D42A4")]
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018912")]
	[Address(RVA = "0x36D4354", Offset = "0x36D4354", VA = "0x36D4354")]
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018913")]
	[Address(RVA = "0x36D43FC", Offset = "0x36D43FC", VA = "0x36D43FC")]
	public static AKRESULT SetRTPCValueByPlayingID(string in_pszRtpcName, float in_value, uint in_playingID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018914")]
	[Address(RVA = "0x36D4490", Offset = "0x36D4490", VA = "0x36D4490")]
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018915")]
	[Address(RVA = "0x36D4588", Offset = "0x36D4588", VA = "0x36D4588")]
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018916")]
	[Address(RVA = "0x36D467C", Offset = "0x36D467C", VA = "0x36D467C")]
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018917")]
	[Address(RVA = "0x36D476C", Offset = "0x36D476C", VA = "0x36D476C")]
	public static AKRESULT ResetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018918")]
	[Address(RVA = "0x36D4854", Offset = "0x36D4854", VA = "0x36D4854")]
	public static AKRESULT ResetRTPCValue(uint in_rtpcID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018919")]
	[Address(RVA = "0x36D48D8", Offset = "0x36D48D8", VA = "0x36D48D8")]
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve, bool in_bBypassInternalValueInterpolation)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601891A")]
	[Address(RVA = "0x36D49D0", Offset = "0x36D49D0", VA = "0x36D49D0")]
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration, AkCurveInterpolation in_eFadeCurve)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601891B")]
	[Address(RVA = "0x36D4AC4", Offset = "0x36D4AC4", VA = "0x36D4AC4")]
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, int in_uValueChangeDuration)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601891C")]
	[Address(RVA = "0x36D4BB4", Offset = "0x36D4BB4", VA = "0x36D4BB4")]
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601891D")]
	[Address(RVA = "0x36D4C9C", Offset = "0x36D4C9C", VA = "0x36D4C9C")]
	public static AKRESULT ResetRTPCValue(string in_pszRtpcName)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601891E")]
	[Address(RVA = "0x36D4D20", Offset = "0x36D4D20", VA = "0x36D4D20")]
	public static AKRESULT SetSwitch(uint in_switchGroup, uint in_switchState, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601891F")]
	[Address(RVA = "0x36D4E10", Offset = "0x36D4E10", VA = "0x36D4E10")]
	public static AKRESULT SetSwitch(string in_pszSwitchGroup, string in_pszSwitchState, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018920")]
	[Address(RVA = "0x36D4F00", Offset = "0x36D4F00", VA = "0x36D4F00")]
	public static AKRESULT PostTrigger(uint in_triggerID, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018921")]
	[Address(RVA = "0x36D4FE8", Offset = "0x36D4FE8", VA = "0x36D4FE8")]
	public static AKRESULT PostTrigger(string in_pszTrigger, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018922")]
	[Address(RVA = "0x36D50D0", Offset = "0x36D50D0", VA = "0x36D50D0")]
	public static AKRESULT SetState(uint in_stateGroup, uint in_state)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018923")]
	[Address(RVA = "0x36D515C", Offset = "0x36D515C", VA = "0x36D515C")]
	public static AKRESULT SetState(string in_pszStateGroup, string in_pszState)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018924")]
	[Address(RVA = "0x36D51E8", Offset = "0x36D51E8", VA = "0x36D51E8")]
	public static AKRESULT SetGameObjectAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray in_aAuxSendValues, uint in_uNumSendValues)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018925")]
	[Address(RVA = "0x36D52F8", Offset = "0x36D52F8", VA = "0x36D52F8")]
	public static AKRESULT SetGameObjectOutputBusVolume(GameObject in_emitterObjID, GameObject in_listenerObjID, float in_fControlValue)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018926")]
	[Address(RVA = "0x36D5418", Offset = "0x36D5418", VA = "0x36D5418")]
	public static AKRESULT SetActorMixerEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018927")]
	[Address(RVA = "0x36D54AC", Offset = "0x36D54AC", VA = "0x36D54AC")]
	public static AKRESULT SetBusEffect(uint in_audioNodeID, uint in_uFXIndex, uint in_shareSetID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018928")]
	[Address(RVA = "0x36D5540", Offset = "0x36D5540", VA = "0x36D5540")]
	public static AKRESULT SetBusEffect(string in_pszBusName, uint in_uFXIndex, uint in_shareSetID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018929")]
	[Address(RVA = "0x36D55D4", Offset = "0x36D55D4", VA = "0x36D55D4")]
	public static AKRESULT SetMixer(uint in_audioNodeID, uint in_shareSetID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601892A")]
	[Address(RVA = "0x36D5660", Offset = "0x36D5660", VA = "0x36D5660")]
	public static AKRESULT SetMixer(string in_pszBusName, uint in_shareSetID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601892B")]
	[Address(RVA = "0x36D56EC", Offset = "0x36D56EC", VA = "0x36D56EC")]
	public static AKRESULT SetBusConfig(uint in_audioNodeID, AkChannelConfig in_channelConfig)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601892C")]
	[Address(RVA = "0x36D5788", Offset = "0x36D5788", VA = "0x36D5788")]
	public static AKRESULT SetBusConfig(string in_pszBusName, AkChannelConfig in_channelConfig)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601892D")]
	[Address(RVA = "0x36D5824", Offset = "0x36D5824", VA = "0x36D5824")]
	public static AKRESULT SetObjectObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_ListenerID, float in_fObstructionLevel, float in_fOcclusionLevel)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601892E")]
	[Address(RVA = "0x36D5950", Offset = "0x36D5950", VA = "0x36D5950")]
	public static AKRESULT SetMultipleObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_uListenerID, AkObstructionOcclusionValuesArray in_fObstructionOcclusionValues, uint in_uNumOcclusionObstruction)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601892F")]
	[Address(RVA = "0x36D5A94", Offset = "0x36D5A94", VA = "0x36D5A94")]
	public static AKRESULT StartOutputCapture(string in_CaptureFileName)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018930")]
	[Address(RVA = "0x36D5B18", Offset = "0x36D5B18", VA = "0x36D5B18")]
	public static AKRESULT StopOutputCapture()
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018931")]
	[Address(RVA = "0x36D5B94", Offset = "0x36D5B94", VA = "0x36D5B94")]
	public static AKRESULT AddOutputCaptureMarker(string in_MarkerText)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018932")]
	[Address(RVA = "0x36D5C18", Offset = "0x36D5C18", VA = "0x36D5C18")]
	public static AKRESULT StartProfilerCapture(string in_CaptureFileName)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018933")]
	[Address(RVA = "0x36D5C9C", Offset = "0x36D5C9C", VA = "0x36D5C9C")]
	public static AKRESULT StopProfilerCapture()
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018934")]
	[Address(RVA = "0x36D5D18", Offset = "0x36D5D18", VA = "0x36D5D18")]
	public static AKRESULT RemoveOutput(ulong in_idOutput)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018935")]
	[Address(RVA = "0x36D5DA4", Offset = "0x36D5DA4", VA = "0x36D5DA4")]
	public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId, out ulong out_pOutputDeviceId)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018936")]
	[Address(RVA = "0x36D5E94", Offset = "0x36D5E94", VA = "0x36D5E94")]
	public static AKRESULT ReplaceOutput(AkOutputSettings in_Settings, ulong in_outputDeviceId)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018937")]
	[Address(RVA = "0x36D5F7C", Offset = "0x36D5F7C", VA = "0x36D5F7C")]
	public static ulong GetOutputID(uint in_idShareset, uint in_idDevice)
	{
		return default(ulong);
	}

	[Token(Token = "0x6018938")]
	[Address(RVA = "0x36D6008", Offset = "0x36D6008", VA = "0x36D6008")]
	public static ulong GetOutputID(string in_szShareSet, uint in_idDevice)
	{
		return default(ulong);
	}

	[Token(Token = "0x6018939")]
	[Address(RVA = "0x36D6094", Offset = "0x36D6094", VA = "0x36D6094")]
	public static AKRESULT SetBusDevice(uint in_idBus, uint in_idNewDevice)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601893A")]
	[Address(RVA = "0x36D6120", Offset = "0x36D6120", VA = "0x36D6120")]
	public static AKRESULT SetBusDevice(string in_BusName, string in_DeviceName)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601893B")]
	[Address(RVA = "0x36D61AC", Offset = "0x36D61AC", VA = "0x36D61AC")]
	public static AKRESULT SetOutputVolume(ulong in_idOutput, float in_fVolume)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601893C")]
	[Address(RVA = "0x36D6240", Offset = "0x36D6240", VA = "0x36D6240")]
	public static AKRESULT GetDeviceSpatialAudioSupport(uint in_idDevice)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601893D")]
	[Address(RVA = "0x36D62C4", Offset = "0x36D62C4", VA = "0x36D62C4")]
	public static AKRESULT Suspend(bool in_bRenderAnyway)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601893E")]
	[Address(RVA = "0x36D6348", Offset = "0x36D6348", VA = "0x36D6348")]
	public static AKRESULT Suspend()
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601893F")]
	[Address(RVA = "0x36D63C4", Offset = "0x36D63C4", VA = "0x36D63C4")]
	public static AKRESULT WakeupFromSuspend()
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018940")]
	[Address(RVA = "0x36D6440", Offset = "0x36D6440", VA = "0x36D6440")]
	public static uint GetBufferTick()
	{
		return default(uint);
	}

	[Token(Token = "0x6018943")]
	[Address(RVA = "0x36D65B4", Offset = "0x36D65B4", VA = "0x36D65B4")]
	public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo, bool in_bExtrapolate)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018944")]
	[Address(RVA = "0x36D6690", Offset = "0x36D6690", VA = "0x36D6690")]
	public static AKRESULT GetPlayingSegmentInfo(uint in_PlayingID, AkSegmentInfo out_segmentInfo)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018945")]
	[Address(RVA = "0x36D6764", Offset = "0x36D6764", VA = "0x36D6764")]
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018946")]
	[Address(RVA = "0x36D6864", Offset = "0x36D6864", VA = "0x36D6864")]
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018947")]
	[Address(RVA = "0x36D695C", Offset = "0x36D695C", VA = "0x36D695C")]
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018948")]
	[Address(RVA = "0x36D6A50", Offset = "0x36D6A50", VA = "0x36D6A50")]
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018949")]
	[Address(RVA = "0x36D6AE4", Offset = "0x36D6AE4", VA = "0x36D6AE4")]
	public static AKRESULT PostCode(AkMonitorErrorCode in_eError, AkMonitorErrorLevel in_eErrorLevel)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601894A")]
	[Address(RVA = "0x36D6B70", Offset = "0x36D6B70", VA = "0x36D6B70")]
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID, bool in_bIsBus)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601894B")]
	[Address(RVA = "0x36D6C70", Offset = "0x36D6C70", VA = "0x36D6C70")]
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID, uint in_audioNodeID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601894C")]
	[Address(RVA = "0x36D6D68", Offset = "0x36D6D68", VA = "0x36D6D68")]
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID, GameObject in_gameObjID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601894D")]
	[Address(RVA = "0x36D6E5C", Offset = "0x36D6E5C", VA = "0x36D6E5C")]
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel, uint in_playingID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601894E")]
	[Address(RVA = "0x36D6EF0", Offset = "0x36D6EF0", VA = "0x36D6EF0")]
	public static AKRESULT PostString(string in_pszError, AkMonitorErrorLevel in_eErrorLevel)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601894F")]
	[Address(RVA = "0x36D6F7C", Offset = "0x36D6F7C", VA = "0x36D6F7C")]
	public static int GetTimeStamp()
	{
		return default(int);
	}

	[Token(Token = "0x6018950")]
	[Address(RVA = "0x36D6FF8", Offset = "0x36D6FF8", VA = "0x36D6FF8")]
	public static uint GetNumNonZeroBits(uint in_uWord)
	{
		return default(uint);
	}

	[Token(Token = "0x6018951")]
	[Address(RVA = "0x36D707C", Offset = "0x36D707C", VA = "0x36D707C")]
	public static void AkGetDefaultHighPriorityThreadProperties(AkThreadProperties out_threadProperties)
	{
	}

	[Token(Token = "0x6018952")]
	[Address(RVA = "0x36D7110", Offset = "0x36D7110", VA = "0x36D7110")]
	public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments, uint in_idSequence)
	{
		return default(uint);
	}

	[Token(Token = "0x6018953")]
	[Address(RVA = "0x36D71B8", Offset = "0x36D71B8", VA = "0x36D71B8")]
	public static uint ResolveDialogueEvent(uint in_eventID, uint[] in_aArgumentValues, uint in_uNumArguments)
	{
		return default(uint);
	}

	[Token(Token = "0x6018954")]
	[Address(RVA = "0x36D724C", Offset = "0x36D724C", VA = "0x36D724C")]
	public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out int out_iValue)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018955")]
	[Address(RVA = "0x36D72E0", Offset = "0x36D72E0", VA = "0x36D72E0")]
	public static AKRESULT GetDialogueEventCustomPropertyValue(uint in_eventID, uint in_uPropID, out float out_fValue)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018956")]
	[Address(RVA = "0x36D7374", Offset = "0x36D7374", VA = "0x36D7374")]
	public static AKRESULT GetPosition(GameObject in_GameObjectID, AkTransform out_rPosition)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018957")]
	[Address(RVA = "0x36D7450", Offset = "0x36D7450", VA = "0x36D7450")]
	public static AKRESULT GetListenerPosition(GameObject in_uIndex, AkTransform out_rPosition)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018958")]
	[Address(RVA = "0x36D7544", Offset = "0x36D7544", VA = "0x36D7544")]
	public static AKRESULT GetRTPCValue(uint in_rtpcID, GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018959")]
	[Address(RVA = "0x36D763C", Offset = "0x36D763C", VA = "0x36D763C")]
	public static AKRESULT GetRTPCValue(string in_pszRtpcName, GameObject in_gameObjectID, uint in_playingID, out float out_rValue, ref int io_rValueType)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601895A")]
	[Address(RVA = "0x36D7734", Offset = "0x36D7734", VA = "0x36D7734")]
	public static AKRESULT GetSwitch(uint in_switchGroup, GameObject in_gameObjectID, out uint out_rSwitchState)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601895B")]
	[Address(RVA = "0x36D7824", Offset = "0x36D7824", VA = "0x36D7824")]
	public static AKRESULT GetSwitch(string in_pstrSwitchGroupName, GameObject in_GameObj, out uint out_rSwitchState)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601895C")]
	[Address(RVA = "0x36D7904", Offset = "0x36D7904", VA = "0x36D7904")]
	public static AKRESULT GetState(uint in_stateGroup, out uint out_rState)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601895D")]
	[Address(RVA = "0x36D7990", Offset = "0x36D7990", VA = "0x36D7990")]
	public static AKRESULT GetState(string in_pstrStateGroupName, out uint out_rState)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601895E")]
	[Address(RVA = "0x36D7A1C", Offset = "0x36D7A1C", VA = "0x36D7A1C")]
	public static AKRESULT GetGameObjectAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray out_paAuxSendValues, ref uint io_ruNumSendValues)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601895F")]
	[Address(RVA = "0x36D7B2C", Offset = "0x36D7B2C", VA = "0x36D7B2C")]
	public static AKRESULT GetGameObjectDryLevelValue(GameObject in_EmitterID, GameObject in_ListenerID, out float out_rfControlValue)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018960")]
	[Address(RVA = "0x36D7C40", Offset = "0x36D7C40", VA = "0x36D7C40")]
	public static AKRESULT GetObjectObstructionAndOcclusion(GameObject in_EmitterID, GameObject in_ListenerID, out float out_rfObstructionLevel, out float out_rfOcclusionLevel)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018961")]
	[Address(RVA = "0x36D7D5C", Offset = "0x36D7D5C", VA = "0x36D7D5C")]
	public static AKRESULT QueryAudioObjectIDs(uint in_eventID, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018962")]
	[Address(RVA = "0x36D7E1C", Offset = "0x36D7E1C", VA = "0x36D7E1C")]
	public static AKRESULT QueryAudioObjectIDs(string in_pszEventName, ref uint io_ruNumItems, AkObjectInfoArray out_aObjectInfos)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018963")]
	[Address(RVA = "0x36D7EDC", Offset = "0x36D7EDC", VA = "0x36D7EDC")]
	public static AKRESULT GetPositioningInfo(uint in_ObjectID, AkPositioningInfo out_rPositioningInfo)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018964")]
	[Address(RVA = "0x36D7FB0", Offset = "0x36D7FB0", VA = "0x36D7FB0")]
	public static bool GetIsGameObjectActive(GameObject in_GameObjId)
	{
		return default(bool);
	}

	[Token(Token = "0x6018965")]
	[Address(RVA = "0x36D808C", Offset = "0x36D808C", VA = "0x36D808C")]
	public static float GetMaxRadius(GameObject in_GameObjId)
	{
		return default(float);
	}

	[Token(Token = "0x6018966")]
	[Address(RVA = "0x36D8168", Offset = "0x36D8168", VA = "0x36D8168")]
	public static uint GetEventIDFromPlayingID(uint in_playingID)
	{
		return default(uint);
	}

	[Token(Token = "0x6018967")]
	[Address(RVA = "0x36D81EC", Offset = "0x36D81EC", VA = "0x36D81EC")]
	public static ulong GetGameObjectFromPlayingID(uint in_playingID)
	{
		return default(ulong);
	}

	[Token(Token = "0x6018968")]
	[Address(RVA = "0x36D8270", Offset = "0x36D8270", VA = "0x36D8270")]
	public static AKRESULT GetPlayingIDsFromGameObject(GameObject in_GameObjId, ref uint io_ruNumIDs, uint[] out_aPlayingIDs)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018969")]
	[Address(RVA = "0x36D8360", Offset = "0x36D8360", VA = "0x36D8360")]
	public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out int out_iValue)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601896A")]
	[Address(RVA = "0x36D83F4", Offset = "0x36D83F4", VA = "0x36D83F4")]
	public static AKRESULT GetCustomPropertyValue(uint in_ObjectID, uint in_uPropID, out float out_fValue)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601896B")]
	[Address(RVA = "0x36D8488", Offset = "0x36D8488", VA = "0x36D8488")]
	public static void AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref uint io_uChannelMask)
	{
	}

	[Token(Token = "0x601896C")]
	[Address(RVA = "0x36D850C", Offset = "0x36D850C", VA = "0x36D850C")]
	public static void AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref uint io_uChannelMask)
	{
	}

	[Token(Token = "0x601896D")]
	[Address(RVA = "0x36D8590", Offset = "0x36D8590", VA = "0x36D8590")]
	public static void AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref uint io_uChannelMask)
	{
	}

	[Token(Token = "0x601896E")]
	[Address(RVA = "0x36D8614", Offset = "0x36D8614", VA = "0x36D8614")]
	public static byte ChannelMaskToNumChannels(uint in_uChannelMask)
	{
		return default(byte);
	}

	[Token(Token = "0x601896F")]
	[Address(RVA = "0x36D8698", Offset = "0x36D8698", VA = "0x36D8698")]
	public static uint ChannelMaskFromNumChannels(uint in_uNumChannels)
	{
		return default(uint);
	}

	[Token(Token = "0x6018970")]
	[Address(RVA = "0x36D871C", Offset = "0x36D871C", VA = "0x36D871C")]
	public static byte ChannelBitToIndex(uint in_uChannelBit, uint in_uChannelMask)
	{
		return default(byte);
	}

	[Token(Token = "0x6018971")]
	[Address(RVA = "0x36D87A8", Offset = "0x36D87A8", VA = "0x36D87A8")]
	public static bool HasSurroundChannels(uint in_uChannelMask)
	{
		return default(bool);
	}

	[Token(Token = "0x6018972")]
	[Address(RVA = "0x36D882C", Offset = "0x36D882C", VA = "0x36D882C")]
	public static bool HasStrictlyOnePairOfSurroundChannels(uint in_uChannelMask)
	{
		return default(bool);
	}

	[Token(Token = "0x6018973")]
	[Address(RVA = "0x36D88B0", Offset = "0x36D88B0", VA = "0x36D88B0")]
	public static bool HasSideAndRearChannels(uint in_uChannelMask)
	{
		return default(bool);
	}

	[Token(Token = "0x6018974")]
	[Address(RVA = "0x36D8934", Offset = "0x36D8934", VA = "0x36D8934")]
	public static bool HasHeightChannels(uint in_uChannelMask)
	{
		return default(bool);
	}

	[Token(Token = "0x6018975")]
	[Address(RVA = "0x36D89B8", Offset = "0x36D89B8", VA = "0x36D89B8")]
	public static uint BackToSideChannels(uint in_uChannelMask)
	{
		return default(uint);
	}

	[Token(Token = "0x6018976")]
	[Address(RVA = "0x36D8A3C", Offset = "0x36D8A3C", VA = "0x36D8A3C")]
	public static uint StdChannelIndexToDisplayIndex(AkChannelOrdering in_eOrdering, uint in_uChannelMask, uint in_uChannelIdx)
	{
		return default(uint);
	}

	[Token(Token = "0x6018980")]
	[Address(RVA = "0x36D8F34", Offset = "0x36D8F34", VA = "0x36D8F34")]
	public static int GetPoolID()
	{
		return default(int);
	}

	[Token(Token = "0x6018981")]
	[Address(RVA = "0x36D8FB0", Offset = "0x36D8FB0", VA = "0x36D8FB0")]
	public static AKRESULT RegisterEmitter(GameObject in_gameObjectID, AkEmitterSettings in_settings)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018982")]
	[Address(RVA = "0x36D90A4", Offset = "0x36D90A4", VA = "0x36D90A4")]
	public static AKRESULT UnregisterEmitter(GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018983")]
	[Address(RVA = "0x36D9180", Offset = "0x36D9180", VA = "0x36D9180")]
	public static AKRESULT SetEmitterAuxSendValues(GameObject in_gameObjectID, AkAuxSendArray in_pAuxSends, uint in_uNumAux)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018984")]
	[Address(RVA = "0x36D9290", Offset = "0x36D9290", VA = "0x36D9290")]
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, uint in_AuxBusID, ulong in_roomID, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018985")]
	[Address(RVA = "0x36D93A4", Offset = "0x36D93A4", VA = "0x36D93A4")]
	public static AKRESULT SetImageSource(uint in_srcID, AkImageSourceSettings in_info, uint in_AuxBusID, ulong in_roomID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018986")]
	[Address(RVA = "0x36D945C", Offset = "0x36D945C", VA = "0x36D945C")]
	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID, GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018987")]
	[Address(RVA = "0x36D954C", Offset = "0x36D954C", VA = "0x36D954C")]
	public static AKRESULT RemoveImageSource(uint in_srcID, uint in_AuxBusID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018988")]
	[Address(RVA = "0x36D95D8", Offset = "0x36D95D8", VA = "0x36D95D8")]
	public static AKRESULT RemoveGeometry(ulong in_SetID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018989")]
	[Address(RVA = "0x36D9664", Offset = "0x36D9664", VA = "0x36D9664")]
	public static AKRESULT QueryReflectionPaths(GameObject in_gameObjectID, AkVector out_listenerPos, AkVector out_emitterPos, AkReflectionPathInfoArray out_aPaths, out uint io_uArraySize)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601898A")]
	[Address(RVA = "0x36C700C", Offset = "0x36C700C", VA = "0x36C700C")]
	public static AKRESULT RemoveRoom(ulong in_RoomID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601898B")]
	[Address(RVA = "0x36D97AC", Offset = "0x36D97AC", VA = "0x36D97AC")]
	public static AKRESULT RemovePortal(ulong in_PortalID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601898C")]
	[Address(RVA = "0x36D9838", Offset = "0x36D9838", VA = "0x36D9838")]
	public static AKRESULT SetGameObjectInRoom(GameObject in_gameObjectID, ulong in_CurrentRoomID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601898D")]
	[Address(RVA = "0x36D9928", Offset = "0x36D9928", VA = "0x36D9928")]
	public static AKRESULT SetEmitterObstructionAndOcclusion(GameObject in_gameObjectID, float in_fObstruction, float in_fOcclusion)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601898E")]
	[Address(RVA = "0x36CA268", Offset = "0x36CA268", VA = "0x36CA268")]
	public static AKRESULT SetPortalObstructionAndOcclusion(ulong in_PortalID, float in_fObstruction, float in_fOcclusion)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601898F")]
	[Address(RVA = "0x36D9A18", Offset = "0x36D9A18", VA = "0x36D9A18")]
	public static AKRESULT QueryWetDiffraction(ulong in_portal, out float out_wetDiffraction)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018990")]
	[Address(RVA = "0x36D9AAC", Offset = "0x36D9AAC", VA = "0x36D9AAC")]
	public static AKRESULT GetFastPathSettings(AkInitSettings in_settings, AkPlatformInitSettings in_pfSettings)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018991")]
	[Address(RVA = "0x36B210C", Offset = "0x36B210C", VA = "0x36B210C")]
	public static void SetErrorLogger(AkLogger.ErrorLoggerInteropDelegate logger)
	{
	}

	[Token(Token = "0x6018992")]
	[Address(RVA = "0x36B2370", Offset = "0x36B2370", VA = "0x36B2370")]
	public static void SetErrorLogger()
	{
	}

	[Token(Token = "0x6018993")]
	[Address(RVA = "0x36D9BC8", Offset = "0x36D9BC8", VA = "0x36D9BC8")]
	public static void SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate getAudioSamples, AkAudioInputManager.AudioFormatInteropDelegate getAudioFormat)
	{
	}

	[Token(Token = "0x6018994")]
	[Address(RVA = "0x36D9C54", Offset = "0x36D9C54", VA = "0x36D9C54")]
	public static AKRESULT Init(AkInitializationSettings settings)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018995")]
	[Address(RVA = "0x36D9D20", Offset = "0x36D9D20", VA = "0x36D9D20")]
	public static AKRESULT InitSpatialAudio(AkSpatialAudioInitSettings settings)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018996")]
	[Address(RVA = "0x36D9DB4", Offset = "0x36D9DB4", VA = "0x36D9DB4")]
	public static AKRESULT InitCommunication(AkCommunicationSettings settings)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018997")]
	[Address(RVA = "0x36D9E48", Offset = "0x36D9E48", VA = "0x36D9E48")]
	public static void Term()
	{
	}

	[Token(Token = "0x6018998")]
	[Address(RVA = "0x36D9EC4", Offset = "0x36D9EC4", VA = "0x36D9EC4")]
	public static AKRESULT RegisterGameObjInternal(GameObject in_GameObj)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x6018999")]
	[Address(RVA = "0x36D9F88", Offset = "0x36D9F88", VA = "0x36D9F88")]
	public static AKRESULT UnregisterGameObjInternal(GameObject in_GameObj)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601899A")]
	[Address(RVA = "0x36DA04C", Offset = "0x36DA04C", VA = "0x36DA04C")]
	public static AKRESULT RegisterGameObjInternal_WithName(GameObject in_GameObj, string in_pszObjName)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601899B")]
	[Address(RVA = "0x36DA118", Offset = "0x36DA118", VA = "0x36DA118")]
	public static AKRESULT SetBasePath(string in_pszBasePath)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601899C")]
	[Address(RVA = "0x36DA19C", Offset = "0x36DA19C", VA = "0x36DA19C")]
	public static AKRESULT SetCurrentLanguage(string in_pszAudioSrcPath)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601899D")]
	[Address(RVA = "0x36DA220", Offset = "0x36DA220", VA = "0x36DA220")]
	public static AKRESULT LoadFilePackage(string in_pszFilePackageName, out uint out_uPackageID, int in_memPoolID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601899E")]
	[Address(RVA = "0x36DA2B4", Offset = "0x36DA2B4", VA = "0x36DA2B4")]
	public static AKRESULT AddBasePath(string in_pszBasePath)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x601899F")]
	[Address(RVA = "0x36DA338", Offset = "0x36DA338", VA = "0x36DA338")]
	public static AKRESULT SetGameName(string in_GameName)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189A0")]
	[Address(RVA = "0x36DA3BC", Offset = "0x36DA3BC", VA = "0x36DA3BC")]
	public static AKRESULT SetDecodedBankPath(string in_DecodedPath)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189A1")]
	[Address(RVA = "0x36DA440", Offset = "0x36DA440", VA = "0x36DA440")]
	public static AKRESULT LoadAndDecodeBank(string in_pszString, bool in_bSaveDecodedBank, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189A2")]
	[Address(RVA = "0x36DA4D4", Offset = "0x36DA4D4", VA = "0x36DA4D4")]
	public static AKRESULT LoadAndDecodeBankFromMemory(IntPtr in_BankData, uint in_BankDataSize, bool in_bSaveDecodedBank, string in_DecodedBankName, bool in_bIsLanguageSpecific, out uint out_bankID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189A3")]
	[Address(RVA = "0x36B8C40", Offset = "0x36B8C40", VA = "0x36B8C40")]
	public static string GetCurrentLanguage()
	{
		return null;
	}

	[Token(Token = "0x60189A4")]
	[Address(RVA = "0x36DA58C", Offset = "0x36DA58C", VA = "0x36DA58C")]
	public static AKRESULT UnloadFilePackage(uint in_uPackageID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189A5")]
	[Address(RVA = "0x36DA610", Offset = "0x36DA610", VA = "0x36DA610")]
	public static AKRESULT UnloadAllFilePackages()
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189A6")]
	[Address(RVA = "0x36DA68C", Offset = "0x36DA68C", VA = "0x36DA68C")]
	public static AKRESULT SetObjectPosition(GameObject in_GameObjectID, float PosX, float PosY, float PosZ, float FrontX, float FrontY, float FrontZ, float TopX, float TopY, float TopZ)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189A7")]
	[Address(RVA = "0x36DA7B0", Offset = "0x36DA7B0", VA = "0x36DA7B0")]
	public static AKRESULT GetSourceMultiplePlayPositions(uint in_PlayingID, uint[] out_audioNodeID, uint[] out_mediaID, int[] out_msTime, ref uint io_pcPositions, bool in_bExtrapolate)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189A8")]
	[Address(RVA = "0x36DA868", Offset = "0x36DA868", VA = "0x36DA868")]
	public static AKRESULT SetListeners(GameObject in_emitterGameObj, ulong[] in_pListenerGameObjs, uint in_uNumListeners)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189A9")]
	[Address(RVA = "0x36DA958", Offset = "0x36DA958", VA = "0x36DA958")]
	public static AKRESULT SetDefaultListeners(ulong[] in_pListenerObjs, uint in_uNumListeners)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189AA")]
	[Address(RVA = "0x36DA9E4", Offset = "0x36DA9E4", VA = "0x36DA9E4")]
	public static AKRESULT AddOutput(AkOutputSettings in_Settings, out ulong out_pDeviceID, ulong[] in_pListenerIDs, uint in_uNumListeners)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189AB")]
	[Address(RVA = "0x36DAAD4", Offset = "0x36DAAD4", VA = "0x36DAAD4")]
	public static void GetDefaultStreamSettings(AkStreamMgrSettings out_settings)
	{
	}

	[Token(Token = "0x60189AC")]
	[Address(RVA = "0x36DAB68", Offset = "0x36DAB68", VA = "0x36DAB68")]
	public static void GetDefaultDeviceSettings(AkDeviceSettings out_settings)
	{
	}

	[Token(Token = "0x60189AD")]
	[Address(RVA = "0x36DABFC", Offset = "0x36DABFC", VA = "0x36DABFC")]
	public static void GetDefaultMusicSettings(AkMusicSettings out_settings)
	{
	}

	[Token(Token = "0x60189AE")]
	[Address(RVA = "0x36DACC8", Offset = "0x36DACC8", VA = "0x36DACC8")]
	public static void GetDefaultInitSettings(AkInitSettings out_settings)
	{
	}

	[Token(Token = "0x60189AF")]
	[Address(RVA = "0x36DAD94", Offset = "0x36DAD94", VA = "0x36DAD94")]
	public static void GetDefaultPlatformInitSettings(AkPlatformInitSettings out_settings)
	{
	}

	[Token(Token = "0x60189B0")]
	[Address(RVA = "0x36DAE60", Offset = "0x36DAE60", VA = "0x36DAE60")]
	public static uint GetMajorMinorVersion()
	{
		return default(uint);
	}

	[Token(Token = "0x60189B1")]
	[Address(RVA = "0x36DAEDC", Offset = "0x36DAEDC", VA = "0x36DAEDC")]
	public static uint GetSubminorBuildVersion()
	{
		return default(uint);
	}

	[Token(Token = "0x60189B2")]
	[Address(RVA = "0x36DAF58", Offset = "0x36DAF58", VA = "0x36DAF58")]
	public static AKRESULT QueryIndirectPaths(GameObject in_gameObjectID, AkPathParams arg1, AkReflectionPathInfoArray paths, uint numPaths)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189B3")]
	[Address(RVA = "0x36DB0C4", Offset = "0x36DB0C4", VA = "0x36DB0C4")]
	public static AKRESULT QueryDiffractionPaths(GameObject in_gameObjectID, AkPathParams arg1, AkDiffractionPathInfoArray paths, uint numPaths)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189B4")]
	[Address(RVA = "0x36C8868", Offset = "0x36C8868", VA = "0x36C8868")]
	public static AKRESULT SetRoomPortal(ulong in_PortalID, AkTransform Transform, AkVector Extent, bool bEnabled, ulong FrontRoom, ulong BackRoom)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189B5")]
	[Address(RVA = "0x36C6A10", Offset = "0x36C6A10", VA = "0x36C6A10")]
	public static AKRESULT SetRoom(ulong in_RoomID, AkRoomParams in_roomParams, string in_pName)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189B6")]
	[Address(RVA = "0x36DB230", Offset = "0x36DB230", VA = "0x36DB230")]
	public static AKRESULT RegisterSpatialAudioListener(GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189B7")]
	[Address(RVA = "0x36DB30C", Offset = "0x36DB30C", VA = "0x36DB30C")]
	public static AKRESULT UnregisterSpatialAudioListener(GameObject in_gameObjectID)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189B8")]
	[Address(RVA = "0x36DB3E8", Offset = "0x36DB3E8", VA = "0x36DB3E8")]
	public static AKRESULT SetGeometry(ulong in_GeomSetID, AkTriangleArray Triangles, uint NumTriangles, AkVertexArray Vertices, uint NumVertices, AkAcousticSurfaceArray Surfaces, uint NumSurfaces, ulong RoomID, bool EnableDiffraction, bool EnableDiffractionOnBoundaryEdges)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189B9")]
	[Address(RVA = "0x36B883C", Offset = "0x36B883C", VA = "0x36B883C")]
	public static string StringFromIntPtrString(IntPtr ptr)
	{
		return null;
	}

	[Token(Token = "0x60189BA")]
	[Address(RVA = "0x36DB54C", Offset = "0x36DB54C", VA = "0x36DB54C")]
	public static string StringFromIntPtrWString(IntPtr ptr)
	{
		return null;
	}

	[Token(Token = "0x60189BB")]
	[Address(RVA = "0x36AF8B0", Offset = "0x36AF8B0", VA = "0x36AF8B0")]
	public static string StringFromIntPtrOSString(IntPtr ptr)
	{
		return null;
	}

	[Token(Token = "0x60189BC")]
	[Address(RVA = "0x36DB5D0", Offset = "0x36DB5D0", VA = "0x36DB5D0")]
	private static ulong InternalGameObjectHash(GameObject gameObject)
	{
		return default(ulong);
	}

	[Token(Token = "0x60189BE")]
	[Address(RVA = "0x36B7928", Offset = "0x36B7928", VA = "0x36B7928")]
	public static ulong GetAkGameObjectID(GameObject gameObject)
	{
		return default(ulong);
	}

	[Token(Token = "0x60189BF")]
	[Address(RVA = "0x36DB810", Offset = "0x36DB810", VA = "0x36DB810")]
	public static AKRESULT RegisterGameObj(GameObject gameObject)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189C0")]
	[Address(RVA = "0x36DB9CC", Offset = "0x36DB9CC", VA = "0x36DB9CC")]
	public static AKRESULT RegisterGameObj(GameObject gameObject, string name)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189C1")]
	[Address(RVA = "0x36DBAB4", Offset = "0x36DBAB4", VA = "0x36DBAB4")]
	public static AKRESULT UnregisterGameObj(GameObject gameObject)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189C2")]
	[Address(RVA = "0x36DBC70", Offset = "0x36DBC70", VA = "0x36DBC70")]
	public static AKRESULT SetObjectPosition(GameObject gameObject, Transform transform)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189C3")]
	[Address(RVA = "0x36DBEB4", Offset = "0x36DBEB4", VA = "0x36DBEB4")]
	public static AKRESULT SetObjectPosition(GameObject gameObject, Vector3 position, Vector3 forward, Vector3 up)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60189C4")]
	[Address(RVA = "0x36DBFF8", Offset = "0x36DBFF8", VA = "0x36DBFF8")]
	public static uint PostEvent(uint eventId, GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, object cookie, uint numSources, AkExternalSourceInfo externalSources, uint playingId)
	{
		return default(uint);
	}

	[Token(Token = "0x60189C5")]
	[Address(RVA = "0x36DC15C", Offset = "0x36DC15C", VA = "0x36DC15C")]
	public static uint PostEvent(uint eventId, GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, object cookie, uint numSources, AkExternalSourceInfo externalSources)
	{
		return default(uint);
	}

	[Token(Token = "0x60189C6")]
	[Address(RVA = "0x36DC30C", Offset = "0x36DC30C", VA = "0x36DC30C")]
	public static uint PostEvent(string eventName, GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, object cookie, uint numSources, AkExternalSourceInfo externalSources, uint playingId)
	{
		return default(uint);
	}

	[Token(Token = "0x60189C7")]
	[Address(RVA = "0x36DC470", Offset = "0x36DC470", VA = "0x36DC470")]
	public static uint PostEvent(string eventName, GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, object cookie, uint numSources, AkExternalSourceInfo externalSources)
	{
		return default(uint);
	}

	[Token(Token = "0x60189C8")]
	[Address(RVA = "0x36B79D8", Offset = "0x36B79D8", VA = "0x36B79D8")]
	public static void PreGameObjectAPICall(GameObject gameObject, ulong id)
	{
	}

	[Token(Token = "0x60189C9")]
	[Address(RVA = "0x36DC728", Offset = "0x36DC728", VA = "0x36DC728")]
	private static void AutoRegister(GameObject gameObject, ulong id)
	{
	}

	[Token(Token = "0x60189CA")]
	[Address(RVA = "0x36DC620", Offset = "0x36DC620", VA = "0x36DC620")]
	private static void PreGameObjectAPICallUserHook(GameObject gameObject, ulong id)
	{
	}

	[Token(Token = "0x60189CB")]
	[Address(RVA = "0x36DB8F0", Offset = "0x36DB8F0", VA = "0x36DB8F0")]
	private static void PostRegisterGameObjUserHook(AKRESULT result, GameObject gameObject, ulong id)
	{
	}

	[Token(Token = "0x60189CC")]
	[Address(RVA = "0x36DBB94", Offset = "0x36DBB94", VA = "0x36DBB94")]
	private static void PostUnregisterGameObjUserHook(AKRESULT result, GameObject gameObject, ulong id)
	{
	}

	[Token(Token = "0x60189CD")]
	[Address(RVA = "0x36DC898", Offset = "0x36DC898", VA = "0x36DC898")]
	private static bool IsInRegisteredList(ulong id)
	{
		return default(bool);
	}

	[Token(Token = "0x60189CE")]
	[Address(RVA = "0x36DC968", Offset = "0x36DC968", VA = "0x36DC968")]
	public static bool IsGameObjectRegistered(GameObject in_gameObject)
	{
		return default(bool);
	}
}
