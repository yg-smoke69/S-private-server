using System;
using Il2CppDummyDll;

[Token(Token = "0x2003DAF")]
public class AkAndroidSettings : AkWwiseInitializationSettings.PlatformSettings
{
	[Serializable]
	[Token(Token = "0x2003DB0")]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings
	{
		[Token(Token = "0x2003DB1")]
		public enum AudioAPI
		{
			[Token(Token = "0x401A372")]
			None = 0,
			[Token(Token = "0x401A373")]
			AAudio = 1,
			[Token(Token = "0x401A374")]
			OpenSL_ES = 2,
			[Token(Token = "0x401A375")]
			Default = -1
		}

		[Token(Token = "0x401A36F")]
		[FieldOffset(Offset = "0x40")]
		public AudioAPI m_AudioAPI;

		[Token(Token = "0x401A370")]
		[FieldOffset(Offset = "0x44")]
		public bool m_RoundFrameSizeToHardwareSize;

		[Token(Token = "0x601920C")]
		[Address(RVA = "0x35C0D90", Offset = "0x35C0D90", VA = "0x35C0D90")]
		public PlatformAdvancedSettings()
		{
		}

		[Token(Token = "0x601920D")]
		[Address(RVA = "0x35C0E48", Offset = "0x35C0E48", VA = "0x35C0E48", Slot = "7")]
		public override void CopyTo(AkPlatformInitSettings settings)
		{
		}
	}

	[Token(Token = "0x401A36C")]
	[FieldOffset(Offset = "0x18")]
	public AkCommonUserSettings UserSettings;

	[Token(Token = "0x401A36D")]
	[FieldOffset(Offset = "0x1C")]
	public PlatformAdvancedSettings AdvancedSettings;

	[Token(Token = "0x401A36E")]
	[FieldOffset(Offset = "0x20")]
	public AkCommonCommSettings CommsSettings;

	[Token(Token = "0x6019208")]
	[Address(RVA = "0x35C09E4", Offset = "0x35C09E4", VA = "0x35C09E4")]
	public AkAndroidSettings()
	{
	}

	[Token(Token = "0x6019209")]
	[Address(RVA = "0x35C0D74", Offset = "0x35C0D74", VA = "0x35C0D74", Slot = "12")]
	protected override AkCommonUserSettings GetUserSettings()
	{
		return null;
	}

	[Token(Token = "0x601920A")]
	[Address(RVA = "0x35C0D7C", Offset = "0x35C0D7C", VA = "0x35C0D7C", Slot = "13")]
	protected override AkCommonAdvancedSettings GetAdvancedSettings()
	{
		return null;
	}

	[Token(Token = "0x601920B")]
	[Address(RVA = "0x35C0D84", Offset = "0x35C0D84", VA = "0x35C0D84", Slot = "14")]
	protected override AkCommonCommSettings GetCommsSettings()
	{
		return null;
	}
}
