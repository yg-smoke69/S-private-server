using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003818")]
public class UILeaderBoardItemNewView : UIBaseView
{
	[Token(Token = "0x4016D2D")]
	[FieldOffset(Offset = "0x14")]
	public UIButton itembtn;

	[Token(Token = "0x4016D2E")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget Widget;

	[Token(Token = "0x4016D2F")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Bg;

	[Token(Token = "0x4016D30")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Bg01;

	[Token(Token = "0x4016D31")]
	[FieldOffset(Offset = "0x24")]
	public UILabel RankLabel;

	[Token(Token = "0x4016D32")]
	[FieldOffset(Offset = "0x28")]
	public UISprite CupIcon;

	[Token(Token = "0x4016D33")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite CupIconTop;

	[Token(Token = "0x4016D34")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PersonKills;

	[Token(Token = "0x4016D35")]
	[FieldOffset(Offset = "0x34")]
	public GameObject PersonKillsBaseProfile;

	[Token(Token = "0x4016D36")]
	[FieldOffset(Offset = "0x38")]
	public UILabel PersonKillsKills;

	[Token(Token = "0x4016D37")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel PersonKillsCasualKills;

	[Token(Token = "0x4016D38")]
	[FieldOffset(Offset = "0x40")]
	public GameObject PersonWins;

	[Token(Token = "0x4016D39")]
	[FieldOffset(Offset = "0x44")]
	public GameObject PersonWinsBaseProfile;

	[Token(Token = "0x4016D3A")]
	[FieldOffset(Offset = "0x48")]
	public UILabel PersonWinsWins;

	[Token(Token = "0x4016D3B")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel PersonWinsCasualWins;

	[Token(Token = "0x4016D3C")]
	[FieldOffset(Offset = "0x50")]
	public GameObject PersonBadges;

	[Token(Token = "0x4016D3D")]
	[FieldOffset(Offset = "0x54")]
	public GameObject PersonBadgesBaseProfile;

	[Token(Token = "0x4016D3E")]
	[FieldOffset(Offset = "0x58")]
	public UILabel PersonBadgesBadges;

	[Token(Token = "0x4016D3F")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject PersonBadgesIcon;

	[Token(Token = "0x4016D40")]
	[FieldOffset(Offset = "0x60")]
	public UILabel PersonBadgesRegion;

	[Token(Token = "0x4016D41")]
	[FieldOffset(Offset = "0x64")]
	public GameObject GuildHonor;

	[Token(Token = "0x4016D42")]
	[FieldOffset(Offset = "0x68")]
	public UILabel GuildHonorName;

	[Token(Token = "0x4016D43")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite GuildHonorLogo;

	[Token(Token = "0x4016D44")]
	[FieldOffset(Offset = "0x70")]
	public UILabel GuildHonorHonor;

	[Token(Token = "0x4016D45")]
	[FieldOffset(Offset = "0x74")]
	public GameObject GuildRegionHonor;

	[Token(Token = "0x4016D46")]
	[FieldOffset(Offset = "0x78")]
	public UILabel GuildRegionHonorName;

	[Token(Token = "0x4016D47")]
	[FieldOffset(Offset = "0x7C")]
	public UISprite GuildRegionHonorLogo;

	[Token(Token = "0x4016D48")]
	[FieldOffset(Offset = "0x80")]
	public UILabel GuildRegionHonorRegion;

	[Token(Token = "0x4016D49")]
	[FieldOffset(Offset = "0x84")]
	public UILabel GuildRegionHonorHonor;

	[Token(Token = "0x4016D4A")]
	[FieldOffset(Offset = "0x88")]
	public GameObject TeamScore;

	[Token(Token = "0x4016D4B")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject TeamScoreBaseProfile;

	[Token(Token = "0x4016D4C")]
	[FieldOffset(Offset = "0x90")]
	public UILabel TeamScoreScore;

	[Token(Token = "0x4016D4D")]
	[FieldOffset(Offset = "0x94")]
	public GameObject TeamKills;

	[Token(Token = "0x4016D4E")]
	[FieldOffset(Offset = "0x98")]
	public GameObject TeamKillsBaseProfile;

	[Token(Token = "0x4016D4F")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel TeamKillsKills;

	[Token(Token = "0x4016D50")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel TeamKillsKD;

	[Token(Token = "0x4016D51")]
	[FieldOffset(Offset = "0xA4")]
	public UISprite HighLight;

	[Token(Token = "0x6016BF3")]
	[Address(RVA = "0x1A8DA68", Offset = "0x1A8DA68", VA = "0x1A8DA68")]
	public UILeaderBoardItemNewView()
	{
	}

	[Token(Token = "0x6016BF4")]
	[Address(RVA = "0x1A8DA70", Offset = "0x1A8DA70", VA = "0x1A8DA70", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BF5")]
	[Address(RVA = "0x1A8E8FC", Offset = "0x1A8E8FC", VA = "0x1A8E8FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
