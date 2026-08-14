using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BAB")]
public class CupNameOverwriteDesc
{
	[Token(Token = "0x400AE1D")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x400AE1E")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_id;

	[Token(Token = "0x400AE1F")]
	[FieldOffset(Offset = "0x10")]
	public uint name_type;

	[Token(Token = "0x400AE20")]
	[FieldOffset(Offset = "0x14")]
	public string language;

	[Token(Token = "0x400AE21")]
	[FieldOffset(Offset = "0x18")]
	public string content;

	[Token(Token = "0x6008206")]
	[Address(RVA = "0x309DD28", Offset = "0x309DD28", VA = "0x309DD28")]
	public CupNameOverwriteDesc()
	{
	}
}
