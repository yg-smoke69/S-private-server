using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035FA")]
public class UIHudBrakeView : UIBaseView
{
	[Token(Token = "0x40159C5")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnBrake;

	[Token(Token = "0x601659C")]
	[Address(RVA = "0x1E17094", Offset = "0x1E17094", VA = "0x1E17094")]
	public UIHudBrakeView()
	{
	}

	[Token(Token = "0x601659D")]
	[Address(RVA = "0x1E1709C", Offset = "0x1E1709C", VA = "0x1E1709C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601659E")]
	[Address(RVA = "0x1E17244", Offset = "0x1E17244", VA = "0x1E17244")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
