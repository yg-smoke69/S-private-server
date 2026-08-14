using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039FB")]
public class UIToggleSpriteItemView : UIBaseView
{
	[Token(Token = "0x40186F1")]
	[FieldOffset(Offset = "0x14")]
	public UIToggle ItemToggle;

	[Token(Token = "0x40186F2")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Sprite;

	[Token(Token = "0x40186F3")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite UnselectedSprite;

	[Token(Token = "0x6017197")]
	[Address(RVA = "0x201D5EC", Offset = "0x201D5EC", VA = "0x201D5EC")]
	public UIToggleSpriteItemView()
	{
	}

	[Token(Token = "0x6017198")]
	[Address(RVA = "0x201D5F4", Offset = "0x201D5F4", VA = "0x201D5F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017199")]
	[Address(RVA = "0x201D85C", Offset = "0x201D85C", VA = "0x201D85C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
