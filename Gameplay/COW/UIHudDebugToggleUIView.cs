using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003634")]
public class UIHudDebugToggleUIView : UIBaseView
{
	[Token(Token = "0x4015BE0")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ToggleUIDebug;

	[Token(Token = "0x6016649")]
	[Address(RVA = "0x1CD26FC", Offset = "0x1CD26FC", VA = "0x1CD26FC")]
	public UIHudDebugToggleUIView()
	{
	}

	[Token(Token = "0x601664A")]
	[Address(RVA = "0x1CD2704", Offset = "0x1CD2704", VA = "0x1CD2704", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601664B")]
	[Address(RVA = "0x1CD28AC", Offset = "0x1CD28AC", VA = "0x1CD28AC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
