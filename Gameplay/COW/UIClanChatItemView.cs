using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003447")]
public class UIClanChatItemView : UIBaseView
{
	[Token(Token = "0x40143FF")]
	[FieldOffset(Offset = "0x14")]
	public BaseChatMessageView LeftView;

	[Token(Token = "0x4014400")]
	[FieldOffset(Offset = "0x18")]
	public UIButton headbtnleft;

	[Token(Token = "0x4014401")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton LeftContentBtn;

	[Token(Token = "0x4014402")]
	[FieldOffset(Offset = "0x20")]
	public BaseChatMessageView RightView;

	[Token(Token = "0x4014403")]
	[FieldOffset(Offset = "0x24")]
	public UIButton headbtn;

	[Token(Token = "0x4014404")]
	[FieldOffset(Offset = "0x28")]
	public UIButton RightContentBtn;

	[Token(Token = "0x4014405")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ChatTips;

	[Token(Token = "0x4014406")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PrivateWarning;

	[Token(Token = "0x4014407")]
	[FieldOffset(Offset = "0x34")]
	public GameObject AddFriendTip;

	[Token(Token = "0x4014408")]
	[FieldOffset(Offset = "0x38")]
	public UILabel QuickAddFriendLabel;

	[Token(Token = "0x4014409")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject AddFriendBtnContainer;

	[Token(Token = "0x401440A")]
	[FieldOffset(Offset = "0x40")]
	public UIButton quickAddFriendBtn;

	[Token(Token = "0x401440B")]
	[FieldOffset(Offset = "0x44")]
	public UISprite AddFriendBtnSprite;

	[Token(Token = "0x401440C")]
	[FieldOffset(Offset = "0x48")]
	public UISprite AddFriendBtnIcon;

	[Token(Token = "0x401440D")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite AddFriendBtnLight;

	[Token(Token = "0x6016089")]
	[Address(RVA = "0x2F28080", Offset = "0x2F28080", VA = "0x2F28080")]
	public UIClanChatItemView()
	{
	}

	[Token(Token = "0x601608A")]
	[Address(RVA = "0x2F28088", Offset = "0x2F28088", VA = "0x2F28088", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601608B")]
	[Address(RVA = "0x2F28740", Offset = "0x2F28740", VA = "0x2F28740")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
