using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200156A")]
public class CSGetCupConfigReq
{
	[Token(Token = "0x400930F")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x4009310")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_id;

	[Token(Token = "0x4009311")]
	[FieldOffset(Offset = "0x10")]
	public string language;

	[Token(Token = "0x6007BB2")]
	[Address(RVA = "0x3183508", Offset = "0x3183508", VA = "0x3183508")]
	public CSGetCupConfigReq()
	{
	}
}
