using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200362E")]
public class UIHudCustomView : UIBaseView
{
	[Token(Token = "0x4015B62")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Top;

	[Token(Token = "0x4015B63")]
	[FieldOffset(Offset = "0x18")]
	public Transform RulerMark;

	[Token(Token = "0x4015B64")]
	[FieldOffset(Offset = "0x1C")]
	public Transform SaveZoneMark;

	[Token(Token = "0x4015B65")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SinglePlayerMark;

	[Token(Token = "0x4015B66")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TeamMark_1;

	[Token(Token = "0x4015B67")]
	[FieldOffset(Offset = "0x28")]
	public UISprite TeamMark_2;

	[Token(Token = "0x4015B68")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite TeamMark_3;

	[Token(Token = "0x4015B69")]
	[FieldOffset(Offset = "0x30")]
	public UISprite TeamMark_4;

	[Token(Token = "0x4015B6A")]
	[FieldOffset(Offset = "0x34")]
	public UISprite TreasureMark;

	[Token(Token = "0x4015B6B")]
	[FieldOffset(Offset = "0x38")]
	public Transform Ruler;

	[Token(Token = "0x4015B6C")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel ScaleValue_1;

	[Token(Token = "0x4015B6D")]
	[FieldOffset(Offset = "0x40")]
	public UILabel ScaleValue_2;

	[Token(Token = "0x4015B6E")]
	[FieldOffset(Offset = "0x44")]
	public UILabel ScaleValue_3;

	[Token(Token = "0x4015B6F")]
	[FieldOffset(Offset = "0x48")]
	public UILabel ScaleValue_4;

	[Token(Token = "0x4015B70")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel ScaleValue_5;

	[Token(Token = "0x4015B71")]
	[FieldOffset(Offset = "0x50")]
	public UILabel ScaleValue_6;

	[Token(Token = "0x4015B72")]
	[FieldOffset(Offset = "0x54")]
	public UILabel ScaleValue_7;

	[Token(Token = "0x4015B73")]
	[FieldOffset(Offset = "0x58")]
	public UILabel ScaleValue_8;

	[Token(Token = "0x4015B74")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel ScaleValue_9;

	[Token(Token = "0x4015B75")]
	[FieldOffset(Offset = "0x60")]
	public UILabel ScaleValue_10;

	[Token(Token = "0x4015B76")]
	[FieldOffset(Offset = "0x64")]
	public UILabel ScaleValue_11;

	[Token(Token = "0x4015B77")]
	[FieldOffset(Offset = "0x68")]
	public UILabel ScaleValue_12;

	[Token(Token = "0x4015B78")]
	[FieldOffset(Offset = "0x6C")]
	public Transform Ruler2;

	[Token(Token = "0x4015B79")]
	[FieldOffset(Offset = "0x70")]
	public UILabel ScaleValue_24;

	[Token(Token = "0x4015B7A")]
	[FieldOffset(Offset = "0x74")]
	public UILabel ScaleValue_13;

	[Token(Token = "0x4015B7B")]
	[FieldOffset(Offset = "0x78")]
	public UILabel ScaleValue_14;

	[Token(Token = "0x4015B7C")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel ScaleValue_15;

	[Token(Token = "0x4015B7D")]
	[FieldOffset(Offset = "0x80")]
	public UILabel ScaleValue_16;

	[Token(Token = "0x4015B7E")]
	[FieldOffset(Offset = "0x84")]
	public UILabel ScaleValue_17;

	[Token(Token = "0x4015B7F")]
	[FieldOffset(Offset = "0x88")]
	public UILabel ScaleValue_18;

	[Token(Token = "0x4015B80")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel ScaleValue_19;

	[Token(Token = "0x4015B81")]
	[FieldOffset(Offset = "0x90")]
	public UILabel ScaleValue_20;

	[Token(Token = "0x4015B82")]
	[FieldOffset(Offset = "0x94")]
	public UILabel ScaleValue_21;

	[Token(Token = "0x4015B83")]
	[FieldOffset(Offset = "0x98")]
	public UILabel ScaleValue_22;

	[Token(Token = "0x4015B84")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel ScaleValue_23;

	[Token(Token = "0x4015B85")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject TopLeft;

	[Token(Token = "0x4015B86")]
	[FieldOffset(Offset = "0xA4")]
	public CustomHudItem UIHudItemMarkBtn;

	[Token(Token = "0x4015B87")]
	[FieldOffset(Offset = "0xA8")]
	public CustomHudItem HudMiniMap;

	[Token(Token = "0x4015B88")]
	[FieldOffset(Offset = "0xAC")]
	public CustomHudItem HudTeammatesInfo;

	[Token(Token = "0x4015B89")]
	[FieldOffset(Offset = "0xB0")]
	public CustomHudItem HudChatBtn;

	[Token(Token = "0x4015B8A")]
	[FieldOffset(Offset = "0xB4")]
	public CustomHudItem HudQuickChatContainer;

	[Token(Token = "0x4015B8B")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject Left;

	[Token(Token = "0x4015B8C")]
	[FieldOffset(Offset = "0xBC")]
	public CustomHudItem HudQuickUseMedkit;

	[Token(Token = "0x4015B8D")]
	[FieldOffset(Offset = "0xC0")]
	public CustomHudItem HudInventoryEntry;

	[Token(Token = "0x4015B8E")]
	[FieldOffset(Offset = "0xC4")]
	public CustomHudItem HudSpeedupArea;

	[Token(Token = "0x4015B8F")]
	[FieldOffset(Offset = "0xC8")]
	public CustomHudItem UIHudAuxFire;

	[Token(Token = "0x4015B90")]
	[FieldOffset(Offset = "0xCC")]
	public EdgeDetectHudItem UIHudGrenadeBtn;

	[Token(Token = "0x4015B91")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject GrenadeRight;

	[Token(Token = "0x4015B92")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject GrenadeLeft;

	[Token(Token = "0x4015B93")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject GrenadeTop;

	[Token(Token = "0x4015B94")]
	[FieldOffset(Offset = "0xDC")]
	public GameObject GrenadeBottom;

	[Token(Token = "0x4015B95")]
	[FieldOffset(Offset = "0xE0")]
	public GrenadeDefenceHudItem UIHudGrenadeBtn2;

	[Token(Token = "0x4015B96")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject GrenadeRight2;

	[Token(Token = "0x4015B97")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject GrenadeLeft2;

	[Token(Token = "0x4015B98")]
	[FieldOffset(Offset = "0xEC")]
	public GameObject GrenadeTop2;

	[Token(Token = "0x4015B99")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject GrenadeBottom2;

	[Token(Token = "0x4015B9A")]
	[FieldOffset(Offset = "0xF4")]
	public CustomHudItem HudSwimmingSurf;

	[Token(Token = "0x4015B9B")]
	[FieldOffset(Offset = "0xF8")]
	public CustomHudItem UIHudEmotionEntry;

	[Token(Token = "0x4015B9C")]
	[FieldOffset(Offset = "0xFC")]
	public CustomHudItem UIHudPetAnim;

	[Token(Token = "0x4015B9D")]
	[FieldOffset(Offset = "0x100")]
	public UISprite normal;

	[Token(Token = "0x4015B9E")]
	[FieldOffset(Offset = "0x104")]
	public CustomHudItem UIHudEpicClothesEffectBtnController;

	[Token(Token = "0x4015B9F")]
	[FieldOffset(Offset = "0x108")]
	public GameObject AdjustContainer;

	[Token(Token = "0x4015BA0")]
	[FieldOffset(Offset = "0x10C")]
	public UISlider AlphaSliderBar;

	[Token(Token = "0x4015BA1")]
	[FieldOffset(Offset = "0x110")]
	public UILabel AlphaSliderValue;

	[Token(Token = "0x4015BA2")]
	[FieldOffset(Offset = "0x114")]
	public UISlider SizeSliderBar;

	[Token(Token = "0x4015BA3")]
	[FieldOffset(Offset = "0x118")]
	public UILabel SizeSliderValue;

	[Token(Token = "0x4015BA4")]
	[FieldOffset(Offset = "0x11C")]
	public UIToggle HideToggle;

	[Token(Token = "0x4015BA5")]
	[FieldOffset(Offset = "0x120")]
	public UIToggleButtonGroup GrenadeDirectionBtnRoot;

	[Token(Token = "0x4015BA6")]
	[FieldOffset(Offset = "0x124")]
	public UIToggleButton GrenadeRightBtn;

	[Token(Token = "0x4015BA7")]
	[FieldOffset(Offset = "0x128")]
	public UIToggleButton GrenadeLeftBtn;

	[Token(Token = "0x4015BA8")]
	[FieldOffset(Offset = "0x12C")]
	public UIToggleButton GrenadeTopBtn;

	[Token(Token = "0x4015BA9")]
	[FieldOffset(Offset = "0x130")]
	public UIToggleButton GrenadeBottomBtn;

	[Token(Token = "0x4015BAA")]
	[FieldOffset(Offset = "0x134")]
	public UIToggleSlideButtonGroup CaseContainer;

	[Token(Token = "0x4015BAB")]
	[FieldOffset(Offset = "0x138")]
	public TweenPosition ToggleSlideBG;

	[Token(Token = "0x4015BAC")]
	[FieldOffset(Offset = "0x13C")]
	public UIToggleButton CaseOneToggle;

	[Token(Token = "0x4015BAD")]
	[FieldOffset(Offset = "0x140")]
	public UIToggleButton CaseTwoToggle;

	[Token(Token = "0x4015BAE")]
	[FieldOffset(Offset = "0x144")]
	public UIButton CancelBtn;

	[Token(Token = "0x4015BAF")]
	[FieldOffset(Offset = "0x148")]
	public UIButton ResetBtn;

	[Token(Token = "0x4015BB0")]
	[FieldOffset(Offset = "0x14C")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4015BB1")]
	[FieldOffset(Offset = "0x150")]
	public GameObject ConfirmEnable;

	[Token(Token = "0x4015BB2")]
	[FieldOffset(Offset = "0x154")]
	public GameObject ConfirmDisable;

	[Token(Token = "0x4015BB3")]
	[FieldOffset(Offset = "0x158")]
	public TweenHeight BGTween;

	[Token(Token = "0x4015BB4")]
	[FieldOffset(Offset = "0x15C")]
	public UIButton BtnArrow;

	[Token(Token = "0x4015BB5")]
	[FieldOffset(Offset = "0x160")]
	public GameObject TopRight;

	[Token(Token = "0x4015BB6")]
	[FieldOffset(Offset = "0x164")]
	public CustomHudItem HudWeaponInfo;

	[Token(Token = "0x4015BB7")]
	[FieldOffset(Offset = "0x168")]
	public UIGrid HudWeaponListGrid;

	[Token(Token = "0x4015BB8")]
	[FieldOffset(Offset = "0x16C")]
	public GameObject Remaining;

	[Token(Token = "0x4015BB9")]
	[FieldOffset(Offset = "0x170")]
	public UILabel RemainingCountText;

	[Token(Token = "0x4015BBA")]
	[FieldOffset(Offset = "0x174")]
	public GameObject Kill;

	[Token(Token = "0x4015BBB")]
	[FieldOffset(Offset = "0x178")]
	public UILabel KillCountText;

	[Token(Token = "0x4015BBC")]
	[FieldOffset(Offset = "0x17C")]
	public GameObject Enemy;

	[Token(Token = "0x4015BBD")]
	[FieldOffset(Offset = "0x180")]
	public UILabel RemainingEnemyCountText;

	[Token(Token = "0x4015BBE")]
	[FieldOffset(Offset = "0x184")]
	public GameObject KDA;

	[Token(Token = "0x4015BBF")]
	[FieldOffset(Offset = "0x188")]
	public UILabel KdaCountText;

	[Token(Token = "0x4015BC0")]
	[FieldOffset(Offset = "0x18C")]
	public CustomHudItem HudPickupList;

	[Token(Token = "0x4015BC1")]
	[FieldOffset(Offset = "0x190")]
	public CustomHudItem UIHudAutoFire;

	[Token(Token = "0x4015BC2")]
	[FieldOffset(Offset = "0x194")]
	public CustomHudItem UIHudCombineWeapon;

	[Token(Token = "0x4015BC3")]
	[FieldOffset(Offset = "0x198")]
	public CustomHudItem HudResponseChatBtn;

	[Token(Token = "0x4015BC4")]
	[FieldOffset(Offset = "0x19C")]
	public GameObject BottomLeft;

	[Token(Token = "0x4015BC5")]
	[FieldOffset(Offset = "0x1A0")]
	public CustomHudItem HudMovingJoystick;

	[Token(Token = "0x4015BC6")]
	[FieldOffset(Offset = "0x1A4")]
	public UILabel SignalLabel;

	[Token(Token = "0x4015BC7")]
	[FieldOffset(Offset = "0x1A8")]
	public UISprite SignalIcon;

	[Token(Token = "0x4015BC8")]
	[FieldOffset(Offset = "0x1AC")]
	public GameObject BottomRight;

	[Token(Token = "0x4015BC9")]
	[FieldOffset(Offset = "0x1B0")]
	public CustomHudItem HudFire;

	[Token(Token = "0x4015BCA")]
	[FieldOffset(Offset = "0x1B4")]
	public CustomHudItem HudCreep;

	[Token(Token = "0x4015BCB")]
	[FieldOffset(Offset = "0x1B8")]
	public CustomHudItem HudCrouch;

	[Token(Token = "0x4015BCC")]
	[FieldOffset(Offset = "0x1BC")]
	public CustomHudItem HudJump;

	[Token(Token = "0x4015BCD")]
	[FieldOffset(Offset = "0x1C0")]
	public CustomHudItem HudSight;

	[Token(Token = "0x4015BCE")]
	[FieldOffset(Offset = "0x1C4")]
	public CustomHudItem HudActiveSkill;

	[Token(Token = "0x4015BCF")]
	[FieldOffset(Offset = "0x1C8")]
	public UISprite BtnSprite;

	[Token(Token = "0x4015BD0")]
	[FieldOffset(Offset = "0x1CC")]
	public CustomHudItem HudAuxAim;

	[Token(Token = "0x4015BD1")]
	[FieldOffset(Offset = "0x1D0")]
	public GameObject Bottom;

	[Token(Token = "0x4015BD2")]
	[FieldOffset(Offset = "0x1D4")]
	public UISprite HighLightCircle;

	[Token(Token = "0x4015BD3")]
	[FieldOffset(Offset = "0x1D8")]
	public TweenScale TweenCircle;

	[Token(Token = "0x4015BD4")]
	[FieldOffset(Offset = "0x1DC")]
	public UISprite HighLightSquare;

	[Token(Token = "0x4015BD5")]
	[FieldOffset(Offset = "0x1E0")]
	public TweenScale TweenSquare;

	[Token(Token = "0x4015BD6")]
	[FieldOffset(Offset = "0x1E4")]
	public CustomHudItem UIHudGameMissionMiniInfoPanel;

	[Token(Token = "0x4015BD7")]
	[FieldOffset(Offset = "0x1E8")]
	public CustomHudItem UIHudSwitchWeapon;

	[Token(Token = "0x4015BD8")]
	[FieldOffset(Offset = "0x1EC")]
	public CustomHudItem HudSetting;

	[Token(Token = "0x4015BD9")]
	[FieldOffset(Offset = "0x1F0")]
	public CustomHudItem HudVehicleHorn;

	[Token(Token = "0x6016637")]
	[Address(RVA = "0x1CC6D5C", Offset = "0x1CC6D5C", VA = "0x1CC6D5C")]
	public UIHudCustomView()
	{
	}

	[Token(Token = "0x6016638")]
	[Address(RVA = "0x1CC6D64", Offset = "0x1CC6D64", VA = "0x1CC6D64", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016639")]
	[Address(RVA = "0x1CC9A08", Offset = "0x1CC9A08", VA = "0x1CC9A08")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
