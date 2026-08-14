using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003511")]
public class UIElitePassUpgradeView : UIBaseView
{
	[Token(Token = "0x4014EEF")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture CDNTexture_Left;

	[Token(Token = "0x4014EF0")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture CDNTexture_Right;

	[Token(Token = "0x4014EF1")]
	[FieldOffset(Offset = "0x1C")]
	public BaseItemView UpgradeSprite;

	[Token(Token = "0x4014EF2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Desc5;

	[Token(Token = "0x4014EF3")]
	[FieldOffset(Offset = "0x24")]
	public UILabel BadgeCount;

	[Token(Token = "0x4014EF4")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Badge;

	[Token(Token = "0x4014EF5")]
	[FieldOffset(Offset = "0x2C")]
	public UIScrollView RewardDisplay;

	[Token(Token = "0x4014EF6")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid RewardGrid;

	[Token(Token = "0x4014EF7")]
	[FieldOffset(Offset = "0x34")]
	public UILabel RewardNum;

	[Token(Token = "0x4014EF8")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Subtitle;

	[Token(Token = "0x4014EF9")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton UpgradeBtn;

	[Token(Token = "0x4014EFA")]
	[FieldOffset(Offset = "0x40")]
	public UILabel NormalPrice;

	[Token(Token = "0x4014EFB")]
	[FieldOffset(Offset = "0x44")]
	public UILabel DiscountLabel;

	[Token(Token = "0x4014EFC")]
	[FieldOffset(Offset = "0x48")]
	public UIButton BundleUpgradeBtn;

	[Token(Token = "0x4014EFD")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel BundleOriginalPrice;

	[Token(Token = "0x4014EFE")]
	[FieldOffset(Offset = "0x50")]
	public UILabel BundlePrice;

	[Token(Token = "0x4014EFF")]
	[FieldOffset(Offset = "0x54")]
	public GameObject NormalCustomizedDiscount;

	[Token(Token = "0x4014F00")]
	[FieldOffset(Offset = "0x58")]
	public UILabel NormalCustomizedDiscountLabel;

	[Token(Token = "0x4014F01")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel EPOriginalPrice;

	[Token(Token = "0x4014F02")]
	[FieldOffset(Offset = "0x60")]
	public GameObject UpgradeWithDiscount;

	[Token(Token = "0x4014F03")]
	[FieldOffset(Offset = "0x64")]
	public GameObject UpgradeWithoutDiscount;

	[Token(Token = "0x4014F04")]
	[FieldOffset(Offset = "0x68")]
	public UILabel UpgradeDiscountPrice;

	[Token(Token = "0x4014F05")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject BundleUpgradeWithDiscount;

	[Token(Token = "0x4014F06")]
	[FieldOffset(Offset = "0x70")]
	public UILabel BundleDscountPrice;

	[Token(Token = "0x4014F07")]
	[FieldOffset(Offset = "0x74")]
	public GameObject BundleUpgradeWithoutDiscount;

	[Token(Token = "0x60162E3")]
	[Address(RVA = "0x19CFFA8", Offset = "0x19CFFA8", VA = "0x19CFFA8")]
	public UIElitePassUpgradeView()
	{
	}

	[Token(Token = "0x60162E4")]
	[Address(RVA = "0x19CFFB0", Offset = "0x19CFFB0", VA = "0x19CFFB0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162E5")]
	[Address(RVA = "0x19D0A10", Offset = "0x19D0A10", VA = "0x19D0A10")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
