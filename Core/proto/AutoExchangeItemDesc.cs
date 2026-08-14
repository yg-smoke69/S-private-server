using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019C2")]
public class AutoExchangeItemDesc
{
	[Token(Token = "0x400A167")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400A168")]
	[FieldOffset(Offset = "0xC")]
	public uint dst_item_id;

	[Token(Token = "0x400A169")]
	[FieldOffset(Offset = "0x10")]
	public uint dst_item_num;

	[Token(Token = "0x400A16A")]
	[FieldOffset(Offset = "0x18")]
	public long start_time;

	[Token(Token = "0x400A16B")]
	[FieldOffset(Offset = "0x20")]
	public long end_time;

	[Token(Token = "0x600801A")]
	[Address(RVA = "0x317B034", Offset = "0x317B034", VA = "0x317B034")]
	public AutoExchangeItemDesc()
	{
	}
}
