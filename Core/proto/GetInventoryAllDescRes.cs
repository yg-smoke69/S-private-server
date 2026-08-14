using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015C2")]
public class GetInventoryAllDescRes
{
	[Token(Token = "0x4009433")]
	[FieldOffset(Offset = "0x8")]
	public CSGetBundleRes bundle;

	[Token(Token = "0x4009434")]
	[FieldOffset(Offset = "0xC")]
	public GetRankingItemRankConfigRes ranking_item_rank_config;

	[Token(Token = "0x4009435")]
	[FieldOffset(Offset = "0x10")]
	public CSGetFullscreenItemRes full_screen_item;

	[Token(Token = "0x4009436")]
	[FieldOffset(Offset = "0x14")]
	public CSGetRoleDebrisDescRes role_debris;

	[Token(Token = "0x4009437")]
	[FieldOffset(Offset = "0x18")]
	public long weapon_skin_system_time;

	[Token(Token = "0x4009438")]
	[FieldOffset(Offset = "0x20")]
	public CSGetOptionalBundleRes optional_bundle;

	[Token(Token = "0x4009439")]
	[FieldOffset(Offset = "0x24")]
	public CSSkinTimelineDescRes skin_timeline;

	[Token(Token = "0x400943A")]
	[FieldOffset(Offset = "0x28")]
	public CSGetPreviewWebDescRes preview_web;

	[Token(Token = "0x400943B")]
	[FieldOffset(Offset = "0x2C")]
	public RandomSkinSwitchDesc random_skin_switch;

	[Token(Token = "0x6007C0C")]
	[Address(RVA = "0x30A1FE0", Offset = "0x30A1FE0", VA = "0x30A1FE0")]
	public GetInventoryAllDescRes()
	{
	}
}
