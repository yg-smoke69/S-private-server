using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A4E")]
public class UIUUGCardPreViewView : UIBaseView
{
	[Token(Token = "0x4018A6D")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid CardGrid;

	[Token(Token = "0x4018A6E")]
	[FieldOffset(Offset = "0x18")]
	public UIUUgCardView Card1;

	[Token(Token = "0x4018A6F")]
	[FieldOffset(Offset = "0x1C")]
	public UIUUgCardView Card2;

	[Token(Token = "0x4018A70")]
	[FieldOffset(Offset = "0x20")]
	public UIUUgCardView Card3;

	[Token(Token = "0x4018A71")]
	[FieldOffset(Offset = "0x24")]
	public UIUUgCardView Card4;

	[Token(Token = "0x6017290")]
	[Address(RVA = "0xF4470C", Offset = "0xF4470C", VA = "0xF4470C")]
	public UIUUGCardPreViewView()
	{
	}

	[Token(Token = "0x6017291")]
	[Address(RVA = "0xF44714", Offset = "0xF44714", VA = "0xF44714", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017292")]
	[Address(RVA = "0xF44A3C", Offset = "0xF44A3C", VA = "0xF44A3C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
