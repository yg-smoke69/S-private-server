using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035AC")]
public class UIGameModeRankInfoView : UIBaseView
{
	[Token(Token = "0x4015700")]
	[FieldOffset(Offset = "0x14")]
	public UISprite bg;

	[Token(Token = "0x4015701")]
	[FieldOffset(Offset = "0x18")]
	public UIButton HelperBtn;

	[Token(Token = "0x4015702")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject HelperTipsContainer;

	[Token(Token = "0x4015703")]
	[FieldOffset(Offset = "0x20")]
	public UILabel HelperTips;

	[Token(Token = "0x4015704")]
	[FieldOffset(Offset = "0x24")]
	public UIButton HelperMaskBtn;

	[Token(Token = "0x4015705")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NormalView;

	[Token(Token = "0x4015706")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel gameMode;

	[Token(Token = "0x4015707")]
	[FieldOffset(Offset = "0x30")]
	public UILabel mapMode;

	[Token(Token = "0x4015708")]
	[FieldOffset(Offset = "0x34")]
	public GameObject BonusView;

	[Token(Token = "0x4015709")]
	[FieldOffset(Offset = "0x38")]
	public GameObject BonusReward;

	[Token(Token = "0x401570A")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel ladderExtraBonusRateTxt;

	[Token(Token = "0x401570B")]
	[FieldOffset(Offset = "0x40")]
	public GameObject RP;

	[Token(Token = "0x401570C")]
	[FieldOffset(Offset = "0x44")]
	public UILabel RPLabel;

	[Token(Token = "0x401570D")]
	[FieldOffset(Offset = "0x48")]
	public UILabel BgameMode;

	[Token(Token = "0x401570E")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel BmapMode;

	[Token(Token = "0x401570F")]
	[FieldOffset(Offset = "0x50")]
	public GameObject ChampionshipBonusReward;

	[Token(Token = "0x4015710")]
	[FieldOffset(Offset = "0x54")]
	public UILabel GoldBonusLabel;

	[Token(Token = "0x4015711")]
	[FieldOffset(Offset = "0x58")]
	public UILabel ExpBonusLabel;

	[Token(Token = "0x4015712")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton rankBtn;

	[Token(Token = "0x4015713")]
	[FieldOffset(Offset = "0x60")]
	public UILabel matchMode;

	[Token(Token = "0x4015714")]
	[FieldOffset(Offset = "0x64")]
	public GameObject NoDudectView;

	[Token(Token = "0x4015715")]
	[FieldOffset(Offset = "0x68")]
	public GameObject DoubleTokenView;

	[Token(Token = "0x4015716")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject DoublePointView;

	[Token(Token = "0x4015717")]
	[FieldOffset(Offset = "0x70")]
	public Transform ladderMatchEntry;

	[Token(Token = "0x4015718")]
	[FieldOffset(Offset = "0x74")]
	public GameObject openTime;

	[Token(Token = "0x4015719")]
	[FieldOffset(Offset = "0x78")]
	public UILabel openPeriod;

	[Token(Token = "0x401571A")]
	[FieldOffset(Offset = "0x7C")]
	public UIWidget RankGuideInfo;

	[Token(Token = "0x401571B")]
	[FieldOffset(Offset = "0x80")]
	public UISprite Tag;

	[Token(Token = "0x60164B2")]
	[Address(RVA = "0x21929E8", Offset = "0x21929E8", VA = "0x21929E8")]
	public UIGameModeRankInfoView()
	{
	}

	[Token(Token = "0x60164B3")]
	[Address(RVA = "0x21929F0", Offset = "0x21929F0", VA = "0x21929F0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164B4")]
	[Address(RVA = "0x2193518", Offset = "0x2193518", VA = "0x2193518")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
