using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2003DDA")]
public class AkWwiseInitializationSettings : AkCommonPlatformSettings
{
	[Token(Token = "0x2003DDB")]
	public abstract class PlatformSettings : AkCommonPlatformSettings
	{
		[Token(Token = "0x401A43C")]
		[FieldOffset(Offset = "0xC")]
		private List<string> IgnorePropertyNameList;

		[Token(Token = "0x401A43D")]
		[FieldOffset(Offset = "0x10")]
		private List<string> GlobalPropertyNameList;

		[Token(Token = "0x401A43E")]
		[FieldOffset(Offset = "0x14")]
		private HashSet<string> _GlobalPropertyHashSet;

		[Token(Token = "0x17001B31")]
		public HashSet<string> GlobalPropertyHashSet
		{
			[Token(Token = "0x60192CD")]
			[Address(RVA = "0x2EC36DC", Offset = "0x2EC36DC", VA = "0x2EC36DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60192CE")]
			[Address(RVA = "0x2EC3774", Offset = "0x2EC3774", VA = "0x2EC3774")]
			set
			{
			}
		}

		[Token(Token = "0x60192C7")]
		[Address(RVA = "0x2EC00BC", Offset = "0x2EC00BC", VA = "0x2EC00BC")]
		protected PlatformSettings()
		{
		}

		[Token(Token = "0x60192C8")]
		[Address(RVA = "0x2EC346C", Offset = "0x2EC346C", VA = "0x2EC346C")]
		public void IgnorePropertyValue(string propertyPath)
		{
		}

		[Token(Token = "0x60192C9")]
		[Address(RVA = "0x2EC3510", Offset = "0x2EC3510", VA = "0x2EC3510")]
		public bool IsPropertyIgnored(string propertyPath)
		{
			return default(bool);
		}

		[Token(Token = "0x60192CA")]
		[Address(RVA = "0x2EC3590", Offset = "0x2EC3590", VA = "0x2EC3590")]
		public void SetUseGlobalPropertyValue(string propertyPath, bool use)
		{
		}

		[Token(Token = "0x60192CB")]
		[Address(RVA = "0x2EC30E0", Offset = "0x2EC30E0", VA = "0x2EC30E0")]
		public void SetGlobalPropertyValues(IEnumerable enumerable)
		{
		}

		[Token(Token = "0x60192CC")]
		[Address(RVA = "0x2EC365C", Offset = "0x2EC365C", VA = "0x2EC365C")]
		private bool IsUsingGlobalPropertyValue(string propertyPath)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003DDC")]
	public class CommonPlatformSettings : PlatformSettings
	{
		[Token(Token = "0x401A43F")]
		[FieldOffset(Offset = "0x18")]
		public AkCommonUserSettings UserSettings;

		[Token(Token = "0x401A440")]
		[FieldOffset(Offset = "0x1C")]
		public AkCommonAdvancedSettings AdvancedSettings;

		[Token(Token = "0x401A441")]
		[FieldOffset(Offset = "0x20")]
		public AkCommonCommSettings CommsSettings;

		[Token(Token = "0x60192CF")]
		[Address(RVA = "0x2EC30C4", Offset = "0x2EC30C4", VA = "0x2EC30C4")]
		public CommonPlatformSettings()
		{
		}

		[Token(Token = "0x60192D0")]
		[Address(RVA = "0x2EC30C8", Offset = "0x2EC30C8", VA = "0x2EC30C8", Slot = "12")]
		protected override AkCommonUserSettings GetUserSettings()
		{
			return null;
		}

		[Token(Token = "0x60192D1")]
		[Address(RVA = "0x2EC30D0", Offset = "0x2EC30D0", VA = "0x2EC30D0", Slot = "13")]
		protected override AkCommonAdvancedSettings GetAdvancedSettings()
		{
			return null;
		}

		[Token(Token = "0x60192D2")]
		[Address(RVA = "0x2EC30D8", Offset = "0x2EC30D8", VA = "0x2EC30D8", Slot = "14")]
		protected override AkCommonCommSettings GetCommsSettings()
		{
			return null;
		}
	}

	[Token(Token = "0x401A433")]
	[FieldOffset(Offset = "0xC")]
	public List<string> PlatformSettingsNameList;

	[Token(Token = "0x401A434")]
	[FieldOffset(Offset = "0x10")]
	public List<PlatformSettings> PlatformSettingsList;

	[Token(Token = "0x401A435")]
	[FieldOffset(Offset = "0x14")]
	public List<string> InvalidReferencePlatforms;

	[Token(Token = "0x401A436")]
	[FieldOffset(Offset = "0x18")]
	public AkCommonUserSettings UserSettings;

	[Token(Token = "0x401A437")]
	[FieldOffset(Offset = "0x1C")]
	public AkCommonAdvancedSettings AdvancedSettings;

	[Token(Token = "0x401A438")]
	[FieldOffset(Offset = "0x20")]
	public AkCommonCommSettings CommsSettings;

	[Token(Token = "0x401A439")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string[] AllGlobalValues;

	[Token(Token = "0x401A43A")]
	[FieldOffset(Offset = "0x4")]
	private static AkWwiseInitializationSettings m_Instance;

	[Token(Token = "0x401A43B")]
	[FieldOffset(Offset = "0x8")]
	private static AkBasePlatformSettings m_ActivePlatformSettings;

	[Token(Token = "0x17001B2D")]
	public bool IsValid
	{
		[Token(Token = "0x60192B9")]
		[Address(RVA = "0x2EC02B8", Offset = "0x2EC02B8", VA = "0x2EC02B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B2E")]
	public int Count
	{
		[Token(Token = "0x60192BA")]
		[Address(RVA = "0x2EC0370", Offset = "0x2EC0370", VA = "0x2EC0370")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001B2F")]
	public static AkWwiseInitializationSettings Instance
	{
		[Token(Token = "0x60192BE")]
		[Address(RVA = "0x2EC0400", Offset = "0x2EC0400", VA = "0x2EC0400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B30")]
	public static AkBasePlatformSettings ActivePlatformSettings
	{
		[Token(Token = "0x60192C0")]
		[Address(RVA = "0x2EC0830", Offset = "0x2EC0830", VA = "0x2EC0830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60192B8")]
	[Address(RVA = "0x2EC01E0", Offset = "0x2EC01E0", VA = "0x2EC01E0")]
	public AkWwiseInitializationSettings()
	{
	}

	[Token(Token = "0x60192BB")]
	[Address(RVA = "0x2EC03E8", Offset = "0x2EC03E8", VA = "0x2EC03E8", Slot = "12")]
	protected override AkCommonUserSettings GetUserSettings()
	{
		return null;
	}

	[Token(Token = "0x60192BC")]
	[Address(RVA = "0x2EC03F0", Offset = "0x2EC03F0", VA = "0x2EC03F0", Slot = "13")]
	protected override AkCommonAdvancedSettings GetAdvancedSettings()
	{
		return null;
	}

	[Token(Token = "0x60192BD")]
	[Address(RVA = "0x2EC03F8", Offset = "0x2EC03F8", VA = "0x2EC03F8", Slot = "14")]
	protected override AkCommonCommSettings GetCommsSettings()
	{
		return null;
	}

	[Token(Token = "0x60192BF")]
	[Address(RVA = "0x2EC05B4", Offset = "0x2EC05B4", VA = "0x2EC05B4")]
	private static AkBasePlatformSettings GetPlatformSettings(string platformName)
	{
		return null;
	}

	[Token(Token = "0x60192C1")]
	[Address(RVA = "0x2EC09D0", Offset = "0x2EC09D0", VA = "0x2EC09D0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60192C2")]
	[Address(RVA = "0x2EC0BAC", Offset = "0x2EC0BAC", VA = "0x2EC0BAC")]
	public static bool InitializeSoundEngine()
	{
		return default(bool);
	}

	[Token(Token = "0x60192C3")]
	[Address(RVA = "0x2EC1608", Offset = "0x2EC1608", VA = "0x2EC1608")]
	public static bool ResetSoundEngine(bool isPlaying)
	{
		return default(bool);
	}

	[Token(Token = "0x60192C4")]
	[Address(RVA = "0x2EC1760", Offset = "0x2EC1760", VA = "0x2EC1760")]
	public static void TerminateSoundEngine()
	{
	}

	[Token(Token = "0x60192C5")]
	[Address(RVA = "0x2EC19B0", Offset = "0x2EC19B0", VA = "0x2EC19B0")]
	private static void SleepForMilliseconds(double milliseconds)
	{
	}
}
