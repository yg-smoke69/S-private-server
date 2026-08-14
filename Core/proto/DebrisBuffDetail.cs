using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001534")]
public class DebrisBuffDetail
{
	[Token(Token = "0x4009222")]
	[FieldOffset(Offset = "0x8")]
	public float buff_value;

	[Token(Token = "0x4009223")]
	[FieldOffset(Offset = "0xC")]
	public uint buff_remain_time;

	[Token(Token = "0x4009224")]
	[FieldOffset(Offset = "0x10")]
	public float next_buff_value;

	[Token(Token = "0x6007B7C")]
	[Address(RVA = "0x309E560", Offset = "0x309E560", VA = "0x309E560")]
	public DebrisBuffDetail()
	{
	}
}
