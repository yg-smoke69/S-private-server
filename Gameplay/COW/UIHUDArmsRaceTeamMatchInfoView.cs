using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035D6")]
public class UIHUDArmsRaceTeamMatchInfoView : UIBaseView
{
	[Token(Token = "0x40158D2")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid MaxLevelGrid;

	[Token(Token = "0x40158D3")]
	[FieldOffset(Offset = "0x18")]
	public UISprite MaxTenSprite;

	[Token(Token = "0x40158D4")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite MaxUnitSprite;

	[Token(Token = "0x40158D5")]
	[FieldOffset(Offset = "0x20")]
	public UILabel BattleTimeLabel;

	[Token(Token = "0x40158D6")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SelfWeaponIcon;

	[Token(Token = "0x40158D7")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid SelfLevelGrid;

	[Token(Token = "0x40158D8")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SelfTenSprite;

	[Token(Token = "0x40158D9")]
	[FieldOffset(Offset = "0x30")]
	public UISprite SelfUnitSprite;

	[Token(Token = "0x40158DA")]
	[FieldOffset(Offset = "0x34")]
	public UISprite OpponenWeaponIcon;

	[Token(Token = "0x40158DB")]
	[FieldOffset(Offset = "0x38")]
	public UILabel OpponenArmLevel;

	[Token(Token = "0x40158DC")]
	[FieldOffset(Offset = "0x3C")]
	public UIGrid OpponenLevelGrid;

	[Token(Token = "0x40158DD")]
	[FieldOffset(Offset = "0x40")]
	public UISprite OpponenTenSprite;

	[Token(Token = "0x40158DE")]
	[FieldOffset(Offset = "0x44")]
	public UISprite OpponenUintSprite;

	[Token(Token = "0x40158DF")]
	[FieldOffset(Offset = "0x48")]
	public UIButton OpenScoreBoardBtn;

	[Token(Token = "0x6016530")]
	[Address(RVA = "0x1672A98", Offset = "0x1672A98", VA = "0x1672A98")]
	public UIHUDArmsRaceTeamMatchInfoView()
	{
	}

	[Token(Token = "0x6016531")]
	[Address(RVA = "0x1672AA0", Offset = "0x1672AA0", VA = "0x1672AA0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016532")]
	[Address(RVA = "0x1673128", Offset = "0x1673128", VA = "0x1673128")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
