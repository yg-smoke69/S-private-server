using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003946")]
public class UIRateGamePopupWindowView : UIBaseView
{
	[Token(Token = "0x4017F7C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton SuggestBtn;

	[Token(Token = "0x4017F7D")]
	[FieldOffset(Offset = "0x18")]
	public UIButton PraiseBtn;

	[Token(Token = "0x4017F7E")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnClose;

	[Token(Token = "0x6016F79")]
	[Address(RVA = "0x1AD0C84", Offset = "0x1AD0C84", VA = "0x1AD0C84")]
	public UIRateGamePopupWindowView()
	{
	}

	[Token(Token = "0x6016F7A")]
	[Address(RVA = "0x1AD0C8C", Offset = "0x1AD0C8C", VA = "0x1AD0C8C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F7B")]
	[Address(RVA = "0x1AD0EF4", Offset = "0x1AD0EF4", VA = "0x1AD0EF4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
