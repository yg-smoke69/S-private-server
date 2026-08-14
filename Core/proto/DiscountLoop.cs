using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001ABA")]
public class DiscountLoop
{
	[Token(Token = "0x400A841")]
	[FieldOffset(Offset = "0x8")]
	public uint loop_id;

	[Token(Token = "0x400A842")]
	[FieldOffset(Offset = "0xC")]
	public string start_date;

	[Token(Token = "0x400A843")]
	[FieldOffset(Offset = "0x10")]
	public string end_date;

	[Token(Token = "0x6008117")]
	[Address(RVA = "0x309EFA8", Offset = "0x309EFA8", VA = "0x309EFA8")]
	public DiscountLoop()
	{
	}
}
