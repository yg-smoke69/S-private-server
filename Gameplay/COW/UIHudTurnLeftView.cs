using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003786")]
public class UIHudTurnLeftView : UIBaseView
{
	[Token(Token = "0x4016802")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnTurnLeft;

	[Token(Token = "0x6016A3D")]
	[Address(RVA = "0x158E0C4", Offset = "0x158E0C4", VA = "0x158E0C4")]
	public UIHudTurnLeftView()
	{
	}

	[Token(Token = "0x6016A3E")]
	[Address(RVA = "0x158E0CC", Offset = "0x158E0CC", VA = "0x158E0CC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A3F")]
	[Address(RVA = "0x158E274", Offset = "0x158E274", VA = "0x158E274")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
