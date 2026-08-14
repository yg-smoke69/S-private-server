using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003B2B")]
public class DynamicBone : MonoBehaviour
{
	[Token(Token = "0x2003B2C")]
	public enum FreezeAxis
	{
		[Token(Token = "0x40192F7")]
		None,
		[Token(Token = "0x40192F8")]
		X,
		[Token(Token = "0x40192F9")]
		Y,
		[Token(Token = "0x40192FA")]
		Z
	}

	[Token(Token = "0x2003B2D")]
	private class Particle
	{
		[Token(Token = "0x40192FB")]
		[FieldOffset(Offset = "0x8")]
		public Transform m_Transform;

		[Token(Token = "0x40192FC")]
		[FieldOffset(Offset = "0xC")]
		public int m_ParentIndex;

		[Token(Token = "0x40192FD")]
		[FieldOffset(Offset = "0x10")]
		public float m_Damping;

		[Token(Token = "0x40192FE")]
		[FieldOffset(Offset = "0x14")]
		public float m_Elasticity;

		[Token(Token = "0x40192FF")]
		[FieldOffset(Offset = "0x18")]
		public float m_Stiffness;

		[Token(Token = "0x4019300")]
		[FieldOffset(Offset = "0x1C")]
		public float m_Inert;

		[Token(Token = "0x4019301")]
		[FieldOffset(Offset = "0x20")]
		public float m_Radius;

		[Token(Token = "0x4019302")]
		[FieldOffset(Offset = "0x24")]
		public float m_BoneLength;

		[Token(Token = "0x4019303")]
		[FieldOffset(Offset = "0x28")]
		public float m_Length2Parent;

		[Token(Token = "0x4019304")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 m_Position;

		[Token(Token = "0x4019305")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 m_PrevPosition;

		[Token(Token = "0x4019306")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 m_EndOffset;

		[Token(Token = "0x4019307")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 m_InitLocalPosition;

		[Token(Token = "0x4019308")]
		[FieldOffset(Offset = "0x5C")]
		public Quaternion m_InitLocalRotation;

		[Token(Token = "0x60177F2")]
		[Address(RVA = "0x31F80B8", Offset = "0x31F80B8", VA = "0x31F80B8")]
		public Particle()
		{
		}
	}

	[Token(Token = "0x2003B2E")]
	private sealed class _003CAppendParticles_003Ec__AnonStorey0
	{
		[Token(Token = "0x4019309")]
		[FieldOffset(Offset = "0x8")]
		internal Transform b;

		[Token(Token = "0x60177F3")]
		[Address(RVA = "0x31F8020", Offset = "0x31F8020", VA = "0x31F8020")]
		public _003CAppendParticles_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60177F4")]
		[Address(RVA = "0x31F8028", Offset = "0x31F8028", VA = "0x31F8028")]
		internal bool _003C_003Em__0(Transform temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40192CC")]
	[FieldOffset(Offset = "0xC")]
	public Transform m_Root;

	[Token(Token = "0x40192CD")]
	[FieldOffset(Offset = "0x10")]
	public float m_UpdateRate;

	[Token(Token = "0x40192CE")]
	[FieldOffset(Offset = "0x14")]
	public float m_Damping;

	[Token(Token = "0x40192CF")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve m_DampingDistrib;

	[Token(Token = "0x40192D0")]
	[FieldOffset(Offset = "0x1C")]
	public float m_Elasticity;

	[Token(Token = "0x40192D1")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve m_ElasticityDistrib;

	[Token(Token = "0x40192D2")]
	[FieldOffset(Offset = "0x24")]
	public float m_Stiffness;

	[Token(Token = "0x40192D3")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve m_StiffnessDistrib;

	[Token(Token = "0x40192D4")]
	[FieldOffset(Offset = "0x2C")]
	public float m_Inert;

	[Token(Token = "0x40192D5")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve m_InertDistrib;

	[Token(Token = "0x40192D6")]
	[FieldOffset(Offset = "0x34")]
	public float m_Radius;

	[Token(Token = "0x40192D7")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve m_RadiusDistrib;

	[Token(Token = "0x40192D8")]
	[FieldOffset(Offset = "0x3C")]
	public float m_EndLength;

	[Token(Token = "0x40192D9")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 m_EndOffset;

	[Token(Token = "0x40192DA")]
	[FieldOffset(Offset = "0x4C")]
	public Vector3 m_Gravity;

	[Token(Token = "0x40192DB")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 m_Force;

	[Token(Token = "0x40192DC")]
	[FieldOffset(Offset = "0x64")]
	public List<DynamicBoneCollider> m_Colliders;

	[Token(Token = "0x40192DD")]
	[FieldOffset(Offset = "0x68")]
	public List<Transform> m_Exclusions;

	[Token(Token = "0x40192DE")]
	[FieldOffset(Offset = "0x6C")]
	public List<Transform> m_ValidBones;

	[Token(Token = "0x40192DF")]
	[FieldOffset(Offset = "0x70")]
	public bool m_AnimationControlled;

	[Token(Token = "0x40192E0")]
	[FieldOffset(Offset = "0x74")]
	public FreezeAxis m_FreezeAxis;

	[Token(Token = "0x40192E1")]
	[FieldOffset(Offset = "0x78")]
	public bool m_DistantDisable;

	[Token(Token = "0x40192E2")]
	[FieldOffset(Offset = "0x7C")]
	public Transform m_ReferenceObject;

	[Token(Token = "0x40192E3")]
	[FieldOffset(Offset = "0x80")]
	public float m_DistanceToObject;

	[Token(Token = "0x40192E4")]
	[FieldOffset(Offset = "0x84")]
	public Vector3 m_RandomAcceleration;

	[Token(Token = "0x40192E5")]
	[FieldOffset(Offset = "0x90")]
	public int m_RandomAccelerationInterval;

	[Token(Token = "0x40192E6")]
	[FieldOffset(Offset = "0x94")]
	protected int m_RAIndex;

	[Token(Token = "0x40192E7")]
	[FieldOffset(Offset = "0x98")]
	protected int m_RALerpCount;

	[Token(Token = "0x40192E8")]
	[FieldOffset(Offset = "0x9C")]
	protected Vector3 m_LocalGravity;

	[Token(Token = "0x40192E9")]
	[FieldOffset(Offset = "0xA8")]
	protected Vector3 m_ObjectMove;

	[Token(Token = "0x40192EA")]
	[FieldOffset(Offset = "0xB4")]
	protected Vector3 m_ObjectPrevPosition;

	[Token(Token = "0x40192EB")]
	[FieldOffset(Offset = "0xC0")]
	protected int m_RandomAccelerationCount;

	[Token(Token = "0x40192EC")]
	[FieldOffset(Offset = "0xC4")]
	protected float m_BoneTotalLength;

	[Token(Token = "0x40192ED")]
	[FieldOffset(Offset = "0xC8")]
	protected float m_ObjectScale;

	[Token(Token = "0x40192EE")]
	[FieldOffset(Offset = "0xCC")]
	protected float m_Time;

	[Token(Token = "0x40192EF")]
	[FieldOffset(Offset = "0xD0")]
	protected float m_Weight;

	[Token(Token = "0x40192F0")]
	[FieldOffset(Offset = "0xD4")]
	protected bool m_DistantDisabled;

	[Token(Token = "0x40192F1")]
	[FieldOffset(Offset = "0xD5")]
	protected bool m_Rand;

	[Token(Token = "0x40192F2")]
	[FieldOffset(Offset = "0xD8")]
	private Vector3 m_CurrentRandomAcceleration;

	[Token(Token = "0x40192F3")]
	[FieldOffset(Offset = "0xE4")]
	public bool m_UseRandomForce;

	[Token(Token = "0x40192F4")]
	[FieldOffset(Offset = "0xE5")]
	public bool m_RemoveWhenUMARebuild;

	[Token(Token = "0x40192F5")]
	[FieldOffset(Offset = "0xE8")]
	private List<Particle> m_Particles;

	[Token(Token = "0x60177DF")]
	[Address(RVA = "0x2326130", Offset = "0x2326130", VA = "0x2326130")]
	public DynamicBone()
	{
	}

	[Token(Token = "0x60177E0")]
	[Address(RVA = "0x2326390", Offset = "0x2326390", VA = "0x2326390")]
	private void Start()
	{
	}

	[Token(Token = "0x60177E1")]
	[Address(RVA = "0x23263C4", Offset = "0x23263C4", VA = "0x23263C4")]
	private void Update()
	{
	}

	[Token(Token = "0x60177E2")]
	[Address(RVA = "0x23263FC", Offset = "0x23263FC", VA = "0x23263FC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60177E3")]
	[Address(RVA = "0x2326458", Offset = "0x2326458", VA = "0x2326458")]
	private void CheckDistance()
	{
	}

	[Token(Token = "0x60177E4")]
	[Address(RVA = "0x2326C00", Offset = "0x2326C00", VA = "0x2326C00")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60177E5")]
	[Address(RVA = "0x2326C10", Offset = "0x2326C10", VA = "0x2326C10")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60177E6")]
	[Address(RVA = "0x2326C20", Offset = "0x2326C20", VA = "0x2326C20")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60177E7")]
	[Address(RVA = "0x2326D70", Offset = "0x2326D70", VA = "0x2326D70")]
	public void SetWeight(float w)
	{
	}

	[Token(Token = "0x60177E8")]
	[Address(RVA = "0x2326DDC", Offset = "0x2326DDC", VA = "0x2326DDC")]
	public float GetWeight()
	{
		return default(float);
	}

	[Token(Token = "0x60177E9")]
	[Address(RVA = "0x23266F0", Offset = "0x23266F0", VA = "0x23266F0")]
	private void UpdateDynamicBones(float t)
	{
	}

	[Token(Token = "0x60177EA")]
	[Address(RVA = "0x2328C48", Offset = "0x2328C48", VA = "0x2328C48", Slot = "4")]
	public virtual void SetupParticles()
	{
	}

	[Token(Token = "0x60177EB")]
	[Address(RVA = "0x232921C", Offset = "0x232921C", VA = "0x232921C")]
	private void AppendParticles(Transform b, int parentIndex, float boneLength)
	{
	}

	[Token(Token = "0x60177EC")]
	[Address(RVA = "0x2329E90", Offset = "0x2329E90", VA = "0x2329E90", Slot = "5")]
	public virtual void InitTransforms()
	{
	}

	[Token(Token = "0x60177ED")]
	[Address(RVA = "0x232A044", Offset = "0x232A044", VA = "0x232A044", Slot = "6")]
	public virtual void ResetParticlesPosition()
	{
	}

	[Token(Token = "0x60177EE")]
	[Address(RVA = "0x2326DE4", Offset = "0x2326DE4", VA = "0x2326DE4")]
	private void UpdateParticles1()
	{
	}

	[Token(Token = "0x60177EF")]
	[Address(RVA = "0x232731C", Offset = "0x232731C", VA = "0x232731C")]
	private void UpdateParticles2()
	{
	}

	[Token(Token = "0x60177F0")]
	[Address(RVA = "0x2327F04", Offset = "0x2327F04", VA = "0x2327F04")]
	private void SkipUpdateParticles()
	{
	}

	[Token(Token = "0x60177F1")]
	[Address(RVA = "0x2328830", Offset = "0x2328830", VA = "0x2328830")]
	private void ApplyParticlesToTransforms()
	{
	}
}
