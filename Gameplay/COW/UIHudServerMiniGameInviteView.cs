using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200373F")]
public class UIHudServerMiniGameInviteView : UIBaseView
{
	[Token(Token = "0x4016581")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnAction;

	[Token(Token = "0x4016582")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ActionNameTxt;

	[Token(Token = "0x4016583")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BtnBg;

	[Token(Token = "0x4016584")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BtnIcon;

	[Token(Token = "0x4016585")]
	[FieldOffset(Offset = "0x24")]
	public GameObject CDMask;

	[Token(Token = "0x4016586")]
	[FieldOffset(Offset = "0x28")]
	public UISprite CDProgress;

	[Token(Token = "0x4016587")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject InviteBox;

	[Token(Token = "0x4016588")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LabelInfo;

	[Token(Token = "0x4016589")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnAll;

	[Token(Token = "0x401658A")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LabelAll;

	[Token(Token = "0x401658B")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton BtnFriend;

	[Token(Token = "0x401658C")]
	[FieldOffset(Offset = "0x40")]
	public UILabel LabelFriend;

	[Token(Token = "0x401658D")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BtnClose;

	[Token(Token = "0x401658E")]
	[FieldOffset(Offset = "0x48")]
	public UIButton BtnBackTo;

	[Token(Token = "0x401658F")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite GuideSprite;

	[Token(Token = "0x4016590")]
	[FieldOffset(Offset = "0x50")]
	public UILabel TipTxt;

	[Token(Token = "0x6016968")]
	[Address(RVA = "0x16B789C", Offset = "0x16B789C", VA = "0x16B789C")]
	public UIHudServerMiniGameInviteView()
	{
	}

	[Token(Token = "0x6016969")]
	[Address(RVA = "0x16B78A4", Offset = "0x16B78A4", VA = "0x16B78A4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601696A")]
	[Address(RVA = "0x16B7FD4", Offset = "0x16B7FD4", VA = "0x16B7FD4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
