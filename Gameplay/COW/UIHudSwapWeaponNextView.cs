using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200375E")]
public class UIHudSwapWeaponNextView : UIBaseView
{
	[Token(Token = "0x401668E")]
	[FieldOffset(Offset = "0x14")]
	public UIButton swapBtn;

	[Token(Token = "0x60169C5")]
	[Address(RVA = "0x1FF0028", Offset = "0x1FF0028", VA = "0x1FF0028")]
	public UIHudSwapWeaponNextView()
	{
	}

	[Token(Token = "0x60169C6")]
	[Address(RVA = "0x1FF0030", Offset = "0x1FF0030", VA = "0x1FF0030", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169C7")]
	[Address(RVA = "0x1FF01D8", Offset = "0x1FF01D8", VA = "0x1FF01D8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
