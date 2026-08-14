using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003411")]
public class UIChampionshipLeaderBoardItemView : UIBaseView
{
	[Token(Token = "0x40141AB")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x40141AC")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Score;

	[Token(Token = "0x40141AD")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Kills;

	[Token(Token = "0x40141AE")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BG;

	[Token(Token = "0x40141AF")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Profile;

	[Token(Token = "0x40141B0")]
	[FieldOffset(Offset = "0x28")]
	public GameObject FirstCupIcon;

	[Token(Token = "0x40141B1")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject FirstBg;

	[Token(Token = "0x40141B2")]
	[FieldOffset(Offset = "0x30")]
	public GameObject SecondCupIcon;

	[Token(Token = "0x40141B3")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SecondBg;

	[Token(Token = "0x40141B4")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ThirdCupIcon;

	[Token(Token = "0x40141B5")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ThirdBg;

	[Token(Token = "0x40141B6")]
	[FieldOffset(Offset = "0x40")]
	public GameObject SelfBg;

	[Token(Token = "0x40141B7")]
	[FieldOffset(Offset = "0x44")]
	public GameObject OtherRank;

	[Token(Token = "0x40141B8")]
	[FieldOffset(Offset = "0x48")]
	public UILabel rank;

	[Token(Token = "0x6015FE7")]
	[Address(RVA = "0x282F250", Offset = "0x282F250", VA = "0x282F250")]
	public UIChampionshipLeaderBoardItemView()
	{
	}

	[Token(Token = "0x6015FE8")]
	[Address(RVA = "0x282F258", Offset = "0x282F258", VA = "0x282F258", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FE9")]
	[Address(RVA = "0x282F874", Offset = "0x282F874", VA = "0x282F874")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
