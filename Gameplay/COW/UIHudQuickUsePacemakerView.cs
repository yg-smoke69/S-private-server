using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036F6")]
public class UIHudQuickUsePacemakerView : UIBaseView
{
	[Token(Token = "0x4016349")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnAction;

	[Token(Token = "0x401634A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BtnIcon;

	[Token(Token = "0x401634B")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ActionName;

	[Token(Token = "0x601688D")]
	[Address(RVA = "0x1FD33C4", Offset = "0x1FD33C4", VA = "0x1FD33C4")]
	public UIHudQuickUsePacemakerView()
	{
	}

	[Token(Token = "0x601688E")]
	[Address(RVA = "0x1FD33CC", Offset = "0x1FD33CC", VA = "0x1FD33CC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601688F")]
	[Address(RVA = "0x1FD3634", Offset = "0x1FD3634", VA = "0x1FD3634")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
