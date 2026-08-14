using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A4B")]
public class UIUnLockSkillSlotWindowView : UIBaseView
{
	[Token(Token = "0x4018A39")]
	[FieldOffset(Offset = "0x14")]
	public UISprite SkillIcon;

	[Token(Token = "0x4018A3A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel SkillDesc;

	[Token(Token = "0x4018A3B")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ConfirmLabel;

	[Token(Token = "0x4018A3C")]
	[FieldOffset(Offset = "0x20")]
	public UILabel AdditionalDebrisLabel;

	[Token(Token = "0x4018A3D")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid BtnGrid;

	[Token(Token = "0x4018A3E")]
	[FieldOffset(Offset = "0x28")]
	public UIButton GemsBuyBtn;

	[Token(Token = "0x4018A3F")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite GemsBtnBG;

	[Token(Token = "0x4018A40")]
	[FieldOffset(Offset = "0x30")]
	public UISprite DiamondIcon;

	[Token(Token = "0x4018A41")]
	[FieldOffset(Offset = "0x34")]
	public UILabel GemsPriceLabel;

	[Token(Token = "0x4018A42")]
	[FieldOffset(Offset = "0x38")]
	public UIButton CoinsBuyBtn;

	[Token(Token = "0x4018A43")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite GoldIcon;

	[Token(Token = "0x4018A44")]
	[FieldOffset(Offset = "0x40")]
	public UILabel CoinsPriceLabel;

	[Token(Token = "0x4018A45")]
	[FieldOffset(Offset = "0x44")]
	public UISprite CoinsBtnBG;

	[Token(Token = "0x6017287")]
	[Address(RVA = "0xF53548", Offset = "0xF53548", VA = "0xF53548")]
	public UIUnLockSkillSlotWindowView()
	{
	}

	[Token(Token = "0x6017288")]
	[Address(RVA = "0xF53550", Offset = "0xF53550", VA = "0xF53550", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017289")]
	[Address(RVA = "0xF53B78", Offset = "0xF53B78", VA = "0xF53B78")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
