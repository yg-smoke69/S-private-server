using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034B5")]
public class UIDebugConsoleCommandItem2View : UIBaseView
{
	[Token(Token = "0x40149E2")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CmdBtn;

	[Token(Token = "0x40149E3")]
	[FieldOffset(Offset = "0x18")]
	public UILabel CmdName;

	[Token(Token = "0x40149E4")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput Arg1;

	[Token(Token = "0x40149E5")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Arg1Name;

	[Token(Token = "0x40149E6")]
	[FieldOffset(Offset = "0x24")]
	public UIInput Arg2;

	[Token(Token = "0x40149E7")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Arg2Label;

	[Token(Token = "0x40149E8")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Arg2Name;

	[Token(Token = "0x60161D3")]
	[Address(RVA = "0x11F9E44", Offset = "0x11F9E44", VA = "0x11F9E44")]
	public UIDebugConsoleCommandItem2View()
	{
	}

	[Token(Token = "0x60161D4")]
	[Address(RVA = "0x11F9E4C", Offset = "0x11F9E4C", VA = "0x11F9E4C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161D5")]
	[Address(RVA = "0x11FA234", Offset = "0x11FA234", VA = "0x11FA234")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
