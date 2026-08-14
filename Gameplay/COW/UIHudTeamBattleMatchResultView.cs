using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003769")]
public class UIHudTeamBattleMatchResultView : UIBaseView
{
	[Token(Token = "0x40166C7")]
	[FieldOffset(Offset = "0x14")]
	public Animator HudTeamBattleAni;

	[Token(Token = "0x40166C8")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Defeat;

	[Token(Token = "0x40166C9")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel DefeatTxt;

	[Token(Token = "0x40166CA")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ResultDesc;

	[Token(Token = "0x40166CB")]
	[FieldOffset(Offset = "0x24")]
	public Transform BaseReward;

	[Token(Token = "0x40166CC")]
	[FieldOffset(Offset = "0x28")]
	public UILabel GameModeTxt;

	[Token(Token = "0x40166CD")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel GameMapTxt;

	[Token(Token = "0x40166CE")]
	[FieldOffset(Offset = "0x30")]
	public GameObject WorkShopGo;

	[Token(Token = "0x40166CF")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Victory;

	[Token(Token = "0x40166D0")]
	[FieldOffset(Offset = "0x38")]
	public UILabel VictoryTxt;

	[Token(Token = "0x40166D1")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Draw;

	[Token(Token = "0x40166D2")]
	[FieldOffset(Offset = "0x40")]
	public UILabel DrawTxt;

	[Token(Token = "0x40166D3")]
	[FieldOffset(Offset = "0x44")]
	public GameObject BiaoQianOB;

	[Token(Token = "0x40166D4")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget Biaoqian1;

	[Token(Token = "0x40166D5")]
	[FieldOffset(Offset = "0x4C")]
	public UIWidget Biaoqian2;

	[Token(Token = "0x40166D6")]
	[FieldOffset(Offset = "0x50")]
	public UIWidget Biaoqian3;

	[Token(Token = "0x40166D7")]
	[FieldOffset(Offset = "0x54")]
	public UIWidget Biaoqian4;

	[Token(Token = "0x40166D8")]
	[FieldOffset(Offset = "0x58")]
	public UIWidget PlaceHolderBiaoqian;

	[Token(Token = "0x40166D9")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite LeftTeamScoreBG;

	[Token(Token = "0x40166DA")]
	[FieldOffset(Offset = "0x60")]
	public UILabel LeftTeamScore;

	[Token(Token = "0x40166DB")]
	[FieldOffset(Offset = "0x64")]
	public GameObject LeftTeamDividingLine;

	[Token(Token = "0x40166DC")]
	[FieldOffset(Offset = "0x68")]
	public GameObject LeftTeamDefaultIconOB;

	[Token(Token = "0x40166DD")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject LeftTeamDefaultIcon;

	[Token(Token = "0x40166DE")]
	[FieldOffset(Offset = "0x70")]
	public UISprite LeftTeamClanIcon;

	[Token(Token = "0x40166DF")]
	[FieldOffset(Offset = "0x74")]
	public UISprite LeftTeamIcon;

	[Token(Token = "0x40166E0")]
	[FieldOffset(Offset = "0x78")]
	public UILabel LeftTeamName;

	[Token(Token = "0x40166E1")]
	[FieldOffset(Offset = "0x7C")]
	public UISprite LeftTeamCustomIcon;

	[Token(Token = "0x40166E2")]
	[FieldOffset(Offset = "0x80")]
	public UILabel LeftTitleInfo1Txt;

	[Token(Token = "0x40166E3")]
	[FieldOffset(Offset = "0x84")]
	public UILabel LeftTitleInfo2Txt;

	[Token(Token = "0x40166E4")]
	[FieldOffset(Offset = "0x88")]
	public UILabel LeftTitleInfo3Txt;

	[Token(Token = "0x40166E5")]
	[FieldOffset(Offset = "0x8C")]
	public Transform LeftTeammate1;

	[Token(Token = "0x40166E6")]
	[FieldOffset(Offset = "0x90")]
	public Transform LeftTeammate2;

	[Token(Token = "0x40166E7")]
	[FieldOffset(Offset = "0x94")]
	public Transform LeftTeammate3;

	[Token(Token = "0x40166E8")]
	[FieldOffset(Offset = "0x98")]
	public Transform LeftTeammate4;

	[Token(Token = "0x40166E9")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite RightTeamScoreBG;

	[Token(Token = "0x40166EA")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel RightTeamScore;

	[Token(Token = "0x40166EB")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject RightTeamDividingLine;

	[Token(Token = "0x40166EC")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject RightTeamDefaultIconOB;

	[Token(Token = "0x40166ED")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject RightTeamDefaultIcon;

	[Token(Token = "0x40166EE")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite RightTeamClanIcon;

	[Token(Token = "0x40166EF")]
	[FieldOffset(Offset = "0xB4")]
	public UISprite RightTeamIcon;

	[Token(Token = "0x40166F0")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel RightTeamName;

	[Token(Token = "0x40166F1")]
	[FieldOffset(Offset = "0xBC")]
	public UISprite RightTeamCustomIcon;

	[Token(Token = "0x40166F2")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel RightTitleInfo1Txt;

	[Token(Token = "0x40166F3")]
	[FieldOffset(Offset = "0xC4")]
	public UILabel RightTitleInfo2Txt;

	[Token(Token = "0x40166F4")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel RightTitleInfo3Txt;

	[Token(Token = "0x40166F5")]
	[FieldOffset(Offset = "0xCC")]
	public Transform RightTeammate1;

	[Token(Token = "0x40166F6")]
	[FieldOffset(Offset = "0xD0")]
	public Transform RightTeammate2;

	[Token(Token = "0x40166F7")]
	[FieldOffset(Offset = "0xD4")]
	public Transform RightTeammate3;

	[Token(Token = "0x40166F8")]
	[FieldOffset(Offset = "0xD8")]
	public Transform RightTeammate4;

	[Token(Token = "0x40166F9")]
	[FieldOffset(Offset = "0xDC")]
	public UIButton DetailsBtn;

	[Token(Token = "0x40166FA")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject DetailBtnShowIcon;

	[Token(Token = "0x40166FB")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject DetailBtnHideIcon;

	[Token(Token = "0x40166FC")]
	[FieldOffset(Offset = "0xE8")]
	public UIButton ShareBtn;

	[Token(Token = "0x40166FD")]
	[FieldOffset(Offset = "0xEC")]
	public UIButton NextBtn;

	[Token(Token = "0x40166FE")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel NextBtnTime;

	[Token(Token = "0x40166FF")]
	[FieldOffset(Offset = "0xF4")]
	public UILabel NextBtnLable;

	[Token(Token = "0x4016700")]
	[FieldOffset(Offset = "0xF8")]
	public UIButton ReplayBtn;

	[Token(Token = "0x4016701")]
	[FieldOffset(Offset = "0xFC")]
	public UILabel ReplayTips;

	[Token(Token = "0x4016702")]
	[FieldOffset(Offset = "0x100")]
	public UIGrid RewardBtnGrid;

	[Token(Token = "0x4016703")]
	[FieldOffset(Offset = "0x104")]
	public UIButton LikeBtn;

	[Token(Token = "0x4016704")]
	[FieldOffset(Offset = "0x108")]
	public UIButton AddFriendBtn;

	[Token(Token = "0x4016705")]
	[FieldOffset(Offset = "0x10C")]
	public UIButton ReportBtn;

	[Token(Token = "0x4016706")]
	[FieldOffset(Offset = "0x110")]
	public UIButton VideoGiftBtn;

	[Token(Token = "0x4016707")]
	[FieldOffset(Offset = "0x114")]
	public UIButton FastSendGiftBtn;

	[Token(Token = "0x4016708")]
	[FieldOffset(Offset = "0x118")]
	public Transform CallSignContainer;

	[Token(Token = "0x4016709")]
	[FieldOffset(Offset = "0x11C")]
	public GameObject MultiDetailInfo;

	[Token(Token = "0x401670A")]
	[FieldOffset(Offset = "0x120")]
	public UIScrollView TeamInfoScrollViewLeft;

	[Token(Token = "0x401670B")]
	[FieldOffset(Offset = "0x124")]
	public UIGrid GridLeft;

	[Token(Token = "0x401670C")]
	[FieldOffset(Offset = "0x128")]
	public UIScrollView TeamInfoScrollViewRight;

	[Token(Token = "0x401670D")]
	[FieldOffset(Offset = "0x12C")]
	public UIGrid GridRight;

	[Token(Token = "0x401670E")]
	[FieldOffset(Offset = "0x130")]
	public GameObject MoreKill;

	[Token(Token = "0x401670F")]
	[FieldOffset(Offset = "0x134")]
	public GameObject OppTeamMoreInfo;

	[Token(Token = "0x4016710")]
	[FieldOffset(Offset = "0x138")]
	public UILabel MyTeamMoreLabel;

	[Token(Token = "0x4016711")]
	[FieldOffset(Offset = "0x13C")]
	public GameObject MyTeamMoreInfo;

	[Token(Token = "0x4016712")]
	[FieldOffset(Offset = "0x140")]
	public UILabel OppTeamMoreLabel;

	[Token(Token = "0x4016713")]
	[FieldOffset(Offset = "0x144")]
	public GameObject ShareInfoContainer;

	[Token(Token = "0x4016714")]
	[FieldOffset(Offset = "0x148")]
	public UIWidget Biaoqian1Share;

	[Token(Token = "0x4016715")]
	[FieldOffset(Offset = "0x14C")]
	public UIWidget Biaoqian2Share;

	[Token(Token = "0x4016716")]
	[FieldOffset(Offset = "0x150")]
	public UIWidget Biaoqian3Share;

	[Token(Token = "0x4016717")]
	[FieldOffset(Offset = "0x154")]
	public UIWidget Biaoqian4Share;

	[Token(Token = "0x4016718")]
	[FieldOffset(Offset = "0x158")]
	public UILabel ShareGameModeTxt;

	[Token(Token = "0x4016719")]
	[FieldOffset(Offset = "0x15C")]
	public UIButton DataBtn;

	[Token(Token = "0x401671A")]
	[FieldOffset(Offset = "0x160")]
	public GameObject LeftNormalTitleRoot;

	[Token(Token = "0x401671B")]
	[FieldOffset(Offset = "0x164")]
	public UILabel LeftTitleDataTxt;

	[Token(Token = "0x401671C")]
	[FieldOffset(Offset = "0x168")]
	public GameObject RightNormalTitleRoot;

	[Token(Token = "0x401671D")]
	[FieldOffset(Offset = "0x16C")]
	public UILabel RightTitleDataTxt;

	[Token(Token = "0x401671E")]
	[FieldOffset(Offset = "0x170")]
	public GameObject LeftTitlePlayerTxt;

	[Token(Token = "0x401671F")]
	[FieldOffset(Offset = "0x174")]
	public GameObject RightTitlePlayerTxt;

	[Token(Token = "0x4016720")]
	[FieldOffset(Offset = "0x178")]
	public UISprite DataBtnIcon;

	[Token(Token = "0x4016721")]
	[FieldOffset(Offset = "0x17C")]
	public UILabel DataBtnLabel;

	[Token(Token = "0x4016722")]
	[FieldOffset(Offset = "0x180")]
	public UITable BottomLeftTable;

	[Token(Token = "0x4016723")]
	[FieldOffset(Offset = "0x184")]
	public UILabel TxtModeLeftCorner;

	[Token(Token = "0x4016724")]
	[FieldOffset(Offset = "0x188")]
	public UILabel TxtMapLeftCorner;

	[Token(Token = "0x4016725")]
	[FieldOffset(Offset = "0x18C")]
	public GameObject LeftCorner;

	[Token(Token = "0x4016726")]
	[FieldOffset(Offset = "0x190")]
	public GameObject RightCorner;

	[Token(Token = "0x60169E6")]
	[Address(RVA = "0x179A8E4", Offset = "0x179A8E4", VA = "0x179A8E4")]
	public UIHudTeamBattleMatchResultView()
	{
	}

	[Token(Token = "0x60169E7")]
	[Address(RVA = "0x179A8EC", Offset = "0x179A8EC", VA = "0x179A8EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169E8")]
	[Address(RVA = "0x179CB84", Offset = "0x179CB84", VA = "0x179CB84")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
