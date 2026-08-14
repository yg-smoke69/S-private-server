using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036E5")]
public class UIHudPlayerStatsView : UIBaseView
{
	[Token(Token = "0x40162C5")]
	[FieldOffset(Offset = "0x14")]
	public Transform ArmorStats;

	[Token(Token = "0x40162C6")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Mark;

	[Token(Token = "0x40162C7")]
	[FieldOffset(Offset = "0x1C")]
	public Transform PetLine;

	[Token(Token = "0x40162C8")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid Skills;

	[Token(Token = "0x40162C9")]
	[FieldOffset(Offset = "0x24")]
	public Transform OBActiveSkill;

	[Token(Token = "0x40162CA")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelHP;

	[Token(Token = "0x40162CB")]
	[FieldOffset(Offset = "0x2C")]
	public UIProgressBar HPBarProgressBar;

	[Token(Token = "0x40162CC")]
	[FieldOffset(Offset = "0x30")]
	public UISprite HPBarSprite;

	[Token(Token = "0x40162CD")]
	[FieldOffset(Offset = "0x34")]
	public UIProgressBar MedKitBar;

	[Token(Token = "0x40162CE")]
	[FieldOffset(Offset = "0x38")]
	public GameObject EPNode;

	[Token(Token = "0x40162CF")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel LabelEP;

	[Token(Token = "0x40162D0")]
	[FieldOffset(Offset = "0x40")]
	public UISprite EPBarBG;

	[Token(Token = "0x40162D1")]
	[FieldOffset(Offset = "0x44")]
	public UIProgressBar MushRoomEPBar;

	[Token(Token = "0x40162D2")]
	[FieldOffset(Offset = "0x48")]
	public Transform FSHypeNode;

	[Token(Token = "0x40162D3")]
	[FieldOffset(Offset = "0x4C")]
	public Transform HypeNode;

	[Token(Token = "0x40162D4")]
	[FieldOffset(Offset = "0x50")]
	public Animator HUDEffectAnimator;

	[Token(Token = "0x40162D5")]
	[FieldOffset(Offset = "0x54")]
	public GameObject DamageEffect;

	[Token(Token = "0x40162D6")]
	[FieldOffset(Offset = "0x58")]
	public GameObject HealthEffect;

	[Token(Token = "0x40162D7")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject APNode;

	[Token(Token = "0x40162D8")]
	[FieldOffset(Offset = "0x60")]
	public UILabel LabelAP;

	[Token(Token = "0x40162D9")]
	[FieldOffset(Offset = "0x64")]
	public UISprite APBar;

	[Token(Token = "0x40162DA")]
	[FieldOffset(Offset = "0x68")]
	public UISprite iconAP;

	[Token(Token = "0x40162DB")]
	[FieldOffset(Offset = "0x6C")]
	public UIGrid SkillBufferGrid;

	[Token(Token = "0x40162DC")]
	[FieldOffset(Offset = "0x70")]
	public GameObject CuringMarkedObj;

	[Token(Token = "0x40162DD")]
	[FieldOffset(Offset = "0x74")]
	public GameObject MarkTimeBeReduced;

	[Token(Token = "0x40162DE")]
	[FieldOffset(Offset = "0x78")]
	public UIWidget TutorialWidget;

	[Token(Token = "0x40162DF")]
	[FieldOffset(Offset = "0x7C")]
	public UIWidget WidgetTutorialHudHP;

	[Token(Token = "0x40162E0")]
	[FieldOffset(Offset = "0x80")]
	public GameObject LevelSys;

	[Token(Token = "0x40162E1")]
	[FieldOffset(Offset = "0x84")]
	public UIGrid DynamicSkillGrid;

	[Token(Token = "0x40162E2")]
	[FieldOffset(Offset = "0x88")]
	public UIGrid Buffs;

	[Token(Token = "0x40162E3")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel LabelExp;

	[Token(Token = "0x40162E4")]
	[FieldOffset(Offset = "0x90")]
	public UISprite UISpriteExpBar;

	[Token(Token = "0x40162E5")]
	[FieldOffset(Offset = "0x94")]
	public UICustomHoverButton UICustomHoverButtonExpBar;

	[Token(Token = "0x40162E6")]
	[FieldOffset(Offset = "0x98")]
	public GameObject ExpNode;

	[Token(Token = "0x40162E7")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel addExp;

	[Token(Token = "0x40162E8")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel UILabelexpLevel;

	[Token(Token = "0x40162E9")]
	[FieldOffset(Offset = "0xA4")]
	public UICustomHoverButton UICustomHoverButtonexpLevel;

	[Token(Token = "0x40162EA")]
	[FieldOffset(Offset = "0xA8")]
	public UIWidget zombieExptutorialWidget;

	[Token(Token = "0x40162EB")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject tips;

	[Token(Token = "0x40162EC")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel levelDescription;

	[Token(Token = "0x40162ED")]
	[FieldOffset(Offset = "0xB4")]
	public UIHudPlayerMarkIcon NewMark;

	[Token(Token = "0x40162EE")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject DamageRateEnhanceContainer;

	[Token(Token = "0x40162EF")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject AntiCloth;

	[Token(Token = "0x40162F0")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel damageEnhanceRate;

	[Token(Token = "0x40162F1")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject damageEnhanceVFX;

	[Token(Token = "0x40162F2")]
	[FieldOffset(Offset = "0xC8")]
	public UICustomHoverButton UICustomHoverButtonDamgeRate;

	[Token(Token = "0x40162F3")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject DamageRateTips;

	[Token(Token = "0x40162F4")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject damageMaxVFX;

	[Token(Token = "0x40162F5")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject MarkIceWallSkillBeMark;

	[Token(Token = "0x40162F6")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject BeHurtExpendEPIcon;

	[Token(Token = "0x40162F7")]
	[FieldOffset(Offset = "0xDC")]
	public UISprite MarkIceWallSkillBeMarkCDFill;

	[Token(Token = "0x40162F8")]
	[FieldOffset(Offset = "0xE0")]
	public UIProgressBar EPBarProgressBar;

	[Token(Token = "0x40162F9")]
	[FieldOffset(Offset = "0xE4")]
	public UISprite EPBarSprite;

	[Token(Token = "0x601685A")]
	[Address(RVA = "0x1FB8098", Offset = "0x1FB8098", VA = "0x1FB8098")]
	public UIHudPlayerStatsView()
	{
	}

	[Token(Token = "0x601685B")]
	[Address(RVA = "0x1FB80A0", Offset = "0x1FB80A0", VA = "0x1FB80A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601685C")]
	[Address(RVA = "0x1FB9440", Offset = "0x1FB9440", VA = "0x1FB9440")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
