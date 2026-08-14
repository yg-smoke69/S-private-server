using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200343F")]
public class UIClanApplyItemView : UIBaseView
{
	[Token(Token = "0x40143DD")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIClanApplyItem;

	[Token(Token = "0x40143DE")]
	[FieldOffset(Offset = "0x18")]
	public UISprite SelectLine;

	[Token(Token = "0x40143DF")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget ClanItemInfoContainer;

	[Token(Token = "0x40143E0")]
	[FieldOffset(Offset = "0x20")]
	public Transform AccountInfoContainer;

	[Token(Token = "0x40143E1")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ApplyBtnGroup;

	[Token(Token = "0x40143E2")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnComfirm;

	[Token(Token = "0x40143E3")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnRefuse;

	[Token(Token = "0x6016071")]
	[Address(RVA = "0x2F1FD9C", Offset = "0x2F1FD9C", VA = "0x2F1FD9C")]
	public UIClanApplyItemView()
	{
	}

	[Token(Token = "0x6016072")]
	[Address(RVA = "0x2F1FDA4", Offset = "0x2F1FDA4", VA = "0x2F1FDA4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016073")]
	[Address(RVA = "0x2F20158", Offset = "0x2F20158", VA = "0x2F20158")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
