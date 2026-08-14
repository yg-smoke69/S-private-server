using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003459")]
public class UIClanSettingView : UIBaseView
{
	[Token(Token = "0x4014521")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Content;

	[Token(Token = "0x4014522")]
	[FieldOffset(Offset = "0x18")]
	public UIButton SaveBtn;

	[Token(Token = "0x4014523")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel NameLabel;

	[Token(Token = "0x4014524")]
	[FieldOffset(Offset = "0x20")]
	public UILabel IDLabel;

	[Token(Token = "0x4014525")]
	[FieldOffset(Offset = "0x24")]
	public UILabel TimeLabel;

	[Token(Token = "0x4014526")]
	[FieldOffset(Offset = "0x28")]
	public GameObject AreaContainer;

	[Token(Token = "0x4014527")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton AreaBtn;

	[Token(Token = "0x4014528")]
	[FieldOffset(Offset = "0x30")]
	public UILabel AreaLabel;

	[Token(Token = "0x4014529")]
	[FieldOffset(Offset = "0x34")]
	public UIWidget AreaBG;

	[Token(Token = "0x401452A")]
	[FieldOffset(Offset = "0x38")]
	public UIButton TagBtn;

	[Token(Token = "0x401452B")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel TagLabel;

	[Token(Token = "0x401452C")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget TagBG;

	[Token(Token = "0x401452D")]
	[FieldOffset(Offset = "0x44")]
	public UIToggle AutoToggle;

	[Token(Token = "0x401452E")]
	[FieldOffset(Offset = "0x48")]
	public UIToggle ApproveToggle;

	[Token(Token = "0x401452F")]
	[FieldOffset(Offset = "0x4C")]
	public UIWidget AutoCond;

	[Token(Token = "0x4014530")]
	[FieldOffset(Offset = "0x50")]
	public GameObject ApprovalConditionUnselectBG;

	[Token(Token = "0x4014531")]
	[FieldOffset(Offset = "0x54")]
	public GameObject ApprovalConditionRank;

	[Token(Token = "0x4014532")]
	[FieldOffset(Offset = "0x58")]
	public UIButton CondRankBtn;

	[Token(Token = "0x4014533")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel CondRankLabel;

	[Token(Token = "0x4014534")]
	[FieldOffset(Offset = "0x60")]
	public UIWidget CondRankBG;

	[Token(Token = "0x4014535")]
	[FieldOffset(Offset = "0x64")]
	public GameObject ApprovalConditionLevel;

	[Token(Token = "0x4014536")]
	[FieldOffset(Offset = "0x68")]
	public UIButton CondLevelBtn;

	[Token(Token = "0x4014537")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel CondLevelLabel;

	[Token(Token = "0x4014538")]
	[FieldOffset(Offset = "0x70")]
	public UIWidget CondLevelBG;

	[Token(Token = "0x4014539")]
	[FieldOffset(Offset = "0x74")]
	public UIButton AuditBtn;

	[Token(Token = "0x401453A")]
	[FieldOffset(Offset = "0x78")]
	public UILabel AuditLabel;

	[Token(Token = "0x401453B")]
	[FieldOffset(Offset = "0x7C")]
	public UIWidget AuditBG;

	[Token(Token = "0x401453C")]
	[FieldOffset(Offset = "0x80")]
	public UIButton SloganBtn;

	[Token(Token = "0x401453D")]
	[FieldOffset(Offset = "0x84")]
	public UIInput SloganInput;

	[Token(Token = "0x401453E")]
	[FieldOffset(Offset = "0x88")]
	public UIButton NoticeBtn;

	[Token(Token = "0x401453F")]
	[FieldOffset(Offset = "0x8C")]
	public UIInput NoticeInput;

	[Token(Token = "0x60160BF")]
	[Address(RVA = "0x2B4DD30", Offset = "0x2B4DD30", VA = "0x2B4DD30")]
	public UIClanSettingView()
	{
	}

	[Token(Token = "0x60160C0")]
	[Address(RVA = "0x2B4DD38", Offset = "0x2B4DD38", VA = "0x2B4DD38", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160C1")]
	[Address(RVA = "0x2B4E9E4", Offset = "0x2B4E9E4", VA = "0x2B4E9E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
