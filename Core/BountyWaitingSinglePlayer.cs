using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B15")]
internal class BountyWaitingSinglePlayer : Player
{
	[Token(Token = "0x2000B16")]
	private sealed class _003CCalcuFreeze_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005FBE")]
		[FieldOffset(Offset = "0x8")]
		internal BountyWaitingSinglePlayer _0024this;

		[Token(Token = "0x4005FBF")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4005FC0")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4005FC1")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170006E0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600552C")]
			[Address(RVA = "0x14B4FE8", Offset = "0x14B4FE8", VA = "0x14B4FE8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006E1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600552D")]
			[Address(RVA = "0x14B4FF0", Offset = "0x14B4FF0", VA = "0x14B4FF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600552A")]
		[Address(RVA = "0x14B4D84", Offset = "0x14B4D84", VA = "0x14B4D84")]
		public _003CCalcuFreeze_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600552B")]
		[Address(RVA = "0x14B4EE8", Offset = "0x14B4EE8", VA = "0x14B4EE8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600552E")]
		[Address(RVA = "0x14B4FF8", Offset = "0x14B4FF8", VA = "0x14B4FF8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600552F")]
		[Address(RVA = "0x14B500C", Offset = "0x14B500C", VA = "0x14B500C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000B17")]
	private sealed class _003CCoroutineUpdateHealing_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005FC2")]
		[FieldOffset(Offset = "0x8")]
		internal BountyWaitingSinglePlayer _0024this;

		[Token(Token = "0x4005FC3")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4005FC4")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4005FC5")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170006E2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005532")]
			[Address(RVA = "0x14B52B0", Offset = "0x14B52B0", VA = "0x14B52B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006E3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005533")]
			[Address(RVA = "0x14B52B8", Offset = "0x14B52B8", VA = "0x14B52B8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005530")]
		[Address(RVA = "0x14B4EE0", Offset = "0x14B4EE0", VA = "0x14B4EE0")]
		public _003CCoroutineUpdateHealing_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x6005531")]
		[Address(RVA = "0x14B5094", Offset = "0x14B5094", VA = "0x14B5094", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005534")]
		[Address(RVA = "0x14B52C0", Offset = "0x14B52C0", VA = "0x14B52C0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005535")]
		[Address(RVA = "0x14B52D4", Offset = "0x14B52D4", VA = "0x14B52D4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005FB8")]
	[FieldOffset(Offset = "0x998")]
	private bool m_IsInFreeze;

	[Token(Token = "0x4005FB9")]
	[FieldOffset(Offset = "0x99C")]
	private float m_FreezeTime;

	[Token(Token = "0x4005FBA")]
	[FieldOffset(Offset = "0x9A0")]
	private Coroutine m_FreezeCoroutine;

	[Token(Token = "0x4005FBB")]
	[FieldOffset(Offset = "0x9A4")]
	private float m_LastTakeDamageTime;

	[Token(Token = "0x4005FBC")]
	[FieldOffset(Offset = "0x9A8")]
	private GameObject m_FreezeEffect;

	[Token(Token = "0x4005FBD")]
	[FieldOffset(Offset = "0x9AC")]
	private Coroutine m_HealingCoroutine;

	[Token(Token = "0x170006DF")]
	private int LockHP
	{
		[Token(Token = "0x6005522")]
		[Address(RVA = "0x14B47DC", Offset = "0x14B47DC", VA = "0x14B47DC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6005521")]
	[Address(RVA = "0x14B4758", Offset = "0x14B4758", VA = "0x14B4758")]
	public BountyWaitingSinglePlayer()
	{
	}

	[Token(Token = "0x6005523")]
	[Address(RVA = "0x14B47E4", Offset = "0x14B47E4", VA = "0x14B47E4", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA damageInfo, [Optional] MKFEKBKJCKE damagerWeaponDynamicInfo, [Optional] List<float> checkParams, uint damagerVehicleID = 0u)
	{
	}

	[Token(Token = "0x6005524")]
	[Address(RVA = "0x14B48A8", Offset = "0x14B48A8", VA = "0x14B48A8")]
	public void TakeFreezeDamage(float freezeTime)
	{
	}

	[Token(Token = "0x6005525")]
	[Address(RVA = "0x14B4C2C", Offset = "0x14B4C2C", VA = "0x14B4C2C")]
	private void StopFreeze()
	{
	}

	[Token(Token = "0x6005526")]
	[Address(RVA = "0x14B4BA8", Offset = "0x14B4BA8", VA = "0x14B4BA8")]
	private IEnumerator CalcuFreeze()
	{
		return null;
	}

	[Token(Token = "0x6005527")]
	[Address(RVA = "0x14B4D8C", Offset = "0x14B4D8C", VA = "0x14B4D8C")]
	private void Update()
	{
	}

	[Token(Token = "0x6005528")]
	[Address(RVA = "0x14B4EA8", Offset = "0x14B4EA8", VA = "0x14B4EA8", Slot = "58")]
	protected override void OnDead()
	{
	}

	[Token(Token = "0x6005529")]
	[Address(RVA = "0x14B4E24", Offset = "0x14B4E24", VA = "0x14B4E24")]
	private IEnumerator CoroutineUpdateHealing()
	{
		return null;
	}
}
