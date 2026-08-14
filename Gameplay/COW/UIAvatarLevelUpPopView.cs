using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033CA")]
public class UIAvatarLevelUpPopView : UIBaseView
{
	[Token(Token = "0x4013CD0")]
	[FieldOffset(Offset = "0x14")]
	public Transform SkillIcon;

	[Token(Token = "0x4013CD1")]
	[FieldOffset(Offset = "0x18")]
	public UIPanel SkillIconPanel;

	[Token(Token = "0x4013CD2")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel SkillName;

	[Token(Token = "0x4013CD3")]
	[FieldOffset(Offset = "0x20")]
	public UISprite AvatarIcon;

	[Token(Token = "0x4013CD4")]
	[FieldOffset(Offset = "0x24")]
	public UILabel SkillType;

	[Token(Token = "0x4013CD5")]
	[FieldOffset(Offset = "0x28")]
	public UIButton TipsButton;

	[Token(Token = "0x4013CD6")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel SkillDesc1;

	[Token(Token = "0x4013CD7")]
	[FieldOffset(Offset = "0x30")]
	public UILabel OwnCout1;

	[Token(Token = "0x4013CD8")]
	[FieldOffset(Offset = "0x34")]
	public UIButton LevelBtn;

	[Token(Token = "0x4013CD9")]
	[FieldOffset(Offset = "0x38")]
	public GameObject MaxLevelNoneShow;

	[Token(Token = "0x4013CDA")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject LevelupVfx;

	[Token(Token = "0x4013CDB")]
	[FieldOffset(Offset = "0x40")]
	public GameObject LevelVfx;

	[Token(Token = "0x4013CDC")]
	[FieldOffset(Offset = "0x44")]
	public UILabel SkillUPLevel;

	[Token(Token = "0x4013CDD")]
	[FieldOffset(Offset = "0x48")]
	public UIGrid LevelRewardGrid;

	[Token(Token = "0x4013CDE")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel SkillDesc2;

	[Token(Token = "0x4013CDF")]
	[FieldOffset(Offset = "0x50")]
	public UILabel SkillDesc3;

	[Token(Token = "0x4013CE0")]
	[FieldOffset(Offset = "0x54")]
	public UILabel OwnCout11;

	[Token(Token = "0x4013CE1")]
	[FieldOffset(Offset = "0x58")]
	public UIButton UnDeBrisBtn;

	[Token(Token = "0x4013CE2")]
	[FieldOffset(Offset = "0x5C")]
	public Transform TipsButtonTr;

	[Token(Token = "0x4013CE3")]
	[FieldOffset(Offset = "0x60")]
	public UILabel SkillLevel;

	[Token(Token = "0x4013CE4")]
	[FieldOffset(Offset = "0x64")]
	public UISprite AvatarDerbisIcon;

	[Token(Token = "0x4013CE5")]
	[FieldOffset(Offset = "0x68")]
	public UIButton DebrisBtn;

	[Token(Token = "0x4013CE6")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel OwnCout2;

	[Token(Token = "0x4013CE7")]
	[FieldOffset(Offset = "0x70")]
	public UILabel DerbisCoutLabel;

	[Token(Token = "0x6015F14")]
	[Address(RVA = "0x2A87258", Offset = "0x2A87258", VA = "0x2A87258")]
	public UIAvatarLevelUpPopView()
	{
	}

	[Token(Token = "0x6015F15")]
	[Address(RVA = "0x2A87260", Offset = "0x2A87260", VA = "0x2A87260", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F16")]
	[Address(RVA = "0x2A87C34", Offset = "0x2A87C34", VA = "0x2A87C34")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
