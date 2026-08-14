using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003755")]
public class UIHudSkillStrengthenArmorView : UIBaseView
{
	[Token(Token = "0x4016646")]
	[FieldOffset(Offset = "0x14")]
	public UISprite SkillIcon;

	[Token(Token = "0x4016647")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnTip;

	[Token(Token = "0x4016648")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Tips;

	[Token(Token = "0x60169AA")]
	[Address(RVA = "0x16C9318", Offset = "0x16C9318", VA = "0x16C9318")]
	public UIHudSkillStrengthenArmorView()
	{
	}

	[Token(Token = "0x60169AB")]
	[Address(RVA = "0x16C9320", Offset = "0x16C9320", VA = "0x16C9320", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169AC")]
	[Address(RVA = "0x16C9588", Offset = "0x16C9588", VA = "0x16C9588")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
