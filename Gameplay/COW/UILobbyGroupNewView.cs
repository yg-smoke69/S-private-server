using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200383E")]
public class UILobbyGroupNewView : UIBaseView
{
	[Token(Token = "0x4016F25")]
	[FieldOffset(Offset = "0x14")]
	public UIButton OpenBtn;

	[Token(Token = "0x4016F26")]
	[FieldOffset(Offset = "0x18")]
	public Transform TopRight;

	[Token(Token = "0x4016F27")]
	[FieldOffset(Offset = "0x1C")]
	public UITexture Bg;

	[Token(Token = "0x4016F28")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BgBtn;

	[Token(Token = "0x4016F29")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ChampionshipTeamInfo;

	[Token(Token = "0x4016F2A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CupTeamTier;

	[Token(Token = "0x4016F2B")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TierLevel;

	[Token(Token = "0x4016F2C")]
	[FieldOffset(Offset = "0x30")]
	public UILabel TeamName;

	[Token(Token = "0x4016F2D")]
	[FieldOffset(Offset = "0x34")]
	public UILabel TeamScore;

	[Token(Token = "0x4016F2E")]
	[FieldOffset(Offset = "0x38")]
	public UILabel ScoreLabel;

	[Token(Token = "0x4016F2F")]
	[FieldOffset(Offset = "0x3C")]
	public Transform GroupCodePivot;

	[Token(Token = "0x4016F30")]
	[FieldOffset(Offset = "0x40")]
	public GameObject groupCode;

	[Token(Token = "0x4016F31")]
	[FieldOffset(Offset = "0x44")]
	public GameObject groupCodeLabel;

	[Token(Token = "0x4016F32")]
	[FieldOffset(Offset = "0x48")]
	public UILabel CodeLabel;

	[Token(Token = "0x4016F33")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton groupCodeBtn;

	[Token(Token = "0x4016F34")]
	[FieldOffset(Offset = "0x50")]
	public UIButton GroupCodeHelperBtn;

	[Token(Token = "0x4016F35")]
	[FieldOffset(Offset = "0x54")]
	public Transform PublicPivot;

	[Token(Token = "0x4016F36")]
	[FieldOffset(Offset = "0x58")]
	public GameObject PublicRoot;

	[Token(Token = "0x4016F37")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel publicLabel;

	[Token(Token = "0x4016F38")]
	[FieldOffset(Offset = "0x60")]
	public UIButton PublicBtn;

	[Token(Token = "0x4016F39")]
	[FieldOffset(Offset = "0x64")]
	public GameObject PublicToggleOn;

	[Token(Token = "0x4016F3A")]
	[FieldOffset(Offset = "0x68")]
	public GameObject PublicToggleOff;

	[Token(Token = "0x4016F3B")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject PublicMember;

	[Token(Token = "0x4016F3C")]
	[FieldOffset(Offset = "0x70")]
	public Transform GroupCodePivotLeft;

	[Token(Token = "0x4016F3D")]
	[FieldOffset(Offset = "0x74")]
	public Transform PublicPivotLeft;

	[Token(Token = "0x4016F3E")]
	[FieldOffset(Offset = "0x78")]
	public GameObject GroupInviteNode;

	[Token(Token = "0x4016F3F")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton ArrowBtn;

	[Token(Token = "0x4016F40")]
	[FieldOffset(Offset = "0x80")]
	public UISprite friendListArrow;

	[Token(Token = "0x4016F41")]
	[FieldOffset(Offset = "0x84")]
	public GameObject friends;

	[Token(Token = "0x4016F42")]
	[FieldOffset(Offset = "0x88")]
	public UIButton refreshBtn;

	[Token(Token = "0x4016F43")]
	[FieldOffset(Offset = "0x8C")]
	public UIInput InputName;

	[Token(Token = "0x4016F44")]
	[FieldOffset(Offset = "0x90")]
	public UIButton searchBtn;

	[Token(Token = "0x4016F45")]
	[FieldOffset(Offset = "0x94")]
	public UIScrollView scrollview;

	[Token(Token = "0x4016F46")]
	[FieldOffset(Offset = "0x98")]
	public UIPanel ScrollPanel;

	[Token(Token = "0x4016F47")]
	[FieldOffset(Offset = "0x9C")]
	public UIEasyList ListGrid;

	[Token(Token = "0x4016F48")]
	[FieldOffset(Offset = "0xA0")]
	public UIWrapContent wrapcontent;

	[Token(Token = "0x4016F49")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel LabelInterAppInvite;

	[Token(Token = "0x4016F4A")]
	[FieldOffset(Offset = "0xA8")]
	public UIGrid GridInterAppInvite;

	[Token(Token = "0x4016F4B")]
	[FieldOffset(Offset = "0xAC")]
	public UIButton BtnLineInvite;

	[Token(Token = "0x4016F4C")]
	[FieldOffset(Offset = "0xB0")]
	public UIButton BtnFBInvite;

	[Token(Token = "0x4016F4D")]
	[FieldOffset(Offset = "0xB4")]
	public UIButton BtnVKInvite;

	[Token(Token = "0x4016F4E")]
	[FieldOffset(Offset = "0xB8")]
	public UIButton BtnOtherInvite;

	[Token(Token = "0x4016F4F")]
	[FieldOffset(Offset = "0xBC")]
	public UIButton BtnJoin;

	[Token(Token = "0x4016F50")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel NumCnt;

	[Token(Token = "0x4016F51")]
	[FieldOffset(Offset = "0xC4")]
	public UITable TabTable;

	[Token(Token = "0x4016F52")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject FriendTab;

	[Token(Token = "0x4016F53")]
	[FieldOffset(Offset = "0xCC")]
	public UIToggleButton FriendToggleBtn;

	[Token(Token = "0x4016F54")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject ClanTab;

	[Token(Token = "0x4016F55")]
	[FieldOffset(Offset = "0xD4")]
	public UIToggleButton ClanToggleBtn;

	[Token(Token = "0x4016F56")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject GameVoiceBtnGroup;

	[Token(Token = "0x4016F57")]
	[FieldOffset(Offset = "0xDC")]
	public UIButton MicToggle;

	[Token(Token = "0x4016F58")]
	[FieldOffset(Offset = "0xE0")]
	public UISprite MicSprite;

	[Token(Token = "0x4016F59")]
	[FieldOffset(Offset = "0xE4")]
	public UISprite MicMask;

	[Token(Token = "0x4016F5A")]
	[FieldOffset(Offset = "0xE8")]
	public UIButton SpeakerToggle;

	[Token(Token = "0x4016F5B")]
	[FieldOffset(Offset = "0xEC")]
	public UISprite SpeakerSprite;

	[Token(Token = "0x4016F5C")]
	[FieldOffset(Offset = "0xF0")]
	public UISprite SpeakerMask;

	[Token(Token = "0x4016F5D")]
	[FieldOffset(Offset = "0xF4")]
	public Transform pveMapInfo;

	[Token(Token = "0x4016F5E")]
	[FieldOffset(Offset = "0xF8")]
	public Transform pveWeaponInfo;

	[Token(Token = "0x4016F5F")]
	[FieldOffset(Offset = "0xFC")]
	public UIAnchor leaveBtnContainer;

	[Token(Token = "0x4016F60")]
	[FieldOffset(Offset = "0x100")]
	public UIButton leaveBtn;

	[Token(Token = "0x4016F61")]
	[FieldOffset(Offset = "0x104")]
	public GameObject autoMatch;

	[Token(Token = "0x4016F62")]
	[FieldOffset(Offset = "0x108")]
	public TweenPosition AutoMatchTween;

	[Token(Token = "0x4016F63")]
	[FieldOffset(Offset = "0x10C")]
	public UILabel autoLabel;

	[Token(Token = "0x4016F64")]
	[FieldOffset(Offset = "0x110")]
	public UICheckboxButton checkBtn;

	[Token(Token = "0x4016F65")]
	[FieldOffset(Offset = "0x114")]
	public UISprite AutoMatchSelect;

	[Token(Token = "0x4016F66")]
	[FieldOffset(Offset = "0x118")]
	public UISprite AutoMatchUnSelect;

	[Token(Token = "0x4016F67")]
	[FieldOffset(Offset = "0x11C")]
	public UIButton readyBtn;

	[Token(Token = "0x4016F68")]
	[FieldOffset(Offset = "0x120")]
	public UILabel readyLabel;

	[Token(Token = "0x4016F69")]
	[FieldOffset(Offset = "0x124")]
	public GameObject Ready;

	[Token(Token = "0x4016F6A")]
	[FieldOffset(Offset = "0x128")]
	public UILabel ReadyText;

	[Token(Token = "0x4016F6B")]
	[FieldOffset(Offset = "0x12C")]
	public GameObject CancelReady;

	[Token(Token = "0x4016F6C")]
	[FieldOffset(Offset = "0x130")]
	public UILabel CancelReadyText;

	[Token(Token = "0x4016F6D")]
	[FieldOffset(Offset = "0x134")]
	public UISprite readyBtnSprite;

	[Token(Token = "0x4016F6E")]
	[FieldOffset(Offset = "0x138")]
	public UIButton playBtn;

	[Token(Token = "0x4016F6F")]
	[FieldOffset(Offset = "0x13C")]
	public UIWidget StartGameWidget;

	[Token(Token = "0x4016F70")]
	[FieldOffset(Offset = "0x140")]
	public UILabel StartLabel;

	[Token(Token = "0x4016F71")]
	[FieldOffset(Offset = "0x144")]
	public UISprite AllReadySprite;

	[Token(Token = "0x4016F72")]
	[FieldOffset(Offset = "0x148")]
	public UISprite NotReadySprite;

	[Token(Token = "0x4016F73")]
	[FieldOffset(Offset = "0x14C")]
	public GameObject Guide_start_Anim;

	[Token(Token = "0x4016F74")]
	[FieldOffset(Offset = "0x150")]
	public Transform StartIconVFX;

	[Token(Token = "0x4016F75")]
	[FieldOffset(Offset = "0x154")]
	public Transform BonusInfoAttachPoint;

	[Token(Token = "0x4016F76")]
	[FieldOffset(Offset = "0x158")]
	public GameObject championshipInfo;

	[Token(Token = "0x4016F77")]
	[FieldOffset(Offset = "0x15C")]
	public UIButton TicketBtn;

	[Token(Token = "0x4016F78")]
	[FieldOffset(Offset = "0x160")]
	public UISprite ItemIcon;

	[Token(Token = "0x4016F79")]
	[FieldOffset(Offset = "0x164")]
	public UILabel TicketNum;

	[Token(Token = "0x4016F7A")]
	[FieldOffset(Offset = "0x168")]
	public GameObject OpenTime;

	[Token(Token = "0x4016F7B")]
	[FieldOffset(Offset = "0x16C")]
	public UILabel OpenTimeLabel;

	[Token(Token = "0x4016F7C")]
	[FieldOffset(Offset = "0x170")]
	public GameObject cupMatchInfo;

	[Token(Token = "0x4016F7D")]
	[FieldOffset(Offset = "0x174")]
	public UILabel CupOpenTimeLabel;

	[Token(Token = "0x4016F7E")]
	[FieldOffset(Offset = "0x178")]
	public UIToggle cupTicketToggle;

	[Token(Token = "0x4016F7F")]
	[FieldOffset(Offset = "0x17C")]
	public UISprite CupTicketUnSelect;

	[Token(Token = "0x4016F80")]
	[FieldOffset(Offset = "0x180")]
	public UISprite CupTicketSelect;

	[Token(Token = "0x4016F81")]
	[FieldOffset(Offset = "0x184")]
	public UILabel CupTicketIconLabel;

	[Token(Token = "0x4016F82")]
	[FieldOffset(Offset = "0x188")]
	public GameObject LadderTitle;

	[Token(Token = "0x4016F83")]
	[FieldOffset(Offset = "0x18C")]
	public GameObject ReadyEffect;

	[Token(Token = "0x4016F84")]
	[FieldOffset(Offset = "0x190")]
	public GameObject Guide_start_Anim_Ready_Effect;

	[Token(Token = "0x4016F85")]
	[FieldOffset(Offset = "0x194")]
	public Transform ReadyEffectVFX;

	[Token(Token = "0x4016F86")]
	[FieldOffset(Offset = "0x198")]
	public GameObject MatchMaking;

	[Token(Token = "0x4016F87")]
	[FieldOffset(Offset = "0x19C")]
	public UILabel MulMatchLabel;

	[Token(Token = "0x4016F88")]
	[FieldOffset(Offset = "0x1A0")]
	public UISprite MulMatchIcon;

	[Token(Token = "0x4016F89")]
	[FieldOffset(Offset = "0x1A4")]
	public GameObject CupTeamLocking;

	[Token(Token = "0x4016F8A")]
	[FieldOffset(Offset = "0x1A8")]
	public UILabel CupTeamLockLabel;

	[Token(Token = "0x4016F8B")]
	[FieldOffset(Offset = "0x1AC")]
	public UISprite CupTeamLockIcon;

	[Token(Token = "0x4016F8C")]
	[FieldOffset(Offset = "0x1B0")]
	public GameObject HDInCaptainLobby;

	[Token(Token = "0x4016F8D")]
	[FieldOffset(Offset = "0x1B4")]
	public UILabel CaptainName;

	[Token(Token = "0x4016F8E")]
	[FieldOffset(Offset = "0x1B8")]
	public UIButton CodeCopyBtn;

	[Token(Token = "0x6016C65")]
	[Address(RVA = "0xDB09DC", Offset = "0xDB09DC", VA = "0xDB09DC")]
	public UILobbyGroupNewView()
	{
	}

	[Token(Token = "0x6016C66")]
	[Address(RVA = "0xDB09E4", Offset = "0xDB09E4", VA = "0xDB09E4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C67")]
	[Address(RVA = "0xDB3028", Offset = "0xDB3028", VA = "0xDB3028")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
