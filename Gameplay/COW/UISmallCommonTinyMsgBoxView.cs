using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039B1")]
public class UISmallCommonTinyMsgBoxView : UIBaseView
{
	[Token(Token = "0x4018396")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Content;

	[Token(Token = "0x4018397")]
	[FieldOffset(Offset = "0x18")]
	public UIButton CancelBtn;

	[Token(Token = "0x4018398")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel CancelTxt;

	[Token(Token = "0x4018399")]
	[FieldOffset(Offset = "0x20")]
	public UIButton OKBtn;

	[Token(Token = "0x401839A")]
	[FieldOffset(Offset = "0x24")]
	public UILabel OKTxt;

	[Token(Token = "0x401839B")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Tips;

	[Token(Token = "0x401839C")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Icon;

	[Token(Token = "0x60170BA")]
	[Address(RVA = "0x205901C", Offset = "0x205901C", VA = "0x205901C")]
	public UISmallCommonTinyMsgBoxView()
	{
	}

	[Token(Token = "0x60170BB")]
	[Address(RVA = "0x2059024", Offset = "0x2059024", VA = "0x2059024", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170BC")]
	[Address(RVA = "0x205940C", Offset = "0x205940C", VA = "0x205940C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
