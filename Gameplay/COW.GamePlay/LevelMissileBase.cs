using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x200065B")]
internal abstract class LevelMissileBase : BaseLevelObject, _Attribute
{
	[Token(Token = "0x200065C")]
	protected class HHCBNAPCKHF
	{
		[Token(Token = "0x400476C")]
		[FieldOffset(Offset = "0x8")]
		public int PIALGKABCBG;

		[Token(Token = "0x400476D")]
		[FieldOffset(Offset = "0xC")]
		public float HGEMAGBCANO;

		[Token(Token = "0x400476E")]
		[FieldOffset(Offset = "0x10")]
		public uint CCFCMGLIEFH;

		[Token(Token = "0x400476F")]
		[FieldOffset(Offset = "0x14")]
		public uint DBPDEFEOPCB;

		[Token(Token = "0x4004770")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 PGDEDHFOMCN;

		[Token(Token = "0x4004771")]
		[FieldOffset(Offset = "0x24")]
		public Quaternion BPLOAFBIHJL;

		[Token(Token = "0x4004772")]
		[FieldOffset(Offset = "0x34")]
		public uint NMDNCAFMFDD;

		[Token(Token = "0x4004773")]
		[FieldOffset(Offset = "0x38")]
		public uint AMNKMGEBIPO;

		[Token(Token = "0x4004774")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 JHJLNLCEGOG;

		[Token(Token = "0x4004775")]
		[FieldOffset(Offset = "0x48")]
		public Quaternion FBMPKHMBHAM;

		[Token(Token = "0x4004776")]
		[FieldOffset(Offset = "0x58")]
		public Vector3 LMNBBBCKMGB;

		[Token(Token = "0x17000315")]
		public float IPLHILOEOOM
		{
			[Token(Token = "0x60027FA")]
			[Address(RVA = "0x24C1A6C", Offset = "0x24C1A6C", VA = "0x24C1A6C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60027F8")]
		[Address(RVA = "0x24C5408", Offset = "0x24C5408", VA = "0x24C5408")]
		public HHCBNAPCKHF()
		{
		}

		[Token(Token = "0x60027F9")]
		[Address(RVA = "0x24C09E4", Offset = "0x24C09E4", VA = "0x24C09E4")]
		public bool CGPBHCCHNHA()
		{
			return default(bool);
		}

		[Token(Token = "0x60027FB")]
		[Address(RVA = "0x24C1B10", Offset = "0x24C1B10", VA = "0x24C1B10")]
		public Vector3 KEGFDIPLAOH(float LGHNJEDOFFD)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Token(Token = "0x60027FC")]
		[Address(RVA = "0x24C1C38", Offset = "0x24C1C38", VA = "0x24C1C38")]
		public Quaternion HMDCJBAOPNA(float LGHNJEDOFFD)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}
	}

	[Token(Token = "0x200065D")]
	private sealed class KALPIFOMJCJ : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4004777")]
		[FieldOffset(Offset = "0x8")]
		internal Vector3 ACCOJJMKKPM;

		[Token(Token = "0x4004778")]
		[FieldOffset(Offset = "0x14")]
		internal LevelMissileBase GADHAMJEKIM;

		[Token(Token = "0x4004779")]
		[FieldOffset(Offset = "0x18")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x400477A")]
		[FieldOffset(Offset = "0x1C")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x400477B")]
		[FieldOffset(Offset = "0x20")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x17000316")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60027FF")]
			[Address(RVA = "0x24C72AC", Offset = "0x24C72AC", VA = "0x24C72AC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000317")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002800")]
			[Address(RVA = "0x24C72B4", Offset = "0x24C72B4", VA = "0x24C72B4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60027FD")]
		[Address(RVA = "0x24C69D4", Offset = "0x24C69D4", VA = "0x24C69D4")]
		public KALPIFOMJCJ()
		{
		}

		[Token(Token = "0x60027FE")]
		[Address(RVA = "0x24C7148", Offset = "0x24C7148", VA = "0x24C7148", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002801")]
		[Address(RVA = "0x24C72BC", Offset = "0x24C72BC", VA = "0x24C72BC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002802")]
		[Address(RVA = "0x24C72D0", Offset = "0x24C72D0", VA = "0x24C72D0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400475E")]
	[FieldOffset(Offset = "0x74")]
	private JODBNBMENMC _003CNDJFPFPHNGH_003Ek__BackingField;

	[Token(Token = "0x400475F")]
	[FieldOffset(Offset = "0x78")]
	protected APOMMGLHICL HOAJBDMIJBK;

	[Token(Token = "0x4004760")]
	[FieldOffset(Offset = "0x80")]
	public IHAAMHPPLMG FirePlayerID;

	[Token(Token = "0x4004761")]
	[FieldOffset(Offset = "0x98")]
	public bool FiredByLocalPlayer;

	[Token(Token = "0x4004762")]
	[FieldOffset(Offset = "0x99")]
	private bool _003CJPFJBMIFOGI_003Ek__BackingField;

	[Token(Token = "0x4004763")]
	protected const byte OOKCCJBBAEO = 128;

	[Token(Token = "0x4004764")]
	[FieldOffset(Offset = "0x9C")]
	protected HHCBNAPCKHF PLGAAJABBHA;

	[Token(Token = "0x4004765")]
	[FieldOffset(Offset = "0xA0")]
	protected uint KINJCKMOGIM;

	[Token(Token = "0x4004766")]
	[FieldOffset(Offset = "0xA4")]
	protected bool OIJLMOJMNLJ;

	[Token(Token = "0x4004767")]
	[FieldOffset(Offset = "0xA5")]
	protected bool EEGHGJMOHIF;

	[Token(Token = "0x4004768")]
	public const int TimeoutFrameCount = 200;

	[Token(Token = "0x4004769")]
	[FieldOffset(Offset = "0xA8")]
	private AttackableEntity _003CHLKDMMOAHPK_003Ek__BackingField;

	[Token(Token = "0x400476A")]
	[FieldOffset(Offset = "0xAC")]
	protected ResourceID HBHEIPGLCEJ;

	[Token(Token = "0x400476B")]
	[FieldOffset(Offset = "0xB0")]
	protected bool NOHNBMNLGKD;

	[Token(Token = "0x17000311")]
	public JODBNBMENMC DFGKNGPEPCL
	{
		[Token(Token = "0x60027D5")]
		[Address(RVA = "0x24C02BC", Offset = "0x24C02BC", VA = "0x24C02BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60027D6")]
		[Address(RVA = "0x24C54B4", Offset = "0x24C54B4", VA = "0x24C54B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000312")]
	public float DMDHBKJLBOC
	{
		[Token(Token = "0x60027D7")]
		[Address(RVA = "0x24BF1B4", Offset = "0x24BF1B4", VA = "0x24BF1B4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000313")]
	public bool IIIIKMJLHFB
	{
		[Token(Token = "0x60027D8")]
		[Address(RVA = "0x24C54BC", Offset = "0x24C54BC", VA = "0x24C54BC", Slot = "40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60027D9")]
		[Address(RVA = "0x24C54C4", Offset = "0x24C54C4", VA = "0x24C54C4", Slot = "41")]
		set
		{
		}
	}

	[Token(Token = "0x17000314")]
	public AttackableEntity DPEKKCJIFDF
	{
		[Token(Token = "0x60027DA")]
		[Address(RVA = "0x24C54CC", Offset = "0x24C54CC", VA = "0x24C54CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60027DB")]
		[Address(RVA = "0x24C54D4", Offset = "0x24C54D4", VA = "0x24C54D4")]
		protected set
		{
		}
	}

	[Token(Token = "0x60027D3")]
	[Address(RVA = "0x24BC8EC", Offset = "0x24BC8EC", VA = "0x24BC8EC")]
	protected LevelMissileBase()
	{
	}

	[Token(Token = "0x60027D4")]
	[Address(RVA = "0x24C5410", Offset = "0x24C5410", VA = "0x24C5410", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60027DC")]
	[Address(RVA = "0x24C054C", Offset = "0x24C054C", VA = "0x24C054C")]
	protected void LMNNABBEHLO(AttackableEntity OPJKJHBKLGN)
	{
	}

	[Token(Token = "0x60027DD")]
	[Address(RVA = "0x24BCAB4", Offset = "0x24BCAB4", VA = "0x24BCAB4", Slot = "42")]
	public virtual void Init(ResourceID JPFKGCMPLLM, JODBNBMENMC OECMLDILLJN)
	{
	}

	[Token(Token = "0x60027DE")]
	[Address(RVA = "0x24C54DC", Offset = "0x24C54DC", VA = "0x24C54DC")]
	protected void LGBDFGHKIBJ()
	{
	}

	[Token(Token = "0x60027DF")]
	[Address(RVA = "0x24C56A0", Offset = "0x24C56A0", VA = "0x24C56A0")]
	public void Recycle()
	{
	}

	[Token(Token = "0x60027E0")]
	[Address(RVA = "0x24C4F90", Offset = "0x24C4F90", VA = "0x24C4F90", Slot = "43")]
	protected virtual void AJKGLMOJJGI()
	{
	}

	[Token(Token = "0x60027E1")]
	[Address(RVA = "0x24C58FC", Offset = "0x24C58FC", VA = "0x24C58FC", Slot = "44")]
	protected virtual bool EHELNHPBDDE(Player FIMNKGABILM, ref uint GKFLHDLFDCC, ref AttackableEntity FFDHFKIMFDG)
	{
		return default(bool);
	}

	[Token(Token = "0x60027E2")]
	[Address(RVA = "0x24C597C", Offset = "0x24C597C", VA = "0x24C597C", Slot = "45")]
	public virtual void Fire(APOMMGLHICL PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x60027E3")]
	[Address(RVA = "0x24C5A38", Offset = "0x24C5A38", VA = "0x24C5A38", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x60027E4")]
	[Address(RVA = "0x24C4FE8", Offset = "0x24C4FE8", VA = "0x24C4FE8", Slot = "46")]
	protected virtual void BCAFIPCHLLJ(OPFMONINOBB GLDLCOBLGNF, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x60027E5")]
	[Address(RVA = "0x24BDB0C", Offset = "0x24BDB0C", VA = "0x24BDB0C")]
	protected void BDDAGEBHNHG(OPFMONINOBB GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x60027E6")]
	[Address(RVA = "0x24C50C0", Offset = "0x24C50C0", VA = "0x24C50C0", Slot = "47")]
	protected virtual void GDLCAJOJOKI(AttackableEntity FKCAAKDFCDG, AttackableEntity MLGKHMFMJHP)
	{
	}

	[Token(Token = "0x60027E7")]
	[Address(RVA = "0x24BDC90", Offset = "0x24BDC90", VA = "0x24BDC90")]
	internal void AKNHNDPCGAM(OPFMONINOBB GLDLCOBLGNF, uint LPJONPCPBED, uint BLOANDINMIH)
	{
	}

	[Token(Token = "0x60027E8")]
	[Address(RVA = "0x24C513C", Offset = "0x24C513C", VA = "0x24C513C", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60027E9")]
	[Address(RVA = "0x24C5C94", Offset = "0x24C5C94", VA = "0x24C5C94", Slot = "48")]
	protected virtual void MJIPPMCKOCJ(bool JGAKJHAPHOA, APOMMGLHICL PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x60027EA")]
	[Address(RVA = "0x24C5D58", Offset = "0x24C5D58", VA = "0x24C5D58", Slot = "49")]
	protected virtual void CLGJBBIPBPL(bool JGAKJHAPHOA, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60027EB")]
	[Address(RVA = "0x24C5E3C", Offset = "0x24C5E3C", VA = "0x24C5E3C", Slot = "50")]
	protected virtual void BEIDFBFOLIM(float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60027EC")]
	[Address(RVA = "0x24C520C", Offset = "0x24C520C", VA = "0x24C520C", Slot = "51")]
	protected virtual void MHNCKNMNAGL(float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60027ED")]
	[Address(RVA = "0x24C657C", Offset = "0x24C657C", VA = "0x24C657C", Slot = "52")]
	protected virtual void BBMGDPFLDFM(float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60027EE")]
	[Address(RVA = "0x24C5EEC", Offset = "0x24C5EEC", VA = "0x24C5EEC")]
	protected bool OIHMMDGCFGH(bool PKPEMNPJDHA, float OMAFEKBHOAA = 0f, float OJGNBJELDEM = 0f, float OCDJENFLCCE = 0f, bool IKBOMMMFJNP = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60027EF")]
	[Address(RVA = "0x24C65D8", Offset = "0x24C65D8", VA = "0x24C65D8", Slot = "53")]
	public virtual void Explode(Vector3 ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x60027F0")]
	[Address(RVA = "0x24C68C8", Offset = "0x24C68C8", VA = "0x24C68C8")]
	private IEnumerator ACLICFCNNBH(Vector3 ACCOJJMKKPM)
	{
		return null;
	}

	[Token(Token = "0x60027F1")]
	[Address(RVA = "0x24C69DC", Offset = "0x24C69DC", VA = "0x24C69DC", Slot = "54")]
	protected virtual void FLBGIABDFNL(Vector3 ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x60027F2")]
	[Address(RVA = "0x24C6CE0", Offset = "0x24C6CE0", VA = "0x24C6CE0", Slot = "55")]
	protected virtual void LNDJCNPGDMJ(Vector3 ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x60027F3")]
	[Address(RVA = "0x24C6EB4", Offset = "0x24C6EB4", VA = "0x24C6EB4", Slot = "56")]
	protected virtual void DAOIEMFCDPP()
	{
	}

	[Token(Token = "0x60027F4")]
	[Address(RVA = "0x24C6FE8", Offset = "0x24C6FE8", VA = "0x24C6FE8")]
	private static string NONGKPAABIB(Vector3 JOGHOHLEJFL)
	{
		return null;
	}

	[Token(Token = "0x60027F5")]
	[Address(RVA = "0x24BD53C", Offset = "0x24BD53C", VA = "0x24BD53C")]
	protected void GLDCPDELDME(bool FICNJIMKAEF)
	{
	}

	[Token(Token = "0x60027F6")]
	[Address(RVA = "0x24C7138", Offset = "0x24C7138", VA = "0x24C7138")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	[Token(Token = "0x60027F7")]
	[Address(RVA = "0x24C7140", Offset = "0x24C7140", VA = "0x24C7140")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
