using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003757")]
public class UIHudSkySurfingView : UIBaseView
{
	[Token(Token = "0x4016655")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnSkySurfing;

	[Token(Token = "0x4016656")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ActionNameTxt;

	[Token(Token = "0x4016657")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BGSkySurfing;

	[Token(Token = "0x4016658")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SkySurfingIcon;

	[Token(Token = "0x60169B0")]
	[Address(RVA = "0x1FDC8F4", Offset = "0x1FDC8F4", VA = "0x1FDC8F4")]
	public UIHudSkySurfingView()
	{
	}

	[Token(Token = "0x60169B1")]
	[Address(RVA = "0x1FDC8FC", Offset = "0x1FDC8FC", VA = "0x1FDC8FC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169B2")]
	[Address(RVA = "0x1FDCBC4", Offset = "0x1FDCBC4", VA = "0x1FDCBC4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
