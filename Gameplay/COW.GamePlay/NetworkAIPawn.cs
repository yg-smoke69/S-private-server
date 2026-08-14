using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000921")]
internal class NetworkAIPawn : AttackableEntity
{
	[Token(Token = "0x2000922")]
	protected class HHCBNAPCKHF : ShadowStateBase
	{
		[Token(Token = "0x4005526")]
		[FieldOffset(Offset = "0x10")]
		public PKCEFACBDMP LANMPIGGDAG;

		[Token(Token = "0x4005527")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 JHJLNLCEGOG;

		[Token(Token = "0x4005528")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 PGDEDHFOMCN;

		[Token(Token = "0x4005529")]
		[FieldOffset(Offset = "0x2C")]
		public Quaternion FBMPKHMBHAM;

		[Token(Token = "0x400552A")]
		[FieldOffset(Offset = "0x3C")]
		public Quaternion BPLOAFBIHJL;

		[Token(Token = "0x600402D")]
		[Address(RVA = "0x17DCB28", Offset = "0x17DCB28", VA = "0x17DCB28")]
		public HHCBNAPCKHF()
		{
		}
	}

	[Token(Token = "0x2000923")]
	public class FNJENLEJEKP
	{
		[Token(Token = "0x400552B")]
		[FieldOffset(Offset = "0x8")]
		private NHLIONMIJCI DFBBCAOLHHO;

		[Token(Token = "0x400552C")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<uint, NHLIONMIJCI> BMGHEACDJIG;

		[Token(Token = "0x400552D")]
		[FieldOffset(Offset = "0x10")]
		private NetworkAIPawn _003CBBHBMCKIJJO_003Ek__BackingField;

		[Token(Token = "0x1700044E")]
		public NetworkAIPawn JGHEGHHINPA
		{
			[Token(Token = "0x600402F")]
			[Address(RVA = "0x17E875C", Offset = "0x17E875C", VA = "0x17E875C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004030")]
			[Address(RVA = "0x17E8684", Offset = "0x17E8684", VA = "0x17E8684")]
			private set
			{
			}
		}

		[Token(Token = "0x600402E")]
		[Address(RVA = "0x17DEFC0", Offset = "0x17DEFC0", VA = "0x17DEFC0")]
		public FNJENLEJEKP(NetworkAIPawn FIMNKGABILM)
		{
		}

		[Token(Token = "0x6004031")]
		[Address(RVA = "0x17E3F8C", Offset = "0x17E3F8C", VA = "0x17E3F8C")]
		public bool FEIPODFIEHJ(PKCEFACBDMP GJKCKDIDMPL)
		{
			return default(bool);
		}

		[Token(Token = "0x6004032")]
		[Address(RVA = "0x17E2480", Offset = "0x17E2480", VA = "0x17E2480")]
		public void CCPBEHHPDBC(PKCEFACBDMP AEHJPACEKOJ)
		{
		}
	}

	[Token(Token = "0x2000924")]
	public class NHLIONMIJCI
	{
		[Token(Token = "0x400552E")]
		[FieldOffset(Offset = "0x8")]
		private FNJENLEJEKP _003CDLDBIOHNIAM_003Ek__BackingField;

		[Token(Token = "0x400552F")]
		[FieldOffset(Offset = "0xC")]
		private PKCEFACBDMP _003CELILDKGPEJC_003Ek__BackingField;

		[Token(Token = "0x1700044F")]
		protected FNJENLEJEKP CIDDGOMIFDL
		{
			[Token(Token = "0x6004034")]
			[Address(RVA = "0x17E87EC", Offset = "0x17E87EC", VA = "0x17E87EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004035")]
			[Address(RVA = "0x17E87DC", Offset = "0x17E87DC", VA = "0x17E87DC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000450")]
		protected NetworkAIPawn JGHEGHHINPA
		{
			[Token(Token = "0x6004036")]
			[Address(RVA = "0x17E87F4", Offset = "0x17E87F4", VA = "0x17E87F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000451")]
		public PKCEFACBDMP GHGCGGOLKIP
		{
			[Token(Token = "0x6004037")]
			[Address(RVA = "0x17E86B4", Offset = "0x17E86B4", VA = "0x17E86B4")]
			get
			{
				return default(PKCEFACBDMP);
			}
			[Token(Token = "0x6004038")]
			[Address(RVA = "0x17E87E4", Offset = "0x17E87E4", VA = "0x17E87E4")]
			private set
			{
			}
		}

		[Token(Token = "0x6004033")]
		[Address(RVA = "0x17E868C", Offset = "0x17E868C", VA = "0x17E868C")]
		public NHLIONMIJCI(FNJENLEJEKP GCMJDPIGBOL, PKCEFACBDMP GLDLCOBLGNF)
		{
		}

		[Token(Token = "0x6004039")]
		[Address(RVA = "0x17E86E4", Offset = "0x17E86E4", VA = "0x17E86E4")]
		public void DDOMLJNAFEC(PKCEFACBDMP DLECPMBKMKM)
		{
		}

		[Token(Token = "0x600403A")]
		[Address(RVA = "0x17E8764", Offset = "0x17E8764", VA = "0x17E8764")]
		public void EPLOCAGDCOI(PKCEFACBDMP JEHELPNHACP)
		{
		}

		[Token(Token = "0x600403B")]
		[Address(RVA = "0x17E8864", Offset = "0x17E8864", VA = "0x17E8864", Slot = "4")]
		protected virtual void JMGKNDCPCOC(PKCEFACBDMP JEHELPNHACP)
		{
		}

		[Token(Token = "0x600403C")]
		[Address(RVA = "0x17E88C0", Offset = "0x17E88C0", VA = "0x17E88C0", Slot = "5")]
		protected virtual void LAFFLOMGJDH(PKCEFACBDMP DLECPMBKMKM)
		{
		}
	}

	[Token(Token = "0x2000925")]
	private class PGOIMNLJAKL : NHLIONMIJCI
	{
		[Token(Token = "0x600403D")]
		[Address(RVA = "0x17E86BC", Offset = "0x17E86BC", VA = "0x17E86BC")]
		public PGOIMNLJAKL(FNJENLEJEKP GCMJDPIGBOL)
		{
		}

		[Token(Token = "0x600403E")]
		[Address(RVA = "0x17E891C", Offset = "0x17E891C", VA = "0x17E891C", Slot = "5")]
		protected override void LAFFLOMGJDH(PKCEFACBDMP DLECPMBKMKM)
		{
		}

		[Token(Token = "0x600403F")]
		[Address(RVA = "0x17E89A0", Offset = "0x17E89A0", VA = "0x17E89A0", Slot = "4")]
		protected override void JMGKNDCPCOC(PKCEFACBDMP JEHELPNHACP)
		{
		}

		[Token(Token = "0x6004040")]
		[Address(RVA = "0x17E8A24", Offset = "0x17E8A24", VA = "0x17E8A24")]
		public void _003C_003EiFixBaseProxy_LAFFLOMGJDH(PKCEFACBDMP P0)
		{
		}

		[Token(Token = "0x6004041")]
		[Address(RVA = "0x17E8A28", Offset = "0x17E8A28", VA = "0x17E8A28")]
		public void _003C_003EiFixBaseProxy_JMGKNDCPCOC(PKCEFACBDMP P0)
		{
		}
	}

	[Token(Token = "0x2000926")]
	private sealed class COFNPDCEBDI : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005530")]
		[FieldOffset(Offset = "0x8")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x4005531")]
		[FieldOffset(Offset = "0xC")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x4005532")]
		[FieldOffset(Offset = "0x10")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x17000452")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6004044")]
			[Address(RVA = "0x17E85D8", Offset = "0x17E85D8", VA = "0x17E85D8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000453")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004045")]
			[Address(RVA = "0x17E85E0", Offset = "0x17E85E0", VA = "0x17E85E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004042")]
		[Address(RVA = "0x17E80B0", Offset = "0x17E80B0", VA = "0x17E80B0")]
		public COFNPDCEBDI()
		{
		}

		[Token(Token = "0x6004043")]
		[Address(RVA = "0x17E849C", Offset = "0x17E849C", VA = "0x17E849C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004046")]
		[Address(RVA = "0x17E85E8", Offset = "0x17E85E8", VA = "0x17E85E8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6004047")]
		[Address(RVA = "0x17E85FC", Offset = "0x17E85FC", VA = "0x17E85FC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40054F0")]
	[FieldOffset(Offset = "0x48")]
	private bool HAMDJNICDJF;

	[Token(Token = "0x40054F1")]
	[FieldOffset(Offset = "0x49")]
	private bool KMLMOFKBAGI;

	[Token(Token = "0x40054F2")]
	[FieldOffset(Offset = "0x4C")]
	protected Vector3 PKPDDMLAJHG;

	[Token(Token = "0x40054F3")]
	[FieldOffset(Offset = "0x58")]
	protected float DIIGKNMNKDJ;

	[Token(Token = "0x40054F4")]
	[FieldOffset(Offset = "0x60")]
	protected IHAAMHPPLMG KFMGKCJMCAM;

	[Token(Token = "0x40054F5")]
	[FieldOffset(Offset = "0x78")]
	private int _003CNICENMJCIPK_003Ek__BackingField;

	[Token(Token = "0x40054F6")]
	[FieldOffset(Offset = "0x7C")]
	protected int PHCKPPDFCAM;

	[Token(Token = "0x40054F7")]
	[FieldOffset(Offset = "0x80")]
	private bool _003CIHFLPFPMKKA_003Ek__BackingField;

	[Token(Token = "0x40054F8")]
	[FieldOffset(Offset = "0x84")]
	protected string OIAJCBLDHKP;

	[Token(Token = "0x40054F9")]
	[FieldOffset(Offset = "0x88")]
	protected ITransformNode ENABGKNIDKB;

	[Token(Token = "0x40054FA")]
	[FieldOffset(Offset = "0x8C")]
	protected ITransformNode KMEPOHFOGII;

	[Token(Token = "0x40054FB")]
	[FieldOffset(Offset = "0x90")]
	protected NetworkAIPawnAnimBaseComponent EDCEFDKNGFJ;

	[Token(Token = "0x40054FC")]
	[FieldOffset(Offset = "0x94")]
	protected BoxCollider JHOEKMMAJLC;

	[Token(Token = "0x40054FD")]
	[FieldOffset(Offset = "0x98")]
	protected AIPawnBodyMaterialComponent MPCKMHAJMLK;

	[Token(Token = "0x40054FE")]
	[FieldOffset(Offset = "0x0")]
	public static float DEFAULT_BODY_RADIUS;

	[Token(Token = "0x40054FF")]
	[FieldOffset(Offset = "0x9C")]
	protected CapsuleCollider LEODPJIJFJG;

	[Token(Token = "0x4005500")]
	[FieldOffset(Offset = "0xA0")]
	protected FNJENLEJEKP BONOMLGGGPA;

	[Token(Token = "0x4005501")]
	[FieldOffset(Offset = "0xA4")]
	protected KBALOLBEIKO PNINHGOGPBI;

	[Token(Token = "0x4005502")]
	[FieldOffset(Offset = "0xDC")]
	protected MPLOBNECDLC GHILIPBFHAB;

	[Token(Token = "0x4005503")]
	[FieldOffset(Offset = "0xE8")]
	protected uint NIMGGDLPIMH;

	[Token(Token = "0x4005504")]
	[FieldOffset(Offset = "0xEC")]
	protected NMJJKCJFFMC HKGDLLJGNCA;

	[Token(Token = "0x4005505")]
	[FieldOffset(Offset = "0xFC")]
	protected uint OKEHGJGNHHO;

	[Token(Token = "0x4005506")]
	[FieldOffset(Offset = "0x100")]
	protected OKPLNAODBJB KMMJEHIKNKN;

	[Token(Token = "0x4005507")]
	[FieldOffset(Offset = "0x104")]
	protected IMCIPPJDGNF CEJEGLCCNAH;

	[Token(Token = "0x4005508")]
	[FieldOffset(Offset = "0x108")]
	protected Dictionary<int, FNCCPHBIMFO> DBNEFECFIDK;

	[Token(Token = "0x4005509")]
	[FieldOffset(Offset = "0x10C")]
	protected bool CNMNJFCFPPO;

	[Token(Token = "0x400550A")]
	[FieldOffset(Offset = "0x110")]
	protected uint KINJCKMOGIM;

	[Token(Token = "0x400550B")]
	[FieldOffset(Offset = "0x114")]
	protected HHCBNAPCKHF PLGAAJABBHA;

	[Token(Token = "0x400550C")]
	[FieldOffset(Offset = "0x118")]
	protected float IIAOCJKJIGM;

	[Token(Token = "0x400550D")]
	[FieldOffset(Offset = "0x11C")]
	protected bool DPKFABDPFKA;

	[Token(Token = "0x400550E")]
	[FieldOffset(Offset = "0x11D")]
	private bool _003CBGOBBMJENJD_003Ek__BackingField;

	[Token(Token = "0x400550F")]
	[FieldOffset(Offset = "0x11E")]
	private bool _003CKICPPMKBBIB_003Ek__BackingField;

	[Token(Token = "0x4005510")]
	[FieldOffset(Offset = "0x120")]
	private uint JJPLCJCCDKC;

	[Token(Token = "0x4005511")]
	[FieldOffset(Offset = "0x124")]
	public JEGKCNDOPIH m_zombieSyncEvent;

	[Token(Token = "0x4005512")]
	[FieldOffset(Offset = "0x128")]
	private float _003CJBNFJNONOMG_003Ek__BackingField;

	[Token(Token = "0x4005513")]
	[FieldOffset(Offset = "0x12C")]
	private bool _003COECGPLKIFNG_003Ek__BackingField;

	[Token(Token = "0x4005514")]
	[FieldOffset(Offset = "0x12D")]
	private bool _003CDOLBJNMDICM_003Ek__BackingField;

	[Token(Token = "0x4005515")]
	[FieldOffset(Offset = "0x12E")]
	private bool _003CEGAFHBACHEM_003Ek__BackingField;

	[Token(Token = "0x4005516")]
	[FieldOffset(Offset = "0x12F")]
	public bool m_IsSkillGod;

	[Token(Token = "0x4005517")]
	[FieldOffset(Offset = "0x130")]
	private int OPJBJNNCCEP;

	[Token(Token = "0x4005518")]
	[FieldOffset(Offset = "0x134")]
	protected Dictionary<byte, Vector2> KIIIEKFJCBL;

	[Token(Token = "0x4005519")]
	[FieldOffset(Offset = "0x138")]
	private GhostShadowEffectPlayer GBGDBPOEEEF;

	[Token(Token = "0x400551A")]
	[FieldOffset(Offset = "0x13C")]
	private int BLNPLOKOCLE;

	[Token(Token = "0x400551B")]
	[FieldOffset(Offset = "0x140")]
	protected Transform PJBOFJPMCJB;

	[Token(Token = "0x400551C")]
	[FieldOffset(Offset = "0x144")]
	public bool IsNeedFixPostion;

	[Token(Token = "0x400551D")]
	[FieldOffset(Offset = "0x148")]
	protected float IGPLFMJMDGB;

	[Token(Token = "0x400551E")]
	[FieldOffset(Offset = "0x14C")]
	protected Vector3 LIDAEDNKINL;

	[Token(Token = "0x400551F")]
	[FieldOffset(Offset = "0x158")]
	protected float HJCONEAIFLJ;

	[Token(Token = "0x4005520")]
	[FieldOffset(Offset = "0x15C")]
	protected bool KGGDBOCFBMA;

	[Token(Token = "0x4005521")]
	[FieldOffset(Offset = "0x160")]
	private GameObject KLOILEEAKDB;

	[Token(Token = "0x4005522")]
	[FieldOffset(Offset = "0x164")]
	private Collider[] KJHGPCPDHPC;

	[Token(Token = "0x4005523")]
	[FieldOffset(Offset = "0x168")]
	protected bool HJNLAGFDKJK;

	[Token(Token = "0x4005524")]
	[FieldOffset(Offset = "0x16C")]
	private List<ReusableObject> HKLNKHBNAOG;

	[Token(Token = "0x4005525")]
	[FieldOffset(Offset = "0x170")]
	private Coroutine LNKLPANNGIJ;

	[Token(Token = "0x17000436")]
	public Vector3 IGGJFNHOBEF
	{
		[Token(Token = "0x6003FA9")]
		[Address(RVA = "0x17DD760", Offset = "0x17DD760", VA = "0x17DD760")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000437")]
	public IHAAMHPPLMG IHAAMHPPLMG
	{
		[Token(Token = "0x6003FAB")]
		[Address(RVA = "0x17DD91C", Offset = "0x17DD91C", VA = "0x17DD91C")]
		get
		{
			return default(IHAAMHPPLMG);
		}
		[Token(Token = "0x6003FAC")]
		[Address(RVA = "0x17DD990", Offset = "0x17DD990", VA = "0x17DD990")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000438")]
	public int CPDNBJNLAIM
	{
		[Token(Token = "0x6003FAD")]
		[Address(RVA = "0x17DDA3C", Offset = "0x17DDA3C", VA = "0x17DDA3C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003FAE")]
		[Address(RVA = "0x17DDA44", Offset = "0x17DDA44", VA = "0x17DDA44")]
		set
		{
		}
	}

	[Token(Token = "0x17000439")]
	public int HJGLEJOBDCO
	{
		[Token(Token = "0x6003FAF")]
		[Address(RVA = "0x17DCBB8", Offset = "0x17DCBB8", VA = "0x17DCBB8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003FB0")]
		[Address(RVA = "0x17DDA4C", Offset = "0x17DDA4C", VA = "0x17DDA4C")]
		set
		{
		}
	}

	[Token(Token = "0x1700043A")]
	public bool PADOJJDCGIG
	{
		[Token(Token = "0x6003FB1")]
		[Address(RVA = "0x17DD380", Offset = "0x17DD380", VA = "0x17DD380")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003FB2")]
		[Address(RVA = "0x17DDAAC", Offset = "0x17DDAAC", VA = "0x17DDAAC")]
		set
		{
		}
	}

	[Token(Token = "0x1700043B")]
	public string GCJBNAHBGMD
	{
		[Token(Token = "0x6003FB3")]
		[Address(RVA = "0x17DDAB4", Offset = "0x17DDAB4", VA = "0x17DDAB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003FB4")]
		[Address(RVA = "0x17DDB0C", Offset = "0x17DDB0C", VA = "0x17DDB0C")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700043C")]
	public NetworkAIPawnAnimBaseComponent IEFIHNDNGNI
	{
		[Token(Token = "0x6003FB5")]
		[Address(RVA = "0x17DDB6C", Offset = "0x17DDB6C", VA = "0x17DDB6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700043D")]
	public AIPawnBodyMaterialComponent JFGHCNKBBBG
	{
		[Token(Token = "0x6003FB6")]
		[Address(RVA = "0x17DDBC4", Offset = "0x17DDBC4", VA = "0x17DDBC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700043E")]
	public Transform JIMLGADEEEB
	{
		[Token(Token = "0x6003FB7")]
		[Address(RVA = "0x17DDC1C", Offset = "0x17DDC1C", VA = "0x17DDC1C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700043F")]
	public Transform ECBHDOHKAJK
	{
		[Token(Token = "0x6003FB8")]
		[Address(RVA = "0x17DDD3C", Offset = "0x17DDD3C", VA = "0x17DDD3C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000440")]
	public float EIEPENPKFCM
	{
		[Token(Token = "0x6003FBA")]
		[Address(RVA = "0x17DDEC0", Offset = "0x17DDEC0", VA = "0x17DDEC0")]
		protected get
		{
			return default(float);
		}
		[Token(Token = "0x6003FB9")]
		[Address(RVA = "0x17DDE5C", Offset = "0x17DDE5C", VA = "0x17DDE5C")]
		set
		{
		}
	}

	[Token(Token = "0x17000441")]
	public bool COMDBIBNDAB
	{
		[Token(Token = "0x6003FBC")]
		[Address(RVA = "0x17DDFAC", Offset = "0x17DDFAC", VA = "0x17DDFAC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003FBD")]
		[Address(RVA = "0x17DDFB4", Offset = "0x17DDFB4", VA = "0x17DDFB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000442")]
	public bool OIANDOLOBDK
	{
		[Token(Token = "0x6003FBE")]
		[Address(RVA = "0x17DDFBC", Offset = "0x17DDFBC", VA = "0x17DDFBC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003FBF")]
		[Address(RVA = "0x17DDFC4", Offset = "0x17DDFC4", VA = "0x17DDFC4")]
		set
		{
		}
	}

	[Token(Token = "0x17000443")]
	public uint FOHKJCMLMBM
	{
		[Token(Token = "0x6003FC0")]
		[Address(RVA = "0x17DDFCC", Offset = "0x17DDFCC", VA = "0x17DDFCC")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000444")]
	public virtual int IDFPGCICMML
	{
		[Token(Token = "0x6003FC1")]
		[Address(RVA = "0x17DE024", Offset = "0x17DE024", VA = "0x17DE024", Slot = "63")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003FC2")]
		[Address(RVA = "0x17DE07C", Offset = "0x17DE07C", VA = "0x17DE07C", Slot = "64")]
		set
		{
		}
	}

	[Token(Token = "0x17000445")]
	public virtual KPCKLGPOAOD PLANCPOJMBI
	{
		[Token(Token = "0x6003FC3")]
		[Address(RVA = "0x17DE0D8", Offset = "0x17DE0D8", VA = "0x17DE0D8", Slot = "65")]
		get
		{
			return default(KPCKLGPOAOD);
		}
		[Token(Token = "0x6003FC4")]
		[Address(RVA = "0x17DE130", Offset = "0x17DE130", VA = "0x17DE130", Slot = "66")]
		set
		{
		}
	}

	[Token(Token = "0x17000446")]
	public float AFMMCJIBDJE
	{
		[Token(Token = "0x6003FC5")]
		[Address(RVA = "0x17DE18C", Offset = "0x17DE18C", VA = "0x17DE18C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6003FC6")]
		[Address(RVA = "0x17DE194", Offset = "0x17DE194", VA = "0x17DE194")]
		set
		{
		}
	}

	[Token(Token = "0x17000447")]
	public bool BAAFOBHBHNP
	{
		[Token(Token = "0x6003FC7")]
		[Address(RVA = "0x17DE19C", Offset = "0x17DE19C", VA = "0x17DE19C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003FC8")]
		[Address(RVA = "0x17DE1A4", Offset = "0x17DE1A4", VA = "0x17DE1A4")]
		set
		{
		}
	}

	[Token(Token = "0x17000448")]
	public bool PEJFDKBOAEJ
	{
		[Token(Token = "0x6003FC9")]
		[Address(RVA = "0x17DE1AC", Offset = "0x17DE1AC", VA = "0x17DE1AC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003FCA")]
		[Address(RVA = "0x17DE1B4", Offset = "0x17DE1B4", VA = "0x17DE1B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000449")]
	public bool JLMIGGDIJNP
	{
		[Token(Token = "0x6003FCB")]
		[Address(RVA = "0x17DE1BC", Offset = "0x17DE1BC", VA = "0x17DE1BC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003FCC")]
		[Address(RVA = "0x17DE1C4", Offset = "0x17DE1C4", VA = "0x17DE1C4")]
		set
		{
		}
	}

	[Token(Token = "0x1700044A")]
	public bool DODEOINIHPI
	{
		[Token(Token = "0x6003FCD")]
		[Address(RVA = "0x17DE1CC", Offset = "0x17DE1CC", VA = "0x17DE1CC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003FCE")]
		[Address(RVA = "0x17DE224", Offset = "0x17DE224", VA = "0x17DE224")]
		set
		{
		}
	}

	[Token(Token = "0x1700044B")]
	public int BEPLMEHHAGN
	{
		[Token(Token = "0x6003FCF")]
		[Address(RVA = "0x17DE4B0", Offset = "0x17DE4B0", VA = "0x17DE4B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700044C")]
	public int HBDEOCIOMEJ
	{
		[Token(Token = "0x6003FD0")]
		[Address(RVA = "0x17DE508", Offset = "0x17DE508", VA = "0x17DE508")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700044D")]
	public Vector3 LMNBBBCKMGB
	{
		[Token(Token = "0x6003FDF")]
		[Address(RVA = "0x17DFF9C", Offset = "0x17DFF9C", VA = "0x17DFF9C")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x6003FE0")]
		[Address(RVA = "0x17E000C", Offset = "0x17E000C", VA = "0x17E000C")]
		set
		{
		}
	}

	[Token(Token = "0x6003FA1")]
	[Address(RVA = "0x17DBB1C", Offset = "0x17DBB1C", VA = "0x17DBB1C")]
	public NetworkAIPawn()
	{
	}

	[Token(Token = "0x6003FA2")]
	[Address(RVA = "0x17DCB30", Offset = "0x17DCB30", VA = "0x17DCB30", Slot = "10")]
	public override void InitEntityInfo()
	{
	}

	[Token(Token = "0x6003FA3")]
	[Address(RVA = "0x17DCC10", Offset = "0x17DCC10", VA = "0x17DCC10", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6003FA4")]
	[Address(RVA = "0x17DCC68", Offset = "0x17DCC68", VA = "0x17DCC68", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6003FA5")]
	[Address(RVA = "0x17DD0A4", Offset = "0x17DD0A4", VA = "0x17DD0A4", Slot = "61")]
	protected virtual void MNKMALKKPEA(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6003FA6")]
	[Address(RVA = "0x17DD388", Offset = "0x17DD388", VA = "0x17DD388", Slot = "62")]
	protected virtual void MINFFBODCOL(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6003FA7")]
	[Address(RVA = "0x17DD5C0", Offset = "0x17DD5C0", VA = "0x17DD5C0", Slot = "48")]
	public override Vector3 GetAttackableCenterWS()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6003FA8")]
	[Address(RVA = "0x17DD708", Offset = "0x17DD708", VA = "0x17DD708", Slot = "49")]
	public override float GetAttackableRadius()
	{
		return default(float);
	}

	[Token(Token = "0x6003FAA")]
	[Address(RVA = "0x17DD8B0", Offset = "0x17DD8B0", VA = "0x17DD8B0", Slot = "50")]
	public override Vector3 GetHitDamagePos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6003FBB")]
	[Address(RVA = "0x17DDF18", Offset = "0x17DDF18", VA = "0x17DDF18")]
	protected bool AFDMGPFCBIO()
	{
		return default(bool);
	}

	[Token(Token = "0x6003FD1")]
	[Address(RVA = "0x17DE560", Offset = "0x17DE560", VA = "0x17DE560", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6003FD2")]
	[Address(RVA = "0x17DCA84", Offset = "0x17DCA84", VA = "0x17DCA84", Slot = "67")]
	public virtual void CreateInit(Transform GOLANILPAJP, EBNJADFGCFA KEJFOBBEAJO)
	{
	}

	[Token(Token = "0x6003FD3")]
	[Address(RVA = "0x17DC268", Offset = "0x17DC268", VA = "0x17DC268", Slot = "68")]
	public virtual void ReuseInit(Transform GOLANILPAJP, EBNJADFGCFA KEJFOBBEAJO)
	{
	}

	[Token(Token = "0x6003FD4")]
	[Address(RVA = "0x17DBDD4", Offset = "0x17DBDD4", VA = "0x17DBDD4")]
	protected void JDBCAHJKPEP(EBNJADFGCFA KEJFOBBEAJO)
	{
	}

	[Token(Token = "0x6003FD5")]
	[Address(RVA = "0x17DF1BC", Offset = "0x17DF1BC", VA = "0x17DF1BC", Slot = "69")]
	protected virtual void KMJODBHMEGM()
	{
	}

	[Token(Token = "0x6003FD6")]
	[Address(RVA = "0x17DF8C0", Offset = "0x17DF8C0", VA = "0x17DF8C0", Slot = "70")]
	protected virtual void BMINBBBIGIF(Transform GDOGIGDHJJO)
	{
	}

	[Token(Token = "0x6003FD7")]
	[Address(RVA = "0x17DFAB4", Offset = "0x17DFAB4", VA = "0x17DFAB4")]
	protected void MCFHJKPCKHC(NetworkAIPawnAnimComponent ECLFHHCHMPN)
	{
	}

	[Token(Token = "0x6003FD8")]
	[Address(RVA = "0x17DED94", Offset = "0x17DED94", VA = "0x17DED94")]
	protected void LLIPGNOGKPP()
	{
	}

	[Token(Token = "0x6003FD9")]
	[Address(RVA = "0x17DEA48", Offset = "0x17DEA48", VA = "0x17DEA48")]
	protected void FFGCPCDHAAM(List<ACDBEEAJLDL> PKAHCEKFHIA)
	{
	}

	[Token(Token = "0x6003FDA")]
	[Address(RVA = "0x17DFDFC", Offset = "0x17DFDFC", VA = "0x17DFDFC")]
	protected float CCFMDOCMPNG(GPBDEDFKJNA.ENBHOKKHLPG PMGBACFJIHO)
	{
		return default(float);
	}

	[Token(Token = "0x6003FDB")]
	[Address(RVA = "0x17DFC04", Offset = "0x17DFC04", VA = "0x17DFC04")]
	private float PGHCEEOJFFK()
	{
		return default(float);
	}

	[Token(Token = "0x6003FDC")]
	[Address(RVA = "0x17DE940", Offset = "0x17DE940", VA = "0x17DE940")]
	public void SetCollisionEnable(bool ELOELMEPFCN)
	{
	}

	[Token(Token = "0x6003FDD")]
	[Address(RVA = "0x17DE5CC", Offset = "0x17DE5CC", VA = "0x17DE5CC")]
	protected void LGBDFGHKIBJ()
	{
	}

	[Token(Token = "0x6003FDE")]
	[Address(RVA = "0x17DFF38", Offset = "0x17DFF38", VA = "0x17DFF38")]
	public GameObject GetGameObject()
	{
		return null;
	}

	[Token(Token = "0x6003FE1")]
	[Address(RVA = "0x17E0094", Offset = "0x17E0094", VA = "0x17E0094")]
	public void SyncAIMove(ENLFMIDMHGP KMIPBIGPDPI)
	{
	}

	[Token(Token = "0x6003FE2")]
	[Address(RVA = "0x17E0608", Offset = "0x17E0608", VA = "0x17E0608")]
	public void SyncAISkillData(BLADJJHNHNI KMIPBIGPDPI)
	{
	}

	[Token(Token = "0x6003FE3")]
	[Address(RVA = "0x17E0C6C", Offset = "0x17E0C6C", VA = "0x17E0C6C")]
	public void Explode()
	{
	}

	[Token(Token = "0x6003FE4")]
	[Address(RVA = "0x17E0CC0", Offset = "0x17E0CC0", VA = "0x17E0CC0")]
	public void Dead(int HEONOMOEOLN, IHAAMHPPLMG HLJDHPGGODB, bool KCHNLMEEHOP = false)
	{
	}

	[Token(Token = "0x6003FE5")]
	[Address(RVA = "0x17E1FB0", Offset = "0x17E1FB0", VA = "0x17E1FB0")]
	public void OnRecyle()
	{
	}

	[Token(Token = "0x6003FE6")]
	[Address(RVA = "0x17E2364", Offset = "0x17E2364", VA = "0x17E2364", Slot = "29")]
	protected override void UnRegisterEntity()
	{
	}

	[Token(Token = "0x6003FE7")]
	[Address(RVA = "0x17E23D0", Offset = "0x17E23D0", VA = "0x17E23D0", Slot = "71")]
	public virtual void UpdateBehavior(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6003FE8")]
	[Address(RVA = "0x17E266C", Offset = "0x17E266C", VA = "0x17E266C", Slot = "72")]
	public virtual void UpdateKinematics(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6003FE9")]
	[Address(RVA = "0x17E2728", Offset = "0x17E2728", VA = "0x17E2728", Slot = "73")]
	public virtual void PostUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6003FEA")]
	[Address(RVA = "0x17E28B4", Offset = "0x17E28B4", VA = "0x17E28B4", Slot = "74")]
	public virtual void PlayWalkSound()
	{
	}

	[Token(Token = "0x6003FEB")]
	[Address(RVA = "0x17E2A08", Offset = "0x17E2A08", VA = "0x17E2A08")]
	private bool LGMNOAKGCFE()
	{
		return default(bool);
	}

	[Token(Token = "0x6003FEC")]
	[Address(RVA = "0x17E2860", Offset = "0x17E2860", VA = "0x17E2860")]
	private void OPJOGGDOOIE()
	{
	}

	[Token(Token = "0x6003FED")]
	[Address(RVA = "0x17E2BD4", Offset = "0x17E2BD4", VA = "0x17E2BD4")]
	public Vector3 FixPosition(Vector3 ACCOJJMKKPM)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6003FEE")]
	[Address(RVA = "0x17E3104", Offset = "0x17E3104", VA = "0x17E3104")]
	private bool MFMNANOAFPH()
	{
		return default(bool);
	}

	[Token(Token = "0x6003FEF")]
	[Address(RVA = "0x17E315C", Offset = "0x17E315C", VA = "0x17E315C", Slot = "75")]
	public virtual void OnSkillPhaseEnter(GDEHAFJBPGE KPIAGKHAPOP, OPKPPFDNCMC GEPIPPKAIBK, float GGMFDABGEKN, float NCGNOHEHDML, bool ICLFBLKGENK)
	{
	}

	[Token(Token = "0x6003FF0")]
	[Address(RVA = "0x17E323C", Offset = "0x17E323C", VA = "0x17E323C", Slot = "76")]
	public virtual void OnSkillPhaseExit(GDEHAFJBPGE KPIAGKHAPOP, OPKPPFDNCMC GEPIPPKAIBK)
	{
	}

	[Token(Token = "0x6003FF1")]
	[Address(RVA = "0x17E32AC", Offset = "0x17E32AC", VA = "0x17E32AC")]
	public void UpdateSkillAnim(OPKPPFDNCMC GEPIPPKAIBK, GDEHAFJBPGE KPIAGKHAPOP, int HBGPBPOMLDG, float MIEOJFFIIHH)
	{
	}

	[Token(Token = "0x6003FF2")]
	[Address(RVA = "0x17E3374", Offset = "0x17E3374", VA = "0x17E3374", Slot = "77")]
	protected virtual bool JBKMLPGGNAM(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
		return default(bool);
	}

	[Token(Token = "0x6003FF3")]
	[Address(RVA = "0x17E3440", Offset = "0x17E3440", VA = "0x17E3440", Slot = "78")]
	protected virtual bool FLLIOKPHEMH()
	{
		return default(bool);
	}

	[Token(Token = "0x6003FF4")]
	[Address(RVA = "0x17E3568", Offset = "0x17E3568", VA = "0x17E3568", Slot = "79")]
	protected virtual void AIJNEIIGPIA(float OPKNJGBDOBB, float OMAFEKBHOAA, bool OPPLEJLPHAM)
	{
	}

	[Token(Token = "0x6003FF5")]
	[Address(RVA = "0x17E4010", Offset = "0x17E4010", VA = "0x17E4010")]
	private void PJAJMIDFJIA()
	{
	}

	[Token(Token = "0x6003FF6")]
	[Address(RVA = "0x17E40D8", Offset = "0x17E40D8", VA = "0x17E40D8", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x6003FF7")]
	[Address(RVA = "0x17E42F4", Offset = "0x17E42F4", VA = "0x17E42F4", Slot = "80")]
	public virtual void TakeDamage(int KOCMLPLOILD, IHAAMHPPLMG HLJDHPGGODB, DBNMCJLEFJI JPLHIDNDING = DBNMCJLEFJI.None, int BOEIBGAABDL = -1, [Optional] Vector3 NJMFBKNHMBP, [Optional] Vector3 DOBOBMFMKBJ, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x6003FF8")]
	[Address(RVA = "0x17E51B4", Offset = "0x17E51B4", VA = "0x17E51B4")]
	public bool IsAnimationPlaying(int MBKHHEHLHEF, string HINJBPEDIAL)
	{
		return default(bool);
	}

	[Token(Token = "0x6003FF9")]
	[Address(RVA = "0x17E5230", Offset = "0x17E5230", VA = "0x17E5230", Slot = "81")]
	public virtual Vector3 GetHeadPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6003FFA")]
	[Address(RVA = "0x17E5464", Offset = "0x17E5464", VA = "0x17E5464", Slot = "82")]
	public virtual Vector3 GetHipPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6003FFB")]
	[Address(RVA = "0x17E5698", Offset = "0x17E5698", VA = "0x17E5698")]
	public void PushAISyncedStateData(object ANBEGGDFLBM, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x6003FFC")]
	[Address(RVA = "0x17E5A74", Offset = "0x17E5A74", VA = "0x17E5A74")]
	public void StartHitfly()
	{
	}

	[Token(Token = "0x6003FFD")]
	[Address(RVA = "0x17E5C98", Offset = "0x17E5C98", VA = "0x17E5C98")]
	public void StopHitfly()
	{
	}

	[Token(Token = "0x6003FFE")]
	[Address(RVA = "0x17E5D38", Offset = "0x17E5D38", VA = "0x17E5D38", Slot = "83")]
	protected virtual bool ACNHIBFHJNP()
	{
		return default(bool);
	}

	[Token(Token = "0x6003FFF")]
	[Address(RVA = "0x17DE754", Offset = "0x17DE754", VA = "0x17DE754")]
	private void OBIMBAMKHLC(ResourceID JPFKGCMPLLM, Vector3 ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x6004000")]
	[Address(RVA = "0x17E1B30", Offset = "0x17E1B30", VA = "0x17E1B30")]
	public void PlayAshot(ResourceID IDNEFEOPGIF, EAudioGroupType PMGBACFJIHO = EAudioGroupType.Zombie_GeneralSkill, bool ELOGCJLPBKI = true, float AIFHEJMAIFP = 1f)
	{
	}

	[Token(Token = "0x6004001")]
	[Address(RVA = "0x17E5EF8", Offset = "0x17E5EF8", VA = "0x17E5EF8")]
	public GameObject Play3DLoopSFX(ResourceID IDNEFEOPGIF, float AIFHEJMAIFP = 1f)
	{
		return null;
	}

	[Token(Token = "0x6004002")]
	[Address(RVA = "0x17E60CC", Offset = "0x17E60CC", VA = "0x17E60CC")]
	public void Stop3DLoopSFX(GameObject BGJPMMPPIJO)
	{
	}

	[Token(Token = "0x6004003")]
	[Address(RVA = "0x17E6208", Offset = "0x17E6208", VA = "0x17E6208", Slot = "59")]
	public override uint GetAttackableID()
	{
		return default(uint);
	}

	[Token(Token = "0x6004004")]
	[Address(RVA = "0x17E62FC", Offset = "0x17E62FC", VA = "0x17E62FC", Slot = "60")]
	public override JADJBFDFEHA GetAttackableType()
	{
		return default(JADJBFDFEHA);
	}

	[Token(Token = "0x6004005")]
	[Address(RVA = "0x17E6354", Offset = "0x17E6354", VA = "0x17E6354")]
	public void PlayEffect(ResourceID JPFKGCMPLLM)
	{
	}

	[Token(Token = "0x6004006")]
	[Address(RVA = "0x17E65BC", Offset = "0x17E65BC", VA = "0x17E65BC")]
	public void PlayAnimEffect(string AKBMGPPCKID)
	{
	}

	[Token(Token = "0x6004007")]
	[Address(RVA = "0x17E672C", Offset = "0x17E672C", VA = "0x17E672C")]
	public void PlayAnimSound(string AKBMGPPCKID)
	{
	}

	[Token(Token = "0x6004008")]
	[Address(RVA = "0x17E68AC", Offset = "0x17E68AC", VA = "0x17E68AC")]
	public void PlayShadowEffect(bool FKJKDBGNMHP = true, float EOGFNBOKPFH = 0f, float NEEHBMGKJCF = 0f)
	{
	}

	[Token(Token = "0x6004009")]
	[Address(RVA = "0x17E6A08", Offset = "0x17E6A08", VA = "0x17E6A08")]
	public void StopShadowEffect()
	{
	}

	[Token(Token = "0x600400A")]
	[Address(RVA = "0x17E6B04", Offset = "0x17E6B04", VA = "0x17E6B04")]
	public void DisActiveExistShadowEffect()
	{
	}

	[Token(Token = "0x600400B")]
	[Address(RVA = "0x17E6C00", Offset = "0x17E6C00", VA = "0x17E6C00")]
	public void ShowModel()
	{
	}

	[Token(Token = "0x600400C")]
	[Address(RVA = "0x17E6D74", Offset = "0x17E6D74", VA = "0x17E6D74")]
	public void HideModel()
	{
	}

	[Token(Token = "0x600400D")]
	[Address(RVA = "0x17E6EE8", Offset = "0x17E6EE8", VA = "0x17E6EE8")]
	public void DisableColliders()
	{
	}

	[Token(Token = "0x600400E")]
	[Address(RVA = "0x17E6FAC", Offset = "0x17E6FAC", VA = "0x17E6FAC")]
	public void EnableColliders()
	{
	}

	[Token(Token = "0x600400F")]
	[Address(RVA = "0x17E7070", Offset = "0x17E7070", VA = "0x17E7070")]
	public void OnPRIStateIndexChanged(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004010")]
	[Address(RVA = "0x17E737C", Offset = "0x17E737C", VA = "0x17E737C")]
	public void OnPRITransformLevelChanged(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004011")]
	[Address(RVA = "0x17E747C", Offset = "0x17E747C", VA = "0x17E747C")]
	public void SkillTryToTransform()
	{
	}

	[Token(Token = "0x6004012")]
	[Address(RVA = "0x17E7400", Offset = "0x17E7400", VA = "0x17E7400")]
	public void TryToTransform(int BACIIIEPDLO)
	{
	}

	[Token(Token = "0x6004013")]
	[Address(RVA = "0x17DC8B4", Offset = "0x17DC8B4", VA = "0x17DC8B4")]
	public void ClearCurModel()
	{
	}

	[Token(Token = "0x6004014")]
	[Address(RVA = "0x17E74E4", Offset = "0x17E74E4", VA = "0x17E74E4")]
	public void TransformChangeModel()
	{
	}

	[Token(Token = "0x6004015")]
	[Address(RVA = "0x17E7614", Offset = "0x17E7614", VA = "0x17E7614")]
	private void HKEOBLHJBPC(Transform HPHJJMBKCNK, ResourceID OCIHFINHIII)
	{
	}

	[Token(Token = "0x6004016")]
	[Address(RVA = "0x17DF2DC", Offset = "0x17DF2DC", VA = "0x17DF2DC")]
	private void MOHGPKDEBIM(Transform GDOGIGDHJJO, ResourceID GJHEDDIOAAH)
	{
	}

	[Token(Token = "0x6004017")]
	[Address(RVA = "0x17E78DC", Offset = "0x17E78DC", VA = "0x17E78DC")]
	public void OnSkillUpdateMsgCome(uint CEGBBIBELDM, OPKPPFDNCMC GEPIPPKAIBK, object LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004018")]
	public void RegisterSkillMsgHandler<T>(uint CEGBBIBELDM, OPKPPFDNCMC GEPIPPKAIBK, IMCIPPJDGNF.ICCKKIOOFGK<T> FKJAAHJPACL)
	{
	}

	[Token(Token = "0x6004019")]
	[Address(RVA = "0x17E79AC", Offset = "0x17E79AC", VA = "0x17E79AC", Slot = "84")]
	public virtual void PostAddedToGame()
	{
	}

	[Token(Token = "0x600401A")]
	[Address(RVA = "0x17E7A14", Offset = "0x17E7A14", VA = "0x17E7A14")]
	private void HLNKAGKGIFN()
	{
	}

	[Token(Token = "0x600401B")]
	[Address(RVA = "0x17E7D10", Offset = "0x17E7D10", VA = "0x17E7D10", Slot = "85")]
	public virtual void OnBossEnterNewPhase(int FEHMDGLDNFM)
	{
	}

	[Token(Token = "0x600401C")]
	[Address(RVA = "0x17E7D6C", Offset = "0x17E7D6C", VA = "0x17E7D6C")]
	public GameObject GetEffectInstance(ResourceID IDNEFEOPGIF, bool MPHHNJMICKI = true)
	{
		return null;
	}

	[Token(Token = "0x600401D")]
	[Address(RVA = "0x17E21BC", Offset = "0x17E21BC", VA = "0x17E21BC")]
	private void OGGBFDJOOKC()
	{
	}

	[Token(Token = "0x600401E")]
	[Address(RVA = "0x17E7C6C", Offset = "0x17E7C6C", VA = "0x17E7C6C")]
	private void CKILPKKAGHH()
	{
	}

	[Token(Token = "0x600401F")]
	[Address(RVA = "0x17E7FF8", Offset = "0x17E7FF8", VA = "0x17E7FF8")]
	private IEnumerator KECDCCKOPKN()
	{
		return null;
	}

	[Token(Token = "0x6004021")]
	[Address(RVA = "0x17E8124", Offset = "0x17E8124", VA = "0x17E8124")]
	private void EKAJLGLOACG()
	{
	}

	[Token(Token = "0x6004022")]
	[Address(RVA = "0x17E828C", Offset = "0x17E828C", VA = "0x17E828C")]
	private void IEGLHPEMDLD()
	{
	}

	[Token(Token = "0x6004023")]
	[Address(RVA = "0x17E8418", Offset = "0x17E8418", VA = "0x17E8418")]
	public void _003C_003EiFixBaseProxy_InitEntityInfo()
	{
	}

	[Token(Token = "0x6004024")]
	[Address(RVA = "0x17E8420", Offset = "0x17E8420", VA = "0x17E8420")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6004025")]
	[Address(RVA = "0x17E8428", Offset = "0x17E8428", VA = "0x17E8428")]
	public Vector3 _003C_003EiFixBaseProxy_GetAttackableCenterWS()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6004026")]
	[Address(RVA = "0x17E843C", Offset = "0x17E843C", VA = "0x17E843C")]
	public float _003C_003EiFixBaseProxy_GetAttackableRadius()
	{
		return default(float);
	}

	[Token(Token = "0x6004027")]
	[Address(RVA = "0x17E8444", Offset = "0x17E8444", VA = "0x17E8444")]
	public Vector3 _003C_003EiFixBaseProxy_GetHitDamagePos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6004028")]
	[Address(RVA = "0x17E8458", Offset = "0x17E8458", VA = "0x17E8458")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x6004029")]
	[Address(RVA = "0x17E8460", Offset = "0x17E8460", VA = "0x17E8460")]
	public void _003C_003EiFixBaseProxy_UnRegisterEntity()
	{
	}

	[Token(Token = "0x600402A")]
	[Address(RVA = "0x17E8468", Offset = "0x17E8468", VA = "0x17E8468")]
	public void _003C_003EiFixBaseProxy_TakeDamage(ELMGJKHIIAA P0, MKFEKBKJCKE P1, List<float> P2, uint P3)
	{
	}

	[Token(Token = "0x600402B")]
	[Address(RVA = "0x17E848C", Offset = "0x17E848C", VA = "0x17E848C")]
	public uint _003C_003EiFixBaseProxy_GetAttackableID()
	{
		return default(uint);
	}

	[Token(Token = "0x600402C")]
	[Address(RVA = "0x17E8494", Offset = "0x17E8494", VA = "0x17E8494")]
	public JADJBFDFEHA _003C_003EiFixBaseProxy_GetAttackableType()
	{
		return default(JADJBFDFEHA);
	}
}
