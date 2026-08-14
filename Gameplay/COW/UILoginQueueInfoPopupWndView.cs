using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003857")]
public class UILoginQueueInfoPopupWndView : UIBaseView
{
	[Token(Token = "0x4017169")]
	[FieldOffset(Offset = "0x14")]
	public UILabel QueuePos;

	[Token(Token = "0x401716A")]
	[FieldOffset(Offset = "0x18")]
	public UIProgressBar Progress;

	[Token(Token = "0x401716B")]
	[FieldOffset(Offset = "0x1C")]
	public UICountDownLabel CountDownLabel;

	[Token(Token = "0x401716C")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnClose;

	[Token(Token = "0x6016CB0")]
	[Address(RVA = "0x21F5F2C", Offset = "0x21F5F2C", VA = "0x21F5F2C")]
	public UILoginQueueInfoPopupWndView()
	{
	}

	[Token(Token = "0x6016CB1")]
	[Address(RVA = "0x21F5F34", Offset = "0x21F5F34", VA = "0x21F5F34", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CB2")]
	[Address(RVA = "0x21F61FC", Offset = "0x21F61FC", VA = "0x21F61FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
