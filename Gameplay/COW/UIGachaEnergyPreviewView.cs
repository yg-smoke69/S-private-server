using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200356E")]
public class UIGachaEnergyPreviewView : UIBaseView
{
	[Token(Token = "0x40152D0")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView GachaPreviewScrollView;

	[Token(Token = "0x40152D1")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList Grid;

	[Token(Token = "0x40152D2")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BGClickLottery;

	[Token(Token = "0x40152D3")]
	[FieldOffset(Offset = "0x20")]
	public UIButton btnclose;

	[Token(Token = "0x40152D4")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnProbability;

	[Token(Token = "0x60163FA")]
	[Address(RVA = "0x2475068", Offset = "0x2475068", VA = "0x2475068")]
	public UIGachaEnergyPreviewView()
	{
	}

	[Token(Token = "0x60163FB")]
	[Address(RVA = "0x2475070", Offset = "0x2475070", VA = "0x2475070", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60163FC")]
	[Address(RVA = "0x2475398", Offset = "0x2475398", VA = "0x2475398")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
