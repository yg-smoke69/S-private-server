using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200362C")]
public class UIHudCSSORoundStartView : UIBaseView
{
	[Token(Token = "0x4015B4E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject RoundStartContainer;

	[Token(Token = "0x4015B4F")]
	[FieldOffset(Offset = "0x18")]
	public UILabel RoundNum;

	[Token(Token = "0x4015B50")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel GamezoneName;

	[Token(Token = "0x4015B51")]
	[FieldOffset(Offset = "0x20")]
	public UILabel MyTeamRank;

	[Token(Token = "0x4015B52")]
	[FieldOffset(Offset = "0x24")]
	public UILabel OppoTeamRank;

	[Token(Token = "0x4015B53")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NormalNum;

	[Token(Token = "0x4015B54")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject SpecialNum;

	[Token(Token = "0x4015B55")]
	[FieldOffset(Offset = "0x30")]
	public UISprite PlayerNum;

	[Token(Token = "0x4015B56")]
	[FieldOffset(Offset = "0x34")]
	public UISprite PlayerNum2;

	[Token(Token = "0x4015B57")]
	[FieldOffset(Offset = "0x38")]
	public UIHudCSSOTeamInfoView MyFaction;

	[Token(Token = "0x4015B58")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject MyFactionHP;

	[Token(Token = "0x4015B59")]
	[FieldOffset(Offset = "0x40")]
	public UILabel MyTeamLabel;

	[Token(Token = "0x4015B5A")]
	[FieldOffset(Offset = "0x44")]
	public UIHudCSSOTeamInfoView OppoFaction;

	[Token(Token = "0x4015B5B")]
	[FieldOffset(Offset = "0x48")]
	public GameObject OppoFactionHP;

	[Token(Token = "0x4015B5C")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject NoEnemy;

	[Token(Token = "0x4015B5D")]
	[FieldOffset(Offset = "0x50")]
	public UILabel OppoTeamLabel;

	[Token(Token = "0x6016631")]
	[Address(RVA = "0x2137054", Offset = "0x2137054", VA = "0x2137054")]
	public UIHudCSSORoundStartView()
	{
	}

	[Token(Token = "0x6016632")]
	[Address(RVA = "0x213705C", Offset = "0x213705C", VA = "0x213705C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016633")]
	[Address(RVA = "0x213775C", Offset = "0x213775C", VA = "0x213775C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
