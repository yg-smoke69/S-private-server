using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000A13")]
internal class FOFJEMOKAOH : _Attribute, IConvertible, IComparable<int>
{
	[Token(Token = "0x2000A14")]
	public enum CLCKGCKMDNE
	{
		[Token(Token = "0x4005AD1")]
		NONE,
		[Token(Token = "0x4005AD2")]
		FREE,
		[Token(Token = "0x4005AD3")]
		FIXED_LOCK,
		[Token(Token = "0x4005AD4")]
		FIXED_ORBIT
	}

	[Token(Token = "0x2000A15")]
	public enum IEMPBCJNBCC
	{
		[Token(Token = "0x4005AD6")]
		Manual,
		[Token(Token = "0x4005AD7")]
		Auto
	}

	[Token(Token = "0x2000A16")]
	public enum JPGMOPJDINK
	{
		[Token(Token = "0x4005AD9")]
		Damage,
		[Token(Token = "0x4005ADA")]
		KnockedDown
	}

	[Token(Token = "0x2000A17")]
	public enum GKINMFIHGBD
	{
		[Token(Token = "0x4005ADC")]
		Default,
		[Token(Token = "0x4005ADD")]
		ZoomIn_Scale1
	}

	[Token(Token = "0x2000A18")]
	private sealed class EEOAEPGPEPK
	{
		[Token(Token = "0x4005ADE")]
		[FieldOffset(Offset = "0x8")]
		internal byte NJMCMHANCHM;

		[Token(Token = "0x6004ED4")]
		[Address(RVA = "0x1D9A054", Offset = "0x1D9A054", VA = "0x1D9A054")]
		public EEOAEPGPEPK()
		{
		}

		[Token(Token = "0x6004ED5")]
		[Address(RVA = "0x1DA035C", Offset = "0x1DA035C", VA = "0x1DA035C")]
		internal bool CHOPCLCOBKC(TeamData OPJKJHBKLGN)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4005A7E")]
	protected const uint MKLPDBFENAC = 1u;

	[Token(Token = "0x4005A7F")]
	protected const uint LFJMNJIPINO = 2u;

	[Token(Token = "0x4005A80")]
	protected const uint EGCCKHNBENN = 4u;

	[Token(Token = "0x4005A81")]
	protected const uint FDJKHCAPPFP = 8u;

	[Token(Token = "0x4005A82")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003CEGGDHBFMIMB_003Ek__BackingField;

	[Token(Token = "0x4005A83")]
	[FieldOffset(Offset = "0x10")]
	private IHAAMHPPLMG _003CNIMFIBIBPDG_003Ek__BackingField;

	[Token(Token = "0x4005A84")]
	[FieldOffset(Offset = "0x28")]
	public IHAAMHPPLMG GMCBFADDHIB;

	[Token(Token = "0x4005A85")]
	[FieldOffset(Offset = "0x40")]
	private Player NJMDHHGDNPJ;

	[Token(Token = "0x4005A86")]
	[FieldOffset(Offset = "0x48")]
	private IHAAMHPPLMG _003CMEINKMDHOMJ_003Ek__BackingField;

	[Token(Token = "0x4005A87")]
	[FieldOffset(Offset = "0x60")]
	private CLCKGCKMDNE AHFMLFGAPGJ;

	[Token(Token = "0x4005A88")]
	[FieldOffset(Offset = "0x64")]
	public CLCKGCKMDNE COLLEINOEDD;

	[Token(Token = "0x4005A89")]
	[FieldOffset(Offset = "0x68")]
	private UIModelSpectator PJBOFJPMCJB;

	[Token(Token = "0x4005A8A")]
	[FieldOffset(Offset = "0x6C")]
	public bool HPLBAHJAOKH;

	[Token(Token = "0x4005A8B")]
	[FieldOffset(Offset = "0x6D")]
	private bool KAPGGFJFGOD;

	[Token(Token = "0x4005A8C")]
	[FieldOffset(Offset = "0x6E")]
	private bool IJCLIJINNID;

	[Token(Token = "0x4005A8D")]
	[FieldOffset(Offset = "0x6F")]
	private bool KCOODHJBNLK;

	[Token(Token = "0x4005A8E")]
	[FieldOffset(Offset = "0x70")]
	private bool IJCEILBEAOB;

	[Token(Token = "0x4005A8F")]
	[FieldOffset(Offset = "0x71")]
	private bool JCDDLEODCIH;

	[Token(Token = "0x4005A90")]
	[FieldOffset(Offset = "0x72")]
	private bool CEGCOEOOKJP;

	[Token(Token = "0x4005A91")]
	[FieldOffset(Offset = "0x73")]
	public bool PHNANNNLNCI;

	[Token(Token = "0x4005A92")]
	[FieldOffset(Offset = "0x74")]
	private IEMPBCJNBCC APPFOJKCBHH;

	[Token(Token = "0x4005A93")]
	[FieldOffset(Offset = "0x78")]
	private int _003CPOKPLFLPBGP_003Ek__BackingField;

	[Token(Token = "0x4005A94")]
	[FieldOffset(Offset = "0x7C")]
	private AudioResource OEIDBPJAFHE;

	[Token(Token = "0x4005A95")]
	[FieldOffset(Offset = "0x80")]
	private AudioResource LDPJOPNGNKC;

	[Token(Token = "0x4005A96")]
	[FieldOffset(Offset = "0x84")]
	private AudioResource ELKHHIIMOCP;

	[Token(Token = "0x4005A97")]
	[FieldOffset(Offset = "0x88")]
	private JADJBFDFEHA LMFFNPPOAGL;

	[Token(Token = "0x4005A98")]
	[FieldOffset(Offset = "0x8C")]
	private uint EAMBEAEMLBJ;

	[Token(Token = "0x4005A99")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 PNCIFOBFNCF;

	[Token(Token = "0x4005A9A")]
	[FieldOffset(Offset = "0x9C")]
	private Quaternion IOGJEGEBMOM;

	[Token(Token = "0x4005A9B")]
	[FieldOffset(Offset = "0xAC")]
	private float EDJKNKEDNMG;

	[Token(Token = "0x4005A9C")]
	[FieldOffset(Offset = "0xB0")]
	private Vector3 MDMJIGHMFPJ;

	[Token(Token = "0x4005A9D")]
	[FieldOffset(Offset = "0xBC")]
	private float EGAEDFOEKLI;

	[Token(Token = "0x4005A9E")]
	[FieldOffset(Offset = "0xC0")]
	private float BMEFOIBJGBI;

	[Token(Token = "0x4005A9F")]
	[FieldOffset(Offset = "0xC4")]
	private float ILGHEDBLHNH;

	[Token(Token = "0x4005AA0")]
	[FieldOffset(Offset = "0xC8")]
	private bool GECIFPDAHKD;

	[Token(Token = "0x4005AA1")]
	[FieldOffset(Offset = "0xC9")]
	private bool FFBDDGMDPGI;

	[Token(Token = "0x4005AA2")]
	[FieldOffset(Offset = "0xCA")]
	private bool LLFNMHELJDA;

	[Token(Token = "0x4005AA3")]
	[FieldOffset(Offset = "0xCC")]
	private float ELGKDMLDABA;

	[Token(Token = "0x4005AA4")]
	[FieldOffset(Offset = "0xD0")]
	private float BKOMFMEMLOK;

	[Token(Token = "0x4005AA5")]
	private const float LCODONHIFED = 0.8f;

	[Token(Token = "0x4005AA6")]
	[FieldOffset(Offset = "0xD4")]
	private HashSet<ResourceID> LGENOIBFAME;

	[Token(Token = "0x4005AA7")]
	[FieldOffset(Offset = "0xD8")]
	private Dictionary<KeyCode, int> JBNFOBDFGKE;

	[Token(Token = "0x4005AA8")]
	[FieldOffset(Offset = "0xDC")]
	private bool LLHECBLCBEE;

	[Token(Token = "0x4005AA9")]
	[FieldOffset(Offset = "0xDD")]
	private bool CIDCHMADLPA;

	[Token(Token = "0x4005AAA")]
	[FieldOffset(Offset = "0xE0")]
	private Dictionary<KeyCode, Action> APIJNFFHFFL;

	[Token(Token = "0x4005AAB")]
	[FieldOffset(Offset = "0xE4")]
	private Dictionary<KeyCode, Action> DMOKLOMKAAB;

	[Token(Token = "0x4005AAC")]
	[FieldOffset(Offset = "0xE8")]
	private Dictionary<KeyCode, Action> HMBHKEODNKD;

	[Token(Token = "0x4005AAD")]
	[FieldOffset(Offset = "0x0")]
	private static Action HMDOHFBHDOB;

	[Token(Token = "0x4005AAE")]
	[FieldOffset(Offset = "0x4")]
	private static Action AOCDJNOINOH;

	[Token(Token = "0x4005AAF")]
	[FieldOffset(Offset = "0x8")]
	private static Action AAOFHFGKOBN;

	[Token(Token = "0x4005AB0")]
	[FieldOffset(Offset = "0xC")]
	private static Action KJNIBJNOINP;

	[Token(Token = "0x4005AB1")]
	[FieldOffset(Offset = "0x10")]
	private static Action LMELNMABMHH;

	[Token(Token = "0x4005AB2")]
	[FieldOffset(Offset = "0x14")]
	private static Action CBMPCCOKCBK;

	[Token(Token = "0x4005AB3")]
	[FieldOffset(Offset = "0x18")]
	private static Action ELAGCOFNAMO;

	[Token(Token = "0x4005AB4")]
	[FieldOffset(Offset = "0x1C")]
	private static Action FLBCAAMNJAP;

	[Token(Token = "0x4005AB5")]
	[FieldOffset(Offset = "0x20")]
	private static Action MMDDJGMHMCI;

	[Token(Token = "0x4005AB6")]
	[FieldOffset(Offset = "0x24")]
	private static Action HAIFJFNCJKC;

	[Token(Token = "0x4005AB7")]
	[FieldOffset(Offset = "0x28")]
	private static Action NGJCJHIKPPA;

	[Token(Token = "0x4005AB8")]
	[FieldOffset(Offset = "0x2C")]
	private static Action BICJKLLPHCA;

	[Token(Token = "0x4005AB9")]
	[FieldOffset(Offset = "0x30")]
	private static Action GCCOFMCMMGF;

	[Token(Token = "0x4005ABA")]
	[FieldOffset(Offset = "0x34")]
	private static Action JILJPNGEBCL;

	[Token(Token = "0x4005ABB")]
	[FieldOffset(Offset = "0x38")]
	private static Action BDMJJKDFFGC;

	[Token(Token = "0x4005ABC")]
	[FieldOffset(Offset = "0x3C")]
	private static Action CCBADAAKOKA;

	[Token(Token = "0x4005ABD")]
	[FieldOffset(Offset = "0x40")]
	private static Action KPDCMLHMLOA;

	[Token(Token = "0x4005ABE")]
	[FieldOffset(Offset = "0x44")]
	private static Action HOHJDBKGADG;

	[Token(Token = "0x4005ABF")]
	[FieldOffset(Offset = "0x48")]
	private static Action MEFBBPIAOMM;

	[Token(Token = "0x4005AC0")]
	[FieldOffset(Offset = "0x4C")]
	private static Action DOPAIPFLBKG;

	[Token(Token = "0x4005AC1")]
	[FieldOffset(Offset = "0x50")]
	private static Action OICICGAIKLE;

	[Token(Token = "0x4005AC2")]
	[FieldOffset(Offset = "0x54")]
	private static Action EOCALNMBEIE;

	[Token(Token = "0x4005AC3")]
	[FieldOffset(Offset = "0x58")]
	private static Action FHEMLPGAFJD;

	[Token(Token = "0x4005AC4")]
	[FieldOffset(Offset = "0x5C")]
	private static Action OKNGCEKEHMN;

	[Token(Token = "0x4005AC5")]
	[FieldOffset(Offset = "0x60")]
	private static Action HMOLKPJMDOC;

	[Token(Token = "0x4005AC6")]
	[FieldOffset(Offset = "0x64")]
	private static Action MCHPCPJKIPL;

	[Token(Token = "0x4005AC7")]
	[FieldOffset(Offset = "0x68")]
	private static Action CMMGKMGANJE;

	[Token(Token = "0x4005AC8")]
	[FieldOffset(Offset = "0x6C")]
	private static Action CKMLPAABEFA;

	[Token(Token = "0x4005AC9")]
	[FieldOffset(Offset = "0x70")]
	private static Action NKCBLONLCNH;

	[Token(Token = "0x4005ACA")]
	[FieldOffset(Offset = "0x74")]
	private static Action KMNJKBINMIL;

	[Token(Token = "0x4005ACB")]
	[FieldOffset(Offset = "0x78")]
	private static Action IPMNMNJODBJ;

	[Token(Token = "0x4005ACC")]
	[FieldOffset(Offset = "0x7C")]
	private static Action FAJGJBBGDNH;

	[Token(Token = "0x4005ACD")]
	[FieldOffset(Offset = "0x80")]
	private static Action BDIGKFJGALI;

	[Token(Token = "0x4005ACE")]
	[FieldOffset(Offset = "0x84")]
	private static Action HAPBJDOGIJI;

	[Token(Token = "0x4005ACF")]
	[FieldOffset(Offset = "0x88")]
	private static Action KHLCHJGFNCI;

	[Token(Token = "0x17000618")]
	public ulong MIJOCMKONAD
	{
		[Token(Token = "0x6004E18")]
		[Address(RVA = "0x1D8C920", Offset = "0x1D8C920", VA = "0x1D8C920")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6004E19")]
		[Address(RVA = "0x1D8C928", Offset = "0x1D8C928", VA = "0x1D8C928")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000619")]
	public IHAAMHPPLMG IHAAMHPPLMG
	{
		[Token(Token = "0x6004E1A")]
		[Address(RVA = "0x1D8C938", Offset = "0x1D8C938", VA = "0x1D8C938", Slot = "17")]
		get
		{
			return default(IHAAMHPPLMG);
		}
		[Token(Token = "0x6004E1B")]
		[Address(RVA = "0x1D8C950", Offset = "0x1D8C950", VA = "0x1D8C950")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700061A")]
	public Player GEMHAAHJBBD
	{
		[Token(Token = "0x6004E1C")]
		[Address(RVA = "0x1D8C984", Offset = "0x1D8C984", VA = "0x1D8C984", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004E1D")]
		[Address(RVA = "0x1D8C9DC", Offset = "0x1D8C9DC", VA = "0x1D8C9DC")]
		set
		{
		}
	}

	[Token(Token = "0x1700061B")]
	public IHAAMHPPLMG OFNCAKPLFPP
	{
		[Token(Token = "0x6004E1E")]
		[Address(RVA = "0x1D8CDBC", Offset = "0x1D8CDBC", VA = "0x1D8CDBC", Slot = "5")]
		get
		{
			return default(IHAAMHPPLMG);
		}
		[Token(Token = "0x6004E1F")]
		[Address(RVA = "0x1D8CDD4", Offset = "0x1D8CDD4", VA = "0x1D8CDD4", Slot = "6")]
		set
		{
		}
	}

	[Token(Token = "0x1700061C")]
	public CLCKGCKMDNE MNOODDGKJCM
	{
		[Token(Token = "0x6004E20")]
		[Address(RVA = "0x1D8CE08", Offset = "0x1D8CE08", VA = "0x1D8CE08")]
		get
		{
			return default(CLCKGCKMDNE);
		}
	}

	[Token(Token = "0x1700061D")]
	public bool BLIFMKPHHDD
	{
		[Token(Token = "0x6004E21")]
		[Address(RVA = "0x1D8CE60", Offset = "0x1D8CE60", VA = "0x1D8CE60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700061E")]
	public bool APHCHLJCNLO
	{
		[Token(Token = "0x6004E22")]
		[Address(RVA = "0x1D8CEB8", Offset = "0x1D8CEB8", VA = "0x1D8CEB8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700061F")]
	public bool FHCABNBLCJJ
	{
		[Token(Token = "0x6004E23")]
		[Address(RVA = "0x1D8CF10", Offset = "0x1D8CF10", VA = "0x1D8CF10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000620")]
	public IEMPBCJNBCC DHEJFFLJGCK
	{
		[Token(Token = "0x6004E24")]
		[Address(RVA = "0x1D8CF68", Offset = "0x1D8CF68", VA = "0x1D8CF68")]
		get
		{
			return default(IEMPBCJNBCC);
		}
	}

	[Token(Token = "0x17000621")]
	public IHAAMHPPLMG GHHENFFJPHK
	{
		[Token(Token = "0x6004E25")]
		[Address(RVA = "0x1D8CFC0", Offset = "0x1D8CFC0", VA = "0x1D8CFC0")]
		get
		{
			return default(IHAAMHPPLMG);
		}
	}

	[Token(Token = "0x17000622")]
	public int CHDNEIFDJBI
	{
		[Token(Token = "0x6004E26")]
		[Address(RVA = "0x1D8D0F0", Offset = "0x1D8D0F0", VA = "0x1D8D0F0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004E27")]
		[Address(RVA = "0x1D8D0F8", Offset = "0x1D8D0F8", VA = "0x1D8D0F8")]
		set
		{
		}
	}

	[Token(Token = "0x17000623")]
	public OPILIBBOEAC AEMHIOJGMBP
	{
		[Token(Token = "0x6004E29")]
		[Address(RVA = "0x1D8D468", Offset = "0x1D8D468", VA = "0x1D8D468", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000624")]
	public Player LNLKCHLDGPF
	{
		[Token(Token = "0x6004E8F")]
		[Address(RVA = "0x1D9996C", Offset = "0x1D9996C", VA = "0x1D9996C", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004E17")]
	[Address(RVA = "0x1D8C480", Offset = "0x1D8C480", VA = "0x1D8C480")]
	public FOFJEMOKAOH()
	{
	}

	[Token(Token = "0x6004E28")]
	[Address(RVA = "0x1D8D100", Offset = "0x1D8D100", VA = "0x1D8D100", Slot = "20")]
	public bool IsPassengerInVehicleCanFire()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E2A")]
	[Address(RVA = "0x1D8D578", Offset = "0x1D8D578", VA = "0x1D8D578", Slot = "34")]
	public bool HasHeuristicTarget()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E2B")]
	[Address(RVA = "0x1D8D688", Offset = "0x1D8D688", VA = "0x1D8D688")]
	public static FOFJEMOKAOH GADCPIFBKKJ(ulong HHMJNLLBELP, IHAAMHPPLMG BIFFAIEPIND)
	{
		return null;
	}

	[Token(Token = "0x6004E2C")]
	[Address(RVA = "0x1D8D7EC", Offset = "0x1D8D7EC", VA = "0x1D8D7EC")]
	public void DPLMGOJKKCM()
	{
	}

	[Token(Token = "0x6004E2D")]
	[Address(RVA = "0x1D8E6F0", Offset = "0x1D8E6F0", VA = "0x1D8E6F0")]
	private void NIODNAPKEJM(CLCKGCKMDNE HPKCDJLHEFO)
	{
	}

	[Token(Token = "0x6004E2E")]
	[Address(RVA = "0x1D8EF90", Offset = "0x1D8EF90", VA = "0x1D8EF90")]
	public void AAMLGLMAHCF(Vector3 ACCOJJMKKPM, Vector3 JGOGIAFGCFC)
	{
	}

	[Token(Token = "0x6004E2F")]
	[Address(RVA = "0x1D8F4CC", Offset = "0x1D8F4CC", VA = "0x1D8F4CC")]
	public void APGEEPGCDMK()
	{
	}

	[Token(Token = "0x6004E30")]
	[Address(RVA = "0x1D8DB54", Offset = "0x1D8DB54", VA = "0x1D8DB54")]
	private void LJCHOGABCHL()
	{
	}

	[Token(Token = "0x6004E31")]
	[Address(RVA = "0x1D8E9EC", Offset = "0x1D8E9EC", VA = "0x1D8E9EC")]
	private void LOOEMPCICNG()
	{
	}

	[Token(Token = "0x6004E32")]
	[Address(RVA = "0x1D8EDB4", Offset = "0x1D8EDB4", VA = "0x1D8EDB4")]
	private void LDFCHCGIFJO()
	{
	}

	[Token(Token = "0x6004E33")]
	[Address(RVA = "0x1D90068", Offset = "0x1D90068", VA = "0x1D90068")]
	private void MCJMFABEGGH()
	{
	}

	[Token(Token = "0x6004E34")]
	[Address(RVA = "0x1D8E054", Offset = "0x1D8E054", VA = "0x1D8E054")]
	private void CIAGEFMBAKJ()
	{
	}

	[Token(Token = "0x6004E35")]
	[Address(RVA = "0x1D91228", Offset = "0x1D91228", VA = "0x1D91228")]
	private void OCILOFGOMKE()
	{
	}

	[Token(Token = "0x6004E36")]
	[Address(RVA = "0x1D91690", Offset = "0x1D91690", VA = "0x1D91690")]
	public void FHIPMICEPMI(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004E37")]
	[Address(RVA = "0x1D91710", Offset = "0x1D91710", VA = "0x1D91710")]
	private void GLDCPDELDME()
	{
	}

	[Token(Token = "0x6004E38")]
	[Address(RVA = "0x1D918F0", Offset = "0x1D918F0", VA = "0x1D918F0")]
	public void CMLAICLIFEE()
	{
	}

	[Token(Token = "0x6004E39")]
	[Address(RVA = "0x1D91B50", Offset = "0x1D91B50", VA = "0x1D91B50")]
	public void NFANDEJEBLF()
	{
	}

	[Token(Token = "0x6004E3A")]
	[Address(RVA = "0x1D91BAC", Offset = "0x1D91BAC", VA = "0x1D91BAC")]
	public void CBJOBPHNFFL()
	{
	}

	[Token(Token = "0x6004E3B")]
	[Address(RVA = "0x1D92508", Offset = "0x1D92508", VA = "0x1D92508")]
	public void JLNICMEGFBN()
	{
	}

	[Token(Token = "0x6004E3C")]
	[Address(RVA = "0x1D92718", Offset = "0x1D92718", VA = "0x1D92718")]
	private void NLPDBGAJGGP(int IDNEFEOPGIF)
	{
	}

	[Token(Token = "0x6004E3D")]
	[Address(RVA = "0x1D92228", Offset = "0x1D92228", VA = "0x1D92228")]
	private void LAINCPKOBEA(int POGMMPCAAMM)
	{
	}

	[Token(Token = "0x6004E3E")]
	[Address(RVA = "0x1D92870", Offset = "0x1D92870", VA = "0x1D92870")]
	public void EACHEFGGHBK(float LBMGGMBKAEH)
	{
	}

	[Token(Token = "0x6004E3F")]
	[Address(RVA = "0x1D93348", Offset = "0x1D93348", VA = "0x1D93348")]
	public void PPLMKEJJHFO()
	{
	}

	[Token(Token = "0x6004E40")]
	[Address(RVA = "0x1D933A8", Offset = "0x1D933A8", VA = "0x1D933A8", Slot = "12")]
	public Quaternion GetCameraTrackableEntityAimRotation()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x6004E41")]
	[Address(RVA = "0x1D93518", Offset = "0x1D93518", VA = "0x1D93518", Slot = "10")]
	public Vector3 GetCameraTrackableEntityPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6004E42")]
	[Address(RVA = "0x1D9368C", Offset = "0x1D9368C", VA = "0x1D9368C", Slot = "11")]
	public Vector3 GetCameraTrackableEntityTopPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6004E43")]
	[Address(RVA = "0x1D93720", Offset = "0x1D93720", VA = "0x1D93720", Slot = "13")]
	public Transform GetCameraTrackableEntityTransfrom()
	{
		return null;
	}

	[Token(Token = "0x6004E44")]
	[Address(RVA = "0x1D937A0", Offset = "0x1D937A0", VA = "0x1D937A0", Slot = "14")]
	public bool IsCameraTrackableEntityAlive()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E45")]
	[Address(RVA = "0x1D938B0", Offset = "0x1D938B0", VA = "0x1D938B0", Slot = "15")]
	public List<Vector3> GetBoundingBoxList()
	{
		return null;
	}

	[Token(Token = "0x6004E46")]
	[Address(RVA = "0x1D93930", Offset = "0x1D93930", VA = "0x1D93930", Slot = "16")]
	public GameObject GetGameObject()
	{
		return null;
	}

	[Token(Token = "0x6004E47")]
	[Address(RVA = "0x1D93A40", Offset = "0x1D93A40", VA = "0x1D93A40", Slot = "37")]
	public bool GetSightingState()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E48")]
	[Address(RVA = "0x1D93B58", Offset = "0x1D93B58", VA = "0x1D93B58", Slot = "38")]
	public bool IsSightingUIAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E49")]
	[Address(RVA = "0x1D93C64", Offset = "0x1D93C64", VA = "0x1D93C64")]
	public bool BOOEJDKLIDG()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E4A")]
	[Address(RVA = "0x1D93D64", Offset = "0x1D93D64", VA = "0x1D93D64")]
	private void JBLPHHHOINO()
	{
	}

	[Token(Token = "0x6004E4B")]
	[Address(RVA = "0x1D93ED4", Offset = "0x1D93ED4", VA = "0x1D93ED4", Slot = "39")]
	public void OnSightingUIStateChange(bool HNFJGOBEMKM, float HCIFNBGLHIF)
	{
	}

	[Token(Token = "0x6004E4C")]
	[Address(RVA = "0x1D940C0", Offset = "0x1D940C0", VA = "0x1D940C0", Slot = "35")]
	public bool IsTargetFriend(OPILIBBOEAC FFDHFKIMFDG)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E4D")]
	[Address(RVA = "0x1D94718", Offset = "0x1D94718", VA = "0x1D94718", Slot = "36")]
	public bool HeuristicTargetIsFriend()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E4E")]
	[Address(RVA = "0x1D91120", Offset = "0x1D91120", VA = "0x1D91120")]
	private void KCELHEPBKAF()
	{
	}

	[Token(Token = "0x6004E4F")]
	[Address(RVA = "0x1D90B20", Offset = "0x1D90B20", VA = "0x1D90B20")]
	private void LLELGPLFFEI()
	{
	}

	[Token(Token = "0x6004E50")]
	[Address(RVA = "0x1D90EBC", Offset = "0x1D90EBC", VA = "0x1D90EBC")]
	private void CPCLOKPNCBJ()
	{
	}

	[Token(Token = "0x6004E51")]
	[Address(RVA = "0x1D94828", Offset = "0x1D94828", VA = "0x1D94828")]
	private void BDEHDNFGOCH(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6004E52")]
	[Address(RVA = "0x1D949DC", Offset = "0x1D949DC", VA = "0x1D949DC")]
	private void FOPAEMLDINJ(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6004E53")]
	[Address(RVA = "0x1D94B90", Offset = "0x1D94B90", VA = "0x1D94B90")]
	private void JCOFNKFDCHG(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6004E54")]
	[Address(RVA = "0x1D90C98", Offset = "0x1D90C98", VA = "0x1D90C98")]
	private void PCCGLPOIAAI()
	{
	}

	[Token(Token = "0x6004E55")]
	[Address(RVA = "0x1D91014", Offset = "0x1D91014", VA = "0x1D91014")]
	private void IEAFELPDOMG()
	{
	}

	[Token(Token = "0x6004E56")]
	[Address(RVA = "0x1D94D44", Offset = "0x1D94D44", VA = "0x1D94D44")]
	private void NGGAPCFAIIF(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6004E57")]
	[Address(RVA = "0x1D94EF8", Offset = "0x1D94EF8", VA = "0x1D94EF8")]
	private void NDMEJAPDNHA(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6004E58")]
	[Address(RVA = "0x1D950AC", Offset = "0x1D950AC", VA = "0x1D950AC")]
	private void LPIMHLMDEED(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6004E59")]
	[Address(RVA = "0x1D95218", Offset = "0x1D95218", VA = "0x1D95218")]
	private void EDFJMDDDIIM(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6004E5A")]
	[Address(RVA = "0x1D95418", Offset = "0x1D95418", VA = "0x1D95418")]
	private void HJLJBGILNDB(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6004E5B")]
	[Address(RVA = "0x1D9578C", Offset = "0x1D9578C", VA = "0x1D9578C")]
	private void KFNMHLFBIAP(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6004E5C")]
	[Address(RVA = "0x1D95950", Offset = "0x1D95950", VA = "0x1D95950", Slot = "31")]
	public AAHMJHHPECM GetItemOnHand()
	{
		return null;
	}

	[Token(Token = "0x6004E5D")]
	[Address(RVA = "0x1D95A60", Offset = "0x1D95A60", VA = "0x1D95A60", Slot = "32")]
	public AAHMJHHPECM GetRealItemOnHand()
	{
		return null;
	}

	[Token(Token = "0x6004E5E")]
	[Address(RVA = "0x1D95B70", Offset = "0x1D95B70", VA = "0x1D95B70", Slot = "18")]
	public bool IsInVehicle()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E5F")]
	[Address(RVA = "0x1D8D358", Offset = "0x1D8D358", VA = "0x1D8D358", Slot = "19")]
	public Vehicle VehicleIAmIn()
	{
		return null;
	}

	[Token(Token = "0x6004E60")]
	[Address(RVA = "0x1D95C80", Offset = "0x1D95C80", VA = "0x1D95C80", Slot = "21")]
	public bool IsOnStrop()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E61")]
	[Address(RVA = "0x1D95D90", Offset = "0x1D95D90", VA = "0x1D95D90", Slot = "22")]
	public bool IsOnChair()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E62")]
	[Address(RVA = "0x1D95EA0", Offset = "0x1D95EA0", VA = "0x1D95EA0", Slot = "23")]
	public bool IsInCatapult()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E63")]
	[Address(RVA = "0x1D95FB0", Offset = "0x1D95FB0", VA = "0x1D95FB0")]
	public bool NEANJGGKKDG()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E64")]
	[Address(RVA = "0x1D960C0", Offset = "0x1D960C0", VA = "0x1D960C0", Slot = "24")]
	public bool IsOnGrapplingHook()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E65")]
	[Address(RVA = "0x1D961D0", Offset = "0x1D961D0", VA = "0x1D961D0", Slot = "26")]
	public bool IsOnVMEHook()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E66")]
	[Address(RVA = "0x1D962E0", Offset = "0x1D962E0", VA = "0x1D962E0", Slot = "25")]
	public bool IsOnHook()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E67")]
	[Address(RVA = "0x1D963F0", Offset = "0x1D963F0", VA = "0x1D963F0", Slot = "27")]
	public bool HasGrapplingHook()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E68")]
	[Address(RVA = "0x1D96500", Offset = "0x1D96500", VA = "0x1D96500", Slot = "28")]
	public bool HasHook()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E69")]
	[Address(RVA = "0x1D96610", Offset = "0x1D96610", VA = "0x1D96610", Slot = "29")]
	public bool HasVMEHook()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E6A")]
	[Address(RVA = "0x1D96720", Offset = "0x1D96720", VA = "0x1D96720", Slot = "30")]
	public LevelStrop GetStropIAmOn()
	{
		return null;
	}

	[Token(Token = "0x6004E6B")]
	[Address(RVA = "0x1D96830", Offset = "0x1D96830", VA = "0x1D96830")]
	public void HHMFMAEGBLB(ulong DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004E6C")]
	[Address(RVA = "0x1D8FBA8", Offset = "0x1D8FBA8", VA = "0x1D8FBA8")]
	public void KAPFADNEEDM()
	{
	}

	[Token(Token = "0x6004E6D")]
	[Address(RVA = "0x1D96E34", Offset = "0x1D96E34", VA = "0x1D96E34", Slot = "8")]
	public void BIHLCIFBFIN(bool OCKBMCMIHKJ)
	{
	}

	[Token(Token = "0x6004E6E")]
	[Address(RVA = "0x1D96EA4", Offset = "0x1D96EA4", VA = "0x1D96EA4")]
	private void DHFFEFCCOBE(bool OCKBMCMIHKJ, bool MGNFKKCHCIG)
	{
	}

	[Token(Token = "0x6004E6F")]
	[Address(RVA = "0x1D96F70", Offset = "0x1D96F70", VA = "0x1D96F70")]
	private void GEBIIDIKHKI(bool OCKBMCMIHKJ)
	{
	}

	[Token(Token = "0x6004E70")]
	[Address(RVA = "0x1D97248", Offset = "0x1D97248", VA = "0x1D97248")]
	public void OPENFAMEAGJ(bool OCKBMCMIHKJ, bool CAMDMPIAHFB, bool KKBGKJNDILE = false)
	{
	}

	[Token(Token = "0x6004E71")]
	[Address(RVA = "0x1D97D98", Offset = "0x1D97D98", VA = "0x1D97D98")]
	private Player HAPPKFHGKHG(bool OCKBMCMIHKJ, bool CAMDMPIAHFB, IHAAMHPPLMG IDNEFEOPGIF)
	{
		return null;
	}

	[Token(Token = "0x6004E72")]
	[Address(RVA = "0x1D8F588", Offset = "0x1D8F588", VA = "0x1D8F588")]
	public void BHJAJJFFOJB(IHAAMHPPLMG BIFFAIEPIND)
	{
	}

	[Token(Token = "0x6004E73")]
	[Address(RVA = "0x1D98054", Offset = "0x1D98054", VA = "0x1D98054", Slot = "9")]
	public void MAFEBNOPFPH()
	{
	}

	[Token(Token = "0x6004E74")]
	[Address(RVA = "0x1D92A38", Offset = "0x1D92A38", VA = "0x1D92A38")]
	private void DIIGKCPLKGA()
	{
	}

	[Token(Token = "0x6004E75")]
	[Address(RVA = "0x1D92E34", Offset = "0x1D92E34", VA = "0x1D92E34")]
	public void OFBKDIJBFKL(float LBMGGMBKAEH)
	{
	}

	[Token(Token = "0x6004E76")]
	[Address(RVA = "0x1D980A8", Offset = "0x1D980A8", VA = "0x1D980A8")]
	private Vector3 MOPCGJOHLGI()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6004E77")]
	[Address(RVA = "0x1D98240", Offset = "0x1D98240", VA = "0x1D98240")]
	private void IBDLFHGLDKC(float PODKEPNOBON, Vector3 DENFJNNDEMD)
	{
	}

	[Token(Token = "0x6004E78")]
	[Address(RVA = "0x1D98858", Offset = "0x1D98858", VA = "0x1D98858")]
	private void JEPDKAOLKII()
	{
	}

	[Token(Token = "0x6004E79")]
	[Address(RVA = "0x1D984E4", Offset = "0x1D984E4", VA = "0x1D984E4")]
	private float DKIKOCKNKBF()
	{
		return default(float);
	}

	[Token(Token = "0x6004E7A")]
	[Address(RVA = "0x1D98954", Offset = "0x1D98954", VA = "0x1D98954")]
	private float NEHJGBGNJIK()
	{
		return default(float);
	}

	[Token(Token = "0x6004E7B")]
	[Address(RVA = "0x1D93230", Offset = "0x1D93230", VA = "0x1D93230")]
	private void BGLABBOELID(float LBMGGMBKAEH)
	{
	}

	[Token(Token = "0x6004E7C")]
	[Address(RVA = "0x1D98A4C", Offset = "0x1D98A4C", VA = "0x1D98A4C")]
	private float HHFIBAEBLOB(float COCOBLKAIMJ)
	{
		return default(float);
	}

	[Token(Token = "0x6004E7D")]
	[Address(RVA = "0x1D985CC", Offset = "0x1D985CC", VA = "0x1D985CC")]
	private void POAPHJFGOIG(float GEFGNGCDHJF = 1f)
	{
	}

	[Token(Token = "0x6004E7E")]
	[Address(RVA = "0x1D98B68", Offset = "0x1D98B68", VA = "0x1D98B68")]
	public void GIOAAJAFNKP()
	{
	}

	[Token(Token = "0x6004E7F")]
	[Address(RVA = "0x1D98C20", Offset = "0x1D98C20", VA = "0x1D98C20")]
	public void IONJMDEBCOK()
	{
	}

	[Token(Token = "0x6004E80")]
	[Address(RVA = "0x1D98FA4", Offset = "0x1D98FA4", VA = "0x1D98FA4")]
	public void EHGCGJCDJMI(KIPMKBAKIPF LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004E81")]
	[Address(RVA = "0x1D8DFF8", Offset = "0x1D8DFF8", VA = "0x1D8DFF8")]
	public void LGNLFNNALPE(bool CBMDILHHMKG = false)
	{
	}

	[Token(Token = "0x6004E82")]
	[Address(RVA = "0x1D99028", Offset = "0x1D99028", VA = "0x1D99028")]
	public void FHOGGMJKEAB(bool JEBCKDCKAAB = false)
	{
	}

	[Token(Token = "0x6004E83")]
	[Address(RVA = "0x1D8EF00", Offset = "0x1D8EF00", VA = "0x1D8EF00")]
	private void LICCLNJLMIM(IHAAMHPPLMG KAEHJEGFKBL)
	{
	}

	[Token(Token = "0x6004E84")]
	[Address(RVA = "0x1D99084", Offset = "0x1D99084", VA = "0x1D99084")]
	private bool GMACCNBPMIB()
	{
		return default(bool);
	}

	[Token(Token = "0x6004E85")]
	[Address(RVA = "0x1D9918C", Offset = "0x1D9918C", VA = "0x1D9918C")]
	public bool BLPHCDLCFGO(Vector3 ACCOJJMKKPM)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E86")]
	[Address(RVA = "0x1D9933C", Offset = "0x1D9933C", VA = "0x1D9933C")]
	public bool GLPLDFJBLLO(uint CGDBJAIFEAB)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E87")]
	[Address(RVA = "0x1D99444", Offset = "0x1D99444", VA = "0x1D99444")]
	private void OEMAIPIIDNK(IEMPBCJNBCC HPKCDJLHEFO)
	{
	}

	[Token(Token = "0x6004E88")]
	[Address(RVA = "0x1D995F8", Offset = "0x1D995F8", VA = "0x1D995F8")]
	private void EBCNIGABLOM()
	{
	}

	[Token(Token = "0x6004E89")]
	[Address(RVA = "0x1D99824", Offset = "0x1D99824", VA = "0x1D99824")]
	public void EBEIGFOHMJK(bool JOGHOHLEJFL)
	{
	}

	[Token(Token = "0x6004E8A")]
	[Address(RVA = "0x1D99884", Offset = "0x1D99884", VA = "0x1D99884")]
	public void MMHBDBAAEEN(IHAAMHPPLMG CHCAHDEDLGH, IHAAMHPPLMG PKADMILNGLI)
	{
	}

	[Token(Token = "0x6004E8B")]
	[Address(RVA = "0x1D8CAD4", Offset = "0x1D8CAD4", VA = "0x1D8CAD4")]
	private void GKLDBBFBEBP()
	{
	}

	[Token(Token = "0x6004E8C")]
	[Address(RVA = "0x1D8CBD0", Offset = "0x1D8CBD0", VA = "0x1D8CBD0")]
	private void EONIAFMMMMK()
	{
	}

	[Token(Token = "0x6004E8D")]
	[Address(RVA = "0x1D955D8", Offset = "0x1D955D8", VA = "0x1D955D8")]
	private void KHOCLLCJKBL(ref AudioResource LHLMBBIBDLB, ResourceID KMIPBIGPDPI, bool CGHMPOEIMMP)
	{
	}

	[Token(Token = "0x6004E8E")]
	[Address(RVA = "0x1D91FF8", Offset = "0x1D91FF8", VA = "0x1D91FF8")]
	private int FNILBPKONLO()
	{
		return default(int);
	}

	[Token(Token = "0x6004E90")]
	[Address(RVA = "0x1D999CC", Offset = "0x1D999CC", VA = "0x1D999CC")]
	public void MKNEFFDNGKP(JADJBFDFEHA PMGBACFJIHO, uint NMAJCLPMCDN)
	{
	}

	[Token(Token = "0x6004E91")]
	[Address(RVA = "0x1D8F520", Offset = "0x1D8F520", VA = "0x1D8F520")]
	private void BADHPLGJJPO()
	{
	}

	[Token(Token = "0x6004E92")]
	[Address(RVA = "0x1D99B3C", Offset = "0x1D99B3C", VA = "0x1D99B3C")]
	private void FFOBGMBNOFB(JADJBFDFEHA PMGBACFJIHO, uint NMAJCLPMCDN)
	{
	}

	[Token(Token = "0x6004E93")]
	[Address(RVA = "0x1D99DF8", Offset = "0x1D99DF8", VA = "0x1D99DF8")]
	public void FAODEBEIBFP(byte NJMCMHANCHM)
	{
	}

	[Token(Token = "0x6004E94")]
	[Address(RVA = "0x1D9A05C", Offset = "0x1D9A05C", VA = "0x1D9A05C")]
	public void EIGHNNFMNIE()
	{
	}

	[Token(Token = "0x6004E95")]
	[Address(RVA = "0x1D9A1D8", Offset = "0x1D9A1D8", VA = "0x1D9A1D8")]
	public ReplayCamState ICGHCALGKDD()
	{
		return default(ReplayCamState);
	}

	[Token(Token = "0x6004E96")]
	[Address(RVA = "0x1D9A2D8", Offset = "0x1D9A2D8", VA = "0x1D9A2D8")]
	public void CNBDPHKICEP(ReplayCamState GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x6004E97")]
	[Address(RVA = "0x1D9A470", Offset = "0x1D9A470", VA = "0x1D9A470")]
	public void AANDLAGFGFN(Vector3 ACCOJJMKKPM, Vector3 JGOGIAFGCFC)
	{
	}

	[Token(Token = "0x6004E98")]
	[Address(RVA = "0x1D8E4BC", Offset = "0x1D8E4BC", VA = "0x1D8E4BC")]
	private void LMDLIAOOJJE()
	{
	}

	[Token(Token = "0x6004E99")]
	[Address(RVA = "0x1D9A5B8", Offset = "0x1D9A5B8", VA = "0x1D9A5B8")]
	public void AMHECBKJFHH(string CEGBBIBELDM)
	{
	}

	[Token(Token = "0x6004E9A")]
	[Address(RVA = "0x1D8E510", Offset = "0x1D8E510", VA = "0x1D8E510")]
	private void AIGLOMHCBBK()
	{
	}

	[Token(Token = "0x6004E9B")]
	[Address(RVA = "0x1D9A77C", Offset = "0x1D9A77C", VA = "0x1D9A77C")]
	private void LBLJLICMGKE()
	{
	}

	[Token(Token = "0x6004E9C")]
	[Address(RVA = "0x1D9CA40", Offset = "0x1D9CA40", VA = "0x1D9CA40")]
	private void KFGLPGFBAKF()
	{
	}

	[Token(Token = "0x6004E9D")]
	[Address(RVA = "0x1D9C0B4", Offset = "0x1D9C0B4", VA = "0x1D9C0B4")]
	private void DPOEKJNNJHJ()
	{
	}

	[Token(Token = "0x6004E9E")]
	[Address(RVA = "0x1D9BE1C", Offset = "0x1D9BE1C", VA = "0x1D9BE1C")]
	private void LIJDAHMDNEP()
	{
	}

	[Token(Token = "0x6004E9F")]
	[Address(RVA = "0x1D9C628", Offset = "0x1D9C628", VA = "0x1D9C628")]
	private void EFKJNLHACKO()
	{
	}

	[Token(Token = "0x6004EA0")]
	[Address(RVA = "0x1D9CC7C", Offset = "0x1D9CC7C", VA = "0x1D9CC7C")]
	private void OKKBBIDJOJC()
	{
	}

	[Token(Token = "0x6004EA1")]
	[Address(RVA = "0x1D9CC98", Offset = "0x1D9CC98", VA = "0x1D9CC98")]
	private void OFBONBPFIKK()
	{
	}

	[Token(Token = "0x6004EA2")]
	[Address(RVA = "0x1D9CF20", Offset = "0x1D9CF20", VA = "0x1D9CF20")]
	private static void OAJAGMBCNLP()
	{
	}

	[Token(Token = "0x6004EA3")]
	[Address(RVA = "0x1D9D0CC", Offset = "0x1D9D0CC", VA = "0x1D9D0CC")]
	private static void GDFCBEOOGMN()
	{
	}

	[Token(Token = "0x6004EA4")]
	[Address(RVA = "0x1D9D278", Offset = "0x1D9D278", VA = "0x1D9D278")]
	private static void EANGOFKLOHO()
	{
	}

	[Token(Token = "0x6004EA5")]
	[Address(RVA = "0x1D9D424", Offset = "0x1D9D424", VA = "0x1D9D424")]
	private static void NEMPFJECGIF()
	{
	}

	[Token(Token = "0x6004EA6")]
	[Address(RVA = "0x1D9D5CC", Offset = "0x1D9D5CC", VA = "0x1D9D5CC")]
	private static void HKBNHGOBFOL()
	{
	}

	[Token(Token = "0x6004EA7")]
	[Address(RVA = "0x1D9D83C", Offset = "0x1D9D83C", VA = "0x1D9D83C")]
	private static void CPBJLMDMHEB()
	{
	}

	[Token(Token = "0x6004EA8")]
	[Address(RVA = "0x1D9D9E8", Offset = "0x1D9D9E8", VA = "0x1D9D9E8")]
	private static void PJIDKPEKCDL()
	{
	}

	[Token(Token = "0x6004EA9")]
	[Address(RVA = "0x1D9DB94", Offset = "0x1D9DB94", VA = "0x1D9DB94")]
	private void NBAEJELCOKF()
	{
	}

	[Token(Token = "0x6004EAA")]
	[Address(RVA = "0x1D9DB9C", Offset = "0x1D9DB9C", VA = "0x1D9DB9C")]
	private static void FILALBJALGL()
	{
	}

	[Token(Token = "0x6004EAB")]
	[Address(RVA = "0x1D9DCE8", Offset = "0x1D9DCE8", VA = "0x1D9DCE8")]
	private static void DJFJHENCGJM()
	{
	}

	[Token(Token = "0x6004EAC")]
	[Address(RVA = "0x1D9DDA8", Offset = "0x1D9DDA8", VA = "0x1D9DDA8")]
	private void LNAADAJFFNK()
	{
	}

	[Token(Token = "0x6004EAD")]
	[Address(RVA = "0x1D9DDAC", Offset = "0x1D9DDAC", VA = "0x1D9DDAC")]
	private static void CJKIAOOOEIB()
	{
	}

	[Token(Token = "0x6004EAE")]
	[Address(RVA = "0x1D9DE6C", Offset = "0x1D9DE6C", VA = "0x1D9DE6C")]
	private static void AAMCHEPPFNC()
	{
	}

	[Token(Token = "0x6004EAF")]
	[Address(RVA = "0x1D9DF2C", Offset = "0x1D9DF2C", VA = "0x1D9DF2C")]
	private void JBGBLIJDIHO()
	{
	}

	[Token(Token = "0x6004EB0")]
	[Address(RVA = "0x1D9DF3C", Offset = "0x1D9DF3C", VA = "0x1D9DF3C")]
	private static void HBDFNABCJMM()
	{
	}

	[Token(Token = "0x6004EB1")]
	[Address(RVA = "0x1D9DFFC", Offset = "0x1D9DFFC", VA = "0x1D9DFFC")]
	private void BHDDKCANHME()
	{
	}

	[Token(Token = "0x6004EB2")]
	[Address(RVA = "0x1D9E284", Offset = "0x1D9E284", VA = "0x1D9E284")]
	private static void BDNJFONGICL()
	{
	}

	[Token(Token = "0x6004EB3")]
	[Address(RVA = "0x1D9E380", Offset = "0x1D9E380", VA = "0x1D9E380")]
	private static void DAJJOKIAOBF()
	{
	}

	[Token(Token = "0x6004EB4")]
	[Address(RVA = "0x1D9E440", Offset = "0x1D9E440", VA = "0x1D9E440")]
	private void NEEMHGIBGED()
	{
	}

	[Token(Token = "0x6004EB5")]
	[Address(RVA = "0x1D9E59C", Offset = "0x1D9E59C", VA = "0x1D9E59C")]
	private void BNABLAKFHHE()
	{
	}

	[Token(Token = "0x6004EB6")]
	[Address(RVA = "0x1D9E86C", Offset = "0x1D9E86C", VA = "0x1D9E86C")]
	private void OGKNMOEAMFJ()
	{
	}

	[Token(Token = "0x6004EB7")]
	[Address(RVA = "0x1D9E878", Offset = "0x1D9E878", VA = "0x1D9E878")]
	private void FNIEBHCNIKN()
	{
	}

	[Token(Token = "0x6004EB8")]
	[Address(RVA = "0x1D9E884", Offset = "0x1D9E884", VA = "0x1D9E884")]
	private void LBPDEMHAOJH()
	{
	}

	[Token(Token = "0x6004EB9")]
	[Address(RVA = "0x1D9E890", Offset = "0x1D9E890", VA = "0x1D9E890")]
	private void DFLAAJBDBHA()
	{
	}

	[Token(Token = "0x6004EBA")]
	[Address(RVA = "0x1D9E89C", Offset = "0x1D9E89C", VA = "0x1D9E89C")]
	private void OLGJAAMKMFD()
	{
	}

	[Token(Token = "0x6004EBB")]
	[Address(RVA = "0x1D9E8A0", Offset = "0x1D9E8A0", VA = "0x1D9E8A0")]
	private static void ILKPLJJMKPP()
	{
	}

	[Token(Token = "0x6004EBC")]
	[Address(RVA = "0x1D9E9EC", Offset = "0x1D9E9EC", VA = "0x1D9E9EC")]
	private static void FOLCALGHIKE()
	{
	}

	[Token(Token = "0x6004EBD")]
	[Address(RVA = "0x1D9EB38", Offset = "0x1D9EB38", VA = "0x1D9EB38")]
	private void GBJFFKELLHC()
	{
	}

	[Token(Token = "0x6004EBE")]
	[Address(RVA = "0x1D9ED18", Offset = "0x1D9ED18", VA = "0x1D9ED18")]
	private void AJIAOMJIJLJ()
	{
	}

	[Token(Token = "0x6004EBF")]
	[Address(RVA = "0x1D9EEF8", Offset = "0x1D9EEF8", VA = "0x1D9EEF8")]
	private static void GPMHMGNBHGP()
	{
	}

	[Token(Token = "0x6004EC0")]
	[Address(RVA = "0x1D9F044", Offset = "0x1D9F044", VA = "0x1D9F044")]
	private static void HKLNMLDDPIF()
	{
	}

	[Token(Token = "0x6004EC1")]
	[Address(RVA = "0x1D9F190", Offset = "0x1D9F190", VA = "0x1D9F190")]
	private static void COIHPCPPFPJ()
	{
	}

	[Token(Token = "0x6004EC2")]
	[Address(RVA = "0x1D9F2A4", Offset = "0x1D9F2A4", VA = "0x1D9F2A4")]
	private static void BBOOCBLIECL()
	{
	}

	[Token(Token = "0x6004EC3")]
	[Address(RVA = "0x1D9F3B8", Offset = "0x1D9F3B8", VA = "0x1D9F3B8")]
	private static void LOPBHDEFCFI()
	{
	}

	[Token(Token = "0x6004EC4")]
	[Address(RVA = "0x1D9F4E0", Offset = "0x1D9F4E0", VA = "0x1D9F4E0")]
	private static void KNJEFGIGEFA()
	{
	}

	[Token(Token = "0x6004EC5")]
	[Address(RVA = "0x1D9F5A0", Offset = "0x1D9F5A0", VA = "0x1D9F5A0")]
	private static void HKCCKKBNHAE()
	{
	}

	[Token(Token = "0x6004EC6")]
	[Address(RVA = "0x1D9F660", Offset = "0x1D9F660", VA = "0x1D9F660")]
	private static void LDKLIEEBLBA()
	{
	}

	[Token(Token = "0x6004EC7")]
	[Address(RVA = "0x1D9F720", Offset = "0x1D9F720", VA = "0x1D9F720")]
	private static void MHHDFJBNPOB()
	{
	}

	[Token(Token = "0x6004EC8")]
	[Address(RVA = "0x1D9F7E0", Offset = "0x1D9F7E0", VA = "0x1D9F7E0")]
	private static void LGLLLOHGANL()
	{
	}

	[Token(Token = "0x6004EC9")]
	[Address(RVA = "0x1D9F8A0", Offset = "0x1D9F8A0", VA = "0x1D9F8A0")]
	private static void JBGOPFABJGC()
	{
	}

	[Token(Token = "0x6004ECA")]
	[Address(RVA = "0x1D9F9EC", Offset = "0x1D9F9EC", VA = "0x1D9F9EC")]
	private void PLLNKHAJAJB()
	{
	}

	[Token(Token = "0x6004ECB")]
	[Address(RVA = "0x1D9F9F4", Offset = "0x1D9F9F4", VA = "0x1D9F9F4")]
	private void LLDIALGJCBC()
	{
	}

	[Token(Token = "0x6004ECC")]
	[Address(RVA = "0x1D9F9FC", Offset = "0x1D9F9FC", VA = "0x1D9F9FC")]
	private static void INFDCIIKPCN()
	{
	}

	[Token(Token = "0x6004ECD")]
	[Address(RVA = "0x1D9FBF8", Offset = "0x1D9FBF8", VA = "0x1D9FBF8")]
	private static void MFKCIILIHGB()
	{
	}

	[Token(Token = "0x6004ECE")]
	[Address(RVA = "0x1D9FDF4", Offset = "0x1D9FDF4", VA = "0x1D9FDF4")]
	private static void KJMDBCHDFJI()
	{
	}

	[Token(Token = "0x6004ECF")]
	[Address(RVA = "0x1D9FF28", Offset = "0x1D9FF28", VA = "0x1D9FF28")]
	private static void ONBEKGLDCCL()
	{
	}

	[Token(Token = "0x6004ED0")]
	[Address(RVA = "0x1DA005C", Offset = "0x1DA005C", VA = "0x1DA005C")]
	private static void LIALGKEJAEG()
	{
	}

	[Token(Token = "0x6004ED1")]
	[Address(RVA = "0x1DA011C", Offset = "0x1DA011C", VA = "0x1DA011C")]
	private static void JAEEAEDDFFB()
	{
	}

	[Token(Token = "0x6004ED2")]
	[Address(RVA = "0x1DA01DC", Offset = "0x1DA01DC", VA = "0x1DA01DC")]
	private static void HIELBJMCEMN()
	{
	}

	[Token(Token = "0x6004ED3")]
	[Address(RVA = "0x1DA029C", Offset = "0x1DA029C", VA = "0x1DA029C")]
	private static void CLAAJEIEKDA()
	{
	}
}
