using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BB0")]
public class LuckyWheelSettingDesc
{
	[Token(Token = "0x400AE32")]
	[FieldOffset(Offset = "0x8")]
	public uint wheel_id;

	[Token(Token = "0x400AE33")]
	[FieldOffset(Offset = "0x10")]
	public long start_time;

	[Token(Token = "0x400AE34")]
	[FieldOffset(Offset = "0x18")]
	public long end_time;

	[Token(Token = "0x400AE35")]
	[FieldOffset(Offset = "0x20")]
	public uint free_refresh_times;

	[Token(Token = "0x400AE36")]
	[FieldOffset(Offset = "0x24")]
	public uint refresh_currency_amount;

	[Token(Token = "0x400AE37")]
	[FieldOffset(Offset = "0x28")]
	public bool is_show_weight;

	[Token(Token = "0x400AE38")]
	[FieldOffset(Offset = "0x29")]
	public bool melonpi_switch;

	[Token(Token = "0x600820B")]
	[Address(RVA = "0x30A7004", Offset = "0x30A7004", VA = "0x30A7004")]
	public LuckyWheelSettingDesc()
	{
	}
}
