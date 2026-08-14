using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001ADE")]
public class PVECardRankDesc
{
	[Token(Token = "0x400A8F6")]
	[FieldOffset(Offset = "0x8")]
	public uint game_mode;

	[Token(Token = "0x400A8F7")]
	[FieldOffset(Offset = "0xC")]
	public uint map_id;

	[Token(Token = "0x400A8F8")]
	[FieldOffset(Offset = "0x10")]
	public uint difficulty;

	[Token(Token = "0x400A8F9")]
	[FieldOffset(Offset = "0x14")]
	public uint ai_type;

	[Token(Token = "0x400A8FA")]
	[FieldOffset(Offset = "0x18")]
	public uint match_rank;

	[Token(Token = "0x400A8FB")]
	[FieldOffset(Offset = "0x1C")]
	public uint diamond_card_num;

	[Token(Token = "0x400A8FC")]
	[FieldOffset(Offset = "0x20")]
	public uint gold_card_num;

	[Token(Token = "0x400A8FD")]
	[FieldOffset(Offset = "0x24")]
	public uint silver_card_num;

	[Token(Token = "0x400A8FE")]
	[FieldOffset(Offset = "0x28")]
	public uint bronze_card_num;

	[Token(Token = "0x400A8FF")]
	[FieldOffset(Offset = "0x2C")]
	public uint diamond_card_weight;

	[Token(Token = "0x400A900")]
	[FieldOffset(Offset = "0x30")]
	public uint gold_card_weight;

	[Token(Token = "0x400A901")]
	[FieldOffset(Offset = "0x34")]
	public uint silver_card_weight;

	[Token(Token = "0x400A902")]
	[FieldOffset(Offset = "0x38")]
	public uint bronze_card_weight;

	[Token(Token = "0x6008139")]
	[Address(RVA = "0x33DEEFC", Offset = "0x33DEEFC", VA = "0x33DEEFC")]
	public PVECardRankDesc()
	{
	}
}
