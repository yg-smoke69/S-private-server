using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033F3")]
public class UIBigEvent_GlobalProgress_RulePopupWndView : UIBaseView
{
	[Token(Token = "0x4013FD6")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4013FD7")]
	[FieldOffset(Offset = "0x18")]
	public UISprite SpriteBtnClose;

	[Token(Token = "0x4013FD8")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelTitle;

	[Token(Token = "0x4013FD9")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture TextureBg;

	[Token(Token = "0x4013FDA")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelDesc;

	[Token(Token = "0x6015F8D")]
	[Address(RVA = "0x10C17CC", Offset = "0x10C17CC", VA = "0x10C17CC")]
	public UIBigEvent_GlobalProgress_RulePopupWndView()
	{
	}

	[Token(Token = "0x6015F8E")]
	[Address(RVA = "0x10C17D4", Offset = "0x10C17D4", VA = "0x10C17D4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F8F")]
	[Address(RVA = "0x10C1AFC", Offset = "0x10C1AFC", VA = "0x10C1AFC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
