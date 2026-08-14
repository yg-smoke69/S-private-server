using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x2003FC7")]
public class RockSystem : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2003FC8")]
	public class DistributionData
	{
		[Token(Token = "0x401AD9C")]
		[FieldOffset(Offset = "0x8")]
		public int m_meshID;

		[Token(Token = "0x401AD9D")]
		[FieldOffset(Offset = "0xC")]
		public int m_smallRockTypeID;

		[Token(Token = "0x401AD9E")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 m_boundMin;

		[Token(Token = "0x401AD9F")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 m_boundMax;

		[Token(Token = "0x401ADA0")]
		[FieldOffset(Offset = "0x20")]
		public Matrix4x4 m_transform;

		[Token(Token = "0x401ADA1")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 m_scale;

		[Token(Token = "0x6019F8C")]
		[Address(RVA = "0x1D30698", Offset = "0x1D30698", VA = "0x1D30698")]
		public DistributionData(int AOPBBDLPDGL, int FFJLPLMJBCN, Matrix4x4 GJGMOFLECDK, Bounds GMDFLOLJBNE, Quaternion FHOOEHJBEDL, Vector3 IOOPPDAAMEP)
		{
		}
	}

	[Token(Token = "0x2003FC9")]
	public class OHIOKAOHMJL
	{
		[Token(Token = "0x401ADA2")]
		[FieldOffset(Offset = "0x8")]
		public byte EBCBMPDEFHE;

		[Token(Token = "0x401ADA3")]
		[FieldOffset(Offset = "0x9")]
		public byte JILHILJOODN;

		[Token(Token = "0x401ADA4")]
		[FieldOffset(Offset = "0xA")]
		public byte KKFJKCLEMCM;

		[Token(Token = "0x401ADA5")]
		[FieldOffset(Offset = "0xB")]
		public byte IPGFJMEJEGA;

		[Token(Token = "0x401ADA6")]
		[FieldOffset(Offset = "0xC")]
		public int LBNKLLACNKA;

		[Token(Token = "0x6019F8D")]
		[Address(RVA = "0x1D30ACC", Offset = "0x1D30ACC", VA = "0x1D30ACC")]
		public OHIOKAOHMJL(GameObject OMDFNKNJDII, int IDNEFEOPGIF)
		{
		}
	}

	[Token(Token = "0x2003FCA")]
	private class MCIKKLOGPOI
	{
		[Token(Token = "0x401ADA7")]
		[FieldOffset(Offset = "0x8")]
		public GameObject FJNMODKIFHN;

		[Token(Token = "0x401ADA8")]
		[FieldOffset(Offset = "0xC")]
		public List<Mesh> DPJFEMNAAIB;

		[Token(Token = "0x401ADA9")]
		[FieldOffset(Offset = "0x10")]
		public List<Material> GMNDBBAIDBA;

		[Token(Token = "0x401ADAA")]
		[FieldOffset(Offset = "0x14")]
		public List<MaterialPropertyBlock> ICNMLMNIHAC;

		[Token(Token = "0x6019F8E")]
		[Address(RVA = "0x1D30A94", Offset = "0x1D30A94", VA = "0x1D30A94")]
		public MCIKKLOGPOI(GameObject OMDFNKNJDII, List<Material> PIHKCCDPHEI, List<Mesh> IMLENBPJOEL, List<MaterialPropertyBlock> BDCPMEOBDDG)
		{
		}
	}

	[Token(Token = "0x2003FCB")]
	public class BAOCNFIIBAH
	{
		[Token(Token = "0x401ADAB")]
		[FieldOffset(Offset = "0x8")]
		public int CGJEPKGLKGG;

		[Token(Token = "0x401ADAC")]
		[FieldOffset(Offset = "0xC")]
		public int MFDIHDEEGKH;

		[Token(Token = "0x401ADAD")]
		[FieldOffset(Offset = "0x10")]
		public int NJCAIMOCPLP;

		[Token(Token = "0x401ADAE")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 NCGOCDAJLCD;

		[Token(Token = "0x401ADAF")]
		[FieldOffset(Offset = "0x20")]
		public Matrix4x4 NINGGGEBKIM;

		[Token(Token = "0x401ADB0")]
		[FieldOffset(Offset = "0x60")]
		public Matrix4x4 JENAGBJGHFK;

		[Token(Token = "0x401ADB1")]
		[FieldOffset(Offset = "0xA0")]
		public Matrix4x4 OBLPEADBLOG;

		[Token(Token = "0x6019F8F")]
		[Address(RVA = "0x1D305E8", Offset = "0x1D305E8", VA = "0x1D305E8")]
		public BAOCNFIIBAH()
		{
		}
	}

	[Token(Token = "0x2003FCC")]
	public class LHFGDNOOMHD
	{
		[Token(Token = "0x401ADB2")]
		[FieldOffset(Offset = "0x8")]
		public float[,] BKCBHIOFIOC;

		[Token(Token = "0x401ADB3")]
		[FieldOffset(Offset = "0xC")]
		public float[] EHOJOLBNPCI;

		[Token(Token = "0x401ADB4")]
		[FieldOffset(Offset = "0x10")]
		public int[] FPAOLGGJIJP;

		[Token(Token = "0x401ADB5")]
		[FieldOffset(Offset = "0x14")]
		public byte[,,] EGMPFAGNGGG;

		[Token(Token = "0x6019F90")]
		[Address(RVA = "0x1D30914", Offset = "0x1D30914", VA = "0x1D30914")]
		public LHFGDNOOMHD()
		{
		}
	}

	[Token(Token = "0x2003FCD")]
	public class POMHNNJIDCL
	{
		[Token(Token = "0x401ADB6")]
		[FieldOffset(Offset = "0x8")]
		public int MNCFDKLHIEM;

		[Token(Token = "0x6019F91")]
		[Address(RVA = "0x1D30AF8", Offset = "0x1D30AF8", VA = "0x1D30AF8")]
		public POMHNNJIDCL(int EJOBGMNOJGC)
		{
		}
	}

	[Token(Token = "0x2003FCE")]
	public class GEKPGLAIBFK
	{
		[Token(Token = "0x401ADB7")]
		[FieldOffset(Offset = "0x8")]
		public List<int> JCHFKJKBAPE;

		[Token(Token = "0x401ADB8")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 KHIHCMCNPOF;

		[Token(Token = "0x401ADB9")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 DABHNEIHNCJ;

		[Token(Token = "0x6019F92")]
		[Address(RVA = "0x1D30820", Offset = "0x1D30820", VA = "0x1D30820")]
		public GEKPGLAIBFK()
		{
		}
	}

	[Token(Token = "0x401AD69")]
	[FieldOffset(Offset = "0x0")]
	public static bool m_debugSwitchRock;

	[Token(Token = "0x401AD6A")]
	[FieldOffset(Offset = "0xC")]
	public List<GameObject> m_rockTypeList;

	[Token(Token = "0x401AD6B")]
	[FieldOffset(Offset = "0x10")]
	public List<DistributionData> m_distributionDataList;

	[Token(Token = "0x401AD6C")]
	[FieldOffset(Offset = "0x14")]
	private List<OHIOKAOHMJL> BOCDDOBHNPD;

	[Token(Token = "0x401AD6D")]
	[FieldOffset(Offset = "0x18")]
	private List<MCIKKLOGPOI> HHHALOMCBDA;

	[Token(Token = "0x401AD6E")]
	[FieldOffset(Offset = "0x1C")]
	private Transform LDDHKFPKLEK;

	[Token(Token = "0x401AD6F")]
	[FieldOffset(Offset = "0x20")]
	private List<int> FCFNIAODHAC;

	[Token(Token = "0x401AD70")]
	[FieldOffset(Offset = "0x24")]
	private List<int> BJFJAALNPGL;

	[Token(Token = "0x401AD71")]
	[FieldOffset(Offset = "0x28")]
	private List<BAOCNFIIBAH> OEFHGCKFDGD;

	[Token(Token = "0x401AD72")]
	[FieldOffset(Offset = "0x2C")]
	private List<BAOCNFIIBAH> PGGNODBADPO;

	[Token(Token = "0x401AD73")]
	[FieldOffset(Offset = "0x30")]
	private LHFGDNOOMHD PHFAMLHOKGG;

	[Token(Token = "0x401AD74")]
	[FieldOffset(Offset = "0x34")]
	private int NIFGGPCNOHN;

	[Token(Token = "0x401AD75")]
	[FieldOffset(Offset = "0x38")]
	private int BBNCCGMNDBL;

	[Token(Token = "0x401AD76")]
	[FieldOffset(Offset = "0x3C")]
	private float EPGPHENONIN;

	[Token(Token = "0x401AD77")]
	[FieldOffset(Offset = "0x40")]
	private float AGNMBFNPFMD;

	[Token(Token = "0x401AD78")]
	[FieldOffset(Offset = "0x44")]
	private float GEBCCDFPOKG;

	[Token(Token = "0x401AD79")]
	private const float PDELDFNJBMD = 2f;

	[Token(Token = "0x401AD7A")]
	private const int CONGJBEJJPL = 6;

	[Token(Token = "0x401AD7B")]
	[FieldOffset(Offset = "0x48")]
	private int HNJBPAHOJEB;

	[Token(Token = "0x401AD7C")]
	[FieldOffset(Offset = "0x4C")]
	private int EHGOLFJKCJA;

	[Token(Token = "0x401AD7D")]
	private const float NGCCKMKNGCC = -100000f;

	[Token(Token = "0x401AD7E")]
	[FieldOffset(Offset = "0x50")]
	private int GFFBGCBIJGA;

	[Token(Token = "0x401AD7F")]
	[FieldOffset(Offset = "0x54")]
	private List<int> NOBMHPNJOLE;

	[Token(Token = "0x401AD80")]
	[FieldOffset(Offset = "0x58")]
	private List<int> DBKGBDDGJEO;

	[Token(Token = "0x401AD81")]
	[FieldOffset(Offset = "0x5C")]
	private List<int> IPNDEBEONLI;

	[Token(Token = "0x401AD82")]
	[FieldOffset(Offset = "0x60")]
	private List<int> ANLNMKNJNNP;

	[Token(Token = "0x401AD83")]
	[FieldOffset(Offset = "0x64")]
	private Dictionary<int, List<int>> BKOBOKOIENG;

	[Token(Token = "0x401AD84")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<int, List<int>> ALCONKOJJAK;

	[Token(Token = "0x401AD85")]
	[FieldOffset(Offset = "0x6C")]
	private Dictionary<int, List<int>> LDNNEFBEOHJ;

	[Token(Token = "0x401AD86")]
	private const float OANIFJNCHNO = 60f;

	[Token(Token = "0x401AD87")]
	[FieldOffset(Offset = "0x70")]
	private int AMNNDFBDKPD;

	[Token(Token = "0x401AD88")]
	[FieldOffset(Offset = "0x74")]
	private Dictionary<int, GEKPGLAIBFK> KIEEHCJKDKL;

	[Token(Token = "0x401AD89")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<int, GEKPGLAIBFK> GAOHIDJAKMB;

	[Token(Token = "0x401AD8A")]
	[FieldOffset(Offset = "0x7C")]
	private Dictionary<int, GEKPGLAIBFK> DOJGOHOCAKJ;

	[Token(Token = "0x401AD8B")]
	[FieldOffset(Offset = "0x80")]
	private Camera CPHNMPKFICJ;

	[Token(Token = "0x401AD8C")]
	[FieldOffset(Offset = "0x84")]
	private byte AONEJCKJMDE;

	[Token(Token = "0x401AD8D")]
	[FieldOffset(Offset = "0x88")]
	private Material DEAIADBCIIA;

	[Token(Token = "0x401AD8E")]
	[FieldOffset(Offset = "0x8C")]
	private Material APLFHENIKJM;

	[Token(Token = "0x401AD8F")]
	[FieldOffset(Offset = "0x90")]
	private SceneGraphics LBEHNMJPDGC;

	[Token(Token = "0x401AD90")]
	[FieldOffset(Offset = "0x94")]
	private Vector2 HJPDMLOKICD;

	[Token(Token = "0x401AD91")]
	[FieldOffset(Offset = "0x9C")]
	private Vector2 HFNEDOIHFDK;

	[Token(Token = "0x401AD92")]
	[FieldOffset(Offset = "0xA4")]
	private List<int> PCHDMHPLAMC;

	[Token(Token = "0x401AD93")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_bigRockPreivewGO;

	[Token(Token = "0x401AD94")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject m_medRockPreivewGO;

	[Token(Token = "0x401AD95")]
	[FieldOffset(Offset = "0xB0")]
	private bool MJLMKAIEFIC;

	[Token(Token = "0x401AD96")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject m_bigRocks;

	[Token(Token = "0x401AD97")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_medRocks;

	[Token(Token = "0x401AD98")]
	[FieldOffset(Offset = "0xBC")]
	private Renderer[] POGOFLGAGKE;

	[Token(Token = "0x401AD99")]
	[FieldOffset(Offset = "0xC0")]
	private Renderer[] OPGEFLGLEDC;

	[Token(Token = "0x401AD9A")]
	[FieldOffset(Offset = "0xC4")]
	private Vector2[] HMOOJLJMNFK;

	[Token(Token = "0x401AD9B")]
	[FieldOffset(Offset = "0xC8")]
	private int GFMKJMIKDPD;

	[Token(Token = "0x6019F76")]
	[Address(RVA = "0x25C7E68", Offset = "0x25C7E68", VA = "0x25C7E68")]
	public RockSystem()
	{
	}

	[Token(Token = "0x6019F77")]
	[Address(RVA = "0x25C81CC", Offset = "0x25C81CC", VA = "0x25C81CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6019F78")]
	[Address(RVA = "0x25C8664", Offset = "0x25C8664", VA = "0x25C8664")]
	public void Init()
	{
	}

	[Token(Token = "0x6019F79")]
	[Address(RVA = "0x25C91B0", Offset = "0x25C91B0", VA = "0x25C91B0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6019F7A")]
	[Address(RVA = "0x25C9264", Offset = "0x25C9264", VA = "0x25C9264")]
	public void SimuateRock()
	{
	}

	[Token(Token = "0x6019F7B")]
	[Address(RVA = "0x25C9290", Offset = "0x25C9290", VA = "0x25C9290")]
	private void NEAHDAMJBLB()
	{
	}

	[Token(Token = "0x6019F7C")]
	[Address(RVA = "0x25C9128", Offset = "0x25C9128", VA = "0x25C9128")]
	public void InitRockMeshes()
	{
	}

	[Token(Token = "0x6019F7D")]
	[Address(RVA = "0x25C828C", Offset = "0x25C828C", VA = "0x25C828C")]
	private void BJCPNPMDDHF()
	{
	}

	[Token(Token = "0x6019F7E")]
	[Address(RVA = "0x25CA550", Offset = "0x25CA550", VA = "0x25CA550")]
	private void GNPDDJPHHMC()
	{
	}

	[Token(Token = "0x6019F7F")]
	[Address(RVA = "0x25C9FCC", Offset = "0x25C9FCC", VA = "0x25C9FCC")]
	private void KAHFOHBIMDG()
	{
	}

	[Token(Token = "0x6019F80")]
	[Address(RVA = "0x25C9780", Offset = "0x25C9780", VA = "0x25C9780")]
	private void ONDFKEDBJGL()
	{
	}

	[Token(Token = "0x6019F81")]
	[Address(RVA = "0x25CB048", Offset = "0x25CB048", VA = "0x25CB048")]
	private void JBIMLJPGGED(Vector2 FHOKBMGKCAP, Vector2 JOOCJDDCHMD, ref Vector2 FMJKICBEBML, ref Vector2 HLFJOKEOBKA, float PENKLFFDABD, int JDLIMGHHBKE, Dictionary<int, GEKPGLAIBFK> AEKLLAMKGDE, int MOBDKEOEJPH)
	{
	}

	[Token(Token = "0x6019F82")]
	[Address(RVA = "0x25CB984", Offset = "0x25CB984", VA = "0x25CB984")]
	private bool OMKFKOILNKN(ref Vector2 FMJKICBEBML, ref Vector2 HLFJOKEOBKA, float PENKLFFDABD, ref Vector2 AKDPEGLAEFC, ref Vector2 DMHBKBPPOCO)
	{
		return default(bool);
	}

	[Token(Token = "0x6019F83")]
	[Address(RVA = "0x25C9CC8", Offset = "0x25C9CC8", VA = "0x25C9CC8")]
	private void IGOHCDIAMKA()
	{
	}

	[Token(Token = "0x6019F84")]
	[Address(RVA = "0x25CBE4C", Offset = "0x25CBE4C", VA = "0x25CBE4C")]
	private void IGOHCDIAMKA(ref Vector2 FMJKICBEBML, ref Vector2 HLFJOKEOBKA, float PENKLFFDABD)
	{
	}

	[Token(Token = "0x6019F85")]
	[Address(RVA = "0x25CD8B4", Offset = "0x25CD8B4", VA = "0x25CD8B4")]
	private void EHOMGHHHMGH()
	{
	}

	[Token(Token = "0x6019F86")]
	[Address(RVA = "0x25CE374", Offset = "0x25CE374", VA = "0x25CE374")]
	private void KPFLHNMAODG(bool MCDIDHODHLN)
	{
	}

	[Token(Token = "0x6019F87")]
	[Address(RVA = "0x25CD4DC", Offset = "0x25CD4DC", VA = "0x25CD4DC")]
	private void BIALBGOBGJG(ref OHIOKAOHMJL HIDIODNIGGF, int IDNEFEOPGIF, byte LMHNGDLHLCP, byte HKHPEOAGGGK, byte EAMKDGINABE)
	{
	}

	[Token(Token = "0x6019F88")]
	[Address(RVA = "0x25CD7D4", Offset = "0x25CD7D4", VA = "0x25CD7D4")]
	private int MEKDAIKGAJK(ref OHIOKAOHMJL HIDIODNIGGF, int PLLHBNLKHDH, int HHJOGKBAFNF)
	{
		return default(int);
	}

	[Token(Token = "0x6019F89")]
	[Address(RVA = "0x25CD72C", Offset = "0x25CD72C", VA = "0x25CD72C")]
	private void BNBNFGDBGHA(ref OHIOKAOHMJL HIDIODNIGGF)
	{
	}

	[Token(Token = "0x6019F8A")]
	[Address(RVA = "0x25CD6C8", Offset = "0x25CD6C8", VA = "0x25CD6C8")]
	private void ALKLCDKIMIL(ref OHIOKAOHMJL HIDIODNIGGF, byte DEAIOEKELKG, byte IALPDEBJINK, byte BLEAICPKPGL)
	{
	}
}
