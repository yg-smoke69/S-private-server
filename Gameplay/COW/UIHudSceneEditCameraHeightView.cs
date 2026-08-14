using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003725")]
public class UIHudSceneEditCameraHeightView : UIBaseView
{
	[Token(Token = "0x40164B1")]
	[FieldOffset(Offset = "0x14")]
	public UISlider HeightSlider;

	[Token(Token = "0x40164B2")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget GuideWidget;

	[Token(Token = "0x601691A")]
	[Address(RVA = "0x1C54E6C", Offset = "0x1C54E6C", VA = "0x1C54E6C")]
	public UIHudSceneEditCameraHeightView()
	{
	}

	[Token(Token = "0x601691B")]
	[Address(RVA = "0x1C54E74", Offset = "0x1C54E74", VA = "0x1C54E74", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601691C")]
	[Address(RVA = "0x1C5507C", Offset = "0x1C5507C", VA = "0x1C5507C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
