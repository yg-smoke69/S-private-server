using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A93")]
public class EPDebrisDropDesc
{
	[Token(Token = "0x400A665")]
	[FieldOffset(Offset = "0x8")]
	public uint ep_id;

	[Token(Token = "0x400A666")]
	[FieldOffset(Offset = "0xC")]
	public uint debris_id;

	[Token(Token = "0x400A667")]
	[FieldOffset(Offset = "0x10")]
	public uint kill_param;

	[Token(Token = "0x400A668")]
	[FieldOffset(Offset = "0x14")]
	public uint damage_param;

	[Token(Token = "0x400A669")]
	[FieldOffset(Offset = "0x18")]
	public uint rank_param;

	[Token(Token = "0x400A66A")]
	[FieldOffset(Offset = "0x1C")]
	public uint drop_game_max;

	[Token(Token = "0x400A66B")]
	[FieldOffset(Offset = "0x20")]
	public uint drop_daily_max;

	[Token(Token = "0x60080F0")]
	[Address(RVA = "0x309F534", Offset = "0x309F534", VA = "0x309F534")]
	public EPDebrisDropDesc()
	{
	}
}
