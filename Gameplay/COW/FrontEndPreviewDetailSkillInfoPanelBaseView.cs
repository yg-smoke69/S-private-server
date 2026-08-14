using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C9A")]
public class FrontEndPreviewDetailSkillInfoPanelBaseView : UIFrontEndPreviewUIComponentBaseView
{
	[Token(Token = "0x4011082")]
	[FieldOffset(Offset = "0xC")]
	public UILabel SkillDetail;

	[Token(Token = "0x4011083")]
	[FieldOffset(Offset = "0x10")]
	public UILabel SkillName;

	[Token(Token = "0x4011084")]
	[FieldOffset(Offset = "0x14")]
	public UISprite SkillIcon;

	[Token(Token = "0x4011085")]
	[FieldOffset(Offset = "0x18")]
	public UISprite SkillIconBG;

	[Token(Token = "0x4011086")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton SkillTipsBtn;

	[Token(Token = "0x4011087")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SkillDetailContainer;

	[Token(Token = "0x4011088")]
	[FieldOffset(Offset = "0x24")]
	public UIScrollView DescScrollView;

	[Token(Token = "0x4011089")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget DescBg;

	[Token(Token = "0x6012A45")]
	[Address(RVA = "0x104DC68", Offset = "0x104DC68", VA = "0x104DC68")]
	public FrontEndPreviewDetailSkillInfoPanelBaseView()
	{
	}
}
