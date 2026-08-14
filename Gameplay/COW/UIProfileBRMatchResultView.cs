using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200391D")]
public class UIProfileBRMatchResultView : UIBaseView
{
	[Token(Token = "0x4017C46")]
	[FieldOffset(Offset = "0x14")]
	public GameObject MaskBG;

	[Token(Token = "0x4017C47")]
	[FieldOffset(Offset = "0x18")]
	public UILabel RankNum;

	[Token(Token = "0x4017C48")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TotalNum;

	[Token(Token = "0x4017C49")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ResultDesc;

	[Token(Token = "0x4017C4A")]
	[FieldOffset(Offset = "0x24")]
	public UILabel GameModeTxt;

	[Token(Token = "0x4017C4B")]
	[FieldOffset(Offset = "0x28")]
	public UILabel GameMapTxt;

	[Token(Token = "0x4017C4C")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BiaoQianContainer;

	[Token(Token = "0x4017C4D")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget Biaoqian1;

	[Token(Token = "0x4017C4E")]
	[FieldOffset(Offset = "0x34")]
	public UIWidget Biaoqian2;

	[Token(Token = "0x4017C4F")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget Biaoqian3;

	[Token(Token = "0x4017C50")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget Biaoqian4;

	[Token(Token = "0x4017C51")]
	[FieldOffset(Offset = "0x40")]
	public GameObject DetailInfoUI;

	[Token(Token = "0x4017C52")]
	[FieldOffset(Offset = "0x44")]
	public UILabel TitleInfo4Txt;

	[Token(Token = "0x4017C53")]
	[FieldOffset(Offset = "0x48")]
	public UILabel TitleInfo3Txt;

	[Token(Token = "0x4017C54")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel TitleInfo2Txt;

	[Token(Token = "0x4017C55")]
	[FieldOffset(Offset = "0x50")]
	public UILabel TitleInfo1Txt;

	[Token(Token = "0x4017C56")]
	[FieldOffset(Offset = "0x54")]
	public Transform PlayerItemInfo1;

	[Token(Token = "0x4017C57")]
	[FieldOffset(Offset = "0x58")]
	public Transform PlayerItemInfo2;

	[Token(Token = "0x4017C58")]
	[FieldOffset(Offset = "0x5C")]
	public Transform PlayerItemInfo3;

	[Token(Token = "0x4017C59")]
	[FieldOffset(Offset = "0x60")]
	public Transform PlayerItemInfo4;

	[Token(Token = "0x4017C5A")]
	[FieldOffset(Offset = "0x64")]
	public UIButton ShareBtn;

	[Token(Token = "0x4017C5B")]
	[FieldOffset(Offset = "0x68")]
	public UIButton NextBtn;

	[Token(Token = "0x4017C5C")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel NextBtnLable;

	[Token(Token = "0x4017C5D")]
	[FieldOffset(Offset = "0x70")]
	public UIGrid RewardBtnGrid;

	[Token(Token = "0x4017C5E")]
	[FieldOffset(Offset = "0x74")]
	public UIButton FastSendGiftBtn;

	[Token(Token = "0x4017C5F")]
	[FieldOffset(Offset = "0x78")]
	public UILabel ShareGameModeTxt;

	[Token(Token = "0x4017C60")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton DataBtn;

	[Token(Token = "0x4017C61")]
	[FieldOffset(Offset = "0x80")]
	public GameObject NormalTitleRoot;

	[Token(Token = "0x4017C62")]
	[FieldOffset(Offset = "0x84")]
	public UILabel TitleDataTxt;

	[Token(Token = "0x4017C63")]
	[FieldOffset(Offset = "0x88")]
	public UILabel TitleInfo5Txt;

	[Token(Token = "0x4017C64")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject TitlePlayerTxt;

	[Token(Token = "0x4017C65")]
	[FieldOffset(Offset = "0x90")]
	public UIButton report;

	[Token(Token = "0x4017C66")]
	[FieldOffset(Offset = "0x94")]
	public UILabel DataBtnLabel;

	[Token(Token = "0x4017C67")]
	[FieldOffset(Offset = "0x98")]
	public UISprite DataBtnIcon;

	[Token(Token = "0x6016EFE")]
	[Address(RVA = "0xF09B88", Offset = "0xF09B88", VA = "0xF09B88")]
	public UIProfileBRMatchResultView()
	{
	}

	[Token(Token = "0x6016EFF")]
	[Address(RVA = "0xF09B90", Offset = "0xF09B90", VA = "0xF09B90", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F00")]
	[Address(RVA = "0xF0A8BC", Offset = "0xF0A8BC", VA = "0xF0A8BC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
