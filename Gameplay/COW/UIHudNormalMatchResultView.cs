using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036C2")]
public class UIHudNormalMatchResultView : UIBaseView
{
	[Token(Token = "0x4016147")]
	[FieldOffset(Offset = "0x14")]
	public Animator HudNormalMatchResAni;

	[Token(Token = "0x4016148")]
	[FieldOffset(Offset = "0x18")]
	public UILabel RankNum;

	[Token(Token = "0x4016149")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TotalNum;

	[Token(Token = "0x401614A")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ResultDesc;

	[Token(Token = "0x401614B")]
	[FieldOffset(Offset = "0x24")]
	public Transform BaseReward;

	[Token(Token = "0x401614C")]
	[FieldOffset(Offset = "0x28")]
	public UILabel GameModeTxt;

	[Token(Token = "0x401614D")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel GameMapTxt;

	[Token(Token = "0x401614E")]
	[FieldOffset(Offset = "0x30")]
	public GameObject WorkShopGo;

	[Token(Token = "0x401614F")]
	[FieldOffset(Offset = "0x34")]
	public GameObject BiaoQianOB;

	[Token(Token = "0x4016150")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget Biaoqian1;

	[Token(Token = "0x4016151")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget Biaoqian2;

	[Token(Token = "0x4016152")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget Biaoqian3;

	[Token(Token = "0x4016153")]
	[FieldOffset(Offset = "0x44")]
	public UIWidget Biaoqian4;

	[Token(Token = "0x4016154")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget PlaceHolderBiaoqian;

	[Token(Token = "0x4016155")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel TitleInfo1Txt;

	[Token(Token = "0x4016156")]
	[FieldOffset(Offset = "0x50")]
	public UILabel TitleInfo2Txt;

	[Token(Token = "0x4016157")]
	[FieldOffset(Offset = "0x54")]
	public UILabel TitleInfo3Txt;

	[Token(Token = "0x4016158")]
	[FieldOffset(Offset = "0x58")]
	public UILabel TitleInfo4Txt;

	[Token(Token = "0x4016159")]
	[FieldOffset(Offset = "0x5C")]
	public Transform PlayerItemInfo1;

	[Token(Token = "0x401615A")]
	[FieldOffset(Offset = "0x60")]
	public Transform PlayerItemInfo2;

	[Token(Token = "0x401615B")]
	[FieldOffset(Offset = "0x64")]
	public Transform PlayerItemInfo3;

	[Token(Token = "0x401615C")]
	[FieldOffset(Offset = "0x68")]
	public Transform PlayerItemInfo4;

	[Token(Token = "0x401615D")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton ShareBtn;

	[Token(Token = "0x401615E")]
	[FieldOffset(Offset = "0x70")]
	public UIButton NextBtn;

	[Token(Token = "0x401615F")]
	[FieldOffset(Offset = "0x74")]
	public UILabel NextBtnTime;

	[Token(Token = "0x4016160")]
	[FieldOffset(Offset = "0x78")]
	public UILabel NextBtnLable;

	[Token(Token = "0x4016161")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton DetailsBtn;

	[Token(Token = "0x4016162")]
	[FieldOffset(Offset = "0x80")]
	public GameObject DetailBtnShowIcon;

	[Token(Token = "0x4016163")]
	[FieldOffset(Offset = "0x84")]
	public GameObject DetailBtnHideIcon;

	[Token(Token = "0x4016164")]
	[FieldOffset(Offset = "0x88")]
	public UIButton ReplayBtn;

	[Token(Token = "0x4016165")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel ReplayTips;

	[Token(Token = "0x4016166")]
	[FieldOffset(Offset = "0x90")]
	public UIGrid RewardBtnGrid;

	[Token(Token = "0x4016167")]
	[FieldOffset(Offset = "0x94")]
	public UIButton VideoGiftBtn;

	[Token(Token = "0x4016168")]
	[FieldOffset(Offset = "0x98")]
	public UIButton FastSendGiftBtn;

	[Token(Token = "0x4016169")]
	[FieldOffset(Offset = "0x9C")]
	public Transform CallSignContainer;

	[Token(Token = "0x401616A")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject ShareInfoContainer;

	[Token(Token = "0x401616B")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel ShareGameModeTxt;

	[Token(Token = "0x401616C")]
	[FieldOffset(Offset = "0xA8")]
	public UIWidget Biaoqian1Share;

	[Token(Token = "0x401616D")]
	[FieldOffset(Offset = "0xAC")]
	public UIWidget Biaoqian2Share;

	[Token(Token = "0x401616E")]
	[FieldOffset(Offset = "0xB0")]
	public UIWidget Biaoqian3Share;

	[Token(Token = "0x401616F")]
	[FieldOffset(Offset = "0xB4")]
	public UIWidget Biaoqian4Share;

	[Token(Token = "0x4016170")]
	[FieldOffset(Offset = "0xB8")]
	public UIButton DataBtn;

	[Token(Token = "0x4016171")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject NormalTitleRoot;

	[Token(Token = "0x4016172")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel TitleDataTxt;

	[Token(Token = "0x4016173")]
	[FieldOffset(Offset = "0xC4")]
	public UILabel TitleInfo5Txt;

	[Token(Token = "0x4016174")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject TitlePlayerTxt;

	[Token(Token = "0x4016175")]
	[FieldOffset(Offset = "0xCC")]
	public UISprite DataBtnIcon;

	[Token(Token = "0x4016176")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel DataBtnLabel;

	[Token(Token = "0x4016177")]
	[FieldOffset(Offset = "0xD4")]
	public UITable BottomLeftTable;

	[Token(Token = "0x4016178")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel TxtModeLeftCorner;

	[Token(Token = "0x4016179")]
	[FieldOffset(Offset = "0xDC")]
	public UILabel TxtMapLeftCorner;

	[Token(Token = "0x60167F3")]
	[Address(RVA = "0x1F58498", Offset = "0x1F58498", VA = "0x1F58498")]
	public UIHudNormalMatchResultView()
	{
	}

	[Token(Token = "0x60167F4")]
	[Address(RVA = "0x1F584A0", Offset = "0x1F584A0", VA = "0x1F584A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167F5")]
	[Address(RVA = "0x1F597C4", Offset = "0x1F597C4", VA = "0x1F597C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
