using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003657")]
public class UIHudFlightRoamUpView : UIBaseView
{
	[Token(Token = "0x4015CE4")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnUp;

	[Token(Token = "0x4015CE5")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BtnSprite;

	[Token(Token = "0x60166B2")]
	[Address(RVA = "0x1BB25F8", Offset = "0x1BB25F8", VA = "0x1BB25F8")]
	public UIHudFlightRoamUpView()
	{
	}

	[Token(Token = "0x60166B3")]
	[Address(RVA = "0x1BB2600", Offset = "0x1BB2600", VA = "0x1BB2600", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166B4")]
	[Address(RVA = "0x1BB2808", Offset = "0x1BB2808", VA = "0x1BB2808")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
