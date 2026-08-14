using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CFB")]
public class EInventory
{
	[Token(Token = "0x2001CFC")]
	public enum Proto
	{
		[Token(Token = "0x400B752")]
		Proto_NONE,
		[Token(Token = "0x400B753")]
		Proto_TOPUP_NTF,
		[Token(Token = "0x400B754")]
		Proto_MONEY_UPDATE_NTF,
		[Token(Token = "0x400B755")]
		Proto_NEW_ITEMS_NTF,
		[Token(Token = "0x400B756")]
		proto_REBATECARD_NTF,
		[Token(Token = "0x400B757")]
		proto_REBATECARD_REDEEM_NTF,
		[Token(Token = "0x400B758")]
		proto_ITEM_CHANGE,
		[Token(Token = "0x400B759")]
		proto_SELECTED_ITEMS_CHANGE,
		[Token(Token = "0x400B75A")]
		proto_EP_CARD_NTF,
		[Token(Token = "0x400B75B")]
		Proto_INSTALLMENT_ITEMS_NEW_NTF,
		[Token(Token = "0x400B75C")]
		Proto_INSTALLMENT_ITEMS_CHANGE_NTF,
		[Token(Token = "0x400B75D")]
		Proto_INSTALLMENT_ITEMS_DELETE_NTF,
		[Token(Token = "0x400B75E")]
		Proto_INSTALLMENT_PAY_NTF,
		[Token(Token = "0x400B75F")]
		Proto_LIMITED_AVATAR_OUT_EXPIRE_NTF
	}

	[Token(Token = "0x2001CFD")]
	public enum ErrCode
	{
		[Token(Token = "0x400B761")]
		ErrCode_SUSS
	}

	[Token(Token = "0x60086B5")]
	[Address(RVA = "0x33E904C", Offset = "0x33E904C", VA = "0x33E904C")]
	public EInventory()
	{
	}
}
