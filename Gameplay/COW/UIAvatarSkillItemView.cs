using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033D7")]
public class UIAvatarSkillItemView : UIBaseView
{
	[Token(Token = "0x4013E7F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton SkillBtn;

	[Token(Token = "0x4013E80")]
	[FieldOffset(Offset = "0x18")]
	public UILabel SkillName;

	[Token(Token = "0x4013E81")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel SkillDesc;

	[Token(Token = "0x4013E82")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SelectSprite;

	[Token(Token = "0x4013E83")]
	[FieldOffset(Offset = "0x24")]
	public UIPanel AvatarIconPanel;

	[Token(Token = "0x4013E84")]
	[FieldOffset(Offset = "0x28")]
	public UISprite AvatarIcon;

	[Token(Token = "0x4013E85")]
	[FieldOffset(Offset = "0x2C")]
	public UIPanel OtherContainerPanel;

	[Token(Token = "0x4013E86")]
	[FieldOffset(Offset = "0x30")]
	public Transform SkillIcon;

	[Token(Token = "0x4013E87")]
	[FieldOffset(Offset = "0x34")]
	public UIButton LevelBtn;

	[Token(Token = "0x4013E88")]
	[FieldOffset(Offset = "0x38")]
	public GameObject LevelTips;

	[Token(Token = "0x4013E89")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject EquipInfo;

	[Token(Token = "0x4013E8A")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BuyBtn;

	[Token(Token = "0x4013E8B")]
	[FieldOffset(Offset = "0x44")]
	public UIButton TipButton;

	[Token(Token = "0x4013E8C")]
	[FieldOffset(Offset = "0x48")]
	public UILabel SkillCd;

	[Token(Token = "0x4013E8D")]
	[FieldOffset(Offset = "0x4C")]
	public Transform TipsRight;

	[Token(Token = "0x4013E8E")]
	[FieldOffset(Offset = "0x50")]
	public GameObject MaskBg;

	[Token(Token = "0x4013E8F")]
	[FieldOffset(Offset = "0x54")]
	public GameObject RecommendIcon;

	[Token(Token = "0x4013E90")]
	[FieldOffset(Offset = "0x58")]
	public GameObject LoveNode;

	[Token(Token = "0x6015F3B")]
	[Address(RVA = "0x2F99B18", Offset = "0x2F99B18", VA = "0x2F99B18")]
	public UIAvatarSkillItemView()
	{
	}

	[Token(Token = "0x6015F3C")]
	[Address(RVA = "0x2F99B20", Offset = "0x2F99B20", VA = "0x2F99B20", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F3D")]
	[Address(RVA = "0x2F9A290", Offset = "0x2F9A290", VA = "0x2F9A290")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
