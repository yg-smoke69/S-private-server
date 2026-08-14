using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003858")]
public class UILoginRegionChooseItemView : UIBaseView
{
	[Token(Token = "0x401716D")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelName;

	[Token(Token = "0x401716E")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnChoose;

	[Token(Token = "0x401716F")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SpriteChosen;

	[Token(Token = "0x6016CB3")]
	[Address(RVA = "0x21F79E4", Offset = "0x21F79E4", VA = "0x21F79E4")]
	public UILoginRegionChooseItemView()
	{
	}

	[Token(Token = "0x6016CB4")]
	[Address(RVA = "0x21F79EC", Offset = "0x21F79EC", VA = "0x21F79EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CB5")]
	[Address(RVA = "0x21F7C54", Offset = "0x21F7C54", VA = "0x21F7C54")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
