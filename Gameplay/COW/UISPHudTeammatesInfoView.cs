using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039DD")]
internal class UISPHudTeammatesInfoView : UIBaseView
{
	[Token(Token = "0x40185A4")]
	[FieldOffset(Offset = "0x14")]
	public UILabel TeamName;

	[Token(Token = "0x40185A5")]
	[FieldOffset(Offset = "0x18")]
	public UISprite TeamIcon;

	[Token(Token = "0x40185A6")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite FakeTeamIcon;

	[Token(Token = "0x40185A7")]
	[FieldOffset(Offset = "0x20")]
	public UISprite TeamColorBG1;

	[Token(Token = "0x40185A8")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TeamColorBG2;

	[Token(Token = "0x40185A9")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TeamKillCount;

	[Token(Token = "0x40185AA")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject KingKillerTeamVFX;

	[Token(Token = "0x40185AB")]
	[FieldOffset(Offset = "0x30")]
	public UILabel TeamRegion;

	[Token(Token = "0x40185AC")]
	[FieldOffset(Offset = "0x34")]
	public UIGrid Grid;

	[Token(Token = "0x40185AD")]
	[FieldOffset(Offset = "0x38")]
	public UISPHudTeammateItem TeammateTemplate;

	[Token(Token = "0x40185AE")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite TeamRegionBg;

	[Token(Token = "0x40185AF")]
	[FieldOffset(Offset = "0x40")]
	public UIGrid MissionGrid;

	[Token(Token = "0x40185B0")]
	[FieldOffset(Offset = "0x44")]
	public UISPHudTeammateMissionItem MissionItem;

	[Token(Token = "0x601713D")]
	[Address(RVA = "0x14A664C", Offset = "0x14A664C", VA = "0x14A664C")]
	public UISPHudTeammatesInfoView()
	{
	}

	[Token(Token = "0x601713E")]
	[Address(RVA = "0x14A6654", Offset = "0x14A6654", VA = "0x14A6654", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601713F")]
	[Address(RVA = "0x14A6B18", Offset = "0x14A6B18", VA = "0x14A6B18")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
