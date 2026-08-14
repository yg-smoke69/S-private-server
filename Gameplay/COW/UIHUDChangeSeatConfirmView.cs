using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200360B")]
public class UIHUDChangeSeatConfirmView : UIBaseView
{
	[Token(Token = "0x4015A0E")]
	[FieldOffset(Offset = "0x14")]
	public UILabel TipLabel;

	[Token(Token = "0x4015A0F")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x60165CF")]
	[Address(RVA = "0x167704C", Offset = "0x167704C", VA = "0x167704C")]
	public UIHUDChangeSeatConfirmView()
	{
	}

	[Token(Token = "0x60165D0")]
	[Address(RVA = "0x1677054", Offset = "0x1677054", VA = "0x1677054", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165D1")]
	[Address(RVA = "0x167725C", Offset = "0x167725C", VA = "0x167725C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
