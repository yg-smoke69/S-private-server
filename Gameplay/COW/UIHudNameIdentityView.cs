using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036BB")]
public class UIHudNameIdentityView : UIBaseView
{
	[Token(Token = "0x40160F9")]
	[FieldOffset(Offset = "0x14")]
	public UISprite IconSprite;

	[Token(Token = "0x40160FA")]
	[FieldOffset(Offset = "0x18")]
	public UISprite IconSpriteHuman;

	[Token(Token = "0x40160FB")]
	[FieldOffset(Offset = "0x1C")]
	public Transform container;

	[Token(Token = "0x60167DE")]
	[Address(RVA = "0x1F50904", Offset = "0x1F50904", VA = "0x1F50904")]
	public UIHudNameIdentityView()
	{
	}

	[Token(Token = "0x60167DF")]
	[Address(RVA = "0x1F5090C", Offset = "0x1F5090C", VA = "0x1F5090C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167E0")]
	[Address(RVA = "0x1F50B4C", Offset = "0x1F50B4C", VA = "0x1F50B4C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
