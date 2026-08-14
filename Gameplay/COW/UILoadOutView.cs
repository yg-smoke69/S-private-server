using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003837")]
public class UILoadOutView : UIBaseView
{
	[Token(Token = "0x4016EE0")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid GridOld;

	[Token(Token = "0x4016EE1")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid GridNew;

	[Token(Token = "0x4016EE2")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x6016C50")]
	[Address(RVA = "0x2156268", Offset = "0x2156268", VA = "0x2156268")]
	public UILoadOutView()
	{
	}

	[Token(Token = "0x6016C51")]
	[Address(RVA = "0x2156270", Offset = "0x2156270", VA = "0x2156270", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C52")]
	[Address(RVA = "0x21564D8", Offset = "0x21564D8", VA = "0x21564D8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
