using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200350B")]
public class UIElitePassRewardItemView : UIBaseView
{
	[Token(Token = "0x4014E93")]
	[FieldOffset(Offset = "0x14")]
	public TweenScale AnimAlpha;

	[Token(Token = "0x4014E94")]
	[FieldOffset(Offset = "0x18")]
	public TweenScale AnimScale;

	[Token(Token = "0x4014E95")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton FPContainer;

	[Token(Token = "0x4014E96")]
	[FieldOffset(Offset = "0x20")]
	public GameObject FPRewardContainer;

	[Token(Token = "0x4014E97")]
	[FieldOffset(Offset = "0x24")]
	public BaseItemView FPItemView;

	[Token(Token = "0x4014E98")]
	[FieldOffset(Offset = "0x28")]
	public UIButton FPGetBtn;

	[Token(Token = "0x4014E99")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject FPLockIcon;

	[Token(Token = "0x4014E9A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject FPTipsIcon;

	[Token(Token = "0x4014E9B")]
	[FieldOffset(Offset = "0x34")]
	public GameObject FPAchievedIcon;

	[Token(Token = "0x4014E9C")]
	[FieldOffset(Offset = "0x38")]
	public UISprite SpriteFPQualityPlus;

	[Token(Token = "0x4014E9D")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite FPBgQuality;

	[Token(Token = "0x4014E9E")]
	[FieldOffset(Offset = "0x40")]
	public UISprite FPQuality;

	[Token(Token = "0x4014E9F")]
	[FieldOffset(Offset = "0x44")]
	public GameObject FPHL;

	[Token(Token = "0x4014EA0")]
	[FieldOffset(Offset = "0x48")]
	public GameObject FPBg;

	[Token(Token = "0x4014EA1")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton EPContainer;

	[Token(Token = "0x4014EA2")]
	[FieldOffset(Offset = "0x50")]
	public GameObject EPRewardContainer;

	[Token(Token = "0x4014EA3")]
	[FieldOffset(Offset = "0x54")]
	public BaseItemView EPItemView;

	[Token(Token = "0x4014EA4")]
	[FieldOffset(Offset = "0x58")]
	public GameObject EPGetSprite;

	[Token(Token = "0x4014EA5")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton EPGetBtn;

	[Token(Token = "0x4014EA6")]
	[FieldOffset(Offset = "0x60")]
	public GameObject EPHL;

	[Token(Token = "0x4014EA7")]
	[FieldOffset(Offset = "0x64")]
	public GameObject EPLockIcon;

	[Token(Token = "0x4014EA8")]
	[FieldOffset(Offset = "0x68")]
	public GameObject EPTipsIcon;

	[Token(Token = "0x4014EA9")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject EPAchievedIcon;

	[Token(Token = "0x4014EAA")]
	[FieldOffset(Offset = "0x70")]
	public UISprite EPBgQuality;

	[Token(Token = "0x4014EAB")]
	[FieldOffset(Offset = "0x74")]
	public UISprite SpriteEPQualityPlus;

	[Token(Token = "0x4014EAC")]
	[FieldOffset(Offset = "0x78")]
	public UISprite EPQuality;

	[Token(Token = "0x4014EAD")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject EPBg;

	[Token(Token = "0x4014EAE")]
	[FieldOffset(Offset = "0x80")]
	public GameObject BigAwardEffect;

	[Token(Token = "0x4014EAF")]
	[FieldOffset(Offset = "0x84")]
	public GameObject ExclusiveAwardEffect;

	[Token(Token = "0x4014EB0")]
	[FieldOffset(Offset = "0x88")]
	public GameObject EPLockedBg;

	[Token(Token = "0x4014EB1")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton ExtraAwardContainer;

	[Token(Token = "0x4014EB2")]
	[FieldOffset(Offset = "0x90")]
	public GameObject EPExtraRewardContainer;

	[Token(Token = "0x4014EB3")]
	[FieldOffset(Offset = "0x94")]
	public BaseItemView EPExtraItemView;

	[Token(Token = "0x4014EB4")]
	[FieldOffset(Offset = "0x98")]
	public UIButton EPExtraGetBtn;

	[Token(Token = "0x4014EB5")]
	[FieldOffset(Offset = "0x9C")]
	public UIButton EPGetAllExtraBtn;

	[Token(Token = "0x4014EB6")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject EPExtraTipsIcon;

	[Token(Token = "0x4014EB7")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject MaxRewardToClaimNum;

	[Token(Token = "0x4014EB8")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel MaxRewardToClaimNumLabel;

	[Token(Token = "0x4014EB9")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject EPExtraBg;

	[Token(Token = "0x4014EBA")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject Left;

	[Token(Token = "0x4014EBB")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject Right;

	[Token(Token = "0x4014EBC")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject EPExtraHint;

	[Token(Token = "0x4014EBD")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel NextAwardLabel;

	[Token(Token = "0x4014EBE")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel CurrentAwardUnlockedLabel;

	[Token(Token = "0x4014EBF")]
	[FieldOffset(Offset = "0xC4")]
	public UIButton HelpBtn;

	[Token(Token = "0x4014EC0")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject BadgeProgress;

	[Token(Token = "0x4014EC1")]
	[FieldOffset(Offset = "0xCC")]
	public UIButton BigBadgeDot;

	[Token(Token = "0x4014EC2")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite BadgeIcon;

	[Token(Token = "0x4014EC3")]
	[FieldOffset(Offset = "0xD4")]
	public UILabel BadgeCountLabel;

	[Token(Token = "0x4014EC4")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject HighlightDot;

	[Token(Token = "0x4014EC5")]
	[FieldOffset(Offset = "0xDC")]
	public GameObject BigDotGrey;

	[Token(Token = "0x4014EC6")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject SmallBadgeDot1;

	[Token(Token = "0x4014EC7")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject SmallDotGrey1;

	[Token(Token = "0x4014EC8")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject SmallBadgeDot2;

	[Token(Token = "0x4014EC9")]
	[FieldOffset(Offset = "0xEC")]
	public GameObject SmallDotGrey2;

	[Token(Token = "0x4014ECA")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject SmallBadgeDot3;

	[Token(Token = "0x4014ECB")]
	[FieldOffset(Offset = "0xF4")]
	public GameObject SmallDotGrey3;

	[Token(Token = "0x4014ECC")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject SmallBadgeDot4;

	[Token(Token = "0x4014ECD")]
	[FieldOffset(Offset = "0xFC")]
	public GameObject SmallDotGrey4;

	[Token(Token = "0x4014ECE")]
	[FieldOffset(Offset = "0x100")]
	public GameObject BadgeProgressExtra;

	[Token(Token = "0x4014ECF")]
	[FieldOffset(Offset = "0x104")]
	public GameObject BadgeProgressExtraUnlokced;

	[Token(Token = "0x4014ED0")]
	[FieldOffset(Offset = "0x108")]
	public GameObject BadgeProgressExtraLocked;

	[Token(Token = "0x4014ED1")]
	[FieldOffset(Offset = "0x10C")]
	public UISprite SpriteEPOrangeQualityPlus;

	[Token(Token = "0x4014ED2")]
	[FieldOffset(Offset = "0x110")]
	public UISprite SpriteFPOrangeQualityPlus;

	[Token(Token = "0x4014ED3")]
	[FieldOffset(Offset = "0x114")]
	public GameObject download_FP;

	[Token(Token = "0x4014ED4")]
	[FieldOffset(Offset = "0x118")]
	public GameObject download_EP;

	[Token(Token = "0x60162D1")]
	[Address(RVA = "0x30659AC", Offset = "0x30659AC", VA = "0x30659AC")]
	public UIElitePassRewardItemView()
	{
	}

	[Token(Token = "0x60162D2")]
	[Address(RVA = "0x30659B4", Offset = "0x30659B4", VA = "0x30659B4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162D3")]
	[Address(RVA = "0x30671E8", Offset = "0x30671E8", VA = "0x30671E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
