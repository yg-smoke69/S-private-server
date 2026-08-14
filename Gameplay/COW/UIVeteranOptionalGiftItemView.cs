using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A5B")]
public class UIVeteranOptionalGiftItemView : UIBaseView
{
	[Token(Token = "0x4018B3E")]
	[FieldOffset(Offset = "0x14")]
	public BaseItemView2 BaseItemView;

	[Token(Token = "0x4018B3F")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Empty;

	[Token(Token = "0x4018B40")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject BigPrizeBg;

	[Token(Token = "0x4018B41")]
	[FieldOffset(Offset = "0x20")]
	public UISprite PlusSprite;

	[Token(Token = "0x4018B42")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Item;

	[Token(Token = "0x4018B43")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Received;

	[Token(Token = "0x4018B44")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject HighLight;

	[Token(Token = "0x4018B45")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BigPrize;

	[Token(Token = "0x60172B7")]
	[Address(RVA = "0x2CADA4C", Offset = "0x2CADA4C", VA = "0x2CADA4C")]
	public UIVeteranOptionalGiftItemView()
	{
	}

	[Token(Token = "0x60172B8")]
	[Address(RVA = "0x2CADA54", Offset = "0x2CADA54", VA = "0x2CADA54", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172B9")]
	[Address(RVA = "0x2CADE6C", Offset = "0x2CADE6C", VA = "0x2CADE6C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
