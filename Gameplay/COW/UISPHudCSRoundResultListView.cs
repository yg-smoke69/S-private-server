using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039BE")]
public class UISPHudCSRoundResultListView : UIBaseView
{
	[Token(Token = "0x4018442")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition TWTitle;

	[Token(Token = "0x4018443")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid ItemListGrid;

	[Token(Token = "0x4018444")]
	[FieldOffset(Offset = "0x1C")]
	public TweenPosition TWGrid;

	[Token(Token = "0x4018445")]
	[FieldOffset(Offset = "0x20")]
	public UISprite GlassBG;

	[Token(Token = "0x60170E1")]
	[Address(RVA = "0x1D18BD8", Offset = "0x1D18BD8", VA = "0x1D18BD8")]
	public UISPHudCSRoundResultListView()
	{
	}

	[Token(Token = "0x60170E2")]
	[Address(RVA = "0x1D18BE0", Offset = "0x1D18BE0", VA = "0x1D18BE0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170E3")]
	[Address(RVA = "0x1D18DE8", Offset = "0x1D18DE8", VA = "0x1D18DE8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
