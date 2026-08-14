using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AE4")]
public class AwardFromCard
{
	[Token(Token = "0x400A91E")]
	[FieldOffset(Offset = "0x8")]
	public uint weight;

	[Token(Token = "0x400A91F")]
	[FieldOffset(Offset = "0xC")]
	public EInventory.AwardType award_type;

	[Token(Token = "0x400A920")]
	[FieldOffset(Offset = "0x10")]
	public uint award_id;

	[Token(Token = "0x400A921")]
	[FieldOffset(Offset = "0x14")]
	public uint award_num;

	[Token(Token = "0x400A922")]
	[FieldOffset(Offset = "0x18")]
	public uint award_level;

	[Token(Token = "0x400A923")]
	[FieldOffset(Offset = "0x1C")]
	public uint from_card_rank;

	[Token(Token = "0x600813F")]
	[Address(RVA = "0x317B508", Offset = "0x317B508", VA = "0x317B508")]
	public AwardFromCard()
	{
	}
}
