using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035AB")]
public class UIGameModePeriodicRankInfoView : UIBaseView
{
	[Token(Token = "0x40156DE")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnModelPick;

	[Token(Token = "0x40156DF")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelPeriodicModeName;

	[Token(Token = "0x40156E0")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject openTime;

	[Token(Token = "0x40156E1")]
	[FieldOffset(Offset = "0x20")]
	public UILabel openPeriod;

	[Token(Token = "0x40156E2")]
	[FieldOffset(Offset = "0x24")]
	public GameObject LevelContainer;

	[Token(Token = "0x40156E3")]
	[FieldOffset(Offset = "0x28")]
	public UILabel seasonName;

	[Token(Token = "0x40156E4")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SpriteRankIcon;

	[Token(Token = "0x40156E5")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnRankIcon;

	[Token(Token = "0x40156E6")]
	[FieldOffset(Offset = "0x34")]
	public GameObject GoMaxRank;

	[Token(Token = "0x40156E7")]
	[FieldOffset(Offset = "0x38")]
	public GameObject StarIcon;

	[Token(Token = "0x40156E8")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel MaxRankTxt;

	[Token(Token = "0x40156E9")]
	[FieldOffset(Offset = "0x40")]
	public Transform TransformStar;

	[Token(Token = "0x40156EA")]
	[FieldOffset(Offset = "0x44")]
	public UIGrid GridStar;

	[Token(Token = "0x40156EB")]
	[FieldOffset(Offset = "0x48")]
	public GameObject star1;

	[Token(Token = "0x40156EC")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject star2;

	[Token(Token = "0x40156ED")]
	[FieldOffset(Offset = "0x50")]
	public GameObject star3;

	[Token(Token = "0x40156EE")]
	[FieldOffset(Offset = "0x54")]
	public GameObject star4;

	[Token(Token = "0x40156EF")]
	[FieldOffset(Offset = "0x58")]
	public GameObject star5;

	[Token(Token = "0x40156F0")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject blackstar5;

	[Token(Token = "0x40156F1")]
	[FieldOffset(Offset = "0x60")]
	public GameObject blackstar4;

	[Token(Token = "0x40156F2")]
	[FieldOffset(Offset = "0x64")]
	public GameObject blackstar3;

	[Token(Token = "0x40156F3")]
	[FieldOffset(Offset = "0x68")]
	public GameObject blackstar2;

	[Token(Token = "0x40156F4")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject blackstar1;

	[Token(Token = "0x40156F5")]
	[FieldOffset(Offset = "0x70")]
	public GameObject NoticeBg;

	[Token(Token = "0x40156F6")]
	[FieldOffset(Offset = "0x74")]
	public UILabel LabelNotice;

	[Token(Token = "0x40156F7")]
	[FieldOffset(Offset = "0x78")]
	public GameObject GoDownload;

	[Token(Token = "0x40156F8")]
	[FieldOffset(Offset = "0x7C")]
	public Transform TrRootDownload;

	[Token(Token = "0x40156F9")]
	[FieldOffset(Offset = "0x80")]
	public GameObject GoLevelLimit;

	[Token(Token = "0x40156FA")]
	[FieldOffset(Offset = "0x84")]
	public UILabel LabelLevelLimit;

	[Token(Token = "0x40156FB")]
	[FieldOffset(Offset = "0x88")]
	public UILabel MapMode;

	[Token(Token = "0x40156FC")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton MapChangeButton;

	[Token(Token = "0x40156FD")]
	[FieldOffset(Offset = "0x90")]
	public GameObject UIGameModePeriodicRankInfo;

	[Token(Token = "0x40156FE")]
	[FieldOffset(Offset = "0x94")]
	public Transform OpenTimeAnchorWithoutSeason;

	[Token(Token = "0x40156FF")]
	[FieldOffset(Offset = "0x98")]
	public Transform OpenTimeAnchorWithSeason;

	[Token(Token = "0x60164AF")]
	[Address(RVA = "0x219053C", Offset = "0x219053C", VA = "0x219053C")]
	public UIGameModePeriodicRankInfoView()
	{
	}

	[Token(Token = "0x60164B0")]
	[Address(RVA = "0x2190544", Offset = "0x2190544", VA = "0x2190544", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164B1")]
	[Address(RVA = "0x21911D4", Offset = "0x21911D4", VA = "0x21911D4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
