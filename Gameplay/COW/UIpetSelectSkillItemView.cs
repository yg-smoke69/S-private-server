using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003905")]
public class UIpetSelectSkillItemView : UIBaseView
{
	[Token(Token = "0x4017B40")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIpetSelectSkillItem;

	[Token(Token = "0x4017B41")]
	[FieldOffset(Offset = "0x18")]
	public GameObject UnlockMask;

	[Token(Token = "0x4017B42")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SkillIcon;

	[Token(Token = "0x4017B43")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Skilltitle;

	[Token(Token = "0x4017B44")]
	[FieldOffset(Offset = "0x24")]
	public UILabel SkillDesc;

	[Token(Token = "0x4017B45")]
	[FieldOffset(Offset = "0x28")]
	public UILabel levelLabel;

	[Token(Token = "0x6016EB8")]
	[Address(RVA = "0x1A35D74", Offset = "0x1A35D74", VA = "0x1A35D74")]
	public UIpetSelectSkillItemView()
	{
	}

	[Token(Token = "0x6016EB9")]
	[Address(RVA = "0x1A35D7C", Offset = "0x1A35D7C", VA = "0x1A35D7C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EBA")]
	[Address(RVA = "0x1A360F8", Offset = "0x1A360F8", VA = "0x1A360F8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
