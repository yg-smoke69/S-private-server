using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003753")]
public class UIHudSkillGrowthView : UIBaseView
{
	[Token(Token = "0x4016633")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4016634")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnConfirm;

	[Token(Token = "0x4016635")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ConfirmEnabled;

	[Token(Token = "0x4016636")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ConfirmDisabled;

	[Token(Token = "0x4016637")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelPlayerLevel;

	[Token(Token = "0x4016638")]
	[FieldOffset(Offset = "0x28")]
	public UITable Table;

	[Token(Token = "0x4016639")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid GridNewSkills;

	[Token(Token = "0x401663A")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid GridOwnedSkills;

	[Token(Token = "0x401663B")]
	[FieldOffset(Offset = "0x34")]
	public GameObject NewSkills;

	[Token(Token = "0x401663C")]
	[FieldOffset(Offset = "0x38")]
	public GameObject OwnedSkills;

	[Token(Token = "0x401663D")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Tips;

	[Token(Token = "0x401663E")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnRerandom;

	[Token(Token = "0x401663F")]
	[FieldOffset(Offset = "0x44")]
	public UILabel RerandomCntDesc;

	[Token(Token = "0x4016640")]
	[FieldOffset(Offset = "0x48")]
	public UIButton Mask;

	[Token(Token = "0x60169A4")]
	[Address(RVA = "0x16C8200", Offset = "0x16C8200", VA = "0x16C8200")]
	public UIHudSkillGrowthView()
	{
	}

	[Token(Token = "0x60169A5")]
	[Address(RVA = "0x16C8208", Offset = "0x16C8208", VA = "0x16C8208", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169A6")]
	[Address(RVA = "0x16C8860", Offset = "0x16C8860", VA = "0x16C8860")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
