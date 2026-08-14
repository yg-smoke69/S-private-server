using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A57")]
public class UIVeteranGuideancePreviewItemView : UIBaseView
{
	[Token(Token = "0x4018AE8")]
	[FieldOffset(Offset = "0x14")]
	public BaseItemView2 BaseItemView;

	[Token(Token = "0x4018AE9")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ItemBtn;

	[Token(Token = "0x4018AEA")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Item;

	[Token(Token = "0x4018AEB")]
	[FieldOffset(Offset = "0x20")]
	public UILabel num;

	[Token(Token = "0x4018AEC")]
	[FieldOffset(Offset = "0x24")]
	public UISprite DefaultIcon;

	[Token(Token = "0x4018AED")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BigPrizeBG;

	[Token(Token = "0x4018AEE")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite plus;

	[Token(Token = "0x4018AEF")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BigPrize;

	[Token(Token = "0x4018AF0")]
	[FieldOffset(Offset = "0x34")]
	public GameObject BeforeCommit;

	[Token(Token = "0x4018AF1")]
	[FieldOffset(Offset = "0x38")]
	public GameObject AfterCommit;

	[Token(Token = "0x4018AF2")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Available;

	[Token(Token = "0x4018AF3")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Received;

	[Token(Token = "0x4018AF4")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Locked;

	[Token(Token = "0x60172AB")]
	[Address(RVA = "0x2857750", Offset = "0x2857750", VA = "0x2857750")]
	public UIVeteranGuideancePreviewItemView()
	{
	}

	[Token(Token = "0x60172AC")]
	[Address(RVA = "0x2857758", Offset = "0x2857758", VA = "0x2857758", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172AD")]
	[Address(RVA = "0x2857D20", Offset = "0x2857D20", VA = "0x2857D20")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
