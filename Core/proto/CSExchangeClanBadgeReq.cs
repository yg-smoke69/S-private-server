using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001651")]
public class CSExchangeClanBadgeReq
{
	[Token(Token = "0x40095EA")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x40095EB")]
	[FieldOffset(Offset = "0x10")]
	public uint exchange_item_id;

	[Token(Token = "0x6007C9B")]
	[Address(RVA = "0x317FE78", Offset = "0x317FE78", VA = "0x317FE78")]
	public CSExchangeClanBadgeReq()
	{
	}
}
