using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003762")]
public class UIHudSwimmingSurfView : UIBaseView
{
	[Token(Token = "0x4016693")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIHudSwimmingSurf;

	[Token(Token = "0x4016694")]
	[FieldOffset(Offset = "0x18")]
	public UIButton btnSwimmingSurf;

	[Token(Token = "0x4016695")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite normal;

	[Token(Token = "0x4016696")]
	[FieldOffset(Offset = "0x20")]
	public UISprite icon;

	[Token(Token = "0x60169D1")]
	[Address(RVA = "0x1FF17EC", Offset = "0x1FF17EC", VA = "0x1FF17EC")]
	public UIHudSwimmingSurfView()
	{
	}

	[Token(Token = "0x60169D2")]
	[Address(RVA = "0x1FF17F4", Offset = "0x1FF17F4", VA = "0x1FF17F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169D3")]
	[Address(RVA = "0x1FF1AB0", Offset = "0x1FF1AB0", VA = "0x1FF1AB0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
