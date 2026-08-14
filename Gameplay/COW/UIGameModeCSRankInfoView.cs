using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035A6")]
public class UIGameModeCSRankInfoView : UIBaseView
{
	[Token(Token = "0x40156A1")]
	[FieldOffset(Offset = "0x14")]
	public UISprite bg;

	[Token(Token = "0x40156A2")]
	[FieldOffset(Offset = "0x18")]
	public GameObject CSRank_Reward;

	[Token(Token = "0x40156A3")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject NormalView;

	[Token(Token = "0x40156A4")]
	[FieldOffset(Offset = "0x20")]
	public UILabel gameMode;

	[Token(Token = "0x40156A5")]
	[FieldOffset(Offset = "0x24")]
	public UILabel mapMode;

	[Token(Token = "0x40156A6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject openTime;

	[Token(Token = "0x40156A7")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel openPeriod;

	[Token(Token = "0x40156A8")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget RankGuideInfo;

	[Token(Token = "0x40156A9")]
	[FieldOffset(Offset = "0x34")]
	public GameObject LevelContainer;

	[Token(Token = "0x40156AA")]
	[FieldOffset(Offset = "0x38")]
	public UISprite CSMatchLevelSprite;

	[Token(Token = "0x40156AB")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton BtnCSRank;

	[Token(Token = "0x40156AC")]
	[FieldOffset(Offset = "0x40")]
	public GameObject StarIcon;

	[Token(Token = "0x40156AD")]
	[FieldOffset(Offset = "0x44")]
	public UILabel MaxRankTxt;

	[Token(Token = "0x40156AE")]
	[FieldOffset(Offset = "0x48")]
	public Transform star;

	[Token(Token = "0x40156AF")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject star1;

	[Token(Token = "0x40156B0")]
	[FieldOffset(Offset = "0x50")]
	public GameObject star2;

	[Token(Token = "0x40156B1")]
	[FieldOffset(Offset = "0x54")]
	public GameObject star3;

	[Token(Token = "0x40156B2")]
	[FieldOffset(Offset = "0x58")]
	public GameObject star4;

	[Token(Token = "0x40156B3")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject star5;

	[Token(Token = "0x40156B4")]
	[FieldOffset(Offset = "0x60")]
	public GameObject blackstar5;

	[Token(Token = "0x40156B5")]
	[FieldOffset(Offset = "0x64")]
	public GameObject blackstar4;

	[Token(Token = "0x40156B6")]
	[FieldOffset(Offset = "0x68")]
	public GameObject blackstar3;

	[Token(Token = "0x40156B7")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject blackstar2;

	[Token(Token = "0x40156B8")]
	[FieldOffset(Offset = "0x70")]
	public GameObject blackstar1;

	[Token(Token = "0x40156B9")]
	[FieldOffset(Offset = "0x74")]
	public UILabel seasonName;

	[Token(Token = "0x40156BA")]
	[FieldOffset(Offset = "0x78")]
	public UISprite Tag;

	[Token(Token = "0x60164A0")]
	[Address(RVA = "0x246871C", Offset = "0x246871C", VA = "0x246871C")]
	public UIGameModeCSRankInfoView()
	{
	}

	[Token(Token = "0x60164A1")]
	[Address(RVA = "0x2468724", Offset = "0x2468724", VA = "0x2468724", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164A2")]
	[Address(RVA = "0x2469150", Offset = "0x2469150", VA = "0x2469150")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
