using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039FC")]
public class UITokenTipsBtnItemView : UIBaseView
{
	[Token(Token = "0x40186F4")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UITokenTipsBtnItem;

	[Token(Token = "0x40186F5")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Label;

	[Token(Token = "0x601719A")]
	[Address(RVA = "0x201EFC8", Offset = "0x201EFC8", VA = "0x201EFC8")]
	public UITokenTipsBtnItemView()
	{
	}

	[Token(Token = "0x601719B")]
	[Address(RVA = "0x201EFD0", Offset = "0x201EFD0", VA = "0x201EFD0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601719C")]
	[Address(RVA = "0x201F1D8", Offset = "0x201F1D8", VA = "0x201F1D8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
