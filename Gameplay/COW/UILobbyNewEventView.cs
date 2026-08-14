using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003847")]
public class UILobbyNewEventView : UIBaseView
{
	[Token(Token = "0x4016FBF")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIButtonBtnChampionship;

	[Token(Token = "0x4016FC0")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget UIWidgetBtnChampionship;

	[Token(Token = "0x4016FC1")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ChampionshipEffect;

	[Token(Token = "0x4016FC2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject FFCIcon;

	[Token(Token = "0x4016FC3")]
	[FieldOffset(Offset = "0x24")]
	public UITipsButton ChampionshipWarmupRedPoint;

	[Token(Token = "0x4016FC4")]
	[FieldOffset(Offset = "0x28")]
	public UITipsButton ChampionshipTrialOpenRedPoint;

	[Token(Token = "0x4016FC5")]
	[FieldOffset(Offset = "0x2C")]
	public UITipsButton ChampionshipApplyInviteRedPoint;

	[Token(Token = "0x4016FC6")]
	[FieldOffset(Offset = "0x30")]
	public GameObject FFCIconUnOpen;

	[Token(Token = "0x4016FC7")]
	[FieldOffset(Offset = "0x34")]
	public Transform ChampionshipCountDown;

	[Token(Token = "0x4016FC8")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget ChampionGuide;

	[Token(Token = "0x4016FC9")]
	[FieldOffset(Offset = "0x3C")]
	public UIGrid ActivityContainer;

	[Token(Token = "0x4016FCA")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget HDIAPBundleContainer;

	[Token(Token = "0x4016FCB")]
	[FieldOffset(Offset = "0x44")]
	public UIButton NewPlayerSigninBtn;

	[Token(Token = "0x4016FCC")]
	[FieldOffset(Offset = "0x48")]
	public GameObject NewPlayerSigninEffect;

	[Token(Token = "0x4016FCD")]
	[FieldOffset(Offset = "0x4C")]
	public Animator newPlayerIconAnimator;

	[Token(Token = "0x4016FCE")]
	[FieldOffset(Offset = "0x50")]
	public Transform NewPlayerCountDown;

	[Token(Token = "0x4016FCF")]
	[FieldOffset(Offset = "0x54")]
	public UIWidget NewPlayerTaskGuide;

	[Token(Token = "0x4016FD0")]
	[FieldOffset(Offset = "0x58")]
	public UILabel NewPlayerTaskGuideLabel;

	[Token(Token = "0x4016FD1")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton BtnPurchaseEvent;

	[Token(Token = "0x4016FD2")]
	[FieldOffset(Offset = "0x60")]
	public Transform CountDownPurchaseEvent;

	[Token(Token = "0x4016FD3")]
	[FieldOffset(Offset = "0x64")]
	public UIButton BtnLobbyGacha;

	[Token(Token = "0x4016FD4")]
	[FieldOffset(Offset = "0x68")]
	public Transform LobbyGachaCountDown;

	[Token(Token = "0x4016FD5")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject LobbyGachaIntro;

	[Token(Token = "0x4016FD6")]
	[FieldOffset(Offset = "0x70")]
	public UIButton BtnMysteryMall;

	[Token(Token = "0x4016FD7")]
	[FieldOffset(Offset = "0x74")]
	public UISprite MysteryMallTipsNew;

	[Token(Token = "0x4016FD8")]
	[FieldOffset(Offset = "0x78")]
	public Transform CountDownMysteryMall;

	[Token(Token = "0x4016FD9")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton BtnBigEventTemplate;

	[Token(Token = "0x4016FDA")]
	[FieldOffset(Offset = "0x80")]
	public UINetworkTexture TextureBtnBigEventTemplate;

	[Token(Token = "0x4016FDB")]
	[FieldOffset(Offset = "0x84")]
	public UISprite SpriteBigEventTemplateRedDot;

	[Token(Token = "0x4016FDC")]
	[FieldOffset(Offset = "0x88")]
	public Transform BigEventTemplateCountDown;

	[Token(Token = "0x4016FDD")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton VeteranSigninBtn;

	[Token(Token = "0x4016FDE")]
	[FieldOffset(Offset = "0x90")]
	public Transform VeteranSigninCountDown;

	[Token(Token = "0x4016FDF")]
	[FieldOffset(Offset = "0x94")]
	public GameObject VeteranRedDot;

	[Token(Token = "0x4016FE0")]
	[FieldOffset(Offset = "0x98")]
	public GameObject BigEventTemplateContainer;

	[Token(Token = "0x4016FE1")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject BigEventContainer;

	[Token(Token = "0x4016FE2")]
	[FieldOffset(Offset = "0xA0")]
	public UIHorizontalBox TopRightTable;

	[Token(Token = "0x4016FE3")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject LobbyCupIntro;

	[Token(Token = "0x4016FE4")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel CupIntroDialogue;

	[Token(Token = "0x4016FE5")]
	[FieldOffset(Offset = "0xAC")]
	public TweenPosition TweenPosPanelTopRight;

	[Token(Token = "0x6016C80")]
	[Address(RVA = "0x1F99BA4", Offset = "0x1F99BA4", VA = "0x1F99BA4")]
	public UILobbyNewEventView()
	{
	}

	[Token(Token = "0x6016C81")]
	[Address(RVA = "0x1F99BAC", Offset = "0x1F99BAC", VA = "0x1F99BAC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C82")]
	[Address(RVA = "0x1F9AA10", Offset = "0x1F9AA10", VA = "0x1F9AA10")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
