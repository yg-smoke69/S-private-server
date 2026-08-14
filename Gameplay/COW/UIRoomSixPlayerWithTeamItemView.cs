using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003976")]
public class UIRoomSixPlayerWithTeamItemView : UIBaseView
{
	[Token(Token = "0x401810C")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIRoomSixPlayerWithTeamItem;

	[Token(Token = "0x401810D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Selected;

	[Token(Token = "0x401810E")]
	[FieldOffset(Offset = "0x1C")]
	public UIEffectSprite TeamIcon;

	[Token(Token = "0x401810F")]
	[FieldOffset(Offset = "0x20")]
	public UISprite TeamFakeIcon;

	[Token(Token = "0x4018110")]
	[FieldOffset(Offset = "0x24")]
	public UILabel TeamName;

	[Token(Token = "0x4018111")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Id;

	[Token(Token = "0x4018112")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject PlayerGo1;

	[Token(Token = "0x4018113")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PlayerGo2;

	[Token(Token = "0x4018114")]
	[FieldOffset(Offset = "0x34")]
	public GameObject PlayerGo3;

	[Token(Token = "0x4018115")]
	[FieldOffset(Offset = "0x38")]
	public GameObject PlayerGo4;

	[Token(Token = "0x4018116")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject PlayerGo5;

	[Token(Token = "0x4018117")]
	[FieldOffset(Offset = "0x40")]
	public GameObject PlayerGo6;

	[Token(Token = "0x6017009")]
	[Address(RVA = "0x2BEED98", Offset = "0x2BEED98", VA = "0x2BEED98")]
	public UIRoomSixPlayerWithTeamItemView()
	{
	}

	[Token(Token = "0x601700A")]
	[Address(RVA = "0x2BEEDA0", Offset = "0x2BEEDA0", VA = "0x2BEEDA0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601700B")]
	[Address(RVA = "0x2BEF314", Offset = "0x2BEF314", VA = "0x2BEF314")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
