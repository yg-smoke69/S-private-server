using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003756")]
public class UIHudSkillTemplateView : UIBaseView
{
	[Token(Token = "0x4016649")]
	[FieldOffset(Offset = "0x14")]
	public UISprite UIHudSkillTemplate;

	[Token(Token = "0x401664A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Cooldown;

	[Token(Token = "0x401664B")]
	[FieldOffset(Offset = "0x1C")]
	public TweenAlpha SkillFlashAnim;

	[Token(Token = "0x401664C")]
	[FieldOffset(Offset = "0x20")]
	public UIEventListener SkillBtn;

	[Token(Token = "0x401664D")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SkillBG;

	[Token(Token = "0x401664E")]
	[FieldOffset(Offset = "0x28")]
	public UILabel SkillLabel;

	[Token(Token = "0x401664F")]
	[FieldOffset(Offset = "0x2C")]
	public TweenAlpha SkillBrightAnim;

	[Token(Token = "0x4016650")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BannedIcon;

	[Token(Token = "0x4016651")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SkillEffectShoot;

	[Token(Token = "0x4016652")]
	[FieldOffset(Offset = "0x38")]
	public GameObject SkillEffectMove;

	[Token(Token = "0x4016653")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject VFXSkillUpgrade;

	[Token(Token = "0x4016654")]
	[FieldOffset(Offset = "0x40")]
	public GameObject SkillEnhanced;

	[Token(Token = "0x60169AD")]
	[Address(RVA = "0x16CDD04", Offset = "0x16CDD04", VA = "0x16CDD04")]
	public UIHudSkillTemplateView()
	{
	}

	[Token(Token = "0x60169AE")]
	[Address(RVA = "0x16CDD0C", Offset = "0x16CDD0C", VA = "0x16CDD0C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169AF")]
	[Address(RVA = "0x16CE298", Offset = "0x16CE298", VA = "0x16CE298")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
