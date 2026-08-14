using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036CF")]
public class UIHudPartyGameSoloDanceSettlementView : UIBaseView
{
	[Token(Token = "0x40161FE")]
	[FieldOffset(Offset = "0x14")]
	public GameObject GoSettlement;

	[Token(Token = "0x40161FF")]
	[FieldOffset(Offset = "0x18")]
	public GameObject GoSettlementScore;

	[Token(Token = "0x4016200")]
	[FieldOffset(Offset = "0x1C")]
	public Animation AnimationScore;

	[Token(Token = "0x4016201")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelSettlementScoreSelf;

	[Token(Token = "0x4016202")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelSettlementScoreSelfReal;

	[Token(Token = "0x4016203")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelSettlementScoreOther;

	[Token(Token = "0x4016204")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LabelSettlementScoreOtherReal;

	[Token(Token = "0x4016205")]
	[FieldOffset(Offset = "0x30")]
	public Transform TrSettlementBtns;

	[Token(Token = "0x4016206")]
	[FieldOffset(Offset = "0x34")]
	public UIGrid GridSettlementBtns;

	[Token(Token = "0x4016207")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnSettlementBack;

	[Token(Token = "0x4016208")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel LabelBack;

	[Token(Token = "0x4016209")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnSettlementPlayAgain;

	[Token(Token = "0x401620A")]
	[FieldOffset(Offset = "0x44")]
	public Transform Victory;

	[Token(Token = "0x401620B")]
	[FieldOffset(Offset = "0x48")]
	public TweenScale VictoryTween;

	[Token(Token = "0x401620C")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel VictoryTxt;

	[Token(Token = "0x401620D")]
	[FieldOffset(Offset = "0x50")]
	public Transform Defeat;

	[Token(Token = "0x401620E")]
	[FieldOffset(Offset = "0x54")]
	public TweenScale DefeatTween;

	[Token(Token = "0x401620F")]
	[FieldOffset(Offset = "0x58")]
	public UILabel DefeatTxt;

	[Token(Token = "0x601681A")]
	[Address(RVA = "0x1842AAC", Offset = "0x1842AAC", VA = "0x1842AAC")]
	public UIHudPartyGameSoloDanceSettlementView()
	{
	}

	[Token(Token = "0x601681B")]
	[Address(RVA = "0x1842AB4", Offset = "0x1842AB4", VA = "0x1842AB4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601681C")]
	[Address(RVA = "0x184311C", Offset = "0x184311C", VA = "0x184311C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
