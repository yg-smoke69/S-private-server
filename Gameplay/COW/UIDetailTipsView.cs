using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034C2")]
public class UIDetailTipsView : UIBaseView
{
	[Token(Token = "0x4014A15")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Mask;

	[Token(Token = "0x4014A16")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Content;

	[Token(Token = "0x4014A17")]
	[FieldOffset(Offset = "0x1C")]
	public UITable ContentTable;

	[Token(Token = "0x4014A18")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ItemInfo;

	[Token(Token = "0x4014A19")]
	[FieldOffset(Offset = "0x24")]
	public GameObject UIStandardItemMini;

	[Token(Token = "0x4014A1A")]
	[FieldOffset(Offset = "0x28")]
	public UISprite TypeIcon;

	[Token(Token = "0x4014A1B")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel ItemName;

	[Token(Token = "0x4014A1C")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ItemTime;

	[Token(Token = "0x4014A1D")]
	[FieldOffset(Offset = "0x34")]
	public UISprite TimeIcon;

	[Token(Token = "0x4014A1E")]
	[FieldOffset(Offset = "0x38")]
	public UILabel ItemCount;

	[Token(Token = "0x4014A1F")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite IPTag;

	[Token(Token = "0x4014A20")]
	[FieldOffset(Offset = "0x40")]
	public GameObject FakeItemInfo;

	[Token(Token = "0x4014A21")]
	[FieldOffset(Offset = "0x44")]
	public UISprite FakeItemIcon;

	[Token(Token = "0x4014A22")]
	[FieldOffset(Offset = "0x48")]
	public UILabel FakeItemName;

	[Token(Token = "0x4014A23")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite FakeItemBg;

	[Token(Token = "0x4014A24")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Line0;

	[Token(Token = "0x4014A25")]
	[FieldOffset(Offset = "0x54")]
	public UIWidget DescriptionContainer;

	[Token(Token = "0x4014A26")]
	[FieldOffset(Offset = "0x58")]
	public UILabel Description;

	[Token(Token = "0x4014A27")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject CountDownContent;

	[Token(Token = "0x4014A28")]
	[FieldOffset(Offset = "0x60")]
	public Transform CountDown;

	[Token(Token = "0x4014A29")]
	[FieldOffset(Offset = "0x64")]
	public GameObject Line1;

	[Token(Token = "0x4014A2A")]
	[FieldOffset(Offset = "0x68")]
	public GameObject GainObj;

	[Token(Token = "0x4014A2B")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel Gain;

	[Token(Token = "0x4014A2C")]
	[FieldOffset(Offset = "0x70")]
	public UIGrid TipsGrid;

	[Token(Token = "0x4014A2D")]
	[FieldOffset(Offset = "0x74")]
	public UIButton BgBtn;

	[Token(Token = "0x4014A2E")]
	[FieldOffset(Offset = "0x78")]
	public UISprite BG;

	[Token(Token = "0x60161FA")]
	[Address(RVA = "0x2D84AA4", Offset = "0x2D84AA4", VA = "0x2D84AA4")]
	public UIDetailTipsView()
	{
	}

	[Token(Token = "0x60161FB")]
	[Address(RVA = "0x2D84AAC", Offset = "0x2D84AAC", VA = "0x2D84AAC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161FC")]
	[Address(RVA = "0x2D8552C", Offset = "0x2D8552C", VA = "0x2D8552C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
