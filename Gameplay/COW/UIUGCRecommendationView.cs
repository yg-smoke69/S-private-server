using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A45")]
public class UIUGCRecommendationView : UIBaseView
{
	[Token(Token = "0x40189F0")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView CenterSV;

	[Token(Token = "0x40189F1")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget CenterScrollable;

	[Token(Token = "0x40189F2")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget ContentContainer;

	[Token(Token = "0x40189F3")]
	[FieldOffset(Offset = "0x20")]
	public UITable Table;

	[Token(Token = "0x40189F4")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid HotGrid;

	[Token(Token = "0x40189F5")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid SelfdomGrid;

	[Token(Token = "0x40189F6")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject EditorRecom;

	[Token(Token = "0x40189F7")]
	[FieldOffset(Offset = "0x30")]
	public UINetworkTexture CDNMapIcon;

	[Token(Token = "0x40189F8")]
	[FieldOffset(Offset = "0x34")]
	public UILabel MainTitle;

	[Token(Token = "0x40189F9")]
	[FieldOffset(Offset = "0x38")]
	public UILabel MainDesc;

	[Token(Token = "0x40189FA")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton MainRecMoreBtn;

	[Token(Token = "0x40189FB")]
	[FieldOffset(Offset = "0x40")]
	public UIButton HotMoreBtn;

	[Token(Token = "0x40189FC")]
	[FieldOffset(Offset = "0x44")]
	public UIButton RecomRefreshBtn;

	[Token(Token = "0x40189FD")]
	[FieldOffset(Offset = "0x48")]
	public UIButton SelfdomMoreBtn;

	[Token(Token = "0x40189FE")]
	[FieldOffset(Offset = "0x4C")]
	public TweenRotation SelfdomRefreshIcon;

	[Token(Token = "0x40189FF")]
	[FieldOffset(Offset = "0x50")]
	public GameObject SelfdomTitleContainer;

	[Token(Token = "0x4018A00")]
	[FieldOffset(Offset = "0x54")]
	public GameObject SelfdomEmpty;

	[Token(Token = "0x4018A01")]
	[FieldOffset(Offset = "0x58")]
	public GameObject HotEmpty;

	[Token(Token = "0x4018A02")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject DotNode;

	[Token(Token = "0x4018A03")]
	[FieldOffset(Offset = "0x60")]
	public UIGrid DotGrid;

	[Token(Token = "0x4018A04")]
	[FieldOffset(Offset = "0x64")]
	public GameObject DotNodeItem;

	[Token(Token = "0x4018A05")]
	[FieldOffset(Offset = "0x68")]
	public GameObject SideRecItem;

	[Token(Token = "0x4018A06")]
	[FieldOffset(Offset = "0x6C")]
	public UIWrapContent WrapContent;

	[Token(Token = "0x4018A07")]
	[FieldOffset(Offset = "0x70")]
	public UICenterOnChild UICenterOnChild;

	[Token(Token = "0x4018A08")]
	[FieldOffset(Offset = "0x74")]
	public UIScrollView SideScrollview;

	[Token(Token = "0x6017275")]
	[Address(RVA = "0xF37594", Offset = "0xF37594", VA = "0xF37594")]
	public UIUGCRecommendationView()
	{
	}

	[Token(Token = "0x6017276")]
	[Address(RVA = "0xF3759C", Offset = "0xF3759C", VA = "0xF3759C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017277")]
	[Address(RVA = "0xF37FF0", Offset = "0xF37FF0", VA = "0xF37FF0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
