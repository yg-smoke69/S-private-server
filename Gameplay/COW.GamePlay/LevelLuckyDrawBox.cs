using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000648")]
public class LevelLuckyDrawBox : BaseLevelObject
{
	[Token(Token = "0x2000649")]
	public enum LLJMIHMCKDJ
	{
		[Token(Token = "0x40046E0")]
		ADD,
		[Token(Token = "0x40046E1")]
		REFRESH,
		[Token(Token = "0x40046E2")]
		LEVELUP
	}

	[Token(Token = "0x200064A")]
	private sealed class JHBIKJLHGAA : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x40046E3")]
		[FieldOffset(Offset = "0x8")]
		internal LevelLuckyDrawBox GADHAMJEKIM;

		[Token(Token = "0x40046E4")]
		[FieldOffset(Offset = "0xC")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x40046E5")]
		[FieldOffset(Offset = "0x10")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x40046E6")]
		[FieldOffset(Offset = "0x14")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x17000307")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002741")]
			[Address(RVA = "0x24B8358", Offset = "0x24B8358", VA = "0x24B8358", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000308")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002742")]
			[Address(RVA = "0x24B8360", Offset = "0x24B8360", VA = "0x24B8360", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600273F")]
		[Address(RVA = "0x24B5BC8", Offset = "0x24B5BC8", VA = "0x24B5BC8")]
		public JHBIKJLHGAA()
		{
		}

		[Token(Token = "0x6002740")]
		[Address(RVA = "0x24B8164", Offset = "0x24B8164", VA = "0x24B8164", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002743")]
		[Address(RVA = "0x24B8368", Offset = "0x24B8368", VA = "0x24B8368", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002744")]
		[Address(RVA = "0x24B837C", Offset = "0x24B837C", VA = "0x24B837C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200064B")]
	private sealed class KNFFCKJBHCN : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x40046E7")]
		[FieldOffset(Offset = "0x8")]
		internal float NMGBKDGFEFA;

		[Token(Token = "0x40046E8")]
		[FieldOffset(Offset = "0xC")]
		internal LevelLuckyDrawBox GADHAMJEKIM;

		[Token(Token = "0x40046E9")]
		[FieldOffset(Offset = "0x10")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x40046EA")]
		[FieldOffset(Offset = "0x14")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x40046EB")]
		[FieldOffset(Offset = "0x18")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x17000309")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002747")]
			[Address(RVA = "0x24B861C", Offset = "0x24B861C", VA = "0x24B861C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700030A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002748")]
			[Address(RVA = "0x24B8624", Offset = "0x24B8624", VA = "0x24B8624", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002745")]
		[Address(RVA = "0x24B5BD0", Offset = "0x24B5BD0", VA = "0x24B5BD0")]
		public KNFFCKJBHCN()
		{
		}

		[Token(Token = "0x6002746")]
		[Address(RVA = "0x24B8404", Offset = "0x24B8404", VA = "0x24B8404", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002749")]
		[Address(RVA = "0x24B862C", Offset = "0x24B862C", VA = "0x24B862C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600274A")]
		[Address(RVA = "0x24B8640", Offset = "0x24B8640", VA = "0x24B8640", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40046CE")]
	[FieldOffset(Offset = "0x74")]
	private Transform ECAIILDGOJI;

	[Token(Token = "0x40046CF")]
	[FieldOffset(Offset = "0x78")]
	public Collider Trigger;

	[Token(Token = "0x40046D0")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject Model;

	[Token(Token = "0x40046D1")]
	[FieldOffset(Offset = "0x80")]
	public GameObject UsingEffect;

	[Token(Token = "0x40046D2")]
	[FieldOffset(Offset = "0x84")]
	public Transform LevelEffect;

	[Token(Token = "0x40046D3")]
	[FieldOffset(Offset = "0x88")]
	private GameObject BKFECPOCPMK;

	[Token(Token = "0x40046D4")]
	[FieldOffset(Offset = "0x8C")]
	private GameObject GPMAABMKMHH;

	[Token(Token = "0x40046D5")]
	[FieldOffset(Offset = "0x90")]
	private ResourceID ECMDOGIELGO;

	[Token(Token = "0x40046D6")]
	[FieldOffset(Offset = "0x94")]
	private uint ILGECLEFCCO;

	[Token(Token = "0x40046D7")]
	[FieldOffset(Offset = "0x98")]
	private uint HOOGDPKIDDH;

	[Token(Token = "0x40046D8")]
	[FieldOffset(Offset = "0x9C")]
	private bool EPHLFGLPNOM;

	[Token(Token = "0x40046D9")]
	[FieldOffset(Offset = "0x9D")]
	private bool AMMBPDCKHMK;

	[Token(Token = "0x40046DA")]
	[FieldOffset(Offset = "0xA0")]
	private List<FBKJDCGPPIO> NNJDEKAGDEE;

	[Token(Token = "0x40046DB")]
	[FieldOffset(Offset = "0xA4")]
	private uint OAEIGIAIIBN;

	[Token(Token = "0x40046DC")]
	[FieldOffset(Offset = "0xA8")]
	private bool _003CMFPIGJGGCHD_003Ek__BackingField;

	[Token(Token = "0x40046DD")]
	[FieldOffset(Offset = "0xAC")]
	private int GBLIIHINKIB;

	[Token(Token = "0x40046DE")]
	[FieldOffset(Offset = "0xB0")]
	private bool MHGGGMKPLPE;

	[Token(Token = "0x17000306")]
	public bool FOIGGKMIHKB
	{
		[Token(Token = "0x600271E")]
		[Address(RVA = "0x24B4974", Offset = "0x24B4974", VA = "0x24B4974")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600271F")]
		[Address(RVA = "0x24B497C", Offset = "0x24B497C", VA = "0x24B497C")]
		set
		{
		}
	}

	[Token(Token = "0x600271D")]
	[Address(RVA = "0x24B48E0", Offset = "0x24B48E0", VA = "0x24B48E0")]
	public LevelLuckyDrawBox()
	{
	}

	[Token(Token = "0x6002720")]
	[Address(RVA = "0x24B4984", Offset = "0x24B4984", VA = "0x24B4984")]
	public List<FBKJDCGPPIO> GetCurrentBoxItems()
	{
		return null;
	}

	[Token(Token = "0x6002721")]
	[Address(RVA = "0x24B49DC", Offset = "0x24B49DC", VA = "0x24B49DC")]
	public uint GetCurrentLevel()
	{
		return default(uint);
	}

	[Token(Token = "0x6002722")]
	[Address(RVA = "0x24B4A34", Offset = "0x24B4A34", VA = "0x24B4A34")]
	public uint GetBuyCount()
	{
		return default(uint);
	}

	[Token(Token = "0x6002723")]
	[Address(RVA = "0x24B4A8C", Offset = "0x24B4A8C", VA = "0x24B4A8C")]
	public int GetNextLevelUpTimeMs()
	{
		return default(int);
	}

	[Token(Token = "0x6002724")]
	[Address(RVA = "0x24B4AE4", Offset = "0x24B4AE4", VA = "0x24B4AE4", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002725")]
	[Address(RVA = "0x24B4B88", Offset = "0x24B4B88", VA = "0x24B4B88", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6002726")]
	[Address(RVA = "0x24B4BF4", Offset = "0x24B4BF4", VA = "0x24B4BF4", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6002727")]
	[Address(RVA = "0x24B4D80", Offset = "0x24B4D80", VA = "0x24B4D80", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002728")]
	[Address(RVA = "0x24B4DD8", Offset = "0x24B4DD8", VA = "0x24B4DD8")]
	private void EJMKPJLKGCC(byte JGLJDJFHPBO, byte DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6002729")]
	[Address(RVA = "0x24B51DC", Offset = "0x24B51DC", VA = "0x24B51DC")]
	private void PBLABLJBDNJ(uint JGLJDJFHPBO, uint DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600272A")]
	[Address(RVA = "0x24B535C", Offset = "0x24B535C", VA = "0x24B535C")]
	private void BEIALBNKPDF(bool ANFGFJEPMDG)
	{
	}

	[Token(Token = "0x600272B")]
	[Address(RVA = "0x24B5A00", Offset = "0x24B5A00", VA = "0x24B5A00")]
	private IEnumerator DPDOCBNBIDI()
	{
		return null;
	}

	[Token(Token = "0x600272C")]
	[Address(RVA = "0x24B5ACC", Offset = "0x24B5ACC", VA = "0x24B5ACC")]
	private IEnumerator MACDJGIBJOJ(float NMGBKDGFEFA)
	{
		return null;
	}

	[Token(Token = "0x600272D")]
	[Address(RVA = "0x24B5BD8", Offset = "0x24B5BD8", VA = "0x24B5BD8", Slot = "23")]
	protected override void OnUpdateVisibleStateByStreamer(Vector3 MKGCDPNKMOB, Vector3 OANAHFHPBNB)
	{
	}

	[Token(Token = "0x600272E")]
	[Address(RVA = "0x24B607C", Offset = "0x24B607C", VA = "0x24B607C")]
	private void KMJODBHMEGM()
	{
	}

	[Token(Token = "0x600272F")]
	[Address(RVA = "0x24B5D70", Offset = "0x24B5D70", VA = "0x24B5D70")]
	private void IDHCNOKDHOH(bool ODOEHEHNJOG)
	{
	}

	[Token(Token = "0x6002730")]
	[Address(RVA = "0x24B6680", Offset = "0x24B6680", VA = "0x24B6680", Slot = "30")]
	public override void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002731")]
	[Address(RVA = "0x24B6C7C", Offset = "0x24B6C7C", VA = "0x24B6C7C", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002732")]
	[Address(RVA = "0x24B7748", Offset = "0x24B7748", VA = "0x24B7748")]
	private void ADIFBCHJPCA(List<FJOPCENPAFA> OFAJFDOFAJH)
	{
	}

	[Token(Token = "0x6002733")]
	[Address(RVA = "0x24B4F44", Offset = "0x24B4F44", VA = "0x24B4F44")]
	private void EOOIHIEGLBE()
	{
	}

	[Token(Token = "0x6002734")]
	[Address(RVA = "0x24B6C18", Offset = "0x24B6C18", VA = "0x24B6C18")]
	public bool IsSomeoneUsing()
	{
		return default(bool);
	}

	[Token(Token = "0x6002735")]
	[Address(RVA = "0x24B7A58", Offset = "0x24B7A58", VA = "0x24B7A58")]
	public void OnLocalPlayerEnter()
	{
	}

	[Token(Token = "0x6002736")]
	[Address(RVA = "0x24B7C80", Offset = "0x24B7C80", VA = "0x24B7C80")]
	public void OnLocalPlayerExit()
	{
	}

	[Token(Token = "0x6002737")]
	[Address(RVA = "0x24B7E64", Offset = "0x24B7E64", VA = "0x24B7E64")]
	public void StopUse()
	{
	}

	[Token(Token = "0x6002738")]
	[Address(RVA = "0x24B63F0", Offset = "0x24B63F0", VA = "0x24B63F0")]
	private void AKOEDIJANFD()
	{
	}

	[Token(Token = "0x6002739")]
	[Address(RVA = "0x24B8108", Offset = "0x24B8108", VA = "0x24B8108")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x600273A")]
	[Address(RVA = "0x24B8110", Offset = "0x24B8110", VA = "0x24B8110")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x600273B")]
	[Address(RVA = "0x24B8118", Offset = "0x24B8118", VA = "0x24B8118")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x600273C")]
	[Address(RVA = "0x24B8120", Offset = "0x24B8120", VA = "0x24B8120")]
	public void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	[Token(Token = "0x600273D")]
	[Address(RVA = "0x24B8154", Offset = "0x24B8154", VA = "0x24B8154")]
	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	[Token(Token = "0x600273E")]
	[Address(RVA = "0x24B815C", Offset = "0x24B815C", VA = "0x24B815C")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
