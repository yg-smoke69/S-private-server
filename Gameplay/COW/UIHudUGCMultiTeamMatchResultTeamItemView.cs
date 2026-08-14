using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037BA")]
public class UIHudUGCMultiTeamMatchResultTeamItemView : UIBaseView
{
	[Token(Token = "0x4016927")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget btn;

	[Token(Token = "0x4016928")]
	[FieldOffset(Offset = "0x18")]
	public UISprite ColorBG1;

	[Token(Token = "0x4016929")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite ColorBG2;

	[Token(Token = "0x401692A")]
	[FieldOffset(Offset = "0x20")]
	public UILabel rank;

	[Token(Token = "0x401692B")]
	[FieldOffset(Offset = "0x24")]
	public UILabel teamIndex;

	[Token(Token = "0x401692C")]
	[FieldOffset(Offset = "0x28")]
	public UILabel teamScore;

	[Token(Token = "0x401692D")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton questionBtn;

	[Token(Token = "0x401692E")]
	[FieldOffset(Offset = "0x30")]
	public UILabel TitleInfo1Txt;

	[Token(Token = "0x401692F")]
	[FieldOffset(Offset = "0x34")]
	public UILabel TitleInfo2Txt;

	[Token(Token = "0x4016930")]
	[FieldOffset(Offset = "0x38")]
	public UILabel TitleInfo3Txt;

	[Token(Token = "0x4016931")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel TitleInfo4Txt;

	[Token(Token = "0x4016932")]
	[FieldOffset(Offset = "0x40")]
	public UIGrid PlayerInfoList;

	[Token(Token = "0x6016AD9")]
	[Address(RVA = "0x1A645B0", Offset = "0x1A645B0", VA = "0x1A645B0")]
	public UIHudUGCMultiTeamMatchResultTeamItemView()
	{
	}

	[Token(Token = "0x6016ADA")]
	[Address(RVA = "0x1A645B8", Offset = "0x1A645B8", VA = "0x1A645B8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016ADB")]
	[Address(RVA = "0x1A64B80", Offset = "0x1A64B80", VA = "0x1A64B80")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
