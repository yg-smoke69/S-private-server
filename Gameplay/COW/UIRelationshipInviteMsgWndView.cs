using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003950")]
public class UIRelationshipInviteMsgWndView : UIBaseView
{
	[Token(Token = "0x4017FD2")]
	[FieldOffset(Offset = "0x14")]
	public UIEasyList msgGrid;

	[Token(Token = "0x4017FD3")]
	[FieldOffset(Offset = "0x18")]
	public GameObject NoneMsgLabel;

	[Token(Token = "0x6016F97")]
	[Address(RVA = "0x1E4C54C", Offset = "0x1E4C54C", VA = "0x1E4C54C")]
	public UIRelationshipInviteMsgWndView()
	{
	}

	[Token(Token = "0x6016F98")]
	[Address(RVA = "0x1E4C554", Offset = "0x1E4C554", VA = "0x1E4C554", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F99")]
	[Address(RVA = "0x1E4C750", Offset = "0x1E4C750", VA = "0x1E4C750")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
