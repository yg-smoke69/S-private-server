using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x200400F")]
public class TreeSystem : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2004010")]
	public class DistributionData : CEJMEBEOMIJ
	{
		[Token(Token = "0x401AF8B")]
		[FieldOffset(Offset = "0x8")]
		public int m_meshID;

		[Token(Token = "0x401AF8C")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 m_position;

		[Token(Token = "0x401AF8D")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 m_boundMin;

		[Token(Token = "0x401AF8E")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 m_boundMax;

		[Token(Token = "0x401AF8F")]
		[FieldOffset(Offset = "0x28")]
		public short m_scaleID;

		[Token(Token = "0x401AF90")]
		[FieldOffset(Offset = "0x2A")]
		public short m_hueAmount;

		[Token(Token = "0x401AF91")]
		[FieldOffset(Offset = "0x2C")]
		public byte m_textID;

		[Token(Token = "0x601A188")]
		[Address(RVA = "0x1D5054C", Offset = "0x1D5054C", VA = "0x1D5054C")]
		public DistributionData()
		{
		}

		[Token(Token = "0x601A189")]
		[Address(RVA = "0x1D50554", Offset = "0x1D50554", VA = "0x1D50554")]
		public DistributionData(int AOPBBDLPDGL, Vector3 ACCOJJMKKPM, Bounds GMDFLOLJBNE)
		{
		}

		[Token(Token = "0x601A18A")]
		[Address(RVA = "0x1D50774", Offset = "0x1D50774", VA = "0x1D50774", Slot = "6")]
		protected override void PCKFEGCCEMD(JsonData MIBCHPEMKBF)
		{
		}

		[Token(Token = "0x601A18B")]
		[Address(RVA = "0x1D50A1C", Offset = "0x1D50A1C", VA = "0x1D50A1C", Slot = "7")]
		protected override void FNCFOKEBNOD(ref JsonWriter NNPGNFBKEMM)
		{
		}
	}

	[Token(Token = "0x2004011")]
	public class OHIOKAOHMJL
	{
		[Token(Token = "0x401AF92")]
		[FieldOffset(Offset = "0x8")]
		public byte JILHILJOODN;

		[Token(Token = "0x401AF93")]
		[FieldOffset(Offset = "0x9")]
		public byte KKFJKCLEMCM;

		[Token(Token = "0x401AF94")]
		[FieldOffset(Offset = "0xA")]
		public byte IPGFJMEJEGA;

		[Token(Token = "0x401AF95")]
		[FieldOffset(Offset = "0xC")]
		public int LBNKLLACNKA;

		[Token(Token = "0x401AF96")]
		[FieldOffset(Offset = "0x10")]
		public Vector3[] KBLAIJEAICC;

		[Token(Token = "0x601A18C")]
		[Address(RVA = "0x1D40480", Offset = "0x1D40480", VA = "0x1D40480")]
		public OHIOKAOHMJL()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2004012")]
	public class SimulationSetting
	{
		[Token(Token = "0x401AF97")]
		[FieldOffset(Offset = "0x8")]
		public float m_windDiff;

		[Token(Token = "0x401AF98")]
		[FieldOffset(Offset = "0xC")]
		public float m_windSpeed;

		[Token(Token = "0x401AF99")]
		[FieldOffset(Offset = "0x10")]
		public float m_windAmplitude;

		[Token(Token = "0x401AF9A")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 m_windDir;

		[Token(Token = "0x401AF9B")]
		[FieldOffset(Offset = "0x20")]
		public float m_farClipDist;

		[Token(Token = "0x401AF9C")]
		[FieldOffset(Offset = "0x24")]
		public float m_fadeDist;

		[Token(Token = "0x401AF9D")]
		[FieldOffset(Offset = "0x28")]
		public List<int> m_texCountList;

		[Token(Token = "0x401AF9E")]
		[FieldOffset(Offset = "0x2C")]
		public float m_lod0Dist;

		[Token(Token = "0x401AF9F")]
		[FieldOffset(Offset = "0x30")]
		public float m_lod1Dist;

		[Token(Token = "0x401AFA0")]
		[FieldOffset(Offset = "0x34")]
		public float m_lod2Dist;

		[Token(Token = "0x401AFA1")]
		[FieldOffset(Offset = "0x38")]
		public float m_shadowBias;

		[Token(Token = "0x401AFA2")]
		[FieldOffset(Offset = "0x3C")]
		public float m_shadowPower;

		[Token(Token = "0x401AFA3")]
		[FieldOffset(Offset = "0x40")]
		public float m_shadowClampMin;

		[Token(Token = "0x401AFA4")]
		[FieldOffset(Offset = "0x44")]
		public float m_shadowClampMax;

		[Token(Token = "0x601A18D")]
		[Address(RVA = "0x1D51058", Offset = "0x1D51058", VA = "0x1D51058")]
		public SimulationSetting()
		{
		}
	}

	[Token(Token = "0x2004013")]
	public class GFAHMIDHOHK
	{
		[Token(Token = "0x401AFA5")]
		[FieldOffset(Offset = "0x8")]
		public GameObject FJNMODKIFHN;

		[Token(Token = "0x401AFA6")]
		[FieldOffset(Offset = "0xC")]
		public List<Mesh> DPJFEMNAAIB;

		[Token(Token = "0x401AFA7")]
		[FieldOffset(Offset = "0x10")]
		public List<Material> GMNDBBAIDBA;

		[Token(Token = "0x401AFA8")]
		[FieldOffset(Offset = "0x14")]
		public List<MaterialPropertyBlock> ICNMLMNIHAC;

		[Token(Token = "0x401AFA9")]
		[FieldOffset(Offset = "0x18")]
		public VegColorComponent DMAMPLFEEIG;

		[Token(Token = "0x401AFAA")]
		[FieldOffset(Offset = "0x1C")]
		public Vector4[] IGHDJFLFPKI;

		[Token(Token = "0x401AFAB")]
		[FieldOffset(Offset = "0x20")]
		public int CANLDKBGECI;

		[Token(Token = "0x401AFAC")]
		[FieldOffset(Offset = "0x24")]
		public List<Material> MGGDFJDOLGF;

		[Token(Token = "0x601A18E")]
		[Address(RVA = "0x1D48750", Offset = "0x1D48750", VA = "0x1D48750")]
		public GFAHMIDHOHK(GameObject OMDFNKNJDII, List<Material> PIHKCCDPHEI, List<Mesh> IMLENBPJOEL, List<MaterialPropertyBlock> BDCPMEOBDDG, VegColorComponent PPGENMDLHEC, int MOBDKEOEJPH)
		{
		}

		[Token(Token = "0x601A18F")]
		[Address(RVA = "0x1D50C60", Offset = "0x1D50C60", VA = "0x1D50C60")]
		private void LBNLCOLBMCK()
		{
		}
	}

	[Token(Token = "0x2004014")]
	public class COMLDLAPCNK
	{
		[Token(Token = "0x401AFAD")]
		[FieldOffset(Offset = "0x8")]
		public int CGJEPKGLKGG;

		[Token(Token = "0x401AFAE")]
		[FieldOffset(Offset = "0xC")]
		public int MFDIHDEEGKH;

		[Token(Token = "0x401AFAF")]
		[FieldOffset(Offset = "0x10")]
		public int NJCAIMOCPLP;

		[Token(Token = "0x401AFB0")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 NCGOCDAJLCD;

		[Token(Token = "0x401AFB1")]
		[FieldOffset(Offset = "0x20")]
		public Matrix4x4 CFJPJGPMIGL;

		[Token(Token = "0x401AFB2")]
		[FieldOffset(Offset = "0x60")]
		public Matrix4x4 HNLBODDIFII;

		[Token(Token = "0x601A190")]
		[Address(RVA = "0x1D40584", Offset = "0x1D40584", VA = "0x1D40584")]
		public COMLDLAPCNK()
		{
		}
	}

	[Token(Token = "0x2004015")]
	public class ABMLEJDMPMF
	{
		[Token(Token = "0x401AFB3")]
		[FieldOffset(Offset = "0x8")]
		public int CGJEPKGLKGG;

		[Token(Token = "0x401AFB4")]
		[FieldOffset(Offset = "0xC")]
		public int MFDIHDEEGKH;

		[Token(Token = "0x401AFB5")]
		[FieldOffset(Offset = "0x10")]
		public int NJCAIMOCPLP;

		[Token(Token = "0x401AFB6")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 NCGOCDAJLCD;

		[Token(Token = "0x401AFB7")]
		[FieldOffset(Offset = "0x20")]
		public int FMJAEFEHJPL;

		[Token(Token = "0x401AFB8")]
		[FieldOffset(Offset = "0x24")]
		public Matrix4x4[] EBMHMCJFCJC;

		[Token(Token = "0x601A191")]
		[Address(RVA = "0x1D4F35C", Offset = "0x1D4F35C", VA = "0x1D4F35C")]
		public ABMLEJDMPMF()
		{
		}
	}

	[Token(Token = "0x2004016")]
	public class NMIGMGDJEGM
	{
		[Token(Token = "0x401AFB9")]
		[FieldOffset(Offset = "0x8")]
		public float[,] BKCBHIOFIOC;

		[Token(Token = "0x401AFBA")]
		[FieldOffset(Offset = "0xC")]
		public float[,] EHOJOLBNPCI;

		[Token(Token = "0x401AFBB")]
		[FieldOffset(Offset = "0x10")]
		public int[] FPAOLGGJIJP;

		[Token(Token = "0x401AFBC")]
		[FieldOffset(Offset = "0x14")]
		public byte[,,] EGMPFAGNGGG;

		[Token(Token = "0x601A192")]
		[Address(RVA = "0x1D3DFC0", Offset = "0x1D3DFC0", VA = "0x1D3DFC0")]
		public NMIGMGDJEGM()
		{
		}
	}

	[Token(Token = "0x2004017")]
	public class AKCFJLEAHDP
	{
		[Token(Token = "0x401AFBD")]
		[FieldOffset(Offset = "0x8")]
		public int MNCFDKLHIEM;

		[Token(Token = "0x601A193")]
		[Address(RVA = "0x1D5052C", Offset = "0x1D5052C", VA = "0x1D5052C")]
		public AKCFJLEAHDP(int EJOBGMNOJGC)
		{
		}
	}

	[Token(Token = "0x2004018")]
	public class DCHCKODJALA
	{
		[Token(Token = "0x401AFBE")]
		[FieldOffset(Offset = "0x8")]
		public List<int> DOIJLIAGFHH;

		[Token(Token = "0x401AFBF")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 KHIHCMCNPOF;

		[Token(Token = "0x401AFC0")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 DABHNEIHNCJ;

		[Token(Token = "0x601A194")]
		[Address(RVA = "0x1D40490", Offset = "0x1D40490", VA = "0x1D40490")]
		public DCHCKODJALA()
		{
		}
	}

	[Token(Token = "0x2004019")]
	public class MPBAMGFMEAG
	{
		[Token(Token = "0x401AFC1")]
		[FieldOffset(Offset = "0x8")]
		public List<Vector3> IBNIGNOFEME;

		[Token(Token = "0x401AFC2")]
		[FieldOffset(Offset = "0xC")]
		public List<Vector2> FPEMHHBJMIG;

		[Token(Token = "0x401AFC3")]
		[FieldOffset(Offset = "0x10")]
		public float JMINHEEDAEL;

		[Token(Token = "0x401AFC4")]
		[FieldOffset(Offset = "0x14")]
		public float GDLEMOPNJOM;

		[Token(Token = "0x401AFC5")]
		[FieldOffset(Offset = "0x18")]
		public bool KBEIFOCKEFH;

		[Token(Token = "0x601A195")]
		[Address(RVA = "0x1D48B40", Offset = "0x1D48B40", VA = "0x1D48B40")]
		public MPBAMGFMEAG()
		{
		}
	}

	[Token(Token = "0x200401A")]
	public class GGJKDECMHLP
	{
		[Token(Token = "0x401AFC6")]
		[FieldOffset(Offset = "0x8")]
		public List<int> KKHCCAOILJG;

		[Token(Token = "0x401AFC7")]
		[FieldOffset(Offset = "0xC")]
		public int DFMEKJECKAL;

		[Token(Token = "0x401AFC8")]
		[FieldOffset(Offset = "0x10")]
		public int BOEJCMCLGDO;

		[Token(Token = "0x401AFC9")]
		[FieldOffset(Offset = "0x14")]
		public float CDLKPDKHEKF;

		[Token(Token = "0x601A196")]
		[Address(RVA = "0x1D40634", Offset = "0x1D40634", VA = "0x1D40634")]
		public GGJKDECMHLP()
		{
		}
	}

	[Token(Token = "0x401AF0D")]
	[FieldOffset(Offset = "0x0")]
	private static Matrix4x4[] JJINPAKODKG;

	[Token(Token = "0x401AF0E")]
	[FieldOffset(Offset = "0x4")]
	public static bool m_debugSwitchTree;

	[Token(Token = "0x401AF0F")]
	[FieldOffset(Offset = "0x5")]
	public static bool m_debugSwitchVeg;

	[Token(Token = "0x401AF10")]
	[FieldOffset(Offset = "0xC")]
	public List<GameObject> m_vegetationTypeList;

	[Token(Token = "0x401AF11")]
	[FieldOffset(Offset = "0x10")]
	public List<DistributionData> m_distributionDataList;

	[Token(Token = "0x401AF12")]
	[FieldOffset(Offset = "0x14")]
	public List<GameObject> m_BillboardList;

	[Token(Token = "0x401AF13")]
	[FieldOffset(Offset = "0x18")]
	public List<string> m_vegetationTypeResIDList;

	[Token(Token = "0x401AF14")]
	[FieldOffset(Offset = "0x1C")]
	public List<string> m_vegetationBillboardResIDList;

	[Token(Token = "0x401AF15")]
	[FieldOffset(Offset = "0x20")]
	public List<string> m_vegetationPSBillboardResIDLIst;

	[Token(Token = "0x401AF16")]
	[FieldOffset(Offset = "0x24")]
	public GameObject m_cactusBillboard;

	[Token(Token = "0x401AF17")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_palmBillboard;

	[Token(Token = "0x401AF18")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject m_whiteBirchBillboard;

	[Token(Token = "0x401AF19")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_shrub1Billboard;

	[Token(Token = "0x401AF1A")]
	[FieldOffset(Offset = "0x34")]
	public GameObject m_shrub2Billboard;

	[Token(Token = "0x401AF1B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_shrub3Billboard;

	[Token(Token = "0x401AF1C")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject m_shrub4Billboard;

	[Token(Token = "0x401AF1D")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_cactusPSBillboard;

	[Token(Token = "0x401AF1E")]
	[FieldOffset(Offset = "0x44")]
	public GameObject m_palmPSBillboard;

	[Token(Token = "0x401AF1F")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_whiteBirchPSBillboard;

	[Token(Token = "0x401AF20")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject m_shrub1PSBillboard;

	[Token(Token = "0x401AF21")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_shrub2PSBillboard;

	[Token(Token = "0x401AF22")]
	[FieldOffset(Offset = "0x54")]
	public GameObject m_shrub3PSBillboard;

	[Token(Token = "0x401AF23")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_shrub4PSBillboard;

	[Token(Token = "0x401AF24")]
	[FieldOffset(Offset = "0x5C")]
	private List<OHIOKAOHMJL> BOCDDOBHNPD;

	[Token(Token = "0x401AF25")]
	[FieldOffset(Offset = "0x60")]
	private List<GFAHMIDHOHK> LAHOMLECGHL;

	[Token(Token = "0x401AF26")]
	[FieldOffset(Offset = "0x64")]
	private Transform IKJAEAEJMAH;

	[Token(Token = "0x401AF27")]
	[FieldOffset(Offset = "0x68")]
	private List<int> EAJIJHFMMOI;

	[Token(Token = "0x401AF28")]
	[FieldOffset(Offset = "0x6C")]
	private List<int> FGMDFIHDPGL;

	[Token(Token = "0x401AF29")]
	[FieldOffset(Offset = "0x70")]
	private List<COMLDLAPCNK> ADFLAFKONGH;

	[Token(Token = "0x401AF2A")]
	[FieldOffset(Offset = "0x74")]
	private List<COMLDLAPCNK> ACNCDHPMIBE;

	[Token(Token = "0x401AF2B")]
	[FieldOffset(Offset = "0x78")]
	private List<ABMLEJDMPMF> GCKFGCFCGAI;

	[Token(Token = "0x401AF2C")]
	[FieldOffset(Offset = "0x7C")]
	private List<ABMLEJDMPMF> OJBGHLFMCOI;

	[Token(Token = "0x401AF2D")]
	[FieldOffset(Offset = "0x80")]
	private NMIGMGDJEGM INJDBIECKOL;

	[Token(Token = "0x401AF2E")]
	[FieldOffset(Offset = "0x84")]
	private int BJDAMBPHJAJ;

	[Token(Token = "0x401AF2F")]
	[FieldOffset(Offset = "0x88")]
	private int INPHKEKCFEL;

	[Token(Token = "0x401AF30")]
	[FieldOffset(Offset = "0x8C")]
	public float m_mapWidth;

	[Token(Token = "0x401AF31")]
	[FieldOffset(Offset = "0x90")]
	public float m_mapHeight;

	[Token(Token = "0x401AF32")]
	[FieldOffset(Offset = "0x94")]
	public float m_mapStartPosX;

	[Token(Token = "0x401AF33")]
	[FieldOffset(Offset = "0x98")]
	public float m_mapStartPosZ;

	[Token(Token = "0x401AF34")]
	private const float PDELDFNJBMD = 2f;

	[Token(Token = "0x401AF35")]
	[FieldOffset(Offset = "0x9C")]
	private List<Color> MKHKGALFDJA;

	[Token(Token = "0x401AF36")]
	[FieldOffset(Offset = "0xA0")]
	private List<Vector4> FBOEABNOOEP;

	[Token(Token = "0x401AF37")]
	private const int JEMLEKBJFNE = 3;

	[Token(Token = "0x401AF38")]
	private const int PEBGEICFNJL = 12;

	[Token(Token = "0x401AF39")]
	public const int m_treeGroupIndNum = 8;

	[Token(Token = "0x401AF3A")]
	[FieldOffset(Offset = "0xA4")]
	private int HNJGMMBNMFF;

	[Token(Token = "0x401AF3B")]
	[FieldOffset(Offset = "0xA8")]
	private int IKGOICLJMNM;

	[Token(Token = "0x401AF3C")]
	private const int MFIIIKALCAO = 20;

	[Token(Token = "0x401AF3D")]
	[FieldOffset(Offset = "0xAC")]
	private int OFLLINPKAML;

	[Token(Token = "0x401AF3E")]
	[FieldOffset(Offset = "0xB0")]
	private int IOEEPJBDFDI;

	[Token(Token = "0x401AF3F")]
	[FieldOffset(Offset = "0xB4")]
	private int BJLOPGHFFLI;

	[Token(Token = "0x401AF40")]
	[FieldOffset(Offset = "0xB8")]
	private int FHPIALGHOHH;

	[Token(Token = "0x401AF41")]
	private const int HHEKEOFJBLA = 7000;

	[Token(Token = "0x401AF42")]
	[FieldOffset(Offset = "0xBC")]
	private int DIKAEDBKLEI;

	[Token(Token = "0x401AF43")]
	[FieldOffset(Offset = "0xC0")]
	private int IBJMBKHEGCI;

	[Token(Token = "0x401AF44")]
	public const float m_treeGroupFarClipPos = -100000f;

	[Token(Token = "0x401AF45")]
	[FieldOffset(Offset = "0x8")]
	private static float[] EDFFFJFOPAD;

	[Token(Token = "0x401AF46")]
	[FieldOffset(Offset = "0xC4")]
	private Dictionary<int, MPBAMGFMEAG> FGOBBMGBHBF;

	[Token(Token = "0x401AF47")]
	[FieldOffset(Offset = "0xC8")]
	private Dictionary<int, MPBAMGFMEAG> ELJOCIFBAPF;

	[Token(Token = "0x401AF48")]
	[FieldOffset(Offset = "0xCC")]
	private int[] PBKDOBBJEGN;

	[Token(Token = "0x401AF49")]
	[FieldOffset(Offset = "0xD0")]
	private int[] FJABDOEJNAD;

	[Token(Token = "0x401AF4A")]
	[FieldOffset(Offset = "0xD4")]
	private List<Vector3> HGDOJNNMFOI;

	[Token(Token = "0x401AF4B")]
	[FieldOffset(Offset = "0xD8")]
	private List<Vector3> AFDAPHFCINK;

	[Token(Token = "0x401AF4C")]
	[FieldOffset(Offset = "0xDC")]
	private List<Vector2> BNLBEPAOCLP;

	[Token(Token = "0x401AF4D")]
	[FieldOffset(Offset = "0xE0")]
	private List<Vector2> FHPOPBMALPL;

	[Token(Token = "0x401AF4E")]
	[FieldOffset(Offset = "0xE4")]
	private Mesh IDBMCCAAHDJ;

	[Token(Token = "0x401AF4F")]
	[FieldOffset(Offset = "0xE8")]
	private Mesh OHPGANBBCEC;

	[Token(Token = "0x401AF50")]
	[FieldOffset(Offset = "0xEC")]
	private Mesh FDNAMFABPFG;

	[Token(Token = "0x401AF51")]
	[FieldOffset(Offset = "0xF0")]
	private Vector3 HEOKBCHNFGE;

	[Token(Token = "0x401AF52")]
	[FieldOffset(Offset = "0xFC")]
	private Material LGGFMICMJAG;

	[Token(Token = "0x401AF53")]
	[FieldOffset(Offset = "0x100")]
	private Material NJJFIOMAMLP;

	[Token(Token = "0x401AF54")]
	[FieldOffset(Offset = "0x104")]
	private int OLHCBOAPLFB;

	[Token(Token = "0x401AF55")]
	[FieldOffset(Offset = "0x108")]
	private List<int> BGCIBPNMONL;

	[Token(Token = "0x401AF56")]
	[FieldOffset(Offset = "0x10C")]
	private List<int> PGPJKKHBBPK;

	[Token(Token = "0x401AF57")]
	[FieldOffset(Offset = "0x110")]
	private List<int> NBDHONAJIDK;

	[Token(Token = "0x401AF58")]
	[FieldOffset(Offset = "0x114")]
	private List<int> LKCJAMBABFP;

	[Token(Token = "0x401AF59")]
	[FieldOffset(Offset = "0x118")]
	private List<GGJKDECMHLP> CIPMMINMCDH;

	[Token(Token = "0x401AF5A")]
	[FieldOffset(Offset = "0x11C")]
	private List<GGJKDECMHLP> AGGBNJMALMJ;

	[Token(Token = "0x401AF5B")]
	[FieldOffset(Offset = "0x120")]
	private Dictionary<int, List<int>> LAFOLMIHKKC;

	[Token(Token = "0x401AF5C")]
	[FieldOffset(Offset = "0x124")]
	private Dictionary<int, List<int>> BCBHFGDKEIC;

	[Token(Token = "0x401AF5D")]
	[FieldOffset(Offset = "0x128")]
	private Dictionary<int, List<int>> HAFNOAJLGLB;

	[Token(Token = "0x401AF5E")]
	private const float CJEIJEOBMEC = 60f;

	[Token(Token = "0x401AF5F")]
	[FieldOffset(Offset = "0x12C")]
	private int CJNKCEMBKDC;

	[Token(Token = "0x401AF60")]
	[FieldOffset(Offset = "0x130")]
	private Dictionary<int, DCHCKODJALA> DGBJOIKIMPA;

	[Token(Token = "0x401AF61")]
	[FieldOffset(Offset = "0x134")]
	private Camera CPHNMPKFICJ;

	[Token(Token = "0x401AF62")]
	[FieldOffset(Offset = "0x138")]
	private byte AONEJCKJMDE;

	[Token(Token = "0x401AF63")]
	[FieldOffset(Offset = "0x139")]
	private byte IGBFIKHKNDD;

	[Token(Token = "0x401AF64")]
	[FieldOffset(Offset = "0x13C")]
	private Vector3 BINECKAOMKO;

	[Token(Token = "0x401AF65")]
	private const float ICEJHGFFDKC = 6f;

	[Token(Token = "0x401AF66")]
	private const float DCKJDOOGMNL = 12f;

	[Token(Token = "0x401AF67")]
	[FieldOffset(Offset = "0xC")]
	private static float KJPJHHEIBGD;

	[Token(Token = "0x401AF68")]
	[FieldOffset(Offset = "0x10")]
	private static float MBIMEOPIFLL;

	[Token(Token = "0x401AF69")]
	[FieldOffset(Offset = "0x148")]
	private int AKGDMHJFIDJ;

	[Token(Token = "0x401AF6A")]
	[FieldOffset(Offset = "0x14C")]
	public int m_treeTypeBias;

	[Token(Token = "0x401AF6B")]
	[FieldOffset(Offset = "0x150")]
	public bool m_IsVariableTreeTypeBias;

	[Token(Token = "0x401AF6C")]
	[FieldOffset(Offset = "0x154")]
	private short[] DPHHHANKKNG;

	[Token(Token = "0x401AF6D")]
	[FieldOffset(Offset = "0x158")]
	private List<short> CAGOCCEFEMO;

	[Token(Token = "0x401AF6E")]
	[FieldOffset(Offset = "0x15C")]
	private short[,] KEIEJKDJFED;

	[Token(Token = "0x401AF6F")]
	[FieldOffset(Offset = "0x160")]
	private Material DEAIADBCIIA;

	[Token(Token = "0x401AF70")]
	[FieldOffset(Offset = "0x164")]
	private Material APLFHENIKJM;

	[Token(Token = "0x401AF71")]
	[FieldOffset(Offset = "0x168")]
	private SceneGraphics LBEHNMJPDGC;

	[Token(Token = "0x401AF72")]
	[FieldOffset(Offset = "0x16C")]
	private Vector2 HJPDMLOKICD;

	[Token(Token = "0x401AF73")]
	[FieldOffset(Offset = "0x174")]
	private Vector2 HFNEDOIHFDK;

	[Token(Token = "0x401AF74")]
	[FieldOffset(Offset = "0x17C")]
	private List<int> PCHDMHPLAMC;

	[Token(Token = "0x401AF75")]
	[FieldOffset(Offset = "0x180")]
	private bool JOHGANNHHOG;

	[Token(Token = "0x401AF76")]
	[FieldOffset(Offset = "0x184")]
	private List<GGJKDECMHLP> BDOHGEMNOGL;

	[Token(Token = "0x401AF77")]
	[FieldOffset(Offset = "0x188")]
	private List<GGJKDECMHLP> AMLNOEDKPMO;

	[Token(Token = "0x401AF78")]
	[FieldOffset(Offset = "0x18C")]
	public GameObject m_treeRootGO;

	[Token(Token = "0x401AF79")]
	[FieldOffset(Offset = "0x190")]
	public GrassSystem m_grassSystem;

	[Token(Token = "0x401AF7A")]
	[FieldOffset(Offset = "0x14")]
	private static bool HKNPLNEJMHE;

	[Token(Token = "0x401AF7B")]
	[FieldOffset(Offset = "0x15")]
	private static bool FLGFKIBLDOL;

	[Token(Token = "0x401AF7C")]
	[FieldOffset(Offset = "0x194")]
	public bool m_UseHoudiniData;

	[Token(Token = "0x401AF7D")]
	[FieldOffset(Offset = "0x198")]
	private HashSet<Texture> NHDHPGACFKP;

	[Token(Token = "0x401AF7E")]
	[FieldOffset(Offset = "0x19C")]
	private int DMCLJEJKKPG;

	[Token(Token = "0x401AF7F")]
	[FieldOffset(Offset = "0x1A0")]
	private bool EANCDNPPOON;

	[Token(Token = "0x401AF80")]
	[FieldOffset(Offset = "0x1A1")]
	private bool FKHLMOKLEGJ;

	[Token(Token = "0x401AF81")]
	[FieldOffset(Offset = "0x1A2")]
	private bool ONEKEMPGEMM;

	[Token(Token = "0x401AF82")]
	[FieldOffset(Offset = "0x1A3")]
	private bool GNPHIOIAIJO;

	[Token(Token = "0x401AF83")]
	[FieldOffset(Offset = "0x1A4")]
	private bool EOKKAPAONOO;

	[Token(Token = "0x401AF84")]
	[FieldOffset(Offset = "0x1A5")]
	private bool NJOFOPNDFNG;

	[Token(Token = "0x401AF85")]
	[FieldOffset(Offset = "0x1A6")]
	private bool HIIMMMPAEGL;

	[Token(Token = "0x401AF86")]
	[FieldOffset(Offset = "0x1A7")]
	private bool OAKEODCBMAI;

	[Token(Token = "0x401AF87")]
	[FieldOffset(Offset = "0x1A8")]
	private bool NKCFBCEALKN;

	[Token(Token = "0x401AF88")]
	[FieldOffset(Offset = "0x1AC")]
	private Vector2[] HMOOJLJMNFK;

	[Token(Token = "0x401AF89")]
	[FieldOffset(Offset = "0x1B0")]
	private int GFMKJMIKDPD;

	[Token(Token = "0x401AF8A")]
	[FieldOffset(Offset = "0x1B4")]
	private int PEHMCMPIANJ;

	[Token(Token = "0x17001CA9")]
	public List<COMLDLAPCNK> IEIBDEMKIDN
	{
		[Token(Token = "0x601A15C")]
		[Address(RVA = "0x1D3E144", Offset = "0x1D3E144", VA = "0x1D3E144")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A15D")]
		[Address(RVA = "0x1D3E14C", Offset = "0x1D3E14C", VA = "0x1D3E14C")]
		private set
		{
		}
	}

	[Token(Token = "0x601A15B")]
	[Address(RVA = "0x1D3D678", Offset = "0x1D3D678", VA = "0x1D3D678")]
	public TreeSystem()
	{
	}

	[Token(Token = "0x601A15E")]
	[Address(RVA = "0x1D3E154", Offset = "0x1D3E154", VA = "0x1D3E154")]
	private void Start()
	{
	}

	[Token(Token = "0x601A15F")]
	[Address(RVA = "0x1D3FAF0", Offset = "0x1D3FAF0", VA = "0x1D3FAF0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x601A160")]
	[Address(RVA = "0x1D3E694", Offset = "0x1D3E694", VA = "0x1D3E694")]
	public void Init()
	{
	}

	[Token(Token = "0x601A161")]
	[Address(RVA = "0x1D40668", Offset = "0x1D40668", VA = "0x1D40668")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x601A162")]
	[Address(RVA = "0x1D4070C", Offset = "0x1D4070C", VA = "0x1D4070C")]
	public void SimuateVegetation(bool FAECNAIHJKK = false)
	{
	}

	[Token(Token = "0x601A163")]
	[Address(RVA = "0x1D3F92C", Offset = "0x1D3F92C", VA = "0x1D3F92C")]
	public void InitVegetationMeshes()
	{
	}

	[Token(Token = "0x601A164")]
	[Address(RVA = "0x1D3E2B8", Offset = "0x1D3E2B8", VA = "0x1D3E2B8")]
	private void HCIAMEBBCJH()
	{
	}

	[Token(Token = "0x601A165")]
	[Address(RVA = "0x1D3FC60", Offset = "0x1D3FC60", VA = "0x1D3FC60")]
	private bool IBPBPMLCDCP()
	{
		return default(bool);
	}

	[Token(Token = "0x601A166")]
	[Address(RVA = "0x1D3FDE4", Offset = "0x1D3FDE4", VA = "0x1D3FDE4")]
	private bool EFHDCCHDKJO()
	{
		return default(bool);
	}

	[Token(Token = "0x601A167")]
	[Address(RVA = "0x1D3FF68", Offset = "0x1D3FF68", VA = "0x1D3FF68")]
	private bool ACOJDPCJJIB()
	{
		return default(bool);
	}

	[Token(Token = "0x601A168")]
	[Address(RVA = "0x1D400EC", Offset = "0x1D400EC", VA = "0x1D400EC")]
	private bool JDLDDNJEIPC()
	{
		return default(bool);
	}

	[Token(Token = "0x601A169")]
	[Address(RVA = "0x1D40178", Offset = "0x1D40178", VA = "0x1D40178")]
	private bool GECKOMMDKMI()
	{
		return default(bool);
	}

	[Token(Token = "0x601A16A")]
	[Address(RVA = "0x1D402FC", Offset = "0x1D402FC", VA = "0x1D402FC")]
	private bool PBEDELBEHMF()
	{
		return default(bool);
	}

	[Token(Token = "0x601A16B")]
	[Address(RVA = "0x1D43ED8", Offset = "0x1D43ED8", VA = "0x1D43ED8")]
	private void APPGNPHBKHB()
	{
	}

	[Token(Token = "0x601A16C")]
	[Address(RVA = "0x1D48C00", Offset = "0x1D48C00", VA = "0x1D48C00")]
	private void HPNABCKGGCO(Texture NKFJCJGKFJF, ref int GGAPJKPDFGE)
	{
	}

	[Token(Token = "0x601A16D")]
	[Address(RVA = "0x1D48C94", Offset = "0x1D48C94", VA = "0x1D48C94")]
	private void AKAGINIOHIP()
	{
	}

	[Token(Token = "0x601A16E")]
	[Address(RVA = "0x1D47C20", Offset = "0x1D47C20", VA = "0x1D47C20")]
	private void GMKOKMNMAMO()
	{
	}

	[Token(Token = "0x601A16F")]
	[Address(RVA = "0x1D491A0", Offset = "0x1D491A0", VA = "0x1D491A0")]
	public Material GetTreeMaterial(COMLDLAPCNK APMKOBBEABC)
	{
		return null;
	}

	[Token(Token = "0x601A170")]
	[Address(RVA = "0x1D4927C", Offset = "0x1D4927C", VA = "0x1D4927C")]
	public MaterialPropertyBlock GetTreeMaterialPropBlock(COMLDLAPCNK APMKOBBEABC)
	{
		return null;
	}

	[Token(Token = "0x601A171")]
	[Address(RVA = "0x1D3BD48", Offset = "0x1D3BD48", VA = "0x1D3BD48")]
	public void OnScreenShotRendering()
	{
	}

	[Token(Token = "0x601A172")]
	[Address(RVA = "0x1D42220", Offset = "0x1D42220", VA = "0x1D42220")]
	private void NFBOHCBACMH()
	{
	}

	[Token(Token = "0x601A173")]
	[Address(RVA = "0x1D49358", Offset = "0x1D49358", VA = "0x1D49358")]
	private void LNOEIGGGFPD()
	{
	}

	[Token(Token = "0x601A174")]
	[Address(RVA = "0x1D49980", Offset = "0x1D49980", VA = "0x1D49980")]
	private void MFBJNNHLBCJ()
	{
	}

	[Token(Token = "0x601A175")]
	[Address(RVA = "0x1D4095C", Offset = "0x1D4095C", VA = "0x1D4095C")]
	private void HHKDGGPMBIP()
	{
	}

	[Token(Token = "0x601A176")]
	[Address(RVA = "0x1D4B298", Offset = "0x1D4B298", VA = "0x1D4B298")]
	private Vector2 BHKOCDAFHCG(Vector2 ACCOJJMKKPM, Vector2 EBIJHALKJEM)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x601A177")]
	[Address(RVA = "0x1D49C74", Offset = "0x1D49C74", VA = "0x1D49C74")]
	private void AILEALOFAIK(Vector2 FHOKBMGKCAP, Vector2 JOOCJDDCHMD, ref Vector2 FMJKICBEBML, ref Vector2 HLFJOKEOBKA, float PENKLFFDABD)
	{
	}

	[Token(Token = "0x601A178")]
	[Address(RVA = "0x1D4A600", Offset = "0x1D4A600", VA = "0x1D4A600")]
	private void AFBEJAFIPJD(Vector2 FHOKBMGKCAP, Vector2 JOOCJDDCHMD, ref Vector2 FMJKICBEBML, ref Vector2 HLFJOKEOBKA, float PENKLFFDABD)
	{
	}

	[Token(Token = "0x601A179")]
	[Address(RVA = "0x1D4B400", Offset = "0x1D4B400", VA = "0x1D4B400")]
	private bool OMKFKOILNKN(ref Vector2 FMJKICBEBML, ref Vector2 HLFJOKEOBKA, float PENKLFFDABD, ref Vector2 AKDPEGLAEFC, ref Vector2 DMHBKBPPOCO)
	{
		return default(bool);
	}

	[Token(Token = "0x601A17A")]
	[Address(RVA = "0x1D3BB98", Offset = "0x1D3BB98", VA = "0x1D3BB98")]
	public void OnCameraChanged(Camera GNKJBPHOOIB)
	{
	}

	[Token(Token = "0x601A17B")]
	[Address(RVA = "0x1D4102C", Offset = "0x1D4102C", VA = "0x1D4102C")]
	private void HHODNNOHMHK()
	{
	}

	[Token(Token = "0x601A17C")]
	[Address(RVA = "0x1D4B8C8", Offset = "0x1D4B8C8", VA = "0x1D4B8C8")]
	private void POGLHPHGOEB(ref Vector2 FMJKICBEBML, ref Vector2 HLFJOKEOBKA, float PENKLFFDABD)
	{
	}

	[Token(Token = "0x601A17D")]
	[Address(RVA = "0x1D4E1EC", Offset = "0x1D4E1EC", VA = "0x1D4E1EC")]
	private void IOMJIFHGEMH()
	{
	}

	[Token(Token = "0x601A17E")]
	[Address(RVA = "0x1D4F538", Offset = "0x1D4F538", VA = "0x1D4F538")]
	private void CNHJLNFEFAA(ref int MPOEOIGIOAB, ref short MMBLMGFNKED, ref int OJCCKCIONDP, ref int INMOGLOOLBJ)
	{
	}

	[Token(Token = "0x601A17F")]
	[Address(RVA = "0x1D4FC28", Offset = "0x1D4FC28", VA = "0x1D4FC28")]
	private void MBKPKMHJDLE(bool MCDIDHODHLN)
	{
	}

	[Token(Token = "0x601A180")]
	[Address(RVA = "0x1D41354", Offset = "0x1D41354", VA = "0x1D41354")]
	private void OGJPCNLHKAH()
	{
	}

	[Token(Token = "0x601A181")]
	[Address(RVA = "0x1D4F064", Offset = "0x1D4F064", VA = "0x1D4F064")]
	private void KKKFPJGDAPK(ref OHIOKAOHMJL HIDIODNIGGF, int IDNEFEOPGIF, byte LMHNGDLHLCP, byte HKHPEOAGGGK, byte EAMKDGINABE)
	{
	}

	[Token(Token = "0x601A182")]
	[Address(RVA = "0x1D4F41C", Offset = "0x1D4F41C", VA = "0x1D4F41C")]
	private float MEKDAIKGAJK(ref OHIOKAOHMJL HIDIODNIGGF, int PLLHBNLKHDH, int HHJOGKBAFNF, int OHEKABCKNDI)
	{
		return default(float);
	}

	[Token(Token = "0x601A183")]
	[Address(RVA = "0x1D4EFBC", Offset = "0x1D4EFBC", VA = "0x1D4EFBC")]
	private void BNBNFGDBGHA(ref OHIOKAOHMJL HIDIODNIGGF)
	{
	}

	[Token(Token = "0x601A184")]
	[Address(RVA = "0x1D4FC9C", Offset = "0x1D4FC9C", VA = "0x1D4FC9C")]
	public void ClearVisibleBushGroup()
	{
	}

	[Token(Token = "0x601A185")]
	[Address(RVA = "0x1D4FD40", Offset = "0x1D4FD40", VA = "0x1D4FD40")]
	public void RecycleBushGroupList()
	{
	}

	[Token(Token = "0x601A186")]
	[Address(RVA = "0x1D4FDEC", Offset = "0x1D4FDEC", VA = "0x1D4FDEC")]
	public void AddBushGroup(int OAHDNLIDOAM, List<int> HLFBDFLHMKO, int DEAIOEKELKG, int IALPDEBJINK, float FKFAJDCGALA = 0f)
	{
	}
}
