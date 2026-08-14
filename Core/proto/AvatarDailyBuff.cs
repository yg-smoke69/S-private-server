using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A68")]
public class AvatarDailyBuff
{
	[Token(Token = "0x400A54A")]
	[FieldOffset(Offset = "0x8")]
	public uint daily_buff_range_start;

	[Token(Token = "0x400A54B")]
	[FieldOffset(Offset = "0xC")]
	public uint daily_buff_range_end;

	[Token(Token = "0x400A54C")]
	[FieldOffset(Offset = "0x10")]
	public float buff_value;

	[Token(Token = "0x400A54D")]
	[FieldOffset(Offset = "0x14")]
	public float next_buff_value;

	[Token(Token = "0x60080C5")]
	[Address(RVA = "0x317B164", Offset = "0x317B164", VA = "0x317B164")]
	public AvatarDailyBuff()
	{
	}
}
