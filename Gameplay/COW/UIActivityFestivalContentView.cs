using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033A6")]
public class UIActivityFestivalContentView : UIBaseView
{
	[Token(Token = "0x4013B7F")]
	[FieldOffset(Offset = "0x14")]
	public UILabel OperationTips;

	[Token(Token = "0x4013B80")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Operation;

	[Token(Token = "0x4013B81")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject OperateBtnGray;

	[Token(Token = "0x4013B82")]
	[FieldOffset(Offset = "0x20")]
	public GameObject OperateBtnWhite;

	[Token(Token = "0x4013B83")]
	[FieldOffset(Offset = "0x24")]
	public GameObject OperateBtnYellow;

	[Token(Token = "0x4013B84")]
	[FieldOffset(Offset = "0x28")]
	public UILabel OperateBtnTitle;

	[Token(Token = "0x4013B85")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Gained;

	[Token(Token = "0x4013B86")]
	[FieldOffset(Offset = "0x30")]
	public UILabel GainedLabel;

	[Token(Token = "0x4013B87")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButtonGroup AwardSelectGroup;

	[Token(Token = "0x4013B88")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ScrollView_NoTabs;

	[Token(Token = "0x4013B89")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ScrollView;

	[Token(Token = "0x4013B8A")]
	[FieldOffset(Offset = "0x40")]
	public UITable ContentTable;

	[Token(Token = "0x4013B8B")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Introduction;

	[Token(Token = "0x4013B8C")]
	[FieldOffset(Offset = "0x48")]
	public UILabel Time;

	[Token(Token = "0x4013B8D")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject AwardTemplate;

	[Token(Token = "0x4013B8E")]
	[FieldOffset(Offset = "0x50")]
	public UIDragScrollView DragArea;

	[Token(Token = "0x6015EA8")]
	[Address(RVA = "0x2FAC890", Offset = "0x2FAC890", VA = "0x2FAC890")]
	public UIActivityFestivalContentView()
	{
	}

	[Token(Token = "0x6015EA9")]
	[Address(RVA = "0x2FAC898", Offset = "0x2FAC898", VA = "0x2FAC898", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EAA")]
	[Address(RVA = "0x2FACF8C", Offset = "0x2FACF8C", VA = "0x2FACF8C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
