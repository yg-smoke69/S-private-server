using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039E1")]
internal class UISPHudWeaponInfoToggleView : UIBaseView
{
	[Token(Token = "0x40185CA")]
	[FieldOffset(Offset = "0x14")]
	public UIButton WeaponInfoBtn;

	[Token(Token = "0x40185CB")]
	[FieldOffset(Offset = "0x18")]
	public UISprite normal;

	[Token(Token = "0x40185CC")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite HideWeapon;

	[Token(Token = "0x40185CD")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ShowWeapon;

	[Token(Token = "0x6017149")]
	[Address(RVA = "0x14A8FD8", Offset = "0x14A8FD8", VA = "0x14A8FD8")]
	public UISPHudWeaponInfoToggleView()
	{
	}

	[Token(Token = "0x601714A")]
	[Address(RVA = "0x14A8FE0", Offset = "0x14A8FE0", VA = "0x14A8FE0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601714B")]
	[Address(RVA = "0x14A91E8", Offset = "0x14A91E8", VA = "0x14A91E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
