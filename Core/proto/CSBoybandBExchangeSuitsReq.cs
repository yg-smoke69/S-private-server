using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200195A")]
public class CSBoybandBExchangeSuitsReq
{
	[Token(Token = "0x4009F7C")]
	[FieldOffset(Offset = "0x8")]
	public uint suit_serial;

	[Token(Token = "0x4009F7D")]
	[FieldOffset(Offset = "0xC")]
	public uint reward_item_id;

	[Token(Token = "0x6007FB3")]
	[Address(RVA = "0x317E078", Offset = "0x317E078", VA = "0x317E078")]
	public CSBoybandBExchangeSuitsReq()
	{
	}
}
