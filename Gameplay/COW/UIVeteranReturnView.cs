using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A5E")]
public class UIVeteranReturnView : UIBaseView
{
	[Token(Token = "0x4018B68")]
	[FieldOffset(Offset = "0x14")]
	public Animation main;

	[Token(Token = "0x4018B69")]
	[FieldOffset(Offset = "0x18")]
	public GameObject LabelArea;

	[Token(Token = "0x4018B6A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject AwakeFeelingReturn;

	[Token(Token = "0x4018B6B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel StartDate;

	[Token(Token = "0x4018B6C")]
	[FieldOffset(Offset = "0x24")]
	public TypewriterEffect StartDateType;

	[Token(Token = "0x4018B6D")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LandOnLabel;

	[Token(Token = "0x4018B6E")]
	[FieldOffset(Offset = "0x2C")]
	public TypewriterEffect LandOnLabelType;

	[Token(Token = "0x4018B6F")]
	[FieldOffset(Offset = "0x30")]
	public UILabel PlayTimeLabel;

	[Token(Token = "0x4018B70")]
	[FieldOffset(Offset = "0x34")]
	public TypewriterEffect PlayTimeLabelType;

	[Token(Token = "0x4018B71")]
	[FieldOffset(Offset = "0x38")]
	public GameObject PlayTimeLabel2;

	[Token(Token = "0x4018B72")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject BRPerformanceReview;

	[Token(Token = "0x4018B73")]
	[FieldOffset(Offset = "0x40")]
	public UIGrid BRLabelGrid;

	[Token(Token = "0x4018B74")]
	[FieldOffset(Offset = "0x44")]
	public Animation BRLifeTimeObj;

	[Token(Token = "0x4018B75")]
	[FieldOffset(Offset = "0x48")]
	public UILabel BRLifeTimeLabel;

	[Token(Token = "0x4018B76")]
	[FieldOffset(Offset = "0x4C")]
	public Animation BRTotalKillObj;

	[Token(Token = "0x4018B77")]
	[FieldOffset(Offset = "0x50")]
	public UILabel BRTotalKillLabel;

	[Token(Token = "0x4018B78")]
	[FieldOffset(Offset = "0x54")]
	public Animation BRSingleMaxKillObj;

	[Token(Token = "0x4018B79")]
	[FieldOffset(Offset = "0x58")]
	public UILabel BRSingleMaxKillLabel;

	[Token(Token = "0x4018B7A")]
	[FieldOffset(Offset = "0x5C")]
	public Animation BRRescueTeammatesTimesObj;

	[Token(Token = "0x4018B7B")]
	[FieldOffset(Offset = "0x60")]
	public UILabel BRRescueTeammatesTimesLabel;

	[Token(Token = "0x4018B7C")]
	[FieldOffset(Offset = "0x64")]
	public Animation BRTotalSurvivalTimeObj;

	[Token(Token = "0x4018B7D")]
	[FieldOffset(Offset = "0x68")]
	public UILabel BRTotalSurvivalTimeLabel;

	[Token(Token = "0x4018B7E")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel BRModeName;

	[Token(Token = "0x4018B7F")]
	[FieldOffset(Offset = "0x70")]
	public GameObject CSPerformanceReview;

	[Token(Token = "0x4018B80")]
	[FieldOffset(Offset = "0x74")]
	public UIGrid CSLabelGrid;

	[Token(Token = "0x4018B81")]
	[FieldOffset(Offset = "0x78")]
	public Animation CSLifeTimeObj;

	[Token(Token = "0x4018B82")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel CSLifeTimeLabel;

	[Token(Token = "0x4018B83")]
	[FieldOffset(Offset = "0x80")]
	public Animation CSQuadrKillTimesObj;

	[Token(Token = "0x4018B84")]
	[FieldOffset(Offset = "0x84")]
	public UILabel CSQuadrKillTimesLabel;

	[Token(Token = "0x4018B85")]
	[FieldOffset(Offset = "0x88")]
	public Animation CSTripleKillTimesObj;

	[Token(Token = "0x4018B86")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel CSTripleKillTimesLabel;

	[Token(Token = "0x4018B87")]
	[FieldOffset(Offset = "0x90")]
	public Animation CSMVPTimesObj;

	[Token(Token = "0x4018B88")]
	[FieldOffset(Offset = "0x94")]
	public UILabel CSMVPTimesLabel;

	[Token(Token = "0x4018B89")]
	[FieldOffset(Offset = "0x98")]
	public Animation CSWinRateObj;

	[Token(Token = "0x4018B8A")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel CSWinRateLabel;

	[Token(Token = "0x4018B8B")]
	[FieldOffset(Offset = "0xA0")]
	public Animation CSTotalKillObj;

	[Token(Token = "0x4018B8C")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel CSTotalKillLabel;

	[Token(Token = "0x4018B8D")]
	[FieldOffset(Offset = "0xA8")]
	public Animation CSHeadshotKillRateObj;

	[Token(Token = "0x4018B8E")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel CSHeadshotKillRateLabel;

	[Token(Token = "0x4018B8F")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel CSModeName;

	[Token(Token = "0x4018B90")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject NewGuns;

	[Token(Token = "0x4018B91")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel PlayerID;

	[Token(Token = "0x4018B92")]
	[FieldOffset(Offset = "0xBC")]
	public UIScrollView ActivityScrollView;

	[Token(Token = "0x4018B93")]
	[FieldOffset(Offset = "0xC0")]
	public UITable NewLabelTable;

	[Token(Token = "0x4018B94")]
	[FieldOffset(Offset = "0xC4")]
	public UILabel LeavingTimeLabel;

	[Token(Token = "0x4018B95")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel NewActivityAndModeLabel;

	[Token(Token = "0x4018B96")]
	[FieldOffset(Offset = "0xCC")]
	public UILabel NewGunsLabel;

	[Token(Token = "0x4018B97")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel AwardTipsLabel;

	[Token(Token = "0x4018B98")]
	[FieldOffset(Offset = "0xD4")]
	public UIButton NextBtn;

	[Token(Token = "0x4018B99")]
	[FieldOffset(Offset = "0xD8")]
	public Animation main2;

	[Token(Token = "0x4018B9A")]
	[FieldOffset(Offset = "0xDC")]
	public UILabel LabelNext;

	[Token(Token = "0x4018B9B")]
	[FieldOffset(Offset = "0xE0")]
	public UIButton CloseBtn;

	[Token(Token = "0x4018B9C")]
	[FieldOffset(Offset = "0xE4")]
	public Animation mainclose;

	[Token(Token = "0x4018B9D")]
	[FieldOffset(Offset = "0xE8")]
	public Animation main3;

	[Token(Token = "0x60172C0")]
	[Address(RVA = "0x2CBB26C", Offset = "0x2CBB26C", VA = "0x2CBB26C")]
	public UIVeteranReturnView()
	{
	}

	[Token(Token = "0x60172C1")]
	[Address(RVA = "0x2CBB274", Offset = "0x2CBB274", VA = "0x2CBB274", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172C2")]
	[Address(RVA = "0x2CBC7B4", Offset = "0x2CBC7B4", VA = "0x2CBC7B4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
