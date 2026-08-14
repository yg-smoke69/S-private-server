using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200386F")]
public class UIMallGiftFriendItemView : UIBaseView
{
	[Token(Token = "0x4017357")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x4017358")]
	[FieldOffset(Offset = "0x18")]
	public UIToggleButton SelectBtn;

	[Token(Token = "0x4017359")]
	[FieldOffset(Offset = "0x1C")]
	public UIEffectSprite bg;

	[Token(Token = "0x401735A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject fakeBg;

	[Token(Token = "0x401735B")]
	[FieldOffset(Offset = "0x24")]
	public UINetworkTexture HeadIcon;

	[Token(Token = "0x401735C")]
	[FieldOffset(Offset = "0x28")]
	public UIEffectSprite HeadSprite;

	[Token(Token = "0x401735D")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject FakeSprite;

	[Token(Token = "0x401735E")]
	[FieldOffset(Offset = "0x30")]
	public UILabel nickname;

	[Token(Token = "0x401735F")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Available;

	[Token(Token = "0x4017360")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Mask;

	[Token(Token = "0x4017361")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite Relationship;

	[Token(Token = "0x4017362")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Favor;

	[Token(Token = "0x6016CF8")]
	[Address(RVA = "0x225BE84", Offset = "0x225BE84", VA = "0x225BE84")]
	public UIMallGiftFriendItemView()
	{
	}

	[Token(Token = "0x6016CF9")]
	[Address(RVA = "0x225BE8C", Offset = "0x225BE8C", VA = "0x225BE8C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CFA")]
	[Address(RVA = "0x225C418", Offset = "0x225C418", VA = "0x225C418")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
