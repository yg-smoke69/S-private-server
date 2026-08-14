using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003752")]
public class UIHudSkillGrowthItemView : UIBaseView
{
	[Token(Token = "0x4016622")]
	[FieldOffset(Offset = "0x14")]
	public UISprite SkillIcon;

	[Token(Token = "0x4016623")]
	[FieldOffset(Offset = "0x18")]
	public UILabel SkillName;

	[Token(Token = "0x4016624")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel SkillType;

	[Token(Token = "0x4016625")]
	[FieldOffset(Offset = "0x20")]
	public UILabel SkillDesc;

	[Token(Token = "0x4016626")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Selected;

	[Token(Token = "0x4016627")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Unselected;

	[Token(Token = "0x4016628")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Unselectable;

	[Token(Token = "0x4016629")]
	[FieldOffset(Offset = "0x30")]
	public GameObject UpgradeSkillIcon;

	[Token(Token = "0x401662A")]
	[FieldOffset(Offset = "0x34")]
	public UISprite SkillBgCurLevel;

	[Token(Token = "0x401662B")]
	[FieldOffset(Offset = "0x38")]
	public UISprite SkillBgNextLevel;

	[Token(Token = "0x401662C")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite SkillIconCurLevel;

	[Token(Token = "0x401662D")]
	[FieldOffset(Offset = "0x40")]
	public UISprite SkillIconNextLevel;

	[Token(Token = "0x401662E")]
	[FieldOffset(Offset = "0x44")]
	public UIButton UIHudSkillGrowthItem;

	[Token(Token = "0x401662F")]
	[FieldOffset(Offset = "0x48")]
	public UILabel SkillDescAdditional;

	[Token(Token = "0x4016630")]
	[FieldOffset(Offset = "0x4C")]
	public UITable Table;

	[Token(Token = "0x4016631")]
	[FieldOffset(Offset = "0x50")]
	public UIButton DragScroll;

	[Token(Token = "0x4016632")]
	[FieldOffset(Offset = "0x54")]
	public GameObject IsRecommended;

	[Token(Token = "0x60169A1")]
	[Address(RVA = "0x16C7A84", Offset = "0x16C7A84", VA = "0x16C7A84")]
	public UIHudSkillGrowthItemView()
	{
	}

	[Token(Token = "0x60169A2")]
	[Address(RVA = "0x16C7A8C", Offset = "0x16C7A8C", VA = "0x16C7A8C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169A3")]
	[Address(RVA = "0x16C81F8", Offset = "0x16C81F8", VA = "0x16C81F8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
