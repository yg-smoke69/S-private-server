using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034BB")]
public class UIDebugConsoleView : UIBaseView
{
	[Token(Token = "0x40149F5")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Close;

	[Token(Token = "0x40149F6")]
	[FieldOffset(Offset = "0x18")]
	public UITable2 CmdTable;

	[Token(Token = "0x40149F7")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput CustomCmd;

	[Token(Token = "0x40149F8")]
	[FieldOffset(Offset = "0x20")]
	public UIButton Run;

	[Token(Token = "0x60161E5")]
	[Address(RVA = "0x2D7C8E4", Offset = "0x2D7C8E4", VA = "0x2D7C8E4")]
	public UIDebugConsoleView()
	{
	}

	[Token(Token = "0x60161E6")]
	[Address(RVA = "0x2D7C8EC", Offset = "0x2D7C8EC", VA = "0x2D7C8EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161E7")]
	[Address(RVA = "0x2D7CBB4", Offset = "0x2D7CBB4", VA = "0x2D7CBB4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
