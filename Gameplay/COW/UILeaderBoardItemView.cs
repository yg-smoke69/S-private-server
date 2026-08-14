using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003819")]
public class UILeaderBoardItemView : UIBaseView
{
	[Token(Token = "0x4016D52")]
	[FieldOffset(Offset = "0x14")]
	public UIButton itembtn;

	[Token(Token = "0x4016D53")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Rank;

	[Token(Token = "0x4016D54")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LastRank;

	[Token(Token = "0x4016D55")]
	[FieldOffset(Offset = "0x20")]
	public GameObject RaiseSprite;

	[Token(Token = "0x4016D56")]
	[FieldOffset(Offset = "0x24")]
	public GameObject declineSprite;

	[Token(Token = "0x4016D57")]
	[FieldOffset(Offset = "0x28")]
	public GameObject keepSprite;

	[Token(Token = "0x4016D58")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel NameContainer;

	[Token(Token = "0x4016D59")]
	[FieldOffset(Offset = "0x30")]
	public UILabel WinTimes;

	[Token(Token = "0x4016D5A")]
	[FieldOffset(Offset = "0x34")]
	public UILabel WinRate;

	[Token(Token = "0x4016D5B")]
	[FieldOffset(Offset = "0x38")]
	public UILabel KillTimes;

	[Token(Token = "0x4016D5C")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel KDRatio;

	[Token(Token = "0x4016D5D")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Score;

	[Token(Token = "0x4016D5E")]
	[FieldOffset(Offset = "0x44")]
	public UISprite CupIcon;

	[Token(Token = "0x4016D5F")]
	[FieldOffset(Offset = "0x48")]
	public UILabel Badges;

	[Token(Token = "0x4016D60")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject EPIcon;

	[Token(Token = "0x6016BF6")]
	[Address(RVA = "0x1A8E904", Offset = "0x1A8E904", VA = "0x1A8E904")]
	public UILeaderBoardItemView()
	{
	}

	[Token(Token = "0x6016BF7")]
	[Address(RVA = "0x1A8E90C", Offset = "0x1A8E90C", VA = "0x1A8E90C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BF8")]
	[Address(RVA = "0x1A8EFC4", Offset = "0x1A8EFC4", VA = "0x1A8EFC4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
