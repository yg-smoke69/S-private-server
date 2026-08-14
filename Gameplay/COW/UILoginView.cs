using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200385A")]
public class UILoginView : UIBaseView
{
	[Token(Token = "0x4017172")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BgPanel;

	[Token(Token = "0x4017173")]
	[FieldOffset(Offset = "0x18")]
	public UITexture Bg;

	[Token(Token = "0x4017174")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject LoginPanel;

	[Token(Token = "0x4017175")]
	[FieldOffset(Offset = "0x20")]
	public UILabel AccountID;

	[Token(Token = "0x4017176")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Debug;

	[Token(Token = "0x4017177")]
	[FieldOffset(Offset = "0x28")]
	public UITable Table;

	[Token(Token = "0x4017178")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject RegionTitle;

	[Token(Token = "0x4017179")]
	[FieldOffset(Offset = "0x30")]
	public UILabel RegionContent;

	[Token(Token = "0x401717A")]
	[FieldOffset(Offset = "0x34")]
	public UILabel CurrentServer;

	[Token(Token = "0x401717B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject SeverPanel;

	[Token(Token = "0x401717C")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton BtnChangeSever;

	[Token(Token = "0x401717D")]
	[FieldOffset(Offset = "0x40")]
	public UILabel ServerLabel;

	[Token(Token = "0x401717E")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BtnStartGame;

	[Token(Token = "0x401717F")]
	[FieldOffset(Offset = "0x48")]
	public UIButton BgStartGame;

	[Token(Token = "0x4017180")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BtnLogout;

	[Token(Token = "0x4017181")]
	[FieldOffset(Offset = "0x50")]
	public UISprite LogoutIcon;

	[Token(Token = "0x4017182")]
	[FieldOffset(Offset = "0x54")]
	public UISprite LogoutFacebookSprite;

	[Token(Token = "0x4017183")]
	[FieldOffset(Offset = "0x58")]
	public UISprite LogoutVKontakteSprite;

	[Token(Token = "0x4017184")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite LogoutGuestSprite;

	[Token(Token = "0x4017185")]
	[FieldOffset(Offset = "0x60")]
	public UISprite LogoutHuaweiSprite;

	[Token(Token = "0x4017186")]
	[FieldOffset(Offset = "0x64")]
	public UISprite LogoutGoogleSprite;

	[Token(Token = "0x4017187")]
	[FieldOffset(Offset = "0x68")]
	public UISprite LogoutAppleSprite;

	[Token(Token = "0x4017188")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite LogoutTwitterSprite;

	[Token(Token = "0x4017189")]
	[FieldOffset(Offset = "0x70")]
	public UISprite LogoutGarenaSprite;

	[Token(Token = "0x401718A")]
	[FieldOffset(Offset = "0x74")]
	public UIWidget CachedPlayerInfo;

	[Token(Token = "0x401718B")]
	[FieldOffset(Offset = "0x78")]
	public UILabel CachedNicknameLabel;

	[Token(Token = "0x401718C")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject GyroSetting;

	[Token(Token = "0x401718D")]
	[FieldOffset(Offset = "0x80")]
	public UIToggleButtonGroup GyroSelectGroup;

	[Token(Token = "0x401718E")]
	[FieldOffset(Offset = "0x84")]
	public UIToggleButton GyroTarget;

	[Token(Token = "0x401718F")]
	[FieldOffset(Offset = "0x88")]
	public UILabel MoveSpeedValue;

	[Token(Token = "0x4017190")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton MoveSpeedInc;

	[Token(Token = "0x4017191")]
	[FieldOffset(Offset = "0x90")]
	public UIButton MoveSpeedDec;

	[Token(Token = "0x4017192")]
	[FieldOffset(Offset = "0x94")]
	public UILabel RebackSpeedValue;

	[Token(Token = "0x4017193")]
	[FieldOffset(Offset = "0x98")]
	public UIButton RebackSpeedInc;

	[Token(Token = "0x4017194")]
	[FieldOffset(Offset = "0x9C")]
	public UIButton RebackSpeedDec;

	[Token(Token = "0x4017195")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject PanelTOS;

	[Token(Token = "0x4017196")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel LabelTOS;

	[Token(Token = "0x4017197")]
	[FieldOffset(Offset = "0xA8")]
	public UIButton BtnService;

	[Token(Token = "0x4017198")]
	[FieldOffset(Offset = "0xAC")]
	public UIButton BtnPrivacy;

	[Token(Token = "0x4017199")]
	[FieldOffset(Offset = "0xB0")]
	public UIToggle ToggleTOS;

	[Token(Token = "0x401719A")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject TOSVFX;

	[Token(Token = "0x401719B")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject LoginBtns;

	[Token(Token = "0x401719C")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject Normal;

	[Token(Token = "0x401719D")]
	[FieldOffset(Offset = "0xC0")]
	public UIGrid LoginBtnGrid;

	[Token(Token = "0x401719E")]
	[FieldOffset(Offset = "0xC4")]
	public UIButton BtnLoginAppleWhite;

	[Token(Token = "0x401719F")]
	[FieldOffset(Offset = "0xC8")]
	public UIButton BtnLoginAppleBlack;

	[Token(Token = "0x40171A0")]
	[FieldOffset(Offset = "0xCC")]
	public UIButton BtnLoginHW;

	[Token(Token = "0x40171A1")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite SpriteLoginHW_Huawei;

	[Token(Token = "0x40171A2")]
	[FieldOffset(Offset = "0xD4")]
	public UIButton BtnLoginVK;

	[Token(Token = "0x40171A3")]
	[FieldOffset(Offset = "0xD8")]
	public UIButton BtnLoginFB;

	[Token(Token = "0x40171A4")]
	[FieldOffset(Offset = "0xDC")]
	public UIButton BtnLoginGoogle;

	[Token(Token = "0x40171A5")]
	[FieldOffset(Offset = "0xE0")]
	public UISprite SpriteLoginVK_Russian;

	[Token(Token = "0x40171A6")]
	[FieldOffset(Offset = "0xE4")]
	public UIButton BtnLoginTwitter;

	[Token(Token = "0x40171A7")]
	[FieldOffset(Offset = "0xE8")]
	public UIButton BtnLoginGarena;

	[Token(Token = "0x40171A8")]
	[FieldOffset(Offset = "0xEC")]
	public UIButton BtnLoginGuest;

	[Token(Token = "0x40171A9")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject MoreLogin;

	[Token(Token = "0x40171AA")]
	[FieldOffset(Offset = "0xF4")]
	public UIButton MoreLoginBtn;

	[Token(Token = "0x40171AB")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject MoreLoginHintBubble;

	[Token(Token = "0x40171AC")]
	[FieldOffset(Offset = "0xFC")]
	public GameObject PC;

	[Token(Token = "0x40171AD")]
	[FieldOffset(Offset = "0x100")]
	public UIButton PCGuest;

	[Token(Token = "0x40171AE")]
	[FieldOffset(Offset = "0x104")]
	public GameObject Trial;

	[Token(Token = "0x40171AF")]
	[FieldOffset(Offset = "0x108")]
	public UIButton TrialGuest;

	[Token(Token = "0x40171B0")]
	[FieldOffset(Offset = "0x10C")]
	public GameObject PanelAge;

	[Token(Token = "0x40171B1")]
	[FieldOffset(Offset = "0x110")]
	public UILabel LabelAge;

	[Token(Token = "0x40171B2")]
	[FieldOffset(Offset = "0x114")]
	public UIToggle ToggleAge;

	[Token(Token = "0x40171B3")]
	[FieldOffset(Offset = "0x118")]
	public GameObject Age18Logo;

	[Token(Token = "0x40171B4")]
	[FieldOffset(Offset = "0x11C")]
	public UIVertalBox VertalBox;

	[Token(Token = "0x40171B5")]
	[FieldOffset(Offset = "0x120")]
	public UIButton Download;

	[Token(Token = "0x40171B6")]
	[FieldOffset(Offset = "0x124")]
	public UILabel DownloadTips;

	[Token(Token = "0x40171B7")]
	[FieldOffset(Offset = "0x128")]
	public GameObject IntroTips;

	[Token(Token = "0x40171B8")]
	[FieldOffset(Offset = "0x12C")]
	public GameObject VNLinkUrl;

	[Token(Token = "0x40171B9")]
	[FieldOffset(Offset = "0x130")]
	public UIButton UrlBtn;

	[Token(Token = "0x40171BA")]
	[FieldOffset(Offset = "0x134")]
	public UILabel DataHintLabel;

	[Token(Token = "0x40171BB")]
	[FieldOffset(Offset = "0x138")]
	public GameObject RegisterPanel;

	[Token(Token = "0x40171BC")]
	[FieldOffset(Offset = "0x13C")]
	public UIInput InputCode;

	[Token(Token = "0x40171BD")]
	[FieldOffset(Offset = "0x140")]
	public UIInput InputNickName;

	[Token(Token = "0x40171BE")]
	[FieldOffset(Offset = "0x144")]
	public UIButton BtnRegister;

	[Token(Token = "0x40171BF")]
	[FieldOffset(Offset = "0x148")]
	public UISprite LoginLogo;

	[Token(Token = "0x6016CB9")]
	[Address(RVA = "0x21F7E74", Offset = "0x21F7E74", VA = "0x21F7E74")]
	public UILoginView()
	{
	}

	[Token(Token = "0x6016CBA")]
	[Address(RVA = "0x21F7E7C", Offset = "0x21F7E7C", VA = "0x21F7E7C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CBB")]
	[Address(RVA = "0x21F9C2C", Offset = "0x21F9C2C", VA = "0x21F9C2C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
