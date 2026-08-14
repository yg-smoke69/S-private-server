using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2000186")]
public class LocURLData : CSVBaseData
{
	[Token(Token = "0x2000187")]
	public static class Keys
	{
		[Token(Token = "0x4000993")]
		public const string TERMS_OF_SERVICE = "LOC_URL_TERMS_OF_SERVICE";

		[Token(Token = "0x4000994")]
		public const string TERMS_OF_PRIVACY = "LOC_URL_TERMS_OF_PRIVACY";
	}

	[Token(Token = "0x4000991")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<int, string> keyToURL;

	[Token(Token = "0x4000992")]
	[FieldOffset(Offset = "0xC")]
	private string key;

	[Token(Token = "0x17000141")]
	public string Key
	{
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x2961498", Offset = "0x2961498", VA = "0x2961498")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000142")]
	public string Item
	{
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x29614A0", Offset = "0x29614A0", VA = "0x29614A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x29613E0", Offset = "0x29613E0", VA = "0x29613E0")]
	public LocURLData()
	{
	}

	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x29615A0", Offset = "0x29615A0", VA = "0x29615A0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60008C0")]
	[Address(RVA = "0x29615A8", Offset = "0x29615A8", VA = "0x29615A8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
