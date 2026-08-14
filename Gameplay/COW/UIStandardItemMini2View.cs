using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039EE")]
public class UIStandardItemMini2View : UIBaseView
{
	[Token(Token = "0x4018673")]
	[FieldOffset(Offset = "0x14")]
	public BaseItemView2 BaseItemInfo;

	[Token(Token = "0x4018674")]
	[FieldOffset(Offset = "0x18")]
	public UISprite QualityBG;

	[Token(Token = "0x4018675")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x4018676")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Quality;

	[Token(Token = "0x4018677")]
	[FieldOffset(Offset = "0x24")]
	public UILabel OwnedLabel;

	[Token(Token = "0x4018678")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ItemNum;

	[Token(Token = "0x4018679")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Descargar;

	[Token(Token = "0x401867A")]
	[FieldOffset(Offset = "0x30")]
	public UISprite Icon;

	[Token(Token = "0x401867B")]
	[FieldOffset(Offset = "0x34")]
	public GameObject ItemPermanent;

	[Token(Token = "0x401867C")]
	[FieldOffset(Offset = "0x38")]
	public UILabel GachaLimitLabel;

	[Token(Token = "0x401867D")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x6017170")]
	[Address(RVA = "0x206BE48", Offset = "0x206BE48", VA = "0x206BE48")]
	public UIStandardItemMini2View()
	{
	}

	[Token(Token = "0x6017171")]
	[Address(RVA = "0x206BE50", Offset = "0x206BE50", VA = "0x206BE50", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017172")]
	[Address(RVA = "0x206C394", Offset = "0x206C394", VA = "0x206C394")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
