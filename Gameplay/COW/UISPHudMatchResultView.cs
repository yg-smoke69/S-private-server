using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039C3")]
public class UISPHudMatchResultView : UIBaseView
{
	[Token(Token = "0x4018476")]
	[FieldOffset(Offset = "0x14")]
	public UIButton PrevBtn;

	[Token(Token = "0x4018477")]
	[FieldOffset(Offset = "0x18")]
	public UILabel MatchMapTxt;

	[Token(Token = "0x4018478")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel MatchModeTxt;

	[Token(Token = "0x4018479")]
	[FieldOffset(Offset = "0x20")]
	public UITexture bg;

	[Token(Token = "0x401847A")]
	[FieldOffset(Offset = "0x24")]
	public UITexture LocalBG;

	[Token(Token = "0x401847B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject infoPanel;

	[Token(Token = "0x401847C")]
	[FieldOffset(Offset = "0x2C")]
	public UITable LeftTable;

	[Token(Token = "0x401847D")]
	[FieldOffset(Offset = "0x30")]
	public UIScrollView RightScrollView;

	[Token(Token = "0x401847E")]
	[FieldOffset(Offset = "0x34")]
	public TweenPosition RightScrollViewTWPosition;

	[Token(Token = "0x401847F")]
	[FieldOffset(Offset = "0x38")]
	public TweenAlpha RightScrollViewAlpha;

	[Token(Token = "0x4018480")]
	[FieldOffset(Offset = "0x3C")]
	public UIPanel RightScrollViewPanel;

	[Token(Token = "0x4018481")]
	[FieldOffset(Offset = "0x40")]
	public UITable RightTable;

	[Token(Token = "0x4018482")]
	[FieldOffset(Offset = "0x44")]
	public GameObject infoPanelQuad;

	[Token(Token = "0x4018483")]
	[FieldOffset(Offset = "0x48")]
	public UITable LeftTableQuad;

	[Token(Token = "0x4018484")]
	[FieldOffset(Offset = "0x4C")]
	public UIScrollView RightScrollViewQuad;

	[Token(Token = "0x4018485")]
	[FieldOffset(Offset = "0x50")]
	public TweenAlpha RightScrollViewQuadTWAlpha;

	[Token(Token = "0x4018486")]
	[FieldOffset(Offset = "0x54")]
	public TweenPosition RightScrollViewQuadTWPosition;

	[Token(Token = "0x4018487")]
	[FieldOffset(Offset = "0x58")]
	public UIPanel RightScrollViewQuadPanel;

	[Token(Token = "0x4018488")]
	[FieldOffset(Offset = "0x5C")]
	public UITable RightTableQuad;

	[Token(Token = "0x60170F0")]
	[Address(RVA = "0x1D21C6C", Offset = "0x1D21C6C", VA = "0x1D21C6C")]
	public UISPHudMatchResultView()
	{
	}

	[Token(Token = "0x60170F1")]
	[Address(RVA = "0x1D21C74", Offset = "0x1D21C74", VA = "0x1D21C74", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170F2")]
	[Address(RVA = "0x1D22318", Offset = "0x1D22318", VA = "0x1D22318")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
