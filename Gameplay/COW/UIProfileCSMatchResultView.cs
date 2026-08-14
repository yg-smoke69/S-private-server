using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003922")]
public class UIProfileCSMatchResultView : UIBaseView
{
	[Token(Token = "0x4017C78")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ShareGameModeTxt;

	[Token(Token = "0x4017C79")]
	[FieldOffset(Offset = "0x18")]
	public GameObject MaskBG;

	[Token(Token = "0x4017C7A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Defeat;

	[Token(Token = "0x4017C7B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ResultDesc;

	[Token(Token = "0x4017C7C")]
	[FieldOffset(Offset = "0x24")]
	public UILabel GameModeTxt;

	[Token(Token = "0x4017C7D")]
	[FieldOffset(Offset = "0x28")]
	public UILabel GameMapTxt;

	[Token(Token = "0x4017C7E")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Victory;

	[Token(Token = "0x4017C7F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BiaoQianContainer;

	[Token(Token = "0x4017C80")]
	[FieldOffset(Offset = "0x34")]
	public UIWidget Biaoqian1;

	[Token(Token = "0x4017C81")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget Biaoqian2;

	[Token(Token = "0x4017C82")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget Biaoqian3;

	[Token(Token = "0x4017C83")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget Biaoqian4;

	[Token(Token = "0x4017C84")]
	[FieldOffset(Offset = "0x44")]
	public UIWidget PlaceHolderBiaoqian;

	[Token(Token = "0x4017C85")]
	[FieldOffset(Offset = "0x48")]
	public GameObject DetailInfoUI;

	[Token(Token = "0x4017C86")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite LeftTeamScoreBG;

	[Token(Token = "0x4017C87")]
	[FieldOffset(Offset = "0x50")]
	public UILabel LeftTeamScore;

	[Token(Token = "0x4017C88")]
	[FieldOffset(Offset = "0x54")]
	public GameObject LeftTeamDividingLine;

	[Token(Token = "0x4017C89")]
	[FieldOffset(Offset = "0x58")]
	public GameObject LeftTeamDefaultIconOB;

	[Token(Token = "0x4017C8A")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject LeftTeamDefaultIcon;

	[Token(Token = "0x4017C8B")]
	[FieldOffset(Offset = "0x60")]
	public UISprite LeftTeamIcon;

	[Token(Token = "0x4017C8C")]
	[FieldOffset(Offset = "0x64")]
	public UILabel LeftTeamName;

	[Token(Token = "0x4017C8D")]
	[FieldOffset(Offset = "0x68")]
	public UISprite LeftTeamCustomIcon;

	[Token(Token = "0x4017C8E")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel LeftTitleInfo1Txt;

	[Token(Token = "0x4017C8F")]
	[FieldOffset(Offset = "0x70")]
	public UILabel LeftTitleInfo2Txt;

	[Token(Token = "0x4017C90")]
	[FieldOffset(Offset = "0x74")]
	public UILabel LeftTitleInfo3Txt;

	[Token(Token = "0x4017C91")]
	[FieldOffset(Offset = "0x78")]
	public UIGrid LeftTeammateGrid;

	[Token(Token = "0x4017C92")]
	[FieldOffset(Offset = "0x7C")]
	public Transform LeftTeammateContainer;

	[Token(Token = "0x4017C93")]
	[FieldOffset(Offset = "0x80")]
	public UISprite RightTeamScoreBG;

	[Token(Token = "0x4017C94")]
	[FieldOffset(Offset = "0x84")]
	public UILabel RightTeamScore;

	[Token(Token = "0x4017C95")]
	[FieldOffset(Offset = "0x88")]
	public GameObject RightTeamDividingLine;

	[Token(Token = "0x4017C96")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject RightTeamDefaultIconOB;

	[Token(Token = "0x4017C97")]
	[FieldOffset(Offset = "0x90")]
	public GameObject RightTeamDefaultIcon;

	[Token(Token = "0x4017C98")]
	[FieldOffset(Offset = "0x94")]
	public UISprite RightTeamIcon;

	[Token(Token = "0x4017C99")]
	[FieldOffset(Offset = "0x98")]
	public UILabel RightTeamName;

	[Token(Token = "0x4017C9A")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite RightTeamCustomIcon;

	[Token(Token = "0x4017C9B")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel RightTitleInfo1Txt;

	[Token(Token = "0x4017C9C")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel RightTitleInfo2Txt;

	[Token(Token = "0x4017C9D")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel RightTitleInfo3Txt;

	[Token(Token = "0x4017C9E")]
	[FieldOffset(Offset = "0xAC")]
	public UIGrid RightTeammateGrid;

	[Token(Token = "0x4017C9F")]
	[FieldOffset(Offset = "0xB0")]
	public Transform RightTeammateContainer;

	[Token(Token = "0x4017CA0")]
	[FieldOffset(Offset = "0xB4")]
	public UIButton ShareBtn;

	[Token(Token = "0x4017CA1")]
	[FieldOffset(Offset = "0xB8")]
	public UIButton NextBtn;

	[Token(Token = "0x4017CA2")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel NextBtnLable;

	[Token(Token = "0x4017CA3")]
	[FieldOffset(Offset = "0xC0")]
	public UIGrid RewardBtnGrid;

	[Token(Token = "0x4017CA4")]
	[FieldOffset(Offset = "0xC4")]
	public UIButton FastSendGiftBtn;

	[Token(Token = "0x4017CA5")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel DataBtnLabel;

	[Token(Token = "0x4017CA6")]
	[FieldOffset(Offset = "0xCC")]
	public UIButton DataBtn;

	[Token(Token = "0x4017CA7")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject RightNormalTitleRoot;

	[Token(Token = "0x4017CA8")]
	[FieldOffset(Offset = "0xD4")]
	public UILabel RightTitleDataTxt;

	[Token(Token = "0x4017CA9")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject LeftNormalTitleRoot;

	[Token(Token = "0x4017CAA")]
	[FieldOffset(Offset = "0xDC")]
	public UILabel LeftTitleDataTxt;

	[Token(Token = "0x4017CAB")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject LeftTitlePlayerTxt;

	[Token(Token = "0x4017CAC")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject RightTitlePlayerTxt;

	[Token(Token = "0x4017CAD")]
	[FieldOffset(Offset = "0xE8")]
	public UIButton report;

	[Token(Token = "0x4017CAE")]
	[FieldOffset(Offset = "0xEC")]
	public UISprite DataBtnIcon;

	[Token(Token = "0x6016F0D")]
	[Address(RVA = "0xF11BD0", Offset = "0xF11BD0", VA = "0xF11BD0")]
	public UIProfileCSMatchResultView()
	{
	}

	[Token(Token = "0x6016F0E")]
	[Address(RVA = "0xF11BD8", Offset = "0xF11BD8", VA = "0xF11BD8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F0F")]
	[Address(RVA = "0xF130BC", Offset = "0xF130BC", VA = "0xF130BC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
