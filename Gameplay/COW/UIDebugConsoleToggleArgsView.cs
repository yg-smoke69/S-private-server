using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034B9")]
public class UIDebugConsoleToggleArgsView : UIBaseView
{
	[Token(Token = "0x40149EF")]
	[FieldOffset(Offset = "0x14")]
	public UIToggle Toggle;

	[Token(Token = "0x40149F0")]
	[FieldOffset(Offset = "0x18")]
	public UILabel name;

	[Token(Token = "0x40149F1")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ArgTemplate;

	[Token(Token = "0x40149F2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ArgsGO;

	[Token(Token = "0x60161DF")]
	[Address(RVA = "0x2D7C40C", Offset = "0x2D7C40C", VA = "0x2D7C40C")]
	public UIDebugConsoleToggleArgsView()
	{
	}

	[Token(Token = "0x60161E0")]
	[Address(RVA = "0x2D7C414", Offset = "0x2D7C414", VA = "0x2D7C414", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161E1")]
	[Address(RVA = "0x2D7C6C4", Offset = "0x2D7C6C4", VA = "0x2D7C6C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
