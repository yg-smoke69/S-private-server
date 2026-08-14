using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200352F")]
public class UIFastSendGiftItemView : UIBaseView
{
	[Token(Token = "0x4015017")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIButtonUIFastSendGiftItem;

	[Token(Token = "0x4015018")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget UIWidgetUIFastSendGiftItem;

	[Token(Token = "0x4015019")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GoldContainer;

	[Token(Token = "0x401501A")]
	[FieldOffset(Offset = "0x20")]
	public UILabel GoldPritceLabel;

	[Token(Token = "0x401501B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject DiamondContainer;

	[Token(Token = "0x401501C")]
	[FieldOffset(Offset = "0x28")]
	public UILabel DiamondPriceLabel;

	[Token(Token = "0x401501D")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ItemContainer;

	[Token(Token = "0x401501E")]
	[FieldOffset(Offset = "0x30")]
	public UISprite SpritePurplePlus;

	[Token(Token = "0x401501F")]
	[FieldOffset(Offset = "0x34")]
	public GameObject HighLightBG;

	[Token(Token = "0x4015020")]
	[FieldOffset(Offset = "0x38")]
	public BaseItemView2 BaseItemView;

	[Token(Token = "0x4015021")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite Icon;

	[Token(Token = "0x4015022")]
	[FieldOffset(Offset = "0x40")]
	public GameObject SpriteOrangePlus;

	[Token(Token = "0x4015023")]
	[FieldOffset(Offset = "0x44")]
	public GameObject VFX_QualityOrangePlus;

	[Token(Token = "0x4015024")]
	[FieldOffset(Offset = "0x48")]
	public GameObject VFX_QualityRed;

	[Token(Token = "0x601633D")]
	[Address(RVA = "0x1DBB77C", Offset = "0x1DBB77C", VA = "0x1DBB77C")]
	public UIFastSendGiftItemView()
	{
	}

	[Token(Token = "0x601633E")]
	[Address(RVA = "0x1DBB784", Offset = "0x1DBB784", VA = "0x1DBB784", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601633F")]
	[Address(RVA = "0x1DBBDB8", Offset = "0x1DBBDB8", VA = "0x1DBBDB8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
