using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003938")]
public class UIPVEWeaponItemView : UIBaseView
{
	[Token(Token = "0x4017F0C")]
	[FieldOffset(Offset = "0x14")]
	public UIToggleButton ItemBtn;

	[Token(Token = "0x4017F0D")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Purchase;

	[Token(Token = "0x4017F0E")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite avatarIcon;

	[Token(Token = "0x4017F0F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject gray;

	[Token(Token = "0x4017F10")]
	[FieldOffset(Offset = "0x24")]
	public UISprite itemSprite;

	[Token(Token = "0x4017F11")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TipsGO;

	[Token(Token = "0x4017F12")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TagLabel;

	[Token(Token = "0x4017F13")]
	[FieldOffset(Offset = "0x30")]
	public GameObject HL;

	[Token(Token = "0x4017F14")]
	[FieldOffset(Offset = "0x34")]
	public UISprite descSprite;

	[Token(Token = "0x4017F15")]
	[FieldOffset(Offset = "0x38")]
	public UILabel description;

	[Token(Token = "0x6016F4F")]
	[Address(RVA = "0x15AC544", Offset = "0x15AC544", VA = "0x15AC544")]
	public UIPVEWeaponItemView()
	{
	}

	[Token(Token = "0x6016F50")]
	[Address(RVA = "0x15AC54C", Offset = "0x15AC54C", VA = "0x15AC54C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F51")]
	[Address(RVA = "0x15ACA30", Offset = "0x15ACA30", VA = "0x15ACA30")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
