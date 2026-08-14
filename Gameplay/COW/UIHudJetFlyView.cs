using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200368A")]
public class UIHudJetFlyView : UIBaseView
{
	[Token(Token = "0x4015EEB")]
	[FieldOffset(Offset = "0x14")]
	public UISprite EnergyBar;

	[Token(Token = "0x4015EEC")]
	[FieldOffset(Offset = "0x18")]
	public UISprite EnergyBar2;

	[Token(Token = "0x4015EED")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnJetFly;

	[Token(Token = "0x4015EEE")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BtnSprite;

	[Token(Token = "0x601674B")]
	[Address(RVA = "0x20B25DC", Offset = "0x20B25DC", VA = "0x20B25DC")]
	public UIHudJetFlyView()
	{
	}

	[Token(Token = "0x601674C")]
	[Address(RVA = "0x20B25E4", Offset = "0x20B25E4", VA = "0x20B25E4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601674D")]
	[Address(RVA = "0x20B28AC", Offset = "0x20B28AC", VA = "0x20B28AC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
