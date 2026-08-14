using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038A4")]
public class UIMemberShipCheckInView : UIBaseView
{
	[Token(Token = "0x401769F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ReissueBtn;

	[Token(Token = "0x40176A0")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid ItemGrid;

	[Token(Token = "0x40176A1")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton CheckInBtn;

	[Token(Token = "0x40176A2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Remain;

	[Token(Token = "0x40176A3")]
	[FieldOffset(Offset = "0x24")]
	public UILabel RemainLabel;

	[Token(Token = "0x40176A4")]
	[FieldOffset(Offset = "0x28")]
	public UIButton RemainTipBtn;

	[Token(Token = "0x40176A5")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject StoreContainer;

	[Token(Token = "0x40176A6")]
	[FieldOffset(Offset = "0x30")]
	public UITable Table;

	[Token(Token = "0x40176A7")]
	[FieldOffset(Offset = "0x34")]
	public UICountDownLabel CountDownLabel;

	[Token(Token = "0x6016D97")]
	[Address(RVA = "0x269C3E4", Offset = "0x269C3E4", VA = "0x269C3E4")]
	public UIMemberShipCheckInView()
	{
	}

	[Token(Token = "0x6016D98")]
	[Address(RVA = "0x269C3EC", Offset = "0x269C3EC", VA = "0x269C3EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D99")]
	[Address(RVA = "0x269C87C", Offset = "0x269C87C", VA = "0x269C87C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
