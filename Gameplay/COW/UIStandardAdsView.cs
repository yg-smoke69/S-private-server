using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039E9")]
public class UIStandardAdsView : UIBaseView
{
	[Token(Token = "0x401860D")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Content;

	[Token(Token = "0x401860E")]
	[FieldOffset(Offset = "0x18")]
	public UIPanel Dots;

	[Token(Token = "0x401860F")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid Grid;

	[Token(Token = "0x4018610")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView Scrollview;

	[Token(Token = "0x4018611")]
	[FieldOffset(Offset = "0x24")]
	public UIWrapContent WrapContent;

	[Token(Token = "0x6017161")]
	[Address(RVA = "0x20624EC", Offset = "0x20624EC", VA = "0x20624EC")]
	public UIStandardAdsView()
	{
	}

	[Token(Token = "0x6017162")]
	[Address(RVA = "0x20624F4", Offset = "0x20624F4", VA = "0x20624F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017163")]
	[Address(RVA = "0x206281C", Offset = "0x206281C", VA = "0x206281C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
