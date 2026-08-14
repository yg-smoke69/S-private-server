using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039BC")]
public class UISPHudCSPlayerInfoView : UIBaseView
{
	[Token(Token = "0x4018409")]
	[FieldOffset(Offset = "0x14")]
	public GameObject EPNode;

	[Token(Token = "0x401840A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite EPBar;

	[Token(Token = "0x401840B")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelHP;

	[Token(Token = "0x401840C")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HPBar;

	[Token(Token = "0x401840D")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TeamFakeIcon;

	[Token(Token = "0x401840E")]
	[FieldOffset(Offset = "0x28")]
	public UIEffectSprite TeamIcon;

	[Token(Token = "0x401840F")]
	[FieldOffset(Offset = "0x2C")]
	public UIEffectSprite FlagIcon;

	[Token(Token = "0x4018410")]
	[FieldOffset(Offset = "0x30")]
	public UILabel TeamId;

	[Token(Token = "0x4018411")]
	[FieldOffset(Offset = "0x34")]
	public UILabel TeamName;

	[Token(Token = "0x4018412")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Name;

	[Token(Token = "0x4018413")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite NameBG;

	[Token(Token = "0x4018414")]
	[FieldOffset(Offset = "0x40")]
	public UISprite TeamBG;

	[Token(Token = "0x4018415")]
	[FieldOffset(Offset = "0x44")]
	public UISprite HelmetBG;

	[Token(Token = "0x4018416")]
	[FieldOffset(Offset = "0x48")]
	public UISprite FilledHelmet;

	[Token(Token = "0x4018417")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite FilledHelmetEnhanced;

	[Token(Token = "0x4018418")]
	[FieldOffset(Offset = "0x50")]
	public UISprite HelmetLevel;

	[Token(Token = "0x4018419")]
	[FieldOffset(Offset = "0x54")]
	public UISprite ArmorBG;

	[Token(Token = "0x401841A")]
	[FieldOffset(Offset = "0x58")]
	public UISprite FilledArmor;

	[Token(Token = "0x401841B")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite FilledArmorEnhanced;

	[Token(Token = "0x401841C")]
	[FieldOffset(Offset = "0x60")]
	public UISprite ArmorLevel;

	[Token(Token = "0x401841D")]
	[FieldOffset(Offset = "0x64")]
	public UILabel MedkitCount;

	[Token(Token = "0x401841E")]
	[FieldOffset(Offset = "0x68")]
	public UILabel IceWallCount;

	[Token(Token = "0x401841F")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel SmokeBombCount;

	[Token(Token = "0x4018420")]
	[FieldOffset(Offset = "0x70")]
	public UILabel GrenadeCount;

	[Token(Token = "0x4018421")]
	[FieldOffset(Offset = "0x74")]
	public UILabel Kill;

	[Token(Token = "0x4018422")]
	[FieldOffset(Offset = "0x78")]
	public UILabel LabelKDA;

	[Token(Token = "0x4018423")]
	[FieldOffset(Offset = "0x7C")]
	public UISprite WeaponIcon;

	[Token(Token = "0x4018424")]
	[FieldOffset(Offset = "0x80")]
	public Transform LeftAnchor;

	[Token(Token = "0x4018425")]
	[FieldOffset(Offset = "0x84")]
	public UIGrid Skills;

	[Token(Token = "0x4018426")]
	[FieldOffset(Offset = "0x88")]
	public UISPHudSkillItemView SkillTemplate;

	[Token(Token = "0x4018427")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel TokenNum;

	[Token(Token = "0x4018428")]
	[FieldOffset(Offset = "0x90")]
	public GameObject Token;

	[Token(Token = "0x4018429")]
	[FieldOffset(Offset = "0x94")]
	public GameObject ActiveSkill;

	[Token(Token = "0x401842A")]
	[FieldOffset(Offset = "0x98")]
	public UISprite ActiveSkillIcon;

	[Token(Token = "0x401842B")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite CDProgress;

	[Token(Token = "0x401842C")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject CDMask;

	[Token(Token = "0x401842D")]
	[FieldOffset(Offset = "0xA4")]
	public UISprite DisableProgress;

	[Token(Token = "0x401842E")]
	[FieldOffset(Offset = "0xA8")]
	public UISprite highLightSprite;

	[Token(Token = "0x401842F")]
	[FieldOffset(Offset = "0xAC")]
	public UISprite TakeEffectProgress;

	[Token(Token = "0x4018430")]
	[FieldOffset(Offset = "0xB0")]
	public Transform GoldEffect;

	[Token(Token = "0x4018431")]
	[FieldOffset(Offset = "0xB4")]
	public Transform SpriteGoldPlus;

	[Token(Token = "0x4018432")]
	[FieldOffset(Offset = "0xB8")]
	public Transform SpriteRedPlus;

	[Token(Token = "0x4018433")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject GoGradeLv1;

	[Token(Token = "0x4018434")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject GoGradeLv2;

	[Token(Token = "0x4018435")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject GoGradeLv3;

	[Token(Token = "0x4018436")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject QualityMark1;

	[Token(Token = "0x4018437")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject QualityMark2;

	[Token(Token = "0x4018438")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject QualityMark3;

	[Token(Token = "0x60170DB")]
	[Address(RVA = "0x1D15E6C", Offset = "0x1D15E6C", VA = "0x1D15E6C")]
	public UISPHudCSPlayerInfoView()
	{
	}

	[Token(Token = "0x60170DC")]
	[Address(RVA = "0x1D15E74", Offset = "0x1D15E74", VA = "0x1D15E74", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170DD")]
	[Address(RVA = "0x1D16E3C", Offset = "0x1D16E3C", VA = "0x1D16E3C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
