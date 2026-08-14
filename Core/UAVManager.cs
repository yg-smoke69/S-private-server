using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B1F")]
internal class UAVManager : MonoBehaviour
{
	[Token(Token = "0x2000B20")]
	private sealed class _003CSpawnUAVByTime_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005FF3")]
		[FieldOffset(Offset = "0x8")]
		internal UAVManager _0024this;

		[Token(Token = "0x4005FF4")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4005FF5")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4005FF6")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170006E7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005563")]
			[Address(RVA = "0x2648B34", Offset = "0x2648B34", VA = "0x2648B34", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006E8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005564")]
			[Address(RVA = "0x2648B3C", Offset = "0x2648B3C", VA = "0x2648B3C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005561")]
		[Address(RVA = "0x2648818", Offset = "0x2648818", VA = "0x2648818")]
		public _003CSpawnUAVByTime_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6005562")]
		[Address(RVA = "0x2648A00", Offset = "0x2648A00", VA = "0x2648A00", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005565")]
		[Address(RVA = "0x2648B44", Offset = "0x2648B44", VA = "0x2648B44", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005566")]
		[Address(RVA = "0x2648B58", Offset = "0x2648B58", VA = "0x2648B58", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000B21")]
	private sealed class _003CSpawnGroupUAVByTime_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005FF7")]
		[FieldOffset(Offset = "0x8")]
		internal UAVManager _0024this;

		[Token(Token = "0x4005FF8")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4005FF9")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4005FFA")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170006E9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005569")]
			[Address(RVA = "0x2648954", Offset = "0x2648954", VA = "0x2648954", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006EA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600556A")]
			[Address(RVA = "0x264895C", Offset = "0x264895C", VA = "0x264895C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005567")]
		[Address(RVA = "0x2648820", Offset = "0x2648820", VA = "0x2648820")]
		public _003CSpawnGroupUAVByTime_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x6005568")]
		[Address(RVA = "0x2648828", Offset = "0x2648828", VA = "0x2648828", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600556B")]
		[Address(RVA = "0x2648964", Offset = "0x2648964", VA = "0x2648964", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600556C")]
		[Address(RVA = "0x2648978", Offset = "0x2648978", VA = "0x2648978", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005FE6")]
	[FieldOffset(Offset = "0xC")]
	public List<Transform> UAVSpawnPoint;

	[Token(Token = "0x4005FE7")]
	[FieldOffset(Offset = "0x10")]
	public List<Transform> UAVFlyEndPoint;

	[Token(Token = "0x4005FE8")]
	[FieldOffset(Offset = "0x14")]
	public List<Transform> GroupUAVSpawnPoint;

	[Token(Token = "0x4005FE9")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> GroupUAVEndPoint;

	[Token(Token = "0x4005FEA")]
	[FieldOffset(Offset = "0x1C")]
	public int UAVMaxCount;

	[Token(Token = "0x4005FEB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject UAVTemplate;

	[Token(Token = "0x4005FEC")]
	[FieldOffset(Offset = "0x24")]
	public GameObject UAVGroupTemplate;

	[Token(Token = "0x4005FED")]
	[FieldOffset(Offset = "0x28")]
	public float UAVGroupSpawnDelta;

	[Token(Token = "0x4005FEE")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject OilDrumRoot;

	[Token(Token = "0x4005FEF")]
	[FieldOffset(Offset = "0x30")]
	public GameObject NPCRoot;

	[Token(Token = "0x4005FF0")]
	[FieldOffset(Offset = "0x34")]
	private List<BountyWaitingUAV> m_AllUAV;

	[Token(Token = "0x4005FF1")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsActive;

	[Token(Token = "0x4005FF2")]
	[FieldOffset(Offset = "0x3C")]
	private int newUAVCount;

	[Token(Token = "0x170006E6")]
	public List<BountyWaitingUAV> AllUAV
	{
		[Token(Token = "0x6005557")]
		[Address(RVA = "0x2647C94", Offset = "0x2647C94", VA = "0x2647C94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005556")]
	[Address(RVA = "0x2647C00", Offset = "0x2647C00", VA = "0x2647C00")]
	public UAVManager()
	{
	}

	[Token(Token = "0x6005558")]
	[Address(RVA = "0x2647C9C", Offset = "0x2647C9C", VA = "0x2647C9C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005559")]
	[Address(RVA = "0x2647D38", Offset = "0x2647D38", VA = "0x2647D38")]
	private void Start()
	{
	}

	[Token(Token = "0x600555A")]
	[Address(RVA = "0x2647E18", Offset = "0x2647E18", VA = "0x2647E18")]
	public void StartSpawnUAV()
	{
	}

	[Token(Token = "0x600555B")]
	[Address(RVA = "0x2648034", Offset = "0x2648034", VA = "0x2648034")]
	private void SpawnUAV([Optional] BountyWaitingUAV deadUAV)
	{
	}

	[Token(Token = "0x600555C")]
	[Address(RVA = "0x2648350", Offset = "0x2648350", VA = "0x2648350")]
	private void SpawnGroup()
	{
	}

	[Token(Token = "0x600555D")]
	[Address(RVA = "0x2648694", Offset = "0x2648694", VA = "0x2648694")]
	public void StopAndKillAllUAV()
	{
	}

	[Token(Token = "0x600555E")]
	[Address(RVA = "0x2648734", Offset = "0x2648734", VA = "0x2648734")]
	private void OnUAVDead(BountyWaitingUAV deadUAV)
	{
	}

	[Token(Token = "0x600555F")]
	[Address(RVA = "0x2647F2C", Offset = "0x2647F2C", VA = "0x2647F2C")]
	private IEnumerator SpawnUAVByTime()
	{
		return null;
	}

	[Token(Token = "0x6005560")]
	[Address(RVA = "0x2647FB0", Offset = "0x2647FB0", VA = "0x2647FB0")]
	private IEnumerator SpawnGroupUAVByTime()
	{
		return null;
	}
}
