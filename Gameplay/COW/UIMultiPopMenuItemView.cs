using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038B7")]
public class UIMultiPopMenuItemView : UIBaseView
{
	[Token(Token = "0x4017773")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x4017774")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ItemWidget;

	[Token(Token = "0x4017775")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Label;

	[Token(Token = "0x4017776")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HighLight;

	[Token(Token = "0x4017777")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SelectedPoint;

	[Token(Token = "0x6016DD0")]
	[Address(RVA = "0x1952C04", Offset = "0x1952C04", VA = "0x1952C04")]
	public UIMultiPopMenuItemView()
	{
	}

	[Token(Token = "0x6016DD1")]
	[Address(RVA = "0x1952C0C", Offset = "0x1952C0C", VA = "0x1952C0C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DD2")]
	[Address(RVA = "0x1952F1C", Offset = "0x1952F1C", VA = "0x1952F1C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
