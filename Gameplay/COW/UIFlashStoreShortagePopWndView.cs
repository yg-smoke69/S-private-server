using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200353D")]
public class UIFlashStoreShortagePopWndView : UIBaseView
{
	[Token(Token = "0x401510C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton GemsObtainBtn;

	[Token(Token = "0x401510D")]
	[FieldOffset(Offset = "0x18")]
	public UIButton FlashGemsObtainBtn;

	[Token(Token = "0x401510E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel FlashGemsObtainLabel;

	[Token(Token = "0x401510F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel GemsObtainLabel;

	[Token(Token = "0x4015110")]
	[FieldOffset(Offset = "0x24")]
	public UILabel DescriptionLabel;

	[Token(Token = "0x4015111")]
	[FieldOffset(Offset = "0x28")]
	public UIButton GemsObtainBtn2;

	[Token(Token = "0x4015112")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject GemsShortageContainer;

	[Token(Token = "0x4015113")]
	[FieldOffset(Offset = "0x30")]
	public GameObject FlashGemsAndGemsShortageContainer;

	[Token(Token = "0x4015114")]
	[FieldOffset(Offset = "0x34")]
	public GameObject FlashGemsShortageContainer;

	[Token(Token = "0x4015115")]
	[FieldOffset(Offset = "0x38")]
	public UIButton FlashGemsObtainBtn2;

	[Token(Token = "0x4015116")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel FlashGemsObtainLabel2;

	[Token(Token = "0x4015117")]
	[FieldOffset(Offset = "0x40")]
	public UILabel GemsObtainLabel2;

	[Token(Token = "0x6016367")]
	[Address(RVA = "0x1B5E4C0", Offset = "0x1B5E4C0", VA = "0x1B5E4C0")]
	public UIFlashStoreShortagePopWndView()
	{
	}

	[Token(Token = "0x6016368")]
	[Address(RVA = "0x1B5E4C8", Offset = "0x1B5E4C8", VA = "0x1B5E4C8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016369")]
	[Address(RVA = "0x1B5EA6C", Offset = "0x1B5EA6C", VA = "0x1B5EA6C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
