using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035D2")]
public class UIHUDArmsRaceMatchInfoView : UIBaseView
{
	[Token(Token = "0x40158AD")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid MaxLevelGrid;

	[Token(Token = "0x40158AE")]
	[FieldOffset(Offset = "0x18")]
	public UISprite MaxTenSprite;

	[Token(Token = "0x40158AF")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite MaxUnitSprite;

	[Token(Token = "0x40158B0")]
	[FieldOffset(Offset = "0x20")]
	public UILabel BattleTimeLabel;

	[Token(Token = "0x40158B1")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SelfWeaponIcon;

	[Token(Token = "0x40158B2")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid SelfLevelGrid;

	[Token(Token = "0x40158B3")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SelfTenSprite;

	[Token(Token = "0x40158B4")]
	[FieldOffset(Offset = "0x30")]
	public UISprite SelfUnitSprite;

	[Token(Token = "0x40158B5")]
	[FieldOffset(Offset = "0x34")]
	public UILabel SelfRank;

	[Token(Token = "0x40158B6")]
	[FieldOffset(Offset = "0x38")]
	public GameObject RankOneVFX;

	[Token(Token = "0x40158B7")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite TopWeaponIcon;

	[Token(Token = "0x40158B8")]
	[FieldOffset(Offset = "0x40")]
	public UILabel TopArmLevel;

	[Token(Token = "0x40158B9")]
	[FieldOffset(Offset = "0x44")]
	public UIGrid TopLevelGrid;

	[Token(Token = "0x40158BA")]
	[FieldOffset(Offset = "0x48")]
	public UISprite TopTenSprite;

	[Token(Token = "0x40158BB")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite TopUintSprite;

	[Token(Token = "0x6016524")]
	[Address(RVA = "0x1670378", Offset = "0x1670378", VA = "0x1670378")]
	public UIHUDArmsRaceMatchInfoView()
	{
	}

	[Token(Token = "0x6016525")]
	[Address(RVA = "0x1670380", Offset = "0x1670380", VA = "0x1670380", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016526")]
	[Address(RVA = "0x1670A5C", Offset = "0x1670A5C", VA = "0x1670A5C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
