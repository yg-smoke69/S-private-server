using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200348D")]
public class UICreateRoomCoolDownView : UIBaseView
{
	[Token(Token = "0x401474F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4014750")]
	[FieldOffset(Offset = "0x18")]
	public GameObject OneTextStyle;

	[Token(Token = "0x4014751")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel OneTextContent;

	[Token(Token = "0x601615B")]
	[Address(RVA = "0x2730F54", Offset = "0x2730F54", VA = "0x2730F54")]
	public UICreateRoomCoolDownView()
	{
	}

	[Token(Token = "0x601615C")]
	[Address(RVA = "0x2730F5C", Offset = "0x2730F5C", VA = "0x2730F5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601615D")]
	[Address(RVA = "0x27311B8", Offset = "0x27311B8", VA = "0x27311B8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
