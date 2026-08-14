using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003475")]
public class UICommonErrorWndView : UIBaseView
{
	[Token(Token = "0x40146A0")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Message;

	[Token(Token = "0x40146A1")]
	[FieldOffset(Offset = "0x18")]
	public UIButton OkBtn;

	[Token(Token = "0x40146A2")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel BtnOKLabel;

	[Token(Token = "0x6016113")]
	[Address(RVA = "0x2CDE3AC", Offset = "0x2CDE3AC", VA = "0x2CDE3AC")]
	public UICommonErrorWndView()
	{
	}

	[Token(Token = "0x6016114")]
	[Address(RVA = "0x2CDE3B4", Offset = "0x2CDE3B4", VA = "0x2CDE3B4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016115")]
	[Address(RVA = "0x2CDE61C", Offset = "0x2CDE61C", VA = "0x2CDE61C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
