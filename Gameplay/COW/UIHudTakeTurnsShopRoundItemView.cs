using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003765")]
public class UIHudTakeTurnsShopRoundItemView : UIBaseView
{
	[Token(Token = "0x401669F")]
	[FieldOffset(Offset = "0x14")]
	public GameObject SplitLineLeft;

	[Token(Token = "0x40166A0")]
	[FieldOffset(Offset = "0x18")]
	public TweenScale RoundIcon;

	[Token(Token = "0x40166A1")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Self;

	[Token(Token = "0x40166A2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Opponent;

	[Token(Token = "0x40166A3")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Final;

	[Token(Token = "0x40166A4")]
	[FieldOffset(Offset = "0x28")]
	public UILabel RoundIndex;

	[Token(Token = "0x40166A5")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject SplitLineRight;

	[Token(Token = "0x60169DA")]
	[Address(RVA = "0x179118C", Offset = "0x179118C", VA = "0x179118C")]
	public UIHudTakeTurnsShopRoundItemView()
	{
	}

	[Token(Token = "0x60169DB")]
	[Address(RVA = "0x1791194", Offset = "0x1791194", VA = "0x1791194", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169DC")]
	[Address(RVA = "0x1791540", Offset = "0x1791540", VA = "0x1791540")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
