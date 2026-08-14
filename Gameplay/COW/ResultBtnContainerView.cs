using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003393")]
internal class ResultBtnContainerView : UIBaseView
{
	[Token(Token = "0x4013AAE")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ResultBtnContainer;

	[Token(Token = "0x4013AAF")]
	[FieldOffset(Offset = "0x18")]
	public GameObject RewardBtns;

	[Token(Token = "0x4013AB0")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnShareLittle;

	[Token(Token = "0x4013AB1")]
	[FieldOffset(Offset = "0x20")]
	public Animator ShareIconAnimatorLittle;

	[Token(Token = "0x4013AB2")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnReward;

	[Token(Token = "0x4013AB3")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BackToLobbyButton;

	[Token(Token = "0x4013AB4")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnShare;

	[Token(Token = "0x4013AB5")]
	[FieldOffset(Offset = "0x30")]
	public Animator ShareIconAnimator;

	[Token(Token = "0x4013AB6")]
	[FieldOffset(Offset = "0x34")]
	public UILabel CountdownInfo;

	[Token(Token = "0x6015E6F")]
	[Address(RVA = "0x2408904", Offset = "0x2408904", VA = "0x2408904")]
	public ResultBtnContainerView()
	{
	}

	[Token(Token = "0x6015E70")]
	[Address(RVA = "0x240890C", Offset = "0x240890C", VA = "0x240890C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E71")]
	[Address(RVA = "0x2408C90", Offset = "0x2408C90", VA = "0x2408C90")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
