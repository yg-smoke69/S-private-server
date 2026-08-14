using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200374E")]
public class UIHudSingleFightMatchResultView : UIBaseView
{
	[Token(Token = "0x40165EE")]
	[FieldOffset(Offset = "0x14")]
	public Animator HudSingleFightAni;

	[Token(Token = "0x40165EF")]
	[FieldOffset(Offset = "0x18")]
	public GameObject RankInfo;

	[Token(Token = "0x40165F0")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel RankNum;

	[Token(Token = "0x40165F1")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TotalNum;

	[Token(Token = "0x40165F2")]
	[FieldOffset(Offset = "0x24")]
	public GameObject WinnerInfo;

	[Token(Token = "0x40165F3")]
	[FieldOffset(Offset = "0x28")]
	public UILabel WinnerTxt;

	[Token(Token = "0x40165F4")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel GameMapTxt;

	[Token(Token = "0x40165F5")]
	[FieldOffset(Offset = "0x30")]
	public UILabel GameModeTxt;

	[Token(Token = "0x40165F6")]
	[FieldOffset(Offset = "0x34")]
	public GameObject WorkShopGo;

	[Token(Token = "0x40165F7")]
	[FieldOffset(Offset = "0x38")]
	public Transform BaseReward;

	[Token(Token = "0x40165F8")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel ResultDesc;

	[Token(Token = "0x40165F9")]
	[FieldOffset(Offset = "0x40")]
	public GameObject BiaoQianOB;

	[Token(Token = "0x40165FA")]
	[FieldOffset(Offset = "0x44")]
	public UIWidget Biaoqian1;

	[Token(Token = "0x40165FB")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget Biaoqian2;

	[Token(Token = "0x40165FC")]
	[FieldOffset(Offset = "0x4C")]
	public UIWidget Biaoqian3;

	[Token(Token = "0x40165FD")]
	[FieldOffset(Offset = "0x50")]
	public UIWidget Biaoqian4;

	[Token(Token = "0x40165FE")]
	[FieldOffset(Offset = "0x54")]
	public UIWidget PlaceHolderBiaoqian;

	[Token(Token = "0x40165FF")]
	[FieldOffset(Offset = "0x58")]
	public UILabel TitleInfo1Txt;

	[Token(Token = "0x4016600")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel TitleInfo2Txt;

	[Token(Token = "0x4016601")]
	[FieldOffset(Offset = "0x60")]
	public UILabel TitleInfo3Txt;

	[Token(Token = "0x4016602")]
	[FieldOffset(Offset = "0x64")]
	public UILabel TitleInfo4Txt;

	[Token(Token = "0x4016603")]
	[FieldOffset(Offset = "0x68")]
	public UIEasyList PlayerList;

	[Token(Token = "0x4016604")]
	[FieldOffset(Offset = "0x6C")]
	public Transform LocalPlayerInfo;

	[Token(Token = "0x4016605")]
	[FieldOffset(Offset = "0x70")]
	public UIButton DetailsBtn;

	[Token(Token = "0x4016606")]
	[FieldOffset(Offset = "0x74")]
	public GameObject DetailBtnShowIcon;

	[Token(Token = "0x4016607")]
	[FieldOffset(Offset = "0x78")]
	public GameObject DetailBtnHideIcon;

	[Token(Token = "0x4016608")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton ShareBtn;

	[Token(Token = "0x4016609")]
	[FieldOffset(Offset = "0x80")]
	public UIButton NextBtn;

	[Token(Token = "0x401660A")]
	[FieldOffset(Offset = "0x84")]
	public UILabel NextBtnTime;

	[Token(Token = "0x401660B")]
	[FieldOffset(Offset = "0x88")]
	public UILabel NextBtnLable;

	[Token(Token = "0x401660C")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton ReplayBtn;

	[Token(Token = "0x401660D")]
	[FieldOffset(Offset = "0x90")]
	public UILabel ReplayTips;

	[Token(Token = "0x401660E")]
	[FieldOffset(Offset = "0x94")]
	public UIGrid RewardBtnGrid;

	[Token(Token = "0x401660F")]
	[FieldOffset(Offset = "0x98")]
	public UIButton VideoGiftBtn;

	[Token(Token = "0x4016610")]
	[FieldOffset(Offset = "0x9C")]
	public UIButton FastSendGiftBtn;

	[Token(Token = "0x4016611")]
	[FieldOffset(Offset = "0xA0")]
	public Transform CallSignContainer;

	[Token(Token = "0x4016612")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject ShareInfoContainer;

	[Token(Token = "0x4016613")]
	[FieldOffset(Offset = "0xA8")]
	public UIWidget Biaoqian1Share;

	[Token(Token = "0x4016614")]
	[FieldOffset(Offset = "0xAC")]
	public UIWidget Biaoqian2Share;

	[Token(Token = "0x4016615")]
	[FieldOffset(Offset = "0xB0")]
	public UIWidget Biaoqian3Share;

	[Token(Token = "0x4016616")]
	[FieldOffset(Offset = "0xB4")]
	public UIWidget Biaoqian4Share;

	[Token(Token = "0x4016617")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel ShareGameModeTxt;

	[Token(Token = "0x4016618")]
	[FieldOffset(Offset = "0xBC")]
	public UITable BottomLeftTable;

	[Token(Token = "0x4016619")]
	[FieldOffset(Offset = "0xC0")]
	public UIScrollView PlayerScrollView;

	[Token(Token = "0x6016995")]
	[Address(RVA = "0x16C07D0", Offset = "0x16C07D0", VA = "0x16C07D0")]
	public UIHudSingleFightMatchResultView()
	{
	}

	[Token(Token = "0x6016996")]
	[Address(RVA = "0x16C07D8", Offset = "0x16C07D8", VA = "0x16C07D8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016997")]
	[Address(RVA = "0x16C18D4", Offset = "0x16C18D4", VA = "0x16C18D4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
