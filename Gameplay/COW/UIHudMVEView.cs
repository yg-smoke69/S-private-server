using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036B8")]
public class UIHudMVEView : UIBaseView
{
	[Token(Token = "0x40160F1")]
	[FieldOffset(Offset = "0x14")]
	public UISprite EnergyBar;

	[Token(Token = "0x40160F2")]
	[FieldOffset(Offset = "0x18")]
	public UISprite EnergyBar2;

	[Token(Token = "0x40160F3")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnMVE;

	[Token(Token = "0x40160F4")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BtnSprite;

	[Token(Token = "0x60167D5")]
	[Address(RVA = "0xFF8B0C", Offset = "0xFF8B0C", VA = "0xFF8B0C")]
	public UIHudMVEView()
	{
	}

	[Token(Token = "0x60167D6")]
	[Address(RVA = "0xFF8B14", Offset = "0xFF8B14", VA = "0xFF8B14", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167D7")]
	[Address(RVA = "0xFF8DDC", Offset = "0xFF8DDC", VA = "0xFF8DDC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
