using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001652")]
public class CSExchangeClanBadgeRes
{
	[Token(Token = "0x40095EC")]
	[FieldOffset(Offset = "0x8")]
	public uint exchange_badge_id;

	[Token(Token = "0x40095ED")]
	[FieldOffset(Offset = "0x10")]
	public ulong expire_time;

	[Token(Token = "0x6007C9C")]
	[Address(RVA = "0x317FE80", Offset = "0x317FE80", VA = "0x317FE80")]
	public CSExchangeClanBadgeRes()
	{
	}
}
