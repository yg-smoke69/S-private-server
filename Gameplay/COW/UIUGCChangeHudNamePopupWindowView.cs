using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A1C")]
public class UIUGCChangeHudNamePopupWindowView : UIBaseView
{
	[Token(Token = "0x401889A")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelCurrentName;

	[Token(Token = "0x401889B")]
	[FieldOffset(Offset = "0x18")]
	public UIInput InputNewName;

	[Token(Token = "0x401889C")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnCancel;

	[Token(Token = "0x401889D")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnConfirm;

	[Token(Token = "0x401889E")]
	[FieldOffset(Offset = "0x24")]
	public UISprite ConfirmBG;

	[Token(Token = "0x60171FA")]
	[Address(RVA = "0x2B8167C", Offset = "0x2B8167C", VA = "0x2B8167C")]
	public UIUGCChangeHudNamePopupWindowView()
	{
	}

	[Token(Token = "0x60171FB")]
	[Address(RVA = "0x2B81684", Offset = "0x2B81684", VA = "0x2B81684", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171FC")]
	[Address(RVA = "0x2B819AC", Offset = "0x2B819AC", VA = "0x2B819AC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
