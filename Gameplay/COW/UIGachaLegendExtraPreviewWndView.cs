using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003580")]
public class UIGachaLegendExtraPreviewWndView : UIBaseView
{
	[Token(Token = "0x4015405")]
	[FieldOffset(Offset = "0x14")]
	public UIButton OKBtn;

	[Token(Token = "0x4015406")]
	[FieldOffset(Offset = "0x18")]
	public UILabel BtnLabel;

	[Token(Token = "0x4015407")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid PreviewGrid;

	[Token(Token = "0x4015408")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Label;

	[Token(Token = "0x6016430")]
	[Address(RVA = "0x2489638", Offset = "0x2489638", VA = "0x2489638")]
	public UIGachaLegendExtraPreviewWndView()
	{
	}

	[Token(Token = "0x6016431")]
	[Address(RVA = "0x2489640", Offset = "0x2489640", VA = "0x2489640", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016432")]
	[Address(RVA = "0x2489908", Offset = "0x2489908", VA = "0x2489908")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
