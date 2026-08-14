using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003702")]
public class UIHudReaperTransformView : UIBaseView
{
	[Token(Token = "0x401636F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ClickBtn;

	[Token(Token = "0x4016370")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Icon;

	[Token(Token = "0x4016371")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Progress;

	[Token(Token = "0x4016372")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Halo;

	[Token(Token = "0x4016373")]
	[FieldOffset(Offset = "0x24")]
	public GameObject HaloSecond;

	[Token(Token = "0x4016374")]
	[FieldOffset(Offset = "0x28")]
	public GameObject HaloThird;

	[Token(Token = "0x4016375")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject HaloFull;

	[Token(Token = "0x60168B1")]
	[Address(RVA = "0x13DA864", Offset = "0x13DA864", VA = "0x13DA864")]
	public UIHudReaperTransformView()
	{
	}

	[Token(Token = "0x60168B2")]
	[Address(RVA = "0x13DA86C", Offset = "0x13DA86C", VA = "0x13DA86C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168B3")]
	[Address(RVA = "0x13DAC24", Offset = "0x13DAC24", VA = "0x13DAC24")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
