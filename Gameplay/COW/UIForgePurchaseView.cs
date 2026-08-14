using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003540")]
public class UIForgePurchaseView : UIBaseView
{
	[Token(Token = "0x401512A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject line;

	[Token(Token = "0x401512B")]
	[FieldOffset(Offset = "0x18")]
	public UIButton CloseBtn;

	[Token(Token = "0x401512C")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite ItemIcon;

	[Token(Token = "0x401512D")]
	[FieldOffset(Offset = "0x20")]
	public UISprite WeaponIcon;

	[Token(Token = "0x401512E")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ItemNameLabel;

	[Token(Token = "0x401512F")]
	[FieldOffset(Offset = "0x28")]
	public UILabel purchaseDescLabel;

	[Token(Token = "0x4015130")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite quality;

	[Token(Token = "0x4015131")]
	[FieldOffset(Offset = "0x30")]
	public UILabel time;

	[Token(Token = "0x4015132")]
	[FieldOffset(Offset = "0x34")]
	public UILabel cnt;

	[Token(Token = "0x4015133")]
	[FieldOffset(Offset = "0x38")]
	public BaseItemView Material1;

	[Token(Token = "0x4015134")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Material1Count;

	[Token(Token = "0x4015135")]
	[FieldOffset(Offset = "0x40")]
	public BaseItemView Material2;

	[Token(Token = "0x4015136")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Material2Count;

	[Token(Token = "0x4015137")]
	[FieldOffset(Offset = "0x48")]
	public BaseItemView Material3;

	[Token(Token = "0x4015138")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel Material3Count;

	[Token(Token = "0x4015139")]
	[FieldOffset(Offset = "0x50")]
	public UIButton ExchangeBtn;

	[Token(Token = "0x6016370")]
	[Address(RVA = "0x1B6A84C", Offset = "0x1B6A84C", VA = "0x1B6A84C")]
	public UIForgePurchaseView()
	{
	}

	[Token(Token = "0x6016371")]
	[Address(RVA = "0x1B6A854", Offset = "0x1B6A854", VA = "0x1B6A854", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016372")]
	[Address(RVA = "0x1B6AF90", Offset = "0x1B6AF90", VA = "0x1B6AF90")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
