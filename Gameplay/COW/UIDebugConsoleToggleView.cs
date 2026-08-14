using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034BA")]
public class UIDebugConsoleToggleView : UIBaseView
{
	[Token(Token = "0x40149F3")]
	[FieldOffset(Offset = "0x14")]
	public UIToggle Toggle;

	[Token(Token = "0x40149F4")]
	[FieldOffset(Offset = "0x18")]
	public UILabel name;

	[Token(Token = "0x60161E2")]
	[Address(RVA = "0x2D7C6CC", Offset = "0x2D7C6CC", VA = "0x2D7C6CC")]
	public UIDebugConsoleToggleView()
	{
	}

	[Token(Token = "0x60161E3")]
	[Address(RVA = "0x2D7C6D4", Offset = "0x2D7C6D4", VA = "0x2D7C6D4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161E4")]
	[Address(RVA = "0x2D7C8DC", Offset = "0x2D7C8DC", VA = "0x2D7C8DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
