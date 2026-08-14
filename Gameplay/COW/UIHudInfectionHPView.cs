using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003674")]
public class UIHudInfectionHPView : UIBaseView
{
	[Token(Token = "0x4015DBD")]
	[FieldOffset(Offset = "0x14")]
	public UISlider SliderFront;

	[Token(Token = "0x4015DBE")]
	[FieldOffset(Offset = "0x18")]
	public TweenFill Middle;

	[Token(Token = "0x4015DBF")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite MiddleSprite;

	[Token(Token = "0x6016709")]
	[Address(RVA = "0x22A5A94", Offset = "0x22A5A94", VA = "0x22A5A94")]
	public UIHudInfectionHPView()
	{
	}

	[Token(Token = "0x601670A")]
	[Address(RVA = "0x22A5A9C", Offset = "0x22A5A9C", VA = "0x22A5A9C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601670B")]
	[Address(RVA = "0x22A5D04", Offset = "0x22A5D04", VA = "0x22A5D04")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
