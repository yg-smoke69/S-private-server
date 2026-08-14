using System;
using Il2CppDummyDll;

[Token(Token = "0x2003E04")]
public class AkiOSSettings : AkWwiseInitializationSettings.PlatformSettings
{
	[Serializable]
	[Token(Token = "0x2003E05")]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings
	{
		[Token(Token = "0x2003E06")]
		public enum Category
		{
			[Token(Token = "0x401A48A")]
			Ambient,
			[Token(Token = "0x401A48B")]
			SoloAmbient,
			[Token(Token = "0x401A48C")]
			PlayAndRecord
		}

		[Token(Token = "0x2003E07")]
		public enum CategoryOptions
		{
			[Token(Token = "0x401A48E")]
			MixWithOthers = 1,
			[Token(Token = "0x401A48F")]
			DuckOthers = 2,
			[Token(Token = "0x401A490")]
			AllowBluetooth = 4,
			[Token(Token = "0x401A491")]
			DefaultToSpeaker = 8
		}

		[Token(Token = "0x2003E08")]
		public enum Mode
		{
			[Token(Token = "0x401A493")]
			Default,
			[Token(Token = "0x401A494")]
			VoiceChat,
			[Token(Token = "0x401A495")]
			GameChat,
			[Token(Token = "0x401A496")]
			VideoRecording,
			[Token(Token = "0x401A497")]
			Measurement,
			[Token(Token = "0x401A498")]
			MoviePlayback,
			[Token(Token = "0x401A499")]
			VideoChat
		}

		[Token(Token = "0x401A486")]
		[FieldOffset(Offset = "0x40")]
		public Category m_AudioSessionCategory;

		[Token(Token = "0x401A487")]
		[FieldOffset(Offset = "0x44")]
		public CategoryOptions m_AudioSessionCategoryOptions;

		[Token(Token = "0x401A488")]
		[FieldOffset(Offset = "0x48")]
		public Mode m_AudioSessionMode;

		[Token(Token = "0x60193B7")]
		[Address(RVA = "0x2EC3918", Offset = "0x2EC3918", VA = "0x2EC3918")]
		public PlatformAdvancedSettings()
		{
		}

		[Token(Token = "0x60193B8")]
		[Address(RVA = "0x2EC3930", Offset = "0x2EC3930", VA = "0x2EC3930", Slot = "7")]
		public override void CopyTo(AkPlatformInitSettings settings)
		{
		}
	}

	[Token(Token = "0x401A483")]
	[FieldOffset(Offset = "0x18")]
	public AkCommonUserSettings UserSettings;

	[Token(Token = "0x401A484")]
	[FieldOffset(Offset = "0x1C")]
	public PlatformAdvancedSettings AdvancedSettings;

	[Token(Token = "0x401A485")]
	[FieldOffset(Offset = "0x20")]
	public AkCommonCommSettings CommsSettings;

	[Token(Token = "0x60193B3")]
	[Address(RVA = "0x2EC377C", Offset = "0x2EC377C", VA = "0x2EC377C")]
	public AkiOSSettings()
	{
	}

	[Token(Token = "0x60193B4")]
	[Address(RVA = "0x2EC3900", Offset = "0x2EC3900", VA = "0x2EC3900", Slot = "12")]
	protected override AkCommonUserSettings GetUserSettings()
	{
		return null;
	}

	[Token(Token = "0x60193B5")]
	[Address(RVA = "0x2EC3908", Offset = "0x2EC3908", VA = "0x2EC3908", Slot = "13")]
	protected override AkCommonAdvancedSettings GetAdvancedSettings()
	{
		return null;
	}

	[Token(Token = "0x60193B6")]
	[Address(RVA = "0x2EC3910", Offset = "0x2EC3910", VA = "0x2EC3910", Slot = "14")]
	protected override AkCommonCommSettings GetCommsSettings()
	{
		return null;
	}
}
