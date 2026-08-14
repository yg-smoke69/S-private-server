using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B11")]
internal class BountyWaitingBoss : AttackableEntity
{
	[Token(Token = "0x2000B12")]
	private enum BOSSHPPhase
	{
		[Token(Token = "0x4005FAC")]
		Phase_First = 1,
		[Token(Token = "0x4005FAD")]
		Phase_Second,
		[Token(Token = "0x4005FAE")]
		Phase_Third,
		[Token(Token = "0x4005FAF")]
		Phase_Fourth
	}

	[Token(Token = "0x2000B13")]
	private sealed class _003CSelfTakeDamage_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005FB0")]
		[FieldOffset(Offset = "0x8")]
		internal BountyWaitingBoss _0024this;

		[Token(Token = "0x4005FB1")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4005FB2")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4005FB3")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170006DB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005517")]
			[Address(RVA = "0x14B226C", Offset = "0x14B226C", VA = "0x14B226C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006DC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005518")]
			[Address(RVA = "0x14B2274", Offset = "0x14B2274", VA = "0x14B2274", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005515")]
		[Address(RVA = "0x14B20D8", Offset = "0x14B20D8", VA = "0x14B20D8")]
		public _003CSelfTakeDamage_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6005516")]
		[Address(RVA = "0x14B20E0", Offset = "0x14B20E0", VA = "0x14B20E0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005519")]
		[Address(RVA = "0x14B227C", Offset = "0x14B227C", VA = "0x14B227C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600551A")]
		[Address(RVA = "0x14B2290", Offset = "0x14B2290", VA = "0x14B2290", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000B14")]
	private sealed class _003CAttackUpdate_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005FB4")]
		[FieldOffset(Offset = "0x8")]
		internal BountyWaitingBoss _0024this;

		[Token(Token = "0x4005FB5")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4005FB6")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4005FB7")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170006DD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600551D")]
			[Address(RVA = "0x14B202C", Offset = "0x14B202C", VA = "0x14B202C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006DE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600551E")]
			[Address(RVA = "0x14B2034", Offset = "0x14B2034", VA = "0x14B2034", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600551B")]
		[Address(RVA = "0x14B1C60", Offset = "0x14B1C60", VA = "0x14B1C60")]
		public _003CAttackUpdate_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600551C")]
		[Address(RVA = "0x14B1C68", Offset = "0x14B1C68", VA = "0x14B1C68", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600551F")]
		[Address(RVA = "0x14B203C", Offset = "0x14B203C", VA = "0x14B203C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005520")]
		[Address(RVA = "0x14B2050", Offset = "0x14B2050", VA = "0x14B2050", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005F8E")]
	[FieldOffset(Offset = "0x48")]
	public Material PhaseMaterial;

	[Token(Token = "0x4005F8F")]
	[FieldOffset(Offset = "0x4C")]
	public List<Color> PhaseColor;

	[Token(Token = "0x4005F90")]
	[FieldOffset(Offset = "0x50")]
	public GameObject NPCRoot;

	[Token(Token = "0x4005F91")]
	[FieldOffset(Offset = "0x54")]
	public GameObject BossMeshRoot;

	[Token(Token = "0x4005F92")]
	[FieldOffset(Offset = "0x58")]
	public Transform CoreTransform;

	[Token(Token = "0x4005F93")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject ShiledEffectRoot;

	[Token(Token = "0x4005F94")]
	[FieldOffset(Offset = "0x60")]
	public GameObject CoreEffectRoot;

	[Token(Token = "0x4005F95")]
	[FieldOffset(Offset = "0x64")]
	public GameObject PhaseSwtichBodyEffectRoot;

	[Token(Token = "0x4005F96")]
	[FieldOffset(Offset = "0x68")]
	public Animator BossAnimator;

	[Token(Token = "0x4005F97")]
	[FieldOffset(Offset = "0x6C")]
	public int MAXHP;

	[Token(Token = "0x4005F98")]
	[FieldOffset(Offset = "0x70")]
	public float SecondPhaseBeginHPRat;

	[Token(Token = "0x4005F99")]
	[FieldOffset(Offset = "0x74")]
	public float ThirdPhaseBeginHPRat;

	[Token(Token = "0x4005F9A")]
	[FieldOffset(Offset = "0x78")]
	public float FourthPhaseBeginHPRat;

	[Token(Token = "0x4005F9B")]
	[FieldOffset(Offset = "0x7C")]
	public float BaseAttackDelta;

	[Token(Token = "0x4005F9C")]
	[FieldOffset(Offset = "0x80")]
	public BossRocket RocketTemplate;

	[Token(Token = "0x4005F9D")]
	[FieldOffset(Offset = "0x84")]
	public List<BossRocketLauncher> RocketLauncher;

	[Token(Token = "0x4005F9E")]
	[FieldOffset(Offset = "0x88")]
	public BossRocket CannonTemplate;

	[Token(Token = "0x4005F9F")]
	[FieldOffset(Offset = "0x8C")]
	public List<BossRocketLauncher> CannonLauncher;

	[Token(Token = "0x4005FA0")]
	[FieldOffset(Offset = "0x90")]
	public float BossSelfDamageHPRate;

	[Token(Token = "0x4005FA1")]
	[FieldOffset(Offset = "0x94")]
	public float NormalDamageHPRate;

	[Token(Token = "0x4005FA2")]
	[FieldOffset(Offset = "0x98")]
	public float WeakPointDamageHPRate;

	[Token(Token = "0x4005FA3")]
	[FieldOffset(Offset = "0x9C")]
	private BOSSHPPhase m_CurPhase;

	[Token(Token = "0x4005FA4")]
	[FieldOffset(Offset = "0xA0")]
	private int m_CurHP;

	[Token(Token = "0x4005FA5")]
	[FieldOffset(Offset = "0xA4")]
	private Coroutine m_AttackCoroutine;

	[Token(Token = "0x4005FA6")]
	[FieldOffset(Offset = "0xA8")]
	private float m_CurBaseAttackDelta;

	[Token(Token = "0x4005FA7")]
	[FieldOffset(Offset = "0xAC")]
	private bool m_IsRokcetAttackPhase;

	[Token(Token = "0x4005FA8")]
	[FieldOffset(Offset = "0xAD")]
	private bool m_IsCannonAttackPhase;

	[Token(Token = "0x4005FA9")]
	[FieldOffset(Offset = "0xB0")]
	private LineRenderer[] m_LightEffects;

	[Token(Token = "0x4005FAA")]
	[FieldOffset(Offset = "0xB4")]
	private bool m_IsGod;

	[Token(Token = "0x170006DA")]
	private int CurHP
	{
		[Token(Token = "0x6005500")]
		[Address(RVA = "0x2ED9014", Offset = "0x2ED9014", VA = "0x2ED9014")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005501")]
		[Address(RVA = "0x2ED901C", Offset = "0x2ED901C", VA = "0x2ED901C")]
		set
		{
		}
	}

	[Token(Token = "0x60054FF")]
	[Address(RVA = "0x2ED8F30", Offset = "0x2ED8F30", VA = "0x2ED8F30")]
	public BountyWaitingBoss()
	{
	}

	[Token(Token = "0x6005502")]
	[Address(RVA = "0x2ED984C", Offset = "0x2ED984C", VA = "0x2ED984C", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6005503")]
	[Address(RVA = "0x2ED99A0", Offset = "0x2ED99A0", VA = "0x2ED99A0")]
	private void ActiveShiled(bool isActive)
	{
	}

	[Token(Token = "0x6005504")]
	[Address(RVA = "0x2ED99FC", Offset = "0x2ED99FC", VA = "0x2ED99FC", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6005505")]
	[Address(RVA = "0x2ED9A04", Offset = "0x2ED9A04", VA = "0x2ED9A04")]
	public void Active()
	{
	}

	[Token(Token = "0x6005506")]
	[Address(RVA = "0x2ED9E28", Offset = "0x2ED9E28", VA = "0x2ED9E28")]
	private void ChangeMaterialColor(Color color)
	{
	}

	[Token(Token = "0x6005507")]
	[Address(RVA = "0x2EDA0BC", Offset = "0x2EDA0BC", VA = "0x2EDA0BC", Slot = "54")]
	public override void TakeDamage(ELMGJKHIIAA damageInfo, [Optional] MKFEKBKJCKE damagerWeaponDynamicInfo, [Optional] List<float> checkParams, uint vehicleDataID = 0u)
	{
	}

	[Token(Token = "0x6005508")]
	[Address(RVA = "0x2EDA128", Offset = "0x2EDA128", VA = "0x2EDA128")]
	public void SimpleTakeDamage(int damage, int weaponDataID = -1, DBNMCJLEFJI hitColliderType = DBNMCJLEFJI.UAV)
	{
	}

	[Token(Token = "0x6005509")]
	[Address(RVA = "0x2EDA684", Offset = "0x2EDA684", VA = "0x2EDA684", Slot = "58")]
	protected override void OnDead()
	{
	}

	[Token(Token = "0x600550A")]
	[Address(RVA = "0x2ED908C", Offset = "0x2ED908C", VA = "0x2ED908C")]
	private void EndCurPhase()
	{
	}

	[Token(Token = "0x600550B")]
	[Address(RVA = "0x2ED9090", Offset = "0x2ED9090", VA = "0x2ED9090")]
	private void GotoNextPhase()
	{
	}

	[Token(Token = "0x600550C")]
	[Address(RVA = "0x2EDA038", Offset = "0x2EDA038", VA = "0x2EDA038")]
	private IEnumerator SelfTakeDamage()
	{
		return null;
	}

	[Token(Token = "0x600550D")]
	[Address(RVA = "0x2ED9DA4", Offset = "0x2ED9DA4", VA = "0x2ED9DA4")]
	private IEnumerator AttackUpdate()
	{
		return null;
	}

	[Token(Token = "0x600550E")]
	[Address(RVA = "0x2EDA68C", Offset = "0x2EDA68C", VA = "0x2EDA68C")]
	private void Fire(List<BossRocketLauncher> launcers, GameObject rocketTemplate)
	{
	}

	[Token(Token = "0x600550F")]
	[Address(RVA = "0x2EDAAA0", Offset = "0x2EDAAA0", VA = "0x2EDAAA0")]
	public void DebugFire()
	{
	}

	[Token(Token = "0x6005510")]
	[Address(RVA = "0x2EDAB10", Offset = "0x2EDAB10", VA = "0x2EDAB10")]
	public void ResetBoss()
	{
	}

	[Token(Token = "0x6005511")]
	[Address(RVA = "0x2EDAB44", Offset = "0x2EDAB44", VA = "0x2EDAB44")]
	private void _003CActive_003Em__0()
	{
	}

	[Token(Token = "0x6005512")]
	[Address(RVA = "0x2EDAB58", Offset = "0x2EDAB58", VA = "0x2EDAB58")]
	private void _003CGotoNextPhase_003Em__1()
	{
	}

	[Token(Token = "0x6005513")]
	[Address(RVA = "0x2EDAB98", Offset = "0x2EDAB98", VA = "0x2EDAB98")]
	private void _003CGotoNextPhase_003Em__2()
	{
	}

	[Token(Token = "0x6005514")]
	[Address(RVA = "0x2EDABD8", Offset = "0x2EDABD8", VA = "0x2EDABD8")]
	private void _003CGotoNextPhase_003Em__3()
	{
	}
}
