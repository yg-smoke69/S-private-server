using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A26")]
public class UIUGCDebuggerConsoleItemView : UIBaseView
{
	[Token(Token = "0x40188DD")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Name;

	[Token(Token = "0x40188DE")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Default;

	[Token(Token = "0x40188DF")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton EditBtn;

	[Token(Token = "0x6017218")]
	[Address(RVA = "0x2B91AAC", Offset = "0x2B91AAC", VA = "0x2B91AAC")]
	public UIUGCDebuggerConsoleItemView()
	{
	}

	[Token(Token = "0x6017219")]
	[Address(RVA = "0x2B91AB4", Offset = "0x2B91AB4", VA = "0x2B91AB4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601721A")]
	[Address(RVA = "0x2B91D10", Offset = "0x2B91D10", VA = "0x2B91D10")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
