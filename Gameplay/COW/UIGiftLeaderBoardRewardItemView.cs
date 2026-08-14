using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035B0")]
public class UIGiftLeaderBoardRewardItemView : UIBaseView
{
	[Token(Token = "0x401572F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x4015730")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ItemWidget;

	[Token(Token = "0x4015731")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite QualityBG;

	[Token(Token = "0x4015732")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HighLightBG;

	[Token(Token = "0x4015733")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Get;

	[Token(Token = "0x4015734")]
	[FieldOffset(Offset = "0x28")]
	public BaseItemView BaseItemView;

	[Token(Token = "0x4015735")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ItemIcon;

	[Token(Token = "0x4015736")]
	[FieldOffset(Offset = "0x30")]
	public UISprite HeadIcon;

	[Token(Token = "0x4015737")]
	[FieldOffset(Offset = "0x34")]
	public UISprite BannerIcon;

	[Token(Token = "0x4015738")]
	[FieldOffset(Offset = "0x38")]
	public UISprite DebrisIcon;

	[Token(Token = "0x4015739")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite VehicleSkinIcon;

	[Token(Token = "0x401573A")]
	[FieldOffset(Offset = "0x40")]
	public UISprite WeaponSkinIcon;

	[Token(Token = "0x401573B")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Light;

	[Token(Token = "0x401573C")]
	[FieldOffset(Offset = "0x48")]
	public UILabel Count;

	[Token(Token = "0x401573D")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject CountBG;

	[Token(Token = "0x401573E")]
	[FieldOffset(Offset = "0x50")]
	public UISlider GiftProcess;

	[Token(Token = "0x401573F")]
	[FieldOffset(Offset = "0x54")]
	public UISprite Background;

	[Token(Token = "0x4015740")]
	[FieldOffset(Offset = "0x58")]
	public UISprite Foreground;

	[Token(Token = "0x4015741")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject LightSprite;

	[Token(Token = "0x60164BE")]
	[Address(RVA = "0x1CEC058", Offset = "0x1CEC058", VA = "0x1CEC058")]
	public UIGiftLeaderBoardRewardItemView()
	{
	}

	[Token(Token = "0x60164BF")]
	[Address(RVA = "0x1CEC060", Offset = "0x1CEC060", VA = "0x1CEC060", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164C0")]
	[Address(RVA = "0x1CEC88C", Offset = "0x1CEC88C", VA = "0x1CEC88C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
