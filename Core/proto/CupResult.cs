using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013EA")]
public class CupResult
{
	[Token(Token = "0x4008B7B")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x4008B7C")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_id;

	[Token(Token = "0x4008B7D")]
	[FieldOffset(Offset = "0x10")]
	public bool win;

	[Token(Token = "0x6007ACB")]
	[Address(RVA = "0x309DDE4", Offset = "0x309DDE4", VA = "0x309DDE4")]
	public CupResult()
	{
	}
}
