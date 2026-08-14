using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003845")]
public class UILobbyLoadoutView : UIBaseView
{
	[Token(Token = "0x4016FB5")]
	[FieldOffset(Offset = "0x14")]
	public UIButton LoadoutBtn;

	[Token(Token = "0x4016FB6")]
	[FieldOffset(Offset = "0x18")]
	public UISprite LoadOutSelect;

	[Token(Token = "0x4016FB7")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite NoLoadOutSelect;

	[Token(Token = "0x4016FB8")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget WidgetGuide;

	[Token(Token = "0x6016C7A")]
	[Address(RVA = "0xDBD418", Offset = "0xDBD418", VA = "0xDBD418")]
	public UILobbyLoadoutView()
	{
	}

	[Token(Token = "0x6016C7B")]
	[Address(RVA = "0xDBD420", Offset = "0xDBD420", VA = "0xDBD420", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C7C")]
	[Address(RVA = "0xDBD6E8", Offset = "0xDBD6E8", VA = "0xDBD6E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
