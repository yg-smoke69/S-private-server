using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AFF")]
public class BossRocket : MonoBehaviour
{
	[Token(Token = "0x2000B00")]
	private sealed class _003CExpolde_003Ec__AnonStorey0
	{
		[Token(Token = "0x4005F44")]
		[FieldOffset(Offset = "0x8")]
		internal ResourceID effectID;

		[Token(Token = "0x60054A9")]
		[Address(RVA = "0x2ED2958", Offset = "0x2ED2958", VA = "0x2ED2958")]
		public _003CExpolde_003Ec__AnonStorey0()
		{
		}
	}

	[Token(Token = "0x2000B01")]
	private sealed class _003CExpolde_003Ec__AnonStorey1
	{
		[Token(Token = "0x4005F45")]
		[FieldOffset(Offset = "0x8")]
		internal GameObject effect;

		[Token(Token = "0x4005F46")]
		[FieldOffset(Offset = "0xC")]
		internal _003CExpolde_003Ec__AnonStorey0 _003C_003Ef__ref_00240;

		[Token(Token = "0x60054AA")]
		[Address(RVA = "0x2ED2960", Offset = "0x2ED2960", VA = "0x2ED2960")]
		public _003CExpolde_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60054AB")]
		[Address(RVA = "0x2ED2968", Offset = "0x2ED2968", VA = "0x2ED2968")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4005F33")]
	[FieldOffset(Offset = "0xC")]
	public bool IsIceRocket;

	[Token(Token = "0x4005F34")]
	[FieldOffset(Offset = "0x10")]
	public float FreezeTime;

	[Token(Token = "0x4005F35")]
	[FieldOffset(Offset = "0x14")]
	public float MAXSpeed;

	[Token(Token = "0x4005F36")]
	[FieldOffset(Offset = "0x18")]
	public int Damage;

	[Token(Token = "0x4005F37")]
	[FieldOffset(Offset = "0x1C")]
	public float ExplodeRange;

	[Token(Token = "0x4005F38")]
	[FieldOffset(Offset = "0x20")]
	public float AccTime;

	[Token(Token = "0x4005F39")]
	[FieldOffset(Offset = "0x24")]
	public AnimationCurve SpeedCurve;

	[Token(Token = "0x4005F3A")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve RotCurve;

	[Token(Token = "0x4005F3B")]
	[FieldOffset(Offset = "0x2C")]
	public float RotTime;

	[Token(Token = "0x4005F3C")]
	[FieldOffset(Offset = "0x30")]
	public string ExplodeEffectResID;

	[Token(Token = "0x4005F3D")]
	[FieldOffset(Offset = "0x34")]
	public string ExplodeSoundResID;

	[Token(Token = "0x4005F3E")]
	[FieldOffset(Offset = "0x38")]
	protected Vector3 m_TargetPos;

	[Token(Token = "0x4005F3F")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 m_LaunchForward;

	[Token(Token = "0x4005F40")]
	[FieldOffset(Offset = "0x50")]
	protected bool m_IsFlying;

	[Token(Token = "0x4005F41")]
	[FieldOffset(Offset = "0x54")]
	private float m_BeginLaunchTime;

	[Token(Token = "0x4005F42")]
	[FieldOffset(Offset = "0x58")]
	private Transform m_Transform;

	[Token(Token = "0x4005F43")]
	[FieldOffset(Offset = "0x5C")]
	private BountyWarningZone m_CurWarningZone;

	[Token(Token = "0x170006D3")]
	protected Transform CacheTransform
	{
		[Token(Token = "0x60054A4")]
		[Address(RVA = "0x2ED1A28", Offset = "0x2ED1A28", VA = "0x2ED1A28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60054A3")]
	[Address(RVA = "0x2ED1078", Offset = "0x2ED1078", VA = "0x2ED1078")]
	public BossRocket()
	{
	}

	[Token(Token = "0x60054A5")]
	[Address(RVA = "0x2ED13E8", Offset = "0x2ED13E8", VA = "0x2ED13E8", Slot = "4")]
	public virtual void Launch(Vector3 launchPos, Vector3 launchFoward, Vector3 targetPost, [Optional] Transform parent)
	{
	}

	[Token(Token = "0x60054A6")]
	[Address(RVA = "0x2ED2478", Offset = "0x2ED2478", VA = "0x2ED2478")]
	public void ActiveWarningZone(BountyWarningZone zone)
	{
	}

	[Token(Token = "0x60054A7")]
	[Address(RVA = "0x2ED24B8", Offset = "0x2ED24B8", VA = "0x2ED24B8", Slot = "5")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x60054A8")]
	[Address(RVA = "0x2ED1AD0", Offset = "0x2ED1AD0", VA = "0x2ED1AD0")]
	protected void Expolde()
	{
	}
}
