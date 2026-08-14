using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003919")]
public class UIPortraitCloseupView : UIBaseView
{
	[Token(Token = "0x4017C33")]
	[FieldOffset(Offset = "0x14")]
	public GameObject NormalUIRoot;

	[Token(Token = "0x4017C34")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ExitBtn;

	[Token(Token = "0x4017C35")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton TakePhotoBtn;

	[Token(Token = "0x4017C36")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ZoomInOutBtn;

	[Token(Token = "0x4017C37")]
	[FieldOffset(Offset = "0x24")]
	public UISprite ZoomInOutSpr;

	[Token(Token = "0x4017C38")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ScreenShotUIRoot;

	[Token(Token = "0x6016EF2")]
	[Address(RVA = "0xEF8774", Offset = "0xEF8774", VA = "0xEF8774")]
	public UIPortraitCloseupView()
	{
	}

	[Token(Token = "0x6016EF3")]
	[Address(RVA = "0xEF877C", Offset = "0xEF877C", VA = "0xEF877C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EF4")]
	[Address(RVA = "0xEF8AEC", Offset = "0xEF8AEC", VA = "0xEF8AEC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
