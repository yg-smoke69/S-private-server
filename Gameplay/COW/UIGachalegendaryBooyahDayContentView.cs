using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003576")]
public class UIGachalegendaryBooyahDayContentView : UIBaseView
{
	[Token(Token = "0x4015328")]
	[FieldOffset(Offset = "0x14")]
	public Animator UIGachalegendaryAnim;

	[Token(Token = "0x4015329")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture TitleTexture;

	[Token(Token = "0x401532A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject DefaultTitle;

	[Token(Token = "0x401532B")]
	[FieldOffset(Offset = "0x20")]
	public UICountDownLabel FreeCountdownLabel;

	[Token(Token = "0x401532C")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ItemDescLabel;

	[Token(Token = "0x401532D")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ItemDesc;

	[Token(Token = "0x401532E")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject LuckyRoyaleLabelContent;

	[Token(Token = "0x401532F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject SnakeSprite;

	[Token(Token = "0x4015330")]
	[FieldOffset(Offset = "0x34")]
	public GameObject VFXLegendThem;

	[Token(Token = "0x4015331")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnRule;

	[Token(Token = "0x4015332")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject LeftContains;

	[Token(Token = "0x4015333")]
	[FieldOffset(Offset = "0x40")]
	public Transform AdsPos;

	[Token(Token = "0x4015334")]
	[FieldOffset(Offset = "0x44")]
	public UIButton TempBagBtn;

	[Token(Token = "0x4015335")]
	[FieldOffset(Offset = "0x48")]
	public GameObject NewTips;

	[Token(Token = "0x4015336")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel BagNum;

	[Token(Token = "0x4015337")]
	[FieldOffset(Offset = "0x50")]
	public Animation BagNumAnim;

	[Token(Token = "0x4015338")]
	[FieldOffset(Offset = "0x54")]
	public UILabel BagDesc;

	[Token(Token = "0x4015339")]
	[FieldOffset(Offset = "0x58")]
	public UILabel BagNumTotal;

	[Token(Token = "0x401533A")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite BagIcon;

	[Token(Token = "0x401533B")]
	[FieldOffset(Offset = "0x60")]
	public UIButton InventoryBtn;

	[Token(Token = "0x401533C")]
	[FieldOffset(Offset = "0x64")]
	public UIButton PropertyBtn;

	[Token(Token = "0x401533D")]
	[FieldOffset(Offset = "0x68")]
	public UIGrid VehiclePropertyGrid;

	[Token(Token = "0x401533E")]
	[FieldOffset(Offset = "0x6C")]
	public UIGrid WeaponPropertyGrid;

	[Token(Token = "0x401533F")]
	[FieldOffset(Offset = "0x70")]
	public GameObject BagGuideVfx;

	[Token(Token = "0x4015340")]
	[FieldOffset(Offset = "0x74")]
	public GameObject TokenVfx;

	[Token(Token = "0x4015341")]
	[FieldOffset(Offset = "0x78")]
	public GameObject DrawAnim;

	[Token(Token = "0x4015342")]
	[FieldOffset(Offset = "0x7C")]
	public Transform BagGuideVfxStartPos;

	[Token(Token = "0x4015343")]
	[FieldOffset(Offset = "0x80")]
	public Transform TokenVfxStartPos;

	[Token(Token = "0x4015344")]
	[FieldOffset(Offset = "0x84")]
	public Transform AdsContainer;

	[Token(Token = "0x4015345")]
	[FieldOffset(Offset = "0x88")]
	public GameObject UIGachaLegendaryBuyBtn;

	[Token(Token = "0x4015346")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject TokenProgress;

	[Token(Token = "0x4015347")]
	[FieldOffset(Offset = "0x90")]
	public UIWidget TokenProgressWiget;

	[Token(Token = "0x4015348")]
	[FieldOffset(Offset = "0x94")]
	public UILabel TokenNum;

	[Token(Token = "0x4015349")]
	[FieldOffset(Offset = "0x98")]
	public UIButton progressBar;

	[Token(Token = "0x401534A")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject ItemPanel;

	[Token(Token = "0x401534B")]
	[FieldOffset(Offset = "0xA0")]
	public Transform Spot1;

	[Token(Token = "0x401534C")]
	[FieldOffset(Offset = "0xA4")]
	public Transform Spot2;

	[Token(Token = "0x401534D")]
	[FieldOffset(Offset = "0xA8")]
	public Transform Spot3;

	[Token(Token = "0x401534E")]
	[FieldOffset(Offset = "0xAC")]
	public Transform Spot4;

	[Token(Token = "0x401534F")]
	[FieldOffset(Offset = "0xB0")]
	public Transform Spot5;

	[Token(Token = "0x4015350")]
	[FieldOffset(Offset = "0xB4")]
	public UIProgressBar LuckyProgressBar;

	[Token(Token = "0x4015351")]
	[FieldOffset(Offset = "0xB8")]
	public UIProgressBar LuckyProgressBarForThumb;

	[Token(Token = "0x4015352")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject TokenVfxDestination;

	[Token(Token = "0x4015353")]
	[FieldOffset(Offset = "0xC0")]
	public UIWidget PreviewRightSideMiddle;

	[Token(Token = "0x4015354")]
	[FieldOffset(Offset = "0xC4")]
	public UIWidget PreviewLeftSideMiddle;

	[Token(Token = "0x6016412")]
	[Address(RVA = "0x2EA80A8", Offset = "0x2EA80A8", VA = "0x2EA80A8")]
	public UIGachalegendaryBooyahDayContentView()
	{
	}

	[Token(Token = "0x6016413")]
	[Address(RVA = "0x2EA80B0", Offset = "0x2EA80B0", VA = "0x2EA80B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016414")]
	[Address(RVA = "0x2EA90C8", Offset = "0x2EA90C8", VA = "0x2EA90C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
