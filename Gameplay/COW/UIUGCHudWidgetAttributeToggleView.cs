using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A37")]
public class UIUGCHudWidgetAttributeToggleView : UIBaseView
{
	[Token(Token = "0x4018950")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Title;

	[Token(Token = "0x4018951")]
	[FieldOffset(Offset = "0x18")]
	public UIToggle Toggle;

	[Token(Token = "0x4018952")]
	[FieldOffset(Offset = "0x1C")]
	public TweenPosition Thumb;

	[Token(Token = "0x601724B")]
	[Address(RVA = "0x2FFB334", Offset = "0x2FFB334", VA = "0x2FFB334")]
	public UIUGCHudWidgetAttributeToggleView()
	{
	}

	[Token(Token = "0x601724C")]
	[Address(RVA = "0x2FFB33C", Offset = "0x2FFB33C", VA = "0x2FFB33C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601724D")]
	[Address(RVA = "0x2FFB5A4", Offset = "0x2FFB5A4", VA = "0x2FFB5A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
