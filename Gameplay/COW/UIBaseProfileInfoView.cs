using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033E9")]
public class UIBaseProfileInfoView : UIBaseView
{
	[Token(Token = "0x4013F14")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIBaseProfileInfo;

	[Token(Token = "0x4013F15")]
	[FieldOffset(Offset = "0x18")]
	public UILabel BadgeCntLabel;

	[Token(Token = "0x4013F16")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite EPBadge;

	[Token(Token = "0x4013F17")]
	[FieldOffset(Offset = "0x20")]
	public UIEffectSprite bg;

	[Token(Token = "0x4013F18")]
	[FieldOffset(Offset = "0x24")]
	public GameObject fakeBg;

	[Token(Token = "0x4013F19")]
	[FieldOffset(Offset = "0x28")]
	public UISprite gray;

	[Token(Token = "0x4013F1A")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton headbtn;

	[Token(Token = "0x4013F1B")]
	[FieldOffset(Offset = "0x30")]
	public UINetworkTexture HeadIcon;

	[Token(Token = "0x4013F1C")]
	[FieldOffset(Offset = "0x34")]
	public UIEffectSprite HeadSprite;

	[Token(Token = "0x4013F1D")]
	[FieldOffset(Offset = "0x38")]
	public GameObject FakeSprite;

	[Token(Token = "0x4013F1E")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject infoContainer;

	[Token(Token = "0x4013F1F")]
	[FieldOffset(Offset = "0x40")]
	public UISprite CSRank;

	[Token(Token = "0x4013F20")]
	[FieldOffset(Offset = "0x44")]
	public UISprite MaxCSStar;

	[Token(Token = "0x4013F21")]
	[FieldOffset(Offset = "0x48")]
	public UILabel MaxCSRankTxt;

	[Token(Token = "0x4013F22")]
	[FieldOffset(Offset = "0x4C")]
	public UIGrid CSGrid;

	[Token(Token = "0x4013F23")]
	[FieldOffset(Offset = "0x50")]
	public UISprite star1;

	[Token(Token = "0x4013F24")]
	[FieldOffset(Offset = "0x54")]
	public UISprite star2;

	[Token(Token = "0x4013F25")]
	[FieldOffset(Offset = "0x58")]
	public UISprite star3;

	[Token(Token = "0x4013F26")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite star4;

	[Token(Token = "0x4013F27")]
	[FieldOffset(Offset = "0x60")]
	public UISprite star5;

	[Token(Token = "0x4013F28")]
	[FieldOffset(Offset = "0x64")]
	public UISprite blackstar1;

	[Token(Token = "0x4013F29")]
	[FieldOffset(Offset = "0x68")]
	public UISprite blackstar2;

	[Token(Token = "0x4013F2A")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite blackstar3;

	[Token(Token = "0x4013F2B")]
	[FieldOffset(Offset = "0x70")]
	public UISprite blackstar4;

	[Token(Token = "0x4013F2C")]
	[FieldOffset(Offset = "0x74")]
	public UISprite blackstar5;

	[Token(Token = "0x4013F2D")]
	[FieldOffset(Offset = "0x78")]
	public UISprite rank;

	[Token(Token = "0x4013F2E")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject NickNameWithGender;

	[Token(Token = "0x4013F2F")]
	[FieldOffset(Offset = "0x80")]
	public UISprite PlayerSex;

	[Token(Token = "0x4013F30")]
	[FieldOffset(Offset = "0x84")]
	public UILabel NickNameWithGenderLabel;

	[Token(Token = "0x4013F31")]
	[FieldOffset(Offset = "0x88")]
	public UILabel nickname;

	[Token(Token = "0x4013F32")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel level;

	[Token(Token = "0x4013F33")]
	[FieldOffset(Offset = "0x90")]
	public UILabel clanName;

	[Token(Token = "0x4013F34")]
	[FieldOffset(Offset = "0x94")]
	public UISprite platformIcon;

	[Token(Token = "0x4013F35")]
	[FieldOffset(Offset = "0x98")]
	public UILabel online;

	[Token(Token = "0x4013F36")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject LadderEffect;

	[Token(Token = "0x4013F37")]
	[FieldOffset(Offset = "0xA0")]
	public UISprite Favor;

	[Token(Token = "0x4013F38")]
	[FieldOffset(Offset = "0xA4")]
	public UISprite FavorIcon;

	[Token(Token = "0x4013F39")]
	[FieldOffset(Offset = "0xA8")]
	public UISprite PinIcon;

	[Token(Token = "0x4013F3A")]
	[FieldOffset(Offset = "0xAC")]
	public UIButton BtnPin;

	[Token(Token = "0x4013F3B")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite BtnPinIcon;

	[Token(Token = "0x4013F3C")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject Icon_Celebrity;

	[Token(Token = "0x4013F3D")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite Relationship;

	[Token(Token = "0x4013F3E")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject BRStarContainer;

	[Token(Token = "0x4013F3F")]
	[FieldOffset(Offset = "0xC0")]
	public UILadderMatchHeroicLevelView HeroicLevelView;

	[Token(Token = "0x4013F40")]
	[FieldOffset(Offset = "0xC4")]
	public UISprite rankBR;

	[Token(Token = "0x6015F6F")]
	[Address(RVA = "0x1410730", Offset = "0x1410730", VA = "0x1410730")]
	public UIBaseProfileInfoView()
	{
	}

	[Token(Token = "0x6015F70")]
	[Address(RVA = "0x1410738", Offset = "0x1410738", VA = "0x1410738", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F71")]
	[Address(RVA = "0x141190C", Offset = "0x141190C", VA = "0x141190C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
