using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014DD")]
public class BoybandBTradingCardInfo
{
	[Token(Token = "0x4009014")]
	[FieldOffset(Offset = "0x8")]
	public uint card_id;

	[Token(Token = "0x4009015")]
	[FieldOffset(Offset = "0xC")]
	public bool is_rewarded;

	[Token(Token = "0x6007B32")]
	[Address(RVA = "0x317D498", Offset = "0x317D498", VA = "0x317D498")]
	public BoybandBTradingCardInfo()
	{
	}
}
