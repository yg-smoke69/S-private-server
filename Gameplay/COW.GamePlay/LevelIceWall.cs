using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000638")]
internal class LevelIceWall : BaseLevelObject
{
	[Token(Token = "0x2000639")]
	private class HHCBNAPCKHF : ShadowStateBase
	{
		[Token(Token = "0x400467E")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 PGDEDHFOMCN;

		[Token(Token = "0x400467F")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion BPLOAFBIHJL;

		[Token(Token = "0x4004680")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 JHJLNLCEGOG;

		[Token(Token = "0x4004681")]
		[FieldOffset(Offset = "0x38")]
		public Quaternion FBMPKHMBHAM;

		[Token(Token = "0x60026AB")]
		[Address(RVA = "0x24AE7E8", Offset = "0x24AE7E8", VA = "0x24AE7E8")]
		public HHCBNAPCKHF()
		{
		}
	}

	[Token(Token = "0x200063A")]
	private sealed class PDJPBBCDAHJ : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4004682")]
		[FieldOffset(Offset = "0x8")]
		internal float PFHJIHJHHKG;

		[Token(Token = "0x4004683")]
		[FieldOffset(Offset = "0xC")]
		internal Vector3 DMIALJLCIMD;

		[Token(Token = "0x4004684")]
		[FieldOffset(Offset = "0x18")]
		internal LevelIceWall GADHAMJEKIM;

		[Token(Token = "0x4004685")]
		[FieldOffset(Offset = "0x1C")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x4004686")]
		[FieldOffset(Offset = "0x20")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x4004687")]
		[FieldOffset(Offset = "0x24")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x170002FF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60026AE")]
			[Address(RVA = "0x24AED44", Offset = "0x24AED44", VA = "0x24AED44", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000300")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60026AF")]
			[Address(RVA = "0x24AED4C", Offset = "0x24AED4C", VA = "0x24AED4C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60026AC")]
		[Address(RVA = "0x24AE7F0", Offset = "0x24AE7F0", VA = "0x24AE7F0")]
		public PDJPBBCDAHJ()
		{
		}

		[Token(Token = "0x60026AD")]
		[Address(RVA = "0x24AE7F8", Offset = "0x24AE7F8", VA = "0x24AE7F8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60026B0")]
		[Address(RVA = "0x24AED54", Offset = "0x24AED54", VA = "0x24AED54", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60026B1")]
		[Address(RVA = "0x24AED68", Offset = "0x24AED68", VA = "0x24AED68", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4004669")]
	[FieldOffset(Offset = "0x74")]
	public IceWall[] m_IceWall;

	[Token(Token = "0x400466A")]
	[FieldOffset(Offset = "0x78")]
	public Collider m_IceWallTrigger;

	[Token(Token = "0x400466B")]
	[FieldOffset(Offset = "0x7C")]
	private ResourceID EIEGPLELJKJ;

	[Token(Token = "0x400466C")]
	[FieldOffset(Offset = "0x80")]
	private int CDILIIIMJEG;

	[Token(Token = "0x400466D")]
	[FieldOffset(Offset = "0x84")]
	private DJEMJLOJBKP JGBJJEENLFJ;

	[Token(Token = "0x400466E")]
	[FieldOffset(Offset = "0x88")]
	private bool AFDKGINKPOO;

	[Token(Token = "0x400466F")]
	[FieldOffset(Offset = "0x89")]
	private bool DBPAMBCJLMH;

	[Token(Token = "0x4004670")]
	[FieldOffset(Offset = "0x8C")]
	private int DJOLEONHION;

	[Token(Token = "0x4004671")]
	[FieldOffset(Offset = "0x90")]
	private bool CJODIDHEIDB;

	[Token(Token = "0x4004672")]
	[FieldOffset(Offset = "0x94")]
	protected uint KINJCKMOGIM;

	[Token(Token = "0x4004673")]
	[FieldOffset(Offset = "0x98")]
	private HHCBNAPCKHF PLGAAJABBHA;

	[Token(Token = "0x4004674")]
	[FieldOffset(Offset = "0x9C")]
	private GameObject EBFKDDHGEJF;

	[Token(Token = "0x4004675")]
	[FieldOffset(Offset = "0xA0")]
	public float effectLerpFactor;

	[Token(Token = "0x4004676")]
	[FieldOffset(Offset = "0xA4")]
	public float effectLerpUsage;

	[Token(Token = "0x4004677")]
	[FieldOffset(Offset = "0xA8")]
	public List<Material> effectMats;

	[Token(Token = "0x4004678")]
	[FieldOffset(Offset = "0xAC")]
	private MeshRenderer BAJNMDCEMBO;

	[Token(Token = "0x4004679")]
	[FieldOffset(Offset = "0xB0")]
	private float HDOCIIOIBGE;

	[Token(Token = "0x400467A")]
	private const string PHNPDPHBKGM = "ICEWALL_RECOVERHP_SKILL";

	[Token(Token = "0x400467B")]
	[FieldOffset(Offset = "0xB4")]
	private Vector3 MMIKDELCPNF;

	[Token(Token = "0x400467C")]
	private const string HPNMOPEJFCJ = "ICEWALL_EXTRAHP_VIEW";

	[Token(Token = "0x400467D")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 LOJDGNMIHLD;

	[Token(Token = "0x170002FC")]
	public int PPIDMNPBPOI
	{
		[Token(Token = "0x6002686")]
		[Address(RVA = "0x272C7DC", Offset = "0x272C7DC", VA = "0x272C7DC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002FD")]
	public bool DADOFJJNCCC
	{
		[Token(Token = "0x6002687")]
		[Address(RVA = "0x272C834", Offset = "0x272C834", VA = "0x272C834")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002FE")]
	private int KHJDKEDLHHE
	{
		[Token(Token = "0x6002688")]
		[Address(RVA = "0x272C88C", Offset = "0x272C88C", VA = "0x272C88C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002685")]
	[Address(RVA = "0x272C654", Offset = "0x272C654", VA = "0x272C654")]
	public LevelIceWall()
	{
	}

	[Token(Token = "0x6002689")]
	[Address(RVA = "0x272C948", Offset = "0x272C948", VA = "0x272C948")]
	public void Init(DJEMJLOJBKP LGCOECDENEO, int INNOJJAHLPC, bool CNPJGNEBACM, bool BHFPOONGALP = false, bool FEAMPDNLPMB = false)
	{
	}

	[Token(Token = "0x600268A")]
	[Address(RVA = "0x272E6D0", Offset = "0x272E6D0", VA = "0x272E6D0")]
	public bool NeedGetOut()
	{
		return default(bool);
	}

	[Token(Token = "0x600268B")]
	[Address(RVA = "0x272E728", Offset = "0x272E728", VA = "0x272E728")]
	private IEnumerator PEHMJEEKPJB()
	{
		return null;
	}

	[Token(Token = "0x600268C")]
	[Address(RVA = "0x272E7F4", Offset = "0x272E7F4", VA = "0x272E7F4", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x600268D")]
	[Address(RVA = "0x272E898", Offset = "0x272E898", VA = "0x272E898", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x600268E")]
	[Address(RVA = "0x272EBF4", Offset = "0x272EBF4", VA = "0x272EBF4", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x600268F")]
	[Address(RVA = "0x272ED9C", Offset = "0x272ED9C", VA = "0x272ED9C", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002690")]
	[Address(RVA = "0x272F1B8", Offset = "0x272F1B8", VA = "0x272F1B8")]
	public void SyncState(Vector3 MLCIHBOHEHE, Quaternion FHOOEHJBEDL, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x6002691")]
	[Address(RVA = "0x272F390", Offset = "0x272F390", VA = "0x272F390")]
	public void DestroyIceWall()
	{
	}

	[Token(Token = "0x6002692")]
	[Address(RVA = "0x272DAD8", Offset = "0x272DAD8", VA = "0x272DAD8")]
	private ResourceID ECANKBJFBGK()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002693")]
	[Address(RVA = "0x272F6DC", Offset = "0x272F6DC", VA = "0x272F6DC")]
	private ResourceID DKFLLPIFBCJ()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002694")]
	[Address(RVA = "0x272DC14", Offset = "0x272DC14", VA = "0x272DC14")]
	private ResourceID OLCNHGGDNKH()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002695")]
	[Address(RVA = "0x272F818", Offset = "0x272F818", VA = "0x272F818")]
	private ResourceID HFPAOAPPHCN()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002696")]
	[Address(RVA = "0x272FB80", Offset = "0x272FB80", VA = "0x272FB80")]
	public ResourceID GetHitSparkleVFX()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002697")]
	[Address(RVA = "0x272FCBC", Offset = "0x272FCBC", VA = "0x272FCBC")]
	public ResourceID GetHitSFX()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002698")]
	[Address(RVA = "0x272E1D4", Offset = "0x272E1D4", VA = "0x272E1D4")]
	private void KKIAEBCICOH()
	{
	}

	[Token(Token = "0x6002699")]
	[Address(RVA = "0x272F954", Offset = "0x272F954", VA = "0x272F954")]
	private void PADFBLADEKJ()
	{
	}

	[Token(Token = "0x600269A")]
	[Address(RVA = "0x272DD50", Offset = "0x272DD50", VA = "0x272DD50")]
	private void CGGHADKHKKE(ResourceID GJMJJFAOBEL, ResourceID DDDJHDHBFJB)
	{
	}

	[Token(Token = "0x600269B")]
	[Address(RVA = "0x272FEA0", Offset = "0x272FEA0", VA = "0x272FEA0", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x600269C")]
	[Address(RVA = "0x272FEF8", Offset = "0x272FEF8", VA = "0x272FEF8", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x600269D")]
	[Address(RVA = "0x2730084", Offset = "0x2730084", VA = "0x2730084")]
	private void HPGILFDILLD(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600269E")]
	[Address(RVA = "0x272D5E0", Offset = "0x272D5E0", VA = "0x272D5E0")]
	private void JMMFPBILCDB(bool ODOEHEHNJOG)
	{
	}

	[Token(Token = "0x600269F")]
	[Address(RVA = "0x2730270", Offset = "0x2730270", VA = "0x2730270", Slot = "29")]
	protected override void UnRegisterEntity()
	{
	}

	[Token(Token = "0x60026A0")]
	[Address(RVA = "0x272CE48", Offset = "0x272CE48", VA = "0x272CE48")]
	private void BFFJAIHAPKP(bool IMGNBGJDAHG)
	{
	}

	[Token(Token = "0x60026A1")]
	[Address(RVA = "0x27302DC", Offset = "0x27302DC", VA = "0x27302DC")]
	private void LKILHINEKFI(bool EBOJJLIHHCM)
	{
	}

	[Token(Token = "0x60026A2")]
	[Address(RVA = "0x272D0E8", Offset = "0x272D0E8", VA = "0x272D0E8")]
	private void PLEJHCLFOID(bool ODOEHEHNJOG)
	{
	}

	[Token(Token = "0x60026A3")]
	[Address(RVA = "0x272FD2C", Offset = "0x272FD2C", VA = "0x272FD2C")]
	private bool HOHBJNLFLMG()
	{
		return default(bool);
	}

	[Token(Token = "0x60026A4")]
	[Address(RVA = "0x27303FC", Offset = "0x27303FC", VA = "0x27303FC")]
	private void PHAJDAGOHNB(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x60026A5")]
	[Address(RVA = "0x27306EC", Offset = "0x27306EC", VA = "0x27306EC")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x60026A6")]
	[Address(RVA = "0x27306F4", Offset = "0x27306F4", VA = "0x27306F4")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x60026A7")]
	[Address(RVA = "0x27306FC", Offset = "0x27306FC", VA = "0x27306FC")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x60026A8")]
	[Address(RVA = "0x2730704", Offset = "0x2730704", VA = "0x2730704")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60026A9")]
	[Address(RVA = "0x273070C", Offset = "0x273070C", VA = "0x273070C")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60026AA")]
	[Address(RVA = "0x2730714", Offset = "0x2730714", VA = "0x2730714")]
	public void _003C_003EiFixBaseProxy_UnRegisterEntity()
	{
	}
}
