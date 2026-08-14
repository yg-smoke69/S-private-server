using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003FD7")]
public class SceneExtensionInfo : MonoBehaviour
{
	[Token(Token = "0x401ADCD")]
	[FieldOffset(Offset = "0x0")]
	private static SceneExtensionInfo _instance;

	[Token(Token = "0x401ADCE")]
	[FieldOffset(Offset = "0xC")]
	public bool version2018;

	[Token(Token = "0x401ADCF")]
	[FieldOffset(Offset = "0x10")]
	public int lightmapNum;

	[Token(Token = "0x401ADD0")]
	[FieldOffset(Offset = "0x14")]
	public List<LightmapAreaInfo> areaLightmaps;

	[Token(Token = "0x401ADD1")]
	[FieldOffset(Offset = "0x18")]
	private LightmapData[] _003CLightmapDataArr_003Ek__BackingField;

	[Token(Token = "0x401ADD2")]
	[FieldOffset(Offset = "0x1C")]
	private int[] LightmapRefCount;

	[Token(Token = "0x401ADD3")]
	private const int LightmapBlockSize = 3;

	[Token(Token = "0x401ADD4")]
	[FieldOffset(Offset = "0x20")]
	private int extraPrefabLightmapNum;

	[Token(Token = "0x401ADD5")]
	[FieldOffset(Offset = "0x24")]
	private List<LightmapData> LightmapDataArrWithExtra;

	[Token(Token = "0x401ADD6")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, RuntimePrefabStat> extraPrefabLightmaps;

	[Token(Token = "0x401ADD7")]
	public const int P_blockSize = 100;

	[Token(Token = "0x401ADD8")]
	public const int L_blockSize = 50;

	[Token(Token = "0x401ADD9")]
	public const int S_blockSize = 30;

	[Token(Token = "0x401ADDA")]
	private const float shadowOnlyScale = 0.01f;

	[Token(Token = "0x401ADDB")]
	[FieldOffset(Offset = "0x2C")]
	public bool hasShadowmask;

	[Token(Token = "0x401ADDC")]
	[FieldOffset(Offset = "0x2D")]
	public bool skipLightmapFile;

	[Token(Token = "0x401ADDD")]
	[FieldOffset(Offset = "0x4")]
	public static bool bakingMode;

	[Token(Token = "0x401ADDE")]
	[FieldOffset(Offset = "0x5")]
	public static bool enableAlert;

	[Token(Token = "0x401ADDF")]
	public const string c_NegScaleMeshName = "__NegScaleMesh__";

	[Token(Token = "0x17001C59")]
	public static SceneExtensionInfo instance
	{
		[Token(Token = "0x6019FAE")]
		[Address(RVA = "0x21C138C", Offset = "0x21C138C", VA = "0x21C138C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019FAF")]
		[Address(RVA = "0x21C1418", Offset = "0x21C1418", VA = "0x21C1418")]
		private set
		{
		}
	}

	[Token(Token = "0x17001C5A")]
	public LightmapData[] LightmapDataArr
	{
		[Token(Token = "0x6019FB0")]
		[Address(RVA = "0x21C14A8", Offset = "0x21C14A8", VA = "0x21C14A8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019FB1")]
		[Address(RVA = "0x21C14B0", Offset = "0x21C14B0", VA = "0x21C14B0")]
		private set
		{
		}
	}

	[Token(Token = "0x6019FAD")]
	[Address(RVA = "0x21C1300", Offset = "0x21C1300", VA = "0x21C1300")]
	public SceneExtensionInfo()
	{
	}

	[Token(Token = "0x6019FB2")]
	[Address(RVA = "0x21C14B8", Offset = "0x21C14B8", VA = "0x21C14B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019FB3")]
	[Address(RVA = "0x21C192C", Offset = "0x21C192C", VA = "0x21C192C")]
	private void Start()
	{
	}

	[Token(Token = "0x6019FB4")]
	[Address(RVA = "0x21C1F9C", Offset = "0x21C1F9C", VA = "0x21C1F9C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6019FB5")]
	[Address(RVA = "0x21C2094", Offset = "0x21C2094", VA = "0x21C2094")]
	public void InitLightmaps()
	{
	}

	[Token(Token = "0x6019FB6")]
	[Address(RVA = "0x21C15DC", Offset = "0x21C15DC", VA = "0x21C15DC")]
	public void InitLightmapInfo()
	{
	}

	[Token(Token = "0x6019FB7")]
	[Address(RVA = "0x21C19CC", Offset = "0x21C19CC", VA = "0x21C19CC")]
	public void InitLightmapTextures()
	{
	}

	[Token(Token = "0x6019FB8")]
	[Address(RVA = "0x21C20B0", Offset = "0x21C20B0", VA = "0x21C20B0")]
	public void RefreshLightmapNum()
	{
	}

	[Token(Token = "0x6019FB9")]
	[Address(RVA = "0x21C223C", Offset = "0x21C223C", VA = "0x21C223C")]
	public void LoadLightmap(LightmapTextureInfo info)
	{
	}

	[Token(Token = "0x6019FBA")]
	[Address(RVA = "0x21C2584", Offset = "0x21C2584", VA = "0x21C2584")]
	public void UnloadLightmap(LightmapTextureInfo info)
	{
	}

	[Token(Token = "0x6019FBB")]
	[Address(RVA = "0x21C2988", Offset = "0x21C2988", VA = "0x21C2988")]
	public void LoadLightmap(LightmapTextureInfo2 info)
	{
	}

	[Token(Token = "0x6019FBC")]
	[Address(RVA = "0x21C2D00", Offset = "0x21C2D00", VA = "0x21C2D00")]
	public void UnloadLightmap(LightmapTextureInfo2 info)
	{
	}

	[Token(Token = "0x6019FBD")]
	[Address(RVA = "0x21C314C", Offset = "0x21C314C", VA = "0x21C314C")]
	public int LoadLightmapEx(RuntimePrefabLightmap info)
	{
		return default(int);
	}

	[Token(Token = "0x6019FBE")]
	[Address(RVA = "0x21C35C0", Offset = "0x21C35C0", VA = "0x21C35C0")]
	public void UnloadLightmapEx(RuntimePrefabLightmap info)
	{
	}

	[Token(Token = "0x6019FBF")]
	[Address(RVA = "0x21C37A0", Offset = "0x21C37A0", VA = "0x21C37A0")]
	public void ClearLightmapEx()
	{
	}
}
