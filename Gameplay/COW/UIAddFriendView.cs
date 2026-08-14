using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033BA")]
public class UIAddFriendView : UIBaseView
{
	[Token(Token = "0x4013C26")]
	[FieldOffset(Offset = "0x14")]
	public Transform ModePrefer;

	[Token(Token = "0x4013C27")]
	[FieldOffset(Offset = "0x18")]
	public Transform Gender;

	[Token(Token = "0x4013C28")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView FriendListScrollView;

	[Token(Token = "0x4013C29")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList FriendList;

	[Token(Token = "0x4013C2A")]
	[FieldOffset(Offset = "0x24")]
	public UILabel FriendListEmptyHint;

	[Token(Token = "0x4013C2B")]
	[FieldOffset(Offset = "0x28")]
	public UISprite EmptyBG;

	[Token(Token = "0x4013C2C")]
	[FieldOffset(Offset = "0x2C")]
	public UIInput SearchInput;

	[Token(Token = "0x4013C2D")]
	[FieldOffset(Offset = "0x30")]
	public UIButton SearchBtn;

	[Token(Token = "0x4013C2E")]
	[FieldOffset(Offset = "0x34")]
	public UIButton RefreshSelectBtn;

	[Token(Token = "0x4013C2F")]
	[FieldOffset(Offset = "0x38")]
	public UIButton ClearButton;

	[Token(Token = "0x4013C30")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton RefreshBtn;

	[Token(Token = "0x4013C31")]
	[FieldOffset(Offset = "0x40")]
	public GameObject RefreshGreyObj;

	[Token(Token = "0x4013C32")]
	[FieldOffset(Offset = "0x44")]
	public UICountDownLabel RefreshCDLabel;

	[Token(Token = "0x4013C33")]
	[FieldOffset(Offset = "0x48")]
	public UIButton Language;

	[Token(Token = "0x4013C34")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite LanguageSprite;

	[Token(Token = "0x4013C35")]
	[FieldOffset(Offset = "0x50")]
	public UILabel LanguageLabel;

	[Token(Token = "0x4013C36")]
	[FieldOffset(Offset = "0x54")]
	public Transform TimeActive;

	[Token(Token = "0x4013C37")]
	[FieldOffset(Offset = "0x58")]
	public UILabel InterestLabel;

	[Token(Token = "0x6015EE4")]
	[Address(RVA = "0x1F2F9E8", Offset = "0x1F2F9E8", VA = "0x1F2F9E8")]
	public UIAddFriendView()
	{
	}

	[Token(Token = "0x6015EE5")]
	[Address(RVA = "0x1F2F9F0", Offset = "0x1F2F9F0", VA = "0x1F2F9F0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EE6")]
	[Address(RVA = "0x1F30174", Offset = "0x1F30174", VA = "0x1F30174")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
