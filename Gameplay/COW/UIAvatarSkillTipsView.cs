using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033DA")]
public class UIAvatarSkillTipsView : UIBaseView
{
	[Token(Token = "0x4013EB0")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel UIAvatarSkillTips;

	[Token(Token = "0x4013EB1")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Mask;

	[Token(Token = "0x4013EB2")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BG;

	[Token(Token = "0x4013EB3")]
	[FieldOffset(Offset = "0x20")]
	public UILabel SkillName;

	[Token(Token = "0x4013EB4")]
	[FieldOffset(Offset = "0x24")]
	public UILabel SkillDesc;

	[Token(Token = "0x4013EB5")]
	[FieldOffset(Offset = "0x28")]
	public UILabel SkillType;

	[Token(Token = "0x4013EB6")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BelowPanel;

	[Token(Token = "0x4013EB7")]
	[FieldOffset(Offset = "0x30")]
	public UILabel SkillLevel1;

	[Token(Token = "0x4013EB8")]
	[FieldOffset(Offset = "0x34")]
	public UILabel SkillLeve2;

	[Token(Token = "0x4013EB9")]
	[FieldOffset(Offset = "0x38")]
	public UILabel SkillLevel3;

	[Token(Token = "0x4013EBA")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel SkillLevel4;

	[Token(Token = "0x4013EBB")]
	[FieldOffset(Offset = "0x40")]
	public UILabel SkillLevel5;

	[Token(Token = "0x4013EBC")]
	[FieldOffset(Offset = "0x44")]
	public UILabel SkillLevel6;

	[Token(Token = "0x4013EBD")]
	[FieldOffset(Offset = "0x48")]
	public UIGrid SkillGrid;

	[Token(Token = "0x4013EBE")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite bg;

	[Token(Token = "0x6015F44")]
	[Address(RVA = "0x2FA1560", Offset = "0x2FA1560", VA = "0x2FA1560")]
	public UIAvatarSkillTipsView()
	{
	}

	[Token(Token = "0x6015F45")]
	[Address(RVA = "0x2FA1568", Offset = "0x2FA1568", VA = "0x2FA1568", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F46")]
	[Address(RVA = "0x2FA1C44", Offset = "0x2FA1C44", VA = "0x2FA1C44")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
