using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A32")]
public class UIUGCHudWidgetAttributeSliderView : UIBaseView
{
	[Token(Token = "0x401893F")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Title;

	[Token(Token = "0x4018940")]
	[FieldOffset(Offset = "0x18")]
	public UISlider Slider;

	[Token(Token = "0x4018941")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel SliderValue;

	[Token(Token = "0x601723C")]
	[Address(RVA = "0x2FF7760", Offset = "0x2FF7760", VA = "0x2FF7760")]
	public UIUGCHudWidgetAttributeSliderView()
	{
	}

	[Token(Token = "0x601723D")]
	[Address(RVA = "0x2FF7768", Offset = "0x2FF7768", VA = "0x2FF7768", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601723E")]
	[Address(RVA = "0x2FF79D0", Offset = "0x2FF79D0", VA = "0x2FF79D0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
