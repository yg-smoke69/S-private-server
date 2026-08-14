using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200381B")]
public class UILeaveConfirmView : UIBaseView
{
	[Token(Token = "0x4016D89")]
	[FieldOffset(Offset = "0x14")]
	public UIButton close;

	[Token(Token = "0x4016D8A")]
	[FieldOffset(Offset = "0x18")]
	public UIButton CancelBtn;

	[Token(Token = "0x4016D8B")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4016D8C")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BtnSprite;

	[Token(Token = "0x6016BFC")]
	[Address(RVA = "0x1AA3BD4", Offset = "0x1AA3BD4", VA = "0x1AA3BD4")]
	public UILeaveConfirmView()
	{
	}

	[Token(Token = "0x6016BFD")]
	[Address(RVA = "0x1AA3BDC", Offset = "0x1AA3BDC", VA = "0x1AA3BDC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BFE")]
	[Address(RVA = "0x1AA3EA4", Offset = "0x1AA3EA4", VA = "0x1AA3EA4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
