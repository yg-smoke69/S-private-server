using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A0E")]
public class UITrainingCampView : UIBaseView
{
	[Token(Token = "0x40187E6")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture CDNBG;

	[Token(Token = "0x40187E7")]
	[FieldOffset(Offset = "0x18")]
	public GameObject RewardContainer;

	[Token(Token = "0x40187E8")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel RewardLabel;

	[Token(Token = "0x40187E9")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid RewardList;

	[Token(Token = "0x40187EA")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ApplyContainer;

	[Token(Token = "0x40187EB")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TrainingCampName;

	[Token(Token = "0x40187EC")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid ConditionList;

	[Token(Token = "0x40187ED")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid ApplyPageReward;

	[Token(Token = "0x40187EE")]
	[FieldOffset(Offset = "0x34")]
	public GameObject IntroductionContainer;

	[Token(Token = "0x40187EF")]
	[FieldOffset(Offset = "0x38")]
	public UIGrid IntroductionConditionList;

	[Token(Token = "0x40187F0")]
	[FieldOffset(Offset = "0x3C")]
	public Transform IntroductionPageRewardPos;

	[Token(Token = "0x40187F1")]
	[FieldOffset(Offset = "0x40")]
	public UILabel TrainingCampNameForIntro;

	[Token(Token = "0x40187F2")]
	[FieldOffset(Offset = "0x44")]
	public UILabel TrainingCampTitle;

	[Token(Token = "0x40187F3")]
	[FieldOffset(Offset = "0x48")]
	public UIButton DescTipsBtn;

	[Token(Token = "0x40187F4")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject TutorPageContainer;

	[Token(Token = "0x40187F5")]
	[FieldOffset(Offset = "0x50")]
	public UISprite TutorPageTutorNameBG;

	[Token(Token = "0x40187F6")]
	[FieldOffset(Offset = "0x54")]
	public UILabel TutorPageTutorName;

	[Token(Token = "0x40187F7")]
	[FieldOffset(Offset = "0x58")]
	public UILabel TutorPageNoTagLabel;

	[Token(Token = "0x40187F8")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel TutorPageTutorTagLabel;

	[Token(Token = "0x40187F9")]
	[FieldOffset(Offset = "0x60")]
	public UISprite TutorPageTutorTag2;

	[Token(Token = "0x40187FA")]
	[FieldOffset(Offset = "0x64")]
	public UISprite TutorPageTutorTag1;

	[Token(Token = "0x40187FB")]
	[FieldOffset(Offset = "0x68")]
	public UISprite TutorPageTutorTag;

	[Token(Token = "0x40187FC")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject Student1Pos;

	[Token(Token = "0x40187FD")]
	[FieldOffset(Offset = "0x70")]
	public UISprite ConnectionLinelight1;

	[Token(Token = "0x40187FE")]
	[FieldOffset(Offset = "0x74")]
	public GameObject Student2Pos;

	[Token(Token = "0x40187FF")]
	[FieldOffset(Offset = "0x78")]
	public UISprite ConnectionLinelight2;

	[Token(Token = "0x4018800")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject Student3Pos;

	[Token(Token = "0x4018801")]
	[FieldOffset(Offset = "0x80")]
	public UISprite ConnectionLinelight3;

	[Token(Token = "0x4018802")]
	[FieldOffset(Offset = "0x84")]
	public GameObject StudentPageContainer;

	[Token(Token = "0x4018803")]
	[FieldOffset(Offset = "0x88")]
	public UIWidget TutorAvatarPos;

	[Token(Token = "0x4018804")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton TutorAvatarBtn;

	[Token(Token = "0x4018805")]
	[FieldOffset(Offset = "0x90")]
	public GameObject Loading;

	[Token(Token = "0x4018806")]
	[FieldOffset(Offset = "0x94")]
	public UIWidget StudentAvatarPos;

	[Token(Token = "0x4018807")]
	[FieldOffset(Offset = "0x98")]
	public GameObject StudentPageCountDown;

	[Token(Token = "0x4018808")]
	[FieldOffset(Offset = "0x9C")]
	public UICountDownLabel CountDown;

	[Token(Token = "0x4018809")]
	[FieldOffset(Offset = "0xA0")]
	public UISprite StudentPageTutorNameBG;

	[Token(Token = "0x401880A")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel StudentPageTutorName;

	[Token(Token = "0x401880B")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel StudentPageNoTagLabel;

	[Token(Token = "0x401880C")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel StudentPageTutorTagLabel;

	[Token(Token = "0x401880D")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite StudentPageTutorTag2;

	[Token(Token = "0x401880E")]
	[FieldOffset(Offset = "0xB4")]
	public UISprite StudentPageTutorTag1;

	[Token(Token = "0x401880F")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite StudentPageTutorTag;

	[Token(Token = "0x4018810")]
	[FieldOffset(Offset = "0xBC")]
	public UIButton GraduateBtn;

	[Token(Token = "0x4018811")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject StudentScoreLabel;

	[Token(Token = "0x4018812")]
	[FieldOffset(Offset = "0xC4")]
	public UILabel StudentScore;

	[Token(Token = "0x4018813")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel StudentPageStudentName;

	[Token(Token = "0x4018814")]
	[FieldOffset(Offset = "0xCC")]
	public UISprite StudentPageStudentNameBG;

	[Token(Token = "0x4018815")]
	[FieldOffset(Offset = "0xD0")]
	public UIButton TaskBtn;

	[Token(Token = "0x4018816")]
	[FieldOffset(Offset = "0xD4")]
	public UIGrid StudentGrid;

	[Token(Token = "0x4018817")]
	[FieldOffset(Offset = "0xD8")]
	public UISprite Student1NoInfo;

	[Token(Token = "0x4018818")]
	[FieldOffset(Offset = "0xDC")]
	public UIButton Student1InfoBtn;

	[Token(Token = "0x4018819")]
	[FieldOffset(Offset = "0xE0")]
	public UISprite Student1HeadPic;

	[Token(Token = "0x401881A")]
	[FieldOffset(Offset = "0xE4")]
	public UILabel Student1NameLabel;

	[Token(Token = "0x401881B")]
	[FieldOffset(Offset = "0xE8")]
	public UISprite Student2NoInfo;

	[Token(Token = "0x401881C")]
	[FieldOffset(Offset = "0xEC")]
	public UIButton Student2InfoBtn;

	[Token(Token = "0x401881D")]
	[FieldOffset(Offset = "0xF0")]
	public UISprite Student2HeadPic;

	[Token(Token = "0x401881E")]
	[FieldOffset(Offset = "0xF4")]
	public UILabel Student2NameLabel;

	[Token(Token = "0x401881F")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject SideListContainer;

	[Token(Token = "0x4018820")]
	[FieldOffset(Offset = "0xFC")]
	public UIButton CloseBtn;

	[Token(Token = "0x4018821")]
	[FieldOffset(Offset = "0x100")]
	public GameObject ProgressContainer;

	[Token(Token = "0x4018822")]
	[FieldOffset(Offset = "0x104")]
	public UISprite ProgressBarFG;

	[Token(Token = "0x4018823")]
	[FieldOffset(Offset = "0x108")]
	public GameObject ProgressBarVFX;

	[Token(Token = "0x4018824")]
	[FieldOffset(Offset = "0x10C")]
	public GameObject EffectProgressBar;

	[Token(Token = "0x4018825")]
	[FieldOffset(Offset = "0x110")]
	public UILabel ProgressRewardLabel;

	[Token(Token = "0x4018826")]
	[FieldOffset(Offset = "0x114")]
	public UISprite ProgressBar;

	[Token(Token = "0x4018827")]
	[FieldOffset(Offset = "0x118")]
	public UIProgressBar UIProgressBar;

	[Token(Token = "0x4018828")]
	[FieldOffset(Offset = "0x11C")]
	public UIGrid BtnGrid;

	[Token(Token = "0x4018829")]
	[FieldOffset(Offset = "0x120")]
	public UIButton MessageBtn;

	[Token(Token = "0x401882A")]
	[FieldOffset(Offset = "0x124")]
	public UIButton ApplyBtn;

	[Token(Token = "0x401882B")]
	[FieldOffset(Offset = "0x128")]
	public GameObject ApplyBtnEnabled;

	[Token(Token = "0x401882C")]
	[FieldOffset(Offset = "0x12C")]
	public GameObject ApplyBtnDisabled;

	[Token(Token = "0x401882D")]
	[FieldOffset(Offset = "0x130")]
	public GameObject Student1ConnectionLinelight;

	[Token(Token = "0x401882E")]
	[FieldOffset(Offset = "0x134")]
	public GameObject Student2ConnectionLinelight;

	[Token(Token = "0x401882F")]
	[FieldOffset(Offset = "0x138")]
	public UIGrid StudentGraduateRewardList;

	[Token(Token = "0x4018830")]
	[FieldOffset(Offset = "0x13C")]
	public GameObject StudentPageAward;

	[Token(Token = "0x4018831")]
	[FieldOffset(Offset = "0x140")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x60171D0")]
	[Address(RVA = "0x1C24B70", Offset = "0x1C24B70", VA = "0x1C24B70")]
	public UITrainingCampView()
	{
	}

	[Token(Token = "0x60171D1")]
	[Address(RVA = "0x1C24B78", Offset = "0x1C24B78", VA = "0x1C24B78", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171D2")]
	[Address(RVA = "0x1C26828", Offset = "0x1C26828", VA = "0x1C26828")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
