using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003696")]
public class UIHudLockedTargetView : UIBaseView
{
	[Token(Token = "0x4015F6A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x4015F6B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject icon;

	[Token(Token = "0x4015F6C")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel DistanceLabel;

	[Token(Token = "0x4015F6D")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ArrowUp;

	[Token(Token = "0x4015F6E")]
	[FieldOffset(Offset = "0x24")]
	public UISprite ArrowLeft;

	[Token(Token = "0x4015F6F")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ArrowRight;

	[Token(Token = "0x4015F70")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ArrowDown;

	[Token(Token = "0x601676F")]
	[Address(RVA = "0xFEE230", Offset = "0xFEE230", VA = "0xFEE230")]
	public UIHudLockedTargetView()
	{
	}

	[Token(Token = "0x6016770")]
	[Address(RVA = "0xFEE238", Offset = "0xFEE238", VA = "0xFEE238", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016771")]
	[Address(RVA = "0xFEE608", Offset = "0xFEE608", VA = "0xFEE608")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
