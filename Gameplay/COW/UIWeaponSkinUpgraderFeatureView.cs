using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A75")]
public class UIWeaponSkinUpgraderFeatureView : UIBaseView
{
	[Token(Token = "0x4018D04")]
	[FieldOffset(Offset = "0x14")]
	public Animator ShowFeatureAnim;

	[Token(Token = "0x4018D05")]
	[FieldOffset(Offset = "0x18")]
	public GameObject UIContent;

	[Token(Token = "0x4018D06")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BGSprite;

	[Token(Token = "0x4018D07")]
	[FieldOffset(Offset = "0x20")]
	public UITexture GachaFeature_Bg;

	[Token(Token = "0x4018D08")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ObjAnnouncementArea;

	[Token(Token = "0x4018D09")]
	[FieldOffset(Offset = "0x28")]
	public GameObject InterfaceMask;

	[Token(Token = "0x4018D0A")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ItemShow;

	[Token(Token = "0x4018D0B")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ItemInfoContainer;

	[Token(Token = "0x4018D0C")]
	[FieldOffset(Offset = "0x34")]
	public BaseItemView BaseInfoView;

	[Token(Token = "0x4018D0D")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Bottom_btn;

	[Token(Token = "0x4018D0E")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton ShareBtn;

	[Token(Token = "0x4018D0F")]
	[FieldOffset(Offset = "0x40")]
	public Animator ShareIconAnimator;

	[Token(Token = "0x4018D10")]
	[FieldOffset(Offset = "0x44")]
	public UIButton OkBtn;

	[Token(Token = "0x4018D11")]
	[FieldOffset(Offset = "0x48")]
	public GameObject propertyContainer;

	[Token(Token = "0x4018D12")]
	[FieldOffset(Offset = "0x4C")]
	public UIGrid scoreGrid;

	[Token(Token = "0x4018D13")]
	[FieldOffset(Offset = "0x50")]
	public UILabel ItemNameLabel;

	[Token(Token = "0x4018D14")]
	[FieldOffset(Offset = "0x54")]
	public UISprite IPTag;

	[Token(Token = "0x4018D15")]
	[FieldOffset(Offset = "0x58")]
	public GameObject propertyVioContainer;

	[Token(Token = "0x4018D16")]
	[FieldOffset(Offset = "0x5C")]
	public UIGrid scoreVioGrid;

	[Token(Token = "0x4018D17")]
	[FieldOffset(Offset = "0x60")]
	public UILabel ItemNameVioLabel;

	[Token(Token = "0x4018D18")]
	[FieldOffset(Offset = "0x64")]
	public UISprite IPTagVio;

	[Token(Token = "0x4018D19")]
	[FieldOffset(Offset = "0x68")]
	public GameObject propertyRedContainer;

	[Token(Token = "0x4018D1A")]
	[FieldOffset(Offset = "0x6C")]
	public UIGrid scoreRedGrid;

	[Token(Token = "0x4018D1B")]
	[FieldOffset(Offset = "0x70")]
	public UILabel ItemNameRedLabel;

	[Token(Token = "0x4018D1C")]
	[FieldOffset(Offset = "0x74")]
	public UISprite IPTagRed;

	[Token(Token = "0x6017305")]
	[Address(RVA = "0x2EFD80C", Offset = "0x2EFD80C", VA = "0x2EFD80C")]
	public UIWeaponSkinUpgraderFeatureView()
	{
	}

	[Token(Token = "0x6017306")]
	[Address(RVA = "0x2EFD814", Offset = "0x2EFD814", VA = "0x2EFD814", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017307")]
	[Address(RVA = "0x2EFE250", Offset = "0x2EFE250", VA = "0x2EFE250")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
