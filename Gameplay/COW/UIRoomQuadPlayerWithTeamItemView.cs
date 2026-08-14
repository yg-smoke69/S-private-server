using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003972")]
public class UIRoomQuadPlayerWithTeamItemView : UIBaseView
{
	[Token(Token = "0x40180EF")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIRoomQuadPlayerWithTeamItem;

	[Token(Token = "0x40180F0")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Selected;

	[Token(Token = "0x40180F1")]
	[FieldOffset(Offset = "0x1C")]
	public UIEffectSprite TeamIcon;

	[Token(Token = "0x40180F2")]
	[FieldOffset(Offset = "0x20")]
	public UISprite TeamFakeIcon;

	[Token(Token = "0x40180F3")]
	[FieldOffset(Offset = "0x24")]
	public UILabel TeamName;

	[Token(Token = "0x40180F4")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Id;

	[Token(Token = "0x40180F5")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject PlayerGo1;

	[Token(Token = "0x40180F6")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PlayerGo2;

	[Token(Token = "0x40180F7")]
	[FieldOffset(Offset = "0x34")]
	public GameObject PlayerGo3;

	[Token(Token = "0x40180F8")]
	[FieldOffset(Offset = "0x38")]
	public GameObject PlayerGo4;

	[Token(Token = "0x40180F9")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel TeamScore;

	[Token(Token = "0x6016FFD")]
	[Address(RVA = "0x2BEA908", Offset = "0x2BEA908", VA = "0x2BEA908")]
	public UIRoomQuadPlayerWithTeamItemView()
	{
	}

	[Token(Token = "0x6016FFE")]
	[Address(RVA = "0x2BEA910", Offset = "0x2BEA910", VA = "0x2BEA910", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FFF")]
	[Address(RVA = "0x2BEAE3C", Offset = "0x2BEAE3C", VA = "0x2BEAE3C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
