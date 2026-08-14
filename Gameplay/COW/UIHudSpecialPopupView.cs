using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003759")]
public class UIHudSpecialPopupView : UIBaseView
{
	[Token(Token = "0x401665B")]
	[FieldOffset(Offset = "0x14")]
	public Animation MainTipAnim;

	[Token(Token = "0x401665C")]
	[FieldOffset(Offset = "0x18")]
	public UISprite MainIcon;

	[Token(Token = "0x401665D")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel MainMessage;

	[Token(Token = "0x401665E")]
	[FieldOffset(Offset = "0x20")]
	public UISprite MainBg;

	[Token(Token = "0x401665F")]
	[FieldOffset(Offset = "0x24")]
	public UISprite MainBg2;

	[Token(Token = "0x4016660")]
	[FieldOffset(Offset = "0x28")]
	public UISprite MainBg3;

	[Token(Token = "0x4016661")]
	[FieldOffset(Offset = "0x2C")]
	public Animation SubTipAnim;

	[Token(Token = "0x4016662")]
	[FieldOffset(Offset = "0x30")]
	public UISprite SubIcon;

	[Token(Token = "0x4016663")]
	[FieldOffset(Offset = "0x34")]
	public UILabel SubMessage;

	[Token(Token = "0x4016664")]
	[FieldOffset(Offset = "0x38")]
	public UISprite SubBg;

	[Token(Token = "0x4016665")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite SubBg2;

	[Token(Token = "0x60169B6")]
	[Address(RVA = "0x1FDEF1C", Offset = "0x1FDEF1C", VA = "0x1FDEF1C")]
	public UIHudSpecialPopupView()
	{
	}

	[Token(Token = "0x60169B7")]
	[Address(RVA = "0x1FDEF24", Offset = "0x1FDEF24", VA = "0x1FDEF24", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169B8")]
	[Address(RVA = "0x1FDF48C", Offset = "0x1FDF48C", VA = "0x1FDF48C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
