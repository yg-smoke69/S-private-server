using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003485")]
public class UICommonTinyMsgBoxView : UIBaseView
{
	[Token(Token = "0x4014713")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Content;

	[Token(Token = "0x4014714")]
	[FieldOffset(Offset = "0x18")]
	public UIButton CancelBtn;

	[Token(Token = "0x4014715")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel CancelTxt;

	[Token(Token = "0x4014716")]
	[FieldOffset(Offset = "0x20")]
	public UIButton OKBtn;

	[Token(Token = "0x4014717")]
	[FieldOffset(Offset = "0x24")]
	public UILabel OKTxt;

	[Token(Token = "0x4014718")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Tips;

	[Token(Token = "0x4014719")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Icon;

	[Token(Token = "0x401471A")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Content1;

	[Token(Token = "0x401471B")]
	[FieldOffset(Offset = "0x34")]
	public UIButton CancelBtn1;

	[Token(Token = "0x401471C")]
	[FieldOffset(Offset = "0x38")]
	public UILabel CancelTxt1;

	[Token(Token = "0x401471D")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton OKBtn1;

	[Token(Token = "0x401471E")]
	[FieldOffset(Offset = "0x40")]
	public UILabel OKTxt1;

	[Token(Token = "0x401471F")]
	[FieldOffset(Offset = "0x44")]
	public Transform PauseCheck;

	[Token(Token = "0x4014720")]
	[FieldOffset(Offset = "0x48")]
	public Transform Window;

	[Token(Token = "0x6016143")]
	[Address(RVA = "0x1EBB250", Offset = "0x1EBB250", VA = "0x1EBB250")]
	public UICommonTinyMsgBoxView()
	{
	}

	[Token(Token = "0x6016144")]
	[Address(RVA = "0x1EBB258", Offset = "0x1EBB258", VA = "0x1EBB258", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016145")]
	[Address(RVA = "0x1EBB8E0", Offset = "0x1EBB8E0", VA = "0x1EBB8E0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
