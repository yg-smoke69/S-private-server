using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x200066F")]
internal abstract class LevelObjectSpawnedAttackable : LevelObjectSpawned, _Attribute
{
	[Token(Token = "0x40047DE")]
	[FieldOffset(Offset = "0x9C")]
	private bool _003CPCDBNEJIJGE_003Ek__BackingField;

	[Token(Token = "0x40047DF")]
	[FieldOffset(Offset = "0xA0")]
	private Collider _003CINICDNFOFJB_003Ek__BackingField;

	[Token(Token = "0x1700032D")]
	public abstract int JLCCLJCEDIL
	{
		[Token(Token = "0x60028F2")]
		get;
	}

	[Token(Token = "0x1700032E")]
	public bool NPFKJJDEIEG
	{
		[Token(Token = "0x60028F7")]
		[Address(RVA = "0x24CFA70", Offset = "0x24CFA70", VA = "0x24CFA70", Slot = "51")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60028F8")]
		[Address(RVA = "0x24CF928", Offset = "0x24CF928", VA = "0x24CF928")]
		private set
		{
		}
	}

	[Token(Token = "0x1700032F")]
	public Collider ADMPENNANLN
	{
		[Token(Token = "0x60028FE")]
		[Address(RVA = "0x24CFCA0", Offset = "0x24CFCA0", VA = "0x24CFCA0", Slot = "57")]
		get
		{
			return null;
		}
		[Token(Token = "0x60028FF")]
		[Address(RVA = "0x24CFCA8", Offset = "0x24CFCA8", VA = "0x24CFCA8", Slot = "58")]
		set
		{
		}
	}

	[Token(Token = "0x60028F1")]
	[Address(RVA = "0x24B900C", Offset = "0x24B900C", VA = "0x24B900C")]
	protected LevelObjectSpawnedAttackable()
	{
	}

	[Token(Token = "0x60028F3")]
	[Address(RVA = "0x24CF78C", Offset = "0x24CF78C", VA = "0x24CF78C", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60028F4")]
	[Address(RVA = "0x24CF8C0", Offset = "0x24CF8C0", VA = "0x24CF8C0", Slot = "40")]
	protected override void LJAGPONMADJ()
	{
	}

	[Token(Token = "0x60028F5")]
	[Address(RVA = "0x24B9F90", Offset = "0x24B9F90", VA = "0x24B9F90", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x60028F6")]
	[Address(RVA = "0x24CF930", Offset = "0x24CF930", VA = "0x24CF930")]
	protected void KAMKGHOICOE()
	{
	}

	[Token(Token = "0x60028F9")]
	[Address(RVA = "0x24CFA78", Offset = "0x24CFA78", VA = "0x24CFA78", Slot = "65")]
	public virtual uint GetAttackableID()
	{
		return default(uint);
	}

	[Token(Token = "0x60028FA")]
	[Address(RVA = "0x24CFAD0", Offset = "0x24CFAD0", VA = "0x24CFAD0", Slot = "66")]
	public virtual JADJBFDFEHA GetAttackableType()
	{
		return default(JADJBFDFEHA);
	}

	[Token(Token = "0x60028FB")]
	[Address(RVA = "0x24CFB28", Offset = "0x24CFB28", VA = "0x24CFB28", Slot = "67")]
	public virtual float GetAttackableRadius()
	{
		return default(float);
	}

	[Token(Token = "0x60028FC")]
	[Address(RVA = "0x24CFB80", Offset = "0x24CFB80", VA = "0x24CFB80", Slot = "68")]
	public virtual Vector3 GetAttackableCenterWS()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60028FD")]
	[Address(RVA = "0x24CFC10", Offset = "0x24CFC10", VA = "0x24CFC10", Slot = "69")]
	public virtual Vector3 GetHitDamagePos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002900")]
	[Address(RVA = "0x24CFCB0", Offset = "0x24CFCB0", VA = "0x24CFCB0", Slot = "70")]
	public virtual bool NeedAssit()
	{
		return default(bool);
	}

	[Token(Token = "0x6002901")]
	[Address(RVA = "0x24CFD08", Offset = "0x24CFD08", VA = "0x24CFD08", Slot = "60")]
	public bool CanAssitByWeapon(Player DEKAHNJALPI, GPBDEDFKJNA LPGPKFMGCBG)
	{
		return default(bool);
	}

	[Token(Token = "0x6002902")]
	[Address(RVA = "0x24CFD84", Offset = "0x24CFD84", VA = "0x24CFD84", Slot = "71")]
	public virtual bool IsSameTeamWithPlayerID(IHAAMHPPLMG FGFGBHLEONO)
	{
		return default(bool);
	}

	[Token(Token = "0x6002903")]
	[Address(RVA = "0x24CFF24", Offset = "0x24CFF24", VA = "0x24CFF24")]
	protected CHDLJFJCPFN CCPAJNBFGOE()
	{
		return null;
	}

	[Token(Token = "0x6002904")]
	[Address(RVA = "0x24D005C", Offset = "0x24D005C", VA = "0x24D005C", Slot = "72")]
	public virtual void TakeDamageByVehicle(int JLKLMFHFHFF, IHAAMHPPLMG KAEHJEGFKBL, DBNMCJLEFJI JPLHIDNDING, int BOEIBGAABDL)
	{
	}

	[Token(Token = "0x6002905")]
	[Address(RVA = "0x24D0210", Offset = "0x24D0210", VA = "0x24D0210", Slot = "73")]
	public virtual void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint GGIDKOBOJBB = 0u)
	{
	}

	[Token(Token = "0x6002906")]
	[Address(RVA = "0x24D040C", Offset = "0x24D040C", VA = "0x24D040C", Slot = "38")]
	public override void TakeHealing(int EDEOPLNOGPP, IHAAMHPPLMG ONPMGNIIMJD, int OIFJAJJFBLK, [Optional] Vector3 NJMFBKNHMBP, [Optional] Vector3 DOBOBMFMKBJ, [Optional] List<float> NBKBEBFNDBE)
	{
	}

	[Token(Token = "0x6002907")]
	[Address(RVA = "0x24D04E0", Offset = "0x24D04E0", VA = "0x24D04E0", Slot = "46")]
	private GameObject COW_002EGamePlay_002EIAttackableEntity_002Eget_gameObject()
	{
		return null;
	}

	[Token(Token = "0x6002908")]
	[Address(RVA = "0x24D0544", Offset = "0x24D0544", VA = "0x24D0544")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x6002909")]
	[Address(RVA = "0x24D054C", Offset = "0x24D054C", VA = "0x24D054C")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x600290A")]
	[Address(RVA = "0x24D0554", Offset = "0x24D0554", VA = "0x24D0554")]
	public void _003C_003EiFixBaseProxy_LJAGPONMADJ()
	{
	}

	[Token(Token = "0x600290B")]
	[Address(RVA = "0x24D0558", Offset = "0x24D0558", VA = "0x24D0558")]
	public void _003C_003EiFixBaseProxy_TakeHealing(int P0, IHAAMHPPLMG P1, int P2, Vector3 P3, Vector3 P4, List<float> P5)
	{
	}
}
