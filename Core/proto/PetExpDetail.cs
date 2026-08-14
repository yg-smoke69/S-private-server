using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001531")]
public class PetExpDetail
{
	[Token(Token = "0x4009212")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x4009213")]
	[FieldOffset(Offset = "0xC")]
	public string name;

	[Token(Token = "0x4009214")]
	[FieldOffset(Offset = "0x10")]
	public uint level_before;

	[Token(Token = "0x4009215")]
	[FieldOffset(Offset = "0x14")]
	public uint level_after;

	[Token(Token = "0x4009216")]
	[FieldOffset(Offset = "0x18")]
	public uint exp_before;

	[Token(Token = "0x4009217")]
	[FieldOffset(Offset = "0x1C")]
	public uint exp_after;

	[Token(Token = "0x4009218")]
	[FieldOffset(Offset = "0x20")]
	public uint skin_id;

	[Token(Token = "0x6007B7A")]
	[Address(RVA = "0x33DF594", Offset = "0x33DF594", VA = "0x33DF594")]
	public PetExpDetail()
	{
	}
}
