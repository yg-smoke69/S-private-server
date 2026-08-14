using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A47")]
public class UIUGCSelectSpriteNamePopupWindowView : UIBaseView
{
	[Token(Token = "0x4018A21")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4018A22")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ItemTemplate;

	[Token(Token = "0x4018A23")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggle Toggle;

	[Token(Token = "0x4018A24")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Icon;

	[Token(Token = "0x4018A25")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid Grid;

	[Token(Token = "0x601727B")]
	[Address(RVA = "0xF3F6A0", Offset = "0xF3F6A0", VA = "0xF3F6A0")]
	public UIUGCSelectSpriteNamePopupWindowView()
	{
	}

	[Token(Token = "0x601727C")]
	[Address(RVA = "0xF3F6A8", Offset = "0xF3F6A8", VA = "0xF3F6A8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601727D")]
	[Address(RVA = "0xF3F9C4", Offset = "0xF3F9C4", VA = "0xF3F9C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
