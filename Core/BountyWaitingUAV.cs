using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B18")]
internal class BountyWaitingUAV : AttackableEntity
{
	[Token(Token = "0x2000B19")]
	private sealed class _003COnDead_003Ec__AnonStorey1
	{
		[Token(Token = "0x4005FDB")]
		[FieldOffset(Offset = "0x8")]
		internal Object ob;

		[Token(Token = "0x6005544")]
		[Address(RVA = "0x14B5F54", Offset = "0x14B5F54", VA = "0x14B5F54")]
		public _003COnDead_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6005545")]
		[Address(RVA = "0x14B6DA0", Offset = "0x14B6DA0", VA = "0x14B6DA0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2000B1A")]
	private sealed class _003CRandomTakeDamageSelf_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005FDC")]
		[FieldOffset(Offset = "0x8")]
		internal BountyWaitingUAV _0024this;

		[Token(Token = "0x4005FDD")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4005FDE")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4005FDF")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170006E4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005548")]
			[Address(RVA = "0x14B7048", Offset = "0x14B7048", VA = "0x14B7048", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006E5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005549")]
			[Address(RVA = "0x14B7050", Offset = "0x14B7050", VA = "0x14B7050", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005546")]
		[Address(RVA = "0x14B69AC", Offset = "0x14B69AC", VA = "0x14B69AC")]
		public _003CRandomTakeDamageSelf_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6005547")]
		[Address(RVA = "0x14B6ECC", Offset = "0x14B6ECC", VA = "0x14B6ECC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600554A")]
		[Address(RVA = "0x14B7058", Offset = "0x14B7058", VA = "0x14B7058", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600554B")]
		[Address(RVA = "0x14B706C", Offset = "0x14B706C", VA = "0x14B706C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005FC6")]
	[FieldOffset(Offset = "0x48")]
	public Action<BountyWaitingUAV> _OnPostDead;

	[Token(Token = "0x4005FC7")]
	[FieldOffset(Offset = "0x4C")]
	public AnimationCurve MoveCurve;

	[Token(Token = "0x4005FC8")]
	[FieldOffset(Offset = "0x50")]
	public int MAXHP;

	[Token(Token = "0x4005FC9")]
	[FieldOffset(Offset = "0x54")]
	public float MAXFlyTime;

	[Token(Token = "0x4005FCA")]
	[FieldOffset(Offset = "0x58")]
	public float SelfTakeDamageRat;

	[Token(Token = "0x4005FCB")]
	[FieldOffset(Offset = "0x5C")]
	public int m_HP;

	[Token(Token = "0x4005FCC")]
	[FieldOffset(Offset = "0x60")]
	public Transform FireEffect;

	[Token(Token = "0x4005FCD")]
	[FieldOffset(Offset = "0x64")]
	public int Damage;

	[Token(Token = "0x4005FCE")]
	[FieldOffset(Offset = "0x68")]
	public float DamageDuration;

	[Token(Token = "0x4005FCF")]
	[FieldOffset(Offset = "0x6C")]
	public float ImpactEffectSpawnDuration;

	[Token(Token = "0x4005FD0")]
	[FieldOffset(Offset = "0x70")]
	public float ChangeDamageTargetDuration;

	[Token(Token = "0x4005FD1")]
	[FieldOffset(Offset = "0x74")]
	public bool NoRespawn;

	[Token(Token = "0x4005FD2")]
	[FieldOffset(Offset = "0x78")]
	private float m_LastDamageTime;

	[Token(Token = "0x4005FD3")]
	[FieldOffset(Offset = "0x7C")]
	private float m_LastChooseDamageTargetTime;

	[Token(Token = "0x4005FD4")]
	[FieldOffset(Offset = "0x80")]
	private bool m_IsDamageToLocalPlayer;

	[Token(Token = "0x4005FD5")]
	[FieldOffset(Offset = "0x81")]
	private bool m_IsUpdateMove;

	[Token(Token = "0x4005FD6")]
	[FieldOffset(Offset = "0x84")]
	private float m_ActiveTime;

	[Token(Token = "0x4005FD7")]
	[FieldOffset(Offset = "0x88")]
	private Coroutine m_RandomDamgeCor;

	[Token(Token = "0x4005FD8")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 m_StartPos;

	[Token(Token = "0x4005FD9")]
	[FieldOffset(Offset = "0x98")]
	private Vector3 m_EndPos;

	[Token(Token = "0x4005FDA")]
	[FieldOffset(Offset = "0xA4")]
	private float m_LastHitEffectSpawnTime;

	[Token(Token = "0x6005536")]
	[Address(RVA = "0x14B535C", Offset = "0x14B535C", VA = "0x14B535C")]
	public BountyWaitingUAV()
	{
	}

	[Token(Token = "0x6005537")]
	[Address(RVA = "0x14B5394", Offset = "0x14B5394", VA = "0x14B5394", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6005538")]
	[Address(RVA = "0x14B539C", Offset = "0x14B539C", VA = "0x14B539C", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6005539")]
	[Address(RVA = "0x14B53F8", Offset = "0x14B53F8", VA = "0x14B53F8", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA damageInfo, [Optional] MKFEKBKJCKE damagerWeaponDynamicInfo, [Optional] List<float> checkParams, uint vehicleDataID = 0u)
	{
	}

	[Token(Token = "0x600553A")]
	[Address(RVA = "0x14B5444", Offset = "0x14B5444", VA = "0x14B5444")]
	public void SimpleTakeDamage(int damage, int weaponDataID = -1)
	{
	}

	[Token(Token = "0x600553B")]
	[Address(RVA = "0x14B5830", Offset = "0x14B5830", VA = "0x14B5830")]
	public void OnSpawn(Vector3 spawnPos, Vector3 flyEndPos)
	{
	}

	[Token(Token = "0x600553C")]
	[Address(RVA = "0x14B5978", Offset = "0x14B5978", VA = "0x14B5978")]
	public void Active()
	{
	}

	[Token(Token = "0x600553D")]
	[Address(RVA = "0x14B5ABC", Offset = "0x14B5ABC", VA = "0x14B5ABC", Slot = "58")]
	protected override void OnDead()
	{
	}

	[Token(Token = "0x600553E")]
	[Address(RVA = "0x14B5F5C", Offset = "0x14B5F5C", VA = "0x14B5F5C")]
	private void Update()
	{
	}

	[Token(Token = "0x600553F")]
	[Address(RVA = "0x14B5A38", Offset = "0x14B5A38", VA = "0x14B5A38")]
	private IEnumerator RandomTakeDamageSelf()
	{
		return null;
	}

	[Token(Token = "0x6005540")]
	[Address(RVA = "0x14B69B4", Offset = "0x14B69B4", VA = "0x14B69B4")]
	private bool IsDamageSelf()
	{
		return default(bool);
	}

	[Token(Token = "0x6005541")]
	[Address(RVA = "0x14B5F94", Offset = "0x14B5F94", VA = "0x14B5F94")]
	private void UpdateMove()
	{
	}

	[Token(Token = "0x6005542")]
	[Address(RVA = "0x14B6114", Offset = "0x14B6114", VA = "0x14B6114")]
	private void UpdateRandomFire()
	{
	}

	[Token(Token = "0x6005543")]
	[Address(RVA = "0x14B6AA8", Offset = "0x14B6AA8", VA = "0x14B6AA8")]
	private void ChooseDamageTarget()
	{
	}
}
