using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035FD")]
public class UIHudBuffListItemView : UIBaseView
{
	[Token(Token = "0x40159CD")]
	[FieldOffset(Offset = "0x14")]
	public UISprite SpriteItemIcon;

	[Token(Token = "0x40159CE")]
	[FieldOffset(Offset = "0x18")]
	public UISprite CountDown;

	[Token(Token = "0x60165A5")]
	[Address(RVA = "0x1EFC004", Offset = "0x1EFC004", VA = "0x1EFC004")]
	public UIHudBuffListItemView()
	{
	}

	[Token(Token = "0x60165A6")]
	[Address(RVA = "0x1EFC00C", Offset = "0x1EFC00C", VA = "0x1EFC00C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165A7")]
	[Address(RVA = "0x1EFC214", Offset = "0x1EFC214", VA = "0x1EFC214")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
