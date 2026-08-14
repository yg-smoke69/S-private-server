using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003384")]
public class LadderMatchGrandMasterPopView : UIBaseView
{
	[Token(Token = "0x40139F1")]
	[FieldOffset(Offset = "0x14")]
	public UISprite PopOverBg;

	[Token(Token = "0x40139F2")]
	[FieldOffset(Offset = "0x18")]
	public UILabel GrandMasterStar;

	[Token(Token = "0x40139F3")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite RankIcon;

	[Token(Token = "0x40139F4")]
	[FieldOffset(Offset = "0x20")]
	public UILabel StarNumLabel;

	[Token(Token = "0x40139F5")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid RankList;

	[Token(Token = "0x40139F6")]
	[FieldOffset(Offset = "0x28")]
	public UILadderMatchPopoverView RankObjectView;

	[Token(Token = "0x40139F7")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget RankWidget;

	[Token(Token = "0x40139F8")]
	[FieldOffset(Offset = "0x30")]
	public UISprite RankBg;

	[Token(Token = "0x6015E43")]
	[Address(RVA = "0x1EF16E4", Offset = "0x1EF16E4", VA = "0x1EF16E4")]
	public LadderMatchGrandMasterPopView()
	{
	}

	[Token(Token = "0x6015E44")]
	[Address(RVA = "0x1EF16EC", Offset = "0x1EF16EC", VA = "0x1EF16EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E45")]
	[Address(RVA = "0x1EF1B34", Offset = "0x1EF1B34", VA = "0x1EF1B34")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
