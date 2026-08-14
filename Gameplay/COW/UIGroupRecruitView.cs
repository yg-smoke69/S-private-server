using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035B6")]
public class UIGroupRecruitView : UIBaseView
{
	[Token(Token = "0x40157BE")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ModeBtn;

	[Token(Token = "0x40157BF")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ModeWidget;

	[Token(Token = "0x40157C0")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel GameMode;

	[Token(Token = "0x40157C1")]
	[FieldOffset(Offset = "0x20")]
	public UIButton GroupBtn;

	[Token(Token = "0x40157C2")]
	[FieldOffset(Offset = "0x24")]
	public UIWidget GroupWidget;

	[Token(Token = "0x40157C3")]
	[FieldOffset(Offset = "0x28")]
	public UILabel GroupMode;

	[Token(Token = "0x40157C4")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton MapBtn;

	[Token(Token = "0x40157C5")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget MapWidget;

	[Token(Token = "0x40157C6")]
	[FieldOffset(Offset = "0x34")]
	public UILabel MapName;

	[Token(Token = "0x40157C7")]
	[FieldOffset(Offset = "0x38")]
	public UIToggle WorldToggle;

	[Token(Token = "0x40157C8")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget WorldWidget;

	[Token(Token = "0x40157C9")]
	[FieldOffset(Offset = "0x40")]
	public UILabel WorldLabel;

	[Token(Token = "0x40157CA")]
	[FieldOffset(Offset = "0x44")]
	public UIToggle ClanToggle;

	[Token(Token = "0x40157CB")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget ClanWidget;

	[Token(Token = "0x40157CC")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton SendBtn;

	[Token(Token = "0x40157CD")]
	[FieldOffset(Offset = "0x50")]
	public UIWidget SendWidget;

	[Token(Token = "0x40157CE")]
	[FieldOffset(Offset = "0x54")]
	public UIButton LadderBtn;

	[Token(Token = "0x40157CF")]
	[FieldOffset(Offset = "0x58")]
	public UIWidget LadderWidget;

	[Token(Token = "0x40157D0")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel LadderLabel;

	[Token(Token = "0x40157D1")]
	[FieldOffset(Offset = "0x60")]
	public UIButton TagBtn_1;

	[Token(Token = "0x40157D2")]
	[FieldOffset(Offset = "0x64")]
	public UIWidget TagWidget_1;

	[Token(Token = "0x40157D3")]
	[FieldOffset(Offset = "0x68")]
	public UILabel TagLabel_1;

	[Token(Token = "0x40157D4")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton TagBtn_2;

	[Token(Token = "0x40157D5")]
	[FieldOffset(Offset = "0x70")]
	public UIWidget TagWidget_2;

	[Token(Token = "0x40157D6")]
	[FieldOffset(Offset = "0x74")]
	public UILabel TagLabel_2;

	[Token(Token = "0x60164D0")]
	[Address(RVA = "0x2021F5C", Offset = "0x2021F5C", VA = "0x2021F5C")]
	public UIGroupRecruitView()
	{
	}

	[Token(Token = "0x60164D1")]
	[Address(RVA = "0x2021F64", Offset = "0x2021F64", VA = "0x2021F64", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164D2")]
	[Address(RVA = "0x2022A0C", Offset = "0x2022A0C", VA = "0x2022A0C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
