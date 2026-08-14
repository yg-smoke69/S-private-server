using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039C1")]
public class UISPHudKilledView : UIBaseView
{
	[Token(Token = "0x4018460")]
	[FieldOffset(Offset = "0x14")]
	public Animator KillAnimator;

	[Token(Token = "0x4018461")]
	[FieldOffset(Offset = "0x18")]
	public GameObject KillIconsGO;

	[Token(Token = "0x4018462")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject KillIcon;

	[Token(Token = "0x4018463")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HeadKillIcon;

	[Token(Token = "0x4018464")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SniperKillIcon;

	[Token(Token = "0x4018465")]
	[FieldOffset(Offset = "0x28")]
	public GameObject SniperHeadKillIcon;

	[Token(Token = "0x4018466")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject GrenadeKillIcon;

	[Token(Token = "0x4018467")]
	[FieldOffset(Offset = "0x30")]
	public GameObject KnockDownIconsGO;

	[Token(Token = "0x4018468")]
	[FieldOffset(Offset = "0x34")]
	public GameObject KnockDown;

	[Token(Token = "0x4018469")]
	[FieldOffset(Offset = "0x38")]
	public GameObject GrenadeKnockDown;

	[Token(Token = "0x401846A")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject SniperKnockDown;

	[Token(Token = "0x401846B")]
	[FieldOffset(Offset = "0x40")]
	public GameObject KillBlood;

	[Token(Token = "0x401846C")]
	[FieldOffset(Offset = "0x44")]
	public GameObject HeadKillBlood;

	[Token(Token = "0x401846D")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Knife;

	[Token(Token = "0x401846E")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject HeadKnife;

	[Token(Token = "0x60170EA")]
	[Address(RVA = "0x1D216F8", Offset = "0x1D216F8", VA = "0x1D216F8")]
	public UISPHudKilledView()
	{
	}

	[Token(Token = "0x60170EB")]
	[Address(RVA = "0x1D21700", Offset = "0x1D21700", VA = "0x1D21700", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170EC")]
	[Address(RVA = "0x1D21C64", Offset = "0x1D21C64", VA = "0x1D21C64")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
