using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033B3")]
public class UIActivityScrollViewView : UIBaseView
{
	[Token(Token = "0x4013BDB")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel Mask;

	[Token(Token = "0x4013BDC")]
	[FieldOffset(Offset = "0x18")]
	public UIDragScrollView DragArea;

	[Token(Token = "0x4013BDD")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget DragWidget;

	[Token(Token = "0x4013BDE")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4013BDF")]
	[FieldOffset(Offset = "0x24")]
	public UITable Table;

	[Token(Token = "0x6015ECF")]
	[Address(RVA = "0x2FC08E8", Offset = "0x2FC08E8", VA = "0x2FC08E8")]
	public UIActivityScrollViewView()
	{
	}

	[Token(Token = "0x6015ED0")]
	[Address(RVA = "0x2FC08F0", Offset = "0x2FC08F0", VA = "0x2FC08F0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015ED1")]
	[Address(RVA = "0x2FC0C18", Offset = "0x2FC0C18", VA = "0x2FC0C18")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
