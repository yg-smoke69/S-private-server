using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003624")]
internal class UIHudCSSafezoneView : UIBaseView
{
	[Token(Token = "0x4015AFD")]
	[FieldOffset(Offset = "0x14")]
	public UISprite zone;

	[Token(Token = "0x6016619")]
	[Address(RVA = "0x213776C", Offset = "0x213776C", VA = "0x213776C")]
	public UIHudCSSafezoneView()
	{
	}

	[Token(Token = "0x601661A")]
	[Address(RVA = "0x2137774", Offset = "0x2137774", VA = "0x2137774", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601661B")]
	[Address(RVA = "0x2137878", Offset = "0x2137878", VA = "0x2137878")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
