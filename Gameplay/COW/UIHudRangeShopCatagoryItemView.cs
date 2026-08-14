using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036FA")]
public class UIHudRangeShopCatagoryItemView : UIBaseView
{
	[Token(Token = "0x4016357")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x4016358")]
	[FieldOffset(Offset = "0x18")]
	public GameObject HighLight;

	[Token(Token = "0x4016359")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Sprite;

	[Token(Token = "0x401635A")]
	[FieldOffset(Offset = "0x20")]
	public UILabel NewTagLabel;

	[Token(Token = "0x6016899")]
	[Address(RVA = "0x1FD87EC", Offset = "0x1FD87EC", VA = "0x1FD87EC")]
	public UIHudRangeShopCatagoryItemView()
	{
	}

	[Token(Token = "0x601689A")]
	[Address(RVA = "0x1FD87F4", Offset = "0x1FD87F4", VA = "0x1FD87F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601689B")]
	[Address(RVA = "0x1FD8AB0", Offset = "0x1FD8AB0", VA = "0x1FD8AB0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
