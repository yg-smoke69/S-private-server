using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037BE")]
public class UIHudVehicleAutoDriveView : UIBaseView
{
	[Token(Token = "0x401695C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton AutoDriveBtn;

	[Token(Token = "0x6016AE5")]
	[Address(RVA = "0x1A6BF14", Offset = "0x1A6BF14", VA = "0x1A6BF14")]
	public UIHudVehicleAutoDriveView()
	{
	}

	[Token(Token = "0x6016AE6")]
	[Address(RVA = "0x1A6BF1C", Offset = "0x1A6BF1C", VA = "0x1A6BF1C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AE7")]
	[Address(RVA = "0x1A6C0C4", Offset = "0x1A6C0C4", VA = "0x1A6C0C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
