using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200362B")]
public class UIHudCSSORoundResultView : UIBaseView
{
	[Token(Token = "0x4015B3B")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Coins;

	[Token(Token = "0x4015B3C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject WinSprite;

	[Token(Token = "0x4015B3D")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject LoseSprite;

	[Token(Token = "0x4015B3E")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid BonusGrid;

	[Token(Token = "0x4015B3F")]
	[FieldOffset(Offset = "0x24")]
	public GameObject BonusItem;

	[Token(Token = "0x4015B40")]
	[FieldOffset(Offset = "0x28")]
	public UILabel MvpPlayer;

	[Token(Token = "0x4015B41")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject MVPIcon;

	[Token(Token = "0x4015B42")]
	[FieldOffset(Offset = "0x30")]
	public GameObject HoldBG;

	[Token(Token = "0x4015B43")]
	[FieldOffset(Offset = "0x34")]
	public UIHudCSSOTeamInfoView OppoFaction;

	[Token(Token = "0x4015B44")]
	[FieldOffset(Offset = "0x38")]
	public GameObject OppoFactionHP;

	[Token(Token = "0x4015B45")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject NoEnemy;

	[Token(Token = "0x4015B46")]
	[FieldOffset(Offset = "0x40")]
	public GameObject OppoFactionEliminate;

	[Token(Token = "0x4015B47")]
	[FieldOffset(Offset = "0x44")]
	public GameObject OppoTeam;

	[Token(Token = "0x4015B48")]
	[FieldOffset(Offset = "0x48")]
	public UILabel OppoTeamLabel;

	[Token(Token = "0x4015B49")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject OppoWin;

	[Token(Token = "0x4015B4A")]
	[FieldOffset(Offset = "0x50")]
	public UIHudCSSOTeamInfoView MyFaction;

	[Token(Token = "0x4015B4B")]
	[FieldOffset(Offset = "0x54")]
	public GameObject MyFactionEliminate;

	[Token(Token = "0x4015B4C")]
	[FieldOffset(Offset = "0x58")]
	public UILabel MyTeamLabel;

	[Token(Token = "0x4015B4D")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject MyWin;

	[Token(Token = "0x601662E")]
	[Address(RVA = "0x2135444", Offset = "0x2135444", VA = "0x2135444")]
	public UIHudCSSORoundResultView()
	{
	}

	[Token(Token = "0x601662F")]
	[Address(RVA = "0x213544C", Offset = "0x213544C", VA = "0x213544C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016630")]
	[Address(RVA = "0x2135C24", Offset = "0x2135C24", VA = "0x2135C24")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
