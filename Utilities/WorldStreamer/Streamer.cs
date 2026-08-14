using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace WorldStreamer;

[Token(Token = "0x2003D32")]
public class Streamer : MonoBehaviour, _Attribute
{
	[Token(Token = "0x2003D33")]
	public delegate void KEFAODEICHK(Texture NKFJCJGKFJF, ref int GGAPJKPDFGE);

	[Token(Token = "0x2003D34")]
	private enum OBKFFIIEDEE
	{
		[Token(Token = "0x4019F8B")]
		Type_None = 0,
		[Token(Token = "0x4019F8C")]
		Type_MaxScene = 1,
		[Token(Token = "0x4019F8D")]
		Type_FreeMemory = 2,
		[Token(Token = "0x4019F8E")]
		Type_UsedMemory = 4,
		[Token(Token = "0x4019F8F")]
		Type_MaxWaitTime = 8
	}

	[Token(Token = "0x2003D35")]
	private sealed class BKPGLOONEKB : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4019F90")]
		[FieldOffset(Offset = "0x8")]
		internal SceneSplit PAMPOECJJEC;

		[Token(Token = "0x4019F91")]
		[FieldOffset(Offset = "0xC")]
		internal string HOAAKJOCELO;

		[Token(Token = "0x4019F92")]
		[FieldOffset(Offset = "0x10")]
		internal AsyncOperation LOGACCFDBGC;

		[Token(Token = "0x4019F93")]
		[FieldOffset(Offset = "0x14")]
		internal bool AKNJLEDCGDD;

		[Token(Token = "0x4019F94")]
		[FieldOffset(Offset = "0x18")]
		internal Scene NAAJDKBALHA;

		[Token(Token = "0x4019F95")]
		[FieldOffset(Offset = "0x1C")]
		internal GameObject[] FLBNPMBMPGA;

		[Token(Token = "0x4019F96")]
		[FieldOffset(Offset = "0x20")]
		internal Streamer GADHAMJEKIM;

		[Token(Token = "0x4019F97")]
		[FieldOffset(Offset = "0x24")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x4019F98")]
		[FieldOffset(Offset = "0x28")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x4019F99")]
		[FieldOffset(Offset = "0x2C")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x170019E6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60187D8")]
			[Address(RVA = "0x336A754", Offset = "0x336A754", VA = "0x336A754", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170019E7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60187D9")]
			[Address(RVA = "0x336A75C", Offset = "0x336A75C", VA = "0x336A75C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60187D6")]
		[Address(RVA = "0x336A26C", Offset = "0x336A26C", VA = "0x336A26C")]
		public BKPGLOONEKB()
		{
		}

		[Token(Token = "0x60187D7")]
		[Address(RVA = "0x336A274", Offset = "0x336A274", VA = "0x336A274", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60187DA")]
		[Address(RVA = "0x336A764", Offset = "0x336A764", VA = "0x336A764", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60187DB")]
		[Address(RVA = "0x336A778", Offset = "0x336A778", VA = "0x336A778", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2003D36")]
	private sealed class KLNOABNDPEA : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4019F9A")]
		[FieldOffset(Offset = "0x8")]
		internal SceneSplit PAMPOECJJEC;

		[Token(Token = "0x4019F9B")]
		[FieldOffset(Offset = "0xC")]
		internal string HOAAKJOCELO;

		[Token(Token = "0x4019F9C")]
		[FieldOffset(Offset = "0x10")]
		internal int CGNMFGHAGLC;

		[Token(Token = "0x4019F9D")]
		[FieldOffset(Offset = "0x14")]
		internal ABSceneInfo EBDLCKBALOG;

		[Token(Token = "0x4019F9E")]
		[FieldOffset(Offset = "0x18")]
		internal string KLIJAOGPCAE;

		[Token(Token = "0x4019F9F")]
		[FieldOffset(Offset = "0x1C")]
		internal GameObject DNBJECEIDBG;

		[Token(Token = "0x4019FA0")]
		[FieldOffset(Offset = "0x20")]
		internal GameObject OHLLLIMJNNE;

		[Token(Token = "0x4019FA1")]
		[FieldOffset(Offset = "0x24")]
		internal AssetBundleRequest MOHOGKOPGPH;

		[Token(Token = "0x4019FA2")]
		[FieldOffset(Offset = "0x28")]
		internal List<ABSceneGOInfo> JLJMOCCNIOO;

		[Token(Token = "0x4019FA3")]
		[FieldOffset(Offset = "0x2C")]
		internal int CAKLPICIDAI;

		[Token(Token = "0x4019FA4")]
		[FieldOffset(Offset = "0x30")]
		internal ABSceneGOInfo PFKIMPEEPBC;

		[Token(Token = "0x4019FA5")]
		[FieldOffset(Offset = "0x34")]
		internal int HDNFDCHMJOJ;

		[Token(Token = "0x4019FA6")]
		[FieldOffset(Offset = "0x38")]
		internal int EAONBHDHHBN;

		[Token(Token = "0x4019FA7")]
		[FieldOffset(Offset = "0x3C")]
		internal GameObject BKGFMBJEFLP;

		[Token(Token = "0x4019FA8")]
		[FieldOffset(Offset = "0x40")]
		internal bool PNCGNBOFPAG;

		[Token(Token = "0x4019FA9")]
		[FieldOffset(Offset = "0x41")]
		internal bool OMHIIIEAJFP;

		[Token(Token = "0x4019FAA")]
		[FieldOffset(Offset = "0x44")]
		internal string ECJDHGGFFNL;

		[Token(Token = "0x4019FAB")]
		[FieldOffset(Offset = "0x48")]
		internal AssetBundleRequest NPOAPLGDFEL;

		[Token(Token = "0x4019FAC")]
		[FieldOffset(Offset = "0x4C")]
		internal ABScenePrefabRef HNBPONDGOEH;

		[Token(Token = "0x4019FAD")]
		[FieldOffset(Offset = "0x50")]
		internal Streamer GADHAMJEKIM;

		[Token(Token = "0x4019FAE")]
		[FieldOffset(Offset = "0x54")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x4019FAF")]
		[FieldOffset(Offset = "0x58")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x4019FB0")]
		[FieldOffset(Offset = "0x5C")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x170019E8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60187DE")]
			[Address(RVA = "0x336D4F4", Offset = "0x336D4F4", VA = "0x336D4F4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170019E9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60187DF")]
			[Address(RVA = "0x336D4FC", Offset = "0x336D4FC", VA = "0x336D4FC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60187DC")]
		[Address(RVA = "0x336B2D0", Offset = "0x336B2D0", VA = "0x336B2D0")]
		public KLNOABNDPEA()
		{
		}

		[Token(Token = "0x60187DD")]
		[Address(RVA = "0x336B2D8", Offset = "0x336B2D8", VA = "0x336B2D8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60187E0")]
		[Address(RVA = "0x336D504", Offset = "0x336D504", VA = "0x336D504", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60187E1")]
		[Address(RVA = "0x336D518", Offset = "0x336D518", VA = "0x336D518", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2003D37")]
	private sealed class DKBAPFAEIKI : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4019FB1")]
		[FieldOffset(Offset = "0x8")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x4019FB2")]
		[FieldOffset(Offset = "0xC")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x4019FB3")]
		[FieldOffset(Offset = "0x10")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x170019EA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60187E4")]
			[Address(RVA = "0x336AD70", Offset = "0x336AD70", VA = "0x336AD70", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170019EB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60187E5")]
			[Address(RVA = "0x336AD78", Offset = "0x336AD78", VA = "0x336AD78", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60187E2")]
		[Address(RVA = "0x336A800", Offset = "0x336A800", VA = "0x336A800")]
		public DKBAPFAEIKI()
		{
		}

		[Token(Token = "0x60187E3")]
		[Address(RVA = "0x336A808", Offset = "0x336A808", VA = "0x336A808", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60187E6")]
		[Address(RVA = "0x336AD80", Offset = "0x336AD80", VA = "0x336AD80", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60187E7")]
		[Address(RVA = "0x336AD94", Offset = "0x336AD94", VA = "0x336AD94", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4019F24")]
	[FieldOffset(Offset = "0xC")]
	public bool streamerActive;

	[Token(Token = "0x4019F25")]
	[FieldOffset(Offset = "0x0")]
	public static string STREAMERTAG;

	[Token(Token = "0x4019F26")]
	[FieldOffset(Offset = "0x10")]
	public SceneCollection sceneCollection;

	[Token(Token = "0x4019F27")]
	[FieldOffset(Offset = "0x14")]
	public SceneSplit[] splits;

	[Token(Token = "0x4019F28")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 loadingRange;

	[Token(Token = "0x4019F29")]
	[FieldOffset(Offset = "0x24")]
	public bool useLoadingRangeMin;

	[Token(Token = "0x4019F2A")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 loadingRangeMin;

	[Token(Token = "0x4019F2B")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 deloadingRange;

	[Token(Token = "0x4019F2C")]
	[FieldOffset(Offset = "0x40")]
	public float loadingMaxY;

	[Token(Token = "0x4019F2D")]
	[FieldOffset(Offset = "0x44")]
	public float positionCheckTime;

	[Token(Token = "0x4019F2E")]
	[FieldOffset(Offset = "0x48")]
	public float destroyTileDelay;

	[Token(Token = "0x4019F2F")]
	[FieldOffset(Offset = "0x4C")]
	public int maxParallelSceneLoading;

	[Token(Token = "0x4019F30")]
	[FieldOffset(Offset = "0x50")]
	public int sceneLoadWaitFrames;

	[Token(Token = "0x4019F31")]
	[FieldOffset(Offset = "0x54")]
	public bool isPreviewLayer;

	[Token(Token = "0x4019F32")]
	[FieldOffset(Offset = "0x58")]
	public TerrainNeighbours terrainNeighbours;

	[Token(Token = "0x4019F33")]
	[FieldOffset(Offset = "0x5C")]
	public bool looping;

	[Token(Token = "0x4019F34")]
	[FieldOffset(Offset = "0x60")]
	public Transform player;

	[Token(Token = "0x4019F35")]
	[FieldOffset(Offset = "0x64")]
	public bool spawnedPlayer;

	[Token(Token = "0x4019F36")]
	[FieldOffset(Offset = "0x68")]
	public string playerTag;

	[Token(Token = "0x4019F37")]
	[FieldOffset(Offset = "0x6C")]
	public bool showLoadingScreen;

	[Token(Token = "0x4019F38")]
	[FieldOffset(Offset = "0x70")]
	public UILoadingStreamer loadingStreamer;

	[Token(Token = "0x4019F39")]
	[FieldOffset(Offset = "0x74")]
	public bool initialized;

	[Token(Token = "0x4019F3A")]
	[FieldOffset(Offset = "0x78")]
	public int tilesToLoad;

	[Token(Token = "0x4019F3B")]
	[FieldOffset(Offset = "0x7C")]
	public int tilesLoaded;

	[Token(Token = "0x4019F3C")]
	[FieldOffset(Offset = "0x80")]
	public WorldMover worldMover;

	[Token(Token = "0x4019F3D")]
	[FieldOffset(Offset = "0x84")]
	public Vector3 currentMove;

	[Token(Token = "0x4019F3E")]
	[FieldOffset(Offset = "0x90")]
	public Vector3 currentRange;

	[Token(Token = "0x4019F3F")]
	[FieldOffset(Offset = "0x9C")]
	private int MBMDBELNDOO;

	[Token(Token = "0x4019F40")]
	[FieldOffset(Offset = "0xA0")]
	private int MLNCPJDBICC;

	[Token(Token = "0x4019F41")]
	[FieldOffset(Offset = "0xA4")]
	private int PNKHLFNDKBI;

	[Token(Token = "0x4019F42")]
	[FieldOffset(Offset = "0xA8")]
	public Dictionary<int[], SceneSplit> scenesArray;

	[Token(Token = "0x4019F43")]
	[FieldOffset(Offset = "0xAC")]
	public List<SceneSplit> loadedScenes;

	[Token(Token = "0x4019F44")]
	[FieldOffset(Offset = "0xB0")]
	private int OMHAGFCFKMO;

	[Token(Token = "0x4019F45")]
	[FieldOffset(Offset = "0xB4")]
	private List<SceneSplit> NKADMFBNLFH;

	[Token(Token = "0x4019F46")]
	[FieldOffset(Offset = "0xB8")]
	private int FNEKHEBLDLC;

	[Token(Token = "0x4019F47")]
	[FieldOffset(Offset = "0xBC")]
	private bool KEHOLAAAODC;

	[Token(Token = "0x4019F48")]
	[FieldOffset(Offset = "0xC0")]
	private int MBINHMIDHKB;

	[Token(Token = "0x4019F49")]
	[FieldOffset(Offset = "0xC4")]
	private int AFMHIGHCGNK;

	[Token(Token = "0x4019F4A")]
	[FieldOffset(Offset = "0xC8")]
	private int EEILGLNANDN;

	[Token(Token = "0x4019F4B")]
	[FieldOffset(Offset = "0xCC")]
	private int LGHCBDPNANL;

	[Token(Token = "0x4019F4C")]
	[FieldOffset(Offset = "0xD0")]
	private int BMOMMEKICMP;

	[Token(Token = "0x4019F4D")]
	[FieldOffset(Offset = "0xD4")]
	private int IONMDKHBEKM;

	[Token(Token = "0x4019F4E")]
	[FieldOffset(Offset = "0xD8")]
	private int PMDBJIBOACK;

	[Token(Token = "0x4019F4F")]
	[FieldOffset(Offset = "0xDC")]
	private int OCJEEBDGFAC;

	[Token(Token = "0x4019F50")]
	[FieldOffset(Offset = "0xE0")]
	private int EFIHFDDAEHB;

	[Token(Token = "0x4019F51")]
	[FieldOffset(Offset = "0xE4")]
	private string OELPDMODPEM;

	[Token(Token = "0x4019F52")]
	[FieldOffset(Offset = "0xE8")]
	private bool KIOODMPCGDK;

	[Token(Token = "0x4019F53")]
	[FieldOffset(Offset = "0xEC")]
	private Vector3 DACCMCLFHKK;

	[Token(Token = "0x4019F54")]
	private const float MNJBDGBACHM = 100f;

	[Token(Token = "0x4019F55")]
	[FieldOffset(Offset = "0xF8")]
	private GameObject BPOOFOOKONB;

	[Token(Token = "0x4019F56")]
	[FieldOffset(Offset = "0xFC")]
	private Debug_ColliderTrigger DGPFDNLGEHA;

	[Token(Token = "0x4019F57")]
	[FieldOffset(Offset = "0x4")]
	private static bool OIBFNEJMIJN;

	[Token(Token = "0x4019F58")]
	[FieldOffset(Offset = "0x8")]
	public static float waitTillNextUnload;

	[Token(Token = "0x4019F59")]
	[FieldOffset(Offset = "0xC")]
	private static bool AJIFIMMNMHF;

	[Token(Token = "0x4019F5A")]
	[FieldOffset(Offset = "0x10")]
	public static Streamer defaultLayer;

	[Token(Token = "0x4019F5B")]
	[FieldOffset(Offset = "0x14")]
	public static IPreviewLayer previewerLayer;

	[Token(Token = "0x4019F5C")]
	[FieldOffset(Offset = "0x18")]
	public static IPreviewLayer nonstreamPreviewLayer;

	[Token(Token = "0x4019F5D")]
	[FieldOffset(Offset = "0x100")]
	private Dictionary<string, GameObject> EFAKLPOGPEN;

	[Token(Token = "0x4019F5E")]
	[FieldOffset(Offset = "0x104")]
	private Dictionary<string, int> ACNBMPGAABK;

	[Token(Token = "0x4019F5F")]
	[FieldOffset(Offset = "0x108")]
	private Dictionary<int, ABSceneInfo> DABLONJDHAG;

	[Token(Token = "0x4019F60")]
	[FieldOffset(Offset = "0x10C")]
	private Dictionary<int, ABSceneGOInfo> IABGGDKJNEJ;

	[Token(Token = "0x4019F61")]
	[FieldOffset(Offset = "0x110")]
	private Dictionary<int, SharedSceneObjectRecord> CMNMCDIKNNI;

	[Token(Token = "0x4019F62")]
	[FieldOffset(Offset = "0x1C")]
	private static Dictionary<int, ABScenePrefabRef> CCNDJHGMKBN;

	[Token(Token = "0x4019F63")]
	[FieldOffset(Offset = "0x20")]
	private static Dictionary<int, ABScenePrefabMeshInfo> KPCAKKMFDKG;

	[Token(Token = "0x4019F64")]
	[FieldOffset(Offset = "0x24")]
	private static Dictionary<int, ABSceneMeshRef> IGHNPGJAOCC;

	[Token(Token = "0x4019F65")]
	[FieldOffset(Offset = "0x28")]
	private static List<string> LMDLHAMHFNO;

	[Token(Token = "0x4019F66")]
	[FieldOffset(Offset = "0x2C")]
	private static AssetBundle KFKKOPPDDMH;

	[Token(Token = "0x4019F67")]
	[FieldOffset(Offset = "0x114")]
	private SceneStreamerInfoHelper MHDIIMHBNCJ;

	[Token(Token = "0x4019F68")]
	[FieldOffset(Offset = "0x118")]
	private GameObject OEDIEGHBKFD;

	[Token(Token = "0x4019F69")]
	[FieldOffset(Offset = "0x11C")]
	private GameObject NCHICBILJBK;

	[Token(Token = "0x4019F6A")]
	[FieldOffset(Offset = "0x30")]
	private static List<int> MBDDJKDBCBL;

	[Token(Token = "0x4019F6B")]
	[FieldOffset(Offset = "0x34")]
	private static List<int> LFICCNFKOOM;

	[Token(Token = "0x4019F6C")]
	[FieldOffset(Offset = "0x38")]
	private static bool IJDGOMIAFID;

	[Token(Token = "0x4019F6D")]
	[FieldOffset(Offset = "0x3C")]
	private static List<List<short>> PEMFNLJKDGH;

	[Token(Token = "0x4019F6E")]
	[FieldOffset(Offset = "0x40")]
	private static List<ABSceneMatRef> GCJLPGKBNPP;

	[Token(Token = "0x4019F6F")]
	[FieldOffset(Offset = "0x44")]
	private static Dictionary<short, ABSceneTexRef> CPEBHIBCJBH;

	[Token(Token = "0x4019F70")]
	[FieldOffset(Offset = "0x48")]
	private static List<short> FHPPMKOAOKE;

	[Token(Token = "0x4019F71")]
	[FieldOffset(Offset = "0x4C")]
	private static List<short> OMCACMKBHCP;

	[Token(Token = "0x4019F72")]
	[FieldOffset(Offset = "0x120")]
	public KEFAODEICHK m_ABTextureRefIncreaseCallBack;

	[Token(Token = "0x4019F73")]
	[FieldOffset(Offset = "0x124")]
	public List<string> destoryedSceneList;

	[Token(Token = "0x4019F74")]
	[FieldOffset(Offset = "0x50")]
	public static bool useNewUnloadType;

	[Token(Token = "0x4019F75")]
	[FieldOffset(Offset = "0x54")]
	public static int unloadType;

	[Token(Token = "0x4019F76")]
	[FieldOffset(Offset = "0x58")]
	public static int unloadMaxDestoryScene;

	[Token(Token = "0x4019F77")]
	[FieldOffset(Offset = "0x5C")]
	public static int unloadMaxFreeMemory;

	[Token(Token = "0x4019F78")]
	[FieldOffset(Offset = "0x60")]
	public static int unloadProcessMemory;

	[Token(Token = "0x4019F79")]
	[FieldOffset(Offset = "0x64")]
	public static float unloadProcessMemFreq;

	[Token(Token = "0x4019F7A")]
	[FieldOffset(Offset = "0x128")]
	private float KBCKHPFHADB;

	[Token(Token = "0x4019F7B")]
	[FieldOffset(Offset = "0x12C")]
	private bool CPMCGIPEFCF;

	[Token(Token = "0x4019F7C")]
	[FieldOffset(Offset = "0x68")]
	public static int unloadMaxUsedMemory;

	[Token(Token = "0x4019F7D")]
	[FieldOffset(Offset = "0x6C")]
	public static float unloadMaxWaitTime;

	[Token(Token = "0x4019F7E")]
	[FieldOffset(Offset = "0x70")]
	public static float unloadMaxFreeMemFreq;

	[Token(Token = "0x4019F7F")]
	[FieldOffset(Offset = "0x130")]
	private float KGIJNNLEFCA;

	[Token(Token = "0x4019F80")]
	[FieldOffset(Offset = "0x134")]
	private float HMEGICGNOJG;

	[Token(Token = "0x4019F81")]
	[FieldOffset(Offset = "0x74")]
	public static int unloadUnsedCount;

	[Token(Token = "0x4019F82")]
	[FieldOffset(Offset = "0x78")]
	private static int KNHJIAMIAML;

	[Token(Token = "0x4019F83")]
	[FieldOffset(Offset = "0x7C")]
	private static bool OJNLEDANLIF;

	[Token(Token = "0x4019F84")]
	[FieldOffset(Offset = "0x7D")]
	public static bool TryFixCurrentSceneLoading;

	[Token(Token = "0x4019F85")]
	[FieldOffset(Offset = "0x7E")]
	public static bool needUpdate;

	[Token(Token = "0x4019F86")]
	[FieldOffset(Offset = "0x7F")]
	public static bool abSceneUnloadMesh;

	[Token(Token = "0x4019F87")]
	[FieldOffset(Offset = "0x80")]
	public static bool abSceneUnloadTexture;

	[Token(Token = "0x4019F88")]
	[FieldOffset(Offset = "0x138")]
	public StreamerType streamerType;

	[Token(Token = "0x4019F89")]
	[FieldOffset(Offset = "0x13C")]
	private Vector3 CIHFHNMLFDJ;

	[Token(Token = "0x170019E4")]
	public float JBICAPNODDE
	{
		[Token(Token = "0x60187A1")]
		[Address(RVA = "0x2A6F34C", Offset = "0x2A6F34C", VA = "0x2A6F34C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170019E5")]
	public Debug_ColliderTrigger AEGJKBDEIOM
	{
		[Token(Token = "0x60187A2")]
		[Address(RVA = "0x2A6F37C", Offset = "0x2A6F37C", VA = "0x2A6F37C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60187A0")]
	[Address(RVA = "0x2A6F0E0", Offset = "0x2A6F0E0", VA = "0x2A6F0E0")]
	public Streamer()
	{
	}

	[Token(Token = "0x60187A3")]
	[Address(RVA = "0x2A6F458", Offset = "0x2A6F458", VA = "0x2A6F458")]
	public Transform GetPlayerSafe()
	{
		return null;
	}

	[Token(Token = "0x60187A4")]
	[Address(RVA = "0x2A6F4DC", Offset = "0x2A6F4DC", VA = "0x2A6F4DC")]
	public static bool HasAsyncLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x60187A5")]
	[Address(RVA = "0x2A6F574", Offset = "0x2A6F574", VA = "0x2A6F574")]
	public static void StopAsyncLoading()
	{
	}

	[Token(Token = "0x60187A6")]
	[Address(RVA = "0x2A6F604", Offset = "0x2A6F604", VA = "0x2A6F604")]
	public static void ResetAsyncLoading()
	{
	}

	[Token(Token = "0x60187A7")]
	[Address(RVA = "0x2A6F694", Offset = "0x2A6F694", VA = "0x2A6F694")]
	public static Streamer FindStreamerByName(string ANNPOCFNGEC)
	{
		return null;
	}

	[Token(Token = "0x60187A8")]
	[Address(RVA = "0x2A6F768", Offset = "0x2A6F768", VA = "0x2A6F768")]
	private void Awake()
	{
	}

	[Token(Token = "0x60187A9")]
	[Address(RVA = "0x2A6F9AC", Offset = "0x2A6F9AC", VA = "0x2A6F9AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60187AA")]
	[Address(RVA = "0x2A726E4", Offset = "0x2A726E4", VA = "0x2A726E4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60187AB")]
	[Address(RVA = "0x2A70AA8", Offset = "0x2A70AA8", VA = "0x2A70AA8")]
	private void CCFDLJFEHMA()
	{
	}

	[Token(Token = "0x60187AC")]
	[Address(RVA = "0x2A72D98", Offset = "0x2A72D98", VA = "0x2A72D98")]
	private void CLFGIJEMAGP()
	{
	}

	[Token(Token = "0x60187AD")]
	[Address(RVA = "0x2A708D4", Offset = "0x2A708D4", VA = "0x2A708D4")]
	public void UpdateRange()
	{
	}

	[Token(Token = "0x60187AE")]
	[Address(RVA = "0x2A73668", Offset = "0x2A73668", VA = "0x2A73668")]
	private int CFGEMGOCAJO(int NHJNFPKBBLI, int OGFMNCIGEMB)
	{
		return default(int);
	}

	[Token(Token = "0x60187AF")]
	[Address(RVA = "0x2A73694", Offset = "0x2A73694", VA = "0x2A73694")]
	public void AddSceneGO(SceneSplit PAMPOECJJEC, GameObject HMDCIONAOLC)
	{
	}

	[Token(Token = "0x60187B0")]
	[Address(RVA = "0x2A741EC", Offset = "0x2A741EC", VA = "0x2A741EC", Slot = "4")]
	public void OriginLoaded(string PIFMIHOMLKK)
	{
	}

	[Token(Token = "0x60187B1")]
	[Address(RVA = "0x2A743B4", Offset = "0x2A743B4", VA = "0x2A743B4", Slot = "5")]
	public void OriginUnloaded(string PIFMIHOMLKK)
	{
	}

	[Token(Token = "0x60187B2")]
	[Address(RVA = "0x2A745B4", Offset = "0x2A745B4", VA = "0x2A745B4")]
	private void Update()
	{
	}

	[Token(Token = "0x60187B3")]
	[Address(RVA = "0x2A746B4", Offset = "0x2A746B4", VA = "0x2A746B4")]
	private void JEJHNDGOPPG()
	{
	}

	[Token(Token = "0x60187B4")]
	[Address(RVA = "0x2A74B4C", Offset = "0x2A74B4C", VA = "0x2A74B4C")]
	private IEnumerator ABHBHIJGEDE(SceneSplit PAMPOECJJEC)
	{
		return null;
	}

	[Token(Token = "0x60187B5")]
	[Address(RVA = "0x2A7598C", Offset = "0x2A7598C", VA = "0x2A7598C")]
	private void HFPLAOKLGGM(GameObject OOMGGFABMMJ, string PIFMIHOMLKK)
	{
	}

	[Token(Token = "0x60187B6")]
	[Address(RVA = "0x2A75A3C", Offset = "0x2A75A3C", VA = "0x2A75A3C")]
	private bool KGOEHHKBDHP(int IDNEFEOPGIF)
	{
		return default(bool);
	}

	[Token(Token = "0x60187B7")]
	[Address(RVA = "0x2A75BB4", Offset = "0x2A75BB4", VA = "0x2A75BB4")]
	private bool HLCAPIMLKPF(int IDNEFEOPGIF)
	{
		return default(bool);
	}

	[Token(Token = "0x60187B8")]
	[Address(RVA = "0x2A74BEC", Offset = "0x2A74BEC", VA = "0x2A74BEC")]
	private IEnumerator INMILJNCNGA(SceneSplit PAMPOECJJEC)
	{
		return null;
	}

	[Token(Token = "0x60187B9")]
	[Address(RVA = "0x2A75D2C", Offset = "0x2A75D2C", VA = "0x2A75D2C")]
	private void PACJBODJBBJ()
	{
	}

	[Token(Token = "0x60187BA")]
	[Address(RVA = "0x2A775E0", Offset = "0x2A775E0", VA = "0x2A775E0")]
	public bool CheckIsInStreamerRange(Vector3 FJPIOEOBBAI)
	{
		return default(bool);
	}

	[Token(Token = "0x60187BB")]
	[Address(RVA = "0x2A75E44", Offset = "0x2A75E44", VA = "0x2A75E44")]
	public void CheckPositionTiles()
	{
	}

	[Token(Token = "0x60187BC")]
	[Address(RVA = "0x2A782EC", Offset = "0x2A782EC", VA = "0x2A782EC")]
	private int JLKFGOOLPOD(int HHLONFLCJBL)
	{
		return default(int);
	}

	[Token(Token = "0x60187BD")]
	[Address(RVA = "0x2A77838", Offset = "0x2A77838", VA = "0x2A77838")]
	private void FAGHGMJPBDF()
	{
	}

	[Token(Token = "0x60187BE")]
	[Address(RVA = "0x2A7830C", Offset = "0x2A7830C", VA = "0x2A7830C")]
	private void SceneUnloading()
	{
	}

	[Token(Token = "0x60187BF")]
	[Address(RVA = "0x2A76EDC", Offset = "0x2A76EDC", VA = "0x2A76EDC")]
	public void UnloadUnUsedAssets()
	{
	}

	[Token(Token = "0x60187C0")]
	[Address(RVA = "0x2A766F4", Offset = "0x2A766F4", VA = "0x2A766F4")]
	public void UnloadAllScenes()
	{
	}

	[Token(Token = "0x60187C1")]
	[Address(RVA = "0x2A7B100", Offset = "0x2A7B100", VA = "0x2A7B100")]
	public static void UnloadAssets(Streamer BODCBECMNMH)
	{
	}

	[Token(Token = "0x60187C2")]
	[Address(RVA = "0x2A7B248", Offset = "0x2A7B248", VA = "0x2A7B248")]
	public IEnumerator UnloadAssetsWait()
	{
		return null;
	}

	[Token(Token = "0x60187C3")]
	[Address(RVA = "0x2A7B2B4", Offset = "0x2A7B2B4", VA = "0x2A7B2B4")]
	private bool GFDNGIELGPP(int EGNPPJDAPCA)
	{
		return default(bool);
	}

	[Token(Token = "0x60187C4")]
	[Address(RVA = "0x2A7B5C4", Offset = "0x2A7B5C4", VA = "0x2A7B5C4")]
	private void MAKBOIIDCPM(int EGNPPJDAPCA, bool HFLMPBKJAIL = true)
	{
	}

	[Token(Token = "0x60187C5")]
	[Address(RVA = "0x2A74C8C", Offset = "0x2A74C8C", VA = "0x2A74C8C")]
	private void OMPGFFAAEAB()
	{
	}

	[Token(Token = "0x60187C6")]
	[Address(RVA = "0x2A7B85C", Offset = "0x2A7B85C", VA = "0x2A7B85C")]
	private bool LMCCMFEJOBO(GameObject JEMBDPGAPFD, int EGNPPJDAPCA)
	{
		return default(bool);
	}

	[Token(Token = "0x60187C7")]
	[Address(RVA = "0x2A7BC74", Offset = "0x2A7BC74", VA = "0x2A7BC74")]
	public void RegistABTextureExtraRefCallBack(KEFAODEICHK GHGMACFOJOH)
	{
	}

	[Token(Token = "0x60187C8")]
	[Address(RVA = "0x2A7BD60", Offset = "0x2A7BD60", VA = "0x2A7BD60")]
	public void UnRegistABTextureExtraRefCallBack(KEFAODEICHK GHGMACFOJOH)
	{
	}

	[Token(Token = "0x60187C9")]
	[Address(RVA = "0x2A72CD8", Offset = "0x2A72CD8", VA = "0x2A72CD8")]
	private void HMDEEEAKHLK()
	{
	}

	[Token(Token = "0x60187CA")]
	[Address(RVA = "0x2A732D8", Offset = "0x2A732D8", VA = "0x2A732D8")]
	private bool ICHGLGJHALK()
	{
		return default(bool);
	}

	[Token(Token = "0x60187CB")]
	[Address(RVA = "0x2A7BE4C", Offset = "0x2A7BE4C", VA = "0x2A7BE4C")]
	private void OAONAMMGPEP(GameObject JEMBDPGAPFD, int EGNPPJDAPCA)
	{
	}

	[Token(Token = "0x60187CC")]
	[Address(RVA = "0x2A79984", Offset = "0x2A79984", VA = "0x2A79984")]
	private void PLGFPJEFIJD(int EGNPPJDAPCA)
	{
	}

	[Token(Token = "0x60187CD")]
	[Address(RVA = "0x2A751DC", Offset = "0x2A751DC", VA = "0x2A751DC")]
	private void JIMKNHGJOLL()
	{
	}

	[Token(Token = "0x60187CE")]
	[Address(RVA = "0x2A701E4", Offset = "0x2A701E4", VA = "0x2A701E4")]
	private void LCLPDICLMEK(bool EDGDFGGGLGN)
	{
	}

	[Token(Token = "0x60187CF")]
	[Address(RVA = "0x2A7D630", Offset = "0x2A7D630", VA = "0x2A7D630")]
	public static void SceneNameToPos(SceneCollection ADALJLEMAFI, string IILDPHLMGFM, out int LKAGEGNALIG, out int GCEEHKADJAM, out int DOLFBMLIKBL)
	{
	}

	[Token(Token = "0x60187D0")]
	[Address(RVA = "0x2A7DA74", Offset = "0x2A7DA74", VA = "0x2A7DA74")]
	private void OnDrawGizmosSelected()
	{
	}
}
