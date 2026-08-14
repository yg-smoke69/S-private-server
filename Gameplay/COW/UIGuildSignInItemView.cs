using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035B9")]
public class UIGuildSignInItemView : UIBaseView
{
	[Token(Token = "0x4015805")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Mask;

	[Token(Token = "0x4015806")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ExpireLabel;

	[Token(Token = "0x4015807")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GotLabel;

	[Token(Token = "0x4015808")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnItem;

	[Token(Token = "0x4015809")]
	[FieldOffset(Offset = "0x24")]
	public UISprite DateIcon;

	[Token(Token = "0x401580A")]
	[FieldOffset(Offset = "0x28")]
	public UILabel DateLabel;

	[Token(Token = "0x401580B")]
	[FieldOffset(Offset = "0x2C")]
	public BaseItemView m_BaseItem;

	[Token(Token = "0x401580C")]
	[FieldOffset(Offset = "0x30")]
	public UILabel NAME;

	[Token(Token = "0x401580D")]
	[FieldOffset(Offset = "0x34")]
	public UILabel CountLabel;

	[Token(Token = "0x401580E")]
	[FieldOffset(Offset = "0x38")]
	public TweenAlpha GlowFrame;

	[Token(Token = "0x60164D9")]
	[Address(RVA = "0x20282D0", Offset = "0x20282D0", VA = "0x20282D0")]
	public UIGuildSignInItemView()
	{
	}

	[Token(Token = "0x60164DA")]
	[Address(RVA = "0x20282D8", Offset = "0x20282D8", VA = "0x20282D8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164DB")]
	[Address(RVA = "0x20287BC", Offset = "0x20287BC", VA = "0x20287BC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
