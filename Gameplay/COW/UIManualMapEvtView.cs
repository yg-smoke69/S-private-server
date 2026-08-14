using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003882")]
public class UIManualMapEvtView : UIBaseView
{
	[Token(Token = "0x40174DF")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIManualMapEvt;

	[Token(Token = "0x40174E0")]
	[FieldOffset(Offset = "0x18")]
	public Transform RightPos;

	[Token(Token = "0x40174E1")]
	[FieldOffset(Offset = "0x1C")]
	public Transform LeftPos;

	[Token(Token = "0x40174E2")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnLeftArrow;

	[Token(Token = "0x40174E3")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnRightArrow;

	[Token(Token = "0x6016D31")]
	[Address(RVA = "0x2C3C794", Offset = "0x2C3C794", VA = "0x2C3C794")]
	public UIManualMapEvtView()
	{
	}

	[Token(Token = "0x6016D32")]
	[Address(RVA = "0x2C3C79C", Offset = "0x2C3C79C", VA = "0x2C3C79C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D33")]
	[Address(RVA = "0x2C3CA74", Offset = "0x2C3CA74", VA = "0x2C3CA74")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
