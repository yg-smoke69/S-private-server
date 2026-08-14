using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A89")]
public class UIWorkShopMapInfoDetailView : UIBaseView
{
	[Token(Token = "0x4018E67")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemContentBtn;

	[Token(Token = "0x4018E68")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView MapScrollView;

	[Token(Token = "0x4018E69")]
	[FieldOffset(Offset = "0x1C")]
	public UIWrapContent WrapContent;

	[Token(Token = "0x4018E6A")]
	[FieldOffset(Offset = "0x20")]
	public UICenterOnChild CenterOnChildComponent;

	[Token(Token = "0x4018E6B")]
	[FieldOffset(Offset = "0x24")]
	public UIPanel DotObj;

	[Token(Token = "0x4018E6C")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid DotGrid;

	[Token(Token = "0x4018E6D")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite DotNodeItem;

	[Token(Token = "0x6017341")]
	[Address(RVA = "0x1A1BC1C", Offset = "0x1A1BC1C", VA = "0x1A1BC1C")]
	public UIWorkShopMapInfoDetailView()
	{
	}

	[Token(Token = "0x6017342")]
	[Address(RVA = "0x1A1BC24", Offset = "0x1A1BC24", VA = "0x1A1BC24", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017343")]
	[Address(RVA = "0x1A1C00C", Offset = "0x1A1C00C", VA = "0x1A1C00C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
