using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033F6")]
public class UIBigEventFriendCallbackAddFriendView : UIBaseView
{
	[Token(Token = "0x401400A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject GameFriendProfileContainer;

	[Token(Token = "0x401400B")]
	[FieldOffset(Offset = "0x18")]
	public UILabel IDLabel;

	[Token(Token = "0x401400C")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TipLabel;

	[Token(Token = "0x401400D")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnReWrite;

	[Token(Token = "0x401400E")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnAddFriend;

	[Token(Token = "0x401400F")]
	[FieldOffset(Offset = "0x28")]
	public UIButton CloseBtn;

	[Token(Token = "0x4014010")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite CallbackIcon;

	[Token(Token = "0x4014011")]
	[FieldOffset(Offset = "0x30")]
	public UILabel CallbackTitle;

	[Token(Token = "0x6015F96")]
	[Address(RVA = "0x1415750", Offset = "0x1415750", VA = "0x1415750")]
	public UIBigEventFriendCallbackAddFriendView()
	{
	}

	[Token(Token = "0x6015F97")]
	[Address(RVA = "0x1415758", Offset = "0x1415758", VA = "0x1415758", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F98")]
	[Address(RVA = "0x1415B94", Offset = "0x1415B94", VA = "0x1415B94")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
