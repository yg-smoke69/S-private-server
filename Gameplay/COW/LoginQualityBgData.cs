using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000189")]
public class LoginQualityBgData : CSVBaseData
{
	[Token(Token = "0x4000997")]
	[FieldOffset(Offset = "0x8")]
	public uint LoginId;

	[Token(Token = "0x4000998")]
	[FieldOffset(Offset = "0xC")]
	public string CountryCode;

	[Token(Token = "0x4000999")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID ResId;

	[Token(Token = "0x60008C4")]
	[Address(RVA = "0x152D0D0", Offset = "0x152D0D0", VA = "0x152D0D0")]
	public LoginQualityBgData()
	{
	}

	[Token(Token = "0x60008C5")]
	[Address(RVA = "0x152D154", Offset = "0x152D154", VA = "0x152D154", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60008C6")]
	[Address(RVA = "0x152D1B8", Offset = "0x152D1B8", VA = "0x152D1B8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
