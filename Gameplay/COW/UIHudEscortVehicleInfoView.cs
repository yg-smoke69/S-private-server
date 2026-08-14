using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200364C")]
public class UIHudEscortVehicleInfoView : UIBaseView
{
	[Token(Token = "0x4015C7A")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BodyHPBar;

	[Token(Token = "0x4015C7B")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BodyTipBtn;

	[Token(Token = "0x4015C7C")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite WheelHPBar;

	[Token(Token = "0x4015C7D")]
	[FieldOffset(Offset = "0x20")]
	public UIButton WheelTipBtn;

	[Token(Token = "0x4015C7E")]
	[FieldOffset(Offset = "0x24")]
	public UISprite OKStatus;

	[Token(Token = "0x4015C7F")]
	[FieldOffset(Offset = "0x28")]
	public UIButton StatusTipBtn;

	[Token(Token = "0x4015C80")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite NotOKStatus;

	[Token(Token = "0x6016691")]
	[Address(RVA = "0x1B96EC8", Offset = "0x1B96EC8", VA = "0x1B96EC8")]
	public UIHudEscortVehicleInfoView()
	{
	}

	[Token(Token = "0x6016692")]
	[Address(RVA = "0x1B96ED0", Offset = "0x1B96ED0", VA = "0x1B96ED0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016693")]
	[Address(RVA = "0x1B972B8", Offset = "0x1B972B8", VA = "0x1B972B8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
