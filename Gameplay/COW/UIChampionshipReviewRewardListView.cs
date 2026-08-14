using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003419")]
public class UIChampionshipReviewRewardListView : UIBaseView
{
	[Token(Token = "0x40141E0")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Container;

	[Token(Token = "0x40141E1")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnClose;

	[Token(Token = "0x40141E2")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel EmptyTips;

	[Token(Token = "0x40141E3")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ScrollViewTop;

	[Token(Token = "0x40141E4")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ScrollViewBottom;

	[Token(Token = "0x40141E5")]
	[FieldOffset(Offset = "0x28")]
	public UIPanel ScrollPanel;

	[Token(Token = "0x40141E6")]
	[FieldOffset(Offset = "0x2C")]
	public UIEasyList EasyList;

	[Token(Token = "0x40141E7")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ChampionLabel;

	[Token(Token = "0x40141E8")]
	[FieldOffset(Offset = "0x34")]
	public UIGrid Grid;

	[Token(Token = "0x40141E9")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ChampionshipDefaultIcon;

	[Token(Token = "0x40141EA")]
	[FieldOffset(Offset = "0x3C")]
	public UINetworkTexture ChampionshipTexture;

	[Token(Token = "0x6015FFF")]
	[Address(RVA = "0x2839EE8", Offset = "0x2839EE8", VA = "0x2839EE8")]
	public UIChampionshipReviewRewardListView()
	{
	}

	[Token(Token = "0x6016000")]
	[Address(RVA = "0x2839EF0", Offset = "0x2839EF0", VA = "0x2839EF0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016001")]
	[Address(RVA = "0x283A434", Offset = "0x283A434", VA = "0x283A434")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
