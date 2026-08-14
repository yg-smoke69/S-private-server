using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003774")]
public class UIHudTokenComboView : UIBaseView
{
	[Token(Token = "0x401676D")]
	[FieldOffset(Offset = "0x14")]
	public GameObject AnimWidget;

	[Token(Token = "0x401676E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Num;

	[Token(Token = "0x401676F")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel NumShadow;

	[Token(Token = "0x4016770")]
	[FieldOffset(Offset = "0x20")]
	public UILabel NumShadow_Big;

	[Token(Token = "0x4016771")]
	[FieldOffset(Offset = "0x24")]
	public UILabel combo;

	[Token(Token = "0x4016772")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ComboShadow;

	[Token(Token = "0x4016773")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel ComboShadow_Big;

	[Token(Token = "0x6016A07")]
	[Address(RVA = "0x157F770", Offset = "0x157F770", VA = "0x157F770")]
	public UIHudTokenComboView()
	{
	}

	[Token(Token = "0x6016A08")]
	[Address(RVA = "0x157F778", Offset = "0x157F778", VA = "0x157F778", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A09")]
	[Address(RVA = "0x157FB54", Offset = "0x157FB54", VA = "0x157FB54")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
