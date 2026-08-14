using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BB3")]
public class LuckyWheelABTestDesc
{
	[Token(Token = "0x400AE43")]
	[FieldOffset(Offset = "0x8")]
	public uint wheel_id;

	[Token(Token = "0x400AE44")]
	[FieldOffset(Offset = "0xC")]
	public string @class;

	[Token(Token = "0x400AE45")]
	[FieldOffset(Offset = "0x10")]
	public uint original_melon_pi;

	[Token(Token = "0x400AE46")]
	[FieldOffset(Offset = "0x14")]
	public uint abtest_melon_pi;

	[Token(Token = "0x600820E")]
	[Address(RVA = "0x30A6E30", Offset = "0x30A6E30", VA = "0x30A6E30")]
	public LuckyWheelABTestDesc()
	{
	}
}
