using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200167B")]
public class GetStoreAllDescRes
{
	[Token(Token = "0x4009644")]
	[FieldOffset(Offset = "0x8")]
	public CSGetGiftStoreRes gift_store;

	[Token(Token = "0x4009645")]
	[FieldOffset(Offset = "0xC")]
	public CSGetStoreTabRes store_tab;

	[Token(Token = "0x4009646")]
	[FieldOffset(Offset = "0x10")]
	public CSGetIPTagConfigRes ip_tag_config;

	[Token(Token = "0x4009647")]
	[FieldOffset(Offset = "0x14")]
	public CSGetExchangeCurrencyAllDescRes exchange_currency;

	[Token(Token = "0x4009648")]
	[FieldOffset(Offset = "0x18")]
	public CSGetPayLevelConfigRes pay_level_config_res;

	[Token(Token = "0x4009649")]
	[FieldOffset(Offset = "0x1C")]
	public CSGetPBWSpecialStoreRes pbw_special_store_res;

	[Token(Token = "0x400964A")]
	[FieldOffset(Offset = "0x20")]
	public CSGetExchangeCurrencyLocalRes exchange_currency_local;

	[Token(Token = "0x6007CC5")]
	[Address(RVA = "0x30A2360", Offset = "0x30A2360", VA = "0x30A2360")]
	public GetStoreAllDescRes()
	{
	}
}
