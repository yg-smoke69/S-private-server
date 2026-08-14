using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003387")]
public class LadderMatchLobbyEntryView : UIBaseView
{
	[Token(Token = "0x4013A10")]
	[FieldOffset(Offset = "0x14")]
	public UISprite LadderMatchLevelSprite;

	[Token(Token = "0x4013A11")]
	[FieldOffset(Offset = "0x18")]
	public UIButton LadderMatchEntryBtn;

	[Token(Token = "0x4013A12")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject FireEffect;

	[Token(Token = "0x4013A13")]
	[FieldOffset(Offset = "0x20")]
	public GameObject FireParticle_Low;

	[Token(Token = "0x4013A14")]
	[FieldOffset(Offset = "0x24")]
	public GameObject FireParticle_High;

	[Token(Token = "0x4013A15")]
	[FieldOffset(Offset = "0x28")]
	public GameObject FirstWinTip;

	[Token(Token = "0x4013A16")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite AvalibleRankCardIconTip;

	[Token(Token = "0x4013A17")]
	[FieldOffset(Offset = "0x30")]
	public UILabel SeasonName;

	[Token(Token = "0x4013A18")]
	[FieldOffset(Offset = "0x34")]
	public GameObject BRStarContainer;

	[Token(Token = "0x4013A19")]
	[FieldOffset(Offset = "0x38")]
	public UILadderMatchHeroicLevelView HeroicLevelView;

	[Token(Token = "0x6015E4C")]
	[Address(RVA = "0x1EF25CC", Offset = "0x1EF25CC", VA = "0x1EF25CC")]
	public LadderMatchLobbyEntryView()
	{
	}

	[Token(Token = "0x6015E4D")]
	[Address(RVA = "0x1EF25D4", Offset = "0x1EF25D4", VA = "0x1EF25D4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E4E")]
	[Address(RVA = "0x1EF2AA0", Offset = "0x1EF2AA0", VA = "0x1EF2AA0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
