using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034F5")]
public class UIDownloadCentreView : UIBaseView
{
	[Token(Token = "0x4014D40")]
	[FieldOffset(Offset = "0x14")]
	public UIButton DownloadAll;

	[Token(Token = "0x4014D41")]
	[FieldOffset(Offset = "0x18")]
	public UILabel NetStateLabel;

	[Token(Token = "0x4014D42")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel HintLabel;

	[Token(Token = "0x4014D43")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView TabScroller;

	[Token(Token = "0x4014D44")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid TabGrid;

	[Token(Token = "0x4014D45")]
	[FieldOffset(Offset = "0x28")]
	public UIScrollView SimpleScroll;

	[Token(Token = "0x4014D46")]
	[FieldOffset(Offset = "0x2C")]
	public UIEasyList SimpleGrid;

	[Token(Token = "0x4014D47")]
	[FieldOffset(Offset = "0x30")]
	public UIScrollView ComplexScroll;

	[Token(Token = "0x4014D48")]
	[FieldOffset(Offset = "0x34")]
	public UIEasyList ComplexGrid;

	[Token(Token = "0x4014D49")]
	[FieldOffset(Offset = "0x38")]
	public GameObject SimpleScrollArrow;

	[Token(Token = "0x4014D4A")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ComplexScrollArrow;

	[Token(Token = "0x601628F")]
	[Address(RVA = "0x276954C", Offset = "0x276954C", VA = "0x276954C")]
	public UIDownloadCentreView()
	{
	}

	[Token(Token = "0x6016290")]
	[Address(RVA = "0x2769554", Offset = "0x2769554", VA = "0x2769554", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016291")]
	[Address(RVA = "0x2769AA4", Offset = "0x2769AA4", VA = "0x2769AA4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
