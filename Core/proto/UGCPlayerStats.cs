using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018FD")]
public class UGCPlayerStats
{
	[Token(Token = "0x4009E63")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009E64")]
	[FieldOffset(Offset = "0x10")]
	public string nickname;

	[Token(Token = "0x4009E65")]
	[FieldOffset(Offset = "0x14")]
	public string clan_name;

	[Token(Token = "0x4009E66")]
	[FieldOffset(Offset = "0x18")]
	public uint head_pic;

	[Token(Token = "0x4009E67")]
	[FieldOffset(Offset = "0x1C")]
	public uint banner_id;

	[Token(Token = "0x4009E68")]
	[FieldOffset(Offset = "0x20")]
	public uint avatar_id;

	[Token(Token = "0x4009E69")]
	[FieldOffset(Offset = "0x24")]
	public uint role;

	[Token(Token = "0x4009E6A")]
	[FieldOffset(Offset = "0x28")]
	public uint liked;

	[Token(Token = "0x4009E6B")]
	[FieldOffset(Offset = "0x2C")]
	public string lock_region;

	[Token(Token = "0x4009E6C")]
	[FieldOffset(Offset = "0x30")]
	public bool is_mvp;

	[Token(Token = "0x4009E6D")]
	[FieldOffset(Offset = "0x31")]
	public bool is_quit;

	[Token(Token = "0x4009E6E")]
	[FieldOffset(Offset = "0x34")]
	public uint relation_mask;

	[Token(Token = "0x4009E6F")]
	[FieldOffset(Offset = "0x38")]
	public int[] score_to_show;

	[Token(Token = "0x4009E70")]
	[FieldOffset(Offset = "0x3C")]
	public uint global_rank;

	[Token(Token = "0x6007F56")]
	[Address(RVA = "0x33E3F2C", Offset = "0x33E3F2C", VA = "0x33E3F2C")]
	public UGCPlayerStats()
	{
	}
}
