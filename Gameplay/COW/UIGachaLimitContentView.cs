using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200358C")]
public class UIGachaLimitContentView : UIBaseView
{
	[Token(Token = "0x40154BB")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIGachaLimitContent;

	[Token(Token = "0x40154BC")]
	[FieldOffset(Offset = "0x18")]
	public Animation Animation;

	[Token(Token = "0x40154BD")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ExtraAwardContainer;

	[Token(Token = "0x40154BE")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ExtraAwardTitleCount;

	[Token(Token = "0x40154BF")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid ExtraAwardGrid;

	[Token(Token = "0x40154C0")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CountDownContent;

	[Token(Token = "0x40154C1")]
	[FieldOffset(Offset = "0x2C")]
	public UICountDownIcon CountDownIcon;

	[Token(Token = "0x40154C2")]
	[FieldOffset(Offset = "0x30")]
	public UICountDownLabel GachaCountDownLabel;

	[Token(Token = "0x40154C3")]
	[FieldOffset(Offset = "0x34")]
	public GameObject PreviewExit;

	[Token(Token = "0x40154C4")]
	[FieldOffset(Offset = "0x38")]
	public UIButton PreviewItemBtn;

	[Token(Token = "0x40154C5")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject PreviewExitGuideVfx;

	[Token(Token = "0x40154C6")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ModelChange;

	[Token(Token = "0x40154C7")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Anim;

	[Token(Token = "0x40154C8")]
	[FieldOffset(Offset = "0x48")]
	public GameObject TurnTableItemContainer_1;

	[Token(Token = "0x40154C9")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject TurnTableItemContainer_2;

	[Token(Token = "0x40154CA")]
	[FieldOffset(Offset = "0x50")]
	public GameObject TurnTableItemContainer_3;

	[Token(Token = "0x40154CB")]
	[FieldOffset(Offset = "0x54")]
	public GameObject TurnTableItemContainer_4;

	[Token(Token = "0x40154CC")]
	[FieldOffset(Offset = "0x58")]
	public GameObject TurnTableItemContainer_5;

	[Token(Token = "0x40154CD")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject TurnTableItemContainer_6;

	[Token(Token = "0x40154CE")]
	[FieldOffset(Offset = "0x60")]
	public GameObject TurnTableItemContainer_7;

	[Token(Token = "0x40154CF")]
	[FieldOffset(Offset = "0x64")]
	public GameObject TurnTableItemContainer_8;

	[Token(Token = "0x40154D0")]
	[FieldOffset(Offset = "0x68")]
	public GameObject TurnTableItemContainer_9;

	[Token(Token = "0x40154D1")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject TurnTableItemContainer_10;

	[Token(Token = "0x40154D2")]
	[FieldOffset(Offset = "0x70")]
	public GameObject BuyBtnGroup;

	[Token(Token = "0x40154D3")]
	[FieldOffset(Offset = "0x74")]
	public GameObject FinishBtn;

	[Token(Token = "0x40154D4")]
	[FieldOffset(Offset = "0x78")]
	public GameObject RemoveBtnGroup;

	[Token(Token = "0x40154D5")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel RemoveLabel;

	[Token(Token = "0x40154D6")]
	[FieldOffset(Offset = "0x80")]
	public GameObject RemoveBtnGo;

	[Token(Token = "0x40154D7")]
	[FieldOffset(Offset = "0x84")]
	public UIButton RemoveBtn;

	[Token(Token = "0x40154D8")]
	[FieldOffset(Offset = "0x88")]
	public GameObject RemoveBtnable;

	[Token(Token = "0x40154D9")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject RemoveBtnEnable;

	[Token(Token = "0x40154DA")]
	[FieldOffset(Offset = "0x90")]
	public GameObject LimitTurnTableName;

	[Token(Token = "0x40154DB")]
	[FieldOffset(Offset = "0x94")]
	public UINetworkTexture LimitTitleCDN;

	[Token(Token = "0x40154DC")]
	[FieldOffset(Offset = "0x98")]
	public UIButton ProbabilityTips;

	[Token(Token = "0x40154DD")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject CDNMask;

	[Token(Token = "0x40154DE")]
	[FieldOffset(Offset = "0xA0")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x40154DF")]
	[FieldOffset(Offset = "0xA4")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x6016454")]
	[Address(RVA = "0x2A102FC", Offset = "0x2A102FC", VA = "0x2A102FC")]
	public UIGachaLimitContentView()
	{
	}

	[Token(Token = "0x6016455")]
	[Address(RVA = "0x2A10304", Offset = "0x2A10304", VA = "0x2A10304", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016456")]
	[Address(RVA = "0x2A1110C", Offset = "0x2A1110C", VA = "0x2A1110C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
