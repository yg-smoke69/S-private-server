using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034B6")]
public class UIDebugConsoleCommandItemView : UIBaseView
{
	[Token(Token = "0x40149E9")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CmdBtn;

	[Token(Token = "0x40149EA")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Name;

	[Token(Token = "0x60161D6")]
	[Address(RVA = "0x11FA23C", Offset = "0x11FA23C", VA = "0x11FA23C")]
	public UIDebugConsoleCommandItemView()
	{
	}

	[Token(Token = "0x60161D7")]
	[Address(RVA = "0x11FA244", Offset = "0x11FA244", VA = "0x11FA244", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161D8")]
	[Address(RVA = "0x11FA44C", Offset = "0x11FA44C", VA = "0x11FA44C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
