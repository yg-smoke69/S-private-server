using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033D9")]
public class UIAvatarSkillTipsItemView : UIBaseView
{
	[Token(Token = "0x4013EA8")]
	[FieldOffset(Offset = "0x14")]
	public UISprite ColorBg;

	[Token(Token = "0x4013EA9")]
	[FieldOffset(Offset = "0x18")]
	public UILabel SkillKey;

	[Token(Token = "0x4013EAA")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Skill1;

	[Token(Token = "0x4013EAB")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Skill2;

	[Token(Token = "0x4013EAC")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Skill3;

	[Token(Token = "0x4013EAD")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Skill4;

	[Token(Token = "0x4013EAE")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Skill5;

	[Token(Token = "0x4013EAF")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Skill6;

	[Token(Token = "0x6015F41")]
	[Address(RVA = "0x2FA1108", Offset = "0x2FA1108", VA = "0x2FA1108")]
	public UIAvatarSkillTipsItemView()
	{
	}

	[Token(Token = "0x6015F42")]
	[Address(RVA = "0x2FA1110", Offset = "0x2FA1110", VA = "0x2FA1110", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F43")]
	[Address(RVA = "0x2FA1558", Offset = "0x2FA1558", VA = "0x2FA1558")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
