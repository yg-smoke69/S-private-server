using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034AC")]
public class UICupMatchWarmUpView : UIBaseView
{
	[Token(Token = "0x401493A")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture BGCDNTexture;

	[Token(Token = "0x401493B")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnClose;

	[Token(Token = "0x401493C")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel WarmUpTitle;

	[Token(Token = "0x401493D")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture TitleCDNTexture;

	[Token(Token = "0x401493E")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnCupMatch;

	[Token(Token = "0x401493F")]
	[FieldOffset(Offset = "0x28")]
	public UILabel BtnCupMatchLabel;

	[Token(Token = "0x4014940")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LabelStatus;

	[Token(Token = "0x4014941")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LabelSeason;

	[Token(Token = "0x4014942")]
	[FieldOffset(Offset = "0x34")]
	public UICountDownLabel LabelCountDown;

	[Token(Token = "0x4014943")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnArena;

	[Token(Token = "0x60161B8")]
	[Address(RVA = "0x11E8B80", Offset = "0x11E8B80", VA = "0x11E8B80")]
	public UICupMatchWarmUpView()
	{
	}

	[Token(Token = "0x60161B9")]
	[Address(RVA = "0x11E8B88", Offset = "0x11E8B88", VA = "0x11E8B88", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161BA")]
	[Address(RVA = "0x11E9090", Offset = "0x11E9090", VA = "0x11E9090")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
