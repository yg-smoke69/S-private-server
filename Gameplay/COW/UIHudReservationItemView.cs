using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003710")]
public class UIHudReservationItemView : UIBaseView
{
	[Token(Token = "0x40163D2")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIHudReservationItem;

	[Token(Token = "0x40163D3")]
	[FieldOffset(Offset = "0x18")]
	public GameObject UIHudReservationContent;

	[Token(Token = "0x40163D4")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Name;

	[Token(Token = "0x40163D5")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Rank;

	[Token(Token = "0x40163D6")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Status;

	[Token(Token = "0x40163D7")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Selection;

	[Token(Token = "0x40163D8")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton RejectBtn;

	[Token(Token = "0x40163D9")]
	[FieldOffset(Offset = "0x30")]
	public UIButton AgreeBtn;

	[Token(Token = "0x60168DB")]
	[Address(RVA = "0x13F1DC8", Offset = "0x13F1DC8", VA = "0x13F1DC8")]
	public UIHudReservationItemView()
	{
	}

	[Token(Token = "0x60168DC")]
	[Address(RVA = "0x13F1DD0", Offset = "0x13F1DD0", VA = "0x13F1DD0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168DD")]
	[Address(RVA = "0x13F21F4", Offset = "0x13F21F4", VA = "0x13F21F4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
