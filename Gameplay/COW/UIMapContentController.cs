using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002270")]
public class UIMapContentController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002271")]
	private struct EnermyPointObject
	{
		[Token(Token = "0x400D7B3")]
		[FieldOffset(Offset = "0x0")]
		public GameObject PointObject;

		[Token(Token = "0x400D7B4")]
		[FieldOffset(Offset = "0x8")]
		public IHAAMHPPLMG EnermyID;

		[Token(Token = "0x400D7B5")]
		[FieldOffset(Offset = "0x20")]
		public int ServerEndTime;
	}

	[Token(Token = "0x2002272")]
	public enum EIconType
	{
		[Token(Token = "0x400D7B7")]
		EIconType_InGameShop,
		[Token(Token = "0x400D7B8")]
		EIconType_RevivePoint
	}

	[Token(Token = "0x2002273")]
	private class DeliveryEnermyPointObject
	{
		[Token(Token = "0x400D7B9")]
		[FieldOffset(Offset = "0x8")]
		public GameObject PointObject;

		[Token(Token = "0x400D7BA")]
		[FieldOffset(Offset = "0x10")]
		public IHAAMHPPLMG EnermyID;

		[Token(Token = "0x400D7BB")]
		[FieldOffset(Offset = "0x28")]
		public int ServerEndTime;

		[Token(Token = "0x400D7BC")]
		[FieldOffset(Offset = "0x2C")]
		public bool Marked;

		[Token(Token = "0x600BCD9")]
		[Address(RVA = "0x27FD210", Offset = "0x27FD210", VA = "0x27FD210")]
		public DeliveryEnermyPointObject()
		{
		}

		[Token(Token = "0x600BCDA")]
		[Address(RVA = "0x27FD218", Offset = "0x27FD218", VA = "0x27FD218")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002274")]
	private sealed class _003COnTeleportDoorStateChanged_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D7BD")]
		[FieldOffset(Offset = "0x8")]
		internal uint uid;

		[Token(Token = "0x600BCDB")]
		[Address(RVA = "0x27FD12C", Offset = "0x27FD12C", VA = "0x27FD12C")]
		public _003COnTeleportDoorStateChanged_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600BCDC")]
		[Address(RVA = "0x27FD134", Offset = "0x27FD134", VA = "0x27FD134")]
		internal bool _003C_003Em__0(TeleportDoorHintInfo e)
		{
			return default(bool);
		}

		[Token(Token = "0x600BCDD")]
		[Address(RVA = "0x27FD16C", Offset = "0x27FD16C", VA = "0x27FD16C")]
		internal bool _003C_003Em__1(TeleportDoorHintInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002275")]
	private sealed class _003CShowMaxHypePlayerShooting_003Ec__AnonStorey1
	{
		[Token(Token = "0x400D7BE")]
		[FieldOffset(Offset = "0x8")]
		internal MaxHypePlayerHint hint;

		[Token(Token = "0x600BCDE")]
		[Address(RVA = "0x27FD1A4", Offset = "0x27FD1A4", VA = "0x27FD1A4")]
		public _003CShowMaxHypePlayerShooting_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600BCDF")]
		[Address(RVA = "0x27FD1AC", Offset = "0x27FD1AC", VA = "0x27FD1AC")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400D741")]
	[FieldOffset(Offset = "0x28")]
	private UIMapContentView m_View;

	[Token(Token = "0x400D742")]
	[FieldOffset(Offset = "0x2C")]
	private Player m_Player;

	[Token(Token = "0x400D743")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_Center;

	[Token(Token = "0x400D744")]
	[FieldOffset(Offset = "0x0")]
	public static float SIZE_MAP_PIXEL_X;

	[Token(Token = "0x400D745")]
	[FieldOffset(Offset = "0x3C")]
	public float SIZE_MAP_PIXEL_Y;

	[Token(Token = "0x400D746")]
	[FieldOffset(Offset = "0x40")]
	public float ZONE_DIAMETER;

	[Token(Token = "0x400D747")]
	[FieldOffset(Offset = "0x44")]
	public float ZONE_DIAMETER_MAP;

	[Token(Token = "0x400D748")]
	[FieldOffset(Offset = "0x48")]
	private float SIZE_MAP_X;

	[Token(Token = "0x400D749")]
	[FieldOffset(Offset = "0x4C")]
	private float SIZE_MAP_Z;

	[Token(Token = "0x400D74A")]
	[FieldOffset(Offset = "0x50")]
	private float OFFSET_SCALE_RATIO_X;

	[Token(Token = "0x400D74B")]
	[FieldOffset(Offset = "0x54")]
	private float m_rotz;

	[Token(Token = "0x400D74C")]
	[FieldOffset(Offset = "0x58")]
	private float m_peoplerotz;

	[Token(Token = "0x400D74D")]
	[FieldOffset(Offset = "0x5C")]
	private GameObject m_LocalMapMark;

	[Token(Token = "0x400D74E")]
	[FieldOffset(Offset = "0x60")]
	private UIHudPlayerMarkController m_LocalMapMarkController;

	[Token(Token = "0x400D74F")]
	[FieldOffset(Offset = "0x64")]
	private UIBigMapObEventController m_ObEventController;

	[Token(Token = "0x400D750")]
	[FieldOffset(Offset = "0x68")]
	private float MOVE_SENSITIVITY;

	[Token(Token = "0x400D751")]
	[FieldOffset(Offset = "0x6C")]
	private Dictionary<IHAAMHPPLMG, float> m_TeammateMapMarkScale;

	[Token(Token = "0x400D752")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<IHAAMHPPLMG, UIHudPlayerMarkController> m_TeammateMapMarkDict;

	[Token(Token = "0x400D753")]
	[FieldOffset(Offset = "0x74")]
	private Dictionary<IHAAMHPPLMG, TeammateGameObject> m_TeammatesMap;

	[Token(Token = "0x400D754")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<IHAAMHPPLMG, MapUIDeadBox> m_DeadBoxMap;

	[Token(Token = "0x400D755")]
	[FieldOffset(Offset = "0x7C")]
	private Dictionary<uint, GameObject> m_CampFireDict;

	[Token(Token = "0x400D756")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<uint, GameObject> m_CarePackageDict;

	[Token(Token = "0x400D757")]
	[FieldOffset(Offset = "0x84")]
	private Dictionary<uint, GameObject> m_AirDropDict;

	[Token(Token = "0x400D758")]
	[FieldOffset(Offset = "0x88")]
	private Dictionary<uint, GameObject> m_WereWolvesTaskDict;

	[Token(Token = "0x400D759")]
	[FieldOffset(Offset = "0x8C")]
	private Dictionary<uint, GameObject> m_WereWolvesEmergencyTaskDict;

	[Token(Token = "0x400D75A")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<IHAAMHPPLMG, GameObject> m_ZombieDict;

	[Token(Token = "0x400D75B")]
	[FieldOffset(Offset = "0x94")]
	private Dictionary<uint, GameObject> m_PumpkinDict;

	[Token(Token = "0x400D75C")]
	[FieldOffset(Offset = "0x98")]
	private Dictionary<IHAAMHPPLMG, PlayerPumpkinInfo> m_PumpkinHighScoreDict;

	[Token(Token = "0x400D75D")]
	[FieldOffset(Offset = "0x9C")]
	private EBigMapType m_BigMapType;

	[Token(Token = "0x400D75E")]
	[FieldOffset(Offset = "0xA0")]
	private Dictionary<uint, GameObject> m_HotzoneObjects;

	[Token(Token = "0x400D75F")]
	[FieldOffset(Offset = "0xA4")]
	private Dictionary<uint, UIRevivePointMapIconController> m_RevivePointIcons;

	[Token(Token = "0x400D760")]
	[FieldOffset(Offset = "0xA8")]
	private Dictionary<uint, GameObject> m_TreasureMarks;

	[Token(Token = "0x400D761")]
	[FieldOffset(Offset = "0xAC")]
	private Dictionary<uint, GameObject> m_TreasuryMarks;

	[Token(Token = "0x400D762")]
	[FieldOffset(Offset = "0xB0")]
	private Dictionary<uint, GameObject> m_EnergyStoneBoxObjects;

	[Token(Token = "0x400D763")]
	[FieldOffset(Offset = "0xB4")]
	private Dictionary<string, GameObject> m_ActiveSupplyBoxTriggerObjects;

	[Token(Token = "0x400D764")]
	[FieldOffset(Offset = "0xB8")]
	private List<GameObject> m_SupplyBoxTriggerObjectsPool;

	[Token(Token = "0x400D765")]
	[FieldOffset(Offset = "0xBC")]
	private List<GameObject> m_BuffHintMarks;

	[Token(Token = "0x400D766")]
	[FieldOffset(Offset = "0xC0")]
	private List<GameObject> m_FateRandomZones;

	[Token(Token = "0x400D767")]
	[FieldOffset(Offset = "0xC4")]
	private Dictionary<uint, UIHudBombZoneView> m_BombZones;

	[Token(Token = "0x400D768")]
	[FieldOffset(Offset = "0xC8")]
	private UIHudBombZoneView m_ControllZone;

	[Token(Token = "0x400D769")]
	[FieldOffset(Offset = "0xCC")]
	private Color BOMB_ZONE_NO_BOMB;

	[Token(Token = "0x400D76A")]
	[FieldOffset(Offset = "0xDC")]
	private Color BOMB_ZONE_HAS_BOMB;

	[Token(Token = "0x400D76B")]
	[FieldOffset(Offset = "0xEC")]
	private Vector3 m_ZeppelinCurPos;

	[Token(Token = "0x400D76C")]
	[FieldOffset(Offset = "0xF8")]
	private Vector3 m_ZeppelinNextPos;

	[Token(Token = "0x400D76D")]
	[FieldOffset(Offset = "0x104")]
	private bool m_UpdateZeppeline;

	[Token(Token = "0x400D76E")]
	[FieldOffset(Offset = "0x108")]
	private Dictionary<IHAAMHPPLMG, EnermyPointObject> m_EnermyPointDict;

	[Token(Token = "0x400D76F")]
	[FieldOffset(Offset = "0x10C")]
	private DeliveryEnermyPointObject m_DeliverySkillMarkEnemyPoint;

	[Token(Token = "0x400D770")]
	[FieldOffset(Offset = "0x110")]
	private Queue<GameObject> m_CampFireCache;

	[Token(Token = "0x400D771")]
	[FieldOffset(Offset = "0x114")]
	private Queue<GameObject> m_CarePackageCache;

	[Token(Token = "0x400D772")]
	[FieldOffset(Offset = "0x118")]
	private Queue<GameObject> m_AirDropCache;

	[Token(Token = "0x400D773")]
	[FieldOffset(Offset = "0x11C")]
	private Queue<GameObject> m_WereWolvesTaskCache;

	[Token(Token = "0x400D774")]
	[FieldOffset(Offset = "0x120")]
	private Queue<GameObject> m_WereWolvesEmergencyTaskCache;

	[Token(Token = "0x400D775")]
	[FieldOffset(Offset = "0x124")]
	private List<GameObject> m_BombCache;

	[Token(Token = "0x400D776")]
	[FieldOffset(Offset = "0x128")]
	private Queue<GameObject> m_ZombieCache;

	[Token(Token = "0x400D777")]
	[FieldOffset(Offset = "0x12C")]
	private Queue<GameObject> m_EnermyPointCache;

	[Token(Token = "0x400D778")]
	[FieldOffset(Offset = "0x130")]
	private Queue<GameObject> m_PumpkinCache;

	[Token(Token = "0x400D779")]
	[FieldOffset(Offset = "0x134")]
	private Queue<PlayerPumpkinInfo> m_PumpkinHighScoreCache;

	[Token(Token = "0x400D77A")]
	[FieldOffset(Offset = "0x138")]
	private List<GameObject> m_ToxicCache;

	[Token(Token = "0x400D77B")]
	[FieldOffset(Offset = "0x13C")]
	private bool m_ToxicZoneDirty;

	[Token(Token = "0x400D77C")]
	[FieldOffset(Offset = "0x140")]
	private Dictionary<IHAAMHPPLMG, MaxHypePlayerHint> m_RevengeMarkMap;

	[Token(Token = "0x400D77D")]
	[FieldOffset(Offset = "0x144")]
	private Queue<GameObject> m_RevengeMarkCache;

	[Token(Token = "0x400D77E")]
	[FieldOffset(Offset = "0x148")]
	private Dictionary<IHAAMHPPLMG, MaxHypePlayerHint> m_MaxHypePlayerDic;

	[Token(Token = "0x400D77F")]
	[FieldOffset(Offset = "0x14C")]
	private Queue<GameObject> m_MaxHypePlayerCache;

	[Token(Token = "0x400D780")]
	[FieldOffset(Offset = "0x150")]
	private Queue<GameObject> m_GeneratedItemCache;

	[Token(Token = "0x400D781")]
	[FieldOffset(Offset = "0x154")]
	private Dictionary<uint, GeneratedItemHint> m_GeneratedItemDic;

	[Token(Token = "0x400D782")]
	[FieldOffset(Offset = "0x158")]
	private Dictionary<int, List<TeleportDoorHintInfo>> m_TeleportDoors;

	[Token(Token = "0x400D783")]
	[FieldOffset(Offset = "0x15C")]
	private List<GameObject> m_TrainingAroundEnermyPoints;

	[Token(Token = "0x400D784")]
	[FieldOffset(Offset = "0x160")]
	private List<UISprite> m_TeammateSprites;

	[Token(Token = "0x400D785")]
	[FieldOffset(Offset = "0x164")]
	private Vector3 m_InnerCenterPos;

	[Token(Token = "0x400D786")]
	[FieldOffset(Offset = "0x170")]
	private Vector3 m_InnerZoneScale;

	[Token(Token = "0x400D787")]
	[FieldOffset(Offset = "0x17C")]
	private Queue m_QueueDeadTeammates;

	[Token(Token = "0x400D788")]
	[FieldOffset(Offset = "0x180")]
	private List<UavMapObject> m_UAVObjects;

	[Token(Token = "0x400D789")]
	[FieldOffset(Offset = "0x184")]
	private BountyScannerMapObject m_BountyScanner;

	[Token(Token = "0x400D78A")]
	[FieldOffset(Offset = "0x188")]
	private DetectorMapObject m_Detector;

	[Token(Token = "0x400D78B")]
	[FieldOffset(Offset = "0x18C")]
	private AirLineObject m_AirLine;

	[Token(Token = "0x400D78C")]
	[FieldOffset(Offset = "0x190")]
	private float m_CurrentScaleRatio;

	[Token(Token = "0x400D78D")]
	[FieldOffset(Offset = "0x194")]
	private bool m_FirstScale;

	[Token(Token = "0x400D78E")]
	[FieldOffset(Offset = "0x198")]
	private float m_FirstScaleRatio;

	[Token(Token = "0x400D78F")]
	[FieldOffset(Offset = "0x19C")]
	private UIHudPlayerMarkIcon[] m_NewMarks;

	[Token(Token = "0x400D790")]
	[FieldOffset(Offset = "0x1A0")]
	public UIMapUtil.EMapType MapType;

	[Token(Token = "0x400D791")]
	[FieldOffset(Offset = "0x1A4")]
	private bool m_MinimapScaleEnabled;

	[Token(Token = "0x400D792")]
	[FieldOffset(Offset = "0x1A8")]
	private float m_MinimapScale;

	[Token(Token = "0x400D793")]
	[FieldOffset(Offset = "0x1AC")]
	private Vector3 m_BigmapScaleMin;

	[Token(Token = "0x400D794")]
	[FieldOffset(Offset = "0x1B8")]
	private float m_ClipHeight;

	[Token(Token = "0x400D795")]
	[FieldOffset(Offset = "0x1BC")]
	private float m_ClipWidth;

	[Token(Token = "0x400D796")]
	[FieldOffset(Offset = "0x1C0")]
	private Dictionary<GameObject, bool[]> m_ObjectGroupSetting;

	[Token(Token = "0x400D797")]
	[FieldOffset(Offset = "0x1C4")]
	private SafeZone m_CurrentSafeZone;

	[Token(Token = "0x400D798")]
	[FieldOffset(Offset = "0x1C8")]
	private bool m_CurrentSafeZoneRect;

	[Token(Token = "0x400D799")]
	[FieldOffset(Offset = "0x1C9")]
	private bool m_BombPositionInited;

	[Token(Token = "0x400D79A")]
	[FieldOffset(Offset = "0x1CC")]
	private List<UISprite> m_ReaperPlayerFlag;

	[Token(Token = "0x400D79B")]
	[FieldOffset(Offset = "0x1D0")]
	private List<float> m_quadrantLength;

	[Token(Token = "0x400D79C")]
	[FieldOffset(Offset = "0x1D4")]
	private List<Vector3> m_quadrantPoint;

	[Token(Token = "0x400D79D")]
	[FieldOffset(Offset = "0x1D8")]
	private List<GameMissionPlayerRangeObject> m_PlayerRangeObjects;

	[Token(Token = "0x400D79E")]
	[FieldOffset(Offset = "0x1DC")]
	private List<GameObject> m_DetectiveMarkPoints;

	[Token(Token = "0x400D79F")]
	[FieldOffset(Offset = "0x1E0")]
	private Dictionary<uint, GameObject> m_DetectiveMarkPointsByTBD;

	[Token(Token = "0x400D7A0")]
	[FieldOffset(Offset = "0x1E4")]
	private Dictionary<uint, float> m_DetectiveMarkPointsDisappearTime;

	[Token(Token = "0x400D7A1")]
	[FieldOffset(Offset = "0x1E8")]
	private Dictionary<uint, GameObject> m_DetectiveEffectByTBD;

	[Token(Token = "0x400D7A2")]
	[FieldOffset(Offset = "0x1EC")]
	private Dictionary<uint, float> m_DetectiveEffectDisappearTime;

	[Token(Token = "0x400D7A3")]
	[FieldOffset(Offset = "0x1F0")]
	private List<GameObject> m_PointObjPool;

	[Token(Token = "0x400D7A4")]
	[FieldOffset(Offset = "0x1F4")]
	private List<GameObject> m_DetectiveEffectObjPool;

	[Token(Token = "0x400D7A5")]
	[FieldOffset(Offset = "0x1F8")]
	private UITexture m_SafeZoneTargetBg;

	[Token(Token = "0x400D7A6")]
	[FieldOffset(Offset = "0x1FC")]
	private List<uint> m_TmpList;

	[Token(Token = "0x400D7A7")]
	[FieldOffset(Offset = "0x200")]
	private JPPGAJBAAKK m_SceneEditGame;

	[Token(Token = "0x400D7A8")]
	[FieldOffset(Offset = "0x204")]
	private Color m_WSItemHideColor;

	[Token(Token = "0x400D7A9")]
	[FieldOffset(Offset = "0x214")]
	private Dictionary<int, UISprite> m_WorskShopItemIconMap;

	[Token(Token = "0x400D7AA")]
	[FieldOffset(Offset = "0x218")]
	private Queue<UISprite> m_WorskShopItemIconCache;

	[Token(Token = "0x400D7AB")]
	[FieldOffset(Offset = "0x21C")]
	private UISprite m_CheckPointIcon;

	[Token(Token = "0x400D7AC")]
	[FieldOffset(Offset = "0x220")]
	private uint m_AroundEnemyDelayCall;

	[Token(Token = "0x400D7AD")]
	[FieldOffset(Offset = "0x224")]
	private uint m_CandyHotZoneDelayCallID;

	[Token(Token = "0x400D7AE")]
	[FieldOffset(Offset = "0x228")]
	private List<GameObject> m_DebugSafeZoneList;

	[Token(Token = "0x400D7AF")]
	[FieldOffset(Offset = "0x22C")]
	private int m_DebugSafeZoneCount;

	[Token(Token = "0x400D7B0")]
	[FieldOffset(Offset = "0x230")]
	private UILabel m_DebugSafeZoneCountLabel;

	[Token(Token = "0x400D7B1")]
	private const int HippoMapID = 22;

	[Token(Token = "0x400D7B2")]
	[FieldOffset(Offset = "0x234")]
	private Dictionary<int, GameObject> m_TrapIconMap;

	[Token(Token = "0x17001089")]
	private Texture2D m_WSMapTexture
	{
		[Token(Token = "0x600BC1B")]
		[Address(RVA = "0x1244FDC", Offset = "0x1244FDC", VA = "0x1244FDC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600BC1C")]
		[Address(RVA = "0x12450B4", Offset = "0x12450B4", VA = "0x12450B4")]
		set
		{
		}
	}

	[Token(Token = "0x1700108A")]
	private int[,] m_WSMapArray
	{
		[Token(Token = "0x600BC1D")]
		[Address(RVA = "0x124518C", Offset = "0x124518C", VA = "0x124518C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600BC1E")]
		[Address(RVA = "0x1245264", Offset = "0x1245264", VA = "0x1245264")]
		set
		{
		}
	}

	[Token(Token = "0x1700108B")]
	private float m_CurMarkScaleRatio
	{
		[Token(Token = "0x600BCBB")]
		[Address(RVA = "0x126C674", Offset = "0x126C674", VA = "0x126C674")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600BC10")]
	[Address(RVA = "0x123B6CC", Offset = "0x123B6CC", VA = "0x123B6CC")]
	public UIMapContentController()
	{
	}

	[Token(Token = "0x600BC11")]
	[Address(RVA = "0x123C29C", Offset = "0x123C29C", VA = "0x123C29C")]
	public void SetRot(float rotation)
	{
	}

	[Token(Token = "0x600BC12")]
	[Address(RVA = "0x123C300", Offset = "0x123C300", VA = "0x123C300")]
	public void SetPeopleRot(float rotation)
	{
	}

	[Token(Token = "0x600BC13")]
	[Address(RVA = "0x123C364", Offset = "0x123C364", VA = "0x123C364")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BC14")]
	[Address(RVA = "0x123C408", Offset = "0x123C408", VA = "0x123C408", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BC15")]
	[Address(RVA = "0x1241610", Offset = "0x1241610", VA = "0x1241610")]
	private bool TryGetIntersectPoint(Vector3 a, Vector3 b, Vector3 c, Vector3 d, out Vector3 intersectPos)
	{
		return default(bool);
	}

	[Token(Token = "0x600BC16")]
	[Address(RVA = "0x1241F50", Offset = "0x1241F50", VA = "0x1241F50", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BC17")]
	[Address(RVA = "0x1243F74", Offset = "0x1243F74", VA = "0x1243F74")]
	private void InitSpritesForSpecialMode()
	{
	}

	[Token(Token = "0x600BC18")]
	[Address(RVA = "0x12446B8", Offset = "0x12446B8", VA = "0x12446B8")]
	public UIWidget GetMapBgWidget()
	{
		return null;
	}

	[Token(Token = "0x600BC19")]
	[Address(RVA = "0x123C764", Offset = "0x123C764", VA = "0x123C764")]
	private void InitMapTexture()
	{
	}

	[Token(Token = "0x600BC1A")]
	[Address(RVA = "0x1244DAC", Offset = "0x1244DAC", VA = "0x1244DAC")]
	private void OnUpdateMapTexture(object[] data)
	{
	}

	[Token(Token = "0x600BC1F")]
	[Address(RVA = "0x124533C", Offset = "0x124533C", VA = "0x124533C")]
	private void AddWorkShopItem(object[] data)
	{
	}

	[Token(Token = "0x600BC20")]
	[Address(RVA = "0x1246758", Offset = "0x1246758", VA = "0x1246758")]
	private void RemoveWorkShopItem(object[] data)
	{
	}

	[Token(Token = "0x600BC21")]
	[Address(RVA = "0x1246C44", Offset = "0x1246C44", VA = "0x1246C44")]
	private void AddScaleWorkShopItem(object[] data)
	{
	}

	[Token(Token = "0x600BC22")]
	[Address(RVA = "0x1245980", Offset = "0x1245980", VA = "0x1245980")]
	private void RefreshWorkShopMap(List<Vector2> coors, bool Add)
	{
	}

	[Token(Token = "0x600BC23")]
	[Address(RVA = "0x1246F70", Offset = "0x1246F70", VA = "0x1246F70")]
	private void ResetWorkShopMap()
	{
	}

	[Token(Token = "0x600BC24")]
	[Address(RVA = "0x1240A4C", Offset = "0x1240A4C", VA = "0x1240A4C")]
	private void OnGameLoadWorkShopScene(object[] data)
	{
	}

	[Token(Token = "0x600BC25")]
	[Address(RVA = "0x12479E0", Offset = "0x12479E0", VA = "0x12479E0")]
	private void OnWorkShopDynamicObjChange(object[] data)
	{
	}

	[Token(Token = "0x600BC26")]
	[Address(RVA = "0x1247BBC", Offset = "0x1247BBC", VA = "0x1247BBC")]
	private void OnWorkShopDynamicObjIconChange(object[] data)
	{
	}

	[Token(Token = "0x600BC27")]
	[Address(RVA = "0x1247610", Offset = "0x1247610", VA = "0x1247610")]
	private UISprite InstantWorkshopIconItem(uint itemID, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x600BC28")]
	[Address(RVA = "0x1247E6C", Offset = "0x1247E6C", VA = "0x1247E6C")]
	private void OnCheckPointChange(object[] data)
	{
	}

	[Token(Token = "0x600BC29")]
	[Address(RVA = "0x12483E4", Offset = "0x12483E4", VA = "0x12483E4")]
	private void OnWorkShopSceneRefresh(object[] data)
	{
	}

	[Token(Token = "0x600BC2A")]
	[Address(RVA = "0x12462C8", Offset = "0x12462C8", VA = "0x12462C8")]
	private void AddWorkshopMapIcon(int idx, Vector3 pos, ResourceID iconRes, uint itemID)
	{
	}

	[Token(Token = "0x600BC2B")]
	[Address(RVA = "0x1246AB4", Offset = "0x1246AB4", VA = "0x1246AB4")]
	private void RemoveWorkshopMapIcon(int idx)
	{
	}

	[Token(Token = "0x600BC2C")]
	[Address(RVA = "0x12407CC", Offset = "0x12407CC", VA = "0x12407CC")]
	private void SetWorkShopBg()
	{
	}

	[Token(Token = "0x600BC2D")]
	[Address(RVA = "0x12484C4", Offset = "0x12484C4", VA = "0x12484C4")]
	private void OnMapOffsetUpdate(object[] data)
	{
	}

	[Token(Token = "0x600BC2E")]
	[Address(RVA = "0x123CDD8", Offset = "0x123CDD8", VA = "0x123CDD8")]
	protected void RegisterEvents()
	{
	}

	[Token(Token = "0x600BC2F")]
	[Address(RVA = "0x12422A0", Offset = "0x12422A0", VA = "0x12422A0")]
	protected void UnRegisterEvents()
	{
	}

	[Token(Token = "0x600BC30")]
	[Address(RVA = "0x123EE2C", Offset = "0x123EE2C", VA = "0x123EE2C")]
	private void InitUIParams()
	{
	}

	[Token(Token = "0x600BC31")]
	[Address(RVA = "0x123F030", Offset = "0x123F030", VA = "0x123F030")]
	private void InitUIElements()
	{
	}

	[Token(Token = "0x600BC32")]
	[Address(RVA = "0x1248708", Offset = "0x1248708", VA = "0x1248708")]
	public void InitObEventController()
	{
	}

	[Token(Token = "0x600BC33")]
	[Address(RVA = "0x12488A4", Offset = "0x12488A4", VA = "0x12488A4")]
	public bool IsEventIcon(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x600BC34")]
	[Address(RVA = "0x12444F8", Offset = "0x12444F8", VA = "0x12444F8")]
	private bool ShowAllGameZone()
	{
		return default(bool);
	}

	[Token(Token = "0x600BC35")]
	[Address(RVA = "0x124852C", Offset = "0x124852C", VA = "0x124852C")]
	private void RefreshPlayerArrow()
	{
	}

	[Token(Token = "0x600BC36")]
	[Address(RVA = "0x123A69C", Offset = "0x123A69C", VA = "0x123A69C")]
	public void RefreshUIGroup()
	{
	}

	[Token(Token = "0x600BC37")]
	[Address(RVA = "0x12489B4", Offset = "0x12489B4", VA = "0x12489B4")]
	public bool ModeRelatedMinimapScale()
	{
		return default(bool);
	}

	[Token(Token = "0x600BC38")]
	[Address(RVA = "0x1248E44", Offset = "0x1248E44", VA = "0x1248E44")]
	public void SetMinimapSpriteScale(float scale, bool canDynamicScale)
	{
	}

	[Token(Token = "0x600BC39")]
	[Address(RVA = "0x1249C94", Offset = "0x1249C94", VA = "0x1249C94")]
	public void InitBountyScanner([Optional] UIPanel panel)
	{
	}

	[Token(Token = "0x600BC3A")]
	[Address(RVA = "0x1249FA4", Offset = "0x1249FA4", VA = "0x1249FA4")]
	public void UpdateLocalMark(Vector3 p, uint posType)
	{
	}

	[Token(Token = "0x600BC3B")]
	[Address(RVA = "0x124B0B4", Offset = "0x124B0B4", VA = "0x124B0B4")]
	public void RemoveMarkOnMap()
	{
	}

	[Token(Token = "0x600BC3C")]
	[Address(RVA = "0x124B444", Offset = "0x124B444", VA = "0x124B444")]
	public void OnPlayerHPChangedBigMap(object[] data)
	{
	}

	[Token(Token = "0x600BC3D")]
	[Address(RVA = "0x124B8DC", Offset = "0x124B8DC", VA = "0x124B8DC")]
	private void OnPlayerDead(object[] data)
	{
	}

	[Token(Token = "0x600BC3E")]
	[Address(RVA = "0x124CD54", Offset = "0x124CD54", VA = "0x124CD54")]
	public void OnPlayerQuit(object[] data)
	{
	}

	[Token(Token = "0x600BC3F")]
	[Address(RVA = "0x124D0DC", Offset = "0x124D0DC", VA = "0x124D0DC")]
	private void OnInfoBoxDataNtf(object[] data)
	{
	}

	[Token(Token = "0x600BC40")]
	[Address(RVA = "0x124D338", Offset = "0x124D338", VA = "0x124D338")]
	private void OnInfoBoxValid(object[] data)
	{
	}

	[Token(Token = "0x600BC41")]
	[Address(RVA = "0x124D79C", Offset = "0x124D79C", VA = "0x124D79C")]
	public void SyncTeamateState(object[] data)
	{
	}

	[Token(Token = "0x600BC42")]
	[Address(RVA = "0x1250328", Offset = "0x1250328", VA = "0x1250328")]
	public Vector3 ChangePosToLocalPos(Vector3 pos1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600BC43")]
	[Address(RVA = "0x124E804", Offset = "0x124E804", VA = "0x124E804")]
	public void CheckTeamInMap(TeammateGameObject go, Vector3 teammatepos, int index)
	{
	}

	[Token(Token = "0x600BC44")]
	[Address(RVA = "0x125046C", Offset = "0x125046C", VA = "0x125046C")]
	public bool CheckHasJiao(Vector3 pos1, Vector3 pos2, Vector3 pos3, Vector3 pos4, out Vector3 jiaopos)
	{
		return default(bool);
	}

	[Token(Token = "0x600BC45")]
	[Address(RVA = "0x1250738", Offset = "0x1250738", VA = "0x1250738")]
	public void PlayTeammateQuickChatEffect(uint playerID)
	{
	}

	[Token(Token = "0x600BC46")]
	[Address(RVA = "0x1250910", Offset = "0x1250910", VA = "0x1250910")]
	public void OnLocalPlayerLastVehicleChange(object[] param)
	{
	}

	[Token(Token = "0x600BC47")]
	[Address(RVA = "0x1250AA4", Offset = "0x1250AA4", VA = "0x1250AA4")]
	private void Update()
	{
	}

	[Token(Token = "0x600BC48")]
	[Address(RVA = "0x1253320", Offset = "0x1253320", VA = "0x1253320")]
	private void UpdateTeamatePosition()
	{
	}

	[Token(Token = "0x600BC49")]
	[Address(RVA = "0x1254E3C", Offset = "0x1254E3C", VA = "0x1254E3C")]
	private void UpdateEnermyPointPosition()
	{
	}

	[Token(Token = "0x600BC4A")]
	[Address(RVA = "0x1255554", Offset = "0x1255554", VA = "0x1255554")]
	private void UpdateDeliverySkillEnemyPointPosition()
	{
	}

	[Token(Token = "0x600BC4B")]
	[Address(RVA = "0x1255BF4", Offset = "0x1255BF4", VA = "0x1255BF4")]
	private void UpdateMaxHypePlayerPos()
	{
	}

	[Token(Token = "0x600BC4C")]
	[Address(RVA = "0x1256234", Offset = "0x1256234", VA = "0x1256234")]
	private void UpdateRevengeMarkPos()
	{
	}

	[Token(Token = "0x600BC4D")]
	[Address(RVA = "0x1256A20", Offset = "0x1256A20", VA = "0x1256A20")]
	private void UpdateDeathMatchKillerKingPos()
	{
	}

	[Token(Token = "0x600BC4E")]
	[Address(RVA = "0x125272C", Offset = "0x125272C", VA = "0x125272C")]
	private void UpdatePlayerStatus()
	{
	}

	[Token(Token = "0x600BC4F")]
	[Address(RVA = "0x1252F60", Offset = "0x1252F60", VA = "0x1252F60")]
	private void UpdateGuideToMark()
	{
	}

	[Token(Token = "0x600BC50")]
	[Address(RVA = "0x124A9F4", Offset = "0x124A9F4", VA = "0x124A9F4")]
	private void UpdateBigMapGuideToMark()
	{
	}

	[Token(Token = "0x600BC51")]
	[Address(RVA = "0x125306C", Offset = "0x125306C", VA = "0x125306C")]
	private void UpdateWorkShopMapIcon()
	{
	}

	[Token(Token = "0x600BC52")]
	[Address(RVA = "0x1258A60", Offset = "0x1258A60", VA = "0x1258A60")]
	public void OnObservePlayerBigmap(object[] data)
	{
	}

	[Token(Token = "0x600BC53")]
	[Address(RVA = "0x1259824", Offset = "0x1259824", VA = "0x1259824")]
	public void OnObservePlayerMinimap(object[] data)
	{
	}

	[Token(Token = "0x600BC54")]
	[Address(RVA = "0x123B480", Offset = "0x123B480", VA = "0x123B480")]
	public void OnObserverTargetChange()
	{
	}

	[Token(Token = "0x600BC55")]
	[Address(RVA = "0x125A608", Offset = "0x125A608", VA = "0x125A608")]
	public void UpdateMapMarkByIndex(object[] param)
	{
	}

	[Token(Token = "0x600BC56")]
	[Address(RVA = "0x125A9A8", Offset = "0x125A9A8", VA = "0x125A9A8")]
	public void RemoveMapMarkByIndex(object[] param)
	{
	}

	[Token(Token = "0x600BC57")]
	[Address(RVA = "0x125AB34", Offset = "0x125AB34", VA = "0x125AB34")]
	private void OnAddDetector(object[] data)
	{
	}

	[Token(Token = "0x600BC58")]
	[Address(RVA = "0x125AC50", Offset = "0x125AC50", VA = "0x125AC50")]
	private void CreateDetector(LFHDEBBIOPO d)
	{
	}

	[Token(Token = "0x600BC59")]
	[Address(RVA = "0x1241454", Offset = "0x1241454", VA = "0x1241454")]
	private void CreateAirLine()
	{
	}

	[Token(Token = "0x600BC5A")]
	[Address(RVA = "0x125AEFC", Offset = "0x125AEFC", VA = "0x125AEFC")]
	public void BigMapCenterPlayerPos()
	{
	}

	[Token(Token = "0x600BC5B")]
	[Address(RVA = "0x125B448", Offset = "0x125B448", VA = "0x125B448")]
	public void BigMapCenterSafeZone()
	{
	}

	[Token(Token = "0x600BC5C")]
	[Address(RVA = "0x125E1B4", Offset = "0x125E1B4", VA = "0x125E1B4")]
	public float GetCurrentScaleRatio()
	{
		return default(float);
	}

	[Token(Token = "0x600BC5D")]
	[Address(RVA = "0x1243F00", Offset = "0x1243F00", VA = "0x1243F00")]
	private void DestroyDetector()
	{
	}

	[Token(Token = "0x600BC5E")]
	[Address(RVA = "0x1257888", Offset = "0x1257888", VA = "0x1257888")]
	public float GetRealRatio()
	{
		return default(float);
	}

	[Token(Token = "0x600BC5F")]
	[Address(RVA = "0x125E20C", Offset = "0x125E20C", VA = "0x125E20C")]
	public void UpdateDetector(float angle)
	{
	}

	[Token(Token = "0x600BC60")]
	[Address(RVA = "0x125E2E8", Offset = "0x125E2E8", VA = "0x125E2E8")]
	public void UpdateAirLine()
	{
	}

	[Token(Token = "0x600BC61")]
	[Address(RVA = "0x125E354", Offset = "0x125E354", VA = "0x125E354", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600BC62")]
	[Address(RVA = "0x125E3C8", Offset = "0x125E3C8", VA = "0x125E3C8", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600BC63")]
	[Address(RVA = "0x125E42C", Offset = "0x125E42C", VA = "0x125E42C")]
	public void OnTreasureMarked(object[] param)
	{
	}

	[Token(Token = "0x600BC64")]
	[Address(RVA = "0x125E7D4", Offset = "0x125E7D4", VA = "0x125E7D4")]
	private void OnTreasureContainerDelete(object[] param)
	{
	}

	[Token(Token = "0x600BC65")]
	[Address(RVA = "0x125E9DC", Offset = "0x125E9DC", VA = "0x125E9DC")]
	public void OnZombieSync(GEvent data)
	{
	}

	[Token(Token = "0x600BC66")]
	[Address(RVA = "0x125F1C4", Offset = "0x125F1C4", VA = "0x125F1C4")]
	private void AddPumpkinPos(uint id, Vector3 pos)
	{
	}

	[Token(Token = "0x600BC67")]
	[Address(RVA = "0x125F68C", Offset = "0x125F68C", VA = "0x125F68C")]
	public void OnPumpkinPosSync(object[] data)
	{
	}

	[Token(Token = "0x600BC68")]
	[Address(RVA = "0x125FA64", Offset = "0x125FA64", VA = "0x125FA64")]
	public void OnPumpkinPosListSync(object[] data)
	{
	}

	[Token(Token = "0x600BC69")]
	[Address(RVA = "0x125FCB0", Offset = "0x125FCB0", VA = "0x125FCB0")]
	public void OnPlayerPumpkinPosListSync(object[] data)
	{
	}

	[Token(Token = "0x600BC6A")]
	[Address(RVA = "0x1260F7C", Offset = "0x1260F7C", VA = "0x1260F7C")]
	private void OnPlayerGuildWarPropChanged(object[] data)
	{
	}

	[Token(Token = "0x600BC6B")]
	[Address(RVA = "0x1261458", Offset = "0x1261458", VA = "0x1261458")]
	public void OnCarePackageSync(object[] data)
	{
	}

	[Token(Token = "0x600BC6C")]
	[Address(RVA = "0x126222C", Offset = "0x126222C", VA = "0x126222C")]
	public void OnSyncWereWolvesTask(object[] data)
	{
	}

	[Token(Token = "0x600BC6D")]
	[Address(RVA = "0x1262430", Offset = "0x1262430", VA = "0x1262430")]
	private void SyncWereWolvesEmergencyTask(Dictionary<uint, GameObject> dic, Queue<GameObject> queue, uint objID, Vector3 position, bool needDestroy)
	{
	}

	[Token(Token = "0x600BC6E")]
	[Address(RVA = "0x1262BE8", Offset = "0x1262BE8", VA = "0x1262BE8")]
	private void SyncWereWolvesTask(Dictionary<uint, GameObject> dic, Queue<GameObject> queue, uint objID, Vector3 position, bool needDestroy)
	{
	}

	[Token(Token = "0x600BC6F")]
	[Address(RVA = "0x12633A0", Offset = "0x12633A0", VA = "0x12633A0")]
	public void OnSyncAirDrop(object[] data)
	{
	}

	[Token(Token = "0x600BC70")]
	[Address(RVA = "0x126166C", Offset = "0x126166C", VA = "0x126166C")]
	private void SyncAirDrop(Dictionary<uint, GameObject> iconDict, Queue<GameObject> queue, uint objID, Vector3 position, bool needDestroy, float scale = 1f)
	{
	}

	[Token(Token = "0x600BC71")]
	[Address(RVA = "0x1263538", Offset = "0x1263538", VA = "0x1263538")]
	public void OnCampFireSync(object[] data)
	{
	}

	[Token(Token = "0x600BC72")]
	[Address(RVA = "0x1263CB4", Offset = "0x1263CB4", VA = "0x1263CB4")]
	public void OnAddPlayer(object[] data)
	{
	}

	[Token(Token = "0x600BC73")]
	[Address(RVA = "0x1264BD4", Offset = "0x1264BD4", VA = "0x1264BD4")]
	private bool ShouldShowJKPBuff()
	{
		return default(bool);
	}

	[Token(Token = "0x600BC74")]
	[Address(RVA = "0x1263F70", Offset = "0x1263F70", VA = "0x1263F70")]
	private void RefreshAroundEnemy()
	{
	}

	[Token(Token = "0x600BC75")]
	[Address(RVA = "0x1264D2C", Offset = "0x1264D2C", VA = "0x1264D2C")]
	private void HideAroundEnemyPoint()
	{
	}

	[Token(Token = "0x600BC76")]
	[Address(RVA = "0x1264EF8", Offset = "0x1264EF8", VA = "0x1264EF8")]
	private void OnSwitchObserver(object[] param)
	{
	}

	[Token(Token = "0x600BC77")]
	[Address(RVA = "0x12662A4", Offset = "0x12662A4", VA = "0x12662A4")]
	private void OnSyncEnermyPoint(object[] param)
	{
	}

	[Token(Token = "0x600BC78")]
	[Address(RVA = "0x1267138", Offset = "0x1267138", VA = "0x1267138")]
	private void OnSyncDeliverySkillEnemyPoint(object[] param)
	{
	}

	[Token(Token = "0x600BC79")]
	[Address(RVA = "0x124C938", Offset = "0x124C938", VA = "0x124C938")]
	private void RecycleInvisibleRevengeMark(IHAAMHPPLMG pID)
	{
	}

	[Token(Token = "0x600BC7A")]
	[Address(RVA = "0x12676E0", Offset = "0x12676E0", VA = "0x12676E0")]
	private void OnShowItemGeneratorInfo(object[] data)
	{
	}

	[Token(Token = "0x600BC7B")]
	[Address(RVA = "0x1267C74", Offset = "0x1267C74", VA = "0x1267C74")]
	public void OnUpdateTreasuryState(object[] data)
	{
	}

	[Token(Token = "0x600BC7C")]
	[Address(RVA = "0x1268148", Offset = "0x1268148", VA = "0x1268148")]
	private void OnUpdateGeneratedItemInfo(object[] data)
	{
	}

	[Token(Token = "0x600BC7D")]
	[Address(RVA = "0x126866C", Offset = "0x126866C", VA = "0x126866C")]
	private void OnUpdateRevengeInfo(object[] data)
	{
	}

	[Token(Token = "0x600BC7E")]
	[Address(RVA = "0x124C51C", Offset = "0x124C51C", VA = "0x124C51C")]
	private void RecycleInvisibleMaxHypePlayer(IHAAMHPPLMG pID)
	{
	}

	[Token(Token = "0x600BC7F")]
	[Address(RVA = "0x1268A78", Offset = "0x1268A78", VA = "0x1268A78")]
	private void OnMaxHypeLevelPlayerOccurs(object[] data)
	{
	}

	[Token(Token = "0x600BC80")]
	[Address(RVA = "0x1268FF8", Offset = "0x1268FF8", VA = "0x1268FF8")]
	public void ReleaseMapTexture()
	{
	}

	[Token(Token = "0x600BC81")]
	[Address(RVA = "0x126919C", Offset = "0x126919C", VA = "0x126919C")]
	private void OnTeleportDoorStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600BC82")]
	[Address(RVA = "0x1269FC8", Offset = "0x1269FC8", VA = "0x1269FC8")]
	public void SetTeleportDoorVisible(EFNHBHILCNJ type, bool v)
	{
	}

	[Token(Token = "0x600BC83")]
	[Address(RVA = "0x126A228", Offset = "0x126A228", VA = "0x126A228")]
	public bool HasMaxHypePlayer(IHAAMHPPLMG pId)
	{
		return default(bool);
	}

	[Token(Token = "0x600BC84")]
	[Address(RVA = "0x126A340", Offset = "0x126A340", VA = "0x126A340")]
	public void ShowMaxHypePlayerShooting(IHAAMHPPLMG pId, float angle)
	{
	}

	[Token(Token = "0x600BC85")]
	[Address(RVA = "0x126A724", Offset = "0x126A724", VA = "0x126A724")]
	public void OnShowHotzoneOnMap(object[] param)
	{
	}

	[Token(Token = "0x600BC86")]
	[Address(RVA = "0x126AD34", Offset = "0x126AD34", VA = "0x126AD34")]
	public void OnHideHotzoneOnMap(object[] param)
	{
	}

	[Token(Token = "0x600BC87")]
	[Address(RVA = "0x126AEB0", Offset = "0x126AEB0", VA = "0x126AEB0")]
	public bool HasLevelHotzoneShowing()
	{
		return default(bool);
	}

	[Token(Token = "0x600BC88")]
	[Address(RVA = "0x126AF80", Offset = "0x126AF80", VA = "0x126AF80")]
	private void OnEnergyStoneBoxStateChange(object[] param)
	{
	}

	[Token(Token = "0x600BC89")]
	[Address(RVA = "0x126B850", Offset = "0x126B850", VA = "0x126B850")]
	public void OnShowCandyHotzoneOnMap(object[] param)
	{
	}

	[Token(Token = "0x600BC8A")]
	[Address(RVA = "0x126BBD8", Offset = "0x126BBD8", VA = "0x126BBD8")]
	public Vector3 GetMapPanelScale()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600BC8B")]
	[Address(RVA = "0x126BC70", Offset = "0x126BC70", VA = "0x126BC70")]
	public Vector3 GetMapPanelLocalPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600BC8C")]
	[Address(RVA = "0x126BD08", Offset = "0x126BD08", VA = "0x126BD08")]
	public Transform GetMapPanelTransform()
	{
		return null;
	}

	[Token(Token = "0x600BC8D")]
	[Address(RVA = "0x126BD94", Offset = "0x126BD94", VA = "0x126BD94")]
	public Dictionary<IHAAMHPPLMG, TeammateGameObject> GetTeammatesMap()
	{
		return null;
	}

	[Token(Token = "0x600BC8E")]
	[Address(RVA = "0x124A824", Offset = "0x124A824", VA = "0x124A824")]
	private float GetOrCreateMarkScale(IHAAMHPPLMG playerID)
	{
		return default(float);
	}

	[Token(Token = "0x600BC8F")]
	[Address(RVA = "0x126BDEC", Offset = "0x126BDEC", VA = "0x126BDEC")]
	private void OnTeamParachuteModeChange(object[] param)
	{
	}

	[Token(Token = "0x600BC90")]
	[Address(RVA = "0x125720C", Offset = "0x125720C", VA = "0x125720C")]
	private void UpdateToxicZone()
	{
	}

	[Token(Token = "0x600BC91")]
	[Address(RVA = "0x126C72C", Offset = "0x126C72C", VA = "0x126C72C")]
	private void OnShowToxicZoneOnMap(object[] param)
	{
	}

	[Token(Token = "0x600BC92")]
	[Address(RVA = "0x126C794", Offset = "0x126C794", VA = "0x126C794")]
	private void OnSyncPetFindMushroomMark(object[] param)
	{
	}

	[Token(Token = "0x600BC93")]
	[Address(RVA = "0x126CAF0", Offset = "0x126CAF0", VA = "0x126CAF0")]
	private void SetMushRoomHide()
	{
	}

	[Token(Token = "0x600BC94")]
	[Address(RVA = "0x126CB80", Offset = "0x126CB80", VA = "0x126CB80")]
	private void OnSyncPetFindMushroomRemove(object[] param)
	{
	}

	[Token(Token = "0x600BC95")]
	[Address(RVA = "0x126CEE4", Offset = "0x126CEE4", VA = "0x126CEE4")]
	private void OnShowRandomCenter(object[] param)
	{
	}

	[Token(Token = "0x600BC96")]
	[Address(RVA = "0x126D148", Offset = "0x126D148", VA = "0x126D148")]
	private void OnSyncCSGameZone(object[] param)
	{
	}

	[Token(Token = "0x600BC97")]
	[Address(RVA = "0x126D2FC", Offset = "0x126D2FC", VA = "0x126D2FC")]
	private void OnShowWarningZoneOnMap(object[] param)
	{
	}

	[Token(Token = "0x600BC98")]
	[Address(RVA = "0x126D710", Offset = "0x126D710", VA = "0x126D710")]
	public void ShowIconOnMap(EIconType iconType, bool show)
	{
	}

	[Token(Token = "0x600BC99")]
	[Address(RVA = "0x126D898", Offset = "0x126D898", VA = "0x126D898")]
	private void OnShowRevivePointOnMap(object[] param)
	{
	}

	[Token(Token = "0x600BC9A")]
	[Address(RVA = "0x126E0D0", Offset = "0x126E0D0", VA = "0x126E0D0")]
	private void OnShowIngameShopOnMap(object[] param)
	{
	}

	[Token(Token = "0x600BC9B")]
	[Address(RVA = "0x126E7B8", Offset = "0x126E7B8", VA = "0x126E7B8")]
	private void OnRevivePointStateChanged(object[] param)
	{
	}

	[Token(Token = "0x600BC9C")]
	[Address(RVA = "0x126E934", Offset = "0x126E934", VA = "0x126E934")]
	private void OnRevivePointTimeChanged(object[] param)
	{
	}

	[Token(Token = "0x600BC9D")]
	[Address(RVA = "0x126EAB8", Offset = "0x126EAB8", VA = "0x126EAB8")]
	private void OnBombZoneChanged(object[] param)
	{
	}

	[Token(Token = "0x600BC9E")]
	[Address(RVA = "0x126EFFC", Offset = "0x126EFFC", VA = "0x126EFFC")]
	private void OnControlPointChanged(object[] data)
	{
	}

	[Token(Token = "0x600BC9F")]
	[Address(RVA = "0x124478C", Offset = "0x124478C", VA = "0x124478C")]
	private string GetMiniMapName(uint map_id, string lang)
	{
		return null;
	}

	[Token(Token = "0x600BCA0")]
	[Address(RVA = "0x126F6A8", Offset = "0x126F6A8", VA = "0x126F6A8")]
	private void OnBombPickupGet(object[] data)
	{
	}

	[Token(Token = "0x600BCA1")]
	[Address(RVA = "0x126F938", Offset = "0x126F938", VA = "0x126F938")]
	private void OnBombPickupDrop(object[] data)
	{
	}

	[Token(Token = "0x600BCA2")]
	[Address(RVA = "0x126FC90", Offset = "0x126FC90", VA = "0x126FC90")]
	private void OnBombRoundChange(object[] data)
	{
	}

	[Token(Token = "0x600BCA3")]
	[Address(RVA = "0x126FDAC", Offset = "0x126FDAC", VA = "0x126FDAC")]
	private void OnBombSettled(object[] data)
	{
	}

	[Token(Token = "0x600BCA4")]
	[Address(RVA = "0x1270208", Offset = "0x1270208", VA = "0x1270208")]
	private void OnPlayerODFactionChanged(object[] data)
	{
	}

	[Token(Token = "0x600BCA5")]
	[Address(RVA = "0x1270428", Offset = "0x1270428", VA = "0x1270428")]
	private void OnZeppelinPosUpdate(object[] data)
	{
	}

	[Token(Token = "0x600BCA6")]
	[Address(RVA = "0x1270654", Offset = "0x1270654", VA = "0x1270654")]
	private void OnEscortVehiclePosUpdate(object[] data)
	{
	}

	[Token(Token = "0x600BCA7")]
	[Address(RVA = "0x1270864", Offset = "0x1270864", VA = "0x1270864")]
	private void OnZeppelinSpawnNextPosition(object[] data)
	{
	}

	[Token(Token = "0x600BCA8")]
	[Address(RVA = "0x12578F4", Offset = "0x12578F4", VA = "0x12578F4")]
	private void UpdateZepplineMoveDirection()
	{
	}

	[Token(Token = "0x600BCA9")]
	[Address(RVA = "0x1270AEC", Offset = "0x1270AEC", VA = "0x1270AEC")]
	private void OnShowBountyContract(object[] data)
	{
	}

	[Token(Token = "0x600BCAA")]
	[Address(RVA = "0x1270D9C", Offset = "0x1270D9C", VA = "0x1270D9C")]
	private void OnUavCreate(object[] data)
	{
	}

	[Token(Token = "0x600BCAB")]
	[Address(RVA = "0x127113C", Offset = "0x127113C", VA = "0x127113C")]
	private void OnUavDestroy(object[] data)
	{
	}

	[Token(Token = "0x600BCAC")]
	[Address(RVA = "0x12581AC", Offset = "0x12581AC", VA = "0x12581AC")]
	private void UpdateMissionWantedPlayerPosition(float deltaTime)
	{
	}

	[Token(Token = "0x600BCAD")]
	[Address(RVA = "0x1271388", Offset = "0x1271388", VA = "0x1271388")]
	private void OnShowPlayerRange(object[] data)
	{
	}

	[Token(Token = "0x600BCAE")]
	[Address(RVA = "0x1271850", Offset = "0x1271850", VA = "0x1271850")]
	private void OnRoleChange(object[] param)
	{
	}

	[Token(Token = "0x600BCAF")]
	[Address(RVA = "0x1271994", Offset = "0x1271994", VA = "0x1271994")]
	private void OnDebugSafeZone(object[] param)
	{
	}

	[Token(Token = "0x600BCB0")]
	[Address(RVA = "0x1258384", Offset = "0x1258384", VA = "0x1258384")]
	public void UpdateMinimapGuideToMark()
	{
	}

	[Token(Token = "0x600BCB1")]
	[Address(RVA = "0x127278C", Offset = "0x127278C", VA = "0x127278C")]
	public void OnPlayerHPChangedMinimap(IHAAMHPPLMG pId)
	{
	}

	[Token(Token = "0x600BCB2")]
	[Address(RVA = "0x123AAE8", Offset = "0x123AAE8", VA = "0x123AAE8")]
	public void SetMapMaskSupplement()
	{
	}

	[Token(Token = "0x600BCB3")]
	[Address(RVA = "0x1272C9C", Offset = "0x1272C9C", VA = "0x1272C9C")]
	public void EnableBigMap(EBigMapType bigMapType = EBigMapType.MapTpyeNormal)
	{
	}

	[Token(Token = "0x600BCB4")]
	[Address(RVA = "0x1273158", Offset = "0x1273158", VA = "0x1273158")]
	private void UpdateTeammates()
	{
	}

	[Token(Token = "0x600BCB5")]
	[Address(RVA = "0x1249904", Offset = "0x1249904", VA = "0x1249904")]
	public void UpdateTeammates(float scale)
	{
	}

	[Token(Token = "0x600BCB6")]
	[Address(RVA = "0x1272DF8", Offset = "0x1272DF8", VA = "0x1272DF8")]
	private void UpdateEnerPoint()
	{
	}

	[Token(Token = "0x600BCB7")]
	[Address(RVA = "0x12731C4", Offset = "0x12731C4", VA = "0x12731C4")]
	private void UpdateDeliverySkillPoint()
	{
	}

	[Token(Token = "0x600BCB8")]
	[Address(RVA = "0x1273370", Offset = "0x1273370", VA = "0x1273370")]
	public void InitBigmapParams(Vector3 scale, float clipWidth, float clipHeight)
	{
	}

	[Token(Token = "0x600BCB9")]
	[Address(RVA = "0x1273530", Offset = "0x1273530", VA = "0x1273530")]
	public void InitSidemapParams(Vector3 scale, float clipWidth, float clipHeight)
	{
	}

	[Token(Token = "0x600BCBA")]
	[Address(RVA = "0x12736F0", Offset = "0x12736F0", VA = "0x12736F0")]
	public float GetBigmapCurrentScaleRatio()
	{
		return default(float);
	}

	[Token(Token = "0x600BCBC")]
	[Address(RVA = "0x12594F0", Offset = "0x12594F0", VA = "0x12594F0")]
	public void RemoveTeamMapMark(IHAAMHPPLMG playerID, int teamIndex)
	{
	}

	[Token(Token = "0x600BCBD")]
	[Address(RVA = "0x1273748", Offset = "0x1273748", VA = "0x1273748")]
	public void UpdateTeamMapMark(uint playerIDInt, int teamIndex, uint posType, bool hasMark, short posX, short posY)
	{
	}

	[Token(Token = "0x600BCBE")]
	[Address(RVA = "0x1274314", Offset = "0x1274314", VA = "0x1274314")]
	private void ShowFateRandomTeamZone(object[] param)
	{
	}

	[Token(Token = "0x600BCBF")]
	[Address(RVA = "0x1274880", Offset = "0x1274880", VA = "0x1274880")]
	private void OnFateRandomStartFight(object[] param)
	{
	}

	[Token(Token = "0x600BCC0")]
	[Address(RVA = "0x12749F0", Offset = "0x12749F0", VA = "0x12749F0")]
	private void OnUGCSupplyBoxTriggerEnable(object[] param)
	{
	}

	[Token(Token = "0x600BCC1")]
	[Address(RVA = "0x12752D8", Offset = "0x12752D8", VA = "0x12752D8")]
	private void OnUGCSupplyBoxTriggeModelChanged(object[] param)
	{
	}

	[Token(Token = "0x600BCC2")]
	[Address(RVA = "0x1275110", Offset = "0x1275110", VA = "0x1275110")]
	private GameObject GetSupplyBoxTriggerObjectFromPool()
	{
		return null;
	}

	[Token(Token = "0x600BCC3")]
	[Address(RVA = "0x1274F44", Offset = "0x1274F44", VA = "0x1274F44")]
	private void RecycleSupplierBoxTriggerObject(string entityID)
	{
	}

	[Token(Token = "0x600BCC4")]
	[Address(RVA = "0x125BB0C", Offset = "0x125BB0C", VA = "0x125BB0C")]
	public void UpdateMapScale(Vector3 targetScale)
	{
	}

	[Token(Token = "0x600BCC5")]
	[Address(RVA = "0x12755A4", Offset = "0x12755A4", VA = "0x12755A4")]
	public void MoveMap(Vector2 deltaPos)
	{
	}

	[Token(Token = "0x600BCC6")]
	[Address(RVA = "0x1275CD8", Offset = "0x1275CD8", VA = "0x1275CD8")]
	private void OnDetectiveMarkEnemy(object[] data)
	{
	}

	[Token(Token = "0x600BCC7")]
	[Address(RVA = "0x1276DB4", Offset = "0x1276DB4", VA = "0x1276DB4")]
	private void OnDetectiveEnemiesByTBD(object[] data)
	{
	}

	[Token(Token = "0x600BCC8")]
	[Address(RVA = "0x12781CC", Offset = "0x12781CC", VA = "0x12781CC")]
	private GameObject PopPointObjFromPool()
	{
		return null;
	}

	[Token(Token = "0x600BCC9")]
	[Address(RVA = "0x1257F78", Offset = "0x1257F78", VA = "0x1257F78")]
	private void RecyclePointObj(uint playerID)
	{
	}

	[Token(Token = "0x600BCCA")]
	[Address(RVA = "0x1278004", Offset = "0x1278004", VA = "0x1278004")]
	private GameObject PopDetectiveEffectObjFromPool()
	{
		return null;
	}

	[Token(Token = "0x600BCCB")]
	[Address(RVA = "0x1257D44", Offset = "0x1257D44", VA = "0x1257D44")]
	private void RecycleDetectiveEffectObj(uint playerID)
	{
	}

	[Token(Token = "0x600BCCC")]
	[Address(RVA = "0x1276A98", Offset = "0x1276A98", VA = "0x1276A98")]
	private void RefreshDetectiveEffect()
	{
	}

	[Token(Token = "0x600BCCD")]
	[Address(RVA = "0x1278394", Offset = "0x1278394", VA = "0x1278394")]
	private void OnControlPhaseChange(object[] data)
	{
	}

	[Token(Token = "0x600BCCE")]
	[Address(RVA = "0x1278AA4", Offset = "0x1278AA4", VA = "0x1278AA4")]
	private void OnShowVoteBody(object[] data)
	{
	}

	[Token(Token = "0x600BCCF")]
	[Address(RVA = "0x1278D68", Offset = "0x1278D68", VA = "0x1278D68")]
	private void OnHideVoteBody(object[] data)
	{
	}

	[Token(Token = "0x600BCD0")]
	[Address(RVA = "0x1278ED8", Offset = "0x1278ED8", VA = "0x1278ED8")]
	private void OnTrapCatchPlayer(object[] param)
	{
	}

	[Token(Token = "0x600BCD2")]
	[Address(RVA = "0x1279444", Offset = "0x1279444", VA = "0x1279444")]
	private void _003CSyncTeamateState_003Em__0()
	{
	}

	[Token(Token = "0x600BCD3")]
	[Address(RVA = "0x12795D0", Offset = "0x12795D0", VA = "0x12795D0")]
	private void _003COnObservePlayerMinimap_003Em__1()
	{
	}

	[Token(Token = "0x600BCD4")]
	[Address(RVA = "0x127975C", Offset = "0x127975C", VA = "0x127975C")]
	private void _003COnShowCandyHotzoneOnMap_003Em__2()
	{
	}

	[Token(Token = "0x600BCD5")]
	[Address(RVA = "0x1279838", Offset = "0x1279838", VA = "0x1279838")]
	private void _003COnPlayerHPChangedMinimap_003Em__3()
	{
	}

	[Token(Token = "0x600BCD6")]
	[Address(RVA = "0x12799C4", Offset = "0x12799C4", VA = "0x12799C4")]
	private void _003CRefreshDetectiveEffect_003Em__4()
	{
	}

	[Token(Token = "0x600BCD7")]
	[Address(RVA = "0x1279A08", Offset = "0x1279A08", VA = "0x1279A08")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BCD8")]
	[Address(RVA = "0x1279A10", Offset = "0x1279A10", VA = "0x1279A10")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
