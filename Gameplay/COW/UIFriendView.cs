using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200354A")]
public class UIFriendView : UIBaseView
{
	[Token(Token = "0x40151CC")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x40151CD")]
	[FieldOffset(Offset = "0x18")]
	public UILabel FriendListEmptyHint;

	[Token(Token = "0x40151CE")]
	[FieldOffset(Offset = "0x1C")]
	public Transform LeftContainer;

	[Token(Token = "0x40151CF")]
	[FieldOffset(Offset = "0x20")]
	public UITable InviteBtnGroup;

	[Token(Token = "0x40151D0")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ShareLabel;

	[Token(Token = "0x40151D1")]
	[FieldOffset(Offset = "0x28")]
	public UIButton CopyLink;

	[Token(Token = "0x40151D2")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton LineInvite;

	[Token(Token = "0x40151D3")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BindInvite;

	[Token(Token = "0x40151D4")]
	[FieldOffset(Offset = "0x34")]
	public UISprite BindInviteSprite;

	[Token(Token = "0x40151D5")]
	[FieldOffset(Offset = "0x38")]
	public UIButton OtherInvite;

	[Token(Token = "0x40151D6")]
	[FieldOffset(Offset = "0x3C")]
	public Transform CountdownTime;

	[Token(Token = "0x40151D7")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnFriendsRequest;

	[Token(Token = "0x40151D8")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ApplyHint;

	[Token(Token = "0x40151D9")]
	[FieldOffset(Offset = "0x48")]
	public UIButton BtnWatchLive;

	[Token(Token = "0x40151DA")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BtnRelationshipGraph;

	[Token(Token = "0x40151DB")]
	[FieldOffset(Offset = "0x50")]
	public UISprite RelationshipGraphWidget;

	[Token(Token = "0x40151DC")]
	[FieldOffset(Offset = "0x54")]
	public UIInput SearchInput;

	[Token(Token = "0x40151DD")]
	[FieldOffset(Offset = "0x58")]
	public UIButton SearchButton;

	[Token(Token = "0x40151DE")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject SearchClearSprite;

	[Token(Token = "0x40151DF")]
	[FieldOffset(Offset = "0x60")]
	public GameObject SearchSprite;

	[Token(Token = "0x40151E0")]
	[FieldOffset(Offset = "0x64")]
	public UILabel FriendCountTitle;

	[Token(Token = "0x40151E1")]
	[FieldOffset(Offset = "0x68")]
	public UILabel FriendCountLabel;

	[Token(Token = "0x40151E2")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject MiddleContents;

	[Token(Token = "0x40151E3")]
	[FieldOffset(Offset = "0x70")]
	public UIScrollView FriendListScrollView;

	[Token(Token = "0x40151E4")]
	[FieldOffset(Offset = "0x74")]
	public UIEasyList FriendList;

	[Token(Token = "0x40151E5")]
	[FieldOffset(Offset = "0x78")]
	public UIScrollView FriendCallbackScrollView;

	[Token(Token = "0x40151E6")]
	[FieldOffset(Offset = "0x7C")]
	public UITable TableContent;

	[Token(Token = "0x40151E7")]
	[FieldOffset(Offset = "0x80")]
	public Transform AddFriendRoot;

	[Token(Token = "0x40151E8")]
	[FieldOffset(Offset = "0x84")]
	public Transform FriendRelationshipGraphRoot;

	[Token(Token = "0x40151E9")]
	[FieldOffset(Offset = "0x88")]
	public GameObject FriendListEmptyAction;

	[Token(Token = "0x40151EA")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel FriendListEmptyActionTitle;

	[Token(Token = "0x40151EB")]
	[FieldOffset(Offset = "0x90")]
	public UIButton FriendListEmptyActionBtn;

	[Token(Token = "0x40151EC")]
	[FieldOffset(Offset = "0x94")]
	public UILabel FriendListEmptyActionBtnLabel;

	[Token(Token = "0x40151ED")]
	[FieldOffset(Offset = "0x98")]
	public GameObject ScrollBG_1;

	[Token(Token = "0x40151EE")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject ScrollBG_2;

	[Token(Token = "0x601638E")]
	[Address(RVA = "0x25139CC", Offset = "0x25139CC", VA = "0x25139CC")]
	public UIFriendView()
	{
	}

	[Token(Token = "0x601638F")]
	[Address(RVA = "0x25139D4", Offset = "0x25139D4", VA = "0x25139D4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016390")]
	[Address(RVA = "0x251473C", Offset = "0x251473C", VA = "0x251473C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
