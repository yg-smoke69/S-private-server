using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000F8")]
public class CommunityWebsiteData : CSVBaseData
{
	[Token(Token = "0x4000643")]
	private const string REGION_DEFAULT = "default";

	[Token(Token = "0x4000644")]
	private const string LANGUAGE_DEFAULT = "default";

	[Token(Token = "0x4000645")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, Dictionary<string, CommunityWebsiteData>> _Data;

	[Token(Token = "0x4000646")]
	[FieldOffset(Offset = "0x8")]
	private string _003CRegion_003Ek__BackingField;

	[Token(Token = "0x4000647")]
	[FieldOffset(Offset = "0xC")]
	private string _003CLanguageAbbr_003Ek__BackingField;

	[Token(Token = "0x4000648")]
	[FieldOffset(Offset = "0x10")]
	private string _003CFacebookURL_003Ek__BackingField;

	[Token(Token = "0x4000649")]
	[FieldOffset(Offset = "0x14")]
	private string _003COfficialURL_003Ek__BackingField;

	[Token(Token = "0x400064A")]
	[FieldOffset(Offset = "0x18")]
	private string _003CGER_TermsOfService_003Ek__BackingField;

	[Token(Token = "0x400064B")]
	[FieldOffset(Offset = "0x1C")]
	private string _003CGER_HelpAndSupport_003Ek__BackingField;

	[Token(Token = "0x400064C")]
	[FieldOffset(Offset = "0x20")]
	public string Inslwebsite;

	[Token(Token = "0x400064D")]
	[FieldOffset(Offset = "0x24")]
	private int _003CID_003Ek__BackingField;

	[Token(Token = "0x400064E")]
	[FieldOffset(Offset = "0x28")]
	private bool _003CExternalForFacebook_003Ek__BackingField;

	[Token(Token = "0x400064F")]
	[FieldOffset(Offset = "0x29")]
	private bool _003CExternalForOfficial_003Ek__BackingField;

	[Token(Token = "0x4000650")]
	[FieldOffset(Offset = "0x2A")]
	private bool _003CShowFacebook_003Ek__BackingField;

	[Token(Token = "0x4000651")]
	[FieldOffset(Offset = "0x2B")]
	private bool _003CShowOfficial_003Ek__BackingField;

	[Token(Token = "0x4000652")]
	[FieldOffset(Offset = "0x2C")]
	public bool ExternalForIns;

	[Token(Token = "0x4000653")]
	[FieldOffset(Offset = "0x2D")]
	public bool ShowIns;

	[Token(Token = "0x1700010A")]
	public string Region
	{
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1C7F858", Offset = "0x1C7F858", VA = "0x1C7F858")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1C7F860", Offset = "0x1C7F860", VA = "0x1C7F860")]
		private set
		{
		}
	}

	[Token(Token = "0x1700010B")]
	public string LanguageAbbr
	{
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1C7F868", Offset = "0x1C7F868", VA = "0x1C7F868")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x1C7F870", Offset = "0x1C7F870", VA = "0x1C7F870")]
		private set
		{
		}
	}

	[Token(Token = "0x1700010C")]
	public string FacebookURL
	{
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1C7F878", Offset = "0x1C7F878", VA = "0x1C7F878")]
		get
		{
			return null;
		}
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x1C7F880", Offset = "0x1C7F880", VA = "0x1C7F880")]
		private set
		{
		}
	}

	[Token(Token = "0x1700010D")]
	public string OfficialURL
	{
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1C7F888", Offset = "0x1C7F888", VA = "0x1C7F888")]
		get
		{
			return null;
		}
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1C7F890", Offset = "0x1C7F890", VA = "0x1C7F890")]
		private set
		{
		}
	}

	[Token(Token = "0x1700010E")]
	public string GER_TermsOfService
	{
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1C7F898", Offset = "0x1C7F898", VA = "0x1C7F898")]
		get
		{
			return null;
		}
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1C7F8A0", Offset = "0x1C7F8A0", VA = "0x1C7F8A0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700010F")]
	public string GER_HelpAndSupport
	{
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1C7F8A8", Offset = "0x1C7F8A8", VA = "0x1C7F8A8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1C7F8B0", Offset = "0x1C7F8B0", VA = "0x1C7F8B0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000110")]
	public int ID
	{
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1C7F8B8", Offset = "0x1C7F8B8", VA = "0x1C7F8B8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1C7F8C0", Offset = "0x1C7F8C0", VA = "0x1C7F8C0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000111")]
	public bool ExternalForFacebook
	{
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1C7F8C8", Offset = "0x1C7F8C8", VA = "0x1C7F8C8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1C7F8D0", Offset = "0x1C7F8D0", VA = "0x1C7F8D0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000112")]
	public bool ExternalForOfficial
	{
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1C7F8D8", Offset = "0x1C7F8D8", VA = "0x1C7F8D8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1C7F8E0", Offset = "0x1C7F8E0", VA = "0x1C7F8E0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000113")]
	public bool ShowFacebook
	{
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1C7F8E8", Offset = "0x1C7F8E8", VA = "0x1C7F8E8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1C7F8F0", Offset = "0x1C7F8F0", VA = "0x1C7F8F0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000114")]
	public bool ShowOfficial
	{
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1C7F8F8", Offset = "0x1C7F8F8", VA = "0x1C7F8F8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1C7F900", Offset = "0x1C7F900", VA = "0x1C7F900")]
		private set
		{
		}
	}

	[Token(Token = "0x6000632")]
	[Address(RVA = "0x1C7F200", Offset = "0x1C7F200", VA = "0x1C7F200")]
	public CommunityWebsiteData()
	{
	}

	[Token(Token = "0x6000633")]
	[Address(RVA = "0x1C7F284", Offset = "0x1C7F284", VA = "0x1C7F284")]
	public static CommunityWebsiteData Get(string region, string language)
	{
		return null;
	}

	[Token(Token = "0x6000634")]
	[Address(RVA = "0x1C7F3B4", Offset = "0x1C7F3B4", VA = "0x1C7F3B4")]
	private static Dictionary<string, CommunityWebsiteData> Get(string region)
	{
		return null;
	}

	[Token(Token = "0x6000635")]
	[Address(RVA = "0x1C7F6CC", Offset = "0x1C7F6CC", VA = "0x1C7F6CC")]
	private static CommunityWebsiteData Get(string language, Dictionary<string, CommunityWebsiteData> data)
	{
		return null;
	}

	[Token(Token = "0x600064C")]
	[Address(RVA = "0x1C7F908", Offset = "0x1C7F908", VA = "0x1C7F908", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600064D")]
	[Address(RVA = "0x1C7F9E0", Offset = "0x1C7F9E0", VA = "0x1C7F9E0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
