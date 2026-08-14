using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003592")]
public class UIGachaLuckyBagContentView : UIBaseView
{
	[Token(Token = "0x4015511")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIGachaLuckyBagContent;

	[Token(Token = "0x4015512")]
	[FieldOffset(Offset = "0x18")]
	public GameObject UISceneInCG;

	[Token(Token = "0x4015513")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RewardScene;

	[Token(Token = "0x4015514")]
	[FieldOffset(Offset = "0x20")]
	public UILabel RewardName;

	[Token(Token = "0x4015515")]
	[FieldOffset(Offset = "0x24")]
	public BaseItemView RewardItem;

	[Token(Token = "0x4015516")]
	[FieldOffset(Offset = "0x28")]
	public UILabel NameLabel;

	[Token(Token = "0x4015517")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject IconGroup;

	[Token(Token = "0x4015518")]
	[FieldOffset(Offset = "0x30")]
	public UISprite Sprite_Debris;

	[Token(Token = "0x4015519")]
	[FieldOffset(Offset = "0x34")]
	public UISprite VoucherIcon;

	[Token(Token = "0x401551A")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LimitLabel;

	[Token(Token = "0x401551B")]
	[FieldOffset(Offset = "0x3C")]
	public UIToggle RewardToggle;

	[Token(Token = "0x401551C")]
	[FieldOffset(Offset = "0x40")]
	public UISprite SelectedSprite;

	[Token(Token = "0x401551D")]
	[FieldOffset(Offset = "0x44")]
	public UISprite UnSelectedSprite;

	[Token(Token = "0x401551E")]
	[FieldOffset(Offset = "0x48")]
	public UILabel QuantityLabel;

	[Token(Token = "0x401551F")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BackBtn;

	[Token(Token = "0x4015520")]
	[FieldOffset(Offset = "0x50")]
	public UIButton ShareBtn;

	[Token(Token = "0x4015521")]
	[FieldOffset(Offset = "0x54")]
	public Animator ShareIconAnimator;

	[Token(Token = "0x4015522")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ShareUI;

	[Token(Token = "0x4015523")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject UserProfile;

	[Token(Token = "0x4015524")]
	[FieldOffset(Offset = "0x60")]
	public UINetworkTexture HeadshotRemote;

	[Token(Token = "0x4015525")]
	[FieldOffset(Offset = "0x64")]
	public GameObject HeadshotDefault;

	[Token(Token = "0x4015526")]
	[FieldOffset(Offset = "0x68")]
	public UIEffectSprite HeadshotLocal;

	[Token(Token = "0x4015527")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel PlayerID;

	[Token(Token = "0x4015528")]
	[FieldOffset(Offset = "0x70")]
	public UILabel PlayerNickname;

	[Token(Token = "0x4015529")]
	[FieldOffset(Offset = "0x74")]
	public UISprite FFLogo;

	[Token(Token = "0x401552A")]
	[FieldOffset(Offset = "0x78")]
	public UITexture ShareDrawSymbol;

	[Token(Token = "0x401552B")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject DrawScene;

	[Token(Token = "0x401552C")]
	[FieldOffset(Offset = "0x80")]
	public Animator DrawSceneAnimator;

	[Token(Token = "0x401552D")]
	[FieldOffset(Offset = "0x84")]
	public UIButton OKBtn;

	[Token(Token = "0x401552E")]
	[FieldOffset(Offset = "0x88")]
	public UIButton ClearBtn;

	[Token(Token = "0x401552F")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject LineRenderer;

	[Token(Token = "0x4015530")]
	[FieldOffset(Offset = "0x90")]
	public UITexture ShowSymbol;

	[Token(Token = "0x4015531")]
	[FieldOffset(Offset = "0x94")]
	public UITexture ShowSymbolWidget;

	[Token(Token = "0x4015532")]
	[FieldOffset(Offset = "0x98")]
	public GameObject DrawTips;

	[Token(Token = "0x4015533")]
	[FieldOffset(Offset = "0x9C")]
	public UITexture DrawSceneBG;

	[Token(Token = "0x4015534")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject UnlockSuccess;

	[Token(Token = "0x4015535")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject UIContent;

	[Token(Token = "0x4015536")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject BuyBtn;

	[Token(Token = "0x4015537")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel BuyPriceLabel;

	[Token(Token = "0x4015538")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject NetworkTexturebg;

	[Token(Token = "0x4015539")]
	[FieldOffset(Offset = "0xB4")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x401553A")]
	[FieldOffset(Offset = "0xB8")]
	public UIButton PoolRewardBtn;

	[Token(Token = "0x401553B")]
	[FieldOffset(Offset = "0xBC")]
	public UICountDownLabel FreeCountdownLabel;

	[Token(Token = "0x401553C")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel LimitedLabel;

	[Token(Token = "0x401553D")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject RewardPoolPos;

	[Token(Token = "0x401553E")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject PreviewLeftSideOpenPreviewPool;

	[Token(Token = "0x401553F")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject PreviewRightSide;

	[Token(Token = "0x6016466")]
	[Address(RVA = "0x2A18140", Offset = "0x2A18140", VA = "0x2A18140")]
	public UIGachaLuckyBagContentView()
	{
	}

	[Token(Token = "0x6016467")]
	[Address(RVA = "0x2A18148", Offset = "0x2A18148", VA = "0x2A18148", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016468")]
	[Address(RVA = "0x2A19370", Offset = "0x2A19370", VA = "0x2A19370")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
