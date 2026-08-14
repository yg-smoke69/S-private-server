using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AD9")]
public class CardPool
{
	[Token(Token = "0x400A8EA")]
	[FieldOffset(Offset = "0x8")]
	public uint card_id;

	[Token(Token = "0x400A8EB")]
	[FieldOffset(Offset = "0xC")]
	public uint pool_weight;

	[Token(Token = "0x400A8EC")]
	[FieldOffset(Offset = "0x10")]
	public bool is_used;

	[Token(Token = "0x6008135")]
	[Address(RVA = "0x309AC38", Offset = "0x309AC38", VA = "0x309AC38")]
	public CardPool()
	{
	}
}
