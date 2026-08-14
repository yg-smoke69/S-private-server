using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200372A")]
public class UIHudSceneEditCurGameModeView : UIBaseView
{
	[Token(Token = "0x40164CD")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ModeLabel;

	[Token(Token = "0x40164CE")]
	[FieldOffset(Offset = "0x18")]
	public UIButton HelpBtn;

	[Token(Token = "0x6016929")]
	[Address(RVA = "0x1C5C4E0", Offset = "0x1C5C4E0", VA = "0x1C5C4E0")]
	public UIHudSceneEditCurGameModeView()
	{
	}

	[Token(Token = "0x601692A")]
	[Address(RVA = "0x1C5C4E8", Offset = "0x1C5C4E8", VA = "0x1C5C4E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601692B")]
	[Address(RVA = "0x1C5C6F0", Offset = "0x1C5C6F0", VA = "0x1C5C6F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
