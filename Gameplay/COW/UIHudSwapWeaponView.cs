using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003761")]
public class UIHudSwapWeaponView : UIBaseView
{
	[Token(Token = "0x4016691")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnSwap;

	[Token(Token = "0x4016692")]
	[FieldOffset(Offset = "0x18")]
	public UILabel BtnName;

	[Token(Token = "0x60169CE")]
	[Address(RVA = "0x1FF0DE4", Offset = "0x1FF0DE4", VA = "0x1FF0DE4")]
	public UIHudSwapWeaponView()
	{
	}

	[Token(Token = "0x60169CF")]
	[Address(RVA = "0x1FF0DEC", Offset = "0x1FF0DEC", VA = "0x1FF0DEC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169D0")]
	[Address(RVA = "0x1FF0FF4", Offset = "0x1FF0FF4", VA = "0x1FF0FF4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
