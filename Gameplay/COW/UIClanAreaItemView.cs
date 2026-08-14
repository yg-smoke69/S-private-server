using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003441")]
internal class UIClanAreaItemView : UIBaseView
{
	[Token(Token = "0x40143E9")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x40143EA")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ItemWidget;

	[Token(Token = "0x40143EB")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Label;

	[Token(Token = "0x40143EC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HighLight;

	[Token(Token = "0x40143ED")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SelectedPoint;

	[Token(Token = "0x6016077")]
	[Address(RVA = "0x2F212A8", Offset = "0x2F212A8", VA = "0x2F212A8")]
	public UIClanAreaItemView()
	{
	}

	[Token(Token = "0x6016078")]
	[Address(RVA = "0x2F212B0", Offset = "0x2F212B0", VA = "0x2F212B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016079")]
	[Address(RVA = "0x2F214F4", Offset = "0x2F214F4", VA = "0x2F214F4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
