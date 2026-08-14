using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x2003F41")]
public class BFPFFNANJAM
{
	[Serializable]
	[Token(Token = "0x2003F42")]
	public class DistributionData
	{
		[Token(Token = "0x401AAB6")]
		[FieldOffset(Offset = "0x8")]
		public int m_meshID;

		[Token(Token = "0x401AAB7")]
		[FieldOffset(Offset = "0xC")]
		public DynamicGenerator.DDBKGEBAIHM m_type;

		[Token(Token = "0x401AAB8")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 m_position;

		[Token(Token = "0x401AAB9")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 m_scale;

		[Token(Token = "0x401AABA")]
		[FieldOffset(Offset = "0x28")]
		public Quaternion m_rotation;

		[Token(Token = "0x401AABB")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 m_boundMin;

		[Token(Token = "0x401AABC")]
		[FieldOffset(Offset = "0x40")]
		public Vector2 m_boundMax;

		[Token(Token = "0x401AABD")]
		[FieldOffset(Offset = "0x48")]
		public int m_dirRndID;

		[Token(Token = "0x6019C63")]
		[Address(RVA = "0x25A291C", Offset = "0x25A291C", VA = "0x25A291C")]
		public DistributionData(int AOPBBDLPDGL, int ONMMMAGGEJE, DynamicGenerator.DDBKGEBAIHM PMGBACFJIHO, Vector3 ACCOJJMKKPM, Vector3 IOOPPDAAMEP, Quaternion LCMDGPINKAO, Bounds GMDFLOLJBNE)
		{
		}
	}

	[Token(Token = "0x2003F43")]
	public class OHIOKAOHMJL
	{
		[Token(Token = "0x401AABE")]
		[FieldOffset(Offset = "0x8")]
		public PGOJJKOAKKO AFCOOCAMAOI;

		[Token(Token = "0x401AABF")]
		[FieldOffset(Offset = "0xC")]
		public GameObject FJNMODKIFHN;

		[Token(Token = "0x401AAC0")]
		[FieldOffset(Offset = "0x10")]
		public int EBCBMPDEFHE;

		[Token(Token = "0x401AAC1")]
		[FieldOffset(Offset = "0x14")]
		public int JILHILJOODN;

		[Token(Token = "0x401AAC2")]
		[FieldOffset(Offset = "0x18")]
		public int KKFJKCLEMCM;

		[Token(Token = "0x401AAC3")]
		[FieldOffset(Offset = "0x1C")]
		public int IPGFJMEJEGA;

		[Token(Token = "0x401AAC4")]
		[FieldOffset(Offset = "0x20")]
		public bool FMCHNLHKHEN;

		[Token(Token = "0x401AAC5")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 ENNDBOIDAII;

		[Token(Token = "0x401AAC6")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 NCGOCDAJLCD;

		[Token(Token = "0x6019C64")]
		[Address(RVA = "0x259B59C", Offset = "0x259B59C", VA = "0x259B59C")]
		public OHIOKAOHMJL()
		{
		}
	}

	[Token(Token = "0x2003F44")]
	public class PGOJJKOAKKO
	{
		[Token(Token = "0x401AAC7")]
		[FieldOffset(Offset = "0x8")]
		public Vector4 EGLPDCIPPMF;

		[Token(Token = "0x401AAC8")]
		[FieldOffset(Offset = "0x18")]
		public Matrix4x4 DLKAGBOGKDO;

		[Token(Token = "0x401AAC9")]
		[FieldOffset(Offset = "0x58")]
		public Vector3 FEEHPCFKNPK;

		[Token(Token = "0x401AACA")]
		[FieldOffset(Offset = "0x64")]
		public Vector3[] KCICBGJKEIH;

		[Token(Token = "0x6019C65")]
		[Address(RVA = "0x259B63C", Offset = "0x259B63C", VA = "0x259B63C")]
		public PGOJJKOAKKO()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003F45")]
	public class DynamicPrefabInfo
	{
		[Token(Token = "0x401AACB")]
		[FieldOffset(Offset = "0x8")]
		public GameObject m_prefab;

		[Token(Token = "0x401AACC")]
		[FieldOffset(Offset = "0xC")]
		public GameObject m_collider;

		[Token(Token = "0x401AACD")]
		[FieldOffset(Offset = "0x10")]
		public DynamicGenerator.DDBKGEBAIHM m_type;

		[Token(Token = "0x401AACE")]
		[FieldOffset(Offset = "0x14")]
		public int m_individualNum;

		[Token(Token = "0x401AACF")]
		[FieldOffset(Offset = "0x18")]
		public bool m_receiveShadow;

		[Token(Token = "0x6019C66")]
		[Address(RVA = "0x25A2A68", Offset = "0x25A2A68", VA = "0x25A2A68")]
		public DynamicPrefabInfo()
		{
		}
	}

	[Token(Token = "0x2003F46")]
	public class NLCFNILHPCC
	{
		[Token(Token = "0x401AAD0")]
		[FieldOffset(Offset = "0x8")]
		public bool AJLFDFGKAIE;

		[Token(Token = "0x401AAD1")]
		[FieldOffset(Offset = "0xC")]
		public DynamicMeshVisibleHelper AAKBOFICBDM;

		[Token(Token = "0x401AAD2")]
		[FieldOffset(Offset = "0x10")]
		public List<KEEKMMPLKDH> NMHBLIIEJNH;

		[Token(Token = "0x6019C67")]
		[Address(RVA = "0x259AFD0", Offset = "0x259AFD0", VA = "0x259AFD0")]
		public NLCFNILHPCC()
		{
		}
	}

	[Token(Token = "0x2003F47")]
	public class KEEKMMPLKDH
	{
		[Token(Token = "0x401AAD3")]
		[FieldOffset(Offset = "0x8")]
		public GameObject FJNMODKIFHN;

		[Token(Token = "0x401AAD4")]
		[FieldOffset(Offset = "0xC")]
		public List<Mesh> DPJFEMNAAIB;

		[Token(Token = "0x401AAD5")]
		[FieldOffset(Offset = "0x10")]
		public List<Renderer> FODNAPHMAIB;

		[Token(Token = "0x401AAD6")]
		[FieldOffset(Offset = "0x14")]
		public List<Material> GMNDBBAIDBA;

		[Token(Token = "0x401AAD7")]
		[FieldOffset(Offset = "0x18")]
		public List<MaterialPropertyBlock> ICNMLMNIHAC;

		[Token(Token = "0x401AAD8")]
		[FieldOffset(Offset = "0x1C")]
		public List<List<Material>> LLJCCEBLJBA;

		[Token(Token = "0x401AAD9")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 NCGOCDAJLCD;

		[Token(Token = "0x6019C68")]
		[Address(RVA = "0x259B05C", Offset = "0x259B05C", VA = "0x259B05C")]
		public KEEKMMPLKDH(GameObject OMDFNKNJDII, List<Renderer> LCODDCBBEMO, List<Mesh> IMLENBPJOEL, List<MaterialPropertyBlock> BDCPMEOBDDG, List<Material> DAHJFFAGGKK, Vector3 ACCOJJMKKPM)
		{
		}
	}

	[Token(Token = "0x2003F48")]
	public class ALBBDLONDFN
	{
		[Token(Token = "0x401AADA")]
		[FieldOffset(Offset = "0x8")]
		public int CGJEPKGLKGG;

		[Token(Token = "0x401AADB")]
		[FieldOffset(Offset = "0xC")]
		public int NJCAIMOCPLP;

		[Token(Token = "0x401AADC")]
		[FieldOffset(Offset = "0x10")]
		public int EBCBMPDEFHE;

		[Token(Token = "0x401AADD")]
		[FieldOffset(Offset = "0x14")]
		public int DLMJDBKPKIP;

		[Token(Token = "0x401AADE")]
		[FieldOffset(Offset = "0x18")]
		public float[] LMLJLBKABAK;

		[Token(Token = "0x401AADF")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 NCGOCDAJLCD;

		[Token(Token = "0x401AAE0")]
		[FieldOffset(Offset = "0x28")]
		public Vector4[] KNAHNKEPCEE;

		[Token(Token = "0x401AAE1")]
		[FieldOffset(Offset = "0x2C")]
		public Matrix4x4 NINGGGEBKIM;

		[Token(Token = "0x401AAE2")]
		[FieldOffset(Offset = "0x6C")]
		public Matrix4x4 JENAGBJGHFK;

		[Token(Token = "0x401AAE3")]
		[FieldOffset(Offset = "0xAC")]
		public Matrix4x4 OBLPEADBLOG;

		[Token(Token = "0x6019C69")]
		[Address(RVA = "0x2597C94", Offset = "0x2597C94", VA = "0x2597C94")]
		public ALBBDLONDFN()
		{
		}
	}

	[Token(Token = "0x2003F49")]
	public class LJNNIAPMLCN
	{
		[Token(Token = "0x401AAE4")]
		[FieldOffset(Offset = "0x8")]
		public List<int> JCHFKJKBAPE;

		[Token(Token = "0x401AAE5")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 KHIHCMCNPOF;

		[Token(Token = "0x401AAE6")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 DABHNEIHNCJ;

		[Token(Token = "0x6019C6A")]
		[Address(RVA = "0x259B664", Offset = "0x259B664", VA = "0x259B664")]
		public LJNNIAPMLCN()
		{
		}
	}

	[Token(Token = "0x2003F4A")]
	public class FHKJBLFFFNJ
	{
		[Token(Token = "0x401AAE7")]
		[FieldOffset(Offset = "0x8")]
		public int LPPDKOHDEII;

		[Token(Token = "0x401AAE8")]
		[FieldOffset(Offset = "0xC")]
		public List<DistributionData> NEJINAJONAC;

		[Token(Token = "0x401AAE9")]
		[FieldOffset(Offset = "0x10")]
		public List<OHIOKAOHMJL> BOCDDOBHNPD;

		[Token(Token = "0x401AAEA")]
		[FieldOffset(Offset = "0x14")]
		public Dictionary<int, LJNNIAPMLCN> DKIBDGMNCNH;

		[Token(Token = "0x401AAEB")]
		[FieldOffset(Offset = "0x18")]
		public List<int> JNAPFIIGGBI;

		[Token(Token = "0x401AAEC")]
		[FieldOffset(Offset = "0x1C")]
		public Dictionary<int, List<int>> GLHLEDBCFEP;

		[Token(Token = "0x401AAED")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<int, List<ALBBDLONDFN>> NCMBKDECNNG;

		[Token(Token = "0x401AAEE")]
		[FieldOffset(Offset = "0x24")]
		public Dictionary<int, List<GameObject>> CMNKLEGJJHM;

		[Token(Token = "0x401AAEF")]
		[FieldOffset(Offset = "0x28")]
		public bool MBOBKMMDCOB;

		[Token(Token = "0x6019C6B")]
		[Address(RVA = "0x2597D7C", Offset = "0x2597D7C", VA = "0x2597D7C")]
		public FHKJBLFFFNJ(int PMGBACFJIHO)
		{
		}
	}

	[Token(Token = "0x2003F4B")]
	public class AJHGILHGJEN
	{
		[Token(Token = "0x401AAF0")]
		[FieldOffset(Offset = "0x8")]
		public float[,,] BKCBHIOFIOC;

		[Token(Token = "0x401AAF1")]
		[FieldOffset(Offset = "0xC")]
		public float[,] EHOJOLBNPCI;

		[Token(Token = "0x401AAF2")]
		[FieldOffset(Offset = "0x10")]
		public float[] PIKLHPMABBL;

		[Token(Token = "0x401AAF3")]
		[FieldOffset(Offset = "0x14")]
		public int[,] GCFPBFGANIN;

		[Token(Token = "0x401AAF4")]
		[FieldOffset(Offset = "0x18")]
		public int[,,,] EGMPFAGNGGG;

		[Token(Token = "0x6019C6C")]
		[Address(RVA = "0x2596FE4", Offset = "0x2596FE4", VA = "0x2596FE4")]
		public AJHGILHGJEN()
		{
		}
	}

	[Token(Token = "0x401AA85")]
	[FieldOffset(Offset = "0x8")]
	private List<DynamicGeneratorGroup> FEFNCIGCBMC;

	[Token(Token = "0x401AA86")]
	[FieldOffset(Offset = "0xC")]
	private List<DynamicPrefabInfo> EIBCDMCMCKK;

	[Token(Token = "0x401AA87")]
	[FieldOffset(Offset = "0x10")]
	private List<DynamicPrefabInfo> JIFCFJMGHKH;

	[Token(Token = "0x401AA88")]
	[FieldOffset(Offset = "0x14")]
	private FHKJBLFFFNJ[] HHDBEABKLGD;

	[Token(Token = "0x401AA89")]
	[FieldOffset(Offset = "0x18")]
	private List<NLCFNILHPCC> MNMNDECKBFG;

	[Token(Token = "0x401AA8A")]
	[FieldOffset(Offset = "0x1C")]
	private List<NLCFNILHPCC> LFMOPPGLIGK;

	[Token(Token = "0x401AA8B")]
	[FieldOffset(Offset = "0x20")]
	private Camera CPHNMPKFICJ;

	[Token(Token = "0x401AA8C")]
	[FieldOffset(Offset = "0x24")]
	private AJHGILHGJEN DJAACPGONJK;

	[Token(Token = "0x401AA8D")]
	[FieldOffset(Offset = "0x28")]
	private int FOBOFJAEHIL;

	[Token(Token = "0x401AA8E")]
	[FieldOffset(Offset = "0x2C")]
	private int DFFJKIEODGB;

	[Token(Token = "0x401AA8F")]
	[FieldOffset(Offset = "0x30")]
	private int BOGKOOBJPJD;

	[Token(Token = "0x401AA90")]
	[FieldOffset(Offset = "0x34")]
	private Vector2 NIAAHODDCGK;

	[Token(Token = "0x401AA91")]
	[FieldOffset(Offset = "0x3C")]
	private Vector2 NEJGBNNGFDG;

	[Token(Token = "0x401AA92")]
	[FieldOffset(Offset = "0x44")]
	private Vector2 FLLOEPKJHON;

	[Token(Token = "0x401AA93")]
	[FieldOffset(Offset = "0x4C")]
	private float HHGHGIDPPHO;

	[Token(Token = "0x401AA94")]
	[FieldOffset(Offset = "0x50")]
	private bool FAPGPBJABAH;

	[Token(Token = "0x401AA95")]
	private const int HMPDMKBDDDM = 10;

	[Token(Token = "0x401AA96")]
	private const float PDELDFNJBMD = 2f;

	[Token(Token = "0x401AA97")]
	[FieldOffset(Offset = "0x54")]
	private int NAMLIOLDFJF;

	[Token(Token = "0x401AA98")]
	[FieldOffset(Offset = "0x58")]
	private List<ALBBDLONDFN> HNBOJJMLLKK;

	[Token(Token = "0x401AA99")]
	[FieldOffset(Offset = "0x5C")]
	private int[,] DMIKPFFKPIC;

	[Token(Token = "0x401AA9A")]
	[FieldOffset(Offset = "0x60")]
	private Matrix4x4 PAKDLAACDFC;

	[Token(Token = "0x401AA9B")]
	[FieldOffset(Offset = "0xA0")]
	private int OBBNCKJCMAB;

	[Token(Token = "0x401AA9C")]
	[FieldOffset(Offset = "0xA4")]
	private List<List<int>> MGJHDHAKGLH;

	[Token(Token = "0x401AA9D")]
	[FieldOffset(Offset = "0xA8")]
	private List<List<ALBBDLONDFN>> OHFENBCIKGC;

	[Token(Token = "0x401AA9E")]
	[FieldOffset(Offset = "0xAC")]
	private int KJDHGANLPOF;

	[Token(Token = "0x401AA9F")]
	[FieldOffset(Offset = "0xB0")]
	private int FPFBFFCHNGF;

	[Token(Token = "0x401AAA0")]
	[FieldOffset(Offset = "0xB4")]
	private Material DEAIADBCIIA;

	[Token(Token = "0x401AAA1")]
	[FieldOffset(Offset = "0xB8")]
	private Material APLFHENIKJM;

	[Token(Token = "0x401AAA2")]
	[FieldOffset(Offset = "0xBC")]
	private int JENAGBJGHFK;

	[Token(Token = "0x401AAA3")]
	[FieldOffset(Offset = "0xC0")]
	private int NINGGGEBKIM;

	[Token(Token = "0x401AAA4")]
	[FieldOffset(Offset = "0xC4")]
	private int OBLPEADBLOG;

	[Token(Token = "0x401AAA5")]
	[FieldOffset(Offset = "0xC8")]
	private int LMLJLBKABAK;

	[Token(Token = "0x401AAA6")]
	[FieldOffset(Offset = "0xCC")]
	private int MLLCOEFAMHC;

	[Token(Token = "0x401AAA7")]
	[FieldOffset(Offset = "0xD0")]
	private int OACGEGJFEHB;

	[Token(Token = "0x401AAA8")]
	[FieldOffset(Offset = "0xD4")]
	private int DEHIOCALJGC;

	[Token(Token = "0x401AAA9")]
	[FieldOffset(Offset = "0xD8")]
	private float _003CMEEBNNHHCIL_003Ek__BackingField;

	[Token(Token = "0x401AAAA")]
	[FieldOffset(Offset = "0xDC")]
	private float _003CGOBNBPHOEPO_003Ek__BackingField;

	[Token(Token = "0x401AAAB")]
	[FieldOffset(Offset = "0xE0")]
	private Quaternion OFBBDNNBEGD;

	[Token(Token = "0x401AAAC")]
	[FieldOffset(Offset = "0xF0")]
	private Vector3 JBOPOKPDALD;

	[Token(Token = "0x401AAAD")]
	[FieldOffset(Offset = "0xFC")]
	private int GCFIBDBCCFF;

	[Token(Token = "0x401AAAE")]
	[FieldOffset(Offset = "0x100")]
	private int[,] BKOLOPIFMJM;

	[Token(Token = "0x401AAAF")]
	[FieldOffset(Offset = "0x104")]
	private List<int> OGPIMGEMNBD;

	[Token(Token = "0x401AAB0")]
	[FieldOffset(Offset = "0x108")]
	private List<int> PBMJEBECMPN;

	[Token(Token = "0x401AAB1")]
	[FieldOffset(Offset = "0x10C")]
	private List<int> ILCDCBBPJCA;

	[Token(Token = "0x401AAB2")]
	[FieldOffset(Offset = "0x110")]
	private List<int> HIEBKEFPNIC;

	[Token(Token = "0x401AAB3")]
	[FieldOffset(Offset = "0x114")]
	private Vector2[] HMOOJLJMNFK;

	[Token(Token = "0x401AAB4")]
	[FieldOffset(Offset = "0x118")]
	public Matrix4x4 CFJPJGPMIGL;

	[Token(Token = "0x401AAB5")]
	[FieldOffset(Offset = "0x158")]
	public Matrix4x4 HNLBODDIFII;

	[Token(Token = "0x17001C2A")]
	public float MEFHOHJFPMB
	{
		[Token(Token = "0x6019C41")]
		[Address(RVA = "0x25971C8", Offset = "0x25971C8", VA = "0x25971C8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6019C42")]
		[Address(RVA = "0x25971D0", Offset = "0x25971D0", VA = "0x25971D0")]
		private set
		{
		}
	}

	[Token(Token = "0x17001C2B")]
	public float COFJPAKIKMB
	{
		[Token(Token = "0x6019C43")]
		[Address(RVA = "0x25971D8", Offset = "0x25971D8", VA = "0x25971D8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6019C44")]
		[Address(RVA = "0x25971E0", Offset = "0x25971E0", VA = "0x25971E0")]
		private set
		{
		}
	}

	[Token(Token = "0x6019C40")]
	[Address(RVA = "0x2596C60", Offset = "0x2596C60", VA = "0x2596C60")]
	public BFPFFNANJAM()
	{
	}

	[Token(Token = "0x6019C45")]
	[Address(RVA = "0x25971E8", Offset = "0x25971E8", VA = "0x25971E8")]
	public void DPLMGOJKKCM(Camera KFGFLKFGPBA, List<DynamicGeneratorGroup> JCEPENNCJJM)
	{
	}

	[Token(Token = "0x6019C46")]
	[Address(RVA = "0x2597688", Offset = "0x2597688", VA = "0x2597688")]
	private void GMJJCMFKJKB()
	{
	}

	[Token(Token = "0x6019C47")]
	[Address(RVA = "0x2597798", Offset = "0x2597798", VA = "0x2597798")]
	private void FAGHMKMJJBM(List<DynamicGeneratorGroup> JCEPENNCJJM)
	{
	}

	[Token(Token = "0x6019C48")]
	[Address(RVA = "0x25985C4", Offset = "0x25985C4", VA = "0x25985C4")]
	private void ODEAOFKMIIJ(List<DynamicGeneratorGroup> OBDCNDEJJKF)
	{
	}

	[Token(Token = "0x6019C49")]
	[Address(RVA = "0x259AF44", Offset = "0x259AF44", VA = "0x259AF44")]
	public void PMLFGJDNCEO(List<DynamicGeneratorGroup> OBDCNDEJJKF)
	{
	}

	[Token(Token = "0x6019C4A")]
	[Address(RVA = "0x2597F48", Offset = "0x2597F48", VA = "0x2597F48")]
	private void LBBJNKCFFAC()
	{
	}

	[Token(Token = "0x6019C4B")]
	[Address(RVA = "0x2597B7C", Offset = "0x2597B7C", VA = "0x2597B7C")]
	private void IPMKNEMJINJ()
	{
	}

	[Token(Token = "0x6019C4C")]
	[Address(RVA = "0x2598DA0", Offset = "0x2598DA0", VA = "0x2598DA0")]
	private void OHKAIBCNLBF(List<DynamicPrefabInfo> EELKLPKAMHD, List<NLCFNILHPCC> EOLDJPBJDNA)
	{
	}

	[Token(Token = "0x6019C4D")]
	[Address(RVA = "0x259A5FC", Offset = "0x259A5FC", VA = "0x259A5FC")]
	private void KMANEDEACNH(FHKJBLFFFNJ[] KEEGHMDENHJ, Dictionary<int, FHKJBLFFFNJ> CJPMPJPLBPL)
	{
	}

	[Token(Token = "0x6019C4E")]
	[Address(RVA = "0x259B758", Offset = "0x259B758", VA = "0x259B758")]
	private void JBKBNPHALLI()
	{
	}

	[Token(Token = "0x6019C4F")]
	[Address(RVA = "0x259BA68", Offset = "0x259BA68", VA = "0x259BA68")]
	public void KGMGPCLGCEH()
	{
	}

	[Token(Token = "0x6019C50")]
	[Address(RVA = "0x259C010", Offset = "0x259C010", VA = "0x259C010")]
	private void OLBNJNDMHEH()
	{
	}

	[Token(Token = "0x6019C51")]
	[Address(RVA = "0x259CE18", Offset = "0x259CE18", VA = "0x259CE18")]
	private void NLNBMPMKGOI()
	{
	}

	[Token(Token = "0x6019C52")]
	[Address(RVA = "0x259D7A0", Offset = "0x259D7A0", VA = "0x259D7A0")]
	private void OFMIDBJPKAI(int PMGBACFJIHO, ref FHKJBLFFFNJ EKBJPLKPHFE)
	{
	}

	[Token(Token = "0x6019C53")]
	[Address(RVA = "0x259E890", Offset = "0x259E890", VA = "0x259E890")]
	private bool OMKFKOILNKN(ref Vector2 AKDPEGLAEFC, ref Vector2 DMHBKBPPOCO)
	{
		return default(bool);
	}

	[Token(Token = "0x6019C54")]
	[Address(RVA = "0x259ED58", Offset = "0x259ED58", VA = "0x259ED58")]
	private void LMEKCNGMJFB(FHKJBLFFFNJ EKBJPLKPHFE, ref List<int> FDOPNBCPFKN, bool GHGLOEGBHFP = false)
	{
	}

	[Token(Token = "0x6019C55")]
	[Address(RVA = "0x259D6A0", Offset = "0x259D6A0", VA = "0x259D6A0")]
	private void LBHDDBFOEPK()
	{
	}

	[Token(Token = "0x6019C56")]
	[Address(RVA = "0x259D6A4", Offset = "0x259D6A4", VA = "0x259D6A4")]
	private void HLGKPPOLOIA()
	{
	}

	[Token(Token = "0x6019C57")]
	[Address(RVA = "0x259F768", Offset = "0x259F768", VA = "0x259F768")]
	private void IFPEBCOGCII(FHKJBLFFFNJ EKBJPLKPHFE)
	{
	}

	[Token(Token = "0x6019C58")]
	[Address(RVA = "0x25A05F0", Offset = "0x25A05F0", VA = "0x25A05F0")]
	private void EHOMICHIDME(ALBBDLONDFN LDLBDEGCGMJ, int IONIPJBKDOL, int MHFAFKACMPN)
	{
	}

	[Token(Token = "0x6019C59")]
	[Address(RVA = "0x25A0340", Offset = "0x25A0340", VA = "0x25A0340")]
	private void OPGPMAIKNIO(int IONIPJBKDOL, ALBBDLONDFN LDLBDEGCGMJ, ref Matrix4x4 GJGMOFLECDK, ref Vector3 IOOPPDAAMEP, int IDNEFEOPGIF)
	{
	}

	[Token(Token = "0x6019C5A")]
	[Address(RVA = "0x25A0220", Offset = "0x25A0220", VA = "0x25A0220")]
	private void GOEBKAFDHBH(int IONIPJBKDOL, ALBBDLONDFN LDLBDEGCGMJ, DistributionData BPBHKFDFMOK)
	{
	}

	[Token(Token = "0x6019C5B")]
	[Address(RVA = "0x259D724", Offset = "0x259D724", VA = "0x259D724")]
	private void AFABJBMLLIP()
	{
	}

	[Token(Token = "0x6019C5C")]
	[Address(RVA = "0x25A0864", Offset = "0x25A0864", VA = "0x25A0864")]
	private void IGMLODGNABO(FHKJBLFFFNJ EKBJPLKPHFE)
	{
	}

	[Token(Token = "0x6019C5D")]
	[Address(RVA = "0x25A0C58", Offset = "0x25A0C58", VA = "0x25A0C58")]
	private void CFCJNDGGPNM(DistributionData BPBHKFDFMOK, OHIOKAOHMJL HIDIODNIGGF)
	{
	}

	[Token(Token = "0x6019C5E")]
	[Address(RVA = "0x25A2368", Offset = "0x25A2368", VA = "0x25A2368")]
	private void CFCJNDGGPNM(DistributionData BPBHKFDFMOK, Vector3 ACCOJJMKKPM, int OAHDNLIDOAM)
	{
	}

	[Token(Token = "0x6019C5F")]
	[Address(RVA = "0x25A171C", Offset = "0x25A171C", VA = "0x25A171C")]
	private void DECLJCMKCAE(ALBBDLONDFN LDLBDEGCGMJ, DynamicGenerator.DDBKGEBAIHM PMGBACFJIHO, bool MBDLFEFIMNJ)
	{
	}

	[Token(Token = "0x6019C60")]
	[Address(RVA = "0x25A0C54", Offset = "0x25A0C54", VA = "0x25A0C54")]
	private void JOBBIEDHPPB(DistributionData BPBHKFDFMOK, OHIOKAOHMJL HIDIODNIGGF)
	{
	}

	[Token(Token = "0x6019C61")]
	[Address(RVA = "0x25A0CD8", Offset = "0x25A0CD8", VA = "0x25A0CD8")]
	private void BGOGJEHBPCH(ALBBDLONDFN LDLBDEGCGMJ)
	{
	}

	[Token(Token = "0x6019C62")]
	[Address(RVA = "0x25A0FD8", Offset = "0x25A0FD8", VA = "0x25A0FD8")]
	private void NGKMAFBGOAH(ALBBDLONDFN LDLBDEGCGMJ)
	{
	}
}
