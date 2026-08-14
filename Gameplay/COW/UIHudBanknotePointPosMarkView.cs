using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035E2")]
public class UIHudBanknotePointPosMarkView : UIBaseView
{
	[Token(Token = "0x401591D")]
	[FieldOffset(Offset = "0x14")]
	public UISprite NormalState;

	[Token(Token = "0x401591E")]
	[FieldOffset(Offset = "0x18")]
	public UISprite ScrambleState;

	[Token(Token = "0x401591F")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ControlPointName;

	[Token(Token = "0x4015920")]
	[FieldOffset(Offset = "0x20")]
	public UILabel RestAmount;

	[Token(Token = "0x4015921")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ArrowLeft;

	[Token(Token = "0x4015922")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ArrowUp;

	[Token(Token = "0x4015923")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ArrowDown;

	[Token(Token = "0x4015924")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ArrowRight;

	[Token(Token = "0x4015925")]
	[FieldOffset(Offset = "0x34")]
	public UILabel DistanceLabel;

	[Token(Token = "0x4015926")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget Container;

	[Token(Token = "0x6016554")]
	[Address(RVA = "0x171DF98", Offset = "0x171DF98", VA = "0x171DF98")]
	public UIHudBanknotePointPosMarkView()
	{
	}

	[Token(Token = "0x6016555")]
	[Address(RVA = "0x171DFA0", Offset = "0x171DFA0", VA = "0x171DFA0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016556")]
	[Address(RVA = "0x171E478", Offset = "0x171E478", VA = "0x171E478")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
