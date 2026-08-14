using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003780")]
public class UIHudTrainingVehicleTimerView : UIBaseView
{
	[Token(Token = "0x40167E5")]
	[FieldOffset(Offset = "0x14")]
	public UILabel BestHistoryTime;

	[Token(Token = "0x40167E6")]
	[FieldOffset(Offset = "0x18")]
	public UILabel CurTimer;

	[Token(Token = "0x6016A2B")]
	[Address(RVA = "0x1587800", Offset = "0x1587800", VA = "0x1587800")]
	public UIHudTrainingVehicleTimerView()
	{
	}

	[Token(Token = "0x6016A2C")]
	[Address(RVA = "0x1587808", Offset = "0x1587808", VA = "0x1587808", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A2D")]
	[Address(RVA = "0x1587A10", Offset = "0x1587A10", VA = "0x1587A10")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
