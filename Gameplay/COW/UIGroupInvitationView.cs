using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035B3")]
public class UIGroupInvitationView : UIBaseView
{
	[Token(Token = "0x4015774")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIGroupInvitation;

	[Token(Token = "0x4015775")]
	[FieldOffset(Offset = "0x18")]
	public GameObject friends;

	[Token(Token = "0x4015776")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton refreshBtn;

	[Token(Token = "0x4015777")]
	[FieldOffset(Offset = "0x20")]
	public UIInput InputName;

	[Token(Token = "0x4015778")]
	[FieldOffset(Offset = "0x24")]
	public UIButton searchBtn;

	[Token(Token = "0x4015779")]
	[FieldOffset(Offset = "0x28")]
	public UIScrollView scrollview;

	[Token(Token = "0x401577A")]
	[FieldOffset(Offset = "0x2C")]
	public UIPanel ScrollPanel;

	[Token(Token = "0x401577B")]
	[FieldOffset(Offset = "0x30")]
	public UIEasyList ListGrid;

	[Token(Token = "0x401577C")]
	[FieldOffset(Offset = "0x34")]
	public UIWrapContent wrapcontent;

	[Token(Token = "0x401577D")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LabelInterAppInvite;

	[Token(Token = "0x401577E")]
	[FieldOffset(Offset = "0x3C")]
	public UIGrid GridInterAppInvite;

	[Token(Token = "0x401577F")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnLineInvite;

	[Token(Token = "0x4015780")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BtnFBInvite;

	[Token(Token = "0x4015781")]
	[FieldOffset(Offset = "0x48")]
	public UIButton BtnVKInvite;

	[Token(Token = "0x4015782")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BtnOtherInvite;

	[Token(Token = "0x4015783")]
	[FieldOffset(Offset = "0x50")]
	public UILabel NumCnt;

	[Token(Token = "0x4015784")]
	[FieldOffset(Offset = "0x54")]
	public UITable TabTable;

	[Token(Token = "0x4015785")]
	[FieldOffset(Offset = "0x58")]
	public GameObject FriendTab;

	[Token(Token = "0x4015786")]
	[FieldOffset(Offset = "0x5C")]
	public UIToggleButton FriendToggleBtn;

	[Token(Token = "0x4015787")]
	[FieldOffset(Offset = "0x60")]
	public GameObject ClanTab;

	[Token(Token = "0x4015788")]
	[FieldOffset(Offset = "0x64")]
	public UIToggleButton ClanToggleBtn;

	[Token(Token = "0x4015789")]
	[FieldOffset(Offset = "0x68")]
	public UIButton Mask;

	[Token(Token = "0x60164C7")]
	[Address(RVA = "0x1CFA5AC", Offset = "0x1CFA5AC", VA = "0x1CFA5AC")]
	public UIGroupInvitationView()
	{
	}

	[Token(Token = "0x60164C8")]
	[Address(RVA = "0x1CFA5B4", Offset = "0x1CFA5B4", VA = "0x1CFA5B4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164C9")]
	[Address(RVA = "0x1CFAF0C", Offset = "0x1CFAF0C", VA = "0x1CFAF0C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
