using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200370D")]
public class UIHudReportSubReasonToggleView : UIBaseView
{
	[Token(Token = "0x40163BE")]
	[FieldOffset(Offset = "0x14")]
	public UIToggle Toggle;

	[Token(Token = "0x40163BF")]
	[FieldOffset(Offset = "0x18")]
	public UILabel reason;

	[Token(Token = "0x60168D2")]
	[Address(RVA = "0x13ED4EC", Offset = "0x13ED4EC", VA = "0x13ED4EC")]
	public UIHudReportSubReasonToggleView()
	{
	}

	[Token(Token = "0x60168D3")]
	[Address(RVA = "0x13ED4F4", Offset = "0x13ED4F4", VA = "0x13ED4F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168D4")]
	[Address(RVA = "0x13ED6FC", Offset = "0x13ED6FC", VA = "0x13ED6FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
