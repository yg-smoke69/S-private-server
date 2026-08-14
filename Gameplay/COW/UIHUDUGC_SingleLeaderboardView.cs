using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037AC")]
public class UIHUDUGC_SingleLeaderboardView : UIBaseView
{
	[Token(Token = "0x40168B3")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView TeamScrollView;

	[Token(Token = "0x40168B4")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList TeamGrid;

	[Token(Token = "0x40168B5")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton SpaceBtn;

	[Token(Token = "0x40168B6")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid TitleGrid;

	[Token(Token = "0x40168B7")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelTemp;

	[Token(Token = "0x40168B8")]
	[FieldOffset(Offset = "0x28")]
	public UILabel PlayerTitle;

	[Token(Token = "0x40168B9")]
	[FieldOffset(Offset = "0x2C")]
	public Transform selfRank;

	[Token(Token = "0x6016AAF")]
	[Address(RVA = "0x292159C", Offset = "0x292159C", VA = "0x292159C")]
	public UIHUDUGC_SingleLeaderboardView()
	{
	}

	[Token(Token = "0x6016AB0")]
	[Address(RVA = "0x29215A4", Offset = "0x29215A4", VA = "0x29215A4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AB1")]
	[Address(RVA = "0x2921964", Offset = "0x2921964", VA = "0x2921964")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
