using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200345D")]
public class UIClanWarInviteWndView : UIBaseView
{
	[Token(Token = "0x4014555")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ScrollContainer;

	[Token(Token = "0x4014556")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SearchObj;

	[Token(Token = "0x4014557")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput SearchInput;

	[Token(Token = "0x4014558")]
	[FieldOffset(Offset = "0x20")]
	public TweenAlpha SearchTweenLabel;

	[Token(Token = "0x4014559")]
	[FieldOffset(Offset = "0x24")]
	public UIButton SearchBtn;

	[Token(Token = "0x401455A")]
	[FieldOffset(Offset = "0x28")]
	public UISprite SearchBtnSprite;

	[Token(Token = "0x401455B")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject SearchClearSprite;

	[Token(Token = "0x401455C")]
	[FieldOffset(Offset = "0x30")]
	public UIButton RefreshBtn;

	[Token(Token = "0x401455D")]
	[FieldOffset(Offset = "0x34")]
	public GameObject RefreshNormalObj;

	[Token(Token = "0x401455E")]
	[FieldOffset(Offset = "0x38")]
	public GameObject RefreshGreyObj;

	[Token(Token = "0x401455F")]
	[FieldOffset(Offset = "0x3C")]
	public UICountDownLabel RefreshCDLabel;

	[Token(Token = "0x4014560")]
	[FieldOffset(Offset = "0x40")]
	public UIEasyList profileGrid;

	[Token(Token = "0x4014561")]
	[FieldOffset(Offset = "0x44")]
	public UILabel NoInfo;

	[Token(Token = "0x60160CB")]
	[Address(RVA = "0x28F4DD8", Offset = "0x28F4DD8", VA = "0x28F4DD8")]
	public UIClanWarInviteWndView()
	{
	}

	[Token(Token = "0x60160CC")]
	[Address(RVA = "0x28F4DE0", Offset = "0x28F4DE0", VA = "0x28F4DE0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160CD")]
	[Address(RVA = "0x28F53CC", Offset = "0x28F53CC", VA = "0x28F53CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
