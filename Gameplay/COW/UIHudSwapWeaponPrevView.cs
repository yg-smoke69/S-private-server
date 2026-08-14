using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200375F")]
public class UIHudSwapWeaponPrevView : UIBaseView
{
	[Token(Token = "0x401668F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton swapBtn;

	[Token(Token = "0x60169C8")]
	[Address(RVA = "0x1FF0418", Offset = "0x1FF0418", VA = "0x1FF0418")]
	public UIHudSwapWeaponPrevView()
	{
	}

	[Token(Token = "0x60169C9")]
	[Address(RVA = "0x1FF0420", Offset = "0x1FF0420", VA = "0x1FF0420", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169CA")]
	[Address(RVA = "0x1FF05C8", Offset = "0x1FF05C8", VA = "0x1FF05C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
