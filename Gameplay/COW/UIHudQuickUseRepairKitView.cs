using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036F7")]
public class UIHudQuickUseRepairKitView : UIBaseView
{
	[Token(Token = "0x401634C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnQuickUse;

	[Token(Token = "0x401634D")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget Icon;

	[Token(Token = "0x401634E")]
	[FieldOffset(Offset = "0x1C")]
	public ParticleSystem FlashEffect;

	[Token(Token = "0x401634F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel RepairKitCount;

	[Token(Token = "0x4016350")]
	[FieldOffset(Offset = "0x24")]
	public GameObject PrepTimer;

	[Token(Token = "0x4016351")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TimeLabel;

	[Token(Token = "0x4016352")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Progress;

	[Token(Token = "0x4016353")]
	[FieldOffset(Offset = "0x30")]
	public GameObject UrgencyTipObj;

	[Token(Token = "0x6016890")]
	[Address(RVA = "0x1FD62B4", Offset = "0x1FD62B4", VA = "0x1FD62B4")]
	public UIHudQuickUseRepairKitView()
	{
	}

	[Token(Token = "0x6016891")]
	[Address(RVA = "0x1FD62BC", Offset = "0x1FD62BC", VA = "0x1FD62BC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016892")]
	[Address(RVA = "0x1FD66EC", Offset = "0x1FD66EC", VA = "0x1FD66EC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
