using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x2003FD9")]
public class SceneGraphics : MonoSingleton<SceneGraphics>
{
	[Token(Token = "0x2003FDA")]
	public delegate void MPPBPKAPCFN(Material HMNKPBLBCOC);

	[Token(Token = "0x401ADE9")]
	[FieldOffset(Offset = "0xC")]
	public Texture2D m_terrainShadowTex;

	[Token(Token = "0x401ADEA")]
	[FieldOffset(Offset = "0x10")]
	public List<GameObject> m_waterGO;

	[Token(Token = "0x401ADEB")]
	[FieldOffset(Offset = "0x14")]
	private List<Material> EOJNPBGCMGK;

	[Token(Token = "0x401ADEC")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 m_lightDirection;

	[Token(Token = "0x401ADED")]
	[FieldOffset(Offset = "0x24")]
	public Vector4 m_waterPosition;

	[Token(Token = "0x401ADEE")]
	[FieldOffset(Offset = "0x34")]
	public float m_mapWidth;

	[Token(Token = "0x401ADEF")]
	[FieldOffset(Offset = "0x38")]
	public float m_mapHeight;

	[Token(Token = "0x401ADF0")]
	[FieldOffset(Offset = "0x3C")]
	public float m_mapStartPosX;

	[Token(Token = "0x401ADF1")]
	[FieldOffset(Offset = "0x40")]
	public float m_mapStartPosZ;

	[Token(Token = "0x401ADF2")]
	[FieldOffset(Offset = "0x44")]
	public float m_mapCenterX;

	[Token(Token = "0x401ADF3")]
	[FieldOffset(Offset = "0x48")]
	public float m_mapCenterZ;

	[Token(Token = "0x401ADF4")]
	[FieldOffset(Offset = "0x4C")]
	public float m_shadowSizeX;

	[Token(Token = "0x401ADF5")]
	[FieldOffset(Offset = "0x50")]
	public float m_shadowSizeZ;

	[Token(Token = "0x401ADF6")]
	[FieldOffset(Offset = "0x54")]
	public bool m_forceOffFogSwitch;

	[Token(Token = "0x401ADF7")]
	[FieldOffset(Offset = "0x58")]
	public float m_landFogStartDensity;

	[Token(Token = "0x401ADF8")]
	[FieldOffset(Offset = "0x5C")]
	public float m_landFogEndDensity;

	[Token(Token = "0x401ADF9")]
	[FieldOffset(Offset = "0x60")]
	public float m_landFogSwitchHeight;

	[Token(Token = "0x401ADFA")]
	[FieldOffset(Offset = "0x64")]
	public float m_landFogSwitchSpeed;

	[Token(Token = "0x401ADFB")]
	[FieldOffset(Offset = "0x68")]
	private int IEJNMNDMIDO;

	[Token(Token = "0x401ADFC")]
	[FieldOffset(Offset = "0x6C")]
	private float HHOGJJBHJOD;

	[Token(Token = "0x401ADFD")]
	[FieldOffset(Offset = "0x70")]
	public bool m_fogDistantSwitch;

	[Token(Token = "0x401ADFE")]
	[FieldOffset(Offset = "0x74")]
	public float m_fogDistantSwitchSpeed;

	[Token(Token = "0x401ADFF")]
	[FieldOffset(Offset = "0x78")]
	public float m_skyFogDistantStart;

	[Token(Token = "0x401AE00")]
	[FieldOffset(Offset = "0x7C")]
	public float m_skyFogDistantEnd;

	[Token(Token = "0x401AE01")]
	[FieldOffset(Offset = "0x80")]
	public float m_landFogDistantStart;

	[Token(Token = "0x401AE02")]
	[FieldOffset(Offset = "0x84")]
	public float m_landFogDistantEnd;

	[Token(Token = "0x401AE03")]
	[FieldOffset(Offset = "0x88")]
	private int DFLLEJCOBAC;

	[Token(Token = "0x401AE04")]
	[FieldOffset(Offset = "0x8C")]
	private int INIKNMDFPAJ;

	[Token(Token = "0x401AE05")]
	[FieldOffset(Offset = "0x90")]
	private float MPNNOEIJABM;

	[Token(Token = "0x401AE06")]
	[FieldOffset(Offset = "0x94")]
	private float FNDDEHPLOAO;

	[Token(Token = "0x401AE07")]
	[FieldOffset(Offset = "0x98")]
	private bool HLGHNGOLOBC;

	[Token(Token = "0x401AE08")]
	[FieldOffset(Offset = "0x9C")]
	public float m_vegPreviewHeight;

	[Token(Token = "0x401AE09")]
	[FieldOffset(Offset = "0xA0")]
	public int m_treeGroupPSNum;

	[Token(Token = "0x401AE0A")]
	[FieldOffset(Offset = "0xA4")]
	public bool m_isInVegPreview;

	[Token(Token = "0x401AE0B")]
	[FieldOffset(Offset = "0xA8")]
	public Texture2D lutTexture;

	[Token(Token = "0x401AE0C")]
	[FieldOffset(Offset = "0xAC")]
	public Color skyboxColor;

	[Token(Token = "0x401AE0D")]
	[FieldOffset(Offset = "0xBC")]
	public float charaLightIntensityOff;

	[Token(Token = "0x401AE0E")]
	[FieldOffset(Offset = "0xC0")]
	public float charaLightIntensityOn;

	[Token(Token = "0x401AE0F")]
	[FieldOffset(Offset = "0xC4")]
	private GameObject DNHJLJJDKGA;

	[Token(Token = "0x401AE10")]
	[FieldOffset(Offset = "0xC8")]
	public Texture2D characterDissolveTex;

	[Token(Token = "0x401AE11")]
	[FieldOffset(Offset = "0xCC")]
	public Vector4 characterDissolveTex_ST;

	[Token(Token = "0x401AE12")]
	[FieldOffset(Offset = "0xDC")]
	public Color characterDissolveCol;

	[Token(Token = "0x401AE13")]
	[FieldOffset(Offset = "0xEC")]
	public List<DynamicGeneratorGroup> m_dynamicGenGroupList;

	[Token(Token = "0x401AE14")]
	[FieldOffset(Offset = "0xF0")]
	private Camera CPHNMPKFICJ;

	[Token(Token = "0x401AE15")]
	[FieldOffset(Offset = "0xF4")]
	private float BGNJFMLPMEF;

	[Token(Token = "0x401AE16")]
	[FieldOffset(Offset = "0xF8")]
	private float DLHMDHBHPAP;

	[Token(Token = "0x401AE17")]
	[FieldOffset(Offset = "0xFC")]
	public float m_waterTransThres;

	[Token(Token = "0x401AE18")]
	[FieldOffset(Offset = "0x100")]
	private bool OCEKLEBEHML;

	[Token(Token = "0x401AE19")]
	[FieldOffset(Offset = "0x104")]
	public GameObject m_farWaterGO;

	[Token(Token = "0x401AE1A")]
	[FieldOffset(Offset = "0x108")]
	public Color m_farWaterColor;

	[Token(Token = "0x401AE1B")]
	[FieldOffset(Offset = "0x118")]
	private Material FAJFGIBMHIJ;

	[Token(Token = "0x401AE1C")]
	[FieldOffset(Offset = "0x11C")]
	public float m_farWaterFadeSpeed;

	[Token(Token = "0x401AE1D")]
	[FieldOffset(Offset = "0x120")]
	private float DALDBICHDGK;

	[Token(Token = "0x401AE1E")]
	[FieldOffset(Offset = "0x124")]
	private bool KNOAMCGEKCH;

	[Token(Token = "0x401AE1F")]
	[FieldOffset(Offset = "0x128")]
	private GameObject BGDGCJELIFO;

	[Token(Token = "0x401AE20")]
	[FieldOffset(Offset = "0x12C")]
	private Color HNKLBGLAFJL;

	[Token(Token = "0x401AE21")]
	[FieldOffset(Offset = "0x13C")]
	private BFPFFNANJAM DMCAKMHMNIF;

	[Token(Token = "0x401AE22")]
	[FieldOffset(Offset = "0x140")]
	private FOFJEMOKAOH DEIMGFGFALM;

	[Token(Token = "0x401AE23")]
	[FieldOffset(Offset = "0x144")]
	private bool _003CCPKAMPCCFPD_003Ek__BackingField;

	[Token(Token = "0x401AE24")]
	[FieldOffset(Offset = "0x145")]
	private bool _003CNDEPDOCIAAB_003Ek__BackingField;

	[Token(Token = "0x401AE25")]
	[FieldOffset(Offset = "0x148")]
	private GAGILKKDDMJ ODFJIKDBNNN;

	[Token(Token = "0x401AE26")]
	[FieldOffset(Offset = "0x14C")]
	public GameObject m_treeOrnamentGO;

	[Token(Token = "0x401AE27")]
	[FieldOffset(Offset = "0x150")]
	private Material NMPIADBGLEE;

	[Token(Token = "0x401AE28")]
	[FieldOffset(Offset = "0x154")]
	private Transform KMBCOJEBOMI;

	[Token(Token = "0x401AE29")]
	[FieldOffset(Offset = "0x158")]
	private GameObject ODHNFPGOKOG;

	[Token(Token = "0x401AE2A")]
	[FieldOffset(Offset = "0x15C")]
	private ParticleSystem NFBKPGPBKBB;

	[Token(Token = "0x401AE2B")]
	[FieldOffset(Offset = "0x160")]
	private bool PNGKBODJPAB;

	[Token(Token = "0x401AE2C")]
	[FieldOffset(Offset = "0x161")]
	public bool m_isNightMode;

	[Token(Token = "0x401AE2D")]
	[FieldOffset(Offset = "0x162")]
	public bool m_forceOffNightMode;

	[Token(Token = "0x401AE2E")]
	[FieldOffset(Offset = "0x163")]
	public bool m_isDawnMode;

	[Token(Token = "0x401AE2F")]
	[FieldOffset(Offset = "0x164")]
	public bool m_forceOffDawnMode;

	[Token(Token = "0x401AE30")]
	[FieldOffset(Offset = "0x165")]
	public bool m_isSnowMode;

	[Token(Token = "0x401AE31")]
	[FieldOffset(Offset = "0x166")]
	public bool m_forceOffSnowMode;

	[Token(Token = "0x401AE32")]
	[FieldOffset(Offset = "0x168")]
	public Material m_treeShadowMat;

	[Token(Token = "0x401AE33")]
	[FieldOffset(Offset = "0x16C")]
	private bool HLFANPFIMGI;

	[Token(Token = "0x401AE34")]
	[FieldOffset(Offset = "0x170")]
	public Vector4 m_backLightDir;

	[Token(Token = "0x401AE35")]
	[FieldOffset(Offset = "0x180")]
	public Color m_backLightColor;

	[Token(Token = "0x401AE36")]
	[FieldOffset(Offset = "0x190")]
	public Color m_shadowColor;

	[Token(Token = "0x401AE37")]
	[FieldOffset(Offset = "0x1A0")]
	public GameObject m_terrainGO;

	[Token(Token = "0x401AE38")]
	[FieldOffset(Offset = "0x1A4")]
	private Renderer[] ABIAKHKLPIC;

	[Token(Token = "0x401AE39")]
	[FieldOffset(Offset = "0x1A8")]
	public GameObject m_terrainGOPreview;

	[Token(Token = "0x401AE3A")]
	[FieldOffset(Offset = "0x1AC")]
	public GameObject m_cloudGOPreview;

	[Token(Token = "0x401AE3B")]
	[FieldOffset(Offset = "0x1B0")]
	public GameObject m_buildingGOPreview;

	[Token(Token = "0x401AE3C")]
	[FieldOffset(Offset = "0x1B4")]
	public float m_switchTerrainHeightStart;

	[Token(Token = "0x401AE3D")]
	[FieldOffset(Offset = "0x1B8")]
	public float m_switchTerrainHeightEnd;

	[Token(Token = "0x401AE3E")]
	[FieldOffset(Offset = "0x1BC")]
	private Dictionary<Material, Texture> MOGCPAAFEFN;

	[Token(Token = "0x401AE3F")]
	[FieldOffset(Offset = "0x1C0")]
	private Dictionary<string, Texture> HKOOEHNIIGO;

	[Token(Token = "0x401AE40")]
	[FieldOffset(Offset = "0x1C4")]
	private List<Material> KEMKBOPHJMM;

	[Token(Token = "0x401AE41")]
	[FieldOffset(Offset = "0x1C8")]
	public Material m_terrainMatPreview;

	[Token(Token = "0x401AE42")]
	[FieldOffset(Offset = "0x1CC")]
	public Material m_terrainMatPreviewOpaque;

	[Token(Token = "0x401AE43")]
	[FieldOffset(Offset = "0x1D0")]
	public float m_blendingInnerRadius;

	[Token(Token = "0x401AE44")]
	[FieldOffset(Offset = "0x1D4")]
	public float m_blendingOuterRadius;

	[Token(Token = "0x401AE45")]
	[FieldOffset(Offset = "0x1D8")]
	private Material GBCNODKBDOF;

	[Token(Token = "0x401AE46")]
	[FieldOffset(Offset = "0x1DC")]
	private Material[] DMJNKLAAKFL;

	[Token(Token = "0x401AE47")]
	[FieldOffset(Offset = "0x1E0")]
	private bool DJKODMIJAKI;

	[Token(Token = "0x401AE48")]
	[FieldOffset(Offset = "0x1E1")]
	private bool JJJLHNMNCIA;

	[Token(Token = "0x401AE49")]
	[FieldOffset(Offset = "0x1E2")]
	private bool BDIIAMELFBF;

	[Token(Token = "0x401AE4A")]
	[FieldOffset(Offset = "0x1E4")]
	public GameObject m_sandStormGO;

	[Token(Token = "0x401AE4B")]
	[FieldOffset(Offset = "0x1E8")]
	private ParticleSystem INJEKEJNKII;

	[Token(Token = "0x401AE4C")]
	[FieldOffset(Offset = "0x1EC")]
	private bool OPNKAGJIOJO;

	[Token(Token = "0x401AE4D")]
	[FieldOffset(Offset = "0x1F0")]
	public float m_lowestFogDensity;

	[Token(Token = "0x401AE4E")]
	[FieldOffset(Offset = "0x1F4")]
	public bool m_IsDesertMap;

	[Token(Token = "0x401AE4F")]
	[FieldOffset(Offset = "0x1F5")]
	public bool m_IsNeoParadiseMap;

	[Token(Token = "0x401AE50")]
	[FieldOffset(Offset = "0x1F6")]
	public bool m_IsWereWolvesMap;

	[Token(Token = "0x401AE51")]
	[FieldOffset(Offset = "0x1F8")]
	private Material LLLKODOMLKA;

	[Token(Token = "0x401AE52")]
	[FieldOffset(Offset = "0x0")]
	public static bool m_nightModeSwitch;

	[Token(Token = "0x401AE53")]
	[FieldOffset(Offset = "0x1")]
	public static bool m_dawnModeSwitch;

	[Token(Token = "0x401AE54")]
	[FieldOffset(Offset = "0x2")]
	public static bool m_snowModeSwitch;

	[Token(Token = "0x401AE55")]
	[FieldOffset(Offset = "0x3")]
	public static bool m_hdModeSwitch;

	[Token(Token = "0x401AE56")]
	[FieldOffset(Offset = "0x1FC")]
	private Dictionary<string, TextureOverride> HPKBCAMDMJO;

	[Token(Token = "0x401AE57")]
	[FieldOffset(Offset = "0x200")]
	private HashSet<BFPFFNANJAM.NLCFNILHPCC> BGNICGBKBGK;

	[Token(Token = "0x401AE58")]
	[FieldOffset(Offset = "0x204")]
	private string DELFBDMKKKM;

	[Token(Token = "0x401AE59")]
	[FieldOffset(Offset = "0x208")]
	private HashSet<NetworkMaterialInfo> HFAGCAHKFBL;

	[Token(Token = "0x401AE5A")]
	[FieldOffset(Offset = "0x20C")]
	private Dictionary<int, HashSet<NetworkMaterialInfo>> JFLBLDPEJEM;

	[Token(Token = "0x401AE5B")]
	[FieldOffset(Offset = "0x210")]
	private bool BLMNDCACMMO;

	[Token(Token = "0x401AE5C")]
	[FieldOffset(Offset = "0x214")]
	private ENetworkMaterialGroup AEOCMIGLHCD;

	[Token(Token = "0x401AE5D")]
	[FieldOffset(Offset = "0x218")]
	public MPPBPKAPCFN InitTerrainPreviewProc;

	[Token(Token = "0x401AE5E")]
	[FieldOffset(Offset = "0x21C")]
	public MPPBPKAPCFN PrepareTerrainPreviewOpaqueMatProc;

	[Token(Token = "0x401AE5F")]
	[FieldOffset(Offset = "0x220")]
	public MPPBPKAPCFN TerrainPreviewBlendMatProc;

	[Token(Token = "0x401AE60")]
	[FieldOffset(Offset = "0x224")]
	public MPPBPKAPCFN ResumeTerrainMatProc;

	[Token(Token = "0x401AE61")]
	[FieldOffset(Offset = "0x228")]
	public MPPBPKAPCFN NoPreviewInitTerrainProc;

	[Token(Token = "0x401AE62")]
	[FieldOffset(Offset = "0x22C")]
	private CameraReflection FBDLLDBMACL;

	[Token(Token = "0x401AE63")]
	[FieldOffset(Offset = "0x230")]
	public TreeSystem CurTreeSystem;

	[Token(Token = "0x401AE64")]
	[FieldOffset(Offset = "0x234")]
	public GrassSystem CurGrassSystem;

	[Token(Token = "0x401AE65")]
	[FieldOffset(Offset = "0x238")]
	public VegetationManager CurVegetationManager;

	[Token(Token = "0x401AE66")]
	[FieldOffset(Offset = "0x23C")]
	private int KGGGJDBANEP;

	[Token(Token = "0x401AE67")]
	[FieldOffset(Offset = "0x240")]
	private int GMALICKJFKJ;

	[Token(Token = "0x401AE68")]
	[FieldOffset(Offset = "0x244")]
	private int EEMLNDLMDKD;

	[Token(Token = "0x401AE69")]
	[FieldOffset(Offset = "0x248")]
	private int FNMCKDIACNL;

	[Token(Token = "0x401AE6A")]
	[FieldOffset(Offset = "0x24C")]
	private int FLNBPGEPIPJ;

	[Token(Token = "0x401AE6B")]
	[FieldOffset(Offset = "0x250")]
	private int DHHENDBPHGP;

	[Token(Token = "0x401AE6C")]
	[FieldOffset(Offset = "0x254")]
	private int CAHCAKNGBHM;

	[Token(Token = "0x401AE6D")]
	[FieldOffset(Offset = "0x258")]
	private int OCCNIOHMMOL;

	[Token(Token = "0x401AE6E")]
	[FieldOffset(Offset = "0x25C")]
	private int OEPEMPONHAB;

	[Token(Token = "0x17001C5B")]
	public bool LGNLFNNALPE
	{
		[Token(Token = "0x6019FC3")]
		[Address(RVA = "0x1D30F84", Offset = "0x1D30F84", VA = "0x1D30F84")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6019FC4")]
		[Address(RVA = "0x1D30F8C", Offset = "0x1D30F8C", VA = "0x1D30F8C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001C5C")]
	public bool FHOGGMJKEAB
	{
		[Token(Token = "0x6019FC5")]
		[Address(RVA = "0x1D30F94", Offset = "0x1D30F94", VA = "0x1D30F94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6019FC6")]
		[Address(RVA = "0x1D30F9C", Offset = "0x1D30F9C", VA = "0x1D30F9C")]
		private set
		{
		}
	}

	[Token(Token = "0x6019FC2")]
	[Address(RVA = "0x1D30B18", Offset = "0x1D30B18", VA = "0x1D30B18")]
	public SceneGraphics()
	{
	}

	[Token(Token = "0x6019FC7")]
	[Address(RVA = "0x1D30FA4", Offset = "0x1D30FA4", VA = "0x1D30FA4")]
	public static bool IsProcValid(MPPBPKAPCFN ENFMBOOLEIL)
	{
		return default(bool);
	}

	[Token(Token = "0x6019FC8")]
	[Address(RVA = "0x1D30FF0", Offset = "0x1D30FF0", VA = "0x1D30FF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6019FC9")]
	[Address(RVA = "0x1D33B28", Offset = "0x1D33B28", VA = "0x1D33B28")]
	private void BLNKNAFIFBI()
	{
	}

	[Token(Token = "0x6019FCA")]
	[Address(RVA = "0x1D311EC", Offset = "0x1D311EC", VA = "0x1D311EC")]
	private void GMJJCMFKJKB()
	{
	}

	[Token(Token = "0x6019FCB")]
	[Address(RVA = "0x1D31318", Offset = "0x1D31318", VA = "0x1D31318")]
	private void NJPIMJHNJNM()
	{
	}

	[Token(Token = "0x6019FCC")]
	[Address(RVA = "0x1D32AE4", Offset = "0x1D32AE4", VA = "0x1D32AE4")]
	private void CIBONOKEGFJ()
	{
	}

	[Token(Token = "0x6019FCD")]
	[Address(RVA = "0x1D33BB4", Offset = "0x1D33BB4", VA = "0x1D33BB4")]
	private void FFAKJHGALPA()
	{
	}

	[Token(Token = "0x6019FCE")]
	[Address(RVA = "0x1D32038", Offset = "0x1D32038", VA = "0x1D32038")]
	private void GEPFHMHJBEC()
	{
	}

	[Token(Token = "0x6019FCF")]
	[Address(RVA = "0x1D34A70", Offset = "0x1D34A70", VA = "0x1D34A70")]
	private GameObject ADICDGADBMJ()
	{
		return null;
	}

	[Token(Token = "0x6019FD0")]
	[Address(RVA = "0x1D34848", Offset = "0x1D34848", VA = "0x1D34848")]
	private void BOFIAPLOJEF()
	{
	}

	[Token(Token = "0x6019FD1")]
	[Address(RVA = "0x1D34BE8", Offset = "0x1D34BE8", VA = "0x1D34BE8")]
	private void EDJJPFNJBPK()
	{
	}

	[Token(Token = "0x6019FD2")]
	[Address(RVA = "0x1D34E10", Offset = "0x1D34E10", VA = "0x1D34E10")]
	private void ELPOEFKBKHA()
	{
	}

	[Token(Token = "0x6019FD3")]
	[Address(RVA = "0x1D3203C", Offset = "0x1D3203C", VA = "0x1D3203C")]
	private void EEHBLAAJGFH()
	{
	}

	[Token(Token = "0x6019FD4")]
	[Address(RVA = "0x1D32040", Offset = "0x1D32040", VA = "0x1D32040")]
	private void ACHMCKMDOGJ()
	{
	}

	[Token(Token = "0x6019FD5")]
	[Address(RVA = "0x1D329C4", Offset = "0x1D329C4", VA = "0x1D329C4")]
	private void KAAFNECFCGN()
	{
	}

	[Token(Token = "0x6019FD6")]
	[Address(RVA = "0x1D339A0", Offset = "0x1D339A0", VA = "0x1D339A0")]
	public void InitDesertEffect()
	{
	}

	[Token(Token = "0x6019FD7")]
	[Address(RVA = "0x1D33C84", Offset = "0x1D33C84", VA = "0x1D33C84")]
	public void EnableCharacterBackLight()
	{
	}

	[Token(Token = "0x6019FD8")]
	[Address(RVA = "0x1D35354", Offset = "0x1D35354", VA = "0x1D35354")]
	public void DisableCharacterBackLight()
	{
	}

	[Token(Token = "0x6019FD9")]
	[Address(RVA = "0x1D33D90", Offset = "0x1D33D90", VA = "0x1D33D90")]
	public void SetCharacterDissolve()
	{
	}

	[Token(Token = "0x6019FDA")]
	[Address(RVA = "0x1D33BD8", Offset = "0x1D33BD8", VA = "0x1D33BD8")]
	public void InitItemOutline()
	{
	}

	[Token(Token = "0x6019FDB")]
	[Address(RVA = "0x1D33E48", Offset = "0x1D33E48", VA = "0x1D33E48")]
	public void InitSceneLensFlares()
	{
	}

	[Token(Token = "0x6019FDC")]
	[Address(RVA = "0x1D33FD0", Offset = "0x1D33FD0", VA = "0x1D33FD0")]
	private void GECPOIIMJOL()
	{
	}

	[Token(Token = "0x6019FDD")]
	[Address(RVA = "0x1D347AC", Offset = "0x1D347AC", VA = "0x1D347AC")]
	public void CreateDynamicManager()
	{
	}

	[Token(Token = "0x6019FDE")]
	[Address(RVA = "0x1D35454", Offset = "0x1D35454", VA = "0x1D35454")]
	public void InitRegionActDynamicList(string[] NFBGBDLMHKN)
	{
	}

	[Token(Token = "0x6019FDF")]
	[Address(RVA = "0x1D3588C", Offset = "0x1D3588C", VA = "0x1D3588C", Slot = "6")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6019FE0")]
	[Address(RVA = "0x1D35DC8", Offset = "0x1D35DC8", VA = "0x1D35DC8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6019FE1")]
	[Address(RVA = "0x1D31750", Offset = "0x1D31750", VA = "0x1D31750")]
	public void SetLUTEffect(EInGameFilterSetting EBFOKDMNABH, [Optional] Camera KFGFLKFGPBA)
	{
	}

	[Token(Token = "0x6019FE2")]
	[Address(RVA = "0x1D374F8", Offset = "0x1D374F8", VA = "0x1D374F8")]
	public void SetBloomEnable(bool MCDIDHODHLN)
	{
	}

	[Token(Token = "0x6019FE3")]
	[Address(RVA = "0x1D3631C", Offset = "0x1D3631C", VA = "0x1D3631C")]
	private void DHCEKGNNAMF()
	{
	}

	[Token(Token = "0x6019FE4")]
	[Address(RVA = "0x1D37798", Offset = "0x1D37798", VA = "0x1D37798")]
	private void CCHLBBAPECB(float BAPAKNFHKHP)
	{
	}

	[Token(Token = "0x6019FE5")]
	[Address(RVA = "0x1D3790C", Offset = "0x1D3790C", VA = "0x1D3790C")]
	private void AAMPFEPEJPP(float BAPAKNFHKHP)
	{
	}

	[Token(Token = "0x6019FE6")]
	[Address(RVA = "0x1D37BE8", Offset = "0x1D37BE8", VA = "0x1D37BE8")]
	private void HGPHGJKFJJG(float BAPAKNFHKHP)
	{
	}

	[Token(Token = "0x6019FE7")]
	[Address(RVA = "0x1D3853C", Offset = "0x1D3853C", VA = "0x1D3853C")]
	private void CAGJFPEEKEB()
	{
	}

	[Token(Token = "0x6019FE8")]
	[Address(RVA = "0x1D3696C", Offset = "0x1D3696C", VA = "0x1D3696C")]
	private void JPGKNKMHCIJ()
	{
	}

	[Token(Token = "0x6019FE9")]
	[Address(RVA = "0x1D35F78", Offset = "0x1D35F78", VA = "0x1D35F78")]
	private void BGEBNHLFLEB()
	{
	}

	[Token(Token = "0x6019FEA")]
	[Address(RVA = "0x1D37050", Offset = "0x1D37050", VA = "0x1D37050")]
	private void AAIJKCJLKMG()
	{
	}

	[Token(Token = "0x6019FEB")]
	[Address(RVA = "0x1D38AA0", Offset = "0x1D38AA0", VA = "0x1D38AA0")]
	private void MHECKKDBDJF()
	{
	}

	[Token(Token = "0x6019FEC")]
	[Address(RVA = "0x1D38D74", Offset = "0x1D38D74", VA = "0x1D38D74")]
	private void BIGBDNECMOM()
	{
	}

	[Token(Token = "0x6019FED")]
	[Address(RVA = "0x1D38EA8", Offset = "0x1D38EA8", VA = "0x1D38EA8")]
	private void LKHKOHMNPLE()
	{
	}

	[Token(Token = "0x6019FEE")]
	[Address(RVA = "0x1D37054", Offset = "0x1D37054", VA = "0x1D37054")]
	private void MMMOCCABGOG()
	{
	}

	[Token(Token = "0x6019FEF")]
	[Address(RVA = "0x1D37188", Offset = "0x1D37188", VA = "0x1D37188")]
	private void GBKDGABIAJN()
	{
	}

	[Token(Token = "0x6019FF0")]
	[Address(RVA = "0x1D37FFC", Offset = "0x1D37FFC", VA = "0x1D37FFC")]
	private void BKIOONDGHKN()
	{
	}

	[Token(Token = "0x6019FF1")]
	[Address(RVA = "0x1D3939C", Offset = "0x1D3939C", VA = "0x1D3939C")]
	private void JMNMIIHOOGC()
	{
	}

	[Token(Token = "0x6019FF2")]
	[Address(RVA = "0x1D3762C", Offset = "0x1D3762C", VA = "0x1D3762C")]
	private void LNCMDFCKHFO()
	{
	}

	[Token(Token = "0x6019FF3")]
	[Address(RVA = "0x1D345A8", Offset = "0x1D345A8", VA = "0x1D345A8")]
	private bool OFACDKKOCEH()
	{
		return default(bool);
	}

	[Token(Token = "0x6019FF4")]
	[Address(RVA = "0x1D39640", Offset = "0x1D39640", VA = "0x1D39640")]
	private void GHBOECOFNCK()
	{
	}

	[Token(Token = "0x6019FF5")]
	[Address(RVA = "0x1D37430", Offset = "0x1D37430", VA = "0x1D37430")]
	private void MOPEGBKOFIK()
	{
	}

	[Token(Token = "0x6019FF6")]
	[Address(RVA = "0x1D35AEC", Offset = "0x1D35AEC", VA = "0x1D35AEC")]
	public void SetCameraPerspective(bool JBPPGEAJPNL)
	{
	}

	[Token(Token = "0x6019FF7")]
	[Address(RVA = "0x1D39758", Offset = "0x1D39758", VA = "0x1D39758")]
	public void SetCameraPerspectiveColor(bool JEBCKDCKAAB)
	{
	}

	[Token(Token = "0x6019FF8")]
	[Address(RVA = "0x1D397D4", Offset = "0x1D397D4", VA = "0x1D397D4")]
	public void RegistTextureOverride(string HINJBPEDIAL, TextureOverride JKBLBBGKPNI)
	{
	}

	[Token(Token = "0x6019FF9")]
	[Address(RVA = "0x1D39894", Offset = "0x1D39894", VA = "0x1D39894")]
	public void RegistDynamicPrefabMesh(BFPFFNANJAM.NLCFNILHPCC AGCKDHMPOLH)
	{
	}

	[Token(Token = "0x6019FFA")]
	[Address(RVA = "0x1D39964", Offset = "0x1D39964", VA = "0x1D39964")]
	public void RegistNetworkMaterials(HashSet<NetworkMaterialInfo> ILGKCKEGIBJ, ENetworkMaterialGroup FPLGALIMBEG)
	{
	}

	[Token(Token = "0x6019FFB")]
	[Address(RVA = "0x1D39CF0", Offset = "0x1D39CF0", VA = "0x1D39CF0")]
	public void OnRegionActiveTypeChanged()
	{
	}

	[Token(Token = "0x6019FFC")]
	[Address(RVA = "0x1D39F00", Offset = "0x1D39F00", VA = "0x1D39F00")]
	public void ApplyTextureOverrideType()
	{
	}

	[Token(Token = "0x6019FFD")]
	[Address(RVA = "0x1D39D14", Offset = "0x1D39D14", VA = "0x1D39D14")]
	public void RefreshDynamicPrefabMeshVisible()
	{
	}

	[Token(Token = "0x6019FFE")]
	[Address(RVA = "0x1D3AADC", Offset = "0x1D3AADC", VA = "0x1D3AADC")]
	public void ApplyTrainingBillBoard()
	{
	}

	[Token(Token = "0x6019FFF")]
	[Address(RVA = "0x1D3AD68", Offset = "0x1D3AD68", VA = "0x1D3AD68")]
	public void OnTriningBillBoardCDNFinish(Texture2D KANJOBFCAIN)
	{
	}

	[Token(Token = "0x601A000")]
	[Address(RVA = "0x1D3A144", Offset = "0x1D3A144", VA = "0x1D3A144")]
	public void ApplyBillboardCDNUrl()
	{
	}

	[Token(Token = "0x601A001")]
	[Address(RVA = "0x1D3B138", Offset = "0x1D3B138", VA = "0x1D3B138")]
	public void ApplyArenaScreenCDNUrl()
	{
	}

	[Token(Token = "0x601A002")]
	[Address(RVA = "0x1D3AF18", Offset = "0x1D3AF18", VA = "0x1D3AF18")]
	public void StartDownloadTexture()
	{
	}

	[Token(Token = "0x601A003")]
	[Address(RVA = "0x1D35C80", Offset = "0x1D35C80", VA = "0x1D35C80")]
	public void CancelDownloadTexture()
	{
	}

	[Token(Token = "0x601A004")]
	[Address(RVA = "0x1D3B370", Offset = "0x1D3B370", VA = "0x1D3B370")]
	public void OnDownloadedTexture(Texture2D FDECBPKGFKA)
	{
	}

	[Token(Token = "0x601A005")]
	[Address(RVA = "0x1D3B5B0", Offset = "0x1D3B5B0", VA = "0x1D3B5B0")]
	public static void ChangeToPreZShader(ref Material JIJPDPPFEMG)
	{
	}

	[Token(Token = "0x601A006")]
	[Address(RVA = "0x1D3B76C", Offset = "0x1D3B76C", VA = "0x1D3B76C")]
	public static void ChangeToPreZV2Shader(ref Material JIJPDPPFEMG, out Material MPNMPKEGDIB)
	{
	}

	[Token(Token = "0x601A007")]
	[Address(RVA = "0x1D3BA2C", Offset = "0x1D3BA2C", VA = "0x1D3BA2C")]
	public void OnCameraChanged(Camera GNKJBPHOOIB)
	{
	}

	[Token(Token = "0x601A008")]
	[Address(RVA = "0x1D3BC2C", Offset = "0x1D3BC2C", VA = "0x1D3BC2C")]
	public void OnCameraUpdated()
	{
	}

	[Token(Token = "0x601A009")]
	[Address(RVA = "0x1D3BC30", Offset = "0x1D3BC30", VA = "0x1D3BC30")]
	public void OnScreenShotRendering()
	{
	}

	[Token(Token = "0x601A00A")]
	[Address(RVA = "0x1D3BD4C", Offset = "0x1D3BD4C", VA = "0x1D3BD4C")]
	public void OnSceneLoaded()
	{
	}

	[Token(Token = "0x601A00B")]
	[Address(RVA = "0x1D3BE00", Offset = "0x1D3BE00", VA = "0x1D3BE00")]
	public void RecordStreamerCollider()
	{
	}

	[Token(Token = "0x601A00C")]
	[Address(RVA = "0x1D3BE10", Offset = "0x1D3BE10", VA = "0x1D3BE10")]
	public void DeRecordStreamerCollider()
	{
	}

	[Token(Token = "0x601A00D")]
	[Address(RVA = "0x1D3BE28", Offset = "0x1D3BE28", VA = "0x1D3BE28")]
	public int GetStreamerColliderCount()
	{
		return default(int);
	}

	[Token(Token = "0x601A00E")]
	[Address(RVA = "0x1D3BE30", Offset = "0x1D3BE30", VA = "0x1D3BE30")]
	public bool IsSwitchingTerrain()
	{
		return default(bool);
	}
}
