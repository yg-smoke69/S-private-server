using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003894")]
public class UIMatchMakingWaitingView : UIBaseView
{
	[Token(Token = "0x40175FF")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Time;

	[Token(Token = "0x4017600")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnCancel;

	[Token(Token = "0x4017601")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject LabelOptionalPauseHint;

	[Token(Token = "0x6016D67")]
	[Address(RVA = "0x2817248", Offset = "0x2817248", VA = "0x2817248")]
	public UIMatchMakingWaitingView()
	{
	}

	[Token(Token = "0x6016D68")]
	[Address(RVA = "0x2817250", Offset = "0x2817250", VA = "0x2817250", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D69")]
	[Address(RVA = "0x28174AC", Offset = "0x28174AC", VA = "0x28174AC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
