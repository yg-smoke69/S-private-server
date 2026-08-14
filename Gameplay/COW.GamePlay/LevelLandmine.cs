using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000642")]
internal class LevelLandmine : BaseLevelObject
{
	[Token(Token = "0x2000643")]
	private sealed class AFLNIFGJKEN : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x40046BA")]
		[FieldOffset(Offset = "0x8")]
		internal LevelLandmine GADHAMJEKIM;

		[Token(Token = "0x40046BB")]
		[FieldOffset(Offset = "0xC")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x40046BC")]
		[FieldOffset(Offset = "0x10")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x40046BD")]
		[FieldOffset(Offset = "0x14")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x17000304")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60026FB")]
			[Address(RVA = "0x24B4788", Offset = "0x24B4788", VA = "0x24B4788", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000305")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60026FC")]
			[Address(RVA = "0x24B4790", Offset = "0x24B4790", VA = "0x24B4790", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60026F9")]
		[Address(RVA = "0x24B3F08", Offset = "0x24B3F08", VA = "0x24B3F08")]
		public AFLNIFGJKEN()
		{
		}

		[Token(Token = "0x60026FA")]
		[Address(RVA = "0x24B424C", Offset = "0x24B424C", VA = "0x24B424C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60026FD")]
		[Address(RVA = "0x24B4798", Offset = "0x24B4798", VA = "0x24B4798", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60026FE")]
		[Address(RVA = "0x24B47AC", Offset = "0x24B47AC", VA = "0x24B47AC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40046AB")]
	[FieldOffset(Offset = "0x74")]
	public Landmine m_Landmine;

	[Token(Token = "0x40046AC")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_SetStayEffect;

	[Token(Token = "0x40046AD")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject m_EffectNode;

	[Token(Token = "0x40046AE")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_StartEffect;

	[Token(Token = "0x40046AF")]
	[FieldOffset(Offset = "0x84")]
	public GameObject m_WarningEffect;

	[Token(Token = "0x40046B0")]
	[FieldOffset(Offset = "0x88")]
	public SphereCollider m_LandmineTrigger;

	[Token(Token = "0x40046B1")]
	[FieldOffset(Offset = "0x8C")]
	private LGCOKIBHIJL KONECJJAMBJ;

	[Token(Token = "0x40046B2")]
	[FieldOffset(Offset = "0x90")]
	private float MLCBGEAGAEJ;

	[Token(Token = "0x40046B3")]
	[FieldOffset(Offset = "0x94")]
	private int NGFAGGHMILM;

	[Token(Token = "0x40046B4")]
	[FieldOffset(Offset = "0x98")]
	private bool HHOBHGAMANH;

	[Token(Token = "0x40046B5")]
	[FieldOffset(Offset = "0x9C")]
	private GameObject IKKMGHNJBDP;

	[Token(Token = "0x40046B6")]
	[FieldOffset(Offset = "0xA0")]
	private uint BAMEFBDNDDB;

	[Token(Token = "0x40046B7")]
	[FieldOffset(Offset = "0xA4")]
	private Player IEFIBEKJOKA;

	[Token(Token = "0x40046B8")]
	[FieldOffset(Offset = "0xA8")]
	private IHAAMHPPLMG NAOKAJENNEL;

	[Token(Token = "0x40046B9")]
	[FieldOffset(Offset = "0xC0")]
	private float CLMPPNONBOH;

	[Token(Token = "0x60026E4")]
	[Address(RVA = "0x24B23D0", Offset = "0x24B23D0", VA = "0x24B23D0")]
	public LevelLandmine()
	{
	}

	[Token(Token = "0x60026E5")]
	[Address(RVA = "0x24B2484", Offset = "0x24B2484", VA = "0x24B2484", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60026E6")]
	[Address(RVA = "0x24B2528", Offset = "0x24B2528", VA = "0x24B2528", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60026E7")]
	[Address(RVA = "0x24B2580", Offset = "0x24B2580", VA = "0x24B2580")]
	public float GetExplodeRange()
	{
		return default(float);
	}

	[Token(Token = "0x60026E8")]
	[Address(RVA = "0x24B2604", Offset = "0x24B2604", VA = "0x24B2604")]
	public void Init(LGCOKIBHIJL COGOOKNKDGF, uint BIFFAIEPIND)
	{
	}

	[Token(Token = "0x60026E9")]
	[Address(RVA = "0x24B299C", Offset = "0x24B299C", VA = "0x24B299C")]
	private bool GPIGENDDCFI(GPBDEDFKJNA.HAAOGJECGDE PMGBACFJIHO)
	{
		return default(bool);
	}

	[Token(Token = "0x60026EA")]
	[Address(RVA = "0x24B2A18", Offset = "0x24B2A18", VA = "0x24B2A18")]
	public Player GetOwner()
	{
		return null;
	}

	[Token(Token = "0x60026EB")]
	[Address(RVA = "0x24B2A70", Offset = "0x24B2A70", VA = "0x24B2A70")]
	public IHAAMHPPLMG GetOwnerID()
	{
		return default(IHAAMHPPLMG);
	}

	[Token(Token = "0x60026EC")]
	[Address(RVA = "0x24B2AE4", Offset = "0x24B2AE4", VA = "0x24B2AE4", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x60026ED")]
	[Address(RVA = "0x24B2D78", Offset = "0x24B2D78", VA = "0x24B2D78")]
	private void JIFLCFHMKHD()
	{
	}

	[Token(Token = "0x60026EE")]
	[Address(RVA = "0x24B3B7C", Offset = "0x24B3B7C", VA = "0x24B3B7C")]
	private void BEAOEFDKFOK()
	{
	}

	[Token(Token = "0x60026EF")]
	[Address(RVA = "0x24B3DC4", Offset = "0x24B3DC4", VA = "0x24B3DC4")]
	private bool NMBJHCKMMLP()
	{
		return default(bool);
	}

	[Token(Token = "0x60026F0")]
	[Address(RVA = "0x24B2CAC", Offset = "0x24B2CAC", VA = "0x24B2CAC")]
	private IEnumerator IPCMJPFPNGF()
	{
		return null;
	}

	[Token(Token = "0x60026F1")]
	[Address(RVA = "0x24B34D4", Offset = "0x24B34D4", VA = "0x24B34D4")]
	private void EMLEGGCPPLD(bool CHADOJMOHFJ)
	{
	}

	[Token(Token = "0x60026F2")]
	[Address(RVA = "0x24B3A38", Offset = "0x24B3A38", VA = "0x24B3A38")]
	private void CCPGNLPGMKL()
	{
	}

	[Token(Token = "0x60026F3")]
	[Address(RVA = "0x24B3F10", Offset = "0x24B3F10", VA = "0x24B3F10")]
	public void EnterTrigger(bool PDOIMJHFHEM, bool KALAHLABNBC, bool EPMNMNOIEGO)
	{
	}

	[Token(Token = "0x60026F4")]
	[Address(RVA = "0x24B40D4", Offset = "0x24B40D4", VA = "0x24B40D4")]
	public void ExitTrigger(bool PDOIMJHFHEM, bool KALAHLABNBC, bool EPMNMNOIEGO)
	{
	}

	[Token(Token = "0x60026F5")]
	[Address(RVA = "0x24B3D54", Offset = "0x24B3D54", VA = "0x24B3D54")]
	private void LBCHBOGLJMB()
	{
	}

	[Token(Token = "0x60026F6")]
	[Address(RVA = "0x24B4220", Offset = "0x24B4220", VA = "0x24B4220")]
	private void EMLNADLDFOL()
	{
	}

	[Token(Token = "0x60026F7")]
	[Address(RVA = "0x24B423C", Offset = "0x24B423C", VA = "0x24B423C")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60026F8")]
	[Address(RVA = "0x24B4244", Offset = "0x24B4244", VA = "0x24B4244")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
