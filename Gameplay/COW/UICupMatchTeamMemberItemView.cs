using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034A8")]
public class UICupMatchTeamMemberItemView : UIBaseView
{
	[Token(Token = "0x40148DF")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Item;

	[Token(Token = "0x40148E0")]
	[FieldOffset(Offset = "0x18")]
	public Transform BaseProfile;

	[Token(Token = "0x40148E1")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel State;

	[Token(Token = "0x40148E2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Captain;

	[Token(Token = "0x40148E3")]
	[FieldOffset(Offset = "0x24")]
	public UISprite bg;

	[Token(Token = "0x40148E4")]
	[FieldOffset(Offset = "0x28")]
	public UIButton Tier;

	[Token(Token = "0x40148E5")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TireLabel;

	[Token(Token = "0x40148E6")]
	[FieldOffset(Offset = "0x30")]
	public UIButton TicketBtn;

	[Token(Token = "0x40148E7")]
	[FieldOffset(Offset = "0x34")]
	public UISprite TicketIcon;

	[Token(Token = "0x40148E8")]
	[FieldOffset(Offset = "0x38")]
	public GameObject NoTicket;

	[Token(Token = "0x40148E9")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Change;

	[Token(Token = "0x60161AC")]
	[Address(RVA = "0x11DE454", Offset = "0x11DE454", VA = "0x11DE454")]
	public UICupMatchTeamMemberItemView()
	{
	}

	[Token(Token = "0x60161AD")]
	[Address(RVA = "0x11DE45C", Offset = "0x11DE45C", VA = "0x11DE45C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161AE")]
	[Address(RVA = "0x11DE978", Offset = "0x11DE978", VA = "0x11DE978")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
