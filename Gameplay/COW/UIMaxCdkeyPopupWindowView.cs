using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038A0")]
public class UIMaxCdkeyPopupWindowView : UIBaseView
{
	[Token(Token = "0x4017686")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelTip;

	[Token(Token = "0x4017687")]
	[FieldOffset(Offset = "0x18")]
	public UIInput InputEmail;

	[Token(Token = "0x4017688")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput InputCode;

	[Token(Token = "0x4017689")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnUrl;

	[Token(Token = "0x401768A")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnConfirm;

	[Token(Token = "0x6016D8B")]
	[Address(RVA = "0x26925A8", Offset = "0x26925A8", VA = "0x26925A8")]
	public UIMaxCdkeyPopupWindowView()
	{
	}

	[Token(Token = "0x6016D8C")]
	[Address(RVA = "0x26925B0", Offset = "0x26925B0", VA = "0x26925B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D8D")]
	[Address(RVA = "0x26928D8", Offset = "0x26928D8", VA = "0x26928D8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
