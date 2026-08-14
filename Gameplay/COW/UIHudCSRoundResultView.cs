using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003623")]
public class UIHudCSRoundResultView : UIBaseView
{
	[Token(Token = "0x4015AF2")]
	[FieldOffset(Offset = "0x14")]
	public UISprite wolf;

	[Token(Token = "0x4015AF3")]
	[FieldOffset(Offset = "0x18")]
	public GameObject LeftTeam;

	[Token(Token = "0x4015AF4")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RightTeam;

	[Token(Token = "0x4015AF5")]
	[FieldOffset(Offset = "0x20")]
	public GameObject winSprite;

	[Token(Token = "0x4015AF6")]
	[FieldOffset(Offset = "0x24")]
	public GameObject loseSprite;

	[Token(Token = "0x4015AF7")]
	[FieldOffset(Offset = "0x28")]
	public UILabel roundInfo;

	[Token(Token = "0x4015AF8")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject coinsContainer;

	[Token(Token = "0x4015AF9")]
	[FieldOffset(Offset = "0x30")]
	public UILabel coins;

	[Token(Token = "0x4015AFA")]
	[FieldOffset(Offset = "0x34")]
	public UIGrid bonusGrid;

	[Token(Token = "0x4015AFB")]
	[FieldOffset(Offset = "0x38")]
	public GameObject bonusItem;

	[Token(Token = "0x4015AFC")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel LabelReason;

	[Token(Token = "0x6016616")]
	[Address(RVA = "0x1F1B11C", Offset = "0x1F1B11C", VA = "0x1F1B11C")]
	public UIHudCSRoundResultView()
	{
	}

	[Token(Token = "0x6016617")]
	[Address(RVA = "0x1F1B124", Offset = "0x1F1B124", VA = "0x1F1B124", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016618")]
	[Address(RVA = "0x1F1B644", Offset = "0x1F1B644", VA = "0x1F1B644")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
