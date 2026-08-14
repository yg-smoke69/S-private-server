using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200381A")]
public class UILeaderBoardNewView : UIBaseView
{
	[Token(Token = "0x4016D61")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Profile;

	[Token(Token = "0x4016D62")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Share;

	[Token(Token = "0x4016D63")]
	[FieldOffset(Offset = "0x1C")]
	public Transform LeftContainer;

	[Token(Token = "0x4016D64")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView ContentScrollView;

	[Token(Token = "0x4016D65")]
	[FieldOffset(Offset = "0x24")]
	public UIEasyList ContentList;

	[Token(Token = "0x4016D66")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ListTitleBar;

	[Token(Token = "0x4016D67")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ListTitlePersonKills;

	[Token(Token = "0x4016D68")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ListTitlePersonWins;

	[Token(Token = "0x4016D69")]
	[FieldOffset(Offset = "0x34")]
	public GameObject ListTitleCSPersonKills;

	[Token(Token = "0x4016D6A")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ListTitleGuildHonor;

	[Token(Token = "0x4016D6B")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ListTitleGuildRegionHonor;

	[Token(Token = "0x4016D6C")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ListTitlePersonBadges;

	[Token(Token = "0x4016D6D")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ListTitleTeamScore;

	[Token(Token = "0x4016D6E")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ListTitleTeamKills;

	[Token(Token = "0x4016D6F")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite BG;

	[Token(Token = "0x4016D70")]
	[FieldOffset(Offset = "0x50")]
	public UISprite BG01;

	[Token(Token = "0x4016D71")]
	[FieldOffset(Offset = "0x54")]
	public GameObject SelfInfo;

	[Token(Token = "0x4016D72")]
	[FieldOffset(Offset = "0x58")]
	public UISprite SelfBG;

	[Token(Token = "0x4016D73")]
	[FieldOffset(Offset = "0x5C")]
	public Transform SelfLBContainer;

	[Token(Token = "0x4016D74")]
	[FieldOffset(Offset = "0x60")]
	public UILabel SelfInfoTips;

	[Token(Token = "0x4016D75")]
	[FieldOffset(Offset = "0x64")]
	public UIButton Share2;

	[Token(Token = "0x4016D76")]
	[FieldOffset(Offset = "0x68")]
	public UIButton SeasonTipsBtn;

	[Token(Token = "0x4016D77")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite SeasonIcon;

	[Token(Token = "0x4016D78")]
	[FieldOffset(Offset = "0x70")]
	public UILabel SeasonLabel;

	[Token(Token = "0x4016D79")]
	[FieldOffset(Offset = "0x74")]
	public UISprite UnOpen;

	[Token(Token = "0x4016D7A")]
	[FieldOffset(Offset = "0x78")]
	public UIButton CSSeasonTipsBtn;

	[Token(Token = "0x4016D7B")]
	[FieldOffset(Offset = "0x7C")]
	public UISprite CSSeasonIcon;

	[Token(Token = "0x4016D7C")]
	[FieldOffset(Offset = "0x80")]
	public UILabel CSSeasonLabel;

	[Token(Token = "0x4016D7D")]
	[FieldOffset(Offset = "0x84")]
	public UISprite CSUnOpen;

	[Token(Token = "0x4016D7E")]
	[FieldOffset(Offset = "0x88")]
	public Transform Fliter1;

	[Token(Token = "0x4016D7F")]
	[FieldOffset(Offset = "0x8C")]
	public Transform Fliter2;

	[Token(Token = "0x4016D80")]
	[FieldOffset(Offset = "0x90")]
	public Transform Fliter3;

	[Token(Token = "0x4016D81")]
	[FieldOffset(Offset = "0x94")]
	public UILabel GuildWeekTime;

	[Token(Token = "0x4016D82")]
	[FieldOffset(Offset = "0x98")]
	public GameObject InteractMask;

	[Token(Token = "0x4016D83")]
	[FieldOffset(Offset = "0x9C")]
	public UIWidget ItemLeft;

	[Token(Token = "0x4016D84")]
	[FieldOffset(Offset = "0xA0")]
	public UIWidget ItemRight1;

	[Token(Token = "0x4016D85")]
	[FieldOffset(Offset = "0xA4")]
	public UIWidget ItemRight2;

	[Token(Token = "0x4016D86")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject Loading;

	[Token(Token = "0x4016D87")]
	[FieldOffset(Offset = "0xAC")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x4016D88")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject TipsNoData;

	[Token(Token = "0x6016BF9")]
	[Address(RVA = "0x1AA2CE0", Offset = "0x1AA2CE0", VA = "0x1AA2CE0")]
	public UILeaderBoardNewView()
	{
	}

	[Token(Token = "0x6016BFA")]
	[Address(RVA = "0x1AA2CE8", Offset = "0x1AA2CE8", VA = "0x1AA2CE8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BFB")]
	[Address(RVA = "0x1AA3BCC", Offset = "0x1AA3BCC", VA = "0x1AA3BCC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
