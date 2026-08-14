using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200363C")]
public class UIHudDynamicSkillTemplateView : UIBaseView
{
	[Token(Token = "0x4015C13")]
	[FieldOffset(Offset = "0x14")]
	public UISprite UIHudDynamicSkillTemplate;

	[Token(Token = "0x4015C14")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Cooldown;

	[Token(Token = "0x4015C15")]
	[FieldOffset(Offset = "0x1C")]
	public TweenAlpha SkillFlashAnim;

	[Token(Token = "0x4015C16")]
	[FieldOffset(Offset = "0x20")]
	public UIEventListener SkillBtn;

	[Token(Token = "0x4015C17")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SkillBG;

	[Token(Token = "0x4015C18")]
	[FieldOffset(Offset = "0x28")]
	public UILabel SkillLabel;

	[Token(Token = "0x4015C19")]
	[FieldOffset(Offset = "0x2C")]
	public TweenAlpha SkillBrightAnim;

	[Token(Token = "0x4015C1A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BannedIcon;

	[Token(Token = "0x4015C1B")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SkillEffectShoot;

	[Token(Token = "0x4015C1C")]
	[FieldOffset(Offset = "0x38")]
	public GameObject SkillEffectMove;

	[Token(Token = "0x4015C1D")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject VFXSkillUpgrade;

	[Token(Token = "0x4015C1E")]
	[FieldOffset(Offset = "0x40")]
	public GameObject SkillEnhanced;

	[Token(Token = "0x6016661")]
	[Address(RVA = "0x1CDD7F8", Offset = "0x1CDD7F8", VA = "0x1CDD7F8")]
	public UIHudDynamicSkillTemplateView()
	{
	}

	[Token(Token = "0x6016662")]
	[Address(RVA = "0x1CDD800", Offset = "0x1CDD800", VA = "0x1CDD800", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016663")]
	[Address(RVA = "0x1CDDD8C", Offset = "0x1CDDD8C", VA = "0x1CDDD8C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
