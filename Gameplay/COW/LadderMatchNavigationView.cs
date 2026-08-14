using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003388")]
public class LadderMatchNavigationView : UIBaseView
{
	[Token(Token = "0x4013A1A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject LadderMatchNavigation;

	[Token(Token = "0x4013A1B")]
	[FieldOffset(Offset = "0x18")]
	public Animator Anim;

	[Token(Token = "0x4013A1C")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RewardContainer;

	[Token(Token = "0x4013A1D")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTextureExt CdnReward;

	[Token(Token = "0x4013A1E")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnRewardDetail;

	[Token(Token = "0x4013A1F")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnViewAll;

	[Token(Token = "0x4013A20")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SpriteRank;

	[Token(Token = "0x4013A21")]
	[FieldOffset(Offset = "0x30")]
	public UIButton GrandMasterRuleBtn;

	[Token(Token = "0x4013A22")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Left;

	[Token(Token = "0x4013A23")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Center;

	[Token(Token = "0x4013A24")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Right;

	[Token(Token = "0x4013A25")]
	[FieldOffset(Offset = "0x40")]
	public Transform SeasonMiniInfoContainer;

	[Token(Token = "0x4013A26")]
	[FieldOffset(Offset = "0x44")]
	public Transform SeasonStatsContainer;

	[Token(Token = "0x4013A27")]
	[FieldOffset(Offset = "0x48")]
	public GameObject GoRootPopMenuSelectGameMode;

	[Token(Token = "0x4013A28")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BtnSelectGameMode;

	[Token(Token = "0x4013A29")]
	[FieldOffset(Offset = "0x50")]
	public UILabel LabelSelectedGameMode;

	[Token(Token = "0x4013A2A")]
	[FieldOffset(Offset = "0x54")]
	public UINetworkTexture TextureBtnSelectGameMode;

	[Token(Token = "0x4013A2B")]
	[FieldOffset(Offset = "0x58")]
	public GameObject GoTabModeBtns;

	[Token(Token = "0x4013A2C")]
	[FieldOffset(Offset = "0x5C")]
	public UIToggleButton ToggleBtnSelectBR;

	[Token(Token = "0x4013A2D")]
	[FieldOffset(Offset = "0x60")]
	public UILabel LabelBtnSelectBR;

	[Token(Token = "0x4013A2E")]
	[FieldOffset(Offset = "0x64")]
	public UIToggleButton ToggleBtnSelectCS;

	[Token(Token = "0x4013A2F")]
	[FieldOffset(Offset = "0x68")]
	public UILabel LabelBtnSelectCS;

	[Token(Token = "0x4013A30")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject TopRight;

	[Token(Token = "0x4013A31")]
	[FieldOffset(Offset = "0x70")]
	public UIButton ExchangeCurrencyBtn;

	[Token(Token = "0x4013A32")]
	[FieldOffset(Offset = "0x74")]
	public UILabel ExchangeCurrencyNum;

	[Token(Token = "0x4013A33")]
	[FieldOffset(Offset = "0x78")]
	public UISprite ExchangeIcon;

	[Token(Token = "0x4013A34")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject ToggleRankGroup;

	[Token(Token = "0x4013A35")]
	[FieldOffset(Offset = "0x80")]
	public GameObject ToggleRankSelected;

	[Token(Token = "0x4013A36")]
	[FieldOffset(Offset = "0x84")]
	public UIButton ToggleRank;

	[Token(Token = "0x4013A37")]
	[FieldOffset(Offset = "0x88")]
	public UILabel LabelToggleRank;

	[Token(Token = "0x4013A38")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject RankCardContainer;

	[Token(Token = "0x4013A39")]
	[FieldOffset(Offset = "0x90")]
	public UIButton ViewRankCardListBtn;

	[Token(Token = "0x4013A3A")]
	[FieldOffset(Offset = "0x94")]
	public UISprite InUseRankCardIcon;

	[Token(Token = "0x4013A3B")]
	[FieldOffset(Offset = "0x98")]
	public UICheckboxButton CurrentRankCardCheckboxBtn;

	[Token(Token = "0x4013A3C")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel RankCardCnt;

	[Token(Token = "0x4013A3D")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject NoCardInUseIcon;

	[Token(Token = "0x4013A3E")]
	[FieldOffset(Offset = "0xA4")]
	public UIButton QuickStartBtn;

	[Token(Token = "0x4013A3F")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject BgRankOpening;

	[Token(Token = "0x4013A40")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject BgRankUnopen;

	[Token(Token = "0x4013A41")]
	[FieldOffset(Offset = "0xB0")]
	public UIToggleButton ToggleBtnSelectLW;

	[Token(Token = "0x4013A42")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject UnClaimableIcon;

	[Token(Token = "0x4013A43")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject ClaimableIcon;

	[Token(Token = "0x4013A44")]
	[FieldOffset(Offset = "0xBC")]
	public UIButton UnlockRewardBtn;

	[Token(Token = "0x4013A45")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject UnlockRewardIntro;

	[Token(Token = "0x4013A46")]
	[FieldOffset(Offset = "0xC4")]
	public UILabel OpenTimeLabel;

	[Token(Token = "0x4013A47")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel SeasonLabel;

	[Token(Token = "0x4013A48")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject SeasonLabelTableGroup;

	[Token(Token = "0x4013A49")]
	[FieldOffset(Offset = "0xD0")]
	public UITable SeasonLabelGroupTable;

	[Token(Token = "0x4013A4A")]
	[FieldOffset(Offset = "0xD4")]
	public UIButton RuleButton;

	[Token(Token = "0x4013A4B")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel StageRewardLabel;

	[Token(Token = "0x4013A4C")]
	[FieldOffset(Offset = "0xDC")]
	public UIScrollView StageRewardScrollView;

	[Token(Token = "0x4013A4D")]
	[FieldOffset(Offset = "0xE0")]
	public UIEasyList RewardEasyList;

	[Token(Token = "0x4013A4E")]
	[FieldOffset(Offset = "0xE4")]
	public UILabel ExchangeStoreLabel;

	[Token(Token = "0x4013A4F")]
	[FieldOffset(Offset = "0xE8")]
	public UIButton ExchangeStoreBtn;

	[Token(Token = "0x4013A50")]
	[FieldOffset(Offset = "0xEC")]
	public UILabel UnlockRewardLabel;

	[Token(Token = "0x4013A51")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel RankTypeLabel;

	[Token(Token = "0x4013A52")]
	[FieldOffset(Offset = "0xF4")]
	public GameObject StageRewardContainer;

	[Token(Token = "0x4013A53")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject LabelRewardName;

	[Token(Token = "0x4013A54")]
	[FieldOffset(Offset = "0xFC")]
	public UILabel FakePlayerBeatLabel;

	[Token(Token = "0x4013A55")]
	[FieldOffset(Offset = "0x100")]
	public UITable SeasonLabelTable;

	[Token(Token = "0x4013A56")]
	[FieldOffset(Offset = "0x104")]
	public UILabel SelectLWLabel;

	[Token(Token = "0x4013A57")]
	[FieldOffset(Offset = "0x108")]
	public UILabel UnselectedLWLabel;

	[Token(Token = "0x6015E4F")]
	[Address(RVA = "0x1EF2AA8", Offset = "0x1EF2AA8", VA = "0x1EF2AA8")]
	public LadderMatchNavigationView()
	{
	}

	[Token(Token = "0x6015E50")]
	[Address(RVA = "0x1EF2AB0", Offset = "0x1EF2AB0", VA = "0x1EF2AB0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E51")]
	[Address(RVA = "0x1EF41F8", Offset = "0x1EF41F8", VA = "0x1EF41F8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
