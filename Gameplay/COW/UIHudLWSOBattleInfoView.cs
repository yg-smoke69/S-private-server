using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036A0")]
public class UIHudLWSOBattleInfoView : UIBaseView
{
	[Token(Token = "0x4015FA9")]
	[FieldOffset(Offset = "0x14")]
	public Transform Info;

	[Token(Token = "0x4015FAA")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4015FAB")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid ItemGrid;

	[Token(Token = "0x4015FAC")]
	[FieldOffset(Offset = "0x20")]
	public UIButton OpenArrowBtn;

	[Token(Token = "0x4015FAD")]
	[FieldOffset(Offset = "0x24")]
	public UIButton CloseArrowBtn;

	[Token(Token = "0x601678D")]
	[Address(RVA = "0x1BBFF84", Offset = "0x1BBFF84", VA = "0x1BBFF84")]
	public UIHudLWSOBattleInfoView()
	{
	}

	[Token(Token = "0x601678E")]
	[Address(RVA = "0x1BBFF8C", Offset = "0x1BBFF8C", VA = "0x1BBFF8C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601678F")]
	[Address(RVA = "0x1BC028C", Offset = "0x1BC028C", VA = "0x1BC028C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
