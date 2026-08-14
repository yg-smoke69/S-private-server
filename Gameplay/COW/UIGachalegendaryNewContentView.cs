using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003579")]
public class UIGachalegendaryNewContentView : UIBaseView
{
	[Token(Token = "0x4015378")]
	[FieldOffset(Offset = "0x14")]
	public Animator UIGachalegendaryAnim;

	[Token(Token = "0x4015379")]
	[FieldOffset(Offset = "0x18")]
	public GameObject LeftContains;

	[Token(Token = "0x401537A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ItemDesc;

	[Token(Token = "0x401537B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LuckyRoyaleLabelContent;

	[Token(Token = "0x401537C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SnakeSprite;

	[Token(Token = "0x401537D")]
	[FieldOffset(Offset = "0x28")]
	public GameObject VFXLegendThem;

	[Token(Token = "0x401537E")]
	[FieldOffset(Offset = "0x2C")]
	public UINetworkTexture TitleTexture;

	[Token(Token = "0x401537F")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ItemDescLabel;

	[Token(Token = "0x4015380")]
	[FieldOffset(Offset = "0x34")]
	public UIButton PrivewBtn01;

	[Token(Token = "0x4015381")]
	[FieldOffset(Offset = "0x38")]
	public UIButton PrivewBtn02;

	[Token(Token = "0x4015382")]
	[FieldOffset(Offset = "0x3C")]
	public Transform CDNAdsContainer;

	[Token(Token = "0x4015383")]
	[FieldOffset(Offset = "0x40")]
	public UIButton TempBagBtn;

	[Token(Token = "0x4015384")]
	[FieldOffset(Offset = "0x44")]
	public GameObject NewTips;

	[Token(Token = "0x4015385")]
	[FieldOffset(Offset = "0x48")]
	public UILabel BagNum;

	[Token(Token = "0x4015386")]
	[FieldOffset(Offset = "0x4C")]
	public Animation BagNumAnim;

	[Token(Token = "0x4015387")]
	[FieldOffset(Offset = "0x50")]
	public UILabel BagDesc;

	[Token(Token = "0x4015388")]
	[FieldOffset(Offset = "0x54")]
	public UILabel BagNumTotal;

	[Token(Token = "0x4015389")]
	[FieldOffset(Offset = "0x58")]
	public UISprite BagIcon;

	[Token(Token = "0x401538A")]
	[FieldOffset(Offset = "0x5C")]
	public UICountDownLabel FreeCountdownLabel;

	[Token(Token = "0x401538B")]
	[FieldOffset(Offset = "0x60")]
	public GameObject RightContains;

	[Token(Token = "0x401538C")]
	[FieldOffset(Offset = "0x64")]
	public GameObject TokenProgress;

	[Token(Token = "0x401538D")]
	[FieldOffset(Offset = "0x68")]
	public UIWidget TokenProgressWiget;

	[Token(Token = "0x401538E")]
	[FieldOffset(Offset = "0x6C")]
	public Transform TokenNumPos;

	[Token(Token = "0x401538F")]
	[FieldOffset(Offset = "0x70")]
	public UILabel TokenNum;

	[Token(Token = "0x4015390")]
	[FieldOffset(Offset = "0x74")]
	public UIButton progressBar;

	[Token(Token = "0x4015391")]
	[FieldOffset(Offset = "0x78")]
	public GameObject ItemPanel;

	[Token(Token = "0x4015392")]
	[FieldOffset(Offset = "0x7C")]
	public Transform Spot1Pos;

	[Token(Token = "0x4015393")]
	[FieldOffset(Offset = "0x80")]
	public Transform Spot1;

	[Token(Token = "0x4015394")]
	[FieldOffset(Offset = "0x84")]
	public Transform Spot2Pos;

	[Token(Token = "0x4015395")]
	[FieldOffset(Offset = "0x88")]
	public Transform Spot2;

	[Token(Token = "0x4015396")]
	[FieldOffset(Offset = "0x8C")]
	public Transform Spot3Pos;

	[Token(Token = "0x4015397")]
	[FieldOffset(Offset = "0x90")]
	public Transform Spot3;

	[Token(Token = "0x4015398")]
	[FieldOffset(Offset = "0x94")]
	public Transform Spot4Pos;

	[Token(Token = "0x4015399")]
	[FieldOffset(Offset = "0x98")]
	public Transform Spot4;

	[Token(Token = "0x401539A")]
	[FieldOffset(Offset = "0x9C")]
	public Transform Spot5Pos;

	[Token(Token = "0x401539B")]
	[FieldOffset(Offset = "0xA0")]
	public Transform Spot5;

	[Token(Token = "0x401539C")]
	[FieldOffset(Offset = "0xA4")]
	public UIPanel ScrollViewPanel;

	[Token(Token = "0x401539D")]
	[FieldOffset(Offset = "0xA8")]
	public UIProgressBar LuckyProgressBar;

	[Token(Token = "0x401539E")]
	[FieldOffset(Offset = "0xAC")]
	public UISprite LuckyProgressBarSprite;

	[Token(Token = "0x401539F")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite LuckyProgressBarFront;

	[Token(Token = "0x40153A0")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject TokenVfxDestination;

	[Token(Token = "0x40153A1")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite Bg;

	[Token(Token = "0x40153A2")]
	[FieldOffset(Offset = "0xBC")]
	public UISprite Bg1;

	[Token(Token = "0x40153A3")]
	[FieldOffset(Offset = "0xC0")]
	public Transform Spot1Sprite;

	[Token(Token = "0x40153A4")]
	[FieldOffset(Offset = "0xC4")]
	public Transform Spot2Sprite;

	[Token(Token = "0x40153A5")]
	[FieldOffset(Offset = "0xC8")]
	public Transform Spot3Sprite;

	[Token(Token = "0x40153A6")]
	[FieldOffset(Offset = "0xCC")]
	public Transform Spot4Sprite;

	[Token(Token = "0x40153A7")]
	[FieldOffset(Offset = "0xD0")]
	public Transform Spot5Sprite;

	[Token(Token = "0x40153A8")]
	[FieldOffset(Offset = "0xD4")]
	public Transform VFX;

	[Token(Token = "0x40153A9")]
	[FieldOffset(Offset = "0xD8")]
	public UIButton InventoryBtn;

	[Token(Token = "0x40153AA")]
	[FieldOffset(Offset = "0xDC")]
	public UIButton PropertyBtn;

	[Token(Token = "0x40153AB")]
	[FieldOffset(Offset = "0xE0")]
	public UIGrid VehiclePropertyGrid;

	[Token(Token = "0x40153AC")]
	[FieldOffset(Offset = "0xE4")]
	public UIGrid WeaponPropertyGrid;

	[Token(Token = "0x40153AD")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject BagGuideVfx;

	[Token(Token = "0x40153AE")]
	[FieldOffset(Offset = "0xEC")]
	public GameObject TokenVfx;

	[Token(Token = "0x40153AF")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject DrawAnim;

	[Token(Token = "0x40153B0")]
	[FieldOffset(Offset = "0xF4")]
	public Transform BagGuideVfxStartPos;

	[Token(Token = "0x40153B1")]
	[FieldOffset(Offset = "0xF8")]
	public Transform TokenVfxStartPos;

	[Token(Token = "0x40153B2")]
	[FieldOffset(Offset = "0xFC")]
	public GameObject UIGachaLegendaryBuyBtn;

	[Token(Token = "0x40153B3")]
	[FieldOffset(Offset = "0x100")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x601641B")]
	[Address(RVA = "0x244BE80", Offset = "0x244BE80", VA = "0x244BE80")]
	public UIGachalegendaryNewContentView()
	{
	}

	[Token(Token = "0x601641C")]
	[Address(RVA = "0x244BE88", Offset = "0x244BE88", VA = "0x244BE88", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601641D")]
	[Address(RVA = "0x244D288", Offset = "0x244D288", VA = "0x244D288")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
