using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C1A")]
public class DigitaluniverseBStarCraftConfigDesc
{
	[Token(Token = "0x400B0DB")]
	[FieldOffset(Offset = "0x8")]
	public uint token_id;

	[Token(Token = "0x400B0DC")]
	[FieldOffset(Offset = "0xC")]
	public uint assist_token;

	[Token(Token = "0x400B0DD")]
	[FieldOffset(Offset = "0x10")]
	public uint assisted_token;

	[Token(Token = "0x400B0DE")]
	[FieldOffset(Offset = "0x14")]
	public uint limit_of_assistance;

	[Token(Token = "0x400B0DF")]
	[FieldOffset(Offset = "0x18")]
	public uint recover_speed;

	[Token(Token = "0x400B0E0")]
	[FieldOffset(Offset = "0x1C")]
	public uint limit_of_token;

	[Token(Token = "0x400B0E1")]
	[FieldOffset(Offset = "0x20")]
	public uint help_value;

	[Token(Token = "0x400B0E2")]
	[FieldOffset(Offset = "0x24")]
	public uint play_together_value;

	[Token(Token = "0x400B0E3")]
	[FieldOffset(Offset = "0x28")]
	public uint initial_value;

	[Token(Token = "0x400B0E4")]
	[FieldOffset(Offset = "0x2C")]
	public uint history_length;

	[Token(Token = "0x400B0E5")]
	[FieldOffset(Offset = "0x30")]
	public uint initial_player_value;

	[Token(Token = "0x400B0E6")]
	[FieldOffset(Offset = "0x34")]
	public uint add_player_value;

	[Token(Token = "0x400B0E7")]
	[FieldOffset(Offset = "0x38")]
	public uint initial_number;

	[Token(Token = "0x400B0E8")]
	[FieldOffset(Offset = "0x3C")]
	public uint top_limit;

	[Token(Token = "0x400B0E9")]
	[FieldOffset(Offset = "0x40")]
	public uint initialization_friend_number;

	[Token(Token = "0x6008274")]
	[Address(RVA = "0x309ED98", Offset = "0x309ED98", VA = "0x309ED98")]
	public DigitaluniverseBStarCraftConfigDesc()
	{
	}
}
