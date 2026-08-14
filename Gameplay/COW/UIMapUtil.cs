using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D2F")]
public class UIMapUtil
{
	[Token(Token = "0x2002D30")]
	public enum EMapType
	{
		[Token(Token = "0x4011440")]
		Minimap,
		[Token(Token = "0x4011441")]
		Bigmap,
		[Token(Token = "0x4011442")]
		Sidemap
	}

	[Token(Token = "0x2002D31")]
	public enum ESafezoneType
	{
		[Token(Token = "0x4011444")]
		Outer,
		[Token(Token = "0x4011445")]
		Inner,
		[Token(Token = "0x4011446")]
		Next,
		[Token(Token = "0x4011447")]
		InnerDotted
	}

	[Token(Token = "0x401141A")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<int, uint> NamePlateColorDict;

	[Token(Token = "0x401141B")]
	[FieldOffset(Offset = "0x4")]
	public static Dictionary<int, uint> NamePlateColorDict4CS;

	[Token(Token = "0x401141C")]
	[FieldOffset(Offset = "0x8")]
	public static int NAME_PLATE_COLOR_COUNT;

	[Token(Token = "0x401141D")]
	[FieldOffset(Offset = "0xC")]
	public static int NAME_PLATE_COLOR_COUNT_CS;

	[Token(Token = "0x401141E")]
	[FieldOffset(Offset = "0x10")]
	public static Vector4 DEFAULT_MAP_OFFSET;

	[Token(Token = "0x401141F")]
	[FieldOffset(Offset = "0x20")]
	public static Dictionary<uint, Vector4> MAPOFFSET_DICT;

	[Token(Token = "0x4011420")]
	[FieldOffset(Offset = "0x24")]
	private static Vector4 CurrentMapOffset;

	[Token(Token = "0x4011421")]
	public const float ZONE_DIAMETER_MAP = 1024f;

	[Token(Token = "0x4011422")]
	[FieldOffset(Offset = "0x34")]
	public static float OFFSET_SCALE_RATIO_X;

	[Token(Token = "0x4011423")]
	[FieldOffset(Offset = "0x38")]
	public static float MAP_WIDTH;

	[Token(Token = "0x4011424")]
	[FieldOffset(Offset = "0x3C")]
	public static float MAP_DOTTED_WIDTH;

	[Token(Token = "0x4011425")]
	[FieldOffset(Offset = "0x40")]
	public static float OUTER_LINEWIDTH;

	[Token(Token = "0x4011426")]
	[FieldOffset(Offset = "0x44")]
	public static float MAP_OUTZONE_TRANSPARENCY;

	[Token(Token = "0x4011427")]
	[FieldOffset(Offset = "0x48")]
	private static Vector3 m_InnerCenterPos;

	[Token(Token = "0x4011428")]
	[FieldOffset(Offset = "0x54")]
	private static Vector3 m_InnerZoneScale;

	[Token(Token = "0x4011429")]
	[FieldOffset(Offset = "0x60")]
	public static Vector4 OUTER_COLOR_BLUE;

	[Token(Token = "0x401142A")]
	[FieldOffset(Offset = "0x70")]
	public static Vector4 OUTER_COLOR_WHITE;

	[Token(Token = "0x401142B")]
	[FieldOffset(Offset = "0x80")]
	public static Vector4 COLOR_CELL_GAME_CIRCLE_BG;

	[Token(Token = "0x401142C")]
	[FieldOffset(Offset = "0x90")]
	public static Vector4 COLOR_CELL_GAME_CIRCLE_RING;

	[Token(Token = "0x401142D")]
	[FieldOffset(Offset = "0xA0")]
	private static Vector3 m_CachedInnerCenter;

	[Token(Token = "0x401142E")]
	[FieldOffset(Offset = "0xAC")]
	private static float m_CachedInnerRadius;

	[Token(Token = "0x401142F")]
	[FieldOffset(Offset = "0xB0")]
	private static float m_CachedInnerWidth;

	[Token(Token = "0x4011430")]
	[FieldOffset(Offset = "0xB4")]
	private static float m_CachedInnerLength;

	[Token(Token = "0x4011431")]
	[FieldOffset(Offset = "0xB8")]
	private static Vector3 m_CachedInnerForward;

	[Token(Token = "0x4011432")]
	[FieldOffset(Offset = "0xC4")]
	private static Vector3 m_CachedOuterCenter;

	[Token(Token = "0x4011433")]
	[FieldOffset(Offset = "0xD0")]
	private static float m_CachedOuterRadius;

	[Token(Token = "0x4011434")]
	[FieldOffset(Offset = "0xD4")]
	private static float m_CachedOuterWidth;

	[Token(Token = "0x4011435")]
	[FieldOffset(Offset = "0xD8")]
	private static float m_CachedOuterLength;

	[Token(Token = "0x4011436")]
	[FieldOffset(Offset = "0xDC")]
	private static Vector3 m_CachedOuterForward;

	[Token(Token = "0x4011437")]
	[FieldOffset(Offset = "0xE8")]
	private static Vector4 m_CachedOuterColor;

	[Token(Token = "0x4011438")]
	[FieldOffset(Offset = "0xF8")]
	private static Vector4 m_CachedShaderOuterInnerCenter;

	[Token(Token = "0x4011439")]
	[FieldOffset(Offset = "0x108")]
	private static Vector4 m_CachedShaderRadii;

	[Token(Token = "0x401143A")]
	[FieldOffset(Offset = "0x118")]
	private static Vector4 m_CachedShaderLineWidth;

	[Token(Token = "0x401143B")]
	public const string DEFAULT_MAP_RES_NAME = "minimap";

	[Token(Token = "0x401143C")]
	[FieldOffset(Offset = "0x128")]
	public static Dictionary<uint, string> MapBackGroundDict;

	[Token(Token = "0x401143D")]
	[FieldOffset(Offset = "0x12C")]
	private static Dictionary<int, string> m_TeamSpritesDict;

	[Token(Token = "0x401143E")]
	[FieldOffset(Offset = "0x130")]
	private static Dictionary<int, string> m_TeamSpritesDict2;

	[Token(Token = "0x17001363")]
	public static float MIN_OFFSET_X
	{
		[Token(Token = "0x6012E4B")]
		[Address(RVA = "0x2808070", Offset = "0x2808070", VA = "0x2808070")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001364")]
	public static float MAX_OFFSET_X
	{
		[Token(Token = "0x6012E4C")]
		[Address(RVA = "0x2808140", Offset = "0x2808140", VA = "0x2808140")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001365")]
	public static float MIN_OFFSET_Z
	{
		[Token(Token = "0x6012E4D")]
		[Address(RVA = "0x2808210", Offset = "0x2808210", VA = "0x2808210")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001366")]
	public static float MAX_OFFSET_Z
	{
		[Token(Token = "0x6012E4E")]
		[Address(RVA = "0x28082E0", Offset = "0x28082E0", VA = "0x28082E0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001367")]
	private static float ZONE_DIAMETER
	{
		[Token(Token = "0x6012E4F")]
		[Address(RVA = "0x28083B0", Offset = "0x28083B0", VA = "0x28083B0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6012E47")]
	[Address(RVA = "0x2807B38", Offset = "0x2807B38", VA = "0x2807B38")]
	public UIMapUtil()
	{
	}

	[Token(Token = "0x6012E48")]
	[Address(RVA = "0x2807B40", Offset = "0x2807B40", VA = "0x2807B40")]
	public static uint GetNamePlateColor(byte teamId)
	{
		return default(uint);
	}

	[Token(Token = "0x6012E49")]
	[Address(RVA = "0x2807D7C", Offset = "0x2807D7C", VA = "0x2807D7C")]
	public static void InitCurrentMapOffset(uint serverMapID)
	{
	}

	[Token(Token = "0x6012E4A")]
	[Address(RVA = "0x2807EF0", Offset = "0x2807EF0", VA = "0x2807EF0")]
	public static void UpdateMapOffset(Vector4 offset)
	{
	}

	[Token(Token = "0x6012E50")]
	[Address(RVA = "0x280848C", Offset = "0x280848C", VA = "0x280848C")]
	public static void InitMapOffsetScaleRatio(float scale)
	{
	}

	[Token(Token = "0x6012E51")]
	[Address(RVA = "0x2808574", Offset = "0x2808574", VA = "0x2808574")]
	public static Vector2 ProjectToMapOffset(Vector2 pos2D)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x6012E52")]
	[Address(RVA = "0x2808A48", Offset = "0x2808A48", VA = "0x2808A48")]
	public static float ProjectToMapRadius(float radius)
	{
		return default(float);
	}

	[Token(Token = "0x6012E53")]
	[Address(RVA = "0x2808B4C", Offset = "0x2808B4C", VA = "0x2808B4C")]
	public static Vector3 ProjectToWorldOffset(Vector2 pos2D)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6012E54")]
	[Address(RVA = "0x280891C", Offset = "0x280891C", VA = "0x280891C")]
	public static Vector3 GetCenter()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6012E55")]
	[Address(RVA = "0x2808CD8", Offset = "0x2808CD8", VA = "0x2808CD8")]
	public static Vector2 ProjectToMapOffsetUnlimited(Vector2 pos2D)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x6012E56")]
	[Address(RVA = "0x2808E18", Offset = "0x2808E18", VA = "0x2808E18")]
	public static Vector2 ProjectToUVPos(Vector2 pos2D)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x6012E57")]
	[Address(RVA = "0x2808FA8", Offset = "0x2808FA8", VA = "0x2808FA8")]
	private static void DrawInnerBorder(UITexture circle, SafeZone currentSafeZone)
	{
	}

	[Token(Token = "0x6012E58")]
	[Address(RVA = "0x2809B48", Offset = "0x2809B48", VA = "0x2809B48")]
	public static void DrawInnerCircleZone(UITexture circle, Vector3 pos, float radius)
	{
	}

	[Token(Token = "0x6012E59")]
	[Address(RVA = "0x28098FC", Offset = "0x28098FC", VA = "0x28098FC")]
	public static void DrawInnerDottedCircleZone(UITexture circle, Vector3 pos, float radius)
	{
	}

	[Token(Token = "0x6012E5A")]
	[Address(RVA = "0x2809654", Offset = "0x2809654", VA = "0x2809654")]
	internal static void DrawInnerRectZone(UITexture circle, Vector3 pos, float width, float length, Vector3 forward)
	{
	}

	[Token(Token = "0x6012E5B")]
	[Address(RVA = "0x2809D94", Offset = "0x2809D94", VA = "0x2809D94")]
	internal static void UpdateInnerCircleMaterial(Material material, Vector3 pos, float radius)
	{
	}

	[Token(Token = "0x6012E5C")]
	[Address(RVA = "0x280AA54", Offset = "0x280AA54", VA = "0x280AA54")]
	internal static void UpdateNextCircleMaterial(Material material, Vector3 pos, float radius)
	{
	}

	[Token(Token = "0x6012E5D")]
	[Address(RVA = "0x2809EC8", Offset = "0x2809EC8", VA = "0x2809EC8")]
	internal static void UpdateInnerDottedCircleMaterial(Material material, Vector3 pos, float radius)
	{
	}

	[Token(Token = "0x6012E5E")]
	[Address(RVA = "0x2809FFC", Offset = "0x2809FFC", VA = "0x2809FFC")]
	private static void UpdateInnerRectMaterial(Material material, Vector3 pos, float length, float width, Vector3 forward)
	{
	}

	[Token(Token = "0x6012E5F")]
	[Address(RVA = "0x280A160", Offset = "0x280A160", VA = "0x280A160")]
	private static void UpdateMaterialCenterPos(Material material, ESafezoneType type, Vector3 pos)
	{
	}

	[Token(Token = "0x6012E60")]
	[Address(RVA = "0x280A468", Offset = "0x280A468", VA = "0x280A468")]
	private static void UpdateMaterialCircleRadius(Material mat, ESafezoneType type, float radius, float lineWidth)
	{
	}

	[Token(Token = "0x6012E61")]
	[Address(RVA = "0x280AB88", Offset = "0x280AB88", VA = "0x280AB88")]
	private static void UpdateMaterialRectCommon(Material material, ESafezoneType type, Vector3 pos, float length, float width, Vector3 forward, float lineWidth)
	{
	}

	[Token(Token = "0x6012E62")]
	[Address(RVA = "0x280AF74", Offset = "0x280AF74", VA = "0x280AF74")]
	private static void DrawOuterBorder(UITexture circle, SafeZone currentSafeZone, Vector4 color)
	{
	}

	[Token(Token = "0x6012E63")]
	[Address(RVA = "0x280BA2C", Offset = "0x280BA2C", VA = "0x280BA2C")]
	public static void DrawOuterCircleZone(UITexture circle, Vector3 pos, float radius, Vector4 color, bool isDirty = false)
	{
	}

	[Token(Token = "0x6012E64")]
	[Address(RVA = "0x280B734", Offset = "0x280B734", VA = "0x280B734")]
	internal static void DrawOuterRectZone(UITexture circle, Vector4 color, Vector3 pos, float width, float length, Vector3 forward)
	{
	}

	[Token(Token = "0x6012E65")]
	[Address(RVA = "0x280BCE0", Offset = "0x280BCE0", VA = "0x280BCE0")]
	internal static void UpdateOuterCircleMaterial(Material material, Vector3 pos, float radius, Vector4 color)
	{
	}

	[Token(Token = "0x6012E66")]
	[Address(RVA = "0x280BE5C", Offset = "0x280BE5C", VA = "0x280BE5C")]
	private static void UpdateOuterRectMaterial(Material material, Vector3 pos, Vector4 color, float length, float width, Vector3 forward)
	{
	}

	[Token(Token = "0x6012E67")]
	[Address(RVA = "0x280C008", Offset = "0x280C008", VA = "0x280C008")]
	private static void UpdateOuterMaterialColor(Material material, Vector4 color)
	{
	}

	[Token(Token = "0x6012E68")]
	[Address(RVA = "0x280C100", Offset = "0x280C100", VA = "0x280C100")]
	public static void ResetCachedData(bool excludeNextCircle = false)
	{
	}

	[Token(Token = "0x6012E69")]
	[Address(RVA = "0x280C390", Offset = "0x280C390", VA = "0x280C390")]
	internal static void DisableSafezone(SafeZone currentSafeZone, UITexture map)
	{
	}

	[Token(Token = "0x6012E6A")]
	[Address(RVA = "0x280CD24", Offset = "0x280CD24", VA = "0x280CD24")]
	public static void SetSafeZoneInvisible(UITexture map, ESafezoneType type)
	{
	}

	[Token(Token = "0x6012E6B")]
	[Address(RVA = "0x280C6A4", Offset = "0x280C6A4", VA = "0x280C6A4")]
	public static void SetCircleSafezone(UITexture map)
	{
	}

	[Token(Token = "0x6012E6C")]
	[Address(RVA = "0x280CA10", Offset = "0x280CA10", VA = "0x280CA10")]
	public static void SetRectangleSafezone(UITexture map)
	{
	}

	[Token(Token = "0x6012E6D")]
	[Address(RVA = "0x280D1E4", Offset = "0x280D1E4", VA = "0x280D1E4")]
	internal static void UpdateSafeZone(SafeZone currentSafeZone, UITexture map)
	{
	}

	[Token(Token = "0x6012E6E")]
	[Address(RVA = "0x280DCBC", Offset = "0x280DCBC", VA = "0x280DCBC")]
	public static void DrawCellGameUICircle(UITexture circle, Vector3 center, float radius)
	{
	}

	[Token(Token = "0x6012E6F")]
	[Address(RVA = "0x280DF9C", Offset = "0x280DF9C", VA = "0x280DF9C")]
	private static void UpdateCellGameUICircle(Material material, Vector3 pos, float radius, Vector4 color)
	{
	}

	[Token(Token = "0x6012E70")]
	[Address(RVA = "0x280E24C", Offset = "0x280E24C", VA = "0x280E24C")]
	public static void DrawCellGameCircleRing(UITexture circle, Vector3 center, float radius, float lineWidth)
	{
	}

	[Token(Token = "0x6012E71")]
	[Address(RVA = "0x280E4EC", Offset = "0x280E4EC", VA = "0x280E4EC")]
	private static void UpdateCellGameCircleRing(Material material, Vector3 pos, float radius, float lineWidthOff)
	{
	}

	[Token(Token = "0x6012E72")]
	[Address(RVA = "0x280DA60", Offset = "0x280DA60", VA = "0x280DA60")]
	private static void UpdateInnerCenterPosScale(SafeZone currentSafeZone)
	{
	}

	[Token(Token = "0x6012E73")]
	[Address(RVA = "0x280E788", Offset = "0x280E788", VA = "0x280E788")]
	internal static void UpdateNextSafeZone(SafeZone currentSafeZone, EEEEFKKFAKO infoboxData, UITexture nextInnerCircle)
	{
	}

	[Token(Token = "0x6012E74")]
	[Address(RVA = "0x280EDD8", Offset = "0x280EDD8", VA = "0x280EDD8")]
	internal static void UpdateGuideToSaveZone(SafeZone currentSafeZone, UISprite guideToSaveZone, Vector3 playerPos)
	{
	}

	[Token(Token = "0x6012E75")]
	[Address(RVA = "0x280F4C4", Offset = "0x280F4C4", VA = "0x280F4C4")]
	public static void SetGameObjectActive(GameObject go, bool active)
	{
	}

	[Token(Token = "0x6012E76")]
	[Address(RVA = "0x280F56C", Offset = "0x280F56C", VA = "0x280F56C")]
	public static void UpdateBombArea(GameObject bombParent, GameObject bombInstance, List<GameObject> bombAreas)
	{
	}

	[Token(Token = "0x6012E77")]
	[Address(RVA = "0x280FD18", Offset = "0x280FD18", VA = "0x280FD18")]
	internal static void SetCSGameZone(SafeZone currentSafeZone, GameObject zoneTemplate, Transform tr)
	{
	}

	[Token(Token = "0x6012E78")]
	[Address(RVA = "0x281028C", Offset = "0x281028C", VA = "0x281028C")]
	internal static void SetBombZone(SafeZone currentSafeZone, Dictionary<uint, UIHudBombZoneView> zones, bool isMiniMap)
	{
	}

	[Token(Token = "0x6012E79")]
	[Address(RVA = "0x28106FC", Offset = "0x28106FC", VA = "0x28106FC")]
	internal static void SetBombZone(Vector3 zonecenter, uint zoneIndex, UIHudBombZoneView zoneView)
	{
	}

	[Token(Token = "0x6012E7A")]
	[Address(RVA = "0x28109C8", Offset = "0x28109C8", VA = "0x28109C8")]
	public static void SetTeamateSpriteByIndex(TeammateGameObject teamGo, int idx)
	{
	}

	[Token(Token = "0x6012E7B")]
	[Address(RVA = "0x2810BA8", Offset = "0x2810BA8", VA = "0x2810BA8")]
	public static void SetTeamateSpriteByIndex2(TeammateGameObject teamGo, int idx)
	{
	}

	[Token(Token = "0x6012E7C")]
	[Address(RVA = "0x2810F0C", Offset = "0x2810F0C", VA = "0x2810F0C")]
	public static void UpdateTeammatePosition(TeammateGameObject teamGo, Vector3 pos, float angle)
	{
	}

	[Token(Token = "0x6012E7D")]
	[Address(RVA = "0x2811220", Offset = "0x2811220", VA = "0x2811220")]
	public static void UpdateEnemyPosition(GameObject enemyGo, Vector3 pos, float angle)
	{
	}

	[Token(Token = "0x6012E7E")]
	[Address(RVA = "0x28114B0", Offset = "0x28114B0", VA = "0x28114B0")]
	public static void UpdateBombPosition(GameObject bomb, Vector3 pos, float angle)
	{
	}

	[Token(Token = "0x6012E7F")]
	[Address(RVA = "0x2811740", Offset = "0x2811740", VA = "0x2811740")]
	public static void UpdateZeppelinPosition(GameObject zeppelin, Vector3 pos)
	{
	}

	[Token(Token = "0x6012E80")]
	[Address(RVA = "0x2811930", Offset = "0x2811930", VA = "0x2811930")]
	public static void UpdateVehiclePosition(GameObject vehicle, Vector3 pos, float angle)
	{
	}

	[Token(Token = "0x6012E81")]
	[Address(RVA = "0x2811B2C", Offset = "0x2811B2C", VA = "0x2811B2C")]
	public static void PlayerStartFiring(GameObject firing)
	{
	}

	[Token(Token = "0x6012E82")]
	[Address(RVA = "0x2811C50", Offset = "0x2811C50", VA = "0x2811C50")]
	public static void PlayerEndFiring(GameObject firing)
	{
	}

	[Token(Token = "0x6012E83")]
	[Address(RVA = "0x2811E0C", Offset = "0x2811E0C", VA = "0x2811E0C")]
	public static TeammateGameObject CreateTeammateGameObject(GameObject teammate)
	{
		return null;
	}

	[Token(Token = "0x6012E84")]
	[Address(RVA = "0x2811EC8", Offset = "0x2811EC8", VA = "0x2811EC8")]
	public static MapUIDeadBox CreateDeadBox(GameObject deadBox)
	{
		return null;
	}

	[Token(Token = "0x6012E85")]
	[Address(RVA = "0x2811F84", Offset = "0x2811F84", VA = "0x2811F84")]
	public static void SetupAirLine(UISprite airline_start, UISprite airline_end, UISprite airline)
	{
	}
}
