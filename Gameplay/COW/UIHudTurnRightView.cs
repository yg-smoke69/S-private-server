using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003787")]
public class UIHudTurnRightView : UIBaseView
{
	[Token(Token = "0x4016803")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnTurnRight;

	[Token(Token = "0x6016A40")]
	[Address(RVA = "0x158E50C", Offset = "0x158E50C", VA = "0x158E50C")]
	public UIHudTurnRightView()
	{
	}

	[Token(Token = "0x6016A41")]
	[Address(RVA = "0x158E514", Offset = "0x158E514", VA = "0x158E514", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A42")]
	[Address(RVA = "0x158E6BC", Offset = "0x158E6BC", VA = "0x158E6BC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
