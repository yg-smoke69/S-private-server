using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003581")]
public class UIGachaLengendaryExtraListBooyahDayItemView : UIBaseView
{
	[Token(Token = "0x4015409")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget RootViewWidget;

	[Token(Token = "0x401540A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite TokenSprite;

	[Token(Token = "0x401540B")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TokenNum;

	[Token(Token = "0x401540C")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ClickButon;

	[Token(Token = "0x401540D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ItemUnLock;

	[Token(Token = "0x401540E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ItemLocked;

	[Token(Token = "0x401540F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ItemGained;

	[Token(Token = "0x4015410")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ItemMini;

	[Token(Token = "0x4015411")]
	[FieldOffset(Offset = "0x34")]
	public BaseItemView RewardItem;

	[Token(Token = "0x4015412")]
	[FieldOffset(Offset = "0x38")]
	public UISprite QualityBG;

	[Token(Token = "0x4015413")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite SpritePurplePlus;

	[Token(Token = "0x4015414")]
	[FieldOffset(Offset = "0x40")]
	public GameObject IconGroup;

	[Token(Token = "0x4015415")]
	[FieldOffset(Offset = "0x44")]
	public UISprite Sprite_Debris;

	[Token(Token = "0x4015416")]
	[FieldOffset(Offset = "0x48")]
	public UISprite VoucherIcon;

	[Token(Token = "0x4015417")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel LimitLabel;

	[Token(Token = "0x4015418")]
	[FieldOffset(Offset = "0x50")]
	public UILabel QuantityLabel;

	[Token(Token = "0x4015419")]
	[FieldOffset(Offset = "0x54")]
	public GameObject VFXBigReward;

	[Token(Token = "0x401541A")]
	[FieldOffset(Offset = "0x58")]
	public GameObject VFXSecondReward;

	[Token(Token = "0x6016433")]
	[Address(RVA = "0x2E70D18", Offset = "0x2E70D18", VA = "0x2E70D18")]
	public UIGachaLengendaryExtraListBooyahDayItemView()
	{
	}

	[Token(Token = "0x6016434")]
	[Address(RVA = "0x2E70D20", Offset = "0x2E70D20", VA = "0x2E70D20", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016435")]
	[Address(RVA = "0x2E714D4", Offset = "0x2E714D4", VA = "0x2E714D4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
