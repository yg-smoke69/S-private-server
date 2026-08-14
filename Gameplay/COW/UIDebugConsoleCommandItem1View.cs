using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034B3")]
public class UIDebugConsoleCommandItem1View : UIBaseView
{
	[Token(Token = "0x40149D6")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CmdBtn;

	[Token(Token = "0x40149D7")]
	[FieldOffset(Offset = "0x18")]
	public UILabel CmdName;

	[Token(Token = "0x40149D8")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput Arg1;

	[Token(Token = "0x40149D9")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Arg1Name;

	[Token(Token = "0x60161CD")]
	[Address(RVA = "0x11F6E38", Offset = "0x11F6E38", VA = "0x11F6E38")]
	public UIDebugConsoleCommandItem1View()
	{
	}

	[Token(Token = "0x60161CE")]
	[Address(RVA = "0x11F6E40", Offset = "0x11F6E40", VA = "0x11F6E40", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161CF")]
	[Address(RVA = "0x11F7108", Offset = "0x11F7108", VA = "0x11F7108")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
