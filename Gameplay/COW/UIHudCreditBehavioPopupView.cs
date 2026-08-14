using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200361A")]
public class UIHudCreditBehavioPopupView : UIBaseView
{
	[Token(Token = "0x4015A79")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel MainPanel;

	[Token(Token = "0x4015A7A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Bg;

	[Token(Token = "0x4015A7B")]
	[FieldOffset(Offset = "0x1C")]
	public UIPanel LabelPanel;

	[Token(Token = "0x4015A7C")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Message;

	[Token(Token = "0x4015A7D")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Messageshow;

	[Token(Token = "0x4015A7E")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget BtnTapClose;

	[Token(Token = "0x60165FD")]
	[Address(RVA = "0x1368D90", Offset = "0x1368D90", VA = "0x1368D90")]
	public UIHudCreditBehavioPopupView()
	{
	}

	[Token(Token = "0x60165FE")]
	[Address(RVA = "0x1368D98", Offset = "0x1368D98", VA = "0x1368D98", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165FF")]
	[Address(RVA = "0x1369120", Offset = "0x1369120", VA = "0x1369120")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
