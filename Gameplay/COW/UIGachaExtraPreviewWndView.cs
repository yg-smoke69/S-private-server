using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003571")]
public class UIGachaExtraPreviewWndView : UIBaseView
{
	[Token(Token = "0x40152ED")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid PreviewGrid;

	[Token(Token = "0x40152EE")]
	[FieldOffset(Offset = "0x18")]
	public UIButton OKBtn;

	[Token(Token = "0x40152EF")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel BtnLabel;

	[Token(Token = "0x40152F0")]
	[FieldOffset(Offset = "0x20")]
	public UILabel AccumulationLabel;

	[Token(Token = "0x40152F1")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LeftTimes;

	[Token(Token = "0x6016403")]
	[Address(RVA = "0x2479D2C", Offset = "0x2479D2C", VA = "0x2479D2C")]
	public UIGachaExtraPreviewWndView()
	{
	}

	[Token(Token = "0x6016404")]
	[Address(RVA = "0x2479D34", Offset = "0x2479D34", VA = "0x2479D34", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016405")]
	[Address(RVA = "0x247A05C", Offset = "0x247A05C", VA = "0x247A05C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
