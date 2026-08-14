using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000651")]
internal class LevelMissile : LevelMissileBase
{
	[Token(Token = "0x2000652")]
	private static class HEMHLMILBEO
	{
		[Token(Token = "0x4004711")]
		[FieldOffset(Offset = "0x0")]
		public static bool CBHJOJHEBEA;

		[Token(Token = "0x4004712")]
		[FieldOffset(Offset = "0x4")]
		public static float LLGCGCFGIAI;

		[Token(Token = "0x4004713")]
		[FieldOffset(Offset = "0x8")]
		public static float DMFCOACLKGF;

		[Token(Token = "0x4004714")]
		[FieldOffset(Offset = "0xC")]
		public static bool JLAEFBBCCGG;

		[Token(Token = "0x4004715")]
		[FieldOffset(Offset = "0xD")]
		public static bool PCJDDKIBBOJ;

		[Token(Token = "0x4004716")]
		[FieldOffset(Offset = "0xE")]
		public static bool BFCBIOBAFGM;

		[Token(Token = "0x4004717")]
		[FieldOffset(Offset = "0xF")]
		public static bool EHELNHPBDDE;

		[Token(Token = "0x4004718")]
		[FieldOffset(Offset = "0x10")]
		public static bool HALNIKMFEMK;

		[Token(Token = "0x4004719")]
		[FieldOffset(Offset = "0x11")]
		public static bool MLLLHIAFCAA;

		[Token(Token = "0x400471A")]
		[FieldOffset(Offset = "0x12")]
		public static bool ALJLDGIHJDC;

		[Token(Token = "0x400471B")]
		[FieldOffset(Offset = "0x13")]
		public static bool LBBLENOMDIG;

		[Token(Token = "0x400471C")]
		[FieldOffset(Offset = "0x14")]
		public static float NLCLIMODKNH;

		[Token(Token = "0x400471D")]
		[FieldOffset(Offset = "0x18")]
		public static bool ILAIBJDBDJC;

		[Token(Token = "0x400471E")]
		[FieldOffset(Offset = "0x1C")]
		public static float NFNPNLPFKEG;

		[Token(Token = "0x400471F")]
		[FieldOffset(Offset = "0x20")]
		public static float ILHLGCHAJOA;

		[Token(Token = "0x4004720")]
		[FieldOffset(Offset = "0x24")]
		public static float IHKOBNLEAAI;

		[Token(Token = "0x4004721")]
		[FieldOffset(Offset = "0x28")]
		public static float IKFCJKHKKBD;

		[Token(Token = "0x4004722")]
		[FieldOffset(Offset = "0x2C")]
		public static float GAADNFNIIHF;

		[Token(Token = "0x4004723")]
		[FieldOffset(Offset = "0x30")]
		public static float MDAHOEKCIGJ;

		[Token(Token = "0x4004724")]
		[FieldOffset(Offset = "0x34")]
		public static float MMGEIEJOCOP;

		[Token(Token = "0x4004725")]
		[FieldOffset(Offset = "0x38")]
		public static float MFFPDPGENAC;

		[Token(Token = "0x4004726")]
		[FieldOffset(Offset = "0x3C")]
		public static float OMMNNNLJLBH;

		[Token(Token = "0x4004727")]
		[FieldOffset(Offset = "0x40")]
		public static float BFLOIBIBFNJ;

		[Token(Token = "0x4004728")]
		[FieldOffset(Offset = "0x44")]
		public static float EPBJFEIHLMC;
	}

	[Token(Token = "0x2000653")]
	protected class DCAHKHCKELK
	{
		[Token(Token = "0x4004729")]
		[FieldOffset(Offset = "0x8")]
		public uint CCFCMGLIEFH;

		[Token(Token = "0x400472A")]
		[FieldOffset(Offset = "0xC")]
		internal AttackableEntity DBNANLDFDBH;

		[Token(Token = "0x400472B")]
		[FieldOffset(Offset = "0x10")]
		public int PAACOEAPCHB;

		[Token(Token = "0x400472C")]
		[FieldOffset(Offset = "0x14")]
		public bool KBKNHOEFFHF;

		[Token(Token = "0x400472D")]
		[FieldOffset(Offset = "0x18")]
		public float JNLNHAOAEAI;

		[Token(Token = "0x400472E")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 BFKFNCGPPLC;

		[Token(Token = "0x400472F")]
		[FieldOffset(Offset = "0x28")]
		public Quaternion CJNAHBNMICG;

		[Token(Token = "0x4004730")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 LMNBBBCKMGB;

		[Token(Token = "0x4004731")]
		[FieldOffset(Offset = "0x44")]
		public float NNGLFFLPKOH;

		[Token(Token = "0x4004732")]
		[FieldOffset(Offset = "0x48")]
		public float IJBKFEFHHGC;

		[Token(Token = "0x4004733")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3 DBAHNADHPCH;

		[Token(Token = "0x4004734")]
		[FieldOffset(Offset = "0x58")]
		public float ODMIGOOOPPF;

		[Token(Token = "0x4004735")]
		[FieldOffset(Offset = "0x5C")]
		public bool BLGHBBGHIPM;

		[Token(Token = "0x4004736")]
		[FieldOffset(Offset = "0x5D")]
		public bool GIDBIOODPIO;

		[Token(Token = "0x4004737")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 MAKPJMDOBNP;

		[Token(Token = "0x4004738")]
		[FieldOffset(Offset = "0x6C")]
		public float DAFCPMCCEBL;

		[Token(Token = "0x4004739")]
		[FieldOffset(Offset = "0x70")]
		public Vector3 PGDEDHFOMCN;

		[Token(Token = "0x400473A")]
		[FieldOffset(Offset = "0x7C")]
		public bool FKFLBEFDKMF;

		[Token(Token = "0x60027BC")]
		[Address(RVA = "0x24C52BC", Offset = "0x24C52BC", VA = "0x24C52BC")]
		public DCAHKHCKELK()
		{
		}

		[Token(Token = "0x60027BD")]
		[Address(RVA = "0x24C02C4", Offset = "0x24C02C4", VA = "0x24C02C4")]
		public void LELFBFLLDMI(DCAHKHCKELK PHEJDNJONIL)
		{
		}
	}

	[Token(Token = "0x2000654")]
	protected class HPHJBAGKDCJ : DCAHKHCKELK
	{
		[Token(Token = "0x400473B")]
		[FieldOffset(Offset = "0x80")]
		public int FLNHHNPBPLM;

		[Token(Token = "0x400473C")]
		[FieldOffset(Offset = "0x84")]
		public float JJJHABEGELO;

		[Token(Token = "0x60027BE")]
		[Address(RVA = "0x24C02AC", Offset = "0x24C02AC", VA = "0x24C02AC")]
		public HPHJBAGKDCJ()
		{
		}

		[Token(Token = "0x60027BF")]
		[Address(RVA = "0x24C0E8C", Offset = "0x24C0E8C", VA = "0x24C0E8C")]
		public void LELFBFLLDMI(HHCBNAPCKHF PHEJDNJONIL)
		{
		}
	}

	[Token(Token = "0x2000655")]
	protected class MFLFMLJGBKD : DCAHKHCKELK
	{
		[Token(Token = "0x400473D")]
		[FieldOffset(Offset = "0x7D")]
		public bool MKAFGHIDHHE;

		[Token(Token = "0x400473E")]
		[FieldOffset(Offset = "0x7E")]
		public bool OCLADPHJCBL;

		[Token(Token = "0x60027C0")]
		[Address(RVA = "0x24C02B4", Offset = "0x24C02B4", VA = "0x24C02B4")]
		public MFLFMLJGBKD()
		{
		}
	}

	[Token(Token = "0x40046FF")]
	protected const byte LCKKIEPABOC = 64;

	[Token(Token = "0x4004700")]
	protected const byte FAFIPLMJOLI = 32;

	[Token(Token = "0x4004701")]
	public const byte StateIndexMask = 15;

	[Token(Token = "0x4004702")]
	private const bool ONEDMIIDFEL = true;

	[Token(Token = "0x4004703")]
	[FieldOffset(Offset = "0xB4")]
	private Vehicle FJMELIMEKJA;

	[Token(Token = "0x4004704")]
	[FieldOffset(Offset = "0xB8")]
	private COW.GamePlay.NGNOBPFAEED<LevelMissile> JPHEEHHDLIK;

	[Token(Token = "0x4004705")]
	[FieldOffset(Offset = "0xBC")]
	private int KHDKFIHGKEC;

	[Token(Token = "0x4004706")]
	[FieldOffset(Offset = "0xC0")]
	private bool ACILGGJAOGB;

	[Token(Token = "0x4004707")]
	[FieldOffset(Offset = "0x0")]
	private static Vector3 LHFLDEBOHIE;

	[Token(Token = "0x4004708")]
	[FieldOffset(Offset = "0xC")]
	private static Vector3 BFDKMFCBLIK;

	[Token(Token = "0x4004709")]
	[FieldOffset(Offset = "0x18")]
	private static bool GIHMMAKMLLJ;

	[Token(Token = "0x400470A")]
	[FieldOffset(Offset = "0x19")]
	private static bool OFAFHJJHCAM;

	[Token(Token = "0x400470B")]
	[FieldOffset(Offset = "0xC4")]
	private GameObject OGLBNHKJPAM;

	[Token(Token = "0x400470C")]
	[FieldOffset(Offset = "0xC8")]
	protected HPHJBAGKDCJ JEBBBKLMBFA;

	[Token(Token = "0x400470D")]
	[FieldOffset(Offset = "0xCC")]
	protected MFLFMLJGBKD MPMPNIKMODO;

	[Token(Token = "0x400470E")]
	[FieldOffset(Offset = "0xD0")]
	private GameObject IHBADKNEFNM;

	[Token(Token = "0x400470F")]
	private const float NNIKOHFJJKF = 5f;

	[Token(Token = "0x4004710")]
	private const float PLIHPNEEIHF = 2f;

	[Token(Token = "0x1700030E")]
	private bool LCNGEOPCFGH
	{
		[Token(Token = "0x6002781")]
		[Address(RVA = "0x24BC968", Offset = "0x24BC968", VA = "0x24BC968")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700030F")]
	public bool HCBFGIKPGLD
	{
		[Token(Token = "0x6002782")]
		[Address(RVA = "0x24BC9CC", Offset = "0x24BC9CC", VA = "0x24BC9CC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002780")]
	[Address(RVA = "0x24BC8E8", Offset = "0x24BC8E8", VA = "0x24BC8E8")]
	public LevelMissile()
	{
	}

	[Token(Token = "0x6002783")]
	[Address(RVA = "0x24BCA24", Offset = "0x24BCA24", VA = "0x24BCA24", Slot = "42")]
	public override void Init(ResourceID JPFKGCMPLLM, JODBNBMENMC OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002784")]
	[Address(RVA = "0x24BCB50", Offset = "0x24BCB50", VA = "0x24BCB50", Slot = "43")]
	protected override void AJKGLMOJJGI()
	{
	}

	[Token(Token = "0x6002785")]
	[Address(RVA = "0x24BCECC", Offset = "0x24BCECC", VA = "0x24BCECC", Slot = "46")]
	protected override void BCAFIPCHLLJ(OPFMONINOBB GLDLCOBLGNF, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x6002786")]
	[Address(RVA = "0x24BE0E0", Offset = "0x24BE0E0", VA = "0x24BE0E0")]
	private COW.GamePlay.NGNOBPFAEED<LevelMissile> IMJJPMLJBOA(uint IDNEFEOPGIF)
	{
		return null;
	}

	[Token(Token = "0x6002787")]
	[Address(RVA = "0x24BD3D0", Offset = "0x24BD3D0", VA = "0x24BD3D0")]
	public bool Mount(uint GKFLHDLFDCC, int HHLONFLCJBL)
	{
		return default(bool);
	}

	[Token(Token = "0x6002788")]
	[Address(RVA = "0x24BD240", Offset = "0x24BD240", VA = "0x24BD240")]
	public void UnMount(bool FEIFNONHGFN = false)
	{
	}

	[Token(Token = "0x6002789")]
	[Address(RVA = "0x24BE2E0", Offset = "0x24BE2E0", VA = "0x24BE2E0")]
	internal void MPGJOKFGLGK(IHAAMHPPLMG IFOLCOIDJIK, uint GKFLHDLFDCC, AttackableEntity FFDHFKIMFDG, uint JDPDFBINIJE, int HHLONFLCJBL, Vector3 KGLGIAKNKAB, Vector3 COCOBLKAIMJ, Vector3 PHENGJDKFDN, float MJIGEHHCIKD, Vector3 JHEMMIPIOPK, Vector3 DCFOJNBCMII)
	{
	}

	[Token(Token = "0x600278A")]
	[Address(RVA = "0x24BE7F4", Offset = "0x24BE7F4", VA = "0x24BE7F4")]
	private void EHELNHPBDDE(out uint GKFLHDLFDCC, out AttackableEntity FFDHFKIMFDG)
	{
	}

	[Token(Token = "0x600278B")]
	[Address(RVA = "0x24BF224", Offset = "0x24BF224", VA = "0x24BF224")]
	internal static void EHELNHPBDDE(IHAAMHPPLMG PKCPDGPOLIK, Transform JHNKHAECLFJ, float DEDAENIPHKB, out uint GKFLHDLFDCC, out AttackableEntity FFDHFKIMFDG, [Optional] Func<AttackableEntity, bool> BMKGOHEFEHP)
	{
	}

	[Token(Token = "0x600278C")]
	[Address(RVA = "0x24BFC24", Offset = "0x24BFC24", VA = "0x24BFC24")]
	private static AttackableEntity NBKMLGIFOJC(Transform JHNKHAECLFJ, AttackableEntity OPOALMNKFJB, AttackableEntity LPIHAOGIKGN, float DEDAENIPHKB, ref float KLEPGFFDLLB, ref float OJCFNDFCGGD, ref float LOKHKCGDHBA, [Optional] Func<AttackableEntity, bool> BMKGOHEFEHP)
	{
		return null;
	}

	[Token(Token = "0x600278D")]
	[Address(RVA = "0x24BF8DC", Offset = "0x24BF8DC", VA = "0x24BF8DC")]
	private static bool OMFIJGGADJO(IHAAMHPPLMG PKCPDGPOLIK, Vehicle CPEMEECILEC)
	{
		return default(bool);
	}

	[Token(Token = "0x600278E")]
	[Address(RVA = "0x24C0190", Offset = "0x24C0190", VA = "0x24C0190", Slot = "47")]
	protected override void GDLCAJOJOKI(AttackableEntity FKCAAKDFCDG, AttackableEntity MLGKHMFMJHP)
	{
	}

	[Token(Token = "0x600278F")]
	[Address(RVA = "0x24BE8D8", Offset = "0x24BE8D8", VA = "0x24BE8D8")]
	private void MJIPPMCKOCJ(uint GKFLHDLFDCC, AttackableEntity FFDHFKIMFDG, Vector3 EBIJHALKJEM, Vector3 PHENGJDKFDN, float MJIGEHHCIKD, Vector3 JHEMMIPIOPK, Vector3 PFAPJJODMCM)
	{
	}

	[Token(Token = "0x6002790")]
	[Address(RVA = "0x24C07A8", Offset = "0x24C07A8", VA = "0x24C07A8", Slot = "18")]
	public override void OnUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002791")]
	[Address(RVA = "0x24C08CC", Offset = "0x24C08CC", VA = "0x24C08CC", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002792")]
	[Address(RVA = "0x24BF05C", Offset = "0x24BF05C", VA = "0x24BF05C")]
	protected void LEBFKPDMKIB(float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002793")]
	[Address(RVA = "0x24C0A60", Offset = "0x24C0A60", VA = "0x24C0A60", Slot = "51")]
	protected override void MHNCKNMNAGL(float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002794")]
	[Address(RVA = "0x24C1104", Offset = "0x24C1104", VA = "0x24C1104")]
	protected void PKNOLLBIIAC(DCAHKHCKELK GLDLCOBLGNF, HHCBNAPCKHF GICMDJHBIFF, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002795")]
	[Address(RVA = "0x24C1030", Offset = "0x24C1030", VA = "0x24C1030")]
	protected void OGFPFACMCDA(DCAHKHCKELK GLDLCOBLGNF, float OMAFEKBHOAA, float JODKCPOIMKI)
	{
	}

	[Token(Token = "0x6002796")]
	[Address(RVA = "0x24C1D78", Offset = "0x24C1D78", VA = "0x24C1D78")]
	protected void OGFPFACMCDA(DCAHKHCKELK GLDLCOBLGNF, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002797")]
	[Address(RVA = "0x24C1F80", Offset = "0x24C1F80", VA = "0x24C1F80")]
	protected void MKIAGPIPFNK(DCAHKHCKELK GLDLCOBLGNF, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002798")]
	[Address(RVA = "0x24C25D0", Offset = "0x24C25D0", VA = "0x24C25D0")]
	protected void FPFKMABNGGO(DCAHKHCKELK GLDLCOBLGNF, float FFDHFKIMFDG, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002799")]
	[Address(RVA = "0x24C2020", Offset = "0x24C2020", VA = "0x24C2020")]
	protected float IMFLDHEPJPI(DCAHKHCKELK GLDLCOBLGNF, float OMAFEKBHOAA)
	{
		return default(float);
	}

	[Token(Token = "0x600279A")]
	[Address(RVA = "0x24C2810", Offset = "0x24C2810", VA = "0x24C2810")]
	protected void BDDIAMGECCE(DCAHKHCKELK GLDLCOBLGNF, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600279B")]
	[Address(RVA = "0x24C2A94", Offset = "0x24C2A94", VA = "0x24C2A94")]
	protected void EOMLDECHBGG(DCAHKHCKELK GLDLCOBLGNF, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600279C")]
	[Address(RVA = "0x24C2188", Offset = "0x24C2188", VA = "0x24C2188")]
	protected void JAEPDFPHJCB(DCAHKHCKELK GLDLCOBLGNF, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600279D")]
	[Address(RVA = "0x24C2C7C", Offset = "0x24C2C7C", VA = "0x24C2C7C")]
	protected bool HPMJPDFKKKK(DCAHKHCKELK GLDLCOBLGNF, ref Vector3 EBIJHALKJEM, Vector3 COCOBLKAIMJ, float KGIHJOIEFGL)
	{
		return default(bool);
	}

	[Token(Token = "0x600279E")]
	[Address(RVA = "0x24C2F68", Offset = "0x24C2F68", VA = "0x24C2F68")]
	protected void ONBDAMGJICP(DCAHKHCKELK GLDLCOBLGNF, Vector3 KMAHBEJLLKO)
	{
	}

	[Token(Token = "0x600279F")]
	[Address(RVA = "0x24C174C", Offset = "0x24C174C", VA = "0x24C174C")]
	protected bool AOBJFGINENF(DCAHKHCKELK DOMBLCAEDAM, DCAHKHCKELK KFIMJINNMLI)
	{
		return default(bool);
	}

	[Token(Token = "0x60027A0")]
	[Address(RVA = "0x24C1230", Offset = "0x24C1230", VA = "0x24C1230")]
	protected void FCIHPEDNMHA(MFLFMLJGBKD NEIIGHOLOCA, DCAHKHCKELK GICMDJHBIFF, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60027A1")]
	[Address(RVA = "0x24C1530", Offset = "0x24C1530", VA = "0x24C1530")]
	protected void OLANOOJMCGJ(MFLFMLJGBKD NEIIGHOLOCA, HPHJBAGKDCJ GICMDJHBIFF, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60027A2")]
	[Address(RVA = "0x24C4064", Offset = "0x24C4064", VA = "0x24C4064")]
	private float NLHIADPKKIF(MFLFMLJGBKD NEIIGHOLOCA, HPHJBAGKDCJ GICMDJHBIFF, float OMAFEKBHOAA, float IOOPPDAAMEP = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x60027A3")]
	[Address(RVA = "0x24C4270", Offset = "0x24C4270", VA = "0x24C4270")]
	private float NLHIADPKKIF(MFLFMLJGBKD NEIIGHOLOCA, float AIBCDNINFJB, float OMAFEKBHOAA)
	{
		return default(float);
	}

	[Token(Token = "0x60027A4")]
	[Address(RVA = "0x24C30E4", Offset = "0x24C30E4", VA = "0x24C30E4")]
	protected void ADGFLJJJDBN(MFLFMLJGBKD NEIIGHOLOCA, HPHJBAGKDCJ GICMDJHBIFF, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60027A5")]
	[Address(RVA = "0x24C3194", Offset = "0x24C3194", VA = "0x24C3194")]
	protected float IDADILMGPCB(MFLFMLJGBKD NEIIGHOLOCA, HPHJBAGKDCJ GICMDJHBIFF, float OMAFEKBHOAA)
	{
		return default(float);
	}

	[Token(Token = "0x60027A6")]
	[Address(RVA = "0x24C33A8", Offset = "0x24C33A8", VA = "0x24C33A8")]
	protected void HFFBJBHKFCA(MFLFMLJGBKD NEIIGHOLOCA, HPHJBAGKDCJ GICMDJHBIFF, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60027A7")]
	[Address(RVA = "0x24C4470", Offset = "0x24C4470", VA = "0x24C4470")]
	private float ANPMHJHDIBM(DCAHKHCKELK PHEJDNJONIL)
	{
		return default(float);
	}

	[Token(Token = "0x60027A8")]
	[Address(RVA = "0x24C19EC", Offset = "0x24C19EC", VA = "0x24C19EC")]
	private void OHIOLIIDBOP(MFLFMLJGBKD NEIIGHOLOCA)
	{
	}

	[Token(Token = "0x60027A9")]
	[Address(RVA = "0x24C47B4", Offset = "0x24C47B4", VA = "0x24C47B4")]
	private void GMBEPHKKFAJ(MFLFMLJGBKD NEIIGHOLOCA, HPHJBAGKDCJ GICMDJHBIFF, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60027AA")]
	[Address(RVA = "0x24BE14C", Offset = "0x24BE14C", VA = "0x24BE14C")]
	private void ONEFONMDGAJ()
	{
	}

	[Token(Token = "0x60027AB")]
	[Address(RVA = "0x24BD604", Offset = "0x24BD604", VA = "0x24BD604")]
	private void JGKCPIHICNO()
	{
	}

	[Token(Token = "0x60027AC")]
	[Address(RVA = "0x24C4990", Offset = "0x24C4990", VA = "0x24C4990")]
	private GameObject HHBOGDBIOAF(ref bool DMPMINNLHON, ref Vector3 KGLGIAKNKAB, ResourceID JPFKGCMPLLM)
	{
		return null;
	}

	[Token(Token = "0x60027AD")]
	[Address(RVA = "0x24BCBC4", Offset = "0x24BCBC4", VA = "0x24BCBC4")]
	private void BAPDFDGDBIF()
	{
	}

	[Token(Token = "0x60027AE")]
	[Address(RVA = "0x24C4C34", Offset = "0x24C4C34", VA = "0x24C4C34")]
	private bool LEJAONMANFP()
	{
		return default(bool);
	}

	[Token(Token = "0x60027AF")]
	[Address(RVA = "0x24BE228", Offset = "0x24BE228", VA = "0x24BE228")]
	private void AGKLGKMFNJD()
	{
	}

	[Token(Token = "0x60027B0")]
	[Address(RVA = "0x24BD818", Offset = "0x24BD818", VA = "0x24BD818")]
	private void OKFLOBMMPLI()
	{
	}

	[Token(Token = "0x60027B1")]
	[Address(RVA = "0x24C4E14", Offset = "0x24C4E14", VA = "0x24C4E14")]
	private void BEPMCNELKOF(ResourceID JPFKGCMPLLM)
	{
	}

	[Token(Token = "0x60027B2")]
	[Address(RVA = "0x24BD8D0", Offset = "0x24BD8D0", VA = "0x24BD8D0")]
	private void CAHBKJMBBKO()
	{
	}

	[Token(Token = "0x60027B3")]
	[Address(RVA = "0x24BCD88", Offset = "0x24BCD88", VA = "0x24BCD88")]
	private void EIBHNKHPIND()
	{
	}

	[Token(Token = "0x60027B4")]
	[Address(RVA = "0x24C4F88", Offset = "0x24C4F88", VA = "0x24C4F88")]
	public void _003C_003EiFixBaseProxy_Init(ResourceID P0, JODBNBMENMC P1)
	{
	}

	[Token(Token = "0x60027B5")]
	[Address(RVA = "0x24C4F8C", Offset = "0x24C4F8C", VA = "0x24C4F8C")]
	public void _003C_003EiFixBaseProxy_AJKGLMOJJGI()
	{
	}

	[Token(Token = "0x60027B6")]
	[Address(RVA = "0x24C4FE4", Offset = "0x24C4FE4", VA = "0x24C4FE4")]
	public void _003C_003EiFixBaseProxy_BCAFIPCHLLJ(OPFMONINOBB P0, uint P1)
	{
	}

	[Token(Token = "0x60027B7")]
	[Address(RVA = "0x24C50BC", Offset = "0x24C50BC", VA = "0x24C50BC")]
	public void _003C_003EiFixBaseProxy_GDLCAJOJOKI(AttackableEntity P0, AttackableEntity P1)
	{
	}

	[Token(Token = "0x60027B8")]
	[Address(RVA = "0x24C5130", Offset = "0x24C5130", VA = "0x24C5130")]
	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x60027B9")]
	[Address(RVA = "0x24C5138", Offset = "0x24C5138", VA = "0x24C5138")]
	public new void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x60027BA")]
	[Address(RVA = "0x24C5208", Offset = "0x24C5208", VA = "0x24C5208")]
	public void _003C_003EiFixBaseProxy_MHNCKNMNAGL(float P0)
	{
	}
}
