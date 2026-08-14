using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003466")]
public class UIClanWarPreviewWndView : UIBaseView
{
	[Token(Token = "0x40145BC")]
	[FieldOffset(Offset = "0x14")]
	public UIButton OKBtn;

	[Token(Token = "0x40145BD")]
	[FieldOffset(Offset = "0x18")]
	public UILabel BtnLabel;

	[Token(Token = "0x40145BE")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid PreviewGrid;

	[Token(Token = "0x60160E6")]
	[Address(RVA = "0x29049EC", Offset = "0x29049EC", VA = "0x29049EC")]
	public UIClanWarPreviewWndView()
	{
	}

	[Token(Token = "0x60160E7")]
	[Address(RVA = "0x29049F4", Offset = "0x29049F4", VA = "0x29049F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160E8")]
	[Address(RVA = "0x2904C5C", Offset = "0x2904C5C", VA = "0x2904C5C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
