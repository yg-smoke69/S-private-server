using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A6C")]
public class GameBonusEventDesc
{
	[Token(Token = "0x400A56A")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A56B")]
	[FieldOffset(Offset = "0xC")]
	public uint id;

	[Token(Token = "0x400A56C")]
	[FieldOffset(Offset = "0x10")]
	public uint match_mode;

	[Token(Token = "0x400A56D")]
	[FieldOffset(Offset = "0x14")]
	public uint game_mode;

	[Token(Token = "0x400A56E")]
	[FieldOffset(Offset = "0x18")]
	public uint map_id;

	[Token(Token = "0x400A56F")]
	[FieldOffset(Offset = "0x1C")]
	public int group_mode;

	[Token(Token = "0x400A570")]
	[FieldOffset(Offset = "0x20")]
	public uint exp_bonus;

	[Token(Token = "0x400A571")]
	[FieldOffset(Offset = "0x24")]
	public uint gold_bonus;

	[Token(Token = "0x400A572")]
	[FieldOffset(Offset = "0x28")]
	public uint gold_limit;

	[Token(Token = "0x400A573")]
	[FieldOffset(Offset = "0x2C")]
	public uint debris_limit;

	[Token(Token = "0x400A574")]
	[FieldOffset(Offset = "0x30")]
	public string start_time;

	[Token(Token = "0x400A575")]
	[FieldOffset(Offset = "0x34")]
	public string end_time;

	[Token(Token = "0x400A576")]
	[FieldOffset(Offset = "0x38")]
	public long start_timestamp;

	[Token(Token = "0x400A577")]
	[FieldOffset(Offset = "0x40")]
	public long end_timestamp;

	[Token(Token = "0x60080C9")]
	[Address(RVA = "0x30A181C", Offset = "0x30A181C", VA = "0x30A181C")]
	public GameBonusEventDesc()
	{
	}
}
