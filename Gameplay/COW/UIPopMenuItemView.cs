using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003914")]
public class UIPopMenuItemView : UIBaseView
{
	[Token(Token = "0x4017C02")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x4017C03")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ItemWidget;

	[Token(Token = "0x4017C04")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Label;

	[Token(Token = "0x4017C05")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HighLight;

	[Token(Token = "0x6016EE5")]
	[Address(RVA = "0x2C5FF38", Offset = "0x2C5FF38", VA = "0x2C5FF38")]
	public UIPopMenuItemView()
	{
	}

	[Token(Token = "0x6016EE6")]
	[Address(RVA = "0x2C5FF40", Offset = "0x2C5FF40", VA = "0x2C5FF40", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EE7")]
	[Address(RVA = "0x2C601FC", Offset = "0x2C601FC", VA = "0x2C601FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
