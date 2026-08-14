using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001739")]
public class CSIAPPurchaseReq
{
	[Token(Token = "0x400999A")]
	[FieldOffset(Offset = "0x8")]
	public string login_token;

	[Token(Token = "0x400999B")]
	[FieldOffset(Offset = "0xC")]
	public uint plat_id;

	[Token(Token = "0x400999C")]
	[FieldOffset(Offset = "0x10")]
	public string external_id;

	[Token(Token = "0x400999D")]
	[FieldOffset(Offset = "0x14")]
	public uint rebate_card_id;

	[Token(Token = "0x400999E")]
	[FieldOffset(Offset = "0x18")]
	public bool from_gop;

	[Token(Token = "0x400999F")]
	[FieldOffset(Offset = "0x1C")]
	public uint iap_type;

	[Token(Token = "0x40099A0")]
	[FieldOffset(Offset = "0x20")]
	public uint iap_consume_type;

	[Token(Token = "0x40099A1")]
	[FieldOffset(Offset = "0x24")]
	public uint store_id;

	[Token(Token = "0x6007D93")]
	[Address(RVA = "0x3097244", Offset = "0x3097244", VA = "0x3097244")]
	public CSIAPPurchaseReq()
	{
	}
}
