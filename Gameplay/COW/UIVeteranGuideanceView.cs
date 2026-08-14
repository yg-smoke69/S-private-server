using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A58")]
public class UIVeteranGuideanceView : UIBaseView
{
	[Token(Token = "0x4018AF5")]
	[FieldOffset(Offset = "0x14")]
	public Animation AnimationMain;

	[Token(Token = "0x4018AF6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject CountDown;

	[Token(Token = "0x4018AF7")]
	[FieldOffset(Offset = "0x1C")]
	public UICountDownLabel LabelDate;

	[Token(Token = "0x4018AF8")]
	[FieldOffset(Offset = "0x20")]
	public UIButton VeteranSign;

	[Token(Token = "0x4018AF9")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SignIcon;

	[Token(Token = "0x4018AFA")]
	[FieldOffset(Offset = "0x28")]
	public UILabel SignLabel;

	[Token(Token = "0x4018AFB")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton IntroductionBtn;

	[Token(Token = "0x4018AFC")]
	[FieldOffset(Offset = "0x30")]
	public GameObject GiftPreviewTab;

	[Token(Token = "0x4018AFD")]
	[FieldOffset(Offset = "0x34")]
	public Transform GiftPre1;

	[Token(Token = "0x4018AFE")]
	[FieldOffset(Offset = "0x38")]
	public Transform GiftPre2;

	[Token(Token = "0x4018AFF")]
	[FieldOffset(Offset = "0x3C")]
	public Transform GiftPre3;

	[Token(Token = "0x4018B00")]
	[FieldOffset(Offset = "0x40")]
	public Transform GiftPre4;

	[Token(Token = "0x4018B01")]
	[FieldOffset(Offset = "0x44")]
	public Transform GiftPre5;

	[Token(Token = "0x4018B02")]
	[FieldOffset(Offset = "0x48")]
	public Transform GiftPre6;

	[Token(Token = "0x4018B03")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton VeteranShop;

	[Token(Token = "0x4018B04")]
	[FieldOffset(Offset = "0x50")]
	public GameObject NotChooseCharacter;

	[Token(Token = "0x4018B05")]
	[FieldOffset(Offset = "0x54")]
	public UIButton NotChooseCharacterBtn;

	[Token(Token = "0x4018B06")]
	[FieldOffset(Offset = "0x58")]
	public GameObject NotChooseAll;

	[Token(Token = "0x4018B07")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton ChooseBtn;

	[Token(Token = "0x4018B08")]
	[FieldOffset(Offset = "0x60")]
	public GameObject ClickMask;

	[Token(Token = "0x4018B09")]
	[FieldOffset(Offset = "0x64")]
	public UILabel DailyNotesTitle;

	[Token(Token = "0x4018B0A")]
	[FieldOffset(Offset = "0x68")]
	public UILabel DailyNotesContent;

	[Token(Token = "0x4018B0B")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton DailyNotesBtn;

	[Token(Token = "0x4018B0C")]
	[FieldOffset(Offset = "0x70")]
	public UILabel NotesLabel;

	[Token(Token = "0x4018B0D")]
	[FieldOffset(Offset = "0x74")]
	public UILabel RewardsToken;

	[Token(Token = "0x4018B0E")]
	[FieldOffset(Offset = "0x78")]
	public UIButton TokenSpriteBtn;

	[Token(Token = "0x4018B0F")]
	[FieldOffset(Offset = "0x7C")]
	public Animation AnimationClick;

	[Token(Token = "0x4018B10")]
	[FieldOffset(Offset = "0x80")]
	public UIButton TaskBtn;

	[Token(Token = "0x4018B11")]
	[FieldOffset(Offset = "0x84")]
	public UILabel TaskLabel;

	[Token(Token = "0x4018B12")]
	[FieldOffset(Offset = "0x88")]
	public UIButton TaskProgressBtn;

	[Token(Token = "0x4018B13")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel TaskNumLabel;

	[Token(Token = "0x4018B14")]
	[FieldOffset(Offset = "0x90")]
	public UISprite ProgressBarFront1;

	[Token(Token = "0x4018B15")]
	[FieldOffset(Offset = "0x94")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x60172AE")]
	[Address(RVA = "0x2857D28", Offset = "0x2857D28", VA = "0x2857D28")]
	public UIVeteranGuideanceView()
	{
	}

	[Token(Token = "0x60172AF")]
	[Address(RVA = "0x2857D30", Offset = "0x2857D30", VA = "0x2857D30", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172B0")]
	[Address(RVA = "0x28589A0", Offset = "0x28589A0", VA = "0x28589A0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
