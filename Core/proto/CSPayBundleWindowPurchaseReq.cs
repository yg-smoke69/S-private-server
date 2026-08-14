using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001742")]
public class CSPayBundleWindowPurchaseReq
{
	[Token(Token = "0x40099B8")]
	[FieldOffset(Offset = "0x8")]
	public string login_token;

	[Token(Token = "0x40099B9")]
	[FieldOffset(Offset = "0xC")]
	public uint rebate_card_id;

	[Token(Token = "0x40099BA")]
	[FieldOffset(Offset = "0x10")]
	public uint id;

	[Token(Token = "0x40099BB")]
	[FieldOffset(Offset = "0x14")]
	public EStore.PbwConsumeType consume_type;

	[Token(Token = "0x40099BC")]
	[FieldOffset(Offset = "0x18")]
	public uint rebate_card_end_timestamp;

	[Token(Token = "0x6007D9C")]
	[Address(RVA = "0x3098334", Offset = "0x3098334", VA = "0x3098334")]
	public CSPayBundleWindowPurchaseReq()
	{
	}
}
