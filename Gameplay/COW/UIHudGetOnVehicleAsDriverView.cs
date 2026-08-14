using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003664")]
public class UIHudGetOnVehicleAsDriverView : UIBaseView
{
	[Token(Token = "0x4015D3D")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnDriver;

	[Token(Token = "0x4015D3E")]
	[FieldOffset(Offset = "0x18")]
	public UISprite SpriteBg;

	[Token(Token = "0x60166D9")]
	[Address(RVA = "0x189362C", Offset = "0x189362C", VA = "0x189362C")]
	public UIHudGetOnVehicleAsDriverView()
	{
	}

	[Token(Token = "0x60166DA")]
	[Address(RVA = "0x1893634", Offset = "0x1893634", VA = "0x1893634", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166DB")]
	[Address(RVA = "0x189383C", Offset = "0x189383C", VA = "0x189383C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
