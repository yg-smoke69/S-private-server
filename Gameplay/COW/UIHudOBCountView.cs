using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036C3")]
public class UIHudOBCountView : UIBaseView
{
	[Token(Token = "0x401617A")]
	[FieldOffset(Offset = "0x14")]
	public Animator UIHudOBCount;

	[Token(Token = "0x401617B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Container;

	[Token(Token = "0x401617C")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SkillOBIcon;

	[Token(Token = "0x401617D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject NormalOBIcon;

	[Token(Token = "0x401617E")]
	[FieldOffset(Offset = "0x24")]
	public UILabel countLabel;

	[Token(Token = "0x60167F6")]
	[Address(RVA = "0x1F5ADC0", Offset = "0x1F5ADC0", VA = "0x1F5ADC0")]
	public UIHudOBCountView()
	{
	}

	[Token(Token = "0x60167F7")]
	[Address(RVA = "0x1F5ADC8", Offset = "0x1F5ADC8", VA = "0x1F5ADC8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167F8")]
	[Address(RVA = "0x1F5B0CC", Offset = "0x1F5B0CC", VA = "0x1F5B0CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
