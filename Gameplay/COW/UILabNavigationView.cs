using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003809")]
public class UILabNavigationView : UIBaseView
{
	[Token(Token = "0x4016C64")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView EntranceScrollView;

	[Token(Token = "0x4016C65")]
	[FieldOffset(Offset = "0x18")]
	public UITable EntranceTable;

	[Token(Token = "0x4016C66")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BookEntrance;

	[Token(Token = "0x4016C67")]
	[FieldOffset(Offset = "0x20")]
	public UIButton LegendClothEntrance;

	[Token(Token = "0x4016C68")]
	[FieldOffset(Offset = "0x24")]
	public GameObject HyperBookEntranceTips;

	[Token(Token = "0x4016C69")]
	[FieldOffset(Offset = "0x28")]
	public GameObject LegendClothEntranceTips;

	[Token(Token = "0x4016C6A")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel HyperBookFootnoteLabel;

	[Token(Token = "0x4016C6B")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LegendClothFootnodeLabel;

	[Token(Token = "0x4016C6C")]
	[FieldOffset(Offset = "0x34")]
	public GameObject HyperBookOpenState;

	[Token(Token = "0x4016C6D")]
	[FieldOffset(Offset = "0x38")]
	public GameObject HyperBookNotOpenState;

	[Token(Token = "0x4016C6E")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject LegendClothOpenState;

	[Token(Token = "0x4016C6F")]
	[FieldOffset(Offset = "0x40")]
	public GameObject LegendClothNotOpenState;

	[Token(Token = "0x4016C70")]
	[FieldOffset(Offset = "0x44")]
	public UIButton GuideMask;

	[Token(Token = "0x6016BC6")]
	[Address(RVA = "0x1AE4820", Offset = "0x1AE4820", VA = "0x1AE4820")]
	public UILabNavigationView()
	{
	}

	[Token(Token = "0x6016BC7")]
	[Address(RVA = "0x1AE4828", Offset = "0x1AE4828", VA = "0x1AE4828", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BC8")]
	[Address(RVA = "0x1AE4E08", Offset = "0x1AE4E08", VA = "0x1AE4E08")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
