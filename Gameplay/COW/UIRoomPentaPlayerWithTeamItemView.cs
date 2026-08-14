using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200396C")]
public class UIRoomPentaPlayerWithTeamItemView : UIBaseView
{
	[Token(Token = "0x40180B2")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIRoomPentaPlayerWithTeamItem;

	[Token(Token = "0x40180B3")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Selected;

	[Token(Token = "0x40180B4")]
	[FieldOffset(Offset = "0x1C")]
	public UIEffectSprite TeamIcon;

	[Token(Token = "0x40180B5")]
	[FieldOffset(Offset = "0x20")]
	public UISprite TeamFakeIcon;

	[Token(Token = "0x40180B6")]
	[FieldOffset(Offset = "0x24")]
	public UILabel TeamName;

	[Token(Token = "0x40180B7")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Id;

	[Token(Token = "0x40180B8")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject PlayerGo1;

	[Token(Token = "0x40180B9")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PlayerGo2;

	[Token(Token = "0x40180BA")]
	[FieldOffset(Offset = "0x34")]
	public GameObject PlayerGo3;

	[Token(Token = "0x40180BB")]
	[FieldOffset(Offset = "0x38")]
	public GameObject PlayerGo4;

	[Token(Token = "0x40180BC")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject PlayerGo5;

	[Token(Token = "0x6016FEB")]
	[Address(RVA = "0x2BDF518", Offset = "0x2BDF518", VA = "0x2BDF518")]
	public UIRoomPentaPlayerWithTeamItemView()
	{
	}

	[Token(Token = "0x6016FEC")]
	[Address(RVA = "0x2BDF520", Offset = "0x2BDF520", VA = "0x2BDF520", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FED")]
	[Address(RVA = "0x2BDFA40", Offset = "0x2BDFA40", VA = "0x2BDFA40")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
