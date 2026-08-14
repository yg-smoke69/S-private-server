using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039D9")]
public class UISPHudTeamAccStatsItemView : UIBaseView
{
	[Token(Token = "0x401855E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject DeadBg;

	[Token(Token = "0x401855F")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget TeamIconGo;

	[Token(Token = "0x4018560")]
	[FieldOffset(Offset = "0x1C")]
	public UIEffectSprite TeamIcon;

	[Token(Token = "0x4018561")]
	[FieldOffset(Offset = "0x20")]
	public UISprite TeamFakeIcon;

	[Token(Token = "0x4018562")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ParticleGo;

	[Token(Token = "0x4018563")]
	[FieldOffset(Offset = "0x28")]
	public GameObject GameObjectDownGo;

	[Token(Token = "0x4018564")]
	[FieldOffset(Offset = "0x2C")]
	public TweenAlpha TweenAlphaDownGo;

	[Token(Token = "0x4018565")]
	[FieldOffset(Offset = "0x30")]
	public UILabel DownLbl;

	[Token(Token = "0x4018566")]
	[FieldOffset(Offset = "0x34")]
	public GameObject GameObjectUpGo;

	[Token(Token = "0x4018567")]
	[FieldOffset(Offset = "0x38")]
	public TweenAlpha TweenAlphaUpGo;

	[Token(Token = "0x4018568")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel UpLbl;

	[Token(Token = "0x4018569")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Name;

	[Token(Token = "0x401856A")]
	[FieldOffset(Offset = "0x44")]
	public UISprite ActiveP1;

	[Token(Token = "0x401856B")]
	[FieldOffset(Offset = "0x48")]
	public UISprite ActiveP2;

	[Token(Token = "0x401856C")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite ActiveP3;

	[Token(Token = "0x401856D")]
	[FieldOffset(Offset = "0x50")]
	public UISprite ActiveP4;

	[Token(Token = "0x401856E")]
	[FieldOffset(Offset = "0x54")]
	public UISprite DeadP1;

	[Token(Token = "0x401856F")]
	[FieldOffset(Offset = "0x58")]
	public UISprite DeadP2;

	[Token(Token = "0x4018570")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite DeadP3;

	[Token(Token = "0x4018571")]
	[FieldOffset(Offset = "0x60")]
	public UISprite DeadP4;

	[Token(Token = "0x4018572")]
	[FieldOffset(Offset = "0x64")]
	public UILabel RankLbl;

	[Token(Token = "0x4018573")]
	[FieldOffset(Offset = "0x68")]
	public UILabel Score;

	[Token(Token = "0x4018574")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel KillCnt;

	[Token(Token = "0x4018575")]
	[FieldOffset(Offset = "0x70")]
	public GameObject Poison;

	[Token(Token = "0x4018576")]
	[FieldOffset(Offset = "0x74")]
	public GameObject KillOfKing;

	[Token(Token = "0x4018577")]
	[FieldOffset(Offset = "0x78")]
	public GameObject TeamAce;

	[Token(Token = "0x4018578")]
	[FieldOffset(Offset = "0x7C")]
	public UISprite ActiveP5;

	[Token(Token = "0x4018579")]
	[FieldOffset(Offset = "0x80")]
	public UISprite ActiveP6;

	[Token(Token = "0x401857A")]
	[FieldOffset(Offset = "0x84")]
	public UISprite DeadP5;

	[Token(Token = "0x401857B")]
	[FieldOffset(Offset = "0x88")]
	public UISprite DeadP6;

	[Token(Token = "0x6017131")]
	[Address(RVA = "0x149249C", Offset = "0x149249C", VA = "0x149249C")]
	public UISPHudTeamAccStatsItemView()
	{
	}

	[Token(Token = "0x6017132")]
	[Address(RVA = "0x14924A4", Offset = "0x14924A4", VA = "0x14924A4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017133")]
	[Address(RVA = "0x14930D8", Offset = "0x14930D8", VA = "0x14930D8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
