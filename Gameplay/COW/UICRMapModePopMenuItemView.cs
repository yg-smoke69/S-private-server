using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003491")]
public class UICRMapModePopMenuItemView : UIBaseView
{
	[Token(Token = "0x40147E6")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x40147E7")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ItemWidget;

	[Token(Token = "0x40147E8")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Label;

	[Token(Token = "0x40147E9")]
	[FieldOffset(Offset = "0x20")]
	public GameObject RLabel;

	[Token(Token = "0x40147EA")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Icon;

	[Token(Token = "0x40147EB")]
	[FieldOffset(Offset = "0x28")]
	public GameObject HighLight;

	[Token(Token = "0x6016167")]
	[Address(RVA = "0x1452D24", Offset = "0x1452D24", VA = "0x1452D24")]
	public UICRMapModePopMenuItemView()
	{
	}

	[Token(Token = "0x6016168")]
	[Address(RVA = "0x1452D2C", Offset = "0x1452D2C", VA = "0x1452D2C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016169")]
	[Address(RVA = "0x1453090", Offset = "0x1453090", VA = "0x1453090")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
