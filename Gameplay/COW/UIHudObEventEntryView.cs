using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036C4")]
public class UIHudObEventEntryView : UIBaseView
{
	[Token(Token = "0x401617F")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Btns;

	[Token(Token = "0x4016180")]
	[FieldOffset(Offset = "0x18")]
	public UIButton btnLocalEvent;

	[Token(Token = "0x4016181")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton btnGlobalEvent;

	[Token(Token = "0x60167F9")]
	[Address(RVA = "0x1F5C368", Offset = "0x1F5C368", VA = "0x1F5C368")]
	public UIHudObEventEntryView()
	{
	}

	[Token(Token = "0x60167FA")]
	[Address(RVA = "0x1F5C370", Offset = "0x1F5C370", VA = "0x1F5C370", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167FB")]
	[Address(RVA = "0x1F5C5CC", Offset = "0x1F5C5CC", VA = "0x1F5C5CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
