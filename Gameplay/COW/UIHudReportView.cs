using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200370E")]
public class UIHudReportView : UIBaseView
{
	[Token(Token = "0x40163C0")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x40163C1")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelTitle;

	[Token(Token = "0x40163C2")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite mask;

	[Token(Token = "0x40163C3")]
	[FieldOffset(Offset = "0x20")]
	public UILabel playerId;

	[Token(Token = "0x40163C4")]
	[FieldOffset(Offset = "0x24")]
	public UIScrollView ScrollView;

	[Token(Token = "0x40163C5")]
	[FieldOffset(Offset = "0x28")]
	public UITable ToggleBtnTable;

	[Token(Token = "0x40163C6")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton btnConfirm;

	[Token(Token = "0x40163C7")]
	[FieldOffset(Offset = "0x30")]
	public UIButton btnCancel;

	[Token(Token = "0x40163C8")]
	[FieldOffset(Offset = "0x34")]
	public GameObject ReporteeContainer;

	[Token(Token = "0x40163C9")]
	[FieldOffset(Offset = "0x38")]
	public GameObject PanelReport;

	[Token(Token = "0x40163CA")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject SuccessFeedback;

	[Token(Token = "0x40163CB")]
	[FieldOffset(Offset = "0x40")]
	public UIButton btnConfirmSuccess;

	[Token(Token = "0x60168D5")]
	[Address(RVA = "0x13ED704", Offset = "0x13ED704", VA = "0x13ED704")]
	public UIHudReportView()
	{
	}

	[Token(Token = "0x60168D6")]
	[Address(RVA = "0x13ED70C", Offset = "0x13ED70C", VA = "0x13ED70C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168D7")]
	[Address(RVA = "0x13EDCB0", Offset = "0x13EDCB0", VA = "0x13EDCB0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
