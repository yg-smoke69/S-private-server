using System;
using Il2CppDummyDll;
using UnityEngine;
using WorldStreamer;

namespace COW.GamePlay;

[Token(Token = "0x2000A89")]
public class SceneGraphicsQuality : MonoBehaviour
{
	[Token(Token = "0x4005C9F")]
	[FieldOffset(Offset = "0xC")]
	public bool enableShadow;

	[Token(Token = "0x4005CA0")]
	[FieldOffset(Offset = "0xD")]
	public bool useUnityShadowForSecondary;

	[Token(Token = "0x4005CA1")]
	[FieldOffset(Offset = "0xE")]
	public bool useUnityDefaultFog;

	[Token(Token = "0x4005CA2")]
	[FieldOffset(Offset = "0x10")]
	public float shadowDistance;

	[Token(Token = "0x4005CA3")]
	[FieldOffset(Offset = "0x0")]
	public static GAGILKKDDMJ currentQuality;

	[Token(Token = "0x4005CA4")]
	[FieldOffset(Offset = "0x4")]
	private static int ADCBMKLJENA;

	[Token(Token = "0x4005CA5")]
	[FieldOffset(Offset = "0x8")]
	private static int DDHHJNBLAOO;

	[Token(Token = "0x4005CA6")]
	[FieldOffset(Offset = "0xC")]
	public static int DeviceWidth;

	[Token(Token = "0x4005CA7")]
	[FieldOffset(Offset = "0x10")]
	public static int DeviceHeight;

	[Token(Token = "0x4005CA8")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int OBABMBLGAPB;

	[Token(Token = "0x4005CA9")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int JMHDPHEFAMA;

	[Token(Token = "0x4005CAA")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly int GKCEABINKNN;

	[Token(Token = "0x4005CAB")]
	[FieldOffset(Offset = "0x20")]
	private static readonly int HAIEBIILEAH;

	[Token(Token = "0x4005CAC")]
	[FieldOffset(Offset = "0x24")]
	public static float m_resolutionResetScale;

	[Token(Token = "0x4005CAD")]
	[FieldOffset(Offset = "0x28")]
	public static EInGameFilterSetting lutEffectFilter;

	[Token(Token = "0x4005CAE")]
	[FieldOffset(Offset = "0x2C")]
	public static BANECLJHGOD shadowType;

	[Token(Token = "0x4005CAF")]
	[FieldOffset(Offset = "0x30")]
	private static bool MANMMECCEEO;

	[Token(Token = "0x4005CB0")]
	[FieldOffset(Offset = "0x31")]
	private static bool OCLPKHMIKIK;

	[Token(Token = "0x4005CB1")]
	[FieldOffset(Offset = "0x34")]
	private static ShadowResolution JAIHNOHAFJP;

	[Token(Token = "0x4005CB2")]
	[FieldOffset(Offset = "0x38")]
	private static Light NICLKFOAKMK;

	[Token(Token = "0x1700063C")]
	private static Light EHCDCLNGMMA
	{
		[Token(Token = "0x6005102")]
		[Address(RVA = "0x1D6E500", Offset = "0x1D6E500", VA = "0x1D6E500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005101")]
	[Address(RVA = "0x1D6E4DC", Offset = "0x1D6E4DC", VA = "0x1D6E4DC")]
	public SceneGraphicsQuality()
	{
	}

	[Token(Token = "0x6005103")]
	[Address(RVA = "0x1D6E728", Offset = "0x1D6E728", VA = "0x1D6E728")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005104")]
	[Address(RVA = "0x1D6F400", Offset = "0x1D6F400", VA = "0x1D6F400")]
	private void Start()
	{
	}

	[Token(Token = "0x6005105")]
	[Address(RVA = "0x1D6EC7C", Offset = "0x1D6EC7C", VA = "0x1D6EC7C")]
	private void DKOIJKJCNHK(Streamer BODCBECMNMH, int DEDAENIPHKB)
	{
	}

	[Token(Token = "0x6005106")]
	[Address(RVA = "0x1D6EE7C", Offset = "0x1D6EE7C", VA = "0x1D6EE7C")]
	public static void SetShadowType(BANECLJHGOD PMGBACFJIHO, bool BDEHCGGPBME = true, float IIADNDEHHAD = -1f)
	{
	}

	[Token(Token = "0x6005107")]
	[Address(RVA = "0x1D6FAF0", Offset = "0x1D6FAF0", VA = "0x1D6FAF0")]
	public static void SetGraphicsQuality(Type AOENOBEDJAJ)
	{
	}

	[Token(Token = "0x6005108")]
	[Address(RVA = "0x1D70028", Offset = "0x1D70028", VA = "0x1D70028")]
	public static void ResetGraphicsQuality()
	{
	}

	[Token(Token = "0x6005109")]
	[Address(RVA = "0x1D702FC", Offset = "0x1D702FC", VA = "0x1D702FC")]
	public static void SetShaderMaximumLOD()
	{
	}

	[Token(Token = "0x600510A")]
	[Address(RVA = "0x1D703D4", Offset = "0x1D703D4", VA = "0x1D703D4")]
	public static void ResetScreenSize(bool JBACEMEFMCA = false)
	{
	}

	[Token(Token = "0x600510B")]
	[Address(RVA = "0x1D70C88", Offset = "0x1D70C88", VA = "0x1D70C88")]
	public static int GetDesignWidth()
	{
		return default(int);
	}

	[Token(Token = "0x600510C")]
	[Address(RVA = "0x1D71070", Offset = "0x1D71070", VA = "0x1D71070")]
	public static int GetDesignHeight()
	{
		return default(int);
	}

	[Token(Token = "0x600510D")]
	[Address(RVA = "0x1D71574", Offset = "0x1D71574", VA = "0x1D71574")]
	public static bool IsLobbyHDRecipeEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x600510E")]
	[Address(RVA = "0x1D716C0", Offset = "0x1D716C0", VA = "0x1D716C0")]
	public static void SetResolutionRegionEnable(bool ELOELMEPFCN)
	{
	}

	[Token(Token = "0x600510F")]
	[Address(RVA = "0x1D71798", Offset = "0x1D71798", VA = "0x1D71798")]
	public static bool GetResolutionRegionEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x6005110")]
	[Address(RVA = "0x1D71868", Offset = "0x1D71868", VA = "0x1D71868")]
	public static void SetShouldReduceResolution(bool CODHJLCPIKI)
	{
	}

	[Token(Token = "0x6005111")]
	[Address(RVA = "0x1D71458", Offset = "0x1D71458", VA = "0x1D71458")]
	public static bool NeedReduceResolution()
	{
		return default(bool);
	}

	[Token(Token = "0x6005112")]
	[Address(RVA = "0x1D71940", Offset = "0x1D71940", VA = "0x1D71940")]
	public static bool IsQualityGreaterEqualThanRef(GAGILKKDDMJ MEMIANAOPEB)
	{
		return default(bool);
	}
}
