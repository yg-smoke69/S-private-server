using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2003DC6")]
public class AkCommonOutputSettings
{
	[Token(Token = "0x2003DC7")]
	public enum PanningRule
	{
		[Token(Token = "0x401A3AF")]
		Speakers,
		[Token(Token = "0x401A3B0")]
		Headphones
	}

	[Serializable]
	[Token(Token = "0x2003DC8")]
	public class ChannelConfiguration
	{
		[Token(Token = "0x2003DC9")]
		public enum ChannelConfigType
		{
			[Token(Token = "0x401A3B5")]
			Anonymous,
			[Token(Token = "0x401A3B6")]
			Standard,
			[Token(Token = "0x401A3B7")]
			Ambisonic
		}

		[Token(Token = "0x2003DCA")]
		public enum ChannelMask
		{
			[Token(Token = "0x401A3B9")]
			NONE = 0,
			[Token(Token = "0x401A3BA")]
			FRONT_LEFT = 1,
			[Token(Token = "0x401A3BB")]
			FRONT_RIGHT = 2,
			[Token(Token = "0x401A3BC")]
			FRONT_CENTER = 4,
			[Token(Token = "0x401A3BD")]
			LOW_FREQUENCY = 8,
			[Token(Token = "0x401A3BE")]
			BACK_LEFT = 16,
			[Token(Token = "0x401A3BF")]
			BACK_RIGHT = 32,
			[Token(Token = "0x401A3C0")]
			BACK_CENTER = 256,
			[Token(Token = "0x401A3C1")]
			SIDE_LEFT = 512,
			[Token(Token = "0x401A3C2")]
			SIDE_RIGHT = 1024,
			[Token(Token = "0x401A3C3")]
			TOP = 2048,
			[Token(Token = "0x401A3C4")]
			HEIGHT_FRONT_LEFT = 4096,
			[Token(Token = "0x401A3C5")]
			HEIGHT_FRONT_CENTER = 8192,
			[Token(Token = "0x401A3C6")]
			HEIGHT_FRONT_RIGHT = 16384,
			[Token(Token = "0x401A3C7")]
			HEIGHT_BACK_LEFT = 32768,
			[Token(Token = "0x401A3C8")]
			HEIGHT_BACK_CENTER = 65536,
			[Token(Token = "0x401A3C9")]
			HEIGHT_BACK_RIGHT = 131072,
			[Token(Token = "0x401A3CA")]
			SETUP_MONO = 4,
			[Token(Token = "0x401A3CB")]
			SETUP_0POINT1 = 8,
			[Token(Token = "0x401A3CC")]
			SETUP_1POINT1 = 12,
			[Token(Token = "0x401A3CD")]
			SETUP_STEREO = 3,
			[Token(Token = "0x401A3CE")]
			SETUP_2POINT1 = 11,
			[Token(Token = "0x401A3CF")]
			SETUP_3STEREO = 7,
			[Token(Token = "0x401A3D0")]
			SETUP_3POINT1 = 15,
			[Token(Token = "0x401A3D1")]
			SETUP_4 = 1539,
			[Token(Token = "0x401A3D2")]
			SETUP_4POINT1 = 1547,
			[Token(Token = "0x401A3D3")]
			SETUP_5 = 1543,
			[Token(Token = "0x401A3D4")]
			SETUP_5POINT1 = 1551,
			[Token(Token = "0x401A3D5")]
			SETUP_6 = 1587,
			[Token(Token = "0x401A3D6")]
			SETUP_6POINT1 = 1595,
			[Token(Token = "0x401A3D7")]
			SETUP_7 = 1591,
			[Token(Token = "0x401A3D8")]
			SETUP_7POINT1 = 1599,
			[Token(Token = "0x401A3D9")]
			SETUP_SURROUND = 259,
			[Token(Token = "0x401A3DA")]
			SETUP_DPL2 = 1539,
			[Token(Token = "0x401A3DB")]
			SETUP_HEIGHT_4 = 184320,
			[Token(Token = "0x401A3DC")]
			SETUP_HEIGHT_5 = 192512,
			[Token(Token = "0x401A3DD")]
			SETUP_HEIGHT_ALL = 258048,
			[Token(Token = "0x401A3DE")]
			SETUP_AURO_222 = 22019,
			[Token(Token = "0x401A3DF")]
			SETUP_AURO_8 = 185859,
			[Token(Token = "0x401A3E0")]
			SETUP_AURO_9 = 185863,
			[Token(Token = "0x401A3E1")]
			SETUP_AURO_9POINT1 = 185871,
			[Token(Token = "0x401A3E2")]
			SETUP_AURO_10 = 187911,
			[Token(Token = "0x401A3E3")]
			SETUP_AURO_10POINT1 = 187919,
			[Token(Token = "0x401A3E4")]
			SETUP_AURO_11 = 196103,
			[Token(Token = "0x401A3E5")]
			SETUP_AURO_11POINT1 = 196111,
			[Token(Token = "0x401A3E6")]
			SETUP_AURO_11_740 = 185911,
			[Token(Token = "0x401A3E7")]
			SETUP_AURO_11POINT1_740 = 185919,
			[Token(Token = "0x401A3E8")]
			SETUP_AURO_13_751 = 196151,
			[Token(Token = "0x401A3E9")]
			SETUP_AURO_13POINT1_751 = 196159,
			[Token(Token = "0x401A3EA")]
			SETUP_DOLBY_5_0_2 = 22023,
			[Token(Token = "0x401A3EB")]
			SETUP_DOLBY_5_1_2 = 22031,
			[Token(Token = "0x401A3EC")]
			SETUP_DOLBY_6_0_2 = 22067,
			[Token(Token = "0x401A3ED")]
			SETUP_DOLBY_6_1_2 = 22075,
			[Token(Token = "0x401A3EE")]
			SETUP_DOLBY_6_0_4 = 185907,
			[Token(Token = "0x401A3EF")]
			SETUP_DOLBY_6_1_4 = 185915,
			[Token(Token = "0x401A3F0")]
			SETUP_DOLBY_7_0_2 = 22071,
			[Token(Token = "0x401A3F1")]
			SETUP_DOLBY_7_1_2 = 22079,
			[Token(Token = "0x401A3F2")]
			SETUP_DOLBY_7_0_4 = 185911,
			[Token(Token = "0x401A3F3")]
			SETUP_DOLBY_7_1_4 = 185919,
			[Token(Token = "0x401A3F4")]
			SETUP_ALL_SPEAKERS = 261951
		}

		[Token(Token = "0x401A3B1")]
		[FieldOffset(Offset = "0x8")]
		public ChannelConfigType m_ChannelConfigType;

		[Token(Token = "0x401A3B2")]
		[FieldOffset(Offset = "0xC")]
		public ChannelMask m_ChannelMask;

		[Token(Token = "0x401A3B3")]
		[FieldOffset(Offset = "0x10")]
		public uint m_NumberOfChannels;

		[Token(Token = "0x6019275")]
		[Address(RVA = "0x35C0D6C", Offset = "0x35C0D6C", VA = "0x35C0D6C")]
		public ChannelConfiguration()
		{
		}

		[Token(Token = "0x6019276")]
		[Address(RVA = "0x35D0718", Offset = "0x35D0718", VA = "0x35D0718")]
		public void CopyTo(AkChannelConfig config)
		{
		}
	}

	[Token(Token = "0x401A3AA")]
	[FieldOffset(Offset = "0x8")]
	public string m_AudioDeviceShareset;

	[Token(Token = "0x401A3AB")]
	[FieldOffset(Offset = "0xC")]
	public uint m_DeviceID;

	[Token(Token = "0x401A3AC")]
	[FieldOffset(Offset = "0x10")]
	public PanningRule m_PanningRule;

	[Token(Token = "0x401A3AD")]
	[FieldOffset(Offset = "0x14")]
	public ChannelConfiguration m_ChannelConfig;

	[Token(Token = "0x6019273")]
	[Address(RVA = "0x35C0CA8", Offset = "0x35C0CA8", VA = "0x35C0CA8")]
	public AkCommonOutputSettings()
	{
	}

	[Token(Token = "0x6019274")]
	[Address(RVA = "0x35D0578", Offset = "0x35D0578", VA = "0x35D0578")]
	public void CopyTo(AkOutputSettings settings)
	{
	}
}
