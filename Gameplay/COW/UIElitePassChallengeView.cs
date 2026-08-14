using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003500")]
public class UIElitePassChallengeView : UIBaseView
{
	[Token(Token = "0x4014DE4")]
	[FieldOffset(Offset = "0x14")]
	public Transform LeftTabContainer;

	[Token(Token = "0x4014DE5")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BadgeIcon;

	[Token(Token = "0x4014DE6")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel BadgeCount;

	[Token(Token = "0x4014DE7")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ElitePassBtn;

	[Token(Token = "0x4014DE8")]
	[FieldOffset(Offset = "0x24")]
	public UIEasyList EasyList;

	[Token(Token = "0x4014DE9")]
	[FieldOffset(Offset = "0x28")]
	public UIButton WeeklyHelpBtn;

	[Token(Token = "0x4014DEA")]
	[FieldOffset(Offset = "0x2C")]
	public Transform CountDown;

	[Token(Token = "0x4014DEB")]
	[FieldOffset(Offset = "0x30")]
	public GameObject WeeklyContainer;

	[Token(Token = "0x4014DEC")]
	[FieldOffset(Offset = "0x34")]
	public UILabel WeekLabel;

	[Token(Token = "0x4014DED")]
	[FieldOffset(Offset = "0x38")]
	public GameObject DailyContainer;

	[Token(Token = "0x4014DEE")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton ClaimAllBtn;

	[Token(Token = "0x4014DEF")]
	[FieldOffset(Offset = "0x40")]
	public UIButton DailyHelpBtn;

	[Token(Token = "0x4014DF0")]
	[FieldOffset(Offset = "0x44")]
	public UIButton TreasureBoxPreviewBtn;

	[Token(Token = "0x4014DF1")]
	[FieldOffset(Offset = "0x48")]
	public UILabel TreasureBoxLabel;

	[Token(Token = "0x4014DF2")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel TreasureBoxProgressLabel;

	[Token(Token = "0x4014DF3")]
	[FieldOffset(Offset = "0x50")]
	public UIButton TreasureBoxClaimBtn;

	[Token(Token = "0x4014DF4")]
	[FieldOffset(Offset = "0x54")]
	public GameObject TreasureBoxNotClaim;

	[Token(Token = "0x4014DF5")]
	[FieldOffset(Offset = "0x58")]
	public GameObject TreasureBoxCanClaim;

	[Token(Token = "0x4014DF6")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel TreasureBoxNotClaimLabel;

	[Token(Token = "0x4014DF7")]
	[FieldOffset(Offset = "0x60")]
	public UILabel TreasureBoxCanClaimLabel;

	[Token(Token = "0x4014DF8")]
	[FieldOffset(Offset = "0x64")]
	public GameObject TreasureBoxClaimed;

	[Token(Token = "0x4014DF9")]
	[FieldOffset(Offset = "0x68")]
	public UILabel TreasureBoxClaimedLabel;

	[Token(Token = "0x4014DFA")]
	[FieldOffset(Offset = "0x6C")]
	public UIScrollView ChallengeScrollView;

	[Token(Token = "0x4014DFB")]
	[FieldOffset(Offset = "0x70")]
	public UILabel EPBtnLabel;

	[Token(Token = "0x4014DFC")]
	[FieldOffset(Offset = "0x74")]
	public UISprite BadgeIconBg1;

	[Token(Token = "0x4014DFD")]
	[FieldOffset(Offset = "0x78")]
	public UISprite BadgeIconBg2;

	[Token(Token = "0x4014DFE")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel WeekLabelBg;

	[Token(Token = "0x4014DFF")]
	[FieldOffset(Offset = "0x80")]
	public UILabel DayLabel;

	[Token(Token = "0x4014E00")]
	[FieldOffset(Offset = "0x84")]
	public UILabel DayLabelBg;

	[Token(Token = "0x4014E01")]
	[FieldOffset(Offset = "0x88")]
	public UIButton MaxRewardClaimBtn;

	[Token(Token = "0x4014E02")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel MaxRewardCanClaimLabel;

	[Token(Token = "0x4014E03")]
	[FieldOffset(Offset = "0x90")]
	public GameObject MaxRewardClaimed;

	[Token(Token = "0x4014E04")]
	[FieldOffset(Offset = "0x94")]
	public UILabel MaxRewardClaimedLabel;

	[Token(Token = "0x4014E05")]
	[FieldOffset(Offset = "0x98")]
	public GameObject MaxRewardNotClaim;

	[Token(Token = "0x4014E06")]
	[FieldOffset(Offset = "0x9C")]
	public UIButton MaxRewardCheckBtn;

	[Token(Token = "0x4014E07")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel MaxRewardCheckLabel;

	[Token(Token = "0x4014E08")]
	[FieldOffset(Offset = "0xA4")]
	public UIProgressBar MaxRewardProgress;

	[Token(Token = "0x4014E09")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel MaxRewardProgressLabel;

	[Token(Token = "0x4014E0A")]
	[FieldOffset(Offset = "0xAC")]
	public UISprite MaxRewardProgressIcon;

	[Token(Token = "0x4014E0B")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject MaxRewardProgressContainer;

	[Token(Token = "0x4014E0C")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject UIFX_TreasureBox_Effect;

	[Token(Token = "0x4014E0D")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject UIFX_EPGet_Effect;

	[Token(Token = "0x4014E0E")]
	[FieldOffset(Offset = "0xBC")]
	public UIButton GoExchangeBtn;

	[Token(Token = "0x4014E0F")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel GoExchangeLabel;

	[Token(Token = "0x4014E10")]
	[FieldOffset(Offset = "0xC4")]
	public UISprite GoExchangeIcon;

	[Token(Token = "0x4014E11")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject UIFX_SpitEffect;

	[Token(Token = "0x60162B0")]
	[Address(RVA = "0x2A51F38", Offset = "0x2A51F38", VA = "0x2A51F38")]
	public UIElitePassChallengeView()
	{
	}

	[Token(Token = "0x60162B1")]
	[Address(RVA = "0x2A51F40", Offset = "0x2A51F40", VA = "0x2A51F40", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162B2")]
	[Address(RVA = "0x2A530F4", Offset = "0x2A530F4", VA = "0x2A530F4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
