using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035E1")]
public class UIHudBanknoteMatchTimeScoreView : UIBaseView
{
	[Token(Token = "0x401590C")]
	[FieldOffset(Offset = "0x14")]
	public GameObject NoActivatingPoint;

	[Token(Token = "0x401590D")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnLeaderboard;

	[Token(Token = "0x401590E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ActivatingPoint;

	[Token(Token = "0x401590F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel time;

	[Token(Token = "0x4015910")]
	[FieldOffset(Offset = "0x24")]
	public UILabel targetScore;

	[Token(Token = "0x4015911")]
	[FieldOffset(Offset = "0x28")]
	public GameObject PingJuEffect;

	[Token(Token = "0x4015912")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ScambleState;

	[Token(Token = "0x4015913")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LocalOccupyState;

	[Token(Token = "0x4015914")]
	[FieldOffset(Offset = "0x34")]
	public GameObject OppOccupyState;

	[Token(Token = "0x4015915")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LocalTeamScore;

	[Token(Token = "0x4015916")]
	[FieldOffset(Offset = "0x3C")]
	public UIProgressBar LocalTeamScoreBar;

	[Token(Token = "0x4015917")]
	[FieldOffset(Offset = "0x40")]
	public UILabel LocalMinusScore;

	[Token(Token = "0x4015918")]
	[FieldOffset(Offset = "0x44")]
	public UILabel OppTeamScore;

	[Token(Token = "0x4015919")]
	[FieldOffset(Offset = "0x48")]
	public UIProgressBar OppTeamScoreBar;

	[Token(Token = "0x401591A")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel OppMinusScore;

	[Token(Token = "0x401591B")]
	[FieldOffset(Offset = "0x50")]
	public UILabel CaptureInfoLabel;

	[Token(Token = "0x401591C")]
	[FieldOffset(Offset = "0x54")]
	public TweenAlpha CaptureInfoTween;

	[Token(Token = "0x6016551")]
	[Address(RVA = "0x171C40C", Offset = "0x171C40C", VA = "0x171C40C")]
	public UIHudBanknoteMatchTimeScoreView()
	{
	}

	[Token(Token = "0x6016552")]
	[Address(RVA = "0x171C414", Offset = "0x171C414", VA = "0x171C414", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016553")]
	[Address(RVA = "0x171CB80", Offset = "0x171CB80", VA = "0x171CB80")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
