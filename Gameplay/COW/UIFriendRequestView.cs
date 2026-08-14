using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003549")]
public class UIFriendRequestView : UIBaseView
{
	[Token(Token = "0x40151BE")]
	[FieldOffset(Offset = "0x14")]
	public Transform LeftContainer;

	[Token(Token = "0x40151BF")]
	[FieldOffset(Offset = "0x18")]
	public UIButton RequestToggle;

	[Token(Token = "0x40151C0")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject FriendRequstLabel;

	[Token(Token = "0x40151C1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject FriendRequstUnSelected;

	[Token(Token = "0x40151C2")]
	[FieldOffset(Offset = "0x24")]
	public GameObject FriendRequstSelected;

	[Token(Token = "0x40151C3")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BlocklistToggle;

	[Token(Token = "0x40151C4")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BlockListLabel;

	[Token(Token = "0x40151C5")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BlockListUnSelected;

	[Token(Token = "0x40151C6")]
	[FieldOffset(Offset = "0x34")]
	public GameObject BlockListSelected;

	[Token(Token = "0x40151C7")]
	[FieldOffset(Offset = "0x38")]
	public UIScrollView FriendListScrollView;

	[Token(Token = "0x40151C8")]
	[FieldOffset(Offset = "0x3C")]
	public UIEasyList FirendList;

	[Token(Token = "0x40151C9")]
	[FieldOffset(Offset = "0x40")]
	public UILabel FriendListEmptyHint;

	[Token(Token = "0x40151CA")]
	[FieldOffset(Offset = "0x44")]
	public GameObject RequestContainer;

	[Token(Token = "0x40151CB")]
	[FieldOffset(Offset = "0x48")]
	public UIButton BtnRefuseAll;

	[Token(Token = "0x601638B")]
	[Address(RVA = "0x25133B0", Offset = "0x25133B0", VA = "0x25133B0")]
	public UIFriendRequestView()
	{
	}

	[Token(Token = "0x601638C")]
	[Address(RVA = "0x25133B8", Offset = "0x25133B8", VA = "0x25133B8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601638D")]
	[Address(RVA = "0x25139C4", Offset = "0x25139C4", VA = "0x25139C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
