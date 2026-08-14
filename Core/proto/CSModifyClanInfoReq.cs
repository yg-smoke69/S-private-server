using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001633")]
public class CSModifyClanInfoReq
{
	[Token(Token = "0x400955F")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x4009560")]
	[FieldOffset(Offset = "0x10")]
	public string announcement;

	[Token(Token = "0x4009561")]
	[FieldOffset(Offset = "0x14")]
	public string slogan;

	[Token(Token = "0x4009562")]
	[FieldOffset(Offset = "0x18")]
	public uint entry_type;

	[Token(Token = "0x4009563")]
	[FieldOffset(Offset = "0x1C")]
	public uint area_id;

	[Token(Token = "0x4009564")]
	[FieldOffset(Offset = "0x20")]
	public uint play_style;

	[Token(Token = "0x4009565")]
	[FieldOffset(Offset = "0x24")]
	public uint entry_level;

	[Token(Token = "0x4009566")]
	[FieldOffset(Offset = "0x28")]
	public uint entry_rank;

	[Token(Token = "0x4009567")]
	[FieldOffset(Offset = "0x2C")]
	public uint clan_badge_id;

	[Token(Token = "0x4009568")]
	[FieldOffset(Offset = "0x30")]
	public uint entry_cs_rank;

	[Token(Token = "0x6007C7D")]
	[Address(RVA = "0x3097B44", Offset = "0x3097B44", VA = "0x3097B44")]
	public CSModifyClanInfoReq()
	{
	}
}
