using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001648")]
public class LuckyBagDraw
{
	[Token(Token = "0x40095C1")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40095C2")]
	[FieldOffset(Offset = "0x10")]
	public ulong bag_id;

	[Token(Token = "0x40095C3")]
	[FieldOffset(Offset = "0x18")]
	public ulong opened_at;

	[Token(Token = "0x40095C4")]
	[FieldOffset(Offset = "0x20")]
	public uint level;

	[Token(Token = "0x6007C92")]
	[Address(RVA = "0x30A6E28", Offset = "0x30A6E28", VA = "0x30A6E28")]
	public LuckyBagDraw()
	{
	}
}
