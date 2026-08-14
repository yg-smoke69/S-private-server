using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003782")]
public class UIHUDTrapActionView : UIBaseView
{
	[Token(Token = "0x40167E8")]
	[FieldOffset(Offset = "0x14")]
	public GameObject InTrapRoot;

	[Token(Token = "0x40167E9")]
	[FieldOffset(Offset = "0x18")]
	public UILabel InTrapCountDownLabel;

	[Token(Token = "0x40167EA")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite InTrapCountDownSprite;

	[Token(Token = "0x40167EB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject RescureTrapRoot;

	[Token(Token = "0x40167EC")]
	[FieldOffset(Offset = "0x24")]
	public UIButton RescureBtn;

	[Token(Token = "0x40167ED")]
	[FieldOffset(Offset = "0x28")]
	public GameObject SpriteOther;

	[Token(Token = "0x40167EE")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject RescureCountDownRoot;

	[Token(Token = "0x40167EF")]
	[FieldOffset(Offset = "0x30")]
	public UILabel RescureCountDownLabel;

	[Token(Token = "0x6016A31")]
	[Address(RVA = "0x22231A8", Offset = "0x22231A8", VA = "0x22231A8")]
	public UIHUDTrapActionView()
	{
	}

	[Token(Token = "0x6016A32")]
	[Address(RVA = "0x22231B0", Offset = "0x22231B0", VA = "0x22231B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A33")]
	[Address(RVA = "0x22235C8", Offset = "0x22235C8", VA = "0x22235C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
