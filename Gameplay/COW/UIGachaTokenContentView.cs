using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200359A")]
public class UIGachaTokenContentView : UIBaseView
{
	[Token(Token = "0x40155C3")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIGachaTokenContent;

	[Token(Token = "0x40155C4")]
	[FieldOffset(Offset = "0x18")]
	public GameObject itemDescLabel;

	[Token(Token = "0x40155C5")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject itemdesc;

	[Token(Token = "0x40155C6")]
	[FieldOffset(Offset = "0x20")]
	public GameObject itemname;

	[Token(Token = "0x40155C7")]
	[FieldOffset(Offset = "0x24")]
	public UISprite itemdescrightposspr;

	[Token(Token = "0x40155C8")]
	[FieldOffset(Offset = "0x28")]
	public UISprite itemnamerightposser;

	[Token(Token = "0x40155C9")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite NewQualityicon;

	[Token(Token = "0x40155CA")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ExtraAwardContainer;

	[Token(Token = "0x40155CB")]
	[FieldOffset(Offset = "0x34")]
	public UILabel ExtraAwardTitleCount;

	[Token(Token = "0x40155CC")]
	[FieldOffset(Offset = "0x38")]
	public UIGrid ExtraAwardGrid;

	[Token(Token = "0x40155CD")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Anim;

	[Token(Token = "0x40155CE")]
	[FieldOffset(Offset = "0x40")]
	public GameObject CDNContent;

	[Token(Token = "0x40155CF")]
	[FieldOffset(Offset = "0x44")]
	public Animation VFX_EFF_Luck;

	[Token(Token = "0x40155D0")]
	[FieldOffset(Offset = "0x48")]
	public UISprite star01;

	[Token(Token = "0x40155D1")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite star02;

	[Token(Token = "0x40155D2")]
	[FieldOffset(Offset = "0x50")]
	public UISprite star03;

	[Token(Token = "0x40155D3")]
	[FieldOffset(Offset = "0x54")]
	public UIButton LuckyBg;

	[Token(Token = "0x40155D4")]
	[FieldOffset(Offset = "0x58")]
	public UILabel EnergyPointLabel;

	[Token(Token = "0x40155D5")]
	[FieldOffset(Offset = "0x5C")]
	public Animation LuckyAnimation;

	[Token(Token = "0x40155D6")]
	[FieldOffset(Offset = "0x60")]
	public UICountDownIcon CountDownIcon;

	[Token(Token = "0x40155D7")]
	[FieldOffset(Offset = "0x64")]
	public UICountDownLabel GachaCountDownLabel;

	[Token(Token = "0x40155D8")]
	[FieldOffset(Offset = "0x68")]
	public UIButton BGClickLottery;

	[Token(Token = "0x40155D9")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject ADScrollView;

	[Token(Token = "0x40155DA")]
	[FieldOffset(Offset = "0x70")]
	public UIWrapContent ADContent;

	[Token(Token = "0x40155DB")]
	[FieldOffset(Offset = "0x74")]
	public UIWidget GachaPreviewPosition;

	[Token(Token = "0x40155DC")]
	[FieldOffset(Offset = "0x78")]
	public GameObject TokenCntContainer;

	[Token(Token = "0x40155DD")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject rewardPooltokenBG;

	[Token(Token = "0x40155DE")]
	[FieldOffset(Offset = "0x80")]
	public GameObject tokenBG;

	[Token(Token = "0x40155DF")]
	[FieldOffset(Offset = "0x84")]
	public UILabel TokenLabel;

	[Token(Token = "0x40155E0")]
	[FieldOffset(Offset = "0x88")]
	public UISprite TokenSprite;

	[Token(Token = "0x40155E1")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject CDNMask01;

	[Token(Token = "0x40155E2")]
	[FieldOffset(Offset = "0x90")]
	public GameObject CDNMask02;

	[Token(Token = "0x40155E3")]
	[FieldOffset(Offset = "0x94")]
	public GameObject BuyBtnGroup;

	[Token(Token = "0x40155E4")]
	[FieldOffset(Offset = "0x98")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x601647E")]
	[Address(RVA = "0x2E8E858", Offset = "0x2E8E858", VA = "0x2E8E858")]
	public UIGachaTokenContentView()
	{
	}

	[Token(Token = "0x601647F")]
	[Address(RVA = "0x2E8E860", Offset = "0x2E8E860", VA = "0x2E8E860", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016480")]
	[Address(RVA = "0x2E8F5CC", Offset = "0x2E8F5CC", VA = "0x2E8F5CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
