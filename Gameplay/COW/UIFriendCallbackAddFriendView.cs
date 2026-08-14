using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003542")]
public class UIFriendCallbackAddFriendView : UIBaseView
{
	[Token(Token = "0x401514B")]
	[FieldOffset(Offset = "0x14")]
	public GameObject GameFriendProfileContainer;

	[Token(Token = "0x401514C")]
	[FieldOffset(Offset = "0x18")]
	public UILabel IDLabel;

	[Token(Token = "0x401514D")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TipLabel;

	[Token(Token = "0x401514E")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnReWrite;

	[Token(Token = "0x401514F")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnAddFriend;

	[Token(Token = "0x6016376")]
	[Address(RVA = "0x1B6CF54", Offset = "0x1B6CF54", VA = "0x1B6CF54")]
	public UIFriendCallbackAddFriendView()
	{
	}

	[Token(Token = "0x6016377")]
	[Address(RVA = "0x1B6CF5C", Offset = "0x1B6CF5C", VA = "0x1B6CF5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016378")]
	[Address(RVA = "0x1B6D278", Offset = "0x1B6D278", VA = "0x1B6D278")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
