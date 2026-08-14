using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003507")]
public class UIElitePassMainWindowView : UIBaseView
{
	[Token(Token = "0x4014E35")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ClaimAllBtn;

	[Token(Token = "0x4014E36")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4014E37")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList RewardList;

	[Token(Token = "0x4014E38")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ElitePassIcon;

	[Token(Token = "0x4014E39")]
	[FieldOffset(Offset = "0x24")]
	public UIButton PrivilegeBtn1;

	[Token(Token = "0x4014E3A")]
	[FieldOffset(Offset = "0x28")]
	public UIButton EPLockBtn;

	[Token(Token = "0x4014E3B")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton PreOrderEPBtn;

	[Token(Token = "0x4014E3C")]
	[FieldOffset(Offset = "0x30")]
	public UISprite PreorderIcon;

	[Token(Token = "0x4014E3D")]
	[FieldOffset(Offset = "0x34")]
	public UILabel PreorderLabel;

	[Token(Token = "0x4014E3E")]
	[FieldOffset(Offset = "0x38")]
	public UIButton SubscribeEPBtn;

	[Token(Token = "0x4014E3F")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite SubscribeIcon;

	[Token(Token = "0x4014E40")]
	[FieldOffset(Offset = "0x40")]
	public UISprite SubscriptionBonus;

	[Token(Token = "0x4014E41")]
	[FieldOffset(Offset = "0x44")]
	public UILabel SubscriptionBonusAmountLabel;

	[Token(Token = "0x4014E42")]
	[FieldOffset(Offset = "0x48")]
	public UILabel SubscribeLabel;

	[Token(Token = "0x4014E43")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite SubscriptionTips;

	[Token(Token = "0x4014E44")]
	[FieldOffset(Offset = "0x50")]
	public UISprite SubscribedPanel;

	[Token(Token = "0x4014E45")]
	[FieldOffset(Offset = "0x54")]
	public UIButton SubscribeHintBtn;

	[Token(Token = "0x4014E46")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ElitePassIconUpdated;

	[Token(Token = "0x4014E47")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton PrivilegeBtn2;

	[Token(Token = "0x4014E48")]
	[FieldOffset(Offset = "0x60")]
	public GameObject ContentScrollBar;

	[Token(Token = "0x4014E49")]
	[FieldOffset(Offset = "0x64")]
	public UISprite ScrollbarBg;

	[Token(Token = "0x4014E4A")]
	[FieldOffset(Offset = "0x68")]
	public UIButton BigAwardMark;

	[Token(Token = "0x4014E4B")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject CurProgressMark;

	[Token(Token = "0x4014E4C")]
	[FieldOffset(Offset = "0x70")]
	public Transform CountDown;

	[Token(Token = "0x4014E4D")]
	[FieldOffset(Offset = "0x74")]
	public UISprite BadgeCountIconSprite;

	[Token(Token = "0x4014E4E")]
	[FieldOffset(Offset = "0x78")]
	public UIButton badgeInfoBtn;

	[Token(Token = "0x4014E4F")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel BadgeCount;

	[Token(Token = "0x4014E50")]
	[FieldOffset(Offset = "0x80")]
	public UIButton GetBadgeButton;

	[Token(Token = "0x4014E51")]
	[FieldOffset(Offset = "0x84")]
	public UINetworkTexture CDNTheme;

	[Token(Token = "0x4014E52")]
	[FieldOffset(Offset = "0x88")]
	public GameObject BottomSubscribePreorder;

	[Token(Token = "0x4014E53")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton UpgradeEPBtn;

	[Token(Token = "0x4014E54")]
	[FieldOffset(Offset = "0x90")]
	public UIButton BuyBadgeBtn;

	[Token(Token = "0x4014E55")]
	[FieldOffset(Offset = "0x94")]
	public UIButton EPQuestBtn;

	[Token(Token = "0x4014E56")]
	[FieldOffset(Offset = "0x98")]
	public GameObject ChallengeTips;

	[Token(Token = "0x4014E57")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject TipGetMore;

	[Token(Token = "0x4014E58")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel TipNeedBadgeCnt;

	[Token(Token = "0x4014E59")]
	[FieldOffset(Offset = "0xA4")]
	public UIButton TipNeedBadgeBtn;

	[Token(Token = "0x4014E5A")]
	[FieldOffset(Offset = "0xA8")]
	public UIButton GetMoreBtn;

	[Token(Token = "0x4014E5B")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject TipUpgrade;

	[Token(Token = "0x4014E5C")]
	[FieldOffset(Offset = "0xB0")]
	public UIButton TipUpgradeBtn;

	[Token(Token = "0x4014E5D")]
	[FieldOffset(Offset = "0xB4")]
	public UIButton UpgradeBtn;

	[Token(Token = "0x4014E5E")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel SubscribeInfoLabel;

	[Token(Token = "0x4014E5F")]
	[FieldOffset(Offset = "0xBC")]
	public UIButton SubscribedInfoBtn;

	[Token(Token = "0x4014E60")]
	[FieldOffset(Offset = "0xC0")]
	public UICountDownLabel SubscribedCountDown;

	[Token(Token = "0x4014E61")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject BottomNormal;

	[Token(Token = "0x4014E62")]
	[FieldOffset(Offset = "0xC8")]
	public UIButton UpgradeEPBtn2;

	[Token(Token = "0x4014E63")]
	[FieldOffset(Offset = "0xCC")]
	public UIButton BuyBadgeBtn2;

	[Token(Token = "0x4014E64")]
	[FieldOffset(Offset = "0xD0")]
	public UIButton EPQuestBtn2;

	[Token(Token = "0x4014E65")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject ChallengeTips2;

	[Token(Token = "0x4014E66")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject TipGetMore2;

	[Token(Token = "0x4014E67")]
	[FieldOffset(Offset = "0xDC")]
	public UILabel TipNeedBadgeCnt2;

	[Token(Token = "0x4014E68")]
	[FieldOffset(Offset = "0xE0")]
	public UIButton TipNeedBadgeBtn2;

	[Token(Token = "0x4014E69")]
	[FieldOffset(Offset = "0xE4")]
	public UIButton GetMoreBtn2;

	[Token(Token = "0x4014E6A")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject TipUpgrade2;

	[Token(Token = "0x4014E6B")]
	[FieldOffset(Offset = "0xEC")]
	public UIButton TipUpgradeBtn2;

	[Token(Token = "0x4014E6C")]
	[FieldOffset(Offset = "0xF0")]
	public UIButton UpgradeBtn2;

	[Token(Token = "0x4014E6D")]
	[FieldOffset(Offset = "0xF4")]
	public UIButton BadgeRankingButton;

	[Token(Token = "0x4014E6E")]
	[FieldOffset(Offset = "0xF8")]
	public UIButton Video_play;

	[Token(Token = "0x4014E6F")]
	[FieldOffset(Offset = "0xFC")]
	public GameObject NewEffect;

	[Token(Token = "0x4014E70")]
	[FieldOffset(Offset = "0x100")]
	public UIButton WebsiteButton;

	[Token(Token = "0x4014E71")]
	[FieldOffset(Offset = "0x104")]
	public GameObject Anim;

	[Token(Token = "0x4014E72")]
	[FieldOffset(Offset = "0x108")]
	public UIButton AnimPlayBtn;

	[Token(Token = "0x4014E73")]
	[FieldOffset(Offset = "0x10C")]
	public UISprite AnimPlayBtnSprite;

	[Token(Token = "0x4014E74")]
	[FieldOffset(Offset = "0x110")]
	public UIButton DocumentButton;

	[Token(Token = "0x4014E75")]
	[FieldOffset(Offset = "0x114")]
	public UINetworkTexture CDNTexture;

	[Token(Token = "0x4014E76")]
	[FieldOffset(Offset = "0x118")]
	public Transform LeftPosition;

	[Token(Token = "0x4014E77")]
	[FieldOffset(Offset = "0x11C")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x4014E78")]
	[FieldOffset(Offset = "0x120")]
	public GameObject EPDiscountContainer;

	[Token(Token = "0x4014E79")]
	[FieldOffset(Offset = "0x124")]
	public UILabel EPDiscountLabel;

	[Token(Token = "0x4014E7A")]
	[FieldOffset(Offset = "0x128")]
	public Transform AnimDownloadPos;

	[Token(Token = "0x4014E7B")]
	[FieldOffset(Offset = "0x12C")]
	public UILabel EPDiscountLabel2;

	[Token(Token = "0x4014E7C")]
	[FieldOffset(Offset = "0x130")]
	public GameObject EPDiscountContainer2;

	[Token(Token = "0x4014E7D")]
	[FieldOffset(Offset = "0x134")]
	public UILabel EPDiscount2Label;

	[Token(Token = "0x4014E7E")]
	[FieldOffset(Offset = "0x138")]
	public UILabel EPDiscount2Label2;

	[Token(Token = "0x60162C5")]
	[Address(RVA = "0x3059898", Offset = "0x3059898", VA = "0x3059898")]
	public UIElitePassMainWindowView()
	{
	}

	[Token(Token = "0x60162C6")]
	[Address(RVA = "0x30598A0", Offset = "0x30598A0", VA = "0x30598A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162C7")]
	[Address(RVA = "0x305B470", Offset = "0x305B470", VA = "0x305B470")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
