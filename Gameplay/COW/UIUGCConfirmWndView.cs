using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A20")]
public class UIUGCConfirmWndView : UIBaseView
{
	[Token(Token = "0x40188AF")]
	[FieldOffset(Offset = "0x14")]
	public UILabel BaseInfoTxt;

	[Token(Token = "0x40188B0")]
	[FieldOffset(Offset = "0x18")]
	public UILabel WarningInfoTxt;

	[Token(Token = "0x40188B1")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnCancel;

	[Token(Token = "0x40188B2")]
	[FieldOffset(Offset = "0x20")]
	public UILabel BtnCancelTxt;

	[Token(Token = "0x40188B3")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnApply;

	[Token(Token = "0x40188B4")]
	[FieldOffset(Offset = "0x28")]
	public UILabel BtnApplyTxt;

	[Token(Token = "0x6017206")]
	[Address(RVA = "0x2B8AB38", Offset = "0x2B8AB38", VA = "0x2B8AB38")]
	public UIUGCConfirmWndView()
	{
	}

	[Token(Token = "0x6017207")]
	[Address(RVA = "0x2B8AB40", Offset = "0x2B8AB40", VA = "0x2B8AB40", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017208")]
	[Address(RVA = "0x2B8AEC8", Offset = "0x2B8AEC8", VA = "0x2B8AEC8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
