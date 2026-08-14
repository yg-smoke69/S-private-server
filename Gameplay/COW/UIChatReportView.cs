using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003432")]
public class UIChatReportView : UIBaseView
{
	[Token(Token = "0x4014318")]
	[FieldOffset(Offset = "0x14")]
	public UICenterTargetHelper ProfileCenterPoint;

	[Token(Token = "0x4014319")]
	[FieldOffset(Offset = "0x18")]
	public UISprite HeadIcon;

	[Token(Token = "0x401431A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Name;

	[Token(Token = "0x401431B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel PlayerID;

	[Token(Token = "0x401431C")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButtonGroup ReportReason;

	[Token(Token = "0x401431D")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButton Racial;

	[Token(Token = "0x401431E")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton Policy;

	[Token(Token = "0x401431F")]
	[FieldOffset(Offset = "0x30")]
	public UIToggleButton Cheat;

	[Token(Token = "0x4014320")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButton AD;

	[Token(Token = "0x4014321")]
	[FieldOffset(Offset = "0x38")]
	public UIToggleButton Other;

	[Token(Token = "0x4014322")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel ReportedChat;

	[Token(Token = "0x4014323")]
	[FieldOffset(Offset = "0x40")]
	public UIButton CancelBtn;

	[Token(Token = "0x4014324")]
	[FieldOffset(Offset = "0x44")]
	public UIButton ReportBtn;

	[Token(Token = "0x4014325")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ReportDisable;

	[Token(Token = "0x601604A")]
	[Address(RVA = "0x2079BCC", Offset = "0x2079BCC", VA = "0x2079BCC")]
	public UIChatReportView()
	{
	}

	[Token(Token = "0x601604B")]
	[Address(RVA = "0x2079BD4", Offset = "0x2079BD4", VA = "0x2079BD4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601604C")]
	[Address(RVA = "0x207A250", Offset = "0x207A250", VA = "0x207A250")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
