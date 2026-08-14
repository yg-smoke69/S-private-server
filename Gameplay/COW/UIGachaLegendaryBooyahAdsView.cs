using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003574")]
public class UIGachaLegendaryBooyahAdsView : UIBaseView
{
	[Token(Token = "0x401531D")]
	[FieldOffset(Offset = "0x14")]
	public Transform Content;

	[Token(Token = "0x401531E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject WithAds;

	[Token(Token = "0x401531F")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnAds;

	[Token(Token = "0x4015320")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid Grid;

	[Token(Token = "0x4015321")]
	[FieldOffset(Offset = "0x24")]
	public UIScrollView scrollview;

	[Token(Token = "0x4015322")]
	[FieldOffset(Offset = "0x28")]
	public UIWrapContent WrapContent;

	[Token(Token = "0x4015323")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton PreviewBtn02;

	[Token(Token = "0x4015324")]
	[FieldOffset(Offset = "0x30")]
	public GameObject WithoutAds;

	[Token(Token = "0x4015325")]
	[FieldOffset(Offset = "0x34")]
	public UIButton PreviewBtn01;

	[Token(Token = "0x601640C")]
	[Address(RVA = "0x248B194", Offset = "0x248B194", VA = "0x248B194")]
	public UIGachaLegendaryBooyahAdsView()
	{
	}

	[Token(Token = "0x601640D")]
	[Address(RVA = "0x248B19C", Offset = "0x248B19C", VA = "0x248B19C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601640E")]
	[Address(RVA = "0x248B604", Offset = "0x248B604", VA = "0x248B604")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
