using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000412")]
internal abstract class AttackableEntity : COWReplicationEntity, _Attribute
{
	[Token(Token = "0x4003AE6")]
	[FieldOffset(Offset = "0x40")]
	private bool FHMPKFMFEPM;

	[Token(Token = "0x4003AE7")]
	[FieldOffset(Offset = "0x44")]
	private Collider _003CINICDNFOFJB_003Ek__BackingField;

	[Token(Token = "0x170001C1")]
	public bool NPFKJJDEIEG
	{
		[Token(Token = "0x6001407")]
		[Address(RVA = "0x1141FB4", Offset = "0x1141FB4", VA = "0x1141FB4", Slot = "35")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001408")]
		[Address(RVA = "0x114200C", Offset = "0x114200C", VA = "0x114200C")]
		set
		{
		}
	}

	[Token(Token = "0x170001C2")]
	public Collider ADMPENNANLN
	{
		[Token(Token = "0x600140F")]
		[Address(RVA = "0x1142384", Offset = "0x1142384", VA = "0x1142384", Slot = "41")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001410")]
		[Address(RVA = "0x114238C", Offset = "0x114238C", VA = "0x114238C", Slot = "42")]
		set
		{
		}
	}

	[Token(Token = "0x6001406")]
	[Address(RVA = "0x1139C50", Offset = "0x1139C50", VA = "0x1139C50")]
	protected AttackableEntity()
	{
	}

	[Token(Token = "0x6001409")]
	[Address(RVA = "0x1142098", Offset = "0x1142098", VA = "0x1142098", Slot = "48")]
	public virtual Vector3 GetAttackableCenterWS()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600140A")]
	[Address(RVA = "0x1142128", Offset = "0x1142128", VA = "0x1142128", Slot = "49")]
	public virtual float GetAttackableRadius()
	{
		return default(float);
	}

	[Token(Token = "0x600140B")]
	[Address(RVA = "0x1142188", Offset = "0x1142188", VA = "0x1142188", Slot = "50")]
	public virtual Vector3 GetHitDamagePos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600140C")]
	[Address(RVA = "0x1142218", Offset = "0x1142218", VA = "0x1142218", Slot = "51")]
	public virtual bool NeedAssit()
	{
		return default(bool);
	}

	[Token(Token = "0x600140D")]
	[Address(RVA = "0x1142270", Offset = "0x1142270", VA = "0x1142270", Slot = "52")]
	public virtual bool CanAssitByWeapon(Player DEKAHNJALPI, GPBDEDFKJNA LPGPKFMGCBG)
	{
		return default(bool);
	}

	[Token(Token = "0x600140E")]
	[Address(RVA = "0x11422EC", Offset = "0x11422EC", VA = "0x11422EC", Slot = "53")]
	public virtual bool IsSameTeamWithPlayerID(IHAAMHPPLMG FGFGBHLEONO)
	{
		return default(bool);
	}

	[Token(Token = "0x6001411")]
	[Address(RVA = "0x1142394", Offset = "0x1142394", VA = "0x1142394", Slot = "54")]
	public virtual void TakeDamage(ELMGJKHIIAA JIIJIFKKCCB, [Optional] MKFEKBKJCKE OPINPCANMDE, [Optional] List<float> NBKBEBFNDBE, uint EMFANFHKAMM = 0u)
	{
	}

	[Token(Token = "0x6001412")]
	[Address(RVA = "0x114240C", Offset = "0x114240C", VA = "0x114240C", Slot = "55")]
	public virtual void TakeHealing(int EDEOPLNOGPP, IHAAMHPPLMG ONPMGNIIMJD, int OIFJAJJFBLK, [Optional] Vector3 NJMFBKNHMBP, [Optional] Vector3 DOBOBMFMKBJ, [Optional] List<float> NBKBEBFNDBE)
	{
	}

	[Token(Token = "0x6001413")]
	[Address(RVA = "0x11424E0", Offset = "0x11424E0", VA = "0x11424E0", Slot = "56")]
	public virtual bool IsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6001414")]
	[Address(RVA = "0x1142640", Offset = "0x1142640", VA = "0x1142640", Slot = "57")]
	public virtual bool IsStreamerVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6001415")]
	[Address(RVA = "0x1142698", Offset = "0x1142698", VA = "0x1142698", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6001416")]
	[Address(RVA = "0x11427CC", Offset = "0x11427CC", VA = "0x11427CC", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6001417")]
	[Address(RVA = "0x114283C", Offset = "0x114283C", VA = "0x114283C", Slot = "58")]
	protected virtual void OnDead()
	{
	}

	[Token(Token = "0x6001418")]
	[Address(RVA = "0x1142964", Offset = "0x1142964", VA = "0x1142964", Slot = "59")]
	public virtual uint GetAttackableID()
	{
		return default(uint);
	}

	[Token(Token = "0x6001419")]
	[Address(RVA = "0x11429BC", Offset = "0x11429BC", VA = "0x11429BC", Slot = "60")]
	public virtual JADJBFDFEHA GetAttackableType()
	{
		return default(JADJBFDFEHA);
	}

	[Token(Token = "0x600141A")]
	[Address(RVA = "0x1142A14", Offset = "0x1142A14", VA = "0x1142A14", Slot = "30")]
	private GameObject COW_002EGamePlay_002EIAttackableEntity_002Eget_gameObject()
	{
		return null;
	}

	[Token(Token = "0x600141B")]
	[Address(RVA = "0x1142A78", Offset = "0x1142A78", VA = "0x1142A78")]
	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x600141C")]
	[Address(RVA = "0x1142A80", Offset = "0x1142A80", VA = "0x1142A80")]
	public void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
