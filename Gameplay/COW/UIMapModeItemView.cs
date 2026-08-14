using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200388D")]
public class UIMapModeItemView : UIBaseView
{
	[Token(Token = "0x40175B6")]
	[FieldOffset(Offset = "0x14")]
	public UIToggleButton MapModeBtn;

	[Token(Token = "0x40175B7")]
	[FieldOffset(Offset = "0x18")]
	public GameObject gray;

	[Token(Token = "0x40175B8")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite mapBg;

	[Token(Token = "0x40175B9")]
	[FieldOffset(Offset = "0x20")]
	public UISprite tagBg;

	[Token(Token = "0x40175BA")]
	[FieldOffset(Offset = "0x24")]
	public UILabel matchMode;

	[Token(Token = "0x40175BB")]
	[FieldOffset(Offset = "0x28")]
	public GameObject MapModeTipsAnim;

	[Token(Token = "0x40175BC")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject selected;

	[Token(Token = "0x40175BD")]
	[FieldOffset(Offset = "0x30")]
	public UILabel tips;

	[Token(Token = "0x40175BE")]
	[FieldOffset(Offset = "0x34")]
	public GameObject LimitLabel;

	[Token(Token = "0x40175BF")]
	[FieldOffset(Offset = "0x38")]
	public GameObject NewLabel;

	[Token(Token = "0x40175C0")]
	[FieldOffset(Offset = "0x3C")]
	public Transform NormalView;

	[Token(Token = "0x40175C1")]
	[FieldOffset(Offset = "0x40")]
	public UILabel gameMode;

	[Token(Token = "0x40175C2")]
	[FieldOffset(Offset = "0x44")]
	public UILabel mapMode;

	[Token(Token = "0x40175C3")]
	[FieldOffset(Offset = "0x48")]
	public Transform BonusView;

	[Token(Token = "0x40175C4")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject BonusReward;

	[Token(Token = "0x40175C5")]
	[FieldOffset(Offset = "0x50")]
	public UILabel ladderExtraBonusRateTxt;

	[Token(Token = "0x40175C6")]
	[FieldOffset(Offset = "0x54")]
	public GameObject ChampionshipBonusReward;

	[Token(Token = "0x40175C7")]
	[FieldOffset(Offset = "0x58")]
	public UILabel ExpBonusLabel;

	[Token(Token = "0x40175C8")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel GoldBonusLabel;

	[Token(Token = "0x40175C9")]
	[FieldOffset(Offset = "0x60")]
	public UILabel BgameMode;

	[Token(Token = "0x40175CA")]
	[FieldOffset(Offset = "0x64")]
	public UILabel BmapMode;

	[Token(Token = "0x40175CB")]
	[FieldOffset(Offset = "0x68")]
	public GameObject DoublePointView;

	[Token(Token = "0x40175CC")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject DoubleTokenView;

	[Token(Token = "0x40175CD")]
	[FieldOffset(Offset = "0x70")]
	public GameObject NoDudectView;

	[Token(Token = "0x6016D52")]
	[Address(RVA = "0x28054A4", Offset = "0x28054A4", VA = "0x28054A4")]
	public UIMapModeItemView()
	{
	}

	[Token(Token = "0x6016D53")]
	[Address(RVA = "0x28054AC", Offset = "0x28054AC", VA = "0x28054AC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D54")]
	[Address(RVA = "0x2805E2C", Offset = "0x2805E2C", VA = "0x2805E2C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
