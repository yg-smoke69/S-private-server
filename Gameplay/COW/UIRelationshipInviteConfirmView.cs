using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200394E")]
public class UIRelationshipInviteConfirmView : UIBaseView
{
	[Token(Token = "0x4017FCA")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ConfirmInfoText;

	[Token(Token = "0x4017FCB")]
	[FieldOffset(Offset = "0x18")]
	public UIButton CancelBtn;

	[Token(Token = "0x4017FCC")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x6016F91")]
	[Address(RVA = "0x1E49CE0", Offset = "0x1E49CE0", VA = "0x1E49CE0")]
	public UIRelationshipInviteConfirmView()
	{
	}

	[Token(Token = "0x6016F92")]
	[Address(RVA = "0x1E49CE8", Offset = "0x1E49CE8", VA = "0x1E49CE8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F93")]
	[Address(RVA = "0x1E49F50", Offset = "0x1E49F50", VA = "0x1E49F50")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
