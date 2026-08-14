using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003425")]
public class UIChampionshipView : UIBaseView
{
	[Token(Token = "0x401425C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton NoticeBtn;

	[Token(Token = "0x401425D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SeasonInfo;

	[Token(Token = "0x401425E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel SeasonName;

	[Token(Token = "0x401425F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel MatchTime;

	[Token(Token = "0x4014260")]
	[FieldOffset(Offset = "0x24")]
	public UISprite MatchTimeBg;

	[Token(Token = "0x4014261")]
	[FieldOffset(Offset = "0x28")]
	public UILabel SeasonNum;

	[Token(Token = "0x4014262")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton SeasonTipsBtn;

	[Token(Token = "0x4014263")]
	[FieldOffset(Offset = "0x30")]
	public Transform LeftTabContainer;

	[Token(Token = "0x4014264")]
	[FieldOffset(Offset = "0x34")]
	public GameObject MainPage;

	[Token(Token = "0x4014265")]
	[FieldOffset(Offset = "0x38")]
	public UILabel ModeName;

	[Token(Token = "0x4014266")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel PlayerCountLimitLabel;

	[Token(Token = "0x4014267")]
	[FieldOffset(Offset = "0x40")]
	public UILabel MinMatchNum;

	[Token(Token = "0x4014268")]
	[FieldOffset(Offset = "0x44")]
	public UILabel NoWeaponSkinBonus;

	[Token(Token = "0x4014269")]
	[FieldOffset(Offset = "0x48")]
	public UILabel OpenTimeInWeek;

	[Token(Token = "0x401426A")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel OpenTimeInDay;

	[Token(Token = "0x401426B")]
	[FieldOffset(Offset = "0x50")]
	public Transform ChampionshipReward1;

	[Token(Token = "0x401426C")]
	[FieldOffset(Offset = "0x54")]
	public Transform ChampionshipReward2;

	[Token(Token = "0x401426D")]
	[FieldOffset(Offset = "0x58")]
	public Transform ChampionshipReward3;

	[Token(Token = "0x401426E")]
	[FieldOffset(Offset = "0x5C")]
	public Transform ChampionshipReward4;

	[Token(Token = "0x401426F")]
	[FieldOffset(Offset = "0x60")]
	public UIButton BtnGotoLadderPage;

	[Token(Token = "0x4014270")]
	[FieldOffset(Offset = "0x64")]
	public Transform Center;

	[Token(Token = "0x4014271")]
	[FieldOffset(Offset = "0x68")]
	public GameObject SeasonIcon;

	[Token(Token = "0x4014272")]
	[FieldOffset(Offset = "0x6C")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x4014273")]
	[FieldOffset(Offset = "0x70")]
	public GameObject DefaultIcon;

	[Token(Token = "0x4014274")]
	[FieldOffset(Offset = "0x74")]
	public UIToggleButton PrepareBtn;

	[Token(Token = "0x4014275")]
	[FieldOffset(Offset = "0x78")]
	public UIToggleButton OpenBtn;

	[Token(Token = "0x4014276")]
	[FieldOffset(Offset = "0x7C")]
	public UIToggleButton CheckBtn;

	[Token(Token = "0x4014277")]
	[FieldOffset(Offset = "0x80")]
	public UIToggleButton SettleBtn;

	[Token(Token = "0x4014278")]
	[FieldOffset(Offset = "0x84")]
	public UILabel CurState;

	[Token(Token = "0x4014279")]
	[FieldOffset(Offset = "0x88")]
	public UITable StateDescTable;

	[Token(Token = "0x401427A")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel CurStateDesc;

	[Token(Token = "0x401427B")]
	[FieldOffset(Offset = "0x90")]
	public Transform CountDownContainer;

	[Token(Token = "0x401427C")]
	[FieldOffset(Offset = "0x94")]
	public Transform BottomRight;

	[Token(Token = "0x401427D")]
	[FieldOffset(Offset = "0x98")]
	public UIButton StartMatchBtn;

	[Token(Token = "0x401427E")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite StartMatchBtnBG;

	[Token(Token = "0x401427F")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject VFXStartClickable;

	[Token(Token = "0x4014280")]
	[FieldOffset(Offset = "0xA4")]
	public UIButton BtnMainPageJoin;

	[Token(Token = "0x4014281")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject VFX_JoinBlink;

	[Token(Token = "0x4014282")]
	[FieldOffset(Offset = "0xAC")]
	public UIButton BtnMainPageRecuit;

	[Token(Token = "0x4014283")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject VFX_RecruitBlink;

	[Token(Token = "0x4014284")]
	[FieldOffset(Offset = "0xB4")]
	public UIButton BtnMainPageSignUp;

	[Token(Token = "0x4014285")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject VFX_SignUpBlink;

	[Token(Token = "0x4014286")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel RemainSessionLabel;

	[Token(Token = "0x4014287")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject TeamPage;

	[Token(Token = "0x4014288")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject LadderPage;

	[Token(Token = "0x4014289")]
	[FieldOffset(Offset = "0xC8")]
	public Transform Left;

	[Token(Token = "0x401428A")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject LeaderBoardNotOpen;

	[Token(Token = "0x401428B")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject Leaderboard;

	[Token(Token = "0x401428C")]
	[FieldOffset(Offset = "0xD4")]
	public UIToggleButtonGroup LeaderBoardTabs;

	[Token(Token = "0x401428D")]
	[FieldOffset(Offset = "0xD8")]
	public UIToggleButton LeaderBoardRegion;

	[Token(Token = "0x401428E")]
	[FieldOffset(Offset = "0xDC")]
	public UIEasyList LeaderBoardEasyList;

	[Token(Token = "0x401428F")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject NoLeaderBoardTips;

	[Token(Token = "0x4014290")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject Checking;

	[Token(Token = "0x4014291")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject LeaderBoardSelf;

	[Token(Token = "0x4014292")]
	[FieldOffset(Offset = "0xEC")]
	public UILabel LBTips;

	[Token(Token = "0x4014293")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject RewardInfo;

	[Token(Token = "0x4014294")]
	[FieldOffset(Offset = "0xF4")]
	public Animation RewardAnimation;

	[Token(Token = "0x4014295")]
	[FieldOffset(Offset = "0xF8")]
	public UIGrid RewardGrid;

	[Token(Token = "0x4014296")]
	[FieldOffset(Offset = "0xFC")]
	public Transform Rotating01;

	[Token(Token = "0x4014297")]
	[FieldOffset(Offset = "0x100")]
	public Transform NewReward1;

	[Token(Token = "0x4014298")]
	[FieldOffset(Offset = "0x104")]
	public Transform Reward1;

	[Token(Token = "0x4014299")]
	[FieldOffset(Offset = "0x108")]
	public Transform Rotating02;

	[Token(Token = "0x401429A")]
	[FieldOffset(Offset = "0x10C")]
	public Transform Reward2;

	[Token(Token = "0x401429B")]
	[FieldOffset(Offset = "0x110")]
	public Transform NewReward2;

	[Token(Token = "0x401429C")]
	[FieldOffset(Offset = "0x114")]
	public Transform Rotating03;

	[Token(Token = "0x401429D")]
	[FieldOffset(Offset = "0x118")]
	public Transform Reward3;

	[Token(Token = "0x401429E")]
	[FieldOffset(Offset = "0x11C")]
	public Transform NewReward3;

	[Token(Token = "0x401429F")]
	[FieldOffset(Offset = "0x120")]
	public Transform Rotating04;

	[Token(Token = "0x40142A0")]
	[FieldOffset(Offset = "0x124")]
	public Transform Reward4;

	[Token(Token = "0x40142A1")]
	[FieldOffset(Offset = "0x128")]
	public Transform NewReward4;

	[Token(Token = "0x40142A2")]
	[FieldOffset(Offset = "0x12C")]
	public UILabel Ranktips;

	[Token(Token = "0x40142A3")]
	[FieldOffset(Offset = "0x130")]
	public UILabel Rank;

	[Token(Token = "0x40142A4")]
	[FieldOffset(Offset = "0x134")]
	public UILabel SeasonTips;

	[Token(Token = "0x40142A5")]
	[FieldOffset(Offset = "0x138")]
	public UILabel CompletedTips;

	[Token(Token = "0x40142A6")]
	[FieldOffset(Offset = "0x13C")]
	public UIButton ShowAllRewardBtn;

	[Token(Token = "0x40142A7")]
	[FieldOffset(Offset = "0x140")]
	public GameObject ChampionshipDefaultIcon;

	[Token(Token = "0x40142A8")]
	[FieldOffset(Offset = "0x144")]
	public UINetworkTexture ChampionshipTexture;

	[Token(Token = "0x40142A9")]
	[FieldOffset(Offset = "0x148")]
	public UIGrid ChampionshipRewardGrid;

	[Token(Token = "0x40142AA")]
	[FieldOffset(Offset = "0x14C")]
	public UILabel ChampionshipLabel;

	[Token(Token = "0x6016023")]
	[Address(RVA = "0x2623374", Offset = "0x2623374", VA = "0x2623374")]
	public UIChampionshipView()
	{
	}

	[Token(Token = "0x6016024")]
	[Address(RVA = "0x262337C", Offset = "0x262337C", VA = "0x262337C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016025")]
	[Address(RVA = "0x2624E50", Offset = "0x2624E50", VA = "0x2624E50")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
