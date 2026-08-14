using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003889")]
public class UIMapContentView : UIBaseView
{
	[Token(Token = "0x4017529")]
	[FieldOffset(Offset = "0x14")]
	public Transform MapPanel;

	[Token(Token = "0x401752A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject mushroom;

	[Token(Token = "0x401752B")]
	[FieldOffset(Offset = "0x1C")]
	public UITexture MapBG;

	[Token(Token = "0x401752C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject WorkMapRoot;

	[Token(Token = "0x401752D")]
	[FieldOffset(Offset = "0x24")]
	public UITexture WorkShopItemMap;

	[Token(Token = "0x401752E")]
	[FieldOffset(Offset = "0x28")]
	public UITexture WorkShopItemMapOutline1;

	[Token(Token = "0x401752F")]
	[FieldOffset(Offset = "0x2C")]
	public UITexture WorkShopItemMapOutline2;

	[Token(Token = "0x4017530")]
	[FieldOffset(Offset = "0x30")]
	public UITexture WorkShopItemMapOutline3;

	[Token(Token = "0x4017531")]
	[FieldOffset(Offset = "0x34")]
	public UITexture WorkShopItemMapOutline4;

	[Token(Token = "0x4017532")]
	[FieldOffset(Offset = "0x38")]
	public UITexture WorkShopItemMapShadow;

	[Token(Token = "0x4017533")]
	[FieldOffset(Offset = "0x3C")]
	public UITexture workShopMapBg;

	[Token(Token = "0x4017534")]
	[FieldOffset(Offset = "0x40")]
	public UITexture MapGrid;

	[Token(Token = "0x4017535")]
	[FieldOffset(Offset = "0x44")]
	public GameObject BombDangerArea;

	[Token(Token = "0x4017536")]
	[FieldOffset(Offset = "0x48")]
	public GameObject BombDangerInstance;

	[Token(Token = "0x4017537")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject WarningZoneArea;

	[Token(Token = "0x4017538")]
	[FieldOffset(Offset = "0x50")]
	public GameObject HotzoneContainer;

	[Token(Token = "0x4017539")]
	[FieldOffset(Offset = "0x54")]
	public GameObject HotzoneArea;

	[Token(Token = "0x401753A")]
	[FieldOffset(Offset = "0x58")]
	public UISprite GuideToMark;

	[Token(Token = "0x401753B")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite warningToSafeZone;

	[Token(Token = "0x401753C")]
	[FieldOffset(Offset = "0x60")]
	public Transform warningArrow;

	[Token(Token = "0x401753D")]
	[FieldOffset(Offset = "0x64")]
	public UISprite GuideToSaveZone;

	[Token(Token = "0x401753E")]
	[FieldOffset(Offset = "0x68")]
	public GameObject OBAirtransporter;

	[Token(Token = "0x401753F")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject PlayerArrow;

	[Token(Token = "0x4017540")]
	[FieldOffset(Offset = "0x70")]
	public UISprite PlayerArrowSprite;

	[Token(Token = "0x4017541")]
	[FieldOffset(Offset = "0x74")]
	public TweenAlpha UavPlayerArrow;

	[Token(Token = "0x4017542")]
	[FieldOffset(Offset = "0x78")]
	public GameObject Arrow;

	[Token(Token = "0x4017543")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject TeamMate;

	[Token(Token = "0x4017544")]
	[FieldOffset(Offset = "0x80")]
	public GameObject id;

	[Token(Token = "0x4017545")]
	[FieldOffset(Offset = "0x84")]
	public GameObject direction;

	[Token(Token = "0x4017546")]
	[FieldOffset(Offset = "0x88")]
	public GameObject knockdown;

	[Token(Token = "0x4017547")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject dead;

	[Token(Token = "0x4017548")]
	[FieldOffset(Offset = "0x90")]
	public GameObject vehicle;

	[Token(Token = "0x4017549")]
	[FieldOffset(Offset = "0x94")]
	public GameObject QuickChatEffect;

	[Token(Token = "0x401754A")]
	[FieldOffset(Offset = "0x98")]
	public GameObject TeammatePoints;

	[Token(Token = "0x401754B")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite TeammatePoint1;

	[Token(Token = "0x401754C")]
	[FieldOffset(Offset = "0xA0")]
	public UISprite TeammatePoint2;

	[Token(Token = "0x401754D")]
	[FieldOffset(Offset = "0xA4")]
	public UISprite TeammatePoint3;

	[Token(Token = "0x401754E")]
	[FieldOffset(Offset = "0xA8")]
	public UISprite UavPoint;

	[Token(Token = "0x401754F")]
	[FieldOffset(Offset = "0xAC")]
	public UISprite DetectorPoint;

	[Token(Token = "0x4017550")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite DetectorCar;

	[Token(Token = "0x4017551")]
	[FieldOffset(Offset = "0xB4")]
	public Transform Uav;

	[Token(Token = "0x4017552")]
	[FieldOffset(Offset = "0xB8")]
	public UIUAVMapObjectView UAVObjectView;

	[Token(Token = "0x4017553")]
	[FieldOffset(Offset = "0xBC")]
	public UISprite UavCircle;

	[Token(Token = "0x4017554")]
	[FieldOffset(Offset = "0xC0")]
	public TweenScale UavCircleLine;

	[Token(Token = "0x4017555")]
	[FieldOffset(Offset = "0xC4")]
	public Transform Bounty;

	[Token(Token = "0x4017556")]
	[FieldOffset(Offset = "0xC8")]
	public UISprite MarkCircle;

	[Token(Token = "0x4017557")]
	[FieldOffset(Offset = "0xCC")]
	public TweenAlpha MarkerTween;

	[Token(Token = "0x4017558")]
	[FieldOffset(Offset = "0xD0")]
	public TweenScale MarkCircleLine;

	[Token(Token = "0x4017559")]
	[FieldOffset(Offset = "0xD4")]
	public UISprite DirectionHint;

	[Token(Token = "0x401755A")]
	[FieldOffset(Offset = "0xD8")]
	public TweenAlpha DirectionHintTween;

	[Token(Token = "0x401755B")]
	[FieldOffset(Offset = "0xDC")]
	public Transform Detector;

	[Token(Token = "0x401755C")]
	[FieldOffset(Offset = "0xE0")]
	public UISprite DetectorCircle;

	[Token(Token = "0x401755D")]
	[FieldOffset(Offset = "0xE4")]
	public TweenScale DetectorCircleLine;

	[Token(Token = "0x401755E")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject AirlineContainer;

	[Token(Token = "0x401755F")]
	[FieldOffset(Offset = "0xEC")]
	public UISprite AirLine;

	[Token(Token = "0x4017560")]
	[FieldOffset(Offset = "0xF0")]
	public UISprite AirLinePointStart;

	[Token(Token = "0x4017561")]
	[FieldOffset(Offset = "0xF4")]
	public UISprite AirLinePointEnd;

	[Token(Token = "0x4017562")]
	[FieldOffset(Offset = "0xF8")]
	public Transform OBPlayerContainer;

	[Token(Token = "0x4017563")]
	[FieldOffset(Offset = "0xFC")]
	public UISprite SpectatorAirDrop;

	[Token(Token = "0x4017564")]
	[FieldOffset(Offset = "0x100")]
	public GameObject TreasureMark;

	[Token(Token = "0x4017565")]
	[FieldOffset(Offset = "0x104")]
	public GameObject CampFire;

	[Token(Token = "0x4017566")]
	[FieldOffset(Offset = "0x108")]
	public GameObject Carepackage;

	[Token(Token = "0x4017567")]
	[FieldOffset(Offset = "0x10C")]
	public LastVehicleObject LastVehicleUIObject;

	[Token(Token = "0x4017568")]
	[FieldOffset(Offset = "0x110")]
	public GameObject MapMarks;

	[Token(Token = "0x4017569")]
	[FieldOffset(Offset = "0x114")]
	public GameObject MapMark;

	[Token(Token = "0x401756A")]
	[FieldOffset(Offset = "0x118")]
	public UISprite Mark;

	[Token(Token = "0x401756B")]
	[FieldOffset(Offset = "0x11C")]
	public GameObject MapMark2;

	[Token(Token = "0x401756C")]
	[FieldOffset(Offset = "0x120")]
	public UISprite Mark2;

	[Token(Token = "0x401756D")]
	[FieldOffset(Offset = "0x124")]
	public GameObject MapMark3;

	[Token(Token = "0x401756E")]
	[FieldOffset(Offset = "0x128")]
	public UISprite Mark3;

	[Token(Token = "0x401756F")]
	[FieldOffset(Offset = "0x12C")]
	public GameObject MapMark4;

	[Token(Token = "0x4017570")]
	[FieldOffset(Offset = "0x130")]
	public UISprite Mark4;

	[Token(Token = "0x4017571")]
	[FieldOffset(Offset = "0x134")]
	public GameObject Zombie;

	[Token(Token = "0x4017572")]
	[FieldOffset(Offset = "0x138")]
	public GameObject EnermyPoint;

	[Token(Token = "0x4017573")]
	[FieldOffset(Offset = "0x13C")]
	public GameObject TeleportDoor;

	[Token(Token = "0x4017574")]
	[FieldOffset(Offset = "0x140")]
	public GameObject MaxHypePlayerPoint;

	[Token(Token = "0x4017575")]
	[FieldOffset(Offset = "0x144")]
	public GameObject AirDropNext;

	[Token(Token = "0x4017576")]
	[FieldOffset(Offset = "0x148")]
	public GameObject ToxicZoneArea;

	[Token(Token = "0x4017577")]
	[FieldOffset(Offset = "0x14C")]
	public GameObject ToxicZoneInstance;

	[Token(Token = "0x4017578")]
	[FieldOffset(Offset = "0x150")]
	public GameObject csZone;

	[Token(Token = "0x4017579")]
	[FieldOffset(Offset = "0x154")]
	public GameObject gamezone;

	[Token(Token = "0x401757A")]
	[FieldOffset(Offset = "0x158")]
	public GameObject CandyZoneIcon;

	[Token(Token = "0x401757B")]
	[FieldOffset(Offset = "0x15C")]
	public GameObject Pumpkin;

	[Token(Token = "0x401757C")]
	[FieldOffset(Offset = "0x160")]
	public PlayerPumpkinInfo PlayerPumpkin;

	[Token(Token = "0x401757D")]
	[FieldOffset(Offset = "0x164")]
	public GameObject GeneratedBuff;

	[Token(Token = "0x401757E")]
	[FieldOffset(Offset = "0x168")]
	public GameObject ItemGenerator;

	[Token(Token = "0x401757F")]
	[FieldOffset(Offset = "0x16C")]
	public GameObject bombZone;

	[Token(Token = "0x4017580")]
	[FieldOffset(Offset = "0x170")]
	public GameObject bombZoneTemplate;

	[Token(Token = "0x4017581")]
	[FieldOffset(Offset = "0x174")]
	public UISprite BombPickup;

	[Token(Token = "0x4017582")]
	[FieldOffset(Offset = "0x178")]
	public GameObject zeppelinContainer;

	[Token(Token = "0x4017583")]
	[FieldOffset(Offset = "0x17C")]
	public UISprite zeppelin;

	[Token(Token = "0x4017584")]
	[FieldOffset(Offset = "0x180")]
	public UISprite zeppelinDestination;

	[Token(Token = "0x4017585")]
	[FieldOffset(Offset = "0x184")]
	public UISprite zeppelinDirection;

	[Token(Token = "0x4017586")]
	[FieldOffset(Offset = "0x188")]
	public Transform zeppelinArrow;

	[Token(Token = "0x4017587")]
	[FieldOffset(Offset = "0x18C")]
	public UISprite ReaperPlayer;

	[Token(Token = "0x4017588")]
	[FieldOffset(Offset = "0x190")]
	public UISprite DetectiveMarkPoint;

	[Token(Token = "0x4017589")]
	[FieldOffset(Offset = "0x194")]
	public UISprite EscortVehicle;

	[Token(Token = "0x401758A")]
	[FieldOffset(Offset = "0x198")]
	public GameObject DetectiveEffectObj;

	[Token(Token = "0x401758B")]
	[FieldOffset(Offset = "0x19C")]
	public GameObject DetectiveEffect;

	[Token(Token = "0x401758C")]
	[FieldOffset(Offset = "0x1A0")]
	public GameObject DeliveryMarkEnermyPoint;

	[Token(Token = "0x401758D")]
	[FieldOffset(Offset = "0x1A4")]
	public GameObject RevivePointContainer;

	[Token(Token = "0x401758E")]
	[FieldOffset(Offset = "0x1A8")]
	public UIRevivePointMapIconController RevivePointIcon;

	[Token(Token = "0x401758F")]
	[FieldOffset(Offset = "0x1AC")]
	public GameObject IngameShopPointContainer;

	[Token(Token = "0x4017590")]
	[FieldOffset(Offset = "0x1B0")]
	public GameObject IngameShopPointIcon;

	[Token(Token = "0x4017591")]
	[FieldOffset(Offset = "0x1B4")]
	public GameObject BountyContract;

	[Token(Token = "0x4017592")]
	[FieldOffset(Offset = "0x1B8")]
	public UISprite WereWolvesBody;

	[Token(Token = "0x4017593")]
	[FieldOffset(Offset = "0x1BC")]
	public UILabel WereWolvesBodyName;

	[Token(Token = "0x4017594")]
	[FieldOffset(Offset = "0x1C0")]
	public GameObject TaskPoint;

	[Token(Token = "0x4017595")]
	[FieldOffset(Offset = "0x1C4")]
	public GameObject randomCenter;

	[Token(Token = "0x4017596")]
	[FieldOffset(Offset = "0x1C8")]
	public GameObject EmergencyTaskPoint;

	[Token(Token = "0x4017597")]
	[FieldOffset(Offset = "0x1CC")]
	public GameObject TrapIcon;

	[Token(Token = "0x4017598")]
	[FieldOffset(Offset = "0x1D0")]
	public UISprite WSMapIconItem;

	[Token(Token = "0x4017599")]
	[FieldOffset(Offset = "0x1D4")]
	public GameMissionPlayerRangeView WantedPlayerRange;

	[Token(Token = "0x401759A")]
	[FieldOffset(Offset = "0x1D8")]
	public GameObject obevent;

	[Token(Token = "0x401759B")]
	[FieldOffset(Offset = "0x1DC")]
	public GameObject obeventDragContainer;

	[Token(Token = "0x401759C")]
	[FieldOffset(Offset = "0x1E0")]
	public GameObject DeadBox;

	[Token(Token = "0x401759D")]
	[FieldOffset(Offset = "0x1E4")]
	public GameObject EnergyStoneBox;

	[Token(Token = "0x401759E")]
	[FieldOffset(Offset = "0x1E8")]
	public UIHudPlayerMarkIcon MarkIcon1;

	[Token(Token = "0x401759F")]
	[FieldOffset(Offset = "0x1EC")]
	public UIHudPlayerMarkIcon MarkIcon2;

	[Token(Token = "0x40175A0")]
	[FieldOffset(Offset = "0x1F0")]
	public UIHudPlayerMarkIcon MarkIcon3;

	[Token(Token = "0x40175A1")]
	[FieldOffset(Offset = "0x1F4")]
	public UIHudPlayerMarkIcon MarkIcon4;

	[Token(Token = "0x40175A2")]
	[FieldOffset(Offset = "0x1F8")]
	public UILabel TeamMateIDLable;

	[Token(Token = "0x40175A3")]
	[FieldOffset(Offset = "0x1FC")]
	public GameObject MapBGMask;

	[Token(Token = "0x40175A4")]
	[FieldOffset(Offset = "0x200")]
	public GameObject VFX_BombPickup;

	[Token(Token = "0x40175A5")]
	[FieldOffset(Offset = "0x204")]
	public UISprite PlayerArrowShadow;

	[Token(Token = "0x40175A6")]
	[FieldOffset(Offset = "0x208")]
	public UIHudPlayerMarkIcon MarkIcon5;

	[Token(Token = "0x40175A7")]
	[FieldOffset(Offset = "0x20C")]
	public UIHudPlayerMarkIcon MarkIcon6;

	[Token(Token = "0x40175A8")]
	[FieldOffset(Offset = "0x210")]
	public UISprite DetectiveEffectExtend;

	[Token(Token = "0x40175A9")]
	[FieldOffset(Offset = "0x214")]
	public GameObject KillerKing;

	[Token(Token = "0x40175AA")]
	[FieldOffset(Offset = "0x218")]
	public GameObject FateRandomBornTeamZone;

	[Token(Token = "0x40175AB")]
	[FieldOffset(Offset = "0x21C")]
	public GameObject ugcSupplyBoxTriggerContainer;

	[Token(Token = "0x40175AC")]
	[FieldOffset(Offset = "0x220")]
	public UISprite ugcSupplyBoxTrigger;

	[Token(Token = "0x6016D46")]
	[Address(RVA = "0x27FD3A8", Offset = "0x27FD3A8", VA = "0x27FD3A8")]
	public UIMapContentView()
	{
	}

	[Token(Token = "0x6016D47")]
	[Address(RVA = "0x27FD3B0", Offset = "0x27FD3B0", VA = "0x27FD3B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D48")]
	[Address(RVA = "0x2800270", Offset = "0x2800270", VA = "0x2800270")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
