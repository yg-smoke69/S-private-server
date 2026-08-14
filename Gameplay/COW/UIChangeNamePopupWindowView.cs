using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003427")]
public class UIChangeNamePopupWindowView : UIBaseView
{
	[Token(Token = "0x40142B2")]
	[FieldOffset(Offset = "0x14")]
	public Animation WindowContainer;

	[Token(Token = "0x40142B3")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelCurrentName;

	[Token(Token = "0x40142B4")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput InputNewName;

	[Token(Token = "0x40142B5")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid BtnsContainer;

	[Token(Token = "0x40142B6")]
	[FieldOffset(Offset = "0x24")]
	public GameObject DiamondBtnGroup;

	[Token(Token = "0x40142B7")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelPrice;

	[Token(Token = "0x40142B8")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnConfirm;

	[Token(Token = "0x40142B9")]
	[FieldOffset(Offset = "0x30")]
	public UISprite ConfirmBtnBg;

	[Token(Token = "0x40142BA")]
	[FieldOffset(Offset = "0x34")]
	public GameObject CardBtnGroup;

	[Token(Token = "0x40142BB")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnUseCard;

	[Token(Token = "0x40142BC")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite UseCardBtnBg;

	[Token(Token = "0x40142BD")]
	[FieldOffset(Offset = "0x40")]
	public GameObject DiamondBtnGroup_Disable;

	[Token(Token = "0x40142BE")]
	[FieldOffset(Offset = "0x44")]
	public GameObject CardBtnGroup_Disable;

	[Token(Token = "0x40142BF")]
	[FieldOffset(Offset = "0x48")]
	public UILabel LabelPriceDisabled;

	[Token(Token = "0x6016029")]
	[Address(RVA = "0x2628354", Offset = "0x2628354", VA = "0x2628354")]
	public UIChangeNamePopupWindowView()
	{
	}

	[Token(Token = "0x601602A")]
	[Address(RVA = "0x262835C", Offset = "0x262835C", VA = "0x262835C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601602B")]
	[Address(RVA = "0x26289B4", Offset = "0x26289B4", VA = "0x26289B4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
