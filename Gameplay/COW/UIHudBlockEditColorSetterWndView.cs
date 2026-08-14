using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035EA")]
public class UIHudBlockEditColorSetterWndView : UIBaseView
{
	[Token(Token = "0x401594D")]
	[FieldOffset(Offset = "0x14")]
	public UITexture HSVBoard;

	[Token(Token = "0x401594E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BoardPoint;

	[Token(Token = "0x401594F")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject PresetColor;

	[Token(Token = "0x4015950")]
	[FieldOffset(Offset = "0x20")]
	public UISprite CurrentColor;

	[Token(Token = "0x4015951")]
	[FieldOffset(Offset = "0x24")]
	public UITexture HSVSliderTexture;

	[Token(Token = "0x4015952")]
	[FieldOffset(Offset = "0x28")]
	public UISlider HSVSliderBar;

	[Token(Token = "0x4015953")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid Grid;

	[Token(Token = "0x4015954")]
	[FieldOffset(Offset = "0x30")]
	public UIButton Mask;

	[Token(Token = "0x4015955")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Content;

	[Token(Token = "0x601656C")]
	[Address(RVA = "0x1E03374", Offset = "0x1E03374", VA = "0x1E03374")]
	public UIHudBlockEditColorSetterWndView()
	{
	}

	[Token(Token = "0x601656D")]
	[Address(RVA = "0x1E0337C", Offset = "0x1E0337C", VA = "0x1E0337C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601656E")]
	[Address(RVA = "0x1E03800", Offset = "0x1E03800", VA = "0x1E03800")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
