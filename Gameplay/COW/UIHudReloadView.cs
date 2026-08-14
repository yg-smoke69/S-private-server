using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003707")]
public class UIHudReloadView : UIBaseView
{
	[Token(Token = "0x4016388")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnReload;

	[Token(Token = "0x4016389")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelNormal;

	[Token(Token = "0x401638A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ReloadWarning;

	[Token(Token = "0x401638B")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget TutorialWidget;

	[Token(Token = "0x60168C0")]
	[Address(RVA = "0x13E0E0C", Offset = "0x13E0E0C", VA = "0x13E0E0C")]
	public UIHudReloadView()
	{
	}

	[Token(Token = "0x60168C1")]
	[Address(RVA = "0x13E0E14", Offset = "0x13E0E14", VA = "0x13E0E14", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168C2")]
	[Address(RVA = "0x13E10D0", Offset = "0x13E10D0", VA = "0x13E10D0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
