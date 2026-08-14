using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036DF")]
public class UIHudPlayAnimView : UIBaseView
{
	[Token(Token = "0x401628D")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnCustomAnim;

	[Token(Token = "0x6016848")]
	[Address(RVA = "0x185C990", Offset = "0x185C990", VA = "0x185C990")]
	public UIHudPlayAnimView()
	{
	}

	[Token(Token = "0x6016849")]
	[Address(RVA = "0x185C998", Offset = "0x185C998", VA = "0x185C998", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601684A")]
	[Address(RVA = "0x185CB40", Offset = "0x185CB40", VA = "0x185CB40")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
