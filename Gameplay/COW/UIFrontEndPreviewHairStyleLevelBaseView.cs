using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CB4")]
public class UIFrontEndPreviewHairStyleLevelBaseView : UIFrontEndPreviewUIComponentBaseView
{
	[Token(Token = "0x401110C")]
	[FieldOffset(Offset = "0xC")]
	public UIButton HairStyleContrlBtn;

	[Token(Token = "0x401110D")]
	[FieldOffset(Offset = "0x10")]
	public GameObject HairStyleContrlLeft;

	[Token(Token = "0x401110E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject HairStyleContrlRight;

	[Token(Token = "0x401110F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject HairStyleSpread;

	[Token(Token = "0x4011110")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite HairStyleBG1;

	[Token(Token = "0x4011111")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HairStyleBG2;

	[Token(Token = "0x4011112")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid HairBtnGrid;

	[Token(Token = "0x4011113")]
	[FieldOffset(Offset = "0x28")]
	public GameObject HairStylePinch;

	[Token(Token = "0x4011114")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton HairSpreadhlBtn;

	[Token(Token = "0x4011115")]
	[FieldOffset(Offset = "0x30")]
	public UILabel HairShowLabel;

	[Token(Token = "0x4011116")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButton HairBtnLv0;

	[Token(Token = "0x4011117")]
	[FieldOffset(Offset = "0x38")]
	public UIToggleButton HairBtnLv1;

	[Token(Token = "0x4011118")]
	[FieldOffset(Offset = "0x3C")]
	public UIToggleButton HairBtnLv2;

	[Token(Token = "0x4011119")]
	[FieldOffset(Offset = "0x40")]
	public UIToggleButton HairBtnLv3;

	[Token(Token = "0x6012B73")]
	[Address(RVA = "0x27FB378", Offset = "0x27FB378", VA = "0x27FB378")]
	public UIFrontEndPreviewHairStyleLevelBaseView()
	{
	}
}
