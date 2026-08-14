using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001ADA")]
public class CardAwardDesc
{
	[Token(Token = "0x400A8ED")]
	[FieldOffset(Offset = "0x8")]
	public uint card_id;

	[Token(Token = "0x400A8EE")]
	[FieldOffset(Offset = "0xC")]
	public uint pool_weight;

	[Token(Token = "0x400A8EF")]
	[FieldOffset(Offset = "0x10")]
	public AwardFromCard award;

	[Token(Token = "0x6008136")]
	[Address(RVA = "0x309AB90", Offset = "0x309AB90", VA = "0x309AB90")]
	public CardAwardDesc()
	{
	}
}
