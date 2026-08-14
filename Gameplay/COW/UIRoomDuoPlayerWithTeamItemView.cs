using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003963")]
public class UIRoomDuoPlayerWithTeamItemView : UIBaseView
{
	[Token(Token = "0x4018048")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIRoomDuoPlayerWithTeamItem;

	[Token(Token = "0x4018049")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Selected;

	[Token(Token = "0x401804A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TeamName;

	[Token(Token = "0x401804B")]
	[FieldOffset(Offset = "0x20")]
	public UIEffectSprite TeamIcon;

	[Token(Token = "0x401804C")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TeamFakeIcon;

	[Token(Token = "0x401804D")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Id;

	[Token(Token = "0x401804E")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject PlayerGo1;

	[Token(Token = "0x401804F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PlayerGo2;

	[Token(Token = "0x4018050")]
	[FieldOffset(Offset = "0x34")]
	public UILabel TeamScore;

	[Token(Token = "0x6016FD0")]
	[Address(RVA = "0x23C02DC", Offset = "0x23C02DC", VA = "0x23C02DC")]
	public UIRoomDuoPlayerWithTeamItemView()
	{
	}

	[Token(Token = "0x6016FD1")]
	[Address(RVA = "0x23C02E4", Offset = "0x23C02E4", VA = "0x23C02E4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FD2")]
	[Address(RVA = "0x23C0768", Offset = "0x23C0768", VA = "0x23C0768")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
