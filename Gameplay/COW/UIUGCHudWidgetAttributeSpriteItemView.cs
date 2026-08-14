using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A33")]
public class UIUGCHudWidgetAttributeSpriteItemView : UIBaseView
{
	[Token(Token = "0x4018942")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Icon;

	[Token(Token = "0x4018943")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SelectedFrame;

	[Token(Token = "0x4018944")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ItemButton;

	[Token(Token = "0x601723F")]
	[Address(RVA = "0x2FF8F54", Offset = "0x2FF8F54", VA = "0x2FF8F54")]
	public UIUGCHudWidgetAttributeSpriteItemView()
	{
	}

	[Token(Token = "0x6017240")]
	[Address(RVA = "0x2FF8F5C", Offset = "0x2FF8F5C", VA = "0x2FF8F5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017241")]
	[Address(RVA = "0x2FF91B8", Offset = "0x2FF91B8", VA = "0x2FF91B8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
