using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003738")]
public class UIHudSceneEditMoveView : UIBaseView
{
	[Token(Token = "0x4016515")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Tutorial;

	[Token(Token = "0x4016516")]
	[FieldOffset(Offset = "0x18")]
	public UICustomHoverButton BtnUp;

	[Token(Token = "0x4016517")]
	[FieldOffset(Offset = "0x1C")]
	public UICustomHoverButton BtnLeft;

	[Token(Token = "0x4016518")]
	[FieldOffset(Offset = "0x20")]
	public UICustomHoverButton BtnRight;

	[Token(Token = "0x4016519")]
	[FieldOffset(Offset = "0x24")]
	public UICustomHoverButton BtnDown;

	[Token(Token = "0x6016953")]
	[Address(RVA = "0x24E7568", Offset = "0x24E7568", VA = "0x24E7568")]
	public UIHudSceneEditMoveView()
	{
	}

	[Token(Token = "0x6016954")]
	[Address(RVA = "0x24E7570", Offset = "0x24E7570", VA = "0x24E7570", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016955")]
	[Address(RVA = "0x24E7898", Offset = "0x24E7898", VA = "0x24E7898")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
