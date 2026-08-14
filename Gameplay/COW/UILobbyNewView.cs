using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200384B")]
public class UILobbyNewView : UIBaseView
{
	[Token(Token = "0x40170AF")]
	[FieldOffset(Offset = "0x14")]
	public UISprite HDMask;

	[Token(Token = "0x40170B0")]
	[FieldOffset(Offset = "0x18")]
	public TweenAlpha TweenAlphaGroupMaskScene;

	[Token(Token = "0x40170B1")]
	[FieldOffset(Offset = "0x1C")]
	public Transform AvatarPanel;

	[Token(Token = "0x40170B2")]
	[FieldOffset(Offset = "0x20")]
	public Transform EmotePanelContainer;

	[Token(Token = "0x40170B3")]
	[FieldOffset(Offset = "0x24")]
	public Transform EquipSetsContainer;

	[Token(Token = "0x40170B4")]
	[FieldOffset(Offset = "0x28")]
	public Transform PanelGroupMask;

	[Token(Token = "0x40170B5")]
	[FieldOffset(Offset = "0x2C")]
	public TweenAlpha TweenAlphaGroupMask;

	[Token(Token = "0x40170B6")]
	[FieldOffset(Offset = "0x30")]
	public Transform TopLeft;

	[Token(Token = "0x40170B7")]
	[FieldOffset(Offset = "0x34")]
	public TweenPosition TweenPosPanelTopLeft;

	[Token(Token = "0x40170B8")]
	[FieldOffset(Offset = "0x38")]
	public UIButton PaymentButton;

	[Token(Token = "0x40170B9")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite PaymentButtonDefaultSprite;

	[Token(Token = "0x40170BA")]
	[FieldOffset(Offset = "0x40")]
	public UINetworkTexture PaymentButtonNetworkTexture;

	[Token(Token = "0x40170BB")]
	[FieldOffset(Offset = "0x44")]
	public GameObject CountDownLabel;

	[Token(Token = "0x40170BC")]
	[FieldOffset(Offset = "0x48")]
	public Transform profile;

	[Token(Token = "0x40170BD")]
	[FieldOffset(Offset = "0x4C")]
	public Transform AdsContainer;

	[Token(Token = "0x40170BE")]
	[FieldOffset(Offset = "0x50")]
	public Transform mapModesPanel;

	[Token(Token = "0x40170BF")]
	[FieldOffset(Offset = "0x54")]
	public Transform TopRight;

	[Token(Token = "0x40170C0")]
	[FieldOffset(Offset = "0x58")]
	public Transform Left;

	[Token(Token = "0x40170C1")]
	[FieldOffset(Offset = "0x5C")]
	public Transform Right;

	[Token(Token = "0x40170C2")]
	[FieldOffset(Offset = "0x60")]
	public GameObject EPContainer;

	[Token(Token = "0x40170C3")]
	[FieldOffset(Offset = "0x64")]
	public UIWidget EPGuideWidget;

	[Token(Token = "0x40170C4")]
	[FieldOffset(Offset = "0x68")]
	public GameObject EPTaskContainer;

	[Token(Token = "0x40170C5")]
	[FieldOffset(Offset = "0x6C")]
	public Transform LeftBottom;

	[Token(Token = "0x40170C6")]
	[FieldOffset(Offset = "0x70")]
	public UIGrid LeftBottomBtnGroup;

	[Token(Token = "0x40170C7")]
	[FieldOffset(Offset = "0x74")]
	public UIButton RewardedVideoBtn;

	[Token(Token = "0x40170C8")]
	[FieldOffset(Offset = "0x78")]
	public GameObject RewardedVideoRedDot;

	[Token(Token = "0x40170C9")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton UIButtonBtnManual;

	[Token(Token = "0x40170CA")]
	[FieldOffset(Offset = "0x80")]
	public UIWidget UIWidgetBtnManual;

	[Token(Token = "0x40170CB")]
	[FieldOffset(Offset = "0x84")]
	public GameObject Tag;

	[Token(Token = "0x40170CC")]
	[FieldOffset(Offset = "0x88")]
	public GameObject Tips;

	[Token(Token = "0x40170CD")]
	[FieldOffset(Offset = "0x8C")]
	public Animator ManualIconAnimator;

	[Token(Token = "0x40170CE")]
	[FieldOffset(Offset = "0x90")]
	public GameObject Age18Logo;

	[Token(Token = "0x40170CF")]
	[FieldOffset(Offset = "0x94")]
	public UIButton PCReplayEntry;

	[Token(Token = "0x40170D0")]
	[FieldOffset(Offset = "0x98")]
	public UIButton TestToggleButton;

	[Token(Token = "0x40170D1")]
	[FieldOffset(Offset = "0x9C")]
	public Transform WardrobePanel;

	[Token(Token = "0x40170D2")]
	[FieldOffset(Offset = "0xA0")]
	public Transform InventoryPanel;

	[Token(Token = "0x40170D3")]
	[FieldOffset(Offset = "0xA4")]
	public Transform NewPlayerSigninPanel;

	[Token(Token = "0x40170D4")]
	[FieldOffset(Offset = "0xA8")]
	public UIWidget HDWeaponRack;

	[Token(Token = "0x40170D5")]
	[FieldOffset(Offset = "0xAC")]
	public UIWidget HDVehicleDisplay;

	[Token(Token = "0x40170D6")]
	[FieldOffset(Offset = "0xB0")]
	public Transform EnterAnimContainer;

	[Token(Token = "0x40170D7")]
	[FieldOffset(Offset = "0xB4")]
	public UIWidget HDIceDisplay;

	[Token(Token = "0x40170D8")]
	[FieldOffset(Offset = "0xB8")]
	public UIWidget HDSkyboardDisplay;

	[Token(Token = "0x40170D9")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject IPMusicContainer;

	[Token(Token = "0x40170DA")]
	[FieldOffset(Offset = "0xC0")]
	public UIButton IPMusicBtn;

	[Token(Token = "0x40170DB")]
	[FieldOffset(Offset = "0xC4")]
	public UISprite IPMusicSprite;

	[Token(Token = "0x40170DC")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject VFX_IPMusic;

	[Token(Token = "0x40170DD")]
	[FieldOffset(Offset = "0xCC")]
	public UISprite IPMusicPlaySprite;

	[Token(Token = "0x40170DE")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite IPMusicStopSprite;

	[Token(Token = "0x40170DF")]
	[FieldOffset(Offset = "0xD4")]
	public Transform PetAnimTrans;

	[Token(Token = "0x40170E0")]
	[FieldOffset(Offset = "0xD8")]
	public UIButton PCReportReplayEntry;

	[Token(Token = "0x40170E1")]
	[FieldOffset(Offset = "0xDC")]
	public Transform DigitaluniverseBEgg;

	[Token(Token = "0x40170E2")]
	[FieldOffset(Offset = "0xE0")]
	public Animation Mask_DigitaluniverseB;

	[Token(Token = "0x6016C8C")]
	[Address(RVA = "0x1CAD388", Offset = "0x1CAD388", VA = "0x1CAD388")]
	public UILobbyNewView()
	{
	}

	[Token(Token = "0x6016C8D")]
	[Address(RVA = "0x1CAD390", Offset = "0x1CAD390", VA = "0x1CAD390", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C8E")]
	[Address(RVA = "0x1CAE51C", Offset = "0x1CAE51C", VA = "0x1CAE51C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
