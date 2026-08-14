using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200357B")]
public class UIGachalegendaryRampage4CContentView : UIBaseView
{
	[Token(Token = "0x40153B6")]
	[FieldOffset(Offset = "0x14")]
	public Animator UIGachalegendaryAnim;

	[Token(Token = "0x40153B7")]
	[FieldOffset(Offset = "0x18")]
	public GameObject LeftContains;

	[Token(Token = "0x40153B8")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ItemDesc;

	[Token(Token = "0x40153B9")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LuckyRoyaleLabelContent;

	[Token(Token = "0x40153BA")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SnakeSprite;

	[Token(Token = "0x40153BB")]
	[FieldOffset(Offset = "0x28")]
	public GameObject VFXLegendThem;

	[Token(Token = "0x40153BC")]
	[FieldOffset(Offset = "0x2C")]
	public UINetworkTexture TitleTexture;

	[Token(Token = "0x40153BD")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ItemDescLabel;

	[Token(Token = "0x40153BE")]
	[FieldOffset(Offset = "0x34")]
	public UIButton PrivewBtn01;

	[Token(Token = "0x40153BF")]
	[FieldOffset(Offset = "0x38")]
	public UIButton PrivewBtn02;

	[Token(Token = "0x40153C0")]
	[FieldOffset(Offset = "0x3C")]
	public Transform CDNAdsContainer;

	[Token(Token = "0x40153C1")]
	[FieldOffset(Offset = "0x40")]
	public UIButton TempBagBtn;

	[Token(Token = "0x40153C2")]
	[FieldOffset(Offset = "0x44")]
	public GameObject NewTips;

	[Token(Token = "0x40153C3")]
	[FieldOffset(Offset = "0x48")]
	public UILabel BagNum;

	[Token(Token = "0x40153C4")]
	[FieldOffset(Offset = "0x4C")]
	public Animation BagNumAnim;

	[Token(Token = "0x40153C5")]
	[FieldOffset(Offset = "0x50")]
	public UILabel BagDesc;

	[Token(Token = "0x40153C6")]
	[FieldOffset(Offset = "0x54")]
	public UILabel BagNumTotal;

	[Token(Token = "0x40153C7")]
	[FieldOffset(Offset = "0x58")]
	public UISprite BagIcon;

	[Token(Token = "0x40153C8")]
	[FieldOffset(Offset = "0x5C")]
	public UICountDownLabel FreeCountdownLabel;

	[Token(Token = "0x40153C9")]
	[FieldOffset(Offset = "0x60")]
	public GameObject RightContains;

	[Token(Token = "0x40153CA")]
	[FieldOffset(Offset = "0x64")]
	public GameObject TokenProgress;

	[Token(Token = "0x40153CB")]
	[FieldOffset(Offset = "0x68")]
	public UIWidget TokenProgressWiget;

	[Token(Token = "0x40153CC")]
	[FieldOffset(Offset = "0x6C")]
	public Transform TokenNumPos;

	[Token(Token = "0x40153CD")]
	[FieldOffset(Offset = "0x70")]
	public UILabel TokenNum;

	[Token(Token = "0x40153CE")]
	[FieldOffset(Offset = "0x74")]
	public UIButton progressBar;

	[Token(Token = "0x40153CF")]
	[FieldOffset(Offset = "0x78")]
	public GameObject ItemPanel;

	[Token(Token = "0x40153D0")]
	[FieldOffset(Offset = "0x7C")]
	public Transform Spot1Pos;

	[Token(Token = "0x40153D1")]
	[FieldOffset(Offset = "0x80")]
	public Transform Spot1;

	[Token(Token = "0x40153D2")]
	[FieldOffset(Offset = "0x84")]
	public Transform Spot2Pos;

	[Token(Token = "0x40153D3")]
	[FieldOffset(Offset = "0x88")]
	public Transform Spot2;

	[Token(Token = "0x40153D4")]
	[FieldOffset(Offset = "0x8C")]
	public Transform Spot3Pos;

	[Token(Token = "0x40153D5")]
	[FieldOffset(Offset = "0x90")]
	public Transform Spot3;

	[Token(Token = "0x40153D6")]
	[FieldOffset(Offset = "0x94")]
	public Transform Spot4Pos;

	[Token(Token = "0x40153D7")]
	[FieldOffset(Offset = "0x98")]
	public Transform Spot4;

	[Token(Token = "0x40153D8")]
	[FieldOffset(Offset = "0x9C")]
	public Transform Spot5Pos;

	[Token(Token = "0x40153D9")]
	[FieldOffset(Offset = "0xA0")]
	public Transform Spot5;

	[Token(Token = "0x40153DA")]
	[FieldOffset(Offset = "0xA4")]
	public UIPanel ScrollViewPanel;

	[Token(Token = "0x40153DB")]
	[FieldOffset(Offset = "0xA8")]
	public UIProgressBar LuckyProgressBar;

	[Token(Token = "0x40153DC")]
	[FieldOffset(Offset = "0xAC")]
	public UISprite LuckyProgressBarSprite;

	[Token(Token = "0x40153DD")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite LuckyProgressBarFront;

	[Token(Token = "0x40153DE")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject TokenVfxDestination;

	[Token(Token = "0x40153DF")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite Bg;

	[Token(Token = "0x40153E0")]
	[FieldOffset(Offset = "0xBC")]
	public UISprite Bg1;

	[Token(Token = "0x40153E1")]
	[FieldOffset(Offset = "0xC0")]
	public Transform VFX;

	[Token(Token = "0x40153E2")]
	[FieldOffset(Offset = "0xC4")]
	public UIButton InventoryBtn;

	[Token(Token = "0x40153E3")]
	[FieldOffset(Offset = "0xC8")]
	public UIButton PropertyBtn;

	[Token(Token = "0x40153E4")]
	[FieldOffset(Offset = "0xCC")]
	public UIGrid VehiclePropertyGrid;

	[Token(Token = "0x40153E5")]
	[FieldOffset(Offset = "0xD0")]
	public UIGrid WeaponPropertyGrid;

	[Token(Token = "0x40153E6")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject BagGuideVfx;

	[Token(Token = "0x40153E7")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject TokenVfx;

	[Token(Token = "0x40153E8")]
	[FieldOffset(Offset = "0xDC")]
	public GameObject DrawAnim;

	[Token(Token = "0x40153E9")]
	[FieldOffset(Offset = "0xE0")]
	public Transform BagGuideVfxStartPos;

	[Token(Token = "0x40153EA")]
	[FieldOffset(Offset = "0xE4")]
	public Transform TokenVfxStartPos;

	[Token(Token = "0x40153EB")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject UIGachaLegendaryBuyBtn;

	[Token(Token = "0x40153EC")]
	[FieldOffset(Offset = "0xEC")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x40153ED")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject UI3DCamera;

	[Token(Token = "0x40153EE")]
	[FieldOffset(Offset = "0xF4")]
	public UIPanel UI3DPanel;

	[Token(Token = "0x40153EF")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject VFX_Screen_small;

	[Token(Token = "0x40153F0")]
	[FieldOffset(Offset = "0xFC")]
	public GameObject VFX_Screen_big;

	[Token(Token = "0x6016421")]
	[Address(RVA = "0x245BB28", Offset = "0x245BB28", VA = "0x245BB28")]
	public UIGachalegendaryRampage4CContentView()
	{
	}

	[Token(Token = "0x6016422")]
	[Address(RVA = "0x245BB30", Offset = "0x245BB30", VA = "0x245BB30", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016423")]
	[Address(RVA = "0x245CF74", Offset = "0x245CF74", VA = "0x245CF74")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
