using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003906")]
public class UIpetSkillItemView : UIBaseView
{
	[Token(Token = "0x4017B46")]
	[FieldOffset(Offset = "0x14")]
	public GameObject SkillInfo;

	[Token(Token = "0x4017B47")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView UIPetskilltextScroll;

	[Token(Token = "0x4017B48")]
	[FieldOffset(Offset = "0x1C")]
	public UITable skilltextTable;

	[Token(Token = "0x4017B49")]
	[FieldOffset(Offset = "0x20")]
	public UILabel SkillDesc;

	[Token(Token = "0x4017B4A")]
	[FieldOffset(Offset = "0x24")]
	public UILabel NextLevelDes;

	[Token(Token = "0x4017B4B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NewTips;

	[Token(Token = "0x4017B4C")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject UnlockMask;

	[Token(Token = "0x4017B4D")]
	[FieldOffset(Offset = "0x30")]
	public UISprite SkillIcon;

	[Token(Token = "0x4017B4E")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Skilltitle;

	[Token(Token = "0x4017B4F")]
	[FieldOffset(Offset = "0x38")]
	public UILabel levelLabel;

	[Token(Token = "0x4017B50")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton ChangeBtn;

	[Token(Token = "0x4017B51")]
	[FieldOffset(Offset = "0x40")]
	public GameObject NoItemTips;

	[Token(Token = "0x4017B52")]
	[FieldOffset(Offset = "0x44")]
	public GameObject SelectSkillGuide;

	[Token(Token = "0x4017B53")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Effect_Circle;

	[Token(Token = "0x4017B54")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton LeftBtn;

	[Token(Token = "0x4017B55")]
	[FieldOffset(Offset = "0x50")]
	public UIButton RightBtn;

	[Token(Token = "0x4017B56")]
	[FieldOffset(Offset = "0x54")]
	public UIButton UpgradeBtn;

	[Token(Token = "0x6016EBB")]
	[Address(RVA = "0x1A36100", Offset = "0x1A36100", VA = "0x1A36100")]
	public UIpetSkillItemView()
	{
	}

	[Token(Token = "0x6016EBC")]
	[Address(RVA = "0x1A36108", Offset = "0x1A36108", VA = "0x1A36108", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EBD")]
	[Address(RVA = "0x1A36868", Offset = "0x1A36868", VA = "0x1A36868")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
