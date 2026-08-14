using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200391B")]
public class UIPreviewTestView : UIBaseView
{
	[Token(Token = "0x4017C3C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton TestButton;

	[Token(Token = "0x4017C3D")]
	[FieldOffset(Offset = "0x18")]
	public UIInput InputFiled;

	[Token(Token = "0x4017C3E")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x4017C3F")]
	[FieldOffset(Offset = "0x20")]
	public UIButton LeftPreview;

	[Token(Token = "0x4017C40")]
	[FieldOffset(Offset = "0x24")]
	public UIButton RightPreview;

	[Token(Token = "0x4017C41")]
	[FieldOffset(Offset = "0x28")]
	public UIButton CenterPreview;

	[Token(Token = "0x4017C42")]
	[FieldOffset(Offset = "0x2C")]
	public Transform PopMenuContainer;

	[Token(Token = "0x4017C43")]
	[FieldOffset(Offset = "0x30")]
	public UIButton NextPreviewPage;

	[Token(Token = "0x6016EF8")]
	[Address(RVA = "0xF02BB8", Offset = "0xF02BB8", VA = "0xF02BB8")]
	public UIPreviewTestView()
	{
	}

	[Token(Token = "0x6016EF9")]
	[Address(RVA = "0xF02BC0", Offset = "0xF02BC0", VA = "0xF02BC0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EFA")]
	[Address(RVA = "0xF02FE0", Offset = "0xF02FE0", VA = "0xF02FE0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
