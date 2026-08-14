using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003867")]
public class UIMailView : UIBaseView
{
	[Token(Token = "0x401726C")]
	[FieldOffset(Offset = "0x14")]
	public UILabel CountLabel;

	[Token(Token = "0x401726D")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView MailScrollView;

	[Token(Token = "0x401726E")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList MailList;

	[Token(Token = "0x401726F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject NoMail;

	[Token(Token = "0x4017270")]
	[FieldOffset(Offset = "0x24")]
	public Transform RightContainer;

	[Token(Token = "0x4017271")]
	[FieldOffset(Offset = "0x28")]
	public UIScrollView ContentScrollView;

	[Token(Token = "0x4017272")]
	[FieldOffset(Offset = "0x2C")]
	public UIPanel PanelMailContent;

	[Token(Token = "0x4017273")]
	[FieldOffset(Offset = "0x30")]
	public UILabel MailContent;

	[Token(Token = "0x4017274")]
	[FieldOffset(Offset = "0x34")]
	public UIScrollView GiftContentScrollView;

	[Token(Token = "0x4017275")]
	[FieldOffset(Offset = "0x38")]
	public UILabel GiftMailContent;

	[Token(Token = "0x4017276")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel MailMessage;

	[Token(Token = "0x4017277")]
	[FieldOffset(Offset = "0x40")]
	public GameObject GiftDecorate;

	[Token(Token = "0x4017278")]
	[FieldOffset(Offset = "0x44")]
	public GameObject GiftDecorate1;

	[Token(Token = "0x4017279")]
	[FieldOffset(Offset = "0x48")]
	public GameObject GiftDecorate2;

	[Token(Token = "0x401727A")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject GiftIcon;

	[Token(Token = "0x401727B")]
	[FieldOffset(Offset = "0x50")]
	public GameObject ReportContentRoot;

	[Token(Token = "0x401727C")]
	[FieldOffset(Offset = "0x54")]
	public UIScrollView ReportContentScrollView;

	[Token(Token = "0x401727D")]
	[FieldOffset(Offset = "0x58")]
	public UILabel ReportContent1;

	[Token(Token = "0x401727E")]
	[FieldOffset(Offset = "0x5C")]
	public UITable ReportContentReasonTable;

	[Token(Token = "0x401727F")]
	[FieldOffset(Offset = "0x60")]
	public UILabel ReportContent3;

	[Token(Token = "0x4017280")]
	[FieldOffset(Offset = "0x64")]
	public UILabel ReportSignature;

	[Token(Token = "0x4017281")]
	[FieldOffset(Offset = "0x68")]
	public UILabel ReportTime;

	[Token(Token = "0x4017282")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject RewardContainer;

	[Token(Token = "0x4017283")]
	[FieldOffset(Offset = "0x70")]
	public UIScrollView RewardScrollView;

	[Token(Token = "0x4017284")]
	[FieldOffset(Offset = "0x74")]
	public UIGrid RewardGrid;

	[Token(Token = "0x4017285")]
	[FieldOffset(Offset = "0x78")]
	public UILabel MailTitle;

	[Token(Token = "0x4017286")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton AcceptBtn;

	[Token(Token = "0x4017287")]
	[FieldOffset(Offset = "0x80")]
	public UIButton RejectBtn;

	[Token(Token = "0x4017288")]
	[FieldOffset(Offset = "0x84")]
	public UIButton ReceiveAllBtn;

	[Token(Token = "0x4017289")]
	[FieldOffset(Offset = "0x88")]
	public UIButton DeleteAllBtn;

	[Token(Token = "0x401728A")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton ReceiveBtn;

	[Token(Token = "0x401728B")]
	[FieldOffset(Offset = "0x90")]
	public UIButton DeleteBtn;

	[Token(Token = "0x401728C")]
	[FieldOffset(Offset = "0x94")]
	public UIButton OpenBtn;

	[Token(Token = "0x401728D")]
	[FieldOffset(Offset = "0x98")]
	public UIScrollView ReportMailScrollView;

	[Token(Token = "0x401728E")]
	[FieldOffset(Offset = "0x9C")]
	public UIEasyList ReportMailList;

	[Token(Token = "0x401728F")]
	[FieldOffset(Offset = "0xA0")]
	public UIToggleButton DailyTabBtn;

	[Token(Token = "0x4017290")]
	[FieldOffset(Offset = "0xA4")]
	public UIToggleButton ReportTabBtn;

	[Token(Token = "0x4017291")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject DailyDot;

	[Token(Token = "0x4017292")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject ReportDot;

	[Token(Token = "0x4017293")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel ReportContent2;

	[Token(Token = "0x4017294")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject ReportDetails;

	[Token(Token = "0x4017295")]
	[FieldOffset(Offset = "0xB8")]
	public UIButton GoToAppealWebBtn;

	[Token(Token = "0x4017296")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel GoToCreditLabel;

	[Token(Token = "0x4017297")]
	[FieldOffset(Offset = "0xC0")]
	public UIButton GoToCreditButton;

	[Token(Token = "0x4017298")]
	[FieldOffset(Offset = "0xC4")]
	public UISprite Daily_MailPic;

	[Token(Token = "0x4017299")]
	[FieldOffset(Offset = "0xC8")]
	public UISprite Report_MailPic;

	[Token(Token = "0x401729A")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject NoMailLabel;

	[Token(Token = "0x401729B")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel DailyMailTxt;

	[Token(Token = "0x401729C")]
	[FieldOffset(Offset = "0xD4")]
	public UILabel ReportMailTxt;

	[Token(Token = "0x6016CE0")]
	[Address(RVA = "0x18E4BC8", Offset = "0x18E4BC8", VA = "0x18E4BC8")]
	public UIMailView()
	{
	}

	[Token(Token = "0x6016CE1")]
	[Address(RVA = "0x18E4BD0", Offset = "0x18E4BD0", VA = "0x18E4BD0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CE2")]
	[Address(RVA = "0x18E5ECC", Offset = "0x18E5ECC", VA = "0x18E5ECC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
