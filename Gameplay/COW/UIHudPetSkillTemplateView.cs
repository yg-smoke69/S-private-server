using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036DB")]
public class UIHudPetSkillTemplateView : UIBaseView
{
	[Token(Token = "0x4016274")]
	[FieldOffset(Offset = "0x14")]
	public UISprite UIHudPetSkillTemplate;

	[Token(Token = "0x4016275")]
	[FieldOffset(Offset = "0x18")]
	public UIButton SkillBtn;

	[Token(Token = "0x4016276")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel SkillLabel;

	[Token(Token = "0x601683E")]
	[Address(RVA = "0x1853CC0", Offset = "0x1853CC0", VA = "0x1853CC0")]
	public UIHudPetSkillTemplateView()
	{
	}

	[Token(Token = "0x601683F")]
	[Address(RVA = "0x1853CC8", Offset = "0x1853CC8", VA = "0x1853CC8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016840")]
	[Address(RVA = "0x1853F30", Offset = "0x1853F30", VA = "0x1853F30")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
