using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000252")]
public class TutorialURLData : CSVBaseData
{
	[Token(Token = "0x4000E17")]
	private const string DEFAULT_LANG_REGION = "default";

	[Token(Token = "0x4000E18")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, Dictionary<string, TutorialURLData>> _Data;

	[Token(Token = "0x4000E19")]
	[FieldOffset(Offset = "0x8")]
	private string _003CLanguage_003Ek__BackingField;

	[Token(Token = "0x4000E1A")]
	[FieldOffset(Offset = "0xC")]
	private string _003CTutorialURL_003Ek__BackingField;

	[Token(Token = "0x4000E1B")]
	[FieldOffset(Offset = "0x10")]
	private string _003CVideoURL_003Ek__BackingField;

	[Token(Token = "0x4000E1C")]
	[FieldOffset(Offset = "0x14")]
	private string _003CRegion_003Ek__BackingField;

	[Token(Token = "0x17000170")]
	public string Language
	{
		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x2335138", Offset = "0x2335138", VA = "0x2335138")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x2335140", Offset = "0x2335140", VA = "0x2335140")]
		private set
		{
		}
	}

	[Token(Token = "0x17000171")]
	public string TutorialURL
	{
		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x2335148", Offset = "0x2335148", VA = "0x2335148")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x2335150", Offset = "0x2335150", VA = "0x2335150")]
		private set
		{
		}
	}

	[Token(Token = "0x17000172")]
	public string VideoURL
	{
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x2335158", Offset = "0x2335158", VA = "0x2335158")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x2335160", Offset = "0x2335160", VA = "0x2335160")]
		private set
		{
		}
	}

	[Token(Token = "0x17000173")]
	public string Region
	{
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x2335168", Offset = "0x2335168", VA = "0x2335168")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x2335170", Offset = "0x2335170", VA = "0x2335170")]
		private set
		{
		}
	}

	[Token(Token = "0x6000B8A")]
	[Address(RVA = "0x23350B4", Offset = "0x23350B4", VA = "0x23350B4")]
	public TutorialURLData()
	{
	}

	[Token(Token = "0x6000B93")]
	[Address(RVA = "0x2335178", Offset = "0x2335178", VA = "0x2335178", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B94")]
	[Address(RVA = "0x2335334", Offset = "0x2335334", VA = "0x2335334", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000B95")]
	[Address(RVA = "0x233524C", Offset = "0x233524C", VA = "0x233524C")]
	public static string FormatPrimaryKey(string region, string language)
	{
		return null;
	}

	[Token(Token = "0x6000B96")]
	[Address(RVA = "0x2335704", Offset = "0x2335704", VA = "0x2335704")]
	public static TutorialURLData Get(string region, string language)
	{
		return null;
	}

	[Token(Token = "0x6000B97")]
	[Address(RVA = "0x233585C", Offset = "0x233585C", VA = "0x233585C")]
	private static Dictionary<string, TutorialURLData> Get(string region)
	{
		return null;
	}

	[Token(Token = "0x6000B98")]
	[Address(RVA = "0x2335AF0", Offset = "0x2335AF0", VA = "0x2335AF0")]
	private static TutorialURLData Get(string language, Dictionary<string, TutorialURLData> data)
	{
		return null;
	}
}
