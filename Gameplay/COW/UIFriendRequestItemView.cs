using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003548")]
public class UIFriendRequestItemView : UIBaseView
{
	[Token(Token = "0x40151B5")]
	[FieldOffset(Offset = "0x14")]
	public GameObject GameFriendProfileContainer;

	[Token(Token = "0x40151B6")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ItemBtn;

	[Token(Token = "0x40151B7")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RequestBtnGroupContainer;

	[Token(Token = "0x40151B8")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BlockBtn;

	[Token(Token = "0x40151B9")]
	[FieldOffset(Offset = "0x24")]
	public UIButton RefuseBtn;

	[Token(Token = "0x40151BA")]
	[FieldOffset(Offset = "0x28")]
	public UIButton AgreeBtn;

	[Token(Token = "0x40151BB")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite FriendBG;

	[Token(Token = "0x40151BC")]
	[FieldOffset(Offset = "0x30")]
	public UISprite RequestBG;

	[Token(Token = "0x40151BD")]
	[FieldOffset(Offset = "0x34")]
	public UIButton CancelBlockBtn;

	[Token(Token = "0x6016388")]
	[Address(RVA = "0x2512F10", Offset = "0x2512F10", VA = "0x2512F10")]
	public UIFriendRequestItemView()
	{
	}

	[Token(Token = "0x6016389")]
	[Address(RVA = "0x2512F18", Offset = "0x2512F18", VA = "0x2512F18", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601638A")]
	[Address(RVA = "0x25133A8", Offset = "0x25133A8", VA = "0x25133A8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
