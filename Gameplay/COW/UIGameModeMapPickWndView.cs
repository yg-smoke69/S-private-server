using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035A9")]
public class UIGameModeMapPickWndView : UIBaseView
{
	[Token(Token = "0x40156D3")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid GridMaps;

	[Token(Token = "0x40156D4")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnConfirm;

	[Token(Token = "0x40156D5")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelSelected;

	[Token(Token = "0x40156D6")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnSelectAll;

	[Token(Token = "0x40156D7")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SpriteAllTick;

	[Token(Token = "0x60164A9")]
	[Address(RVA = "0x218B35C", Offset = "0x218B35C", VA = "0x218B35C")]
	public UIGameModeMapPickWndView()
	{
	}

	[Token(Token = "0x60164AA")]
	[Address(RVA = "0x218B364", Offset = "0x218B364", VA = "0x218B364", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164AB")]
	[Address(RVA = "0x218B68C", Offset = "0x218B68C", VA = "0x218B68C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
