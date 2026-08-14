using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000D03")]
internal abstract class SkateboardControllerBase : Entity, _Attribute, IConvertible
{
	[Token(Token = "0x400693A")]
	[FieldOffset(Offset = "0x34")]
	public Player Owner;

	[Token(Token = "0x400693B")]
	[FieldOffset(Offset = "0x38")]
	protected BCIGOPJHDPB CLCFBJIKGBN;

	[Token(Token = "0x400693C")]
	[FieldOffset(Offset = "0x3C")]
	protected bool KBJDLPBOEFK;

	[Token(Token = "0x400693D")]
	[FieldOffset(Offset = "0x40")]
	protected float JAHFHNOMFDK;

	[Token(Token = "0x400693E")]
	[FieldOffset(Offset = "0x44")]
	public Rigidbody RigidBody;

	[Token(Token = "0x400693F")]
	[FieldOffset(Offset = "0x48")]
	public Transform PlayerPos;

	[Token(Token = "0x4006940")]
	[FieldOffset(Offset = "0x4C")]
	public StatedTaggedTriggerDelegator WaterOrShoalDelegator;

	[Token(Token = "0x4006941")]
	[FieldOffset(Offset = "0x50")]
	public InRoomDelegator EnterRoomDelegator;

	[Token(Token = "0x4006942")]
	[FieldOffset(Offset = "0x54")]
	public GameObject[] LocalPlayerOnly;

	[Token(Token = "0x4006943")]
	[FieldOffset(Offset = "0x58")]
	private bool _003CEJLECCHIEJA_003Ek__BackingField;

	[Token(Token = "0x4006944")]
	[FieldOffset(Offset = "0x5C")]
	public float MaxSpeed;

	[Token(Token = "0x4006945")]
	[FieldOffset(Offset = "0x60")]
	protected GameObject GDBLFPJECOM;

	[Token(Token = "0x4006946")]
	[FieldOffset(Offset = "0x64")]
	protected Transform JACHIHIDAMB;

	[Token(Token = "0x4006947")]
	[FieldOffset(Offset = "0x68")]
	protected Transform ABDLLELHMEJ;

	[Token(Token = "0x4006948")]
	[FieldOffset(Offset = "0x6C")]
	private GameObject MGKKMNKPGFJ;

	[Token(Token = "0x4006949")]
	[FieldOffset(Offset = "0x70")]
	private GameObject CBGHPBPKIHO;

	[Token(Token = "0x400694A")]
	[FieldOffset(Offset = "0x74")]
	private AudioSource FHHDDFHAFHF;

	[Token(Token = "0x400694B")]
	[FieldOffset(Offset = "0x78")]
	private AudioSource ADAELALAHBL;

	[Token(Token = "0x400694C")]
	[FieldOffset(Offset = "0x7C")]
	private float CEIOMDOHCBN;

	[Token(Token = "0x400694D")]
	[FieldOffset(Offset = "0x80")]
	private bool _003CECACCHGPEMC_003Ek__BackingField;

	[Token(Token = "0x400694E")]
	[FieldOffset(Offset = "0x81")]
	private bool _003CFPJBDFLIMCC_003Ek__BackingField;

	[Token(Token = "0x400694F")]
	private const ForceMode IOLHIMJMLPO = 2;

	[Token(Token = "0x17000846")]
	public bool BLFIADFFLBO
	{
		[Token(Token = "0x6006307")]
		[Address(RVA = "0x1D7658C", Offset = "0x1D7658C", VA = "0x1D7658C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006308")]
		[Address(RVA = "0x1D77C3C", Offset = "0x1D77C3C", VA = "0x1D77C3C")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000847")]
	public abstract bool JCAPJNOALJN
	{
		[Token(Token = "0x600630A")]
		get;
	}

	[Token(Token = "0x17000848")]
	public bool NJHDBLDLGGI
	{
		[Token(Token = "0x600630B")]
		[Address(RVA = "0x1D77CC8", Offset = "0x1D77CC8", VA = "0x1D77CC8", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000849")]
	public bool EJKCDPECPDG
	{
		[Token(Token = "0x600630C")]
		[Address(RVA = "0x1D77D70", Offset = "0x1D77D70", VA = "0x1D77D70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600630D")]
		[Address(RVA = "0x1D77D78", Offset = "0x1D77D78", VA = "0x1D77D78")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700084A")]
	public bool FLJMEOHIJAO
	{
		[Token(Token = "0x600630E")]
		[Address(RVA = "0x1D77D80", Offset = "0x1D77D80", VA = "0x1D77D80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600630F")]
		[Address(RVA = "0x1D77D88", Offset = "0x1D77D88", VA = "0x1D77D88")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700084B")]
	public Action EKCKLLNLEEO
	{
		[Token(Token = "0x6006311")]
		[Address(RVA = "0x1D77D90", Offset = "0x1D77D90", VA = "0x1D77D90", Slot = "36")]
		set
		{
		}
	}

	[Token(Token = "0x1700084C")]
	public Action EOLLAHNPEHI
	{
		[Token(Token = "0x6006312")]
		[Address(RVA = "0x1D77E8C", Offset = "0x1D77E8C", VA = "0x1D77E8C", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x1700084D")]
	public bool LFJKFLNNNBK
	{
		[Token(Token = "0x600631C")]
		[Address(RVA = "0x1D76594", Offset = "0x1D76594", VA = "0x1D76594")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006306")]
	[Address(RVA = "0x1D75630", Offset = "0x1D75630", VA = "0x1D75630")]
	protected SkateboardControllerBase()
	{
	}

	[Token(Token = "0x6006309")]
	[Address(RVA = "0x1D77C44", Offset = "0x1D77C44", VA = "0x1D77C44", Slot = "39")]
	public virtual Vector3 GetVelocity()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6006310")]
	[Address(RVA = "0x1D75928", Offset = "0x1D75928", VA = "0x1D75928", Slot = "41")]
	public virtual void Init(BCIGOPJHDPB AJKBOONEOAB, Transform PKJDJAEEMFA, bool JGAKJHAPHOA)
	{
	}

	[Token(Token = "0x6006313")]
	[Address(RVA = "0x1D75E04", Offset = "0x1D75E04", VA = "0x1D75E04", Slot = "42")]
	public virtual void OnGetOn(Player PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x6006314")]
	[Address(RVA = "0x1D760A8", Offset = "0x1D760A8", VA = "0x1D760A8", Slot = "43")]
	public virtual void OnGetOff(Player PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x6006315")]
	[Address(RVA = "0x1D77F88", Offset = "0x1D77F88", VA = "0x1D77F88")]
	protected void ABEAPNMJCIA(Player PJOIFFLCDPM, Transform PHLFBBIAEFE)
	{
	}

	[Token(Token = "0x6006316")]
	[Address(RVA = "0x1D78A50", Offset = "0x1D78A50", VA = "0x1D78A50")]
	protected void FEHBKDFBNAE(Player PJOIFFLCDPM)
	{
	}

	[Token(Token = "0x6006317")]
	[Address(RVA = "0x1D78B88", Offset = "0x1D78B88", VA = "0x1D78B88", Slot = "29")]
	public void SetVisible(bool KENDCFNPDCE)
	{
	}

	[Token(Token = "0x6006318")]
	[Address(RVA = "0x1D76FB8", Offset = "0x1D76FB8", VA = "0x1D76FB8", Slot = "44")]
	public virtual void Jump()
	{
	}

	[Token(Token = "0x6006319")]
	[Address(RVA = "0x1D78D2C", Offset = "0x1D78D2C", VA = "0x1D78D2C", Slot = "45")]
	public virtual void StopJump()
	{
	}

	[Token(Token = "0x600631A")]
	[Address(RVA = "0x1D775E8", Offset = "0x1D775E8", VA = "0x1D775E8", Slot = "46")]
	public virtual void Dash()
	{
	}

	[Token(Token = "0x600631B")]
	[Address(RVA = "0x1D777B8", Offset = "0x1D777B8", VA = "0x1D777B8", Slot = "47")]
	public virtual void StopDash()
	{
	}

	[Token(Token = "0x600631D")]
	public abstract void ApplyAxisControl(Vector3 LLJJKBAGKHP);

	[Token(Token = "0x600631E")]
	[Address(RVA = "0x1D79044", Offset = "0x1D79044", VA = "0x1D79044", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600631F")]
	[Address(RVA = "0x1D768E0", Offset = "0x1D768E0", VA = "0x1D768E0", Slot = "49")]
	protected virtual void PIOOCMDHEAF(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6006320")]
	[Address(RVA = "0x1D790F0", Offset = "0x1D790F0", VA = "0x1D790F0", Slot = "50")]
	protected virtual void IPPFLLMIILK(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6006321")]
	[Address(RVA = "0x1D79160", Offset = "0x1D79160", VA = "0x1D79160", Slot = "18")]
	public override void OnUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6006322")]
	[Address(RVA = "0x1D76AE0", Offset = "0x1D76AE0", VA = "0x1D76AE0", Slot = "51")]
	protected virtual void OBMJGBLOBLM(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6006323")]
	[Address(RVA = "0x1D79628", Offset = "0x1D79628", VA = "0x1D79628", Slot = "52")]
	protected virtual void IDDAAGEJDGB(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6006324")]
	[Address(RVA = "0x1D77968", Offset = "0x1D77968", VA = "0x1D77968", Slot = "53")]
	public virtual void OnForceSync(Vector3 FAFEDEPIFIF)
	{
	}

	[Token(Token = "0x6006325")]
	[Address(RVA = "0x1D78BF4", Offset = "0x1D78BF4", VA = "0x1D78BF4")]
	protected void EGMBHCPHEND()
	{
	}

	[Token(Token = "0x6006326")]
	[Address(RVA = "0x1D78D88", Offset = "0x1D78D88", VA = "0x1D78D88")]
	protected void APDEBOHJOAC()
	{
	}

	[Token(Token = "0x6006327")]
	[Address(RVA = "0x1D78ECC", Offset = "0x1D78ECC", VA = "0x1D78ECC")]
	protected void CCEBLAGINHM()
	{
	}

	[Token(Token = "0x6006328")]
	[Address(RVA = "0x1D79698", Offset = "0x1D79698", VA = "0x1D79698")]
	protected GameObject IDGONNNLJCA(Transform JHNKHAECLFJ, ResourceID KMIPBIGPDPI)
	{
		return null;
	}

	[Token(Token = "0x6006329")]
	[Address(RVA = "0x1D79988", Offset = "0x1D79988", VA = "0x1D79988")]
	protected bool CIFMAOCMLMI()
	{
		return default(bool);
	}

	[Token(Token = "0x600632A")]
	[Address(RVA = "0x1D78144", Offset = "0x1D78144", VA = "0x1D78144")]
	protected void CMNPAJILPAJ()
	{
	}

	[Token(Token = "0x600632B")]
	[Address(RVA = "0x1D79A78", Offset = "0x1D79A78", VA = "0x1D79A78")]
	private void BGOHGCDFGBP(float OJGNBJELDEM)
	{
	}

	[Token(Token = "0x600632C")]
	[Address(RVA = "0x1D79224", Offset = "0x1D79224", VA = "0x1D79224")]
	protected void AECPHJCPOAE()
	{
	}

	[Token(Token = "0x600632D")]
	[Address(RVA = "0x1D78C74", Offset = "0x1D78C74", VA = "0x1D78C74")]
	protected void NOEPFDDGAMP()
	{
	}

	[Token(Token = "0x600632E")]
	[Address(RVA = "0x1D78E14", Offset = "0x1D78E14", VA = "0x1D78E14")]
	protected void JMCLMHCFPKC()
	{
	}

	[Token(Token = "0x600632F")]
	[Address(RVA = "0x1D79C9C", Offset = "0x1D79C9C", VA = "0x1D79C9C")]
	protected void CLIPGBBEGNB(ResourceID KMIPBIGPDPI)
	{
	}

	[Token(Token = "0x6006330")]
	[Address(RVA = "0x1D79E4C", Offset = "0x1D79E4C", VA = "0x1D79E4C")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x6006331")]
	[Address(RVA = "0x1D79E54", Offset = "0x1D79E54", VA = "0x1D79E54")]
	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}
}
