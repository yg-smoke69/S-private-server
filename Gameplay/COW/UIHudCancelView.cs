using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003602")]
public class UIHudCancelView : UIBaseView
{
	[Token(Token = "0x40159E2")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnCancel;

	[Token(Token = "0x60165B4")]
	[Address(RVA = "0x21458B8", Offset = "0x21458B8", VA = "0x21458B8")]
	public UIHudCancelView()
	{
	}

	[Token(Token = "0x60165B5")]
	[Address(RVA = "0x21458C0", Offset = "0x21458C0", VA = "0x21458C0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165B6")]
	[Address(RVA = "0x2145A68", Offset = "0x2145A68", VA = "0x2145A68")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
