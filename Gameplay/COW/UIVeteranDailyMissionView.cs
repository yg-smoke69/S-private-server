using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A55")]
public class UIVeteranDailyMissionView : UIBaseView
{
	[Token(Token = "0x4018AAD")]
	[FieldOffset(Offset = "0x14")]
	public Animation MainAnimation;

	[Token(Token = "0x4018AAE")]
	[FieldOffset(Offset = "0x18")]
	public GameObject NotChooseAll;

	[Token(Token = "0x4018AAF")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ChooseBtn;

	[Token(Token = "0x4018AB0")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ChangeBtn;

	[Token(Token = "0x4018AB1")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ChangeLabel;

	[Token(Token = "0x4018AB2")]
	[FieldOffset(Offset = "0x28")]
	public UISprite TokenSprite;

	[Token(Token = "0x4018AB3")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TokenLabel;

	[Token(Token = "0x4018AB4")]
	[FieldOffset(Offset = "0x30")]
	public GameObject NotChooseCharacter;

	[Token(Token = "0x4018AB5")]
	[FieldOffset(Offset = "0x34")]
	public UIButton NotChooseCharacterBtn;

	[Token(Token = "0x4018AB6")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Content;

	[Token(Token = "0x4018AB7")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject MissionIn;

	[Token(Token = "0x4018AB8")]
	[FieldOffset(Offset = "0x40")]
	public UICountDownLabel MissionCountDownLabel;

	[Token(Token = "0x4018AB9")]
	[FieldOffset(Offset = "0x44")]
	public UIGrid DailyTaskGrid;

	[Token(Token = "0x4018ABA")]
	[FieldOffset(Offset = "0x48")]
	public GameObject InstructorContainer;

	[Token(Token = "0x4018ABB")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject WithInstructor;

	[Token(Token = "0x4018ABC")]
	[FieldOffset(Offset = "0x50")]
	public Animation WithInstructorAnimation;

	[Token(Token = "0x4018ABD")]
	[FieldOffset(Offset = "0x54")]
	public GameObject BGWithInstructor;

	[Token(Token = "0x4018ABE")]
	[FieldOffset(Offset = "0x58")]
	public UIGrid Grid;

	[Token(Token = "0x4018ABF")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton Operation;

	[Token(Token = "0x4018AC0")]
	[FieldOffset(Offset = "0x60")]
	public GameObject ClaimedState;

	[Token(Token = "0x4018AC1")]
	[FieldOffset(Offset = "0x64")]
	public GameObject UnfinishedState;

	[Token(Token = "0x4018AC2")]
	[FieldOffset(Offset = "0x68")]
	public UILabel UnfinishedTitle;

	[Token(Token = "0x4018AC3")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject FinishedState;

	[Token(Token = "0x4018AC4")]
	[FieldOffset(Offset = "0x70")]
	public UILabel FinishedTitle;

	[Token(Token = "0x4018AC5")]
	[FieldOffset(Offset = "0x74")]
	public UILabel ProgressTips;

	[Token(Token = "0x4018AC6")]
	[FieldOffset(Offset = "0x78")]
	public UILabel Desc;

	[Token(Token = "0x4018AC7")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject DescObj;

	[Token(Token = "0x4018AC8")]
	[FieldOffset(Offset = "0x80")]
	public UILabel DescLimit;

	[Token(Token = "0x4018AC9")]
	[FieldOffset(Offset = "0x84")]
	public GameObject DescLimitObj;

	[Token(Token = "0x4018ACA")]
	[FieldOffset(Offset = "0x88")]
	public GameObject WithNoInstructor;

	[Token(Token = "0x4018ACB")]
	[FieldOffset(Offset = "0x8C")]
	public Animation WithNoInstructorAnimatoin;

	[Token(Token = "0x4018ACC")]
	[FieldOffset(Offset = "0x90")]
	public GameObject BGWithNoInstructor;

	[Token(Token = "0x4018ACD")]
	[FieldOffset(Offset = "0x94")]
	public UIButton NoMissionGoto;

	[Token(Token = "0x4018ACE")]
	[FieldOffset(Offset = "0x98")]
	public UILabel NoMissionGotoLabel;

	[Token(Token = "0x4018ACF")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel NoMissionLabel;

	[Token(Token = "0x4018AD0")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel NoMissionDesc;

	[Token(Token = "0x4018AD1")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject MissionDone;

	[Token(Token = "0x4018AD2")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel DoneLabelTitle;

	[Token(Token = "0x4018AD3")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel DoneLabelCon;

	[Token(Token = "0x4018AD4")]
	[FieldOffset(Offset = "0xB0")]
	public UIButton DoneGoto;

	[Token(Token = "0x4018AD5")]
	[FieldOffset(Offset = "0xB4")]
	public UILabel DoneGotoLabel;

	[Token(Token = "0x4018AD6")]
	[FieldOffset(Offset = "0xB8")]
	public Transform StartPos;

	[Token(Token = "0x4018AD7")]
	[FieldOffset(Offset = "0xBC")]
	public Transform EndPos;

	[Token(Token = "0x4018AD8")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject ActivinessVFX;

	[Token(Token = "0x4018AD9")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject ClickMask;

	[Token(Token = "0x4018ADA")]
	[FieldOffset(Offset = "0xC8")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x60172A5")]
	[Address(RVA = "0x284F558", Offset = "0x284F558", VA = "0x284F558")]
	public UIVeteranDailyMissionView()
	{
	}

	[Token(Token = "0x60172A6")]
	[Address(RVA = "0x284F560", Offset = "0x284F560", VA = "0x284F560", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172A7")]
	[Address(RVA = "0x28506CC", Offset = "0x28506CC", VA = "0x28506CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
