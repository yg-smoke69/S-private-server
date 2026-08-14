using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039A9")]
public class UISelectLanguageView : UIBaseView
{
	[Token(Token = "0x401834C")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid ToggleGrid;

	[Token(Token = "0x401834D")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnConfirm;

	[Token(Token = "0x401834E")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnCancel;

	[Token(Token = "0x60170A2")]
	[Address(RVA = "0x1A52F58", Offset = "0x1A52F58", VA = "0x1A52F58")]
	public UISelectLanguageView()
	{
	}

	[Token(Token = "0x60170A3")]
	[Address(RVA = "0x1A52F60", Offset = "0x1A52F60", VA = "0x1A52F60", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170A4")]
	[Address(RVA = "0x1A531C8", Offset = "0x1A531C8", VA = "0x1A531C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
