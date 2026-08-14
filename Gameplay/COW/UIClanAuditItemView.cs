using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003442")]
public class UIClanAuditItemView : UIBaseView
{
	[Token(Token = "0x40143EE")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x40143EF")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ItemWidget;

	[Token(Token = "0x40143F0")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Label;

	[Token(Token = "0x40143F1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HighLight;

	[Token(Token = "0x40143F2")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SelectedPoint;

	[Token(Token = "0x601607A")]
	[Address(RVA = "0x2F21AC4", Offset = "0x2F21AC4", VA = "0x2F21AC4")]
	public UIClanAuditItemView()
	{
	}

	[Token(Token = "0x601607B")]
	[Address(RVA = "0x2F21ACC", Offset = "0x2F21ACC", VA = "0x2F21ACC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601607C")]
	[Address(RVA = "0x2F21DDC", Offset = "0x2F21DDC", VA = "0x2F21DDC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
