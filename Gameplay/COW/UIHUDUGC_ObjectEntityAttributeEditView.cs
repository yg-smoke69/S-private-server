using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200379E")]
public class UIHUDUGC_ObjectEntityAttributeEditView : UIBaseView
{
	[Token(Token = "0x401687D")]
	[FieldOffset(Offset = "0x14")]
	public UIButton addBtn;

	[Token(Token = "0x401687E")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList AttributeGrid;

	[Token(Token = "0x401687F")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Empty;

	[Token(Token = "0x4016880")]
	[FieldOffset(Offset = "0x20")]
	public UIButton Attribute;

	[Token(Token = "0x4016881")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Info;

	[Token(Token = "0x4016882")]
	[FieldOffset(Offset = "0x28")]
	public GameObject AttributeRoot;

	[Token(Token = "0x4016883")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject InfoRoot;

	[Token(Token = "0x4016884")]
	[FieldOffset(Offset = "0x30")]
	public UILabel InfoDes;

	[Token(Token = "0x4016885")]
	[FieldOffset(Offset = "0x34")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4016886")]
	[FieldOffset(Offset = "0x38")]
	public UISprite AddBtnBg;

	[Token(Token = "0x4016887")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel AddBtnLabel;

	[Token(Token = "0x6016A85")]
	[Address(RVA = "0x2E20824", Offset = "0x2E20824", VA = "0x2E20824")]
	public UIHUDUGC_ObjectEntityAttributeEditView()
	{
	}

	[Token(Token = "0x6016A86")]
	[Address(RVA = "0x2E2082C", Offset = "0x2E2082C", VA = "0x2E2082C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A87")]
	[Address(RVA = "0x2E20D70", Offset = "0x2E20D70", VA = "0x2E20D70")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
