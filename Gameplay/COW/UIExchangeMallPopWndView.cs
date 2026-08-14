using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200352D")]
public class UIExchangeMallPopWndView : UIBaseView
{
	[Token(Token = "0x4015004")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4015005")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList EasyList;

	[Token(Token = "0x4015006")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelLimitedCount;

	[Token(Token = "0x4015007")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnExchange;

	[Token(Token = "0x4015008")]
	[FieldOffset(Offset = "0x24")]
	public UISprite ExchangeBtnBG;

	[Token(Token = "0x4015009")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ExchangePriceLabel;

	[Token(Token = "0x401500A")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ExchangeBuyIcon;

	[Token(Token = "0x401500B")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LabelOwnNum;

	[Token(Token = "0x401500C")]
	[FieldOffset(Offset = "0x34")]
	public UISprite ExchangeIcon;

	[Token(Token = "0x6016337")]
	[Address(RVA = "0x19E98AC", Offset = "0x19E98AC", VA = "0x19E98AC")]
	public UIExchangeMallPopWndView()
	{
	}

	[Token(Token = "0x6016338")]
	[Address(RVA = "0x19E98B4", Offset = "0x19E98B4", VA = "0x19E98B4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016339")]
	[Address(RVA = "0x19E9D5C", Offset = "0x19E9D5C", VA = "0x19E9D5C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
