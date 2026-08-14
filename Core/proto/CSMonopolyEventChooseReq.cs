using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001849")]
public class CSMonopolyEventChooseReq
{
	[Token(Token = "0x4009C99")]
	[FieldOffset(Offset = "0x8")]
	public uint choice;

	[Token(Token = "0x4009C9A")]
	[FieldOffset(Offset = "0xC")]
	public string language;

	[Token(Token = "0x6007EA3")]
	[Address(RVA = "0x3097F30", Offset = "0x3097F30", VA = "0x3097F30")]
	public CSMonopolyEventChooseReq()
	{
	}
}
