using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000607")]
public class LevelDamageZone : Entity
{
	[Token(Token = "0x2000608")]
	private sealed class GMOEGDONNGG : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4004578")]
		[FieldOffset(Offset = "0x8")]
		internal float CAMBDLAPJDA;

		[Token(Token = "0x4004579")]
		[FieldOffset(Offset = "0xC")]
		internal LevelDamageZone GADHAMJEKIM;

		[Token(Token = "0x400457A")]
		[FieldOffset(Offset = "0x10")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x400457B")]
		[FieldOffset(Offset = "0x14")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x400457C")]
		[FieldOffset(Offset = "0x18")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x170002EB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002527")]
			[Address(RVA = "0x2710658", Offset = "0x2710658", VA = "0x2710658", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002EC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002528")]
			[Address(RVA = "0x2710660", Offset = "0x2710660", VA = "0x2710660", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002525")]
		[Address(RVA = "0x270FC1C", Offset = "0x270FC1C", VA = "0x270FC1C")]
		public GMOEGDONNGG()
		{
		}

		[Token(Token = "0x6002526")]
		[Address(RVA = "0x271053C", Offset = "0x271053C", VA = "0x271053C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002529")]
		[Address(RVA = "0x2710668", Offset = "0x2710668", VA = "0x2710668", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600252A")]
		[Address(RVA = "0x271067C", Offset = "0x271067C", VA = "0x271067C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400456D")]
	[FieldOffset(Offset = "0x34")]
	private uint HCIBNHFFOMO;

	[Token(Token = "0x400456E")]
	[FieldOffset(Offset = "0x38")]
	private ResourceID EIEGPLELJKJ;

	[Token(Token = "0x400456F")]
	[FieldOffset(Offset = "0x3C")]
	private float GHOPBLGNCLL;

	[Token(Token = "0x4004570")]
	[FieldOffset(Offset = "0x40")]
	private float LGJMHLLPJIA;

	[Token(Token = "0x4004571")]
	[FieldOffset(Offset = "0x44")]
	private float LEKJDMADGBK;

	[Token(Token = "0x4004572")]
	[FieldOffset(Offset = "0x48")]
	private IEnumerator AOAPPAIPMDC;

	[Token(Token = "0x4004573")]
	[FieldOffset(Offset = "0x4C")]
	public CapsuleCollider m_Trigger;

	[Token(Token = "0x4004574")]
	[FieldOffset(Offset = "0x50")]
	public Transform m_ScaleTrans;

	[Token(Token = "0x4004575")]
	[FieldOffset(Offset = "0x54")]
	private List<IHAAMHPPLMG> HOOCHDLKOOG;

	[Token(Token = "0x4004576")]
	[FieldOffset(Offset = "0x58")]
	private PHJFJECLELI GJMMBLEHMIG;

	[Token(Token = "0x4004577")]
	[FieldOffset(Offset = "0x5C")]
	private GameObject MAPLHOCBDBO;

	[Token(Token = "0x6002511")]
	[Address(RVA = "0x270F140", Offset = "0x270F140", VA = "0x270F140")]
	public LevelDamageZone()
	{
	}

	[Token(Token = "0x6002512")]
	[Address(RVA = "0x270F1D0", Offset = "0x270F1D0", VA = "0x270F1D0")]
	public static ResourceID GetResIdByZoneType(byte DIGCBBHFFIN)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002513")]
	[Address(RVA = "0x270F2B8", Offset = "0x270F2B8", VA = "0x270F2B8", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6002514")]
	[Address(RVA = "0x270F324", Offset = "0x270F324", VA = "0x270F324")]
	public void Init(uint IDNEFEOPGIF, ResourceID FCMOICILFBP, int PKLINKOAJBP, float BAJIOEGPDAN, float NKPFEBMAAKP, PHJFJECLELI DIGCBBHFFIN)
	{
	}

	[Token(Token = "0x6002515")]
	[Address(RVA = "0x270F5B8", Offset = "0x270F5B8", VA = "0x270F5B8")]
	private void MBNFINFGGKI()
	{
	}

	[Token(Token = "0x6002516")]
	[Address(RVA = "0x270F9A4", Offset = "0x270F9A4", VA = "0x270F9A4")]
	public uint GetID()
	{
		return default(uint);
	}

	[Token(Token = "0x6002517")]
	[Address(RVA = "0x270F9FC", Offset = "0x270F9FC", VA = "0x270F9FC")]
	public float GetSpeedScale()
	{
		return default(float);
	}

	[Token(Token = "0x6002518")]
	[Address(RVA = "0x270F4D0", Offset = "0x270F4D0", VA = "0x270F4D0")]
	private float NEGLPKLOGPJ()
	{
		return default(float);
	}

	[Token(Token = "0x6002519")]
	[Address(RVA = "0x270FA54", Offset = "0x270FA54", VA = "0x270FA54")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600251A")]
	[Address(RVA = "0x270FAC4", Offset = "0x270FAC4", VA = "0x270FAC4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600251B")]
	[Address(RVA = "0x270F7B0", Offset = "0x270F7B0", VA = "0x270F7B0")]
	private void AKGACHPEDCC()
	{
	}

	[Token(Token = "0x600251C")]
	[Address(RVA = "0x270FB20", Offset = "0x270FB20", VA = "0x270FB20")]
	private IEnumerator MLHGMAPCDEA(float CAMBDLAPJDA)
	{
		return null;
	}

	[Token(Token = "0x600251D")]
	[Address(RVA = "0x270FC24", Offset = "0x270FC24", VA = "0x270FC24")]
	private void DAIPMABJJDN()
	{
	}

	[Token(Token = "0x600251E")]
	[Address(RVA = "0x27101C8", Offset = "0x27101C8", VA = "0x27101C8")]
	public void OnPlayerEnter(IHAAMHPPLMG IFOLCOIDJIK)
	{
	}

	[Token(Token = "0x600251F")]
	[Address(RVA = "0x2710328", Offset = "0x2710328", VA = "0x2710328")]
	public void OnPlayerExit(IHAAMHPPLMG IFOLCOIDJIK)
	{
	}

	[Token(Token = "0x6002520")]
	[Address(RVA = "0x270FF58", Offset = "0x270FF58", VA = "0x270FF58")]
	private void IDDMGCLOHCF()
	{
	}

	[Token(Token = "0x6002521")]
	[Address(RVA = "0x270F858", Offset = "0x270F858", VA = "0x270F858")]
	private void CLIPGBBEGNB()
	{
	}

	[Token(Token = "0x6002522")]
	[Address(RVA = "0x270FE64", Offset = "0x270FE64", VA = "0x270FE64")]
	private void EBLBAGFOEBH()
	{
	}

	[Token(Token = "0x6002523")]
	[Address(RVA = "0x2710430", Offset = "0x2710430", VA = "0x2710430")]
	private ResourceID NPMEAIFLHEA()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002524")]
	[Address(RVA = "0x2710534", Offset = "0x2710534", VA = "0x2710534")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}
}
