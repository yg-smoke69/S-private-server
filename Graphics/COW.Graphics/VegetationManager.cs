using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x200403E")]
public class VegetationManager : MonoBehaviour
{
	[Token(Token = "0x200403F")]
	public enum CDENNEABJCM
	{
		[Token(Token = "0x401B0B7")]
		Veg_Grass,
		[Token(Token = "0x401B0B8")]
		Veg_Tree,
		[Token(Token = "0x401B0B9")]
		Veg_Total
	}

	[Serializable]
	[Token(Token = "0x2004040")]
	public class DistributionData
	{
		[Token(Token = "0x401B0BA")]
		[FieldOffset(Offset = "0x8")]
		public int m_meshID;

		[Token(Token = "0x401B0BB")]
		[FieldOffset(Offset = "0xC")]
		public CDENNEABJCM m_type;

		[Token(Token = "0x401B0BC")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 m_position;

		[Token(Token = "0x401B0BD")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 m_direction;

		[Token(Token = "0x401B0BE")]
		[FieldOffset(Offset = "0x28")]
		public Quaternion m_rotation;

		[Token(Token = "0x401B0BF")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 m_boundMin;

		[Token(Token = "0x401B0C0")]
		[FieldOffset(Offset = "0x40")]
		public Vector2 m_boundMax;

		[Token(Token = "0x401B0C1")]
		[FieldOffset(Offset = "0x48")]
		public short m_colorID;

		[Token(Token = "0x401B0C2")]
		[FieldOffset(Offset = "0x4A")]
		public short m_scaleID;

		[Token(Token = "0x601A2A2")]
		[Address(RVA = "0x120CDAC", Offset = "0x120CDAC", VA = "0x120CDAC")]
		public DistributionData(int AOPBBDLPDGL, CDENNEABJCM PMGBACFJIHO, Vector3 ACCOJJMKKPM, Vector3 COCOBLKAIMJ, Quaternion LCMDGPINKAO, Bounds GMDFLOLJBNE)
		{
		}
	}

	[Token(Token = "0x2004041")]
	public class OHIOKAOHMJL
	{
		[Token(Token = "0x401B0C3")]
		[FieldOffset(Offset = "0x8")]
		public float JMFPIDCOBJE;

		[Token(Token = "0x401B0C4")]
		[FieldOffset(Offset = "0xC")]
		public byte EBCBMPDEFHE;

		[Token(Token = "0x401B0C5")]
		[FieldOffset(Offset = "0xD")]
		public byte JILHILJOODN;

		[Token(Token = "0x401B0C6")]
		[FieldOffset(Offset = "0xE")]
		public byte KKFJKCLEMCM;

		[Token(Token = "0x401B0C7")]
		[FieldOffset(Offset = "0xF")]
		public byte IPGFJMEJEGA;

		[Token(Token = "0x401B0C8")]
		[FieldOffset(Offset = "0x10")]
		public int LBNKLLACNKA;

		[Token(Token = "0x401B0C9")]
		[FieldOffset(Offset = "0x14")]
		public float HOONEEKFDJK;

		[Token(Token = "0x401B0CA")]
		[FieldOffset(Offset = "0x18")]
		public Vector3[] KBLAIJEAICC;

		[Token(Token = "0x601A2A3")]
		[Address(RVA = "0x120D780", Offset = "0x120D780", VA = "0x120D780")]
		public OHIOKAOHMJL(GameObject OMDFNKNJDII, float GAHKFPAEFHD, int IDNEFEOPGIF)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2004042")]
	public class SimulationSetting
	{
		[Token(Token = "0x401B0CB")]
		[FieldOffset(Offset = "0x8")]
		public float m_windDiff;

		[Token(Token = "0x401B0CC")]
		[FieldOffset(Offset = "0xC")]
		public float m_windSpeed;

		[Token(Token = "0x401B0CD")]
		[FieldOffset(Offset = "0x10")]
		public float m_windAmplitude;

		[Token(Token = "0x401B0CE")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 m_windDir;

		[Token(Token = "0x401B0CF")]
		[FieldOffset(Offset = "0x20")]
		public float m_farClipDist;

		[Token(Token = "0x401B0D0")]
		[FieldOffset(Offset = "0x24")]
		public float m_fadeDist;

		[Token(Token = "0x401B0D1")]
		[FieldOffset(Offset = "0x28")]
		public List<int> m_texCountList;

		[Token(Token = "0x401B0D2")]
		[FieldOffset(Offset = "0x2C")]
		public float m_lod0Dist;

		[Token(Token = "0x401B0D3")]
		[FieldOffset(Offset = "0x30")]
		public float m_lod1Dist;

		[Token(Token = "0x401B0D4")]
		[FieldOffset(Offset = "0x34")]
		public float m_lod2Dist;

		[Token(Token = "0x401B0D5")]
		[FieldOffset(Offset = "0x38")]
		public float m_shadowBias;

		[Token(Token = "0x401B0D6")]
		[FieldOffset(Offset = "0x3C")]
		public float m_shadowPower;

		[Token(Token = "0x401B0D7")]
		[FieldOffset(Offset = "0x40")]
		public float m_shadowClampMin;

		[Token(Token = "0x401B0D8")]
		[FieldOffset(Offset = "0x44")]
		public float m_shadowClampMax;

		[Token(Token = "0x601A2A4")]
		[Address(RVA = "0x120D7C0", Offset = "0x120D7C0", VA = "0x120D7C0")]
		public SimulationSetting()
		{
		}
	}

	[Token(Token = "0x2004043")]
	private class GFAHMIDHOHK
	{
		[Token(Token = "0x401B0D9")]
		[FieldOffset(Offset = "0x8")]
		public GameObject FJNMODKIFHN;

		[Token(Token = "0x401B0DA")]
		[FieldOffset(Offset = "0xC")]
		public List<Mesh> DPJFEMNAAIB;

		[Token(Token = "0x401B0DB")]
		[FieldOffset(Offset = "0x10")]
		public List<Material> GMNDBBAIDBA;

		[Token(Token = "0x401B0DC")]
		[FieldOffset(Offset = "0x14")]
		public List<MaterialPropertyBlock> ICNMLMNIHAC;

		[Token(Token = "0x401B0DD")]
		[FieldOffset(Offset = "0x18")]
		public VegColorComponent DMAMPLFEEIG;

		[Token(Token = "0x401B0DE")]
		[FieldOffset(Offset = "0x1C")]
		public Vector4[] IGHDJFLFPKI;

		[Token(Token = "0x401B0DF")]
		[FieldOffset(Offset = "0x20")]
		public int CANLDKBGECI;

		[Token(Token = "0x601A2A5")]
		[Address(RVA = "0x120CFB0", Offset = "0x120CFB0", VA = "0x120CFB0")]
		public GFAHMIDHOHK(GameObject OMDFNKNJDII, List<Material> PIHKCCDPHEI, List<Mesh> IMLENBPJOEL, List<MaterialPropertyBlock> BDCPMEOBDDG, VegColorComponent PPGENMDLHEC, int MOBDKEOEJPH)
		{
		}

		[Token(Token = "0x601A2A6")]
		[Address(RVA = "0x120D1E4", Offset = "0x120D1E4", VA = "0x120D1E4")]
		private void LBNLCOLBMCK()
		{
		}
	}

	[Token(Token = "0x2004044")]
	public class EGNPPEGEFDH
	{
		[Token(Token = "0x401B0E0")]
		[FieldOffset(Offset = "0x8")]
		public int CGJEPKGLKGG;

		[Token(Token = "0x401B0E1")]
		[FieldOffset(Offset = "0xC")]
		public int IEIKMKGKELM;

		[Token(Token = "0x401B0E2")]
		[FieldOffset(Offset = "0x10")]
		public int NJCAIMOCPLP;

		[Token(Token = "0x401B0E3")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 NCGOCDAJLCD;

		[Token(Token = "0x401B0E4")]
		[FieldOffset(Offset = "0x20")]
		public Vector4[] KNAHNKEPCEE;

		[Token(Token = "0x601A2A7")]
		[Address(RVA = "0x120CEF0", Offset = "0x120CEF0", VA = "0x120CEF0")]
		public EGNPPEGEFDH()
		{
		}
	}

	[Token(Token = "0x2004045")]
	public class COMLDLAPCNK
	{
		[Token(Token = "0x401B0E5")]
		[FieldOffset(Offset = "0x8")]
		public int CGJEPKGLKGG;

		[Token(Token = "0x401B0E6")]
		[FieldOffset(Offset = "0xC")]
		public int MFDIHDEEGKH;

		[Token(Token = "0x401B0E7")]
		[FieldOffset(Offset = "0x10")]
		public int NJCAIMOCPLP;

		[Token(Token = "0x401B0E8")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 NCGOCDAJLCD;

		[Token(Token = "0x401B0E9")]
		[FieldOffset(Offset = "0x20")]
		public Matrix4x4 CFJPJGPMIGL;

		[Token(Token = "0x401B0EA")]
		[FieldOffset(Offset = "0x60")]
		public Matrix4x4 HNLBODDIFII;

		[Token(Token = "0x601A2A8")]
		[Address(RVA = "0x120CC08", Offset = "0x120CC08", VA = "0x120CC08")]
		public COMLDLAPCNK()
		{
		}
	}

	[Token(Token = "0x2004046")]
	public class NMIGMGDJEGM
	{
		[Token(Token = "0x401B0EB")]
		[FieldOffset(Offset = "0x8")]
		public float[,,] BKCBHIOFIOC;

		[Token(Token = "0x401B0EC")]
		[FieldOffset(Offset = "0xC")]
		public float[,] EHOJOLBNPCI;

		[Token(Token = "0x401B0ED")]
		[FieldOffset(Offset = "0x10")]
		public int[,] FPAOLGGJIJP;

		[Token(Token = "0x401B0EE")]
		[FieldOffset(Offset = "0x14")]
		public byte[,,,] EGMPFAGNGGG;

		[Token(Token = "0x601A2A9")]
		[Address(RVA = "0x120D5D8", Offset = "0x120D5D8", VA = "0x120D5D8")]
		public NMIGMGDJEGM()
		{
		}
	}

	[Token(Token = "0x2004047")]
	public class AKCFJLEAHDP
	{
		[Token(Token = "0x401B0EF")]
		[FieldOffset(Offset = "0x8")]
		public CDENNEABJCM LPPDKOHDEII;

		[Token(Token = "0x401B0F0")]
		[FieldOffset(Offset = "0xC")]
		public int MNCFDKLHIEM;

		[Token(Token = "0x601A2AA")]
		[Address(RVA = "0x120CBE0", Offset = "0x120CBE0", VA = "0x120CBE0")]
		public AKCFJLEAHDP(CDENNEABJCM PMGBACFJIHO, int EJOBGMNOJGC)
		{
		}
	}

	[Token(Token = "0x2004048")]
	public class DCHCKODJALA
	{
		[Token(Token = "0x401B0F1")]
		[FieldOffset(Offset = "0x8")]
		public List<int> JCHFKJKBAPE;

		[Token(Token = "0x401B0F2")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 KHIHCMCNPOF;

		[Token(Token = "0x401B0F3")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 DABHNEIHNCJ;

		[Token(Token = "0x601A2AB")]
		[Address(RVA = "0x120CCB8", Offset = "0x120CCB8", VA = "0x120CCB8")]
		public DCHCKODJALA()
		{
		}
	}

	[Token(Token = "0x401B046")]
	[FieldOffset(Offset = "0x0")]
	public static bool m_debugSwitchGrass;

	[Token(Token = "0x401B047")]
	[FieldOffset(Offset = "0x1")]
	public static bool m_debugSwitchTree;

	[Token(Token = "0x401B048")]
	[FieldOffset(Offset = "0x2")]
	public static bool m_debugSwitchVeg;

	[Token(Token = "0x401B049")]
	[FieldOffset(Offset = "0x3")]
	public static bool EnablePreZPass;

	[Token(Token = "0x401B04A")]
	[FieldOffset(Offset = "0xC")]
	public List<GameObject> m_vegetationTypeList;

	[Token(Token = "0x401B04B")]
	[FieldOffset(Offset = "0x10")]
	public List<DistributionData> m_distributionDataList;

	[Token(Token = "0x401B04C")]
	[FieldOffset(Offset = "0x14")]
	public SimulationSetting m_simulationSetting;

	[Token(Token = "0x401B04D")]
	[FieldOffset(Offset = "0x18")]
	private List<OHIOKAOHMJL> BOCDDOBHNPD;

	[Token(Token = "0x401B04E")]
	[FieldOffset(Offset = "0x1C")]
	private List<GFAHMIDHOHK> LAHOMLECGHL;

	[Token(Token = "0x401B04F")]
	[FieldOffset(Offset = "0x20")]
	private Transform HDPBEJALBDA;

	[Token(Token = "0x401B050")]
	[FieldOffset(Offset = "0x24")]
	private Transform IKJAEAEJMAH;

	[Token(Token = "0x401B051")]
	[FieldOffset(Offset = "0x28")]
	private List<int> MIPNOMAFMPN;

	[Token(Token = "0x401B052")]
	[FieldOffset(Offset = "0x2C")]
	private List<int> EAJIJHFMMOI;

	[Token(Token = "0x401B053")]
	[FieldOffset(Offset = "0x30")]
	private List<int> FGMDFIHDPGL;

	[Token(Token = "0x401B054")]
	[FieldOffset(Offset = "0x34")]
	private List<int> EHGEJNMKKOK;

	[Token(Token = "0x401B055")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<int, List<int>> ELLEBKNIJFF;

	[Token(Token = "0x401B056")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<int, List<EGNPPEGEFDH>> GLIDCMDPAEI;

	[Token(Token = "0x401B057")]
	[FieldOffset(Offset = "0x40")]
	private List<COMLDLAPCNK> ADFLAFKONGH;

	[Token(Token = "0x401B058")]
	[FieldOffset(Offset = "0x44")]
	private List<COMLDLAPCNK> ACNCDHPMIBE;

	[Token(Token = "0x401B059")]
	[FieldOffset(Offset = "0x48")]
	private float AKJJEMGDOHE;

	[Token(Token = "0x401B05A")]
	[FieldOffset(Offset = "0x4C")]
	private NMIGMGDJEGM INJDBIECKOL;

	[Token(Token = "0x401B05B")]
	[FieldOffset(Offset = "0x50")]
	private int BJDAMBPHJAJ;

	[Token(Token = "0x401B05C")]
	[FieldOffset(Offset = "0x54")]
	private int INPHKEKCFEL;

	[Token(Token = "0x401B05D")]
	[FieldOffset(Offset = "0x58")]
	private int MFHJHIJMODP;

	[Token(Token = "0x401B05E")]
	[FieldOffset(Offset = "0x5C")]
	private float EPGPHENONIN;

	[Token(Token = "0x401B05F")]
	[FieldOffset(Offset = "0x60")]
	private float PCCAIKBDGOH;

	[Token(Token = "0x401B060")]
	[FieldOffset(Offset = "0x64")]
	private float AGNMBFNPFMD;

	[Token(Token = "0x401B061")]
	[FieldOffset(Offset = "0x68")]
	private float GEBCCDFPOKG;

	[Token(Token = "0x401B062")]
	private const float PDELDFNJBMD = 2f;

	[Token(Token = "0x401B063")]
	[FieldOffset(Offset = "0x6C")]
	private Dictionary<string, AKCFJLEAHDP> CNFAPGDELCP;

	[Token(Token = "0x401B064")]
	[FieldOffset(Offset = "0x70")]
	private List<Color> DMILFKBHJOD;

	[Token(Token = "0x401B065")]
	[FieldOffset(Offset = "0x74")]
	private List<Color> MKHKGALFDJA;

	[Token(Token = "0x401B066")]
	[FieldOffset(Offset = "0x78")]
	private List<Vector4> FBOEABNOOEP;

	[Token(Token = "0x401B067")]
	private const int MHICMGFCBEO = 8;

	[Token(Token = "0x401B068")]
	[FieldOffset(Offset = "0x7C")]
	private int HNJGMMBNMFF;

	[Token(Token = "0x401B069")]
	[FieldOffset(Offset = "0x80")]
	private int IKGOICLJMNM;

	[Token(Token = "0x401B06A")]
	private const int HHEKEOFJBLA = 2000;

	[Token(Token = "0x401B06B")]
	[FieldOffset(Offset = "0x84")]
	private int DIKAEDBKLEI;

	[Token(Token = "0x401B06C")]
	private const int IBJMBKHEGCI = 400;

	[Token(Token = "0x401B06D")]
	private const float ILGGLPCIMFP = -100000f;

	[Token(Token = "0x401B06E")]
	[FieldOffset(Offset = "0x88")]
	private Dictionary<int, List<Vector3>> NFNILEAFEDE;

	[Token(Token = "0x401B06F")]
	[FieldOffset(Offset = "0x8C")]
	private Dictionary<int, List<Vector2>> DCBPGCOHJHA;

	[Token(Token = "0x401B070")]
	[FieldOffset(Offset = "0x90")]
	private int[] PBKDOBBJEGN;

	[Token(Token = "0x401B071")]
	[FieldOffset(Offset = "0x94")]
	private int[] FJABDOEJNAD;

	[Token(Token = "0x401B072")]
	[FieldOffset(Offset = "0x98")]
	private List<Vector3> HGDOJNNMFOI;

	[Token(Token = "0x401B073")]
	[FieldOffset(Offset = "0x9C")]
	private List<Vector3> AFDAPHFCINK;

	[Token(Token = "0x401B074")]
	[FieldOffset(Offset = "0xA0")]
	private List<Vector2> BNLBEPAOCLP;

	[Token(Token = "0x401B075")]
	[FieldOffset(Offset = "0xA4")]
	private List<Vector2> FHPOPBMALPL;

	[Token(Token = "0x401B076")]
	[FieldOffset(Offset = "0xA8")]
	private List<Color> JNBJJPKBFPI;

	[Token(Token = "0x401B077")]
	[FieldOffset(Offset = "0xAC")]
	private List<Color> JCNDMEDMEHL;

	[Token(Token = "0x401B078")]
	[FieldOffset(Offset = "0xB0")]
	private Dictionary<int, int> NOMCLFIFELM;

	[Token(Token = "0x401B079")]
	[FieldOffset(Offset = "0xB4")]
	private Mesh IDBMCCAAHDJ;

	[Token(Token = "0x401B07A")]
	[FieldOffset(Offset = "0xB8")]
	private Mesh OHPGANBBCEC;

	[Token(Token = "0x401B07B")]
	[FieldOffset(Offset = "0xBC")]
	private float MHHKLHHCCNN;

	[Token(Token = "0x401B07C")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 HEOKBCHNFGE;

	[Token(Token = "0x401B07D")]
	[FieldOffset(Offset = "0xCC")]
	private Material LGGFMICMJAG;

	[Token(Token = "0x401B07E")]
	[FieldOffset(Offset = "0xD0")]
	private int OLHCBOAPLFB;

	[Token(Token = "0x401B07F")]
	[FieldOffset(Offset = "0xD4")]
	public Vector4 m_treeScaleVec;

	[Token(Token = "0x401B080")]
	[FieldOffset(Offset = "0xE4")]
	private float[] PAPMMLOGAEE;

	[Token(Token = "0x401B081")]
	[FieldOffset(Offset = "0xE8")]
	private List<int> BGCIBPNMONL;

	[Token(Token = "0x401B082")]
	[FieldOffset(Offset = "0xEC")]
	private List<int> PGPJKKHBBPK;

	[Token(Token = "0x401B083")]
	[FieldOffset(Offset = "0xF0")]
	private List<int> NBDHONAJIDK;

	[Token(Token = "0x401B084")]
	[FieldOffset(Offset = "0xF4")]
	private List<int> LKCJAMBABFP;

	[Token(Token = "0x401B085")]
	[FieldOffset(Offset = "0xF8")]
	private HashSet<int> GHPJOJJBHCD;

	[Token(Token = "0x401B086")]
	[FieldOffset(Offset = "0xFC")]
	private Dictionary<int, List<int>> LAFOLMIHKKC;

	[Token(Token = "0x401B087")]
	[FieldOffset(Offset = "0x100")]
	private Dictionary<int, List<int>> BCBHFGDKEIC;

	[Token(Token = "0x401B088")]
	[FieldOffset(Offset = "0x104")]
	private Dictionary<int, List<int>> HAFNOAJLGLB;

	[Token(Token = "0x401B089")]
	private const int BIFMOGIFFOC = 4;

	[Token(Token = "0x401B08A")]
	private const int AGDIOBNLGKL = 10;

	[Token(Token = "0x401B08B")]
	[FieldOffset(Offset = "0x108")]
	private int[] ILJBKHCCMFP;

	[Token(Token = "0x401B08C")]
	[FieldOffset(Offset = "0x10C")]
	public GameObject m_pineTreeBillboard;

	[Token(Token = "0x401B08D")]
	[FieldOffset(Offset = "0x110")]
	public GameObject m_greenTreeBillboard;

	[Token(Token = "0x401B08E")]
	[FieldOffset(Offset = "0x114")]
	public GameObject m_cocoTreeBillboard;

	[Token(Token = "0x401B08F")]
	[FieldOffset(Offset = "0x118")]
	public GameObject m_grassGroupGOType0;

	[Token(Token = "0x401B090")]
	[FieldOffset(Offset = "0x11C")]
	public GameObject m_grassGroupGOType1;

	[Token(Token = "0x401B091")]
	[FieldOffset(Offset = "0x120")]
	public GameObject m_grassGroupGOType2;

	[Token(Token = "0x401B092")]
	[FieldOffset(Offset = "0x124")]
	public GameObject m_grassGroupGOType3;

	[Token(Token = "0x401B093")]
	[FieldOffset(Offset = "0x128")]
	private Mesh[,] HOKIABNHGCB;

	[Token(Token = "0x401B094")]
	[FieldOffset(Offset = "0x12C")]
	private Material[,] HBIHHJKHPFB;

	[Token(Token = "0x401B095")]
	[FieldOffset(Offset = "0x130")]
	private MaterialPropertyBlock[,] KOIBHLGKDCB;

	[Token(Token = "0x401B096")]
	[FieldOffset(Offset = "0x134")]
	private Dictionary<int, int> GNNKALKOFID;

	[Token(Token = "0x401B097")]
	private const float ONENLJNOHIK = 30f;

	[Token(Token = "0x401B098")]
	private const float CJEIJEOBMEC = 60f;

	[Token(Token = "0x401B099")]
	[FieldOffset(Offset = "0x138")]
	private int HEFOMCFEFEN;

	[Token(Token = "0x401B09A")]
	[FieldOffset(Offset = "0x13C")]
	private int CJNKCEMBKDC;

	[Token(Token = "0x401B09B")]
	[FieldOffset(Offset = "0x140")]
	private Dictionary<int, List<int>> IIPAEKHHGFJ;

	[Token(Token = "0x401B09C")]
	[FieldOffset(Offset = "0x144")]
	private Dictionary<int, DCHCKODJALA> DGBJOIKIMPA;

	[Token(Token = "0x401B09D")]
	[FieldOffset(Offset = "0x148")]
	private Camera CPHNMPKFICJ;

	[Token(Token = "0x401B09E")]
	[FieldOffset(Offset = "0x14C")]
	private byte AONEJCKJMDE;

	[Token(Token = "0x401B09F")]
	[FieldOffset(Offset = "0x150")]
	private int AKGDMHJFIDJ;

	[Token(Token = "0x401B0A0")]
	[FieldOffset(Offset = "0x154")]
	private bool MMMFBLHOEKF;

	[Token(Token = "0x401B0A1")]
	[FieldOffset(Offset = "0x158")]
	private short[] DPHHHANKKNG;

	[Token(Token = "0x401B0A2")]
	[FieldOffset(Offset = "0x15C")]
	private List<short> CAGOCCEFEMO;

	[Token(Token = "0x401B0A3")]
	[FieldOffset(Offset = "0x160")]
	private short[,] KEIEJKDJFED;

	[Token(Token = "0x401B0A4")]
	[FieldOffset(Offset = "0x164")]
	private Material DEAIADBCIIA;

	[Token(Token = "0x401B0A5")]
	[FieldOffset(Offset = "0x168")]
	private Material APLFHENIKJM;

	[Token(Token = "0x401B0A6")]
	[FieldOffset(Offset = "0x16C")]
	private SceneGraphics LBEHNMJPDGC;

	[Token(Token = "0x401B0A7")]
	[FieldOffset(Offset = "0x170")]
	private Vector2 HJPDMLOKICD;

	[Token(Token = "0x401B0A8")]
	[FieldOffset(Offset = "0x178")]
	private Vector2 HFNEDOIHFDK;

	[Token(Token = "0x401B0A9")]
	[FieldOffset(Offset = "0x180")]
	private List<int> PCHDMHPLAMC;

	[Token(Token = "0x401B0AA")]
	[FieldOffset(Offset = "0x184")]
	private bool JOHGANNHHOG;

	[Token(Token = "0x401B0AB")]
	[FieldOffset(Offset = "0x188")]
	private float _003CMEEBNNHHCIL_003Ek__BackingField;

	[Token(Token = "0x401B0AC")]
	[FieldOffset(Offset = "0x18C")]
	private float _003CGOBNBPHOEPO_003Ek__BackingField;

	[Token(Token = "0x401B0AD")]
	[FieldOffset(Offset = "0x190")]
	private Quaternion OFBBDNNBEGD;

	[Token(Token = "0x401B0AE")]
	[FieldOffset(Offset = "0x1A0")]
	private Vector3 JBOPOKPDALD;

	[Token(Token = "0x401B0AF")]
	[FieldOffset(Offset = "0x1AC")]
	private int DMCLJEJKKPG;

	[Token(Token = "0x401B0B0")]
	[FieldOffset(Offset = "0x1B0")]
	private List<int> HIEBKEFPNIC;

	[Token(Token = "0x401B0B1")]
	[FieldOffset(Offset = "0x1B4")]
	private List<int> MLNBBMBANEN;

	[Token(Token = "0x401B0B2")]
	[FieldOffset(Offset = "0x1B8")]
	public bool m_StandAloneBackCamPos;

	[Token(Token = "0x401B0B3")]
	[FieldOffset(Offset = "0x1BC")]
	private Vector2[] HMOOJLJMNFK;

	[Token(Token = "0x401B0B4")]
	[FieldOffset(Offset = "0x1C0")]
	private int GFMKJMIKDPD;

	[Token(Token = "0x401B0B5")]
	[FieldOffset(Offset = "0x1C4")]
	private int PEHMCMPIANJ;

	[Token(Token = "0x17001CB0")]
	public float MEFHOHJFPMB
	{
		[Token(Token = "0x601A279")]
		[Address(RVA = "0x1D533B4", Offset = "0x1D533B4", VA = "0x1D533B4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x601A27A")]
		[Address(RVA = "0x1D533BC", Offset = "0x1D533BC", VA = "0x1D533BC")]
		private set
		{
		}
	}

	[Token(Token = "0x17001CB1")]
	public float COFJPAKIKMB
	{
		[Token(Token = "0x601A27B")]
		[Address(RVA = "0x1D533C4", Offset = "0x1D533C4", VA = "0x1D533C4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x601A27C")]
		[Address(RVA = "0x1D533CC", Offset = "0x1D533CC", VA = "0x1D533CC")]
		private set
		{
		}
	}

	[Token(Token = "0x601A278")]
	[Address(RVA = "0x1D51FA8", Offset = "0x1D51FA8", VA = "0x1D51FA8")]
	public VegetationManager()
	{
	}

	[Token(Token = "0x601A27D")]
	[Address(RVA = "0x1D533D4", Offset = "0x1D533D4", VA = "0x1D533D4")]
	private void Start()
	{
	}

	[Token(Token = "0x601A27E")]
	[Address(RVA = "0x1D55760", Offset = "0x1D55760", VA = "0x1D55760")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x601A27F")]
	[Address(RVA = "0x1D5397C", Offset = "0x1D5397C", VA = "0x1D5397C")]
	public void Init(bool AMIKJAOGIPA = false)
	{
	}

	[Token(Token = "0x601A280")]
	[Address(RVA = "0x1D55764", Offset = "0x1D55764", VA = "0x1D55764")]
	public void CheckTreeGrid(int PENDDKHIGKC)
	{
	}

	[Token(Token = "0x601A281")]
	[Address(RVA = "0x1D560F4", Offset = "0x1D560F4", VA = "0x1D560F4")]
	private int ABCHGNGEADO(float NHJNFPKBBLI, float GPGDDPJHNIO)
	{
		return default(int);
	}

	[Token(Token = "0x601A282")]
	[Address(RVA = "0x1D561D8", Offset = "0x1D561D8", VA = "0x1D561D8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x601A283")]
	[Address(RVA = "0x1D563FC", Offset = "0x1D563FC", VA = "0x1D563FC")]
	private void JBKBNPHALLI()
	{
	}

	[Token(Token = "0x601A284")]
	[Address(RVA = "0x1D5670C", Offset = "0x1D5670C", VA = "0x1D5670C")]
	public void SimuateVegetation()
	{
	}

	[Token(Token = "0x601A285")]
	[Address(RVA = "0x1D59178", Offset = "0x1D59178", VA = "0x1D59178")]
	public void UpdateSimulationSetting()
	{
	}

	[Token(Token = "0x601A286")]
	[Address(RVA = "0x1D556CC", Offset = "0x1D556CC", VA = "0x1D556CC")]
	public void InitVegetationMeshes()
	{
	}

	[Token(Token = "0x601A287")]
	[Address(RVA = "0x1D53498", Offset = "0x1D53498", VA = "0x1D53498")]
	private void HCIAMEBBCJH()
	{
	}

	[Token(Token = "0x601A288")]
	[Address(RVA = "0x1D59278", Offset = "0x1D59278", VA = "0x1D59278")]
	private void APPGNPHBKHB()
	{
	}

	[Token(Token = "0x601A289")]
	[Address(RVA = "0x1D5AF2C", Offset = "0x1D5AF2C", VA = "0x1D5AF2C")]
	private void GMKOKMNMAMO()
	{
	}

	[Token(Token = "0x601A28A")]
	[Address(RVA = "0x1D5BBB4", Offset = "0x1D5BBB4", VA = "0x1D5BBB4")]
	private void PHPBPCHLMPH()
	{
	}

	[Token(Token = "0x601A28B")]
	[Address(RVA = "0x1D5C1DC", Offset = "0x1D5C1DC", VA = "0x1D5C1DC")]
	private void ACKNAONECJI()
	{
	}

	[Token(Token = "0x601A28C")]
	[Address(RVA = "0x1D5C67C", Offset = "0x1D5C67C", VA = "0x1D5C67C")]
	private void NJEMCNEAIAN(int IDNEFEOPGIF, ref Vector2 FMJKICBEBML, float GAEIHDLEOJF, float BMKOIDECKPB, float GGPDLGMOBLG)
	{
	}

	[Token(Token = "0x601A28D")]
	[Address(RVA = "0x1D57368", Offset = "0x1D57368", VA = "0x1D57368")]
	private void NFBOHCBACMH()
	{
	}

	[Token(Token = "0x601A28E")]
	[Address(RVA = "0x1D5C8D8", Offset = "0x1D5C8D8", VA = "0x1D5C8D8")]
	private void EDDGEKGKFLM()
	{
	}

	[Token(Token = "0x601A28F")]
	[Address(RVA = "0x1D56918", Offset = "0x1D56918", VA = "0x1D56918")]
	private void HHKDGGPMBIP()
	{
	}

	[Token(Token = "0x601A290")]
	[Address(RVA = "0x1D5D41C", Offset = "0x1D5D41C", VA = "0x1D5D41C")]
	private void KIBBHJMECGC(Vector2 FHOKBMGKCAP, Vector2 JOOCJDDCHMD, ref Vector2 FMJKICBEBML, ref Vector2 HLFJOKEOBKA, float PENKLFFDABD)
	{
	}

	[Token(Token = "0x601A291")]
	[Address(RVA = "0x1D5F770", Offset = "0x1D5F770", VA = "0x1D5F770")]
	private Vector2 BHKOCDAFHCG(Vector2 ACCOJJMKKPM, Vector2 EBIJHALKJEM)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x601A292")]
	[Address(RVA = "0x1D5F844", Offset = "0x1D5F844", VA = "0x1D5F844")]
	private static Vector2 BHKOCDAFHCG(Vector2 ACCOJJMKKPM, Vector2 EBIJHALKJEM, float AGNMBFNPFMD, float GEBCCDFPOKG, float EPGPHENONIN, float PCCAIKBDGOH)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x601A293")]
	[Address(RVA = "0x1D5DFE4", Offset = "0x1D5DFE4", VA = "0x1D5DFE4")]
	private void AILEALOFAIK(Vector2 FHOKBMGKCAP, Vector2 JOOCJDDCHMD, ref Vector2 FMJKICBEBML, ref Vector2 HLFJOKEOBKA, float PENKLFFDABD)
	{
	}

	[Token(Token = "0x601A294")]
	[Address(RVA = "0x1D5F998", Offset = "0x1D5F998", VA = "0x1D5F998")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x601A295")]
	[Address(RVA = "0x1D5E78C", Offset = "0x1D5E78C", VA = "0x1D5E78C")]
	private void AFBEJAFIPJD(Vector2 FHOKBMGKCAP, Vector2 JOOCJDDCHMD, ref Vector2 FMJKICBEBML, ref Vector2 HLFJOKEOBKA, float PENKLFFDABD)
	{
	}

	[Token(Token = "0x601A296")]
	[Address(RVA = "0x1D5F2A8", Offset = "0x1D5F2A8", VA = "0x1D5F2A8")]
	private bool OMKFKOILNKN(ref Vector2 FMJKICBEBML, ref Vector2 HLFJOKEOBKA, float PENKLFFDABD, ref Vector2 AKDPEGLAEFC, ref Vector2 DMHBKBPPOCO)
	{
		return default(bool);
	}

	[Token(Token = "0x601A297")]
	[Address(RVA = "0x1D57010", Offset = "0x1D57010", VA = "0x1D57010")]
	private void HHODNNOHMHK(bool AGEGKNOMAJD = true)
	{
	}

	[Token(Token = "0x601A298")]
	[Address(RVA = "0x1D5F99C", Offset = "0x1D5F99C", VA = "0x1D5F99C")]
	private void NOPKDKMIFNP(ref Vector2 FMJKICBEBML, ref Vector2 HLFJOKEOBKA, float PENKLFFDABD)
	{
	}

	[Token(Token = "0x601A299")]
	[Address(RVA = "0x1D613C4", Offset = "0x1D613C4", VA = "0x1D613C4")]
	private void IGOHDCANBKH(ref Vector2 FMJKICBEBML, ref Vector2 HLFJOKEOBKA, float PENKLFFDABD)
	{
	}

	[Token(Token = "0x601A29A")]
	[Address(RVA = "0x1D6268C", Offset = "0x1D6268C", VA = "0x1D6268C")]
	private void POGLHPHGOEB(ref Vector2 FMJKICBEBML, ref Vector2 HLFJOKEOBKA, float PENKLFFDABD)
	{
	}

	[Token(Token = "0x601A29B")]
	[Address(RVA = "0x1D63018", Offset = "0x1D63018", VA = "0x1D63018")]
	private void IOMJIFHGEMH()
	{
	}

	[Token(Token = "0x601A29C")]
	[Address(RVA = "0x1D63DD8", Offset = "0x1D63DD8", VA = "0x1D63DD8")]
	private void CNHJLNFEFAA(ref int MPOEOIGIOAB, ref short MMBLMGFNKED, ref int OJCCKCIONDP, ref int INMOGLOOLBJ)
	{
	}

	[Token(Token = "0x601A29D")]
	[Address(RVA = "0x1D64B40", Offset = "0x1D64B40", VA = "0x1D64B40")]
	private void MBKPKMHJDLE(bool MCDIDHODHLN)
	{
	}

	[Token(Token = "0x601A29E")]
	[Address(RVA = "0x1D639DC", Offset = "0x1D639DC", VA = "0x1D639DC")]
	private void KKKFPJGDAPK(ref OHIOKAOHMJL HIDIODNIGGF, int IDNEFEOPGIF, byte LMHNGDLHLCP, byte HKHPEOAGGGK, byte EAMKDGINABE)
	{
	}

	[Token(Token = "0x601A29F")]
	[Address(RVA = "0x1D63CD4", Offset = "0x1D63CD4", VA = "0x1D63CD4")]
	private int MEKDAIKGAJK(ref OHIOKAOHMJL HIDIODNIGGF, int PLLHBNLKHDH, int HHJOGKBAFNF, int OHEKABCKNDI)
	{
		return default(int);
	}

	[Token(Token = "0x601A2A0")]
	[Address(RVA = "0x1D63934", Offset = "0x1D63934", VA = "0x1D63934")]
	private void BNBNFGDBGHA(ref OHIOKAOHMJL HIDIODNIGGF)
	{
	}
}
