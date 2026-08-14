using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003760")]
public class UIHudSwapWeaponQuickView : UIBaseView
{
	[Token(Token = "0x4016690")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnSwapWeapon;

	[Token(Token = "0x60169CB")]
	[Address(RVA = "0x1FF0C2C", Offset = "0x1FF0C2C", VA = "0x1FF0C2C")]
	public UIHudSwapWeaponQuickView()
	{
	}

	[Token(Token = "0x60169CC")]
	[Address(RVA = "0x1FF0C34", Offset = "0x1FF0C34", VA = "0x1FF0C34", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169CD")]
	[Address(RVA = "0x1FF0DDC", Offset = "0x1FF0DDC", VA = "0x1FF0DDC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
