using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003402")]
public class UIBigMapView : UIBaseView
{
	[Token(Token = "0x4014068")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x4014069")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Bg;

	[Token(Token = "0x401406A")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnTapClose;

	[Token(Token = "0x401406B")]
	[FieldOffset(Offset = "0x20")]
	public UIPanel MapContainer;

	[Token(Token = "0x401406C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject DebugCatapultContainer;

	[Token(Token = "0x401406D")]
	[FieldOffset(Offset = "0x28")]
	public UILabel CatapultMarkLabel;

	[Token(Token = "0x401406E")]
	[FieldOffset(Offset = "0x2C")]
	public SetRelativeDepth MapEffectDepth;

	[Token(Token = "0x401406F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject eventIcon;

	[Token(Token = "0x4014070")]
	[FieldOffset(Offset = "0x34")]
	public GameObject WolfTipRoot;

	[Token(Token = "0x4014071")]
	[FieldOffset(Offset = "0x38")]
	public GameObject HumanTipRoot;

	[Token(Token = "0x4014072")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject LeftWidget;

	[Token(Token = "0x4014073")]
	[FieldOffset(Offset = "0x40")]
	public UILabel SPSafeZoneTxt;

	[Token(Token = "0x4014074")]
	[FieldOffset(Offset = "0x44")]
	public GameObject HPNode;

	[Token(Token = "0x4014075")]
	[FieldOffset(Offset = "0x48")]
	public UIProgressBar HPBar;

	[Token(Token = "0x4014076")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite HPBarFG;

	[Token(Token = "0x4014077")]
	[FieldOffset(Offset = "0x50")]
	public UIProgressBar HPProgressBar;

	[Token(Token = "0x4014078")]
	[FieldOffset(Offset = "0x54")]
	public GameObject ProgressLeftEnd;

	[Token(Token = "0x4014079")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ProgressRightEnd;

	[Token(Token = "0x401407A")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel HP;

	[Token(Token = "0x401407B")]
	[FieldOffset(Offset = "0x60")]
	public GameObject EPNode;

	[Token(Token = "0x401407C")]
	[FieldOffset(Offset = "0x64")]
	public UIProgressBar EPBar;

	[Token(Token = "0x401407D")]
	[FieldOffset(Offset = "0x68")]
	public UISprite EPBarFG;

	[Token(Token = "0x401407E")]
	[FieldOffset(Offset = "0x6C")]
	public UIProgressBar EPProgressBar;

	[Token(Token = "0x401407F")]
	[FieldOffset(Offset = "0x70")]
	public GameObject EPProgressLeftEnd;

	[Token(Token = "0x4014080")]
	[FieldOffset(Offset = "0x74")]
	public GameObject EPProgressRightEnd;

	[Token(Token = "0x4014081")]
	[FieldOffset(Offset = "0x78")]
	public UILabel EP;

	[Token(Token = "0x4014082")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject rankingContainer;

	[Token(Token = "0x4014083")]
	[FieldOffset(Offset = "0x80")]
	public UIGrid AttachmentGrid;

	[Token(Token = "0x4014084")]
	[FieldOffset(Offset = "0x84")]
	public GameObject DropAttachmentLabel;

	[Token(Token = "0x4014085")]
	[FieldOffset(Offset = "0x88")]
	public GameObject RevivePointEndTimeInfo;

	[Token(Token = "0x4014086")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel ReviveEndTimeLabel;

	[Token(Token = "0x4014087")]
	[FieldOffset(Offset = "0x90")]
	public GameObject RightWidget;

	[Token(Token = "0x4014088")]
	[FieldOffset(Offset = "0x94")]
	public UIButton left_Close;

	[Token(Token = "0x4014089")]
	[FieldOffset(Offset = "0x98")]
	public UIButton BtnClose;

	[Token(Token = "0x401408A")]
	[FieldOffset(Offset = "0x9C")]
	public UIWidget TutorialWidget;

	[Token(Token = "0x401408B")]
	[FieldOffset(Offset = "0xA0")]
	public UIGrid GameMissionRoot;

	[Token(Token = "0x401408C")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject Tips1;

	[Token(Token = "0x401408D")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject Tips2;

	[Token(Token = "0x401408E")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject Tips3;

	[Token(Token = "0x401408F")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject BtnJump;

	[Token(Token = "0x4014090")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject ToggleContainer;

	[Token(Token = "0x4014091")]
	[FieldOffset(Offset = "0xB8")]
	public UIToggle BtnToggleShopIcon;

	[Token(Token = "0x4014092")]
	[FieldOffset(Offset = "0xBC")]
	public UISprite BtnToggleShopIconBg;

	[Token(Token = "0x4014093")]
	[FieldOffset(Offset = "0xC0")]
	public UISprite ShopIconCloseSprite;

	[Token(Token = "0x4014094")]
	[FieldOffset(Offset = "0xC4")]
	public UIToggle BtnToggleRevivePointIcon;

	[Token(Token = "0x4014095")]
	[FieldOffset(Offset = "0xC8")]
	public UISprite BtnToggleRevivePointIconBg;

	[Token(Token = "0x4014096")]
	[FieldOffset(Offset = "0xCC")]
	public UISprite RevivePointIconCloseSprite;

	[Token(Token = "0x4014097")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject CloseTipLabel;

	[Token(Token = "0x4014098")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject WSMapIconDescContainer;

	[Token(Token = "0x4014099")]
	[FieldOffset(Offset = "0xD8")]
	public SceneEditMapIconItemDesc WSMapIconDescItem;

	[Token(Token = "0x401409A")]
	[FieldOffset(Offset = "0xDC")]
	public GameObject RightReviveWidget;

	[Token(Token = "0x401409B")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject Tips4;

	[Token(Token = "0x401409C")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject Tips5;

	[Token(Token = "0x401409D")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject Tips6;

	[Token(Token = "0x401409E")]
	[FieldOffset(Offset = "0xEC")]
	public UIButton BtnRevive;

	[Token(Token = "0x401409F")]
	[FieldOffset(Offset = "0xF0")]
	public UICountDownLabel CountDown;

	[Token(Token = "0x40140A0")]
	[FieldOffset(Offset = "0xF4")]
	public UIButton BtnQuitRevive;

	[Token(Token = "0x40140A1")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject FateRandomSubModeInfo;

	[Token(Token = "0x40140A2")]
	[FieldOffset(Offset = "0xFC")]
	public UISprite FateRandomSubModeIcon;

	[Token(Token = "0x40140A3")]
	[FieldOffset(Offset = "0x100")]
	public UILabel FateRandomSubModeName;

	[Token(Token = "0x40140A4")]
	[FieldOffset(Offset = "0x104")]
	public UIEventListener FateRandomSubModeDetailIcon;

	[Token(Token = "0x40140A5")]
	[FieldOffset(Offset = "0x108")]
	public UILabel FateRandomSubModeDetailTip;

	[Token(Token = "0x40140A6")]
	[FieldOffset(Offset = "0x10C")]
	public GameObject FateRandomBornIconTip;

	[Token(Token = "0x6015FBA")]
	[Address(RVA = "0x10D2CAC", Offset = "0x10D2CAC", VA = "0x10D2CAC")]
	public UIBigMapView()
	{
	}

	[Token(Token = "0x6015FBB")]
	[Address(RVA = "0x10D2CB4", Offset = "0x10D2CB4", VA = "0x10D2CB4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FBC")]
	[Address(RVA = "0x10D4440", Offset = "0x10D4440", VA = "0x10D4440")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
