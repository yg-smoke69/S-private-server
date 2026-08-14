using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200348F")]
public class UICreateRoomView : UIBaseView
{
	[Token(Token = "0x4014772")]
	[FieldOffset(Offset = "0x14")]
	public GameObject RoomTypeBtns;

	[Token(Token = "0x4014773")]
	[FieldOffset(Offset = "0x18")]
	public GameObject LeagueNormalRoomTab;

	[Token(Token = "0x4014774")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButton LeagueNormalToggleBtn;

	[Token(Token = "0x4014775")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CasualRoomTab;

	[Token(Token = "0x4014776")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButton CasualToggleBtn;

	[Token(Token = "0x4014777")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BatchRoomTab;

	[Token(Token = "0x4014778")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton BatchToggleBtn;

	[Token(Token = "0x4014779")]
	[FieldOffset(Offset = "0x30")]
	public GameObject TabBg;

	[Token(Token = "0x401477A")]
	[FieldOffset(Offset = "0x34")]
	public GameObject RoomGameSettingBtnGo;

	[Token(Token = "0x401477B")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Title;

	[Token(Token = "0x401477C")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject RoomCardGo;

	[Token(Token = "0x401477D")]
	[FieldOffset(Offset = "0x40")]
	public GameObject InfoPanel;

	[Token(Token = "0x401477E")]
	[FieldOffset(Offset = "0x44")]
	public UIPanel GameSettingMaskPanel;

	[Token(Token = "0x401477F")]
	[FieldOffset(Offset = "0x48")]
	public UIButton GameSettingMask;

	[Token(Token = "0x4014780")]
	[FieldOffset(Offset = "0x4C")]
	public UIPanel RoomSettingPanel;

	[Token(Token = "0x4014781")]
	[FieldOffset(Offset = "0x50")]
	public UIGrid UIGridMapGrid;

	[Token(Token = "0x4014782")]
	[FieldOffset(Offset = "0x54")]
	public UIToggleButtonGroup UIToggleButtonGroupMapGrid;

	[Token(Token = "0x4014783")]
	[FieldOffset(Offset = "0x58")]
	public UICreateRoomMapItem MapItemObj;

	[Token(Token = "0x4014784")]
	[FieldOffset(Offset = "0x5C")]
	public UIWidget GameModePopMenu;

	[Token(Token = "0x4014785")]
	[FieldOffset(Offset = "0x60")]
	public UIButton HelpeBtn;

	[Token(Token = "0x4014786")]
	[FieldOffset(Offset = "0x64")]
	public UIInput NameInput;

	[Token(Token = "0x4014787")]
	[FieldOffset(Offset = "0x68")]
	public UIInput CodeInput;

	[Token(Token = "0x4014788")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel GroupModeLabel;

	[Token(Token = "0x4014789")]
	[FieldOffset(Offset = "0x70")]
	public GameObject Mode;

	[Token(Token = "0x401478A")]
	[FieldOffset(Offset = "0x74")]
	public UIToggleButton SoloToggle;

	[Token(Token = "0x401478B")]
	[FieldOffset(Offset = "0x78")]
	public UISprite SoloLabelCheckmark;

	[Token(Token = "0x401478C")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel SoloLabel;

	[Token(Token = "0x401478D")]
	[FieldOffset(Offset = "0x80")]
	public UIToggleButton DuoToggle;

	[Token(Token = "0x401478E")]
	[FieldOffset(Offset = "0x84")]
	public UISprite DuoCheckmark;

	[Token(Token = "0x401478F")]
	[FieldOffset(Offset = "0x88")]
	public UILabel DuoLabel;

	[Token(Token = "0x4014790")]
	[FieldOffset(Offset = "0x8C")]
	public UIToggleButton QuadToggle;

	[Token(Token = "0x4014791")]
	[FieldOffset(Offset = "0x90")]
	public UISprite QuadCheckmark;

	[Token(Token = "0x4014792")]
	[FieldOffset(Offset = "0x94")]
	public UILabel QuadLabel;

	[Token(Token = "0x4014793")]
	[FieldOffset(Offset = "0x98")]
	public UIToggleButton HexaToggle;

	[Token(Token = "0x4014794")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite HexaCheckmark;

	[Token(Token = "0x4014795")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel HexaLabel;

	[Token(Token = "0x4014796")]
	[FieldOffset(Offset = "0xA4")]
	public UIGrid RoomSettingDropListGrid;

	[Token(Token = "0x4014797")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject MembersGo;

	[Token(Token = "0x4014798")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject SpectatorsGo;

	[Token(Token = "0x4014799")]
	[FieldOffset(Offset = "0xB0")]
	public UIPanel RoomSettingMaskPanel;

	[Token(Token = "0x401479A")]
	[FieldOffset(Offset = "0xB4")]
	public UIButton RoomSettingMask;

	[Token(Token = "0x401479B")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject GameSettingDragCollider;

	[Token(Token = "0x401479C")]
	[FieldOffset(Offset = "0xBC")]
	public UIPanel UIPanelGameSettingPanel;

	[Token(Token = "0x401479D")]
	[FieldOffset(Offset = "0xC0")]
	public UIScrollView UIScrollViewGameSettingPanel;

	[Token(Token = "0x401479E")]
	[FieldOffset(Offset = "0xC4")]
	public UITable GameSettingTable;

	[Token(Token = "0x401479F")]
	[FieldOffset(Offset = "0xC8")]
	public UIGrid UIGridDropListGrid;

	[Token(Token = "0x40147A0")]
	[FieldOffset(Offset = "0xCC")]
	public UIToggleButtonGroup UIToggleButtonGroupDropListGrid;

	[Token(Token = "0x40147A1")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel LblSubModeDes;

	[Token(Token = "0x40147A2")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject GameSettingCSModeGo;

	[Token(Token = "0x40147A3")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject CSTotalRoundGo;

	[Token(Token = "0x40147A4")]
	[FieldOffset(Offset = "0xDC")]
	public GameObject CSInitCoinGo;

	[Token(Token = "0x40147A5")]
	[FieldOffset(Offset = "0xE0")]
	public UIGrid GameSettingDropListGrid;

	[Token(Token = "0x40147A6")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject FightClubTotalRoundGo;

	[Token(Token = "0x40147A7")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject ReviveGo;

	[Token(Token = "0x40147A8")]
	[FieldOffset(Offset = "0xEC")]
	public GameObject HPGo;

	[Token(Token = "0x40147A9")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject EPGo;

	[Token(Token = "0x40147AA")]
	[FieldOffset(Offset = "0xF4")]
	public GameObject SpeedGo;

	[Token(Token = "0x40147AB")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject JumpHeightGo;

	[Token(Token = "0x40147AC")]
	[FieldOffset(Offset = "0xFC")]
	public UIGrid GameSettingToggleGrid;

	[Token(Token = "0x40147AD")]
	[FieldOffset(Offset = "0x100")]
	public GameObject WeatherTypeGo;

	[Token(Token = "0x40147AE")]
	[FieldOffset(Offset = "0x104")]
	public GameObject UnlimitedAmmoGo;

	[Token(Token = "0x40147AF")]
	[FieldOffset(Offset = "0x108")]
	public GameObject NoFallingDamageGo;

	[Token(Token = "0x40147B0")]
	[FieldOffset(Offset = "0x10C")]
	public GameObject NoLoadoutGo;

	[Token(Token = "0x40147B1")]
	[FieldOffset(Offset = "0x110")]
	public GameObject NoAirdropGo;

	[Token(Token = "0x40147B2")]
	[FieldOffset(Offset = "0x114")]
	public GameObject NoSkillGo;

	[Token(Token = "0x40147B3")]
	[FieldOffset(Offset = "0x118")]
	public GameObject NoVehicleGo;

	[Token(Token = "0x40147B4")]
	[FieldOffset(Offset = "0x11C")]
	public GameObject PowerGunGo;

	[Token(Token = "0x40147B5")]
	[FieldOffset(Offset = "0x120")]
	public GameObject NoUAVGo;

	[Token(Token = "0x40147B6")]
	[FieldOffset(Offset = "0x124")]
	public GameObject NoBombGo;

	[Token(Token = "0x40147B7")]
	[FieldOffset(Offset = "0x128")]
	public GameObject NoZeppelinGo;

	[Token(Token = "0x40147B8")]
	[FieldOffset(Offset = "0x12C")]
	public GameObject HideEnemyClothGo;

	[Token(Token = "0x40147B9")]
	[FieldOffset(Offset = "0x130")]
	public GameObject HideHudGo;

	[Token(Token = "0x40147BA")]
	[FieldOffset(Offset = "0x134")]
	public GameObject FriendDmgGo;

	[Token(Token = "0x40147BB")]
	[FieldOffset(Offset = "0x138")]
	public GameObject InGameChatGo;

	[Token(Token = "0x40147BC")]
	[FieldOffset(Offset = "0x13C")]
	public GameObject ShopFlowGo;

	[Token(Token = "0x40147BD")]
	[FieldOffset(Offset = "0x140")]
	public GameObject UseRandomMapGo;

	[Token(Token = "0x40147BE")]
	[FieldOffset(Offset = "0x144")]
	public GameObject AuxAimGo;

	[Token(Token = "0x40147BF")]
	[FieldOffset(Offset = "0x148")]
	public GameObject GameSettingPanelArrow;

	[Token(Token = "0x40147C0")]
	[FieldOffset(Offset = "0x14C")]
	public UIWidget OBSettingPanel;

	[Token(Token = "0x40147C1")]
	[FieldOffset(Offset = "0x150")]
	public UIGrid OBSettingToggleGrid;

	[Token(Token = "0x40147C2")]
	[FieldOffset(Offset = "0x154")]
	public GameObject OBEnabledGo;

	[Token(Token = "0x40147C3")]
	[FieldOffset(Offset = "0x158")]
	public GameObject AccDataGo;

	[Token(Token = "0x40147C4")]
	[FieldOffset(Offset = "0x15C")]
	public GameObject HideKillInfoGo;

	[Token(Token = "0x40147C5")]
	[FieldOffset(Offset = "0x160")]
	public GameObject ReplayEnabledGo;

	[Token(Token = "0x40147C6")]
	[FieldOffset(Offset = "0x164")]
	public GameObject Emulator;

	[Token(Token = "0x40147C7")]
	[FieldOffset(Offset = "0x168")]
	public GameObject EnableRoleCheck;

	[Token(Token = "0x40147C8")]
	[FieldOffset(Offset = "0x16C")]
	public UIButton OBSettingMask;

	[Token(Token = "0x40147C9")]
	[FieldOffset(Offset = "0x170")]
	public GameObject CSAdSettingPanel;

	[Token(Token = "0x40147CA")]
	[FieldOffset(Offset = "0x174")]
	public GameObject UnavailablePanel;

	[Token(Token = "0x40147CB")]
	[FieldOffset(Offset = "0x178")]
	public UILabel UnavailableTxt;

	[Token(Token = "0x40147CC")]
	[FieldOffset(Offset = "0x17C")]
	public UIGrid BtnGrid;

	[Token(Token = "0x40147CD")]
	[FieldOffset(Offset = "0x180")]
	public UIButton CancelBtn;

	[Token(Token = "0x40147CE")]
	[FieldOffset(Offset = "0x184")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x40147CF")]
	[FieldOffset(Offset = "0x188")]
	public UIButton ReOpenBtn;

	[Token(Token = "0x40147D0")]
	[FieldOffset(Offset = "0x18C")]
	public UIGrid ModeGrid;

	[Token(Token = "0x40147D1")]
	[FieldOffset(Offset = "0x190")]
	public UIToggleButton PentaToggle;

	[Token(Token = "0x40147D2")]
	[FieldOffset(Offset = "0x194")]
	public UISprite PentaCheckmark;

	[Token(Token = "0x40147D3")]
	[FieldOffset(Offset = "0x198")]
	public UILabel PentaLabel;

	[Token(Token = "0x40147D4")]
	[FieldOffset(Offset = "0x19C")]
	public GameObject AutoRevival;

	[Token(Token = "0x40147D5")]
	[FieldOffset(Offset = "0x1A0")]
	public GameObject SaveZoneSpeed;

	[Token(Token = "0x40147D6")]
	[FieldOffset(Offset = "0x1A4")]
	public GameObject SaveZoneDamage;

	[Token(Token = "0x40147D7")]
	[FieldOffset(Offset = "0x1A8")]
	public UIScrollView MapScrollView;

	[Token(Token = "0x40147D8")]
	[FieldOffset(Offset = "0x1AC")]
	public Transform MatchStartBuff;

	[Token(Token = "0x40147D9")]
	[FieldOffset(Offset = "0x1B0")]
	public GameObject GameMissionGo;

	[Token(Token = "0x40147DA")]
	[FieldOffset(Offset = "0x1B4")]
	public GameObject ScoreVisible;

	[Token(Token = "0x40147DB")]
	[FieldOffset(Offset = "0x1B8")]
	public GameObject Bg_CS;

	[Token(Token = "0x40147DC")]
	[FieldOffset(Offset = "0x1BC")]
	public GameObject Bg_BR;

	[Token(Token = "0x6016161")]
	[Address(RVA = "0x27376D4", Offset = "0x27376D4", VA = "0x27376D4")]
	public UICreateRoomView()
	{
	}

	[Token(Token = "0x6016162")]
	[Address(RVA = "0x27376DC", Offset = "0x27376DC", VA = "0x27376DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016163")]
	[Address(RVA = "0x2739D8C", Offset = "0x2739D8C", VA = "0x2739D8C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
