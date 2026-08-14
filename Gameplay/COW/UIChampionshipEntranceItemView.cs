using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200340E")]
public class UIChampionshipEntranceItemView : UIBaseView
{
	[Token(Token = "0x401414A")]
	[FieldOffset(Offset = "0x14")]
	public Animation ShowDetailedInfoAnim;

	[Token(Token = "0x401414B")]
	[FieldOffset(Offset = "0x18")]
	public TweenPosition UIChampionshipEntranceItem;

	[Token(Token = "0x401414C")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton DetailedInfoBackBtn;

	[Token(Token = "0x401414D")]
	[FieldOffset(Offset = "0x20")]
	public UILabel DetailedTitle;

	[Token(Token = "0x401414E")]
	[FieldOffset(Offset = "0x24")]
	public UILabel CurState;

	[Token(Token = "0x401414F")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButton PrepareBtn;

	[Token(Token = "0x4014150")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton OpenBtn;

	[Token(Token = "0x4014151")]
	[FieldOffset(Offset = "0x30")]
	public UIToggleButton CheckBtn;

	[Token(Token = "0x4014152")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButton SettleBtn;

	[Token(Token = "0x4014153")]
	[FieldOffset(Offset = "0x38")]
	public UITable MatchInfo;

	[Token(Token = "0x4014154")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel ModeName;

	[Token(Token = "0x4014155")]
	[FieldOffset(Offset = "0x40")]
	public GameObject PlayerCountLabel;

	[Token(Token = "0x4014156")]
	[FieldOffset(Offset = "0x44")]
	public UILabel PlayerCount;

	[Token(Token = "0x4014157")]
	[FieldOffset(Offset = "0x48")]
	public UILabel PlayerCountLimitLabel;

	[Token(Token = "0x4014158")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject MinMatchLabel;

	[Token(Token = "0x4014159")]
	[FieldOffset(Offset = "0x50")]
	public UILabel MinMatchNum;

	[Token(Token = "0x401415A")]
	[FieldOffset(Offset = "0x54")]
	public UILabel NoWeaponSkinBonus;

	[Token(Token = "0x401415B")]
	[FieldOffset(Offset = "0x58")]
	public GameObject MonSelect;

	[Token(Token = "0x401415C")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject MonUnSelect;

	[Token(Token = "0x401415D")]
	[FieldOffset(Offset = "0x60")]
	public GameObject TueSelect;

	[Token(Token = "0x401415E")]
	[FieldOffset(Offset = "0x64")]
	public GameObject TueUnSelect;

	[Token(Token = "0x401415F")]
	[FieldOffset(Offset = "0x68")]
	public GameObject WedSelect;

	[Token(Token = "0x4014160")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject WedUnSelect;

	[Token(Token = "0x4014161")]
	[FieldOffset(Offset = "0x70")]
	public GameObject ThuSelect;

	[Token(Token = "0x4014162")]
	[FieldOffset(Offset = "0x74")]
	public GameObject ThuUnSelect;

	[Token(Token = "0x4014163")]
	[FieldOffset(Offset = "0x78")]
	public GameObject FriSelect;

	[Token(Token = "0x4014164")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject FriUnSelect;

	[Token(Token = "0x4014165")]
	[FieldOffset(Offset = "0x80")]
	public GameObject SatSelect;

	[Token(Token = "0x4014166")]
	[FieldOffset(Offset = "0x84")]
	public GameObject SatUnSelect;

	[Token(Token = "0x4014167")]
	[FieldOffset(Offset = "0x88")]
	public GameObject SunSelect;

	[Token(Token = "0x4014168")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject SunUnSelect;

	[Token(Token = "0x4014169")]
	[FieldOffset(Offset = "0x90")]
	public Animation Animation;

	[Token(Token = "0x401416A")]
	[FieldOffset(Offset = "0x94")]
	public UIButton EntranceBtn;

	[Token(Token = "0x401416B")]
	[FieldOffset(Offset = "0x98")]
	public GameObject OpenEffect;

	[Token(Token = "0x401416C")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject ClickEffect;

	[Token(Token = "0x401416D")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject OpenInfo;

	[Token(Token = "0x401416E")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject SubscriptInfo;

	[Token(Token = "0x401416F")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel Subscript;

	[Token(Token = "0x4014170")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel OpenTimeDesc;

	[Token(Token = "0x4014171")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel OpenTimeInDay;

	[Token(Token = "0x4014172")]
	[FieldOffset(Offset = "0xB4")]
	public UILabel OpenTimeInWeek;

	[Token(Token = "0x4014173")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel StartTime;

	[Token(Token = "0x4014174")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel SettleTime;

	[Token(Token = "0x4014175")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel MatchFinished;

	[Token(Token = "0x4014176")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject ComingSoon;

	[Token(Token = "0x4014177")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel ComingTime;

	[Token(Token = "0x4014178")]
	[FieldOffset(Offset = "0xCC")]
	public UIButton Ticket;

	[Token(Token = "0x4014179")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel RemainSessionLabel;

	[Token(Token = "0x401417A")]
	[FieldOffset(Offset = "0xD4")]
	public UILabel SeasonTime;

	[Token(Token = "0x401417B")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel SeasonName;

	[Token(Token = "0x401417C")]
	[FieldOffset(Offset = "0xDC")]
	public Transform CountDown;

	[Token(Token = "0x401417D")]
	[FieldOffset(Offset = "0xE0")]
	public UISprite CupDefault;

	[Token(Token = "0x401417E")]
	[FieldOffset(Offset = "0xE4")]
	public UINetworkTexture CupCDN;

	[Token(Token = "0x401417F")]
	[FieldOffset(Offset = "0xE8")]
	public UITipsButton ApplyRedPoint;

	[Token(Token = "0x4014180")]
	[FieldOffset(Offset = "0xEC")]
	public UITipsButton TrialOpenRedPoint;

	[Token(Token = "0x4014181")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject ClaimRewardRedPoint;

	[Token(Token = "0x4014182")]
	[FieldOffset(Offset = "0xF4")]
	public UIButton DetailedInfoBtn;

	[Token(Token = "0x4014183")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject LockNode;

	[Token(Token = "0x4014184")]
	[FieldOffset(Offset = "0xFC")]
	public GameObject LevelCondition;

	[Token(Token = "0x4014185")]
	[FieldOffset(Offset = "0x100")]
	public UILabel LevelConditionContent;

	[Token(Token = "0x4014186")]
	[FieldOffset(Offset = "0x104")]
	public GameObject ScoreCondition;

	[Token(Token = "0x4014187")]
	[FieldOffset(Offset = "0x108")]
	public UILabel ScoreConditionContent;

	[Token(Token = "0x4014188")]
	[FieldOffset(Offset = "0x10C")]
	public GameObject CreditBanNode;

	[Token(Token = "0x6015FDE")]
	[Address(RVA = "0x2827F98", Offset = "0x2827F98", VA = "0x2827F98")]
	public UIChampionshipEntranceItemView()
	{
	}

	[Token(Token = "0x6015FDF")]
	[Address(RVA = "0x2827FA0", Offset = "0x2827FA0", VA = "0x2827FA0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FE0")]
	[Address(RVA = "0x2829728", Offset = "0x2829728", VA = "0x2829728")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
