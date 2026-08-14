using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001628")]
public class CSCreateClanReq
{
	[Token(Token = "0x4009543")]
	[FieldOffset(Offset = "0x8")]
	public string clan_name;

	[Token(Token = "0x4009544")]
	[FieldOffset(Offset = "0x10")]
	public ulong captain_id;

	[Token(Token = "0x4009545")]
	[FieldOffset(Offset = "0x18")]
	public string announcement;

	[Token(Token = "0x4009546")]
	[FieldOffset(Offset = "0x1C")]
	public string slogan;

	[Token(Token = "0x4009547")]
	[FieldOffset(Offset = "0x20")]
	public uint currency_type;

	[Token(Token = "0x4009548")]
	[FieldOffset(Offset = "0x24")]
	public uint entry_type;

	[Token(Token = "0x4009549")]
	[FieldOffset(Offset = "0x28")]
	public uint area_id;

	[Token(Token = "0x400954A")]
	[FieldOffset(Offset = "0x2C")]
	public uint play_style;

	[Token(Token = "0x400954B")]
	[FieldOffset(Offset = "0x30")]
	public uint entry_level;

	[Token(Token = "0x400954C")]
	[FieldOffset(Offset = "0x34")]
	public uint entry_rank;

	[Token(Token = "0x400954D")]
	[FieldOffset(Offset = "0x38")]
	public uint clan_badge_id;

	[Token(Token = "0x400954E")]
	[FieldOffset(Offset = "0x3C")]
	public uint entry_cs_rank;

	[Token(Token = "0x6007C72")]
	[Address(RVA = "0x317F168", Offset = "0x317F168", VA = "0x317F168")]
	public CSCreateClanReq()
	{
	}
}
