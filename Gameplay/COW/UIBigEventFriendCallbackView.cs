using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033F7")]
public class UIBigEventFriendCallbackView : UIBaseView
{
	[Token(Token = "0x4014012")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Title;

	[Token(Token = "0x4014013")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView FriendListScrollView;

	[Token(Token = "0x4014014")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList FriendList;

	[Token(Token = "0x4014015")]
	[FieldOffset(Offset = "0x20")]
	public UILabel FriendListEmptyHint;

	[Token(Token = "0x4014016")]
	[FieldOffset(Offset = "0x24")]
	public GameObject RequestContainer;

	[Token(Token = "0x4014017")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnInviteFriends;

	[Token(Token = "0x6015F99")]
	[Address(RVA = "0x1417220", Offset = "0x1417220", VA = "0x1417220")]
	public UIBigEventFriendCallbackView()
	{
	}

	[Token(Token = "0x6015F9A")]
	[Address(RVA = "0x1417228", Offset = "0x1417228", VA = "0x1417228", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F9B")]
	[Address(RVA = "0x1417598", Offset = "0x1417598", VA = "0x1417598")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
