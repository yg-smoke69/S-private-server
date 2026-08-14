using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A84")]
public class UIWinnerModeEntranceView : UIBaseView
{
	[Token(Token = "0x4018E02")]
	[FieldOffset(Offset = "0x14")]
	public GameObject line;

	[Token(Token = "0x4018E03")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TitleLabel;

	[Token(Token = "0x4018E04")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton CloseBtn;

	[Token(Token = "0x4018E05")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ItemIcon;

	[Token(Token = "0x4018E06")]
	[FieldOffset(Offset = "0x24")]
	public UISprite quality;

	[Token(Token = "0x4018E07")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ItemCnt;

	[Token(Token = "0x4018E08")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel rewardDetails;

	[Token(Token = "0x4018E09")]
	[FieldOffset(Offset = "0x30")]
	public UIButton moreInfoBtn;

	[Token(Token = "0x4018E0A")]
	[FieldOffset(Offset = "0x34")]
	public UIButton PurchaseBtn;

	[Token(Token = "0x4018E0B")]
	[FieldOffset(Offset = "0x38")]
	public UILabel PriceLabel;

	[Token(Token = "0x4018E0C")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite MoneyBgSprite;

	[Token(Token = "0x4018E0D")]
	[FieldOffset(Offset = "0x40")]
	public UIButton ExchangeBtn;

	[Token(Token = "0x4018E0E")]
	[FieldOffset(Offset = "0x44")]
	public UILabel ExchagneLabel;

	[Token(Token = "0x4018E0F")]
	[FieldOffset(Offset = "0x48")]
	public UIButton FreeBtn;

	[Token(Token = "0x4018E10")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject free;

	[Token(Token = "0x6017332")]
	[Address(RVA = "0x1B8F7F0", Offset = "0x1B8F7F0", VA = "0x1B8F7F0")]
	public UIWinnerModeEntranceView()
	{
	}

	[Token(Token = "0x6017333")]
	[Address(RVA = "0x1B8F7F8", Offset = "0x1B8F7F8", VA = "0x1B8F7F8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017334")]
	[Address(RVA = "0x1B8FEC8", Offset = "0x1B8FEC8", VA = "0x1B8FEC8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
