using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200385D")]
public class UILuckyBagView : UIBaseView
{
	[Token(Token = "0x40171DA")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x40171DB")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList Grid;

	[Token(Token = "0x40171DC")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject NoLuckyBagTips;

	[Token(Token = "0x40171DD")]
	[FieldOffset(Offset = "0x20")]
	public UIButton RefreshBtn;

	[Token(Token = "0x40171DE")]
	[FieldOffset(Offset = "0x24")]
	public UILabel RefreshLabel;

	[Token(Token = "0x40171DF")]
	[FieldOffset(Offset = "0x28")]
	public GameObject AwardBigContainer;

	[Token(Token = "0x40171E0")]
	[FieldOffset(Offset = "0x2C")]
	public UICountDownLabel ExpiredTime;

	[Token(Token = "0x40171E1")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Claimed;

	[Token(Token = "0x40171E2")]
	[FieldOffset(Offset = "0x34")]
	public UIButton ReceiveBtn;

	[Token(Token = "0x40171E3")]
	[FieldOffset(Offset = "0x38")]
	public GameObject highlightState;

	[Token(Token = "0x40171E4")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject grayState;

	[Token(Token = "0x40171E5")]
	[FieldOffset(Offset = "0x40")]
	public UIButton AwardBtn;

	[Token(Token = "0x40171E6")]
	[FieldOffset(Offset = "0x44")]
	public UILabel level;

	[Token(Token = "0x40171E7")]
	[FieldOffset(Offset = "0x48")]
	public GameObject RedPoint;

	[Token(Token = "0x40171E8")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel AwardNum;

	[Token(Token = "0x40171E9")]
	[FieldOffset(Offset = "0x50")]
	public UISprite Box;

	[Token(Token = "0x40171EA")]
	[FieldOffset(Offset = "0x54")]
	public Animator BoxAnimator;

	[Token(Token = "0x40171EB")]
	[FieldOffset(Offset = "0x58")]
	public UISprite BoxLevel;

	[Token(Token = "0x40171EC")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject BoxAvaillableVFX;

	[Token(Token = "0x40171ED")]
	[FieldOffset(Offset = "0x60")]
	public GameObject BoxRefreshVFX;

	[Token(Token = "0x40171EE")]
	[FieldOffset(Offset = "0x64")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x40171EF")]
	[FieldOffset(Offset = "0x68")]
	public UILabel TargetScore;

	[Token(Token = "0x40171F0")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel CurentScore;

	[Token(Token = "0x40171F1")]
	[FieldOffset(Offset = "0x70")]
	public GameObject TrailVFX;

	[Token(Token = "0x40171F2")]
	[FieldOffset(Offset = "0x74")]
	public TweenPositionArc TrailVFXTweenPositionArc;

	[Token(Token = "0x40171F3")]
	[FieldOffset(Offset = "0x78")]
	public ParticleSystem progressBarFlashVFX;

	[Token(Token = "0x40171F4")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject DoubleTrailVFX;

	[Token(Token = "0x40171F5")]
	[FieldOffset(Offset = "0x80")]
	public TweenPositionArc DoubleTrailVFXTweenPositionArc;

	[Token(Token = "0x40171F6")]
	[FieldOffset(Offset = "0x84")]
	public ParticleSystem doubleProgressBarFlashVFX;

	[Token(Token = "0x40171F7")]
	[FieldOffset(Offset = "0x88")]
	public UIButton ClaimAllBtn;

	[Token(Token = "0x40171F8")]
	[FieldOffset(Offset = "0x8C")]
	public Transform DefaultBagPos;

	[Token(Token = "0x6016CC2")]
	[Address(RVA = "0x22030EC", Offset = "0x22030EC", VA = "0x22030EC")]
	public UILuckyBagView()
	{
	}

	[Token(Token = "0x6016CC3")]
	[Address(RVA = "0x22030F4", Offset = "0x22030F4", VA = "0x22030F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CC4")]
	[Address(RVA = "0x2203D3C", Offset = "0x2203D3C", VA = "0x2203D3C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
