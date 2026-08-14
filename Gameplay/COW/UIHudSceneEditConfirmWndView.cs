using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003728")]
public class UIHudSceneEditConfirmWndView : UIBaseView
{
	[Token(Token = "0x40164C4")]
	[FieldOffset(Offset = "0x14")]
	public UILabel BaseInfoTxt;

	[Token(Token = "0x40164C5")]
	[FieldOffset(Offset = "0x18")]
	public UILabel WarningInfoTxt;

	[Token(Token = "0x40164C6")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnCancel;

	[Token(Token = "0x40164C7")]
	[FieldOffset(Offset = "0x20")]
	public UILabel BtnCancelTxt;

	[Token(Token = "0x40164C8")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnApply;

	[Token(Token = "0x40164C9")]
	[FieldOffset(Offset = "0x28")]
	public UILabel BtnApplyTxt;

	[Token(Token = "0x6016923")]
	[Address(RVA = "0x1C5AADC", Offset = "0x1C5AADC", VA = "0x1C5AADC")]
	public UIHudSceneEditConfirmWndView()
	{
	}

	[Token(Token = "0x6016924")]
	[Address(RVA = "0x1C5AAE4", Offset = "0x1C5AAE4", VA = "0x1C5AAE4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016925")]
	[Address(RVA = "0x1C5AE6C", Offset = "0x1C5AE6C", VA = "0x1C5AE6C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
