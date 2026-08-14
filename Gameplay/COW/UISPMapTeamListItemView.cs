using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039E5")]
public class UISPMapTeamListItemView : UIBaseView
{
	[Token(Token = "0x40185EB")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Rank;

	[Token(Token = "0x40185EC")]
	[FieldOffset(Offset = "0x18")]
	public GameObject RankBGOrdinary;

	[Token(Token = "0x40185ED")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RankBGGold;

	[Token(Token = "0x40185EE")]
	[FieldOffset(Offset = "0x20")]
	public GameObject RankBGSilver;

	[Token(Token = "0x40185EF")]
	[FieldOffset(Offset = "0x24")]
	public GameObject RankBGCopper;

	[Token(Token = "0x40185F0")]
	[FieldOffset(Offset = "0x28")]
	public UISprite TeamIcon;

	[Token(Token = "0x40185F1")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TeamShortName;

	[Token(Token = "0x40185F2")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid PlayerNameList;

	[Token(Token = "0x40185F3")]
	[FieldOffset(Offset = "0x34")]
	public UILabel PlayerName_1;

	[Token(Token = "0x40185F4")]
	[FieldOffset(Offset = "0x38")]
	public UILabel PlayerName_2;

	[Token(Token = "0x40185F5")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel PlayerName_3;

	[Token(Token = "0x40185F6")]
	[FieldOffset(Offset = "0x40")]
	public UILabel PlayerName_4;

	[Token(Token = "0x40185F7")]
	[FieldOffset(Offset = "0x44")]
	public GameObject TeamDeadMask;

	[Token(Token = "0x6017155")]
	[Address(RVA = "0x14A91F0", Offset = "0x14A91F0", VA = "0x14A91F0")]
	public UISPMapTeamListItemView()
	{
	}

	[Token(Token = "0x6017156")]
	[Address(RVA = "0x14A91F8", Offset = "0x14A91F8", VA = "0x14A91F8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017157")]
	[Address(RVA = "0x14A97E4", Offset = "0x14A97E4", VA = "0x14A97E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
