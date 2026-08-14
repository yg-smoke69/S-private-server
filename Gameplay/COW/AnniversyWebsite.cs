using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200009B")]
public class AnniversyWebsite : CSVBaseData
{
	[Token(Token = "0x200009C")]
	public enum Type
	{
		[Token(Token = "0x400036D")]
		None,
		[Token(Token = "0x400036E")]
		Main,
		[Token(Token = "0x400036F")]
		Invitation
	}

	[Token(Token = "0x4000363")]
	private const string REGION_DEFAULT = "default";

	[Token(Token = "0x4000364")]
	private const string LANGUAGE_DEFAULT = "default";

	[Token(Token = "0x4000365")]
	private const int TYPE_DEFAULT = 1;

	[Token(Token = "0x4000366")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, Dictionary<string, Dictionary<int, AnniversyWebsite>>> _Data;

	[Token(Token = "0x4000367")]
	[FieldOffset(Offset = "0x8")]
	private int _003CID_003Ek__BackingField;

	[Token(Token = "0x4000368")]
	[FieldOffset(Offset = "0xC")]
	private int _003CTitleType_003Ek__BackingField;

	[Token(Token = "0x4000369")]
	[FieldOffset(Offset = "0x10")]
	private string _003CRegion_003Ek__BackingField;

	[Token(Token = "0x400036A")]
	[FieldOffset(Offset = "0x14")]
	private string _003CLanguageAbbr_003Ek__BackingField;

	[Token(Token = "0x400036B")]
	[FieldOffset(Offset = "0x18")]
	private string _003CWebUrl_003Ek__BackingField;

	[Token(Token = "0x17000094")]
	public int ID
	{
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x14C754C", Offset = "0x14C754C", VA = "0x14C754C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x14C7554", Offset = "0x14C7554", VA = "0x14C7554")]
		private set
		{
		}
	}

	[Token(Token = "0x17000095")]
	public int TitleType
	{
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x14C755C", Offset = "0x14C755C", VA = "0x14C755C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x14C7564", Offset = "0x14C7564", VA = "0x14C7564")]
		private set
		{
		}
	}

	[Token(Token = "0x17000096")]
	public string Region
	{
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x14C756C", Offset = "0x14C756C", VA = "0x14C756C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x14C7574", Offset = "0x14C7574", VA = "0x14C7574")]
		private set
		{
		}
	}

	[Token(Token = "0x17000097")]
	public string LanguageAbbr
	{
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x14C757C", Offset = "0x14C757C", VA = "0x14C757C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x14C7584", Offset = "0x14C7584", VA = "0x14C7584")]
		private set
		{
		}
	}

	[Token(Token = "0x17000098")]
	public string WebUrl
	{
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x14C758C", Offset = "0x14C758C", VA = "0x14C758C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x14C7594", Offset = "0x14C7594", VA = "0x14C7594")]
		private set
		{
		}
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x14C6D78", Offset = "0x14C6D78", VA = "0x14C6D78")]
	public AnniversyWebsite()
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x14C6DFC", Offset = "0x14C6DFC", VA = "0x14C6DFC")]
	public static AnniversyWebsite Get(string region, string language, Type type = Type.Main)
	{
		return null;
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x14C6F60", Offset = "0x14C6F60", VA = "0x14C6F60")]
	private static Dictionary<string, Dictionary<int, AnniversyWebsite>> Get(string region)
	{
		return null;
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x14C7278", Offset = "0x14C7278", VA = "0x14C7278")]
	private static Dictionary<int, AnniversyWebsite> Get(string language, Dictionary<string, Dictionary<int, AnniversyWebsite>> data)
	{
		return null;
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x14C7404", Offset = "0x14C7404", VA = "0x14C7404")]
	private static AnniversyWebsite Get(int type, Dictionary<int, AnniversyWebsite> data)
	{
		return null;
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x14C759C", Offset = "0x14C759C", VA = "0x14C759C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x14C7618", Offset = "0x14C7618", VA = "0x14C7618", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
