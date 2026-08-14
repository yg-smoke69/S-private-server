using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AE2")]
public class PVECardAwardDesc
{
	[Token(Token = "0x400A916")]
	[FieldOffset(Offset = "0x8")]
	public uint game_mode;

	[Token(Token = "0x400A917")]
	[FieldOffset(Offset = "0xC")]
	public uint map_id;

	[Token(Token = "0x400A918")]
	[FieldOffset(Offset = "0x10")]
	public uint difficulty;

	[Token(Token = "0x400A919")]
	[FieldOffset(Offset = "0x14")]
	public uint ai_type;

	[Token(Token = "0x400A91A")]
	[FieldOffset(Offset = "0x18")]
	public uint card_rank;

	[Token(Token = "0x400A91B")]
	[FieldOffset(Offset = "0x1C")]
	public AwardFromCard pve_award;

	[Token(Token = "0x600813D")]
	[Address(RVA = "0x33DEDF0", Offset = "0x33DEDF0", VA = "0x33DEDF0")]
	public PVECardAwardDesc()
	{
	}
}
