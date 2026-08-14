using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003455")]
public class UIClanMemberPageView : UIBaseView
{
	[Token(Token = "0x40144ED")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelTotalNum;

	[Token(Token = "0x40144EE")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelClanMaxNum;

	[Token(Token = "0x40144EF")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnExtend;

	[Token(Token = "0x40144F0")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelOnlineNum;

	[Token(Token = "0x40144F1")]
	[FieldOffset(Offset = "0x24")]
	public GameObject TitleBar;

	[Token(Token = "0x40144F2")]
	[FieldOffset(Offset = "0x28")]
	public UIScrollView MemberScrollView;

	[Token(Token = "0x40144F3")]
	[FieldOffset(Offset = "0x2C")]
	public UIEasyList MemberList;

	[Token(Token = "0x40144F4")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid BtnGrid;

	[Token(Token = "0x40144F5")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnApply;

	[Token(Token = "0x40144F6")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnFriendPage;

	[Token(Token = "0x40144F7")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton BtnRecruit;

	[Token(Token = "0x40144F8")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnLeaveClan;

	[Token(Token = "0x40144F9")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BtnArrow;

	[Token(Token = "0x40144FA")]
	[FieldOffset(Offset = "0x48")]
	public GameObject RightArrow;

	[Token(Token = "0x40144FB")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject LeftArrow;

	[Token(Token = "0x40144FC")]
	[FieldOffset(Offset = "0x50")]
	public UIGrid BottomRightBtnGrid;

	[Token(Token = "0x40144FD")]
	[FieldOffset(Offset = "0x54")]
	public UIButton BtnGift;

	[Token(Token = "0x40144FE")]
	[FieldOffset(Offset = "0x58")]
	public UIButton BtnAddFriend;

	[Token(Token = "0x40144FF")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton BtnInspect;

	[Token(Token = "0x4014500")]
	[FieldOffset(Offset = "0x60")]
	public GameObject Loading;

	[Token(Token = "0x4014501")]
	[FieldOffset(Offset = "0x64")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x60160B3")]
	[Address(RVA = "0x2B429C8", Offset = "0x2B429C8", VA = "0x2B429C8")]
	public UIClanMemberPageView()
	{
	}

	[Token(Token = "0x60160B4")]
	[Address(RVA = "0x2B429D0", Offset = "0x2B429D0", VA = "0x2B429D0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160B5")]
	[Address(RVA = "0x2B432C8", Offset = "0x2B432C8", VA = "0x2B432C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
