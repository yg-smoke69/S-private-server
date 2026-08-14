using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036B1")]
public class UIHudMatchResultMVPShowView : UIBaseView
{
	[Token(Token = "0x4016079")]
	[FieldOffset(Offset = "0x14")]
	public Animation HudMVPShowAnim;

	[Token(Token = "0x401607A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel GameModeTxt;

	[Token(Token = "0x401607B")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel PlayerNameTxt;

	[Token(Token = "0x401607C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject FailMVPGrade;

	[Token(Token = "0x401607D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject WinMVPGrade;

	[Token(Token = "0x401607E")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TitleInfo1Txt;

	[Token(Token = "0x401607F")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TitleInfo2Txt;

	[Token(Token = "0x4016080")]
	[FieldOffset(Offset = "0x30")]
	public UILabel TitleInfo3Txt;

	[Token(Token = "0x4016081")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Info1Txt;

	[Token(Token = "0x4016082")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Info2Txt;

	[Token(Token = "0x4016083")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Info3Txt;

	[Token(Token = "0x4016084")]
	[FieldOffset(Offset = "0x40")]
	public UIButton ShareBtn;

	[Token(Token = "0x4016085")]
	[FieldOffset(Offset = "0x44")]
	public UIButton ContinueBtn;

	[Token(Token = "0x4016086")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ContinueTxt;

	[Token(Token = "0x4016087")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject DownloadRoot;

	[Token(Token = "0x4016088")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Download;

	[Token(Token = "0x60167C0")]
	[Address(RVA = "0x19BCF84", Offset = "0x19BCF84", VA = "0x19BCF84")]
	public UIHudMatchResultMVPShowView()
	{
	}

	[Token(Token = "0x60167C1")]
	[Address(RVA = "0x19BCF8C", Offset = "0x19BCF8C", VA = "0x19BCF8C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167C2")]
	[Address(RVA = "0x19BD698", Offset = "0x19BD698", VA = "0x19BD698")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
