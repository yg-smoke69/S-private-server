using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039C6")]
public class UISPHudNewPlayerInfoView : UIBaseView
{
	[Token(Token = "0x40184B9")]
	[FieldOffset(Offset = "0x14")]
	public GameObject EPNode;

	[Token(Token = "0x40184BA")]
	[FieldOffset(Offset = "0x18")]
	public UISprite EPBar;

	[Token(Token = "0x40184BB")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelHP;

	[Token(Token = "0x40184BC")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HPBar;

	[Token(Token = "0x40184BD")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TeamFakeIcon;

	[Token(Token = "0x40184BE")]
	[FieldOffset(Offset = "0x28")]
	public UIEffectSprite TeamIcon;

	[Token(Token = "0x40184BF")]
	[FieldOffset(Offset = "0x2C")]
	public UIEffectSprite FlagIcon;

	[Token(Token = "0x40184C0")]
	[FieldOffset(Offset = "0x30")]
	public UILabel TeamId;

	[Token(Token = "0x40184C1")]
	[FieldOffset(Offset = "0x34")]
	public UILabel TeamName;

	[Token(Token = "0x40184C2")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Name;

	[Token(Token = "0x40184C3")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite TeamBG;

	[Token(Token = "0x40184C4")]
	[FieldOffset(Offset = "0x40")]
	public UISprite HelmetBG;

	[Token(Token = "0x40184C5")]
	[FieldOffset(Offset = "0x44")]
	public UISprite FilledHelmet;

	[Token(Token = "0x40184C6")]
	[FieldOffset(Offset = "0x48")]
	public UISprite FilledHelmetEnhanced;

	[Token(Token = "0x40184C7")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite HelmetLevel;

	[Token(Token = "0x40184C8")]
	[FieldOffset(Offset = "0x50")]
	public UISprite ArmorBG;

	[Token(Token = "0x40184C9")]
	[FieldOffset(Offset = "0x54")]
	public UISprite FilledArmor;

	[Token(Token = "0x40184CA")]
	[FieldOffset(Offset = "0x58")]
	public UISprite FilledArmorEnhanced;

	[Token(Token = "0x40184CB")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite ArmorLevel;

	[Token(Token = "0x40184CC")]
	[FieldOffset(Offset = "0x60")]
	public UILabel MedkitCount;

	[Token(Token = "0x40184CD")]
	[FieldOffset(Offset = "0x64")]
	public UILabel IceWallCount;

	[Token(Token = "0x40184CE")]
	[FieldOffset(Offset = "0x68")]
	public UISprite icon;

	[Token(Token = "0x40184CF")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel ItemCount;

	[Token(Token = "0x40184D0")]
	[FieldOffset(Offset = "0x70")]
	public UILabel Kill;

	[Token(Token = "0x40184D1")]
	[FieldOffset(Offset = "0x74")]
	public UISprite WeaponIcon;

	[Token(Token = "0x40184D2")]
	[FieldOffset(Offset = "0x78")]
	public Transform LeftAnchor;

	[Token(Token = "0x40184D3")]
	[FieldOffset(Offset = "0x7C")]
	public UIGrid Skills;

	[Token(Token = "0x40184D4")]
	[FieldOffset(Offset = "0x80")]
	public UISPHudSkillItemView SkillTemplate;

	[Token(Token = "0x40184D5")]
	[FieldOffset(Offset = "0x84")]
	public UILabel Nation;

	[Token(Token = "0x40184D6")]
	[FieldOffset(Offset = "0x88")]
	public UISprite NationBg;

	[Token(Token = "0x40184D7")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel TokenNum;

	[Token(Token = "0x40184D8")]
	[FieldOffset(Offset = "0x90")]
	public GameObject Token;

	[Token(Token = "0x40184D9")]
	[FieldOffset(Offset = "0x94")]
	public GameObject ActiveSkill;

	[Token(Token = "0x40184DA")]
	[FieldOffset(Offset = "0x98")]
	public UISprite ActiveSkillIcon;

	[Token(Token = "0x40184DB")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite CDProgress;

	[Token(Token = "0x40184DC")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject CDMask;

	[Token(Token = "0x40184DD")]
	[FieldOffset(Offset = "0xA4")]
	public UISprite DisableProgress;

	[Token(Token = "0x40184DE")]
	[FieldOffset(Offset = "0xA8")]
	public UISprite highLightSprite;

	[Token(Token = "0x40184DF")]
	[FieldOffset(Offset = "0xAC")]
	public UISprite TakeEffectProgress;

	[Token(Token = "0x40184E0")]
	[FieldOffset(Offset = "0xB0")]
	public Transform FsHypeNode;

	[Token(Token = "0x40184E1")]
	[FieldOffset(Offset = "0xB4")]
	public Transform GoldEffect;

	[Token(Token = "0x40184E2")]
	[FieldOffset(Offset = "0xB8")]
	public Transform SpriteGoldPlus;

	[Token(Token = "0x40184E3")]
	[FieldOffset(Offset = "0xBC")]
	public Transform SpriteRedPlus;

	[Token(Token = "0x40184E4")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject GoGradeLv1;

	[Token(Token = "0x40184E5")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject GoGradeLv2;

	[Token(Token = "0x40184E6")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject GoGradeLv3;

	[Token(Token = "0x40184E7")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject QualityMark1;

	[Token(Token = "0x40184E8")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject QualityMark2;

	[Token(Token = "0x40184E9")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject QualityMark3;

	[Token(Token = "0x60170F9")]
	[Address(RVA = "0x1D24A7C", Offset = "0x1D24A7C", VA = "0x1D24A7C")]
	public UISPHudNewPlayerInfoView()
	{
	}

	[Token(Token = "0x60170FA")]
	[Address(RVA = "0x1D24A84", Offset = "0x1D24A84", VA = "0x1D24A84", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170FB")]
	[Address(RVA = "0x1D25A88", Offset = "0x1D25A88", VA = "0x1D25A88")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
