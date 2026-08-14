using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200379D")]
public class UIHUDUGC_ObjectEntityAttributeEditItemView : UIBaseView
{
	[Token(Token = "0x4016877")]
	[FieldOffset(Offset = "0x14")]
	public UIButton DeleteBtn;

	[Token(Token = "0x4016878")]
	[FieldOffset(Offset = "0x18")]
	public Transform AttributeMenu;

	[Token(Token = "0x4016879")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput NameInput;

	[Token(Token = "0x401687A")]
	[FieldOffset(Offset = "0x20")]
	public UIInput ValueInput;

	[Token(Token = "0x401687B")]
	[FieldOffset(Offset = "0x24")]
	public Transform boolValueMenu;

	[Token(Token = "0x401687C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject standardValue;

	[Token(Token = "0x6016A82")]
	[Address(RVA = "0x2E204E8", Offset = "0x2E204E8", VA = "0x2E204E8")]
	public UIHUDUGC_ObjectEntityAttributeEditItemView()
	{
	}

	[Token(Token = "0x6016A83")]
	[Address(RVA = "0x2E204F0", Offset = "0x2E204F0", VA = "0x2E204F0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A84")]
	[Address(RVA = "0x2E2081C", Offset = "0x2E2081C", VA = "0x2E2081C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
