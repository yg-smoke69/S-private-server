using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003656")]
public class UIHudFlightRoamDownView : UIBaseView
{
	[Token(Token = "0x4015CE2")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnDown;

	[Token(Token = "0x4015CE3")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BtnSprite;

	[Token(Token = "0x60166AF")]
	[Address(RVA = "0x1BB21A4", Offset = "0x1BB21A4", VA = "0x1BB21A4")]
	public UIHudFlightRoamDownView()
	{
	}

	[Token(Token = "0x60166B0")]
	[Address(RVA = "0x1BB21AC", Offset = "0x1BB21AC", VA = "0x1BB21AC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166B1")]
	[Address(RVA = "0x1BB23B4", Offset = "0x1BB23B4", VA = "0x1BB23B4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
