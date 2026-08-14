using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A70")]
public class UIWeaponSkillItemView : UIBaseView
{
	[Token(Token = "0x4018C73")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIWeaponSkillItem;

	[Token(Token = "0x4018C74")]
	[FieldOffset(Offset = "0x18")]
	public UISprite icon;

	[Token(Token = "0x4018C75")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel desc;

	[Token(Token = "0x60172F6")]
	[Address(RVA = "0x102C180", Offset = "0x102C180", VA = "0x102C180")]
	public UIWeaponSkillItemView()
	{
	}

	[Token(Token = "0x60172F7")]
	[Address(RVA = "0x102C188", Offset = "0x102C188", VA = "0x102C188", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172F8")]
	[Address(RVA = "0x102C3F0", Offset = "0x102C3F0", VA = "0x102C3F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
