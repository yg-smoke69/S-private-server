using System;
using Il2CppDummyDll;

[Token(Token = "0x2003E0A")]
public class AkWindowsSettings : AkWwiseInitializationSettings.PlatformSettings
{
	[Serializable]
	[Token(Token = "0x2003E0B")]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings
	{
		[Token(Token = "0x2003E0C")]
		public enum AudioAPI
		{
			[Token(Token = "0x401A4A0")]
			None = 0,
			[Token(Token = "0x401A4A1")]
			Wasapi = 1,
			[Token(Token = "0x401A4A2")]
			XAudio2 = 2,
			[Token(Token = "0x401A4A3")]
			DirectSound = 4,
			[Token(Token = "0x401A4A4")]
			Default = -1
		}

		[Token(Token = "0x401A49D")]
		[FieldOffset(Offset = "0x40")]
		public AudioAPI m_AudioAPI;

		[Token(Token = "0x401A49E")]
		[FieldOffset(Offset = "0x44")]
		public bool m_GlobalFocus;

		[Token(Token = "0x60193BE")]
		[Address(RVA = "0x2EC01C4", Offset = "0x2EC01C4", VA = "0x2EC01C4")]
		public PlatformAdvancedSettings()
		{
		}

		[Token(Token = "0x60193BF")]
		[Address(RVA = "0x2EC01DC", Offset = "0x2EC01DC", VA = "0x2EC01DC", Slot = "7")]
		public override void CopyTo(AkPlatformInitSettings settings)
		{
		}
	}

	[Token(Token = "0x401A49A")]
	[FieldOffset(Offset = "0x18")]
	public AkCommonUserSettings UserSettings;

	[Token(Token = "0x401A49B")]
	[FieldOffset(Offset = "0x1C")]
	public PlatformAdvancedSettings AdvancedSettings;

	[Token(Token = "0x401A49C")]
	[FieldOffset(Offset = "0x20")]
	public AkCommonCommSettings CommsSettings;

	[Token(Token = "0x60193BA")]
	[Address(RVA = "0x2EC00B8", Offset = "0x2EC00B8", VA = "0x2EC00B8")]
	public AkWindowsSettings()
	{
	}

	[Token(Token = "0x60193BB")]
	[Address(RVA = "0x2EC01AC", Offset = "0x2EC01AC", VA = "0x2EC01AC", Slot = "12")]
	protected override AkCommonUserSettings GetUserSettings()
	{
		return null;
	}

	[Token(Token = "0x60193BC")]
	[Address(RVA = "0x2EC01B4", Offset = "0x2EC01B4", VA = "0x2EC01B4", Slot = "13")]
	protected override AkCommonAdvancedSettings GetAdvancedSettings()
	{
		return null;
	}

	[Token(Token = "0x60193BD")]
	[Address(RVA = "0x2EC01BC", Offset = "0x2EC01BC", VA = "0x2EC01BC", Slot = "14")]
	protected override AkCommonCommSettings GetCommsSettings()
	{
		return null;
	}
}
