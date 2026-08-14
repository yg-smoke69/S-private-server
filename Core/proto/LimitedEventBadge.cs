using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014E2")]
public class LimitedEventBadge
{
	[Token(Token = "0x400901E")]
	[FieldOffset(Offset = "0x8")]
	public uint badge_id;

	[Token(Token = "0x400901F")]
	[FieldOffset(Offset = "0xC")]
	public uint badge_cnt;

	[Token(Token = "0x6007B37")]
	[Address(RVA = "0x30A49F4", Offset = "0x30A49F4", VA = "0x30A49F4")]
	public LimitedEventBadge()
	{
	}
}
