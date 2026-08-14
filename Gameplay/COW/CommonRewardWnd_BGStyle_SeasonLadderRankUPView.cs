using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200337B")]
public class CommonRewardWnd_BGStyle_SeasonLadderRankUPView : UIBaseView
{
	[Token(Token = "0x40139BD")]
	[FieldOffset(Offset = "0x14")]
	public UILabel TitleLabel;

	[Token(Token = "0x40139BE")]
	[FieldOffset(Offset = "0x18")]
	public GameObject VFX;

	[Token(Token = "0x40139BF")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid BtnGroup;

	[Token(Token = "0x40139C0")]
	[FieldOffset(Offset = "0x20")]
	public UIButton RepurchaseBtn;

	[Token(Token = "0x40139C1")]
	[FieldOffset(Offset = "0x24")]
	public UILabel RepurchaseLabel;

	[Token(Token = "0x40139C2")]
	[FieldOffset(Offset = "0x28")]
	public UILabel FreeLabel;

	[Token(Token = "0x40139C3")]
	[FieldOffset(Offset = "0x2C")]
	public UICountDownIcon CountDownIcon;

	[Token(Token = "0x40139C4")]
	[FieldOffset(Offset = "0x30")]
	public UICountDownLabel GachaCountDownLabel;

	[Token(Token = "0x40139C5")]
	[FieldOffset(Offset = "0x34")]
	public UISprite CurrencyIcon;

	[Token(Token = "0x40139C6")]
	[FieldOffset(Offset = "0x38")]
	public UILabel CurrencyCountLabel;

	[Token(Token = "0x40139C7")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton OKBtn;

	[Token(Token = "0x40139C8")]
	[FieldOffset(Offset = "0x40")]
	public UIButton CancelBtn;

	[Token(Token = "0x40139C9")]
	[FieldOffset(Offset = "0x44")]
	public UIButton OpenBtn;

	[Token(Token = "0x40139CA")]
	[FieldOffset(Offset = "0x48")]
	public UIButton FastEquipBtn;

	[Token(Token = "0x40139CB")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton ChooseBtn;

	[Token(Token = "0x40139CC")]
	[FieldOffset(Offset = "0x50")]
	public GameObject VoucherGroup;

	[Token(Token = "0x40139CD")]
	[FieldOffset(Offset = "0x54")]
	public UIButton ExchangeBtn;

	[Token(Token = "0x40139CE")]
	[FieldOffset(Offset = "0x58")]
	public UILabel TotalVourcherCntLabel;

	[Token(Token = "0x40139CF")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel CurVoucherCntLabel;

	[Token(Token = "0x40139D0")]
	[FieldOffset(Offset = "0x60")]
	public UISprite VoucherIcon;

	[Token(Token = "0x40139D1")]
	[FieldOffset(Offset = "0x64")]
	public UISprite RankIcon;

	[Token(Token = "0x40139D2")]
	[FieldOffset(Offset = "0x68")]
	public UILabel GuideLabel;

	[Token(Token = "0x40139D3")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel RankLabel;

	[Token(Token = "0x40139D4")]
	[FieldOffset(Offset = "0x70")]
	public GameObject RankRewardGuide;

	[Token(Token = "0x6015E28")]
	[Address(RVA = "0x173E9B0", Offset = "0x173E9B0", VA = "0x173E9B0")]
	public CommonRewardWnd_BGStyle_SeasonLadderRankUPView()
	{
	}

	[Token(Token = "0x6015E29")]
	[Address(RVA = "0x173E9B8", Offset = "0x173E9B8", VA = "0x173E9B8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E2A")]
	[Address(RVA = "0x173F3DC", Offset = "0x173F3DC", VA = "0x173F3DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
