using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003912")]
public class UIPopMenuItemBigView : UIBaseView
{
	[Token(Token = "0x4017BF0")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x4017BF1")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ItemWidget;

	[Token(Token = "0x4017BF2")]
	[FieldOffset(Offset = "0x1C")]
	public UIDragScrollView UIDragScrollView;

	[Token(Token = "0x4017BF3")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Label;

	[Token(Token = "0x4017BF4")]
	[FieldOffset(Offset = "0x24")]
	public GameObject HighLight;

	[Token(Token = "0x4017BF5")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Icon;

	[Token(Token = "0x6016EDF")]
	[Address(RVA = "0x2C5DAB4", Offset = "0x2C5DAB4", VA = "0x2C5DAB4")]
	public UIPopMenuItemBigView()
	{
	}

	[Token(Token = "0x6016EE0")]
	[Address(RVA = "0x2C5DABC", Offset = "0x2C5DABC", VA = "0x2C5DABC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EE1")]
	[Address(RVA = "0x2C5DE38", Offset = "0x2C5DE38", VA = "0x2C5DE38")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
