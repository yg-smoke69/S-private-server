using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003544")]
public class UIFriendCallbackView : UIBaseView
{
	[Token(Token = "0x401515B")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Title;

	[Token(Token = "0x401515C")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView FriendListScrollView;

	[Token(Token = "0x401515D")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList FriendList;

	[Token(Token = "0x401515E")]
	[FieldOffset(Offset = "0x20")]
	public UILabel FriendListEmptyHint;

	[Token(Token = "0x401515F")]
	[FieldOffset(Offset = "0x24")]
	public GameObject RequestContainer;

	[Token(Token = "0x4015160")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnInviteFriends;

	[Token(Token = "0x601637C")]
	[Address(RVA = "0x24F5624", Offset = "0x24F5624", VA = "0x24F5624")]
	public UIFriendCallbackView()
	{
	}

	[Token(Token = "0x601637D")]
	[Address(RVA = "0x24F562C", Offset = "0x24F562C", VA = "0x24F562C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601637E")]
	[Address(RVA = "0x24F599C", Offset = "0x24F599C", VA = "0x24F599C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
