using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200022B")]
public class SettingURLData : CSVBaseData
{
	[Token(Token = "0x4000D54")]
	private const string LANGUAGE_DEFAULT = "default";

	[Token(Token = "0x4000D55")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, Dictionary<string, SettingURLData>> _Data;

	[Token(Token = "0x4000D56")]
	[FieldOffset(Offset = "0x8")]
	private string _003CRegionName_003Ek__BackingField;

	[Token(Token = "0x4000D57")]
	[FieldOffset(Offset = "0xC")]
	private string _003CLanguage_003Ek__BackingField;

	[Token(Token = "0x4000D58")]
	[FieldOffset(Offset = "0x10")]
	private string _003CCustomerServiceURL_003Ek__BackingField;

	[Token(Token = "0x4000D59")]
	[FieldOffset(Offset = "0x14")]
	private string _003CTermsOfServiceURL_003Ek__BackingField;

	[Token(Token = "0x4000D5A")]
	[FieldOffset(Offset = "0x18")]
	private string _003CPrivacyPoliciesURL_003Ek__BackingField;

	[Token(Token = "0x4000D5B")]
	[FieldOffset(Offset = "0x1C")]
	private bool _003CExternalForCustomerServiceURL_003Ek__BackingField;

	[Token(Token = "0x4000D5C")]
	[FieldOffset(Offset = "0x20")]
	private string _003CCustomerDelAccountURL_003Ek__BackingField;

	[Token(Token = "0x4000D5D")]
	[FieldOffset(Offset = "0x24")]
	private string _003CCustomerDelAccountReviewURL_003Ek__BackingField;

	[Token(Token = "0x17000161")]
	public string RegionName
	{
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x20E2ED8", Offset = "0x20E2ED8", VA = "0x20E2ED8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x20E2EE0", Offset = "0x20E2EE0", VA = "0x20E2EE0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000162")]
	public string Language
	{
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x20E2EE8", Offset = "0x20E2EE8", VA = "0x20E2EE8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x20E2EF0", Offset = "0x20E2EF0", VA = "0x20E2EF0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000163")]
	public string CustomerServiceURL
	{
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x20E2EF8", Offset = "0x20E2EF8", VA = "0x20E2EF8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x20E2F00", Offset = "0x20E2F00", VA = "0x20E2F00")]
		private set
		{
		}
	}

	[Token(Token = "0x17000164")]
	public string TermsOfServiceURL
	{
		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x20E2F08", Offset = "0x20E2F08", VA = "0x20E2F08")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x20E2F10", Offset = "0x20E2F10", VA = "0x20E2F10")]
		private set
		{
		}
	}

	[Token(Token = "0x17000165")]
	public string PrivacyPoliciesURL
	{
		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x20E2F18", Offset = "0x20E2F18", VA = "0x20E2F18")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x20E2F20", Offset = "0x20E2F20", VA = "0x20E2F20")]
		private set
		{
		}
	}

	[Token(Token = "0x17000166")]
	public bool ExternalForCustomerServiceURL
	{
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x20E2F28", Offset = "0x20E2F28", VA = "0x20E2F28")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x20E2F30", Offset = "0x20E2F30", VA = "0x20E2F30")]
		private set
		{
		}
	}

	[Token(Token = "0x17000167")]
	public string CustomerDelAccountURL
	{
		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x20E2F38", Offset = "0x20E2F38", VA = "0x20E2F38")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x20E2F40", Offset = "0x20E2F40", VA = "0x20E2F40")]
		private set
		{
		}
	}

	[Token(Token = "0x17000168")]
	public string CustomerDelAccountReviewURL
	{
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x20E2F48", Offset = "0x20E2F48", VA = "0x20E2F48")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x20E2F50", Offset = "0x20E2F50", VA = "0x20E2F50")]
		private set
		{
		}
	}

	[Token(Token = "0x6000AF8")]
	[Address(RVA = "0x20E2E54", Offset = "0x20E2E54", VA = "0x20E2E54")]
	public SettingURLData()
	{
	}

	[Token(Token = "0x6000B09")]
	[Address(RVA = "0x20E2F58", Offset = "0x20E2F58", VA = "0x20E2F58", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B0A")]
	[Address(RVA = "0x20E3114", Offset = "0x20E3114", VA = "0x20E3114", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000B0B")]
	[Address(RVA = "0x20E302C", Offset = "0x20E302C", VA = "0x20E302C")]
	public static string FormatPrimaryKey(string region, string language)
	{
		return null;
	}

	[Token(Token = "0x6000B0C")]
	[Address(RVA = "0x20E359C", Offset = "0x20E359C", VA = "0x20E359C")]
	public static SettingURLData Get(string region, string language)
	{
		return null;
	}

	[Token(Token = "0x6000B0D")]
	[Address(RVA = "0x20E36B8", Offset = "0x20E36B8", VA = "0x20E36B8")]
	private static Dictionary<string, SettingURLData> Get(string region)
	{
		return null;
	}

	[Token(Token = "0x6000B0E")]
	[Address(RVA = "0x20E394C", Offset = "0x20E394C", VA = "0x20E394C")]
	private static SettingURLData Get(string language, Dictionary<string, SettingURLData> data)
	{
		return null;
	}
}
