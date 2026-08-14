using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x2003F5C")]
public class GrassSystem : MonoBehaviour
{
	[Token(Token = "0x2003F5D")]
	public struct IACMEJKFJDJ
	{
		[Token(Token = "0x401ABB6")]
		[FieldOffset(Offset = "0x0")]
		public float OEFEMAKCKIB;

		[Token(Token = "0x401ABB7")]
		[FieldOffset(Offset = "0x4")]
		public int HKNABIAJKNJ;

		[Token(Token = "0x401ABB8")]
		[FieldOffset(Offset = "0x8")]
		public int GNIHHMJPNCJ;

		[Token(Token = "0x401ABB9")]
		[FieldOffset(Offset = "0xC")]
		public int NKMEKOPOHPM;

		[Token(Token = "0x401ABBA")]
		[FieldOffset(Offset = "0x10")]
		public int OKAJLKFCIJK;

		[Token(Token = "0x401ABBB")]
		[FieldOffset(Offset = "0x14")]
		public int NPELJEGFEOC;

		[Token(Token = "0x401ABBC")]
		[FieldOffset(Offset = "0x18")]
		public int FAAFODLMDPL;

		[Token(Token = "0x401ABBD")]
		[FieldOffset(Offset = "0x1C")]
		public bool DFCDLJPPCID;

		[Token(Token = "0x6019D00")]
		[Address(RVA = "0x93CF10", Offset = "0x93CF10", VA = "0x93CF10")]
		public IACMEJKFJDJ(int LMHNGDLHLCP, int HKHPEOAGGGK, float FKFAJDCGALA = 0f, int PPMBHPKMLDD = -1, int FMHMCNICJIL = -1, int MAMOJLPPLJN = 0, int CLIMNDPOMIE = 0)
		{
		}
	}

	[Token(Token = "0x2003F5E")]
	public struct NEFJAGOKOOO
	{
		[Token(Token = "0x401ABBE")]
		[FieldOffset(Offset = "0x0")]
		public int FAAJFDKBKDC;

		[Token(Token = "0x401ABBF")]
		[FieldOffset(Offset = "0x4")]
		public int OIAIBBGIDEE;

		[Token(Token = "0x6019D01")]
		[Address(RVA = "0x93CF40", Offset = "0x93CF40", VA = "0x93CF40")]
		public NEFJAGOKOOO(int BNDPJDJAFOM, int HIPCLFGCBNI)
		{
		}
	}

	[Token(Token = "0x2003F5F")]
	private class FIDLIBGEHPB : _Attribute
	{
		[Token(Token = "0x6019D02")]
		[Address(RVA = "0x25AB67C", Offset = "0x25AB67C", VA = "0x25AB67C")]
		public FIDLIBGEHPB()
		{
		}

		[Token(Token = "0x6019D03")]
		[Address(RVA = "0x25BF358", Offset = "0x25BF358", VA = "0x25BF358", Slot = "4")]
		public int Compare(NEFJAGOKOOO NHJNFPKBBLI, NEFJAGOKOOO LGALHNNDGNE)
		{
			return default(int);
		}
	}

	[Token(Token = "0x401AB52")]
	[FieldOffset(Offset = "0xC")]
	public string m_mapName;

	[Token(Token = "0x401AB53")]
	[FieldOffset(Offset = "0x10")]
	public GameObject m_grassPrefab0;

	[Token(Token = "0x401AB54")]
	[FieldOffset(Offset = "0x14")]
	public GameObject m_grassPrefab1;

	[Token(Token = "0x401AB55")]
	[FieldOffset(Offset = "0x18")]
	public GameObject m_grassPrefab2;

	[Token(Token = "0x401AB56")]
	[FieldOffset(Offset = "0x1C")]
	public List<GameObject> m_grassPrefabList;

	[Token(Token = "0x401AB57")]
	[FieldOffset(Offset = "0x20")]
	public List<string> m_grassPrefabResNameList;

	[Token(Token = "0x401AB58")]
	[FieldOffset(Offset = "0x24")]
	public GameObject m_grassBillboardPrefab;

	[Token(Token = "0x401AB59")]
	[FieldOffset(Offset = "0x28")]
	public string m_grassPrefab0_ResName;

	[Token(Token = "0x401AB5A")]
	[FieldOffset(Offset = "0x2C")]
	public string m_grassPrefab1_ResName;

	[Token(Token = "0x401AB5B")]
	[FieldOffset(Offset = "0x30")]
	public string m_grassPrefab2_ResName;

	[Token(Token = "0x401AB5C")]
	[FieldOffset(Offset = "0x34")]
	private List<GrassInst> KINNOFJAOIN;

	[Token(Token = "0x401AB5D")]
	[FieldOffset(Offset = "0x38")]
	public float m_grassMaskStartX;

	[Token(Token = "0x401AB5E")]
	[FieldOffset(Offset = "0x3C")]
	public float m_grassMaskStartZ;

	[Token(Token = "0x401AB5F")]
	[FieldOffset(Offset = "0x40")]
	public float m_grassMaskStartY;

	[Token(Token = "0x401AB60")]
	[FieldOffset(Offset = "0x44")]
	public float m_grassMaskSizeX;

	[Token(Token = "0x401AB61")]
	[FieldOffset(Offset = "0x48")]
	public float m_grassMaskSizeZ;

	[Token(Token = "0x401AB62")]
	[FieldOffset(Offset = "0x4C")]
	public float m_grassMaskSizeY;

	[Token(Token = "0x401AB63")]
	public const float m_grassMaskCellSize = 60f;

	[Token(Token = "0x401AB64")]
	public const float m_grassMaskSubCellSize = 20f;

	[Token(Token = "0x401AB65")]
	public const float m_grassViewDist = 100f;

	[Token(Token = "0x401AB66")]
	[FieldOffset(Offset = "0x50")]
	public bool m_UseHoudiniData;

	[Token(Token = "0x401AB67")]
	[FieldOffset(Offset = "0x51")]
	public bool m_UseHoudiniPrefabRemapUV;

	[Token(Token = "0x401AB68")]
	[FieldOffset(Offset = "0x54")]
	public int m_grassCellNumW;

	[Token(Token = "0x401AB69")]
	[FieldOffset(Offset = "0x58")]
	public int m_grassCellNumH;

	[Token(Token = "0x401AB6A")]
	public const int m_grassSubCellNumW = 3;

	[Token(Token = "0x401AB6B")]
	public const int m_grassSubCellNumH = 3;

	[Token(Token = "0x401AB6C")]
	[FieldOffset(Offset = "0x5C")]
	private int JEICMFJNAGG;

	[Token(Token = "0x401AB6D")]
	[FieldOffset(Offset = "0x60")]
	private int BMHDGPMNKAE;

	[Token(Token = "0x401AB6E")]
	[FieldOffset(Offset = "0x0")]
	private static int[] CJGAEANEFOB;

	[Token(Token = "0x401AB6F")]
	[FieldOffset(Offset = "0x64")]
	private Vector2[] BAAMDNBLGFM;

	[Token(Token = "0x401AB70")]
	[FieldOffset(Offset = "0x4")]
	private static int[] LNEMDHFJOCP;

	[Token(Token = "0x401AB71")]
	[FieldOffset(Offset = "0x8")]
	private static int EBNILGACOBE;

	[Token(Token = "0x401AB72")]
	[FieldOffset(Offset = "0xC")]
	private static int BGBCPBOAIFB;

	[Token(Token = "0x401AB73")]
	[FieldOffset(Offset = "0x10")]
	private static float OCEFGGIKIBO;

	[Token(Token = "0x401AB74")]
	[FieldOffset(Offset = "0x14")]
	private static int[] OGEKFHBMBIM;

	[Token(Token = "0x401AB75")]
	[FieldOffset(Offset = "0x18")]
	private static float[,] CJEFLHCHOJO;

	[Token(Token = "0x401AB76")]
	[FieldOffset(Offset = "0x68")]
	private float AEOMIAHPCME;

	[Token(Token = "0x401AB77")]
	[FieldOffset(Offset = "0x6C")]
	private float IBIACCKMOEG;

	[Token(Token = "0x401AB78")]
	[FieldOffset(Offset = "0x70")]
	private float DANFDDIACLN;

	[Token(Token = "0x401AB79")]
	[FieldOffset(Offset = "0x74")]
	private float DNFPFEHMCPG;

	[Token(Token = "0x401AB7A")]
	[FieldOffset(Offset = "0x78")]
	private int JAFKKDOEGJB;

	[Token(Token = "0x401AB7B")]
	[FieldOffset(Offset = "0x7C")]
	private int JDAHCALPDKD;

	[Token(Token = "0x401AB7C")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<int, List<Vector3>> NMCFNBOFMHO;

	[Token(Token = "0x401AB7D")]
	[FieldOffset(Offset = "0x84")]
	private Dictionary<int, List<Vector3>> EFBBECDMKDF;

	[Token(Token = "0x401AB7E")]
	[FieldOffset(Offset = "0x88")]
	private Dictionary<int, List<Vector2>> GBFOPBOMHHK;

	[Token(Token = "0x401AB7F")]
	[FieldOffset(Offset = "0x8C")]
	private Dictionary<int, List<Color32>> FOBAODDMPMJ;

	[Token(Token = "0x401AB80")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<int, List<int>> DHMGAJEEPPH;

	[Token(Token = "0x401AB81")]
	[FieldOffset(Offset = "0x94")]
	private List<Vector3> MMLBHEKLFCH;

	[Token(Token = "0x401AB82")]
	[FieldOffset(Offset = "0x98")]
	private List<Vector2> JDHEHOFFHEO;

	[Token(Token = "0x401AB83")]
	[FieldOffset(Offset = "0x9C")]
	private List<int> CLOGFBANKLL;

	[Token(Token = "0x401AB84")]
	[FieldOffset(Offset = "0xA0")]
	private Material CLDEDCHMACL;

	[Token(Token = "0x401AB85")]
	[FieldOffset(Offset = "0xA4")]
	private Material KODKMAIMCIM;

	[Token(Token = "0x401AB86")]
	[FieldOffset(Offset = "0xA8")]
	private List<Vector3> OFLECPBGHAC;

	[Token(Token = "0x401AB87")]
	[FieldOffset(Offset = "0xAC")]
	private List<Color32> OOOLHHJOJKI;

	[Token(Token = "0x401AB88")]
	[FieldOffset(Offset = "0xB0")]
	private List<Vector3> BLHFBDJHLOO;

	[Token(Token = "0x401AB89")]
	[FieldOffset(Offset = "0xB4")]
	private List<Vector3> PEAEPOBGKBE;

	[Token(Token = "0x401AB8A")]
	[FieldOffset(Offset = "0xB8")]
	private List<Color32> HFALGCOIGPF;

	[Token(Token = "0x401AB8B")]
	[FieldOffset(Offset = "0xBC")]
	private Mesh HKHBIOGKENM;

	[Token(Token = "0x401AB8C")]
	[FieldOffset(Offset = "0xC0")]
	private Mesh CBPJMLCGIJP;

	[Token(Token = "0x401AB8D")]
	[FieldOffset(Offset = "0xC4")]
	private Camera CPHNMPKFICJ;

	[Token(Token = "0x401AB8E")]
	[FieldOffset(Offset = "0xC8")]
	private HashSet<Texture> BDICPOLIPOM;

	[Token(Token = "0x401AB8F")]
	[FieldOffset(Offset = "0xCC")]
	private GrassCell[] NKOKLOJGBKH;

	[Token(Token = "0x401AB90")]
	[FieldOffset(Offset = "0xD0")]
	private Dictionary<GrassSubCell, IACMEJKFJDJ> MBDLOHNGHPB;

	[Token(Token = "0x401AB91")]
	[FieldOffset(Offset = "0xD4")]
	private Dictionary<GrassSubCell, IACMEJKFJDJ> DHPNCLCFLBH;

	[Token(Token = "0x401AB92")]
	[FieldOffset(Offset = "0xD8")]
	private Dictionary<GrassSubCell, IACMEJKFJDJ> AAHGNPNKGLF;

	[Token(Token = "0x401AB93")]
	[FieldOffset(Offset = "0xDC")]
	private List<GrassSubCell> HOEBJKCKEOD;

	[Token(Token = "0x401AB94")]
	[FieldOffset(Offset = "0xE0")]
	private List<GrassSubCell> EHIKAOPEIFB;

	[Token(Token = "0x401AB95")]
	[FieldOffset(Offset = "0xE4")]
	private List<GrassSubCell> MJHDEILNKCI;

	[Token(Token = "0x401AB96")]
	[FieldOffset(Offset = "0xE8")]
	private List<GrassSubCell> BCDEFHHDAJP;

	[Token(Token = "0x401AB97")]
	[FieldOffset(Offset = "0xEC")]
	private List<GrassSubCell> AFMLDNMFAOG;

	[Token(Token = "0x401AB98")]
	[FieldOffset(Offset = "0xF0")]
	private List<NEFJAGOKOOO> FJINPKKHOFP;

	[Token(Token = "0x401AB99")]
	[FieldOffset(Offset = "0xF4")]
	private List<NEFJAGOKOOO> CKJLIHDELNK;

	[Token(Token = "0x401AB9A")]
	[FieldOffset(Offset = "0xF8")]
	private FIDLIBGEHPB JIBEKPMHHGH;

	[Token(Token = "0x401AB9B")]
	[FieldOffset(Offset = "0xFC")]
	private bool KOFACBFCNNC;

	[Token(Token = "0x401AB9C")]
	[FieldOffset(Offset = "0xFD")]
	private bool PJFOIDGPNLG;

	[Token(Token = "0x401AB9D")]
	[FieldOffset(Offset = "0xFE")]
	private bool PJOJIIOFJEE;

	[Token(Token = "0x401AB9E")]
	[FieldOffset(Offset = "0x100")]
	private int MABHAHNALBD;

	[Token(Token = "0x401AB9F")]
	[FieldOffset(Offset = "0x104")]
	private bool GJCDALGNMMJ;

	[Token(Token = "0x401ABA0")]
	[FieldOffset(Offset = "0x108")]
	public float[] m_spriteScale;

	[Token(Token = "0x401ABA1")]
	[FieldOffset(Offset = "0x10C")]
	public TreeSystem m_treeSystem;

	[Token(Token = "0x401ABA2")]
	[FieldOffset(Offset = "0x110")]
	private SceneGraphics LBEHNMJPDGC;

	[Token(Token = "0x401ABA3")]
	[FieldOffset(Offset = "0x114")]
	private uint _003CBNPGHLEEFPA_003Ek__BackingField;

	[Token(Token = "0x401ABA4")]
	[FieldOffset(Offset = "0x118")]
	private bool _003CNMLCOCDNMKD_003Ek__BackingField;

	[Token(Token = "0x401ABA5")]
	[FieldOffset(Offset = "0x11C")]
	private float _003CMEEBNNHHCIL_003Ek__BackingField;

	[Token(Token = "0x401ABA6")]
	[FieldOffset(Offset = "0x120")]
	private float _003CGOBNBPHOEPO_003Ek__BackingField;

	[Token(Token = "0x401ABA7")]
	[FieldOffset(Offset = "0x124")]
	private int MFGPEPCFPNO;

	[Token(Token = "0x401ABA8")]
	[FieldOffset(Offset = "0x128")]
	private Quaternion OFBBDNNBEGD;

	[Token(Token = "0x401ABA9")]
	[FieldOffset(Offset = "0x138")]
	private Vector3 JBOPOKPDALD;

	[Token(Token = "0x401ABAA")]
	[FieldOffset(Offset = "0x144")]
	private bool EANCDNPPOON;

	[Token(Token = "0x401ABAB")]
	[FieldOffset(Offset = "0x145")]
	private bool FKHLMOKLEGJ;

	[Token(Token = "0x401ABAC")]
	[FieldOffset(Offset = "0x146")]
	private bool ONEKEMPGEMM;

	[Token(Token = "0x401ABAD")]
	[FieldOffset(Offset = "0x147")]
	private bool GNPHIOIAIJO;

	[Token(Token = "0x401ABAE")]
	[FieldOffset(Offset = "0x148")]
	private bool EOKKAPAONOO;

	[Token(Token = "0x401ABAF")]
	[FieldOffset(Offset = "0x149")]
	private bool HKNPLNEJMHE;

	[Token(Token = "0x401ABB0")]
	[FieldOffset(Offset = "0x14A")]
	private bool GDHECFOAHIA;

	[Token(Token = "0x401ABB1")]
	[FieldOffset(Offset = "0x14B")]
	private bool JJEMAIJELFL;

	[Token(Token = "0x401ABB2")]
	[FieldOffset(Offset = "0x14C")]
	private bool NKCFBCEALKN;

	[Token(Token = "0x401ABB3")]
	[FieldOffset(Offset = "0x150")]
	private float HCNOIJKFFFG;

	[Token(Token = "0x401ABB4")]
	[FieldOffset(Offset = "0x154")]
	private Dictionary<GrassSubCell, IACMEJKFJDJ> HONEHFEFKFE;

	[Token(Token = "0x401ABB5")]
	[FieldOffset(Offset = "0x158")]
	private Vector2[] HMOOJLJMNFK;

	[Token(Token = "0x17001C2D")]
	public List<GrassInst> CHLGAABFOIP
	{
		[Token(Token = "0x6019CC7")]
		[Address(RVA = "0x25AB684", Offset = "0x25AB684", VA = "0x25AB684")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019CC8")]
		[Address(RVA = "0x25AB68C", Offset = "0x25AB68C", VA = "0x25AB68C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001C2E")]
	public List<GrassSubCell> EOIODLFDDHB
	{
		[Token(Token = "0x6019CC9")]
		[Address(RVA = "0x25AB694", Offset = "0x25AB694", VA = "0x25AB694")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019CCA")]
		[Address(RVA = "0x25AB69C", Offset = "0x25AB69C", VA = "0x25AB69C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001C2F")]
	public uint KKINDPLBAIJ
	{
		[Token(Token = "0x6019CCB")]
		[Address(RVA = "0x25AB6A4", Offset = "0x25AB6A4", VA = "0x25AB6A4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6019CCC")]
		[Address(RVA = "0x25AB6AC", Offset = "0x25AB6AC", VA = "0x25AB6AC")]
		private set
		{
		}
	}

	[Token(Token = "0x17001C30")]
	public bool PCFPBGHILGB
	{
		[Token(Token = "0x6019CCD")]
		[Address(RVA = "0x25AB6B4", Offset = "0x25AB6B4", VA = "0x25AB6B4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6019CCE")]
		[Address(RVA = "0x25AB6BC", Offset = "0x25AB6BC", VA = "0x25AB6BC")]
		private set
		{
		}
	}

	[Token(Token = "0x17001C31")]
	public float MEFHOHJFPMB
	{
		[Token(Token = "0x6019CCF")]
		[Address(RVA = "0x25AB6C4", Offset = "0x25AB6C4", VA = "0x25AB6C4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6019CD0")]
		[Address(RVA = "0x25AB6CC", Offset = "0x25AB6CC", VA = "0x25AB6CC")]
		private set
		{
		}
	}

	[Token(Token = "0x17001C32")]
	public float COFJPAKIKMB
	{
		[Token(Token = "0x6019CD1")]
		[Address(RVA = "0x25AB6D4", Offset = "0x25AB6D4", VA = "0x25AB6D4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6019CD2")]
		[Address(RVA = "0x25AB6DC", Offset = "0x25AB6DC", VA = "0x25AB6DC")]
		private set
		{
		}
	}

	[Token(Token = "0x6019CC6")]
	[Address(RVA = "0x25AB098", Offset = "0x25AB098", VA = "0x25AB098")]
	public GrassSystem()
	{
	}

	[Token(Token = "0x6019CD3")]
	[Address(RVA = "0x25AB6E4", Offset = "0x25AB6E4", VA = "0x25AB6E4")]
	private bool IBPBPMLCDCP()
	{
		return default(bool);
	}

	[Token(Token = "0x6019CD4")]
	[Address(RVA = "0x25AB7F8", Offset = "0x25AB7F8", VA = "0x25AB7F8")]
	private bool EFHDCCHDKJO()
	{
		return default(bool);
	}

	[Token(Token = "0x6019CD5")]
	[Address(RVA = "0x25AB90C", Offset = "0x25AB90C", VA = "0x25AB90C")]
	private bool ACOJDPCJJIB()
	{
		return default(bool);
	}

	[Token(Token = "0x6019CD6")]
	[Address(RVA = "0x25ABA20", Offset = "0x25ABA20", VA = "0x25ABA20")]
	private bool JDLDDNJEIPC()
	{
		return default(bool);
	}

	[Token(Token = "0x6019CD7")]
	[Address(RVA = "0x25ABAAC", Offset = "0x25ABAAC", VA = "0x25ABAAC")]
	private bool GECKOMMDKMI()
	{
		return default(bool);
	}

	[Token(Token = "0x6019CD8")]
	[Address(RVA = "0x25ABBC0", Offset = "0x25ABBC0", VA = "0x25ABBC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6019CD9")]
	[Address(RVA = "0x25AF400", Offset = "0x25AF400", VA = "0x25AF400")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6019CDA")]
	[Address(RVA = "0x25AC188", Offset = "0x25AC188", VA = "0x25AC188")]
	private void GAFEPBNNLAK()
	{
	}

	[Token(Token = "0x6019CDB")]
	[Address(RVA = "0x25AF570", Offset = "0x25AF570", VA = "0x25AF570")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6019CDC")]
	[Address(RVA = "0x25AF8C8", Offset = "0x25AF8C8", VA = "0x25AF8C8")]
	private void JBKBNPHALLI()
	{
	}

	[Token(Token = "0x6019CDD")]
	[Address(RVA = "0x25BAA4C", Offset = "0x25BAA4C", VA = "0x25BAA4C")]
	public void OnCameraTypeChanged(int FMDLIFDMEBC, int FCFFIGONDPN)
	{
	}

	[Token(Token = "0x6019CDE")]
	[Address(RVA = "0x25BAA68", Offset = "0x25BAA68", VA = "0x25BAA68")]
	public void OnSceneLoaded()
	{
	}

	[Token(Token = "0x6019CDF")]
	[Address(RVA = "0x25BAB44", Offset = "0x25BAB44", VA = "0x25BAB44")]
	public string CombinePrefabResName(string LCBMJJIFDMJ)
	{
		return null;
	}

	[Token(Token = "0x6019CE0")]
	[Address(RVA = "0x25BAC04", Offset = "0x25BAC04", VA = "0x25BAC04")]
	public static void GetPrefabByResName(string HNJNLEKDPGB, ref GameObject NBMDGOBCJFN)
	{
	}

	[Token(Token = "0x6019CE1")]
	[Address(RVA = "0x25AC45C", Offset = "0x25AC45C", VA = "0x25AC45C")]
	public void InitGrassPrefab()
	{
	}

	[Token(Token = "0x6019CE2")]
	[Address(RVA = "0x25AE1CC", Offset = "0x25AE1CC", VA = "0x25AE1CC")]
	private void HMPEEMJDNHF()
	{
	}

	[Token(Token = "0x6019CE3")]
	[Address(RVA = "0x25BD1D4", Offset = "0x25BD1D4", VA = "0x25BD1D4")]
	private void HPNABCKGGCO(Texture NKFJCJGKFJF, ref int GGAPJKPDFGE)
	{
	}

	[Token(Token = "0x6019CE4")]
	[Address(RVA = "0x25BC918", Offset = "0x25BC918", VA = "0x25BC918")]
	private void ONBCCNEFCOD(TextAsset OHJOHENHNBA, TextAsset GAFPBANIPGM)
	{
	}

	[Token(Token = "0x6019CE5")]
	[Address(RVA = "0x25BD268", Offset = "0x25BD268", VA = "0x25BD268")]
	public void OnCameraChanged(Camera GNKJBPHOOIB)
	{
	}

	[Token(Token = "0x6019CE6")]
	[Address(RVA = "0x25AFB9C", Offset = "0x25AFB9C", VA = "0x25AFB9C")]
	private void FCKJFNFDNIK()
	{
	}

	[Token(Token = "0x6019CE7")]
	[Address(RVA = "0x25B06A8", Offset = "0x25B06A8", VA = "0x25B06A8")]
	private void HLANPNJDKBH()
	{
	}

	[Token(Token = "0x6019CE8")]
	[Address(RVA = "0x25BDE00", Offset = "0x25BDE00", VA = "0x25BDE00")]
	public void ChangeGrassShowByRect(bool OCMAHFDLNCD, Rect[] KNMKLGKEAOO)
	{
	}

	[Token(Token = "0x6019CE9")]
	[Address(RVA = "0x25B6928", Offset = "0x25B6928", VA = "0x25B6928")]
	private void JFKJGLNLPED()
	{
	}

	[Token(Token = "0x6019CEA")]
	[Address(RVA = "0x25B5FE4", Offset = "0x25B5FE4", VA = "0x25B5FE4")]
	private void DBGMLGLONBB()
	{
	}

	[Token(Token = "0x6019CEB")]
	[Address(RVA = "0x25B2084", Offset = "0x25B2084", VA = "0x25B2084")]
	private void EMBLGIJDGHG()
	{
	}

	[Token(Token = "0x6019CEC")]
	[Address(RVA = "0x25BF04C", Offset = "0x25BF04C", VA = "0x25BF04C")]
	public void OnScreenShotRendering()
	{
	}

	[Token(Token = "0x6019CED")]
	[Address(RVA = "0x25B67B0", Offset = "0x25B67B0", VA = "0x25B67B0")]
	private void BMCMDPEHCDP()
	{
	}

	[Token(Token = "0x6019CEE")]
	[Address(RVA = "0x25BF1C4", Offset = "0x25BF1C4", VA = "0x25BF1C4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6019CEF")]
	[Address(RVA = "0x25BE9AC", Offset = "0x25BE9AC", VA = "0x25BE9AC")]
	private Vector3 IOMMBFLKMDI(Vector3 ACCOJJMKKPM, float FABKMHEKFPK, int DKIJKMLIGHN)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019CF0")]
	[Address(RVA = "0x25BBACC", Offset = "0x25BBACC", VA = "0x25BBACC")]
	public void FetchGrassPrefabVerts()
	{
	}

	[Token(Token = "0x6019CF1")]
	[Address(RVA = "0x25BAEE8", Offset = "0x25BAEE8", VA = "0x25BAEE8")]
	public void FetchGrassPrefabVertsForHoudini()
	{
	}

	[Token(Token = "0x6019CF2")]
	[Address(RVA = "0x25BECA4", Offset = "0x25BECA4", VA = "0x25BECA4")]
	private float MKDOFAHFGHL(int DKIJKMLIGHN)
	{
		return default(float);
	}

	[Token(Token = "0x6019CF3")]
	[Address(RVA = "0x25BE73C", Offset = "0x25BE73C", VA = "0x25BE73C")]
	public int GetTypeID(int DKIJKMLIGHN)
	{
		return default(int);
	}

	[Token(Token = "0x6019CF4")]
	[Address(RVA = "0x25BED04", Offset = "0x25BED04", VA = "0x25BED04")]
	private int ELOJKFOENBD(int DKIJKMLIGHN)
	{
		return default(int);
	}

	[Token(Token = "0x6019CF5")]
	[Address(RVA = "0x25BE978", Offset = "0x25BE978", VA = "0x25BE978")]
	private int BGHKPAEIGIG(int DKIJKMLIGHN)
	{
		return default(int);
	}

	[Token(Token = "0x6019CF6")]
	[Address(RVA = "0x25AEFB8", Offset = "0x25AEFB8", VA = "0x25AEFB8")]
	private void KBLDAPKPIBG()
	{
	}

	[Token(Token = "0x6019CF7")]
	[Address(RVA = "0x25BD2FC", Offset = "0x25BD2FC", VA = "0x25BD2FC")]
	private bool OMKFKOILNKN(ref Vector2 FMJKICBEBML, ref Vector2 HLFJOKEOBKA, float PENKLFFDABD, ref Vector2 AKDPEGLAEFC, ref Vector2 DMHBKBPPOCO)
	{
		return default(bool);
	}

	[Token(Token = "0x6019CF8")]
	[Address(RVA = "0x25BED54", Offset = "0x25BED54", VA = "0x25BED54")]
	private void ABAJNFGANAA(Vector3 JOGHOHLEJFL, Quaternion NJGIGEIFAFI, ref Vector3 NPLOJLCFCKO, float IOOPPDAAMEP, int ENPDKOJANFC)
	{
	}

	[Token(Token = "0x6019CF9")]
	[Address(RVA = "0x25BEFF0", Offset = "0x25BEFF0", VA = "0x25BEFF0")]
	private void GAEDDJGLOHC(Vector3 JOGHOHLEJFL, ref Color32 MGAOFBNFAKF)
	{
	}

	[Token(Token = "0x6019CFA")]
	[Address(RVA = "0x25BDA20", Offset = "0x25BDA20", VA = "0x25BDA20")]
	private void EIEFIHLGDNH(IACMEJKFJDJ CNLMFOLEPBE)
	{
	}

	[Token(Token = "0x6019CFB")]
	[Address(RVA = "0x25BD7C4", Offset = "0x25BD7C4", VA = "0x25BD7C4")]
	private void FIPHFODJMNI(IACMEJKFJDJ CNLMFOLEPBE)
	{
	}

	[Token(Token = "0x6019CFC")]
	[Address(RVA = "0x25BDBA0", Offset = "0x25BDBA0", VA = "0x25BDBA0")]
	private void HLLBKNBFMAO(ref List<NEFJAGOKOOO> CGLINIIPJKC)
	{
	}

	[Token(Token = "0x6019CFD")]
	[Address(RVA = "0x25BE784", Offset = "0x25BE784", VA = "0x25BE784")]
	private void FMDIMJMNLNB(ref int BCEBGALKHDG, int HIPCLFGCBNI)
	{
	}

	[Token(Token = "0x6019CFE")]
	[Address(RVA = "0x25BEAB0", Offset = "0x25BEAB0", VA = "0x25BEAB0")]
	private void EPMODECFGIG(ref int BCEBGALKHDG, int HIPCLFGCBNI)
	{
	}
}
