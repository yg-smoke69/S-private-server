using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000188")]
public class LoginPlatformData : CSVBaseData
{
	[Token(Token = "0x4000995")]
	[FieldOffset(Offset = "0x8")]
	public string Country;

	[Token(Token = "0x4000996")]
	[FieldOffset(Offset = "0xC")]
	public PlatformType Platformtype;

	[Token(Token = "0x60008C1")]
	[Address(RVA = "0x152CEAC", Offset = "0x152CEAC", VA = "0x152CEAC")]
	public LoginPlatformData()
	{
	}

	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x152CF30", Offset = "0x152CF30", VA = "0x152CF30", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60008C3")]
	[Address(RVA = "0x152CF88", Offset = "0x152CF88", VA = "0x152CF88", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
