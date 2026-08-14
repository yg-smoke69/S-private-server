using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003997")]
public class UISceneEditReportView : UIBaseView
{
	[Token(Token = "0x401822E")]
	[FieldOffset(Offset = "0x14")]
	public UISprite mask;

	[Token(Token = "0x401822F")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ID;

	[Token(Token = "0x4018230")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Name;

	[Token(Token = "0x4018231")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ShareCode;

	[Token(Token = "0x4018232")]
	[FieldOffset(Offset = "0x24")]
	public UILabel description;

	[Token(Token = "0x4018233")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButtonGroup ReportReason;

	[Token(Token = "0x4018234")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton Nickname;

	[Token(Token = "0x4018235")]
	[FieldOffset(Offset = "0x30")]
	public UIToggleButton Violence;

	[Token(Token = "0x4018236")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButton AD;

	[Token(Token = "0x4018237")]
	[FieldOffset(Offset = "0x38")]
	public UIToggleButton Other;

	[Token(Token = "0x4018238")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton btnConfirm;

	[Token(Token = "0x4018239")]
	[FieldOffset(Offset = "0x40")]
	public UIButton btnCancel;

	[Token(Token = "0x601706C")]
	[Address(RVA = "0x2DA757C", Offset = "0x2DA757C", VA = "0x2DA757C")]
	public UISceneEditReportView()
	{
	}

	[Token(Token = "0x601706D")]
	[Address(RVA = "0x2DA7584", Offset = "0x2DA7584", VA = "0x2DA7584", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601706E")]
	[Address(RVA = "0x2DA7B4C", Offset = "0x2DA7B4C", VA = "0x2DA7B4C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
