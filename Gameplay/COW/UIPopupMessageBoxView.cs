using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003917")]
public class UIPopupMessageBoxView : UIBaseView
{
	[Token(Token = "0x4017C1E")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel MainWidget;

	[Token(Token = "0x4017C1F")]
	[FieldOffset(Offset = "0x18")]
	public TweenAlpha BgTweenAlpha;

	[Token(Token = "0x4017C20")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BGSprite;

	[Token(Token = "0x4017C21")]
	[FieldOffset(Offset = "0x20")]
	public TweenScale WindowTweenScale;

	[Token(Token = "0x4017C22")]
	[FieldOffset(Offset = "0x24")]
	public TweenAlpha WindowTweenAlpha;

	[Token(Token = "0x4017C23")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BtnCloseGO;

	[Token(Token = "0x4017C24")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnClose;

	[Token(Token = "0x4017C25")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Title;

	[Token(Token = "0x4017C26")]
	[FieldOffset(Offset = "0x34")]
	public UITable TableBtns;

	[Token(Token = "0x4017C27")]
	[FieldOffset(Offset = "0x38")]
	public GameObject BtnCancelGO;

	[Token(Token = "0x4017C28")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton BtnCancel;

	[Token(Token = "0x4017C29")]
	[FieldOffset(Offset = "0x40")]
	public UISprite BtnCancelSprite;

	[Token(Token = "0x4017C2A")]
	[FieldOffset(Offset = "0x44")]
	public UILabel BtnCancelLabel;

	[Token(Token = "0x4017C2B")]
	[FieldOffset(Offset = "0x48")]
	public GameObject BtnOKGO;

	[Token(Token = "0x4017C2C")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BtnOK;

	[Token(Token = "0x4017C2D")]
	[FieldOffset(Offset = "0x50")]
	public UISprite BtnOKSprite;

	[Token(Token = "0x4017C2E")]
	[FieldOffset(Offset = "0x54")]
	public UILabel BtnOKLabel;

	[Token(Token = "0x4017C2F")]
	[FieldOffset(Offset = "0x58")]
	public UISprite TextArea;

	[Token(Token = "0x4017C30")]
	[FieldOffset(Offset = "0x5C")]
	public UITextList Info;

	[Token(Token = "0x4017C31")]
	[FieldOffset(Offset = "0x60")]
	public UILabel Note;

	[Token(Token = "0x6016EEE")]
	[Address(RVA = "0xEF5DA8", Offset = "0xEF5DA8", VA = "0xEF5DA8")]
	public UIPopupMessageBoxView()
	{
	}

	[Token(Token = "0x6016EEF")]
	[Address(RVA = "0xEF5DB0", Offset = "0xEF5DB0", VA = "0xEF5DB0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EF0")]
	[Address(RVA = "0xEF6654", Offset = "0xEF6654", VA = "0xEF6654")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
