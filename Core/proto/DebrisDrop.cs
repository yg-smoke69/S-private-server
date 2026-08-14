using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A67")]
public class DebrisDrop
{
	[Token(Token = "0x400A543")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x400A544")]
	[FieldOffset(Offset = "0xC")]
	public uint debris_id;

	[Token(Token = "0x400A545")]
	[FieldOffset(Offset = "0x10")]
	public uint drop_param;

	[Token(Token = "0x400A546")]
	[FieldOffset(Offset = "0x14")]
	public uint drop_daily_max;

	[Token(Token = "0x400A547")]
	[FieldOffset(Offset = "0x18")]
	public float skill_slot_drop_percent;

	[Token(Token = "0x400A548")]
	[FieldOffset(Offset = "0x1C")]
	public uint drop_kill_param;

	[Token(Token = "0x400A549")]
	[FieldOffset(Offset = "0x20")]
	public uint drop_damage_param;

	[Token(Token = "0x60080C4")]
	[Address(RVA = "0x309E570", Offset = "0x309E570", VA = "0x309E570")]
	public DebrisDrop()
	{
	}
}
