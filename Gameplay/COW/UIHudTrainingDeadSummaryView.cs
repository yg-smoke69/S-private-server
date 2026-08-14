using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200377A")]
public class UIHudTrainingDeadSummaryView : UIBaseView
{
	[Token(Token = "0x401679A")]
	[FieldOffset(Offset = "0x14")]
	public UILabel title;

	[Token(Token = "0x401679B")]
	[FieldOffset(Offset = "0x18")]
	public UILabel KillLabel;

	[Token(Token = "0x401679C")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel AssisLabel;

	[Token(Token = "0x401679D")]
	[FieldOffset(Offset = "0x20")]
	public UILabel HitRateLabel;

	[Token(Token = "0x401679E")]
	[FieldOffset(Offset = "0x24")]
	public UILabel HeadShotRate;

	[Token(Token = "0x401679F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject assisNums;

	[Token(Token = "0x40167A0")]
	[FieldOffset(Offset = "0x2C")]
	public UITable Table;

	[Token(Token = "0x6016A19")]
	[Address(RVA = "0x15843F0", Offset = "0x15843F0", VA = "0x15843F0")]
	public UIHudTrainingDeadSummaryView()
	{
	}

	[Token(Token = "0x6016A1A")]
	[Address(RVA = "0x15843F8", Offset = "0x15843F8", VA = "0x15843F8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A1B")]
	[Address(RVA = "0x15847D4", Offset = "0x15847D4", VA = "0x15847D4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
