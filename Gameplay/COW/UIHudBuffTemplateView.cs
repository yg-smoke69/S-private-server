using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035FF")]
public class UIHudBuffTemplateView : UIBaseView
{
	[Token(Token = "0x40159D1")]
	[FieldOffset(Offset = "0x14")]
	public UISprite UIHudSkillTemplate;

	[Token(Token = "0x40159D2")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Cooldown;

	[Token(Token = "0x40159D3")]
	[FieldOffset(Offset = "0x1C")]
	public TweenAlpha SkillFlashAnim;

	[Token(Token = "0x40159D4")]
	[FieldOffset(Offset = "0x20")]
	public UIEventListener SkillBtn;

	[Token(Token = "0x40159D5")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SkillBG;

	[Token(Token = "0x40159D6")]
	[FieldOffset(Offset = "0x28")]
	public UILabel SkillLabel;

	[Token(Token = "0x40159D7")]
	[FieldOffset(Offset = "0x2C")]
	public TweenAlpha SkillBrightAnim;

	[Token(Token = "0x40159D8")]
	[FieldOffset(Offset = "0x30")]
	public GameObject SkillTipsEffect;

	[Token(Token = "0x60165AB")]
	[Address(RVA = "0x1EFD3C8", Offset = "0x1EFD3C8", VA = "0x1EFD3C8")]
	public UIHudBuffTemplateView()
	{
	}

	[Token(Token = "0x60165AC")]
	[Address(RVA = "0x1EFD3D0", Offset = "0x1EFD3D0", VA = "0x1EFD3D0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165AD")]
	[Address(RVA = "0x1EFD80C", Offset = "0x1EFD80C", VA = "0x1EFD80C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
