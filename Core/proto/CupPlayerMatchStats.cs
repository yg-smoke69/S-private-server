using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001571")]
public class CupPlayerMatchStats
{
	[Token(Token = "0x400932A")]
	[FieldOffset(Offset = "0x8")]
	public uint assists;

	[Token(Token = "0x400932B")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_type;

	[Token(Token = "0x400932C")]
	[FieldOffset(Offset = "0x10")]
	public uint deaths;

	[Token(Token = "0x400932D")]
	[FieldOffset(Offset = "0x14")]
	public uint mvp_count;

	[Token(Token = "0x400932E")]
	[FieldOffset(Offset = "0x18")]
	public uint kills;

	[Token(Token = "0x400932F")]
	[FieldOffset(Offset = "0x1C")]
	public uint double_kills;

	[Token(Token = "0x4009330")]
	[FieldOffset(Offset = "0x20")]
	public uint triple_kills;

	[Token(Token = "0x4009331")]
	[FieldOffset(Offset = "0x24")]
	public uint four_kills;

	[Token(Token = "0x4009332")]
	[FieldOffset(Offset = "0x28")]
	public uint damage;

	[Token(Token = "0x4009333")]
	[FieldOffset(Offset = "0x2C")]
	public uint head_shot_kills;

	[Token(Token = "0x4009334")]
	[FieldOffset(Offset = "0x30")]
	public uint knock_downs;

	[Token(Token = "0x4009335")]
	[FieldOffset(Offset = "0x34")]
	public uint revivals;

	[Token(Token = "0x6007BB9")]
	[Address(RVA = "0x309DDDC", Offset = "0x309DDDC", VA = "0x309DDDC")]
	public CupPlayerMatchStats()
	{
	}
}
