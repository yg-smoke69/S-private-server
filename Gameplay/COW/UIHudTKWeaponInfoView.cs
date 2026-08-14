using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003773")]
public class UIHudTKWeaponInfoView : UIBaseView
{
	[Token(Token = "0x4016766")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget NormalWidget;

	[Token(Token = "0x4016767")]
	[FieldOffset(Offset = "0x18")]
	public TweenAlpha EquipHint;

	[Token(Token = "0x4016768")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel WeaponName;

	[Token(Token = "0x4016769")]
	[FieldOffset(Offset = "0x20")]
	public UISprite WeaponIcon;

	[Token(Token = "0x401676A")]
	[FieldOffset(Offset = "0x24")]
	public UILabel WeaponCnt;

	[Token(Token = "0x401676B")]
	[FieldOffset(Offset = "0x28")]
	public UIProgressBar progressBar;

	[Token(Token = "0x401676C")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite foreground;

	[Token(Token = "0x6016A04")]
	[Address(RVA = "0x1FFC2B8", Offset = "0x1FFC2B8", VA = "0x1FFC2B8")]
	public UIHudTKWeaponInfoView()
	{
	}

	[Token(Token = "0x6016A05")]
	[Address(RVA = "0x1FFC2C0", Offset = "0x1FFC2C0", VA = "0x1FFC2C0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A06")]
	[Address(RVA = "0x1FFC6A8", Offset = "0x1FFC6A8", VA = "0x1FFC6A8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
