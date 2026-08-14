using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003754")]
public class UIHudSkillKnockDownBleedView : UIBaseView
{
	[Token(Token = "0x4016641")]
	[FieldOffset(Offset = "0x14")]
	public UISprite SkillIcon;

	[Token(Token = "0x4016642")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Tips;

	[Token(Token = "0x4016643")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Effect;

	[Token(Token = "0x4016644")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Mask;

	[Token(Token = "0x4016645")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnTip;

	[Token(Token = "0x60169A7")]
	[Address(RVA = "0x16C8AD4", Offset = "0x16C8AD4", VA = "0x16C8AD4")]
	public UIHudSkillKnockDownBleedView()
	{
	}

	[Token(Token = "0x60169A8")]
	[Address(RVA = "0x16C8ADC", Offset = "0x16C8ADC", VA = "0x16C8ADC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169A9")]
	[Address(RVA = "0x16C8DF8", Offset = "0x16C8DF8", VA = "0x16C8DF8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
