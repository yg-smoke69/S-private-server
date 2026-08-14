using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A44")]
public class UIUGCRecommendationPopView : UIBaseView
{
	[Token(Token = "0x40189DF")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BlackBG;

	[Token(Token = "0x40189E0")]
	[FieldOffset(Offset = "0x18")]
	public Transform WindowContainer;

	[Token(Token = "0x40189E1")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView MapScrollView;

	[Token(Token = "0x40189E2")]
	[FieldOffset(Offset = "0x20")]
	public UITable ContentTable;

	[Token(Token = "0x40189E3")]
	[FieldOffset(Offset = "0x24")]
	public GameObject EditRecHead;

	[Token(Token = "0x40189E4")]
	[FieldOffset(Offset = "0x28")]
	public UILabel EditRecMainTile;

	[Token(Token = "0x40189E5")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel EditRecSideTille;

	[Token(Token = "0x40189E6")]
	[FieldOffset(Offset = "0x30")]
	public UINetworkTexture EditRecCDNIcon;

	[Token(Token = "0x40189E7")]
	[FieldOffset(Offset = "0x34")]
	public UILabel EditRecDesc;

	[Token(Token = "0x40189E8")]
	[FieldOffset(Offset = "0x38")]
	public GameObject HotHead;

	[Token(Token = "0x40189E9")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject SelfdomHead;

	[Token(Token = "0x40189EA")]
	[FieldOffset(Offset = "0x40")]
	public UILabel HotHeadMainTile;

	[Token(Token = "0x40189EB")]
	[FieldOffset(Offset = "0x44")]
	public UILabel HotHeadSideTile;

	[Token(Token = "0x40189EC")]
	[FieldOffset(Offset = "0x48")]
	public UILabel SelfdomHeadMainTile;

	[Token(Token = "0x40189ED")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton RecomRefreshBtn;

	[Token(Token = "0x40189EE")]
	[FieldOffset(Offset = "0x50")]
	public TweenRotation SelfdomRefreshIcon;

	[Token(Token = "0x40189EF")]
	[FieldOffset(Offset = "0x54")]
	public UIGrid Grid;

	[Token(Token = "0x6017272")]
	[Address(RVA = "0xF36E28", Offset = "0xF36E28", VA = "0xF36E28")]
	public UIUGCRecommendationPopView()
	{
	}

	[Token(Token = "0x6017273")]
	[Address(RVA = "0xF36E30", Offset = "0xF36E30", VA = "0xF36E30", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017274")]
	[Address(RVA = "0xF3758C", Offset = "0xF3758C", VA = "0xF3758C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
