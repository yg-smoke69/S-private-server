using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036F8")]
public class UIHudQuitConfirmView : UIBaseView
{
	[Token(Token = "0x4016354")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnCancel;

	[Token(Token = "0x4016355")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnOK;

	[Token(Token = "0x6016893")]
	[Address(RVA = "0x1FD7350", Offset = "0x1FD7350", VA = "0x1FD7350")]
	public UIHudQuitConfirmView()
	{
	}

	[Token(Token = "0x6016894")]
	[Address(RVA = "0x1FD7358", Offset = "0x1FD7358", VA = "0x1FD7358", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016895")]
	[Address(RVA = "0x1FD7560", Offset = "0x1FD7560", VA = "0x1FD7560")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
