using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034B4")]
public class UIDebugConsoleCommandItem2PopupView : UIBaseView
{
	[Token(Token = "0x40149DA")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CmdBtn;

	[Token(Token = "0x40149DB")]
	[FieldOffset(Offset = "0x18")]
	public UILabel CmdName;

	[Token(Token = "0x40149DC")]
	[FieldOffset(Offset = "0x1C")]
	public Transform Arg1;

	[Token(Token = "0x40149DD")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Arg1Name;

	[Token(Token = "0x40149DE")]
	[FieldOffset(Offset = "0x24")]
	public Transform Arg1PopupContainer;

	[Token(Token = "0x40149DF")]
	[FieldOffset(Offset = "0x28")]
	public Transform Arg2;

	[Token(Token = "0x40149E0")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Arg2Name;

	[Token(Token = "0x40149E1")]
	[FieldOffset(Offset = "0x30")]
	public Transform Arg2PopupContainer;

	[Token(Token = "0x60161D0")]
	[Address(RVA = "0x11F9A8C", Offset = "0x11F9A8C", VA = "0x11F9A8C")]
	public UIDebugConsoleCommandItem2PopupView()
	{
	}

	[Token(Token = "0x60161D1")]
	[Address(RVA = "0x11F9A94", Offset = "0x11F9A94", VA = "0x11F9A94", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161D2")]
	[Address(RVA = "0x11F9E3C", Offset = "0x11F9E3C", VA = "0x11F9E3C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
