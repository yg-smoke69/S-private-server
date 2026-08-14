using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034C0")]
public class UIDetailTipsInGameView : UIBaseView
{
	[Token(Token = "0x4014A0E")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Mask;

	[Token(Token = "0x4014A0F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Content;

	[Token(Token = "0x4014A10")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BG;

	[Token(Token = "0x4014A11")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Description;

	[Token(Token = "0x60161F4")]
	[Address(RVA = "0x2D83FEC", Offset = "0x2D83FEC", VA = "0x2D83FEC")]
	public UIDetailTipsInGameView()
	{
	}

	[Token(Token = "0x60161F5")]
	[Address(RVA = "0x2D83FF4", Offset = "0x2D83FF4", VA = "0x2D83FF4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161F6")]
	[Address(RVA = "0x2D842B0", Offset = "0x2D842B0", VA = "0x2D842B0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
