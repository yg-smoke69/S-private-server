using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036B7")]
public class UIHudMovingJoystickView : UIBaseView
{
	[Token(Token = "0x40160E8")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget MainWidget;

	[Token(Token = "0x40160E9")]
	[FieldOffset(Offset = "0x18")]
	public Transform Joystick;

	[Token(Token = "0x40160EA")]
	[FieldOffset(Offset = "0x1C")]
	public Transform JoystickBG;

	[Token(Token = "0x40160EB")]
	[FieldOffset(Offset = "0x20")]
	public Transform Outjoystick;

	[Token(Token = "0x40160EC")]
	[FieldOffset(Offset = "0x24")]
	public UISprite RunningTag;

	[Token(Token = "0x40160ED")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NoLock;

	[Token(Token = "0x40160EE")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Runing_filing;

	[Token(Token = "0x40160EF")]
	[FieldOffset(Offset = "0x30")]
	public GameObject HighlightSpr;

	[Token(Token = "0x40160F0")]
	[FieldOffset(Offset = "0x34")]
	public GameObject VfxObj;

	[Token(Token = "0x60167D2")]
	[Address(RVA = "0x1F4DD74", Offset = "0x1F4DD74", VA = "0x1F4DD74")]
	public UIHudMovingJoystickView()
	{
	}

	[Token(Token = "0x60167D3")]
	[Address(RVA = "0x1F4DD7C", Offset = "0x1F4DD7C", VA = "0x1F4DD7C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167D4")]
	[Address(RVA = "0x1F4E188", Offset = "0x1F4E188", VA = "0x1F4E188")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
