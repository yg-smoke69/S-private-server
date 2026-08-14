using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003B32")]
public class DynamicBoneNet : DynamicBone
{
	[Token(Token = "0x2003B33")]
	private class Particle
	{
		[Token(Token = "0x401931A")]
		[FieldOffset(Offset = "0x8")]
		public Transform m_Transform;

		[Token(Token = "0x401931B")]
		[FieldOffset(Offset = "0xC")]
		public int m_ParentIndex;

		[Token(Token = "0x401931C")]
		[FieldOffset(Offset = "0x10")]
		public float m_Damping;

		[Token(Token = "0x401931D")]
		[FieldOffset(Offset = "0x14")]
		public float m_Elasticity;

		[Token(Token = "0x401931E")]
		[FieldOffset(Offset = "0x18")]
		public float m_Stiffness;

		[Token(Token = "0x401931F")]
		[FieldOffset(Offset = "0x1C")]
		public float m_Inert;

		[Token(Token = "0x4019320")]
		[FieldOffset(Offset = "0x20")]
		public float m_Radius;

		[Token(Token = "0x4019321")]
		[FieldOffset(Offset = "0x24")]
		public float m_BoneLength;

		[Token(Token = "0x4019322")]
		[FieldOffset(Offset = "0x28")]
		public Particle m_ColomnParent;

		[Token(Token = "0x4019323")]
		[FieldOffset(Offset = "0x2C")]
		public Particle m_RowParent;

		[Token(Token = "0x4019324")]
		[FieldOffset(Offset = "0x30")]
		public float m_Length2Parent;

		[Token(Token = "0x4019325")]
		[FieldOffset(Offset = "0x34")]
		public float m_Length2NetParent;

		[Token(Token = "0x4019326")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 m_Position;

		[Token(Token = "0x4019327")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 m_PrevPosition;

		[Token(Token = "0x4019328")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 m_EndOffset;

		[Token(Token = "0x4019329")]
		[FieldOffset(Offset = "0x5C")]
		public Vector3 m_InitLocalPosition;

		[Token(Token = "0x401932A")]
		[FieldOffset(Offset = "0x68")]
		public Quaternion m_InitLocalRotation;

		[Token(Token = "0x6017812")]
		[Address(RVA = "0x31FEC6C", Offset = "0x31FEC6C", VA = "0x31FEC6C")]
		public Particle()
		{
		}
	}

	[Token(Token = "0x2003B34")]
	private sealed class _003CAppendParticles_003Ec__AnonStorey0
	{
		[Token(Token = "0x401932B")]
		[FieldOffset(Offset = "0x8")]
		internal Transform b;

		[Token(Token = "0x6017813")]
		[Address(RVA = "0x31FEC64", Offset = "0x31FEC64", VA = "0x31FEC64")]
		public _003CAppendParticles_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6017814")]
		[Address(RVA = "0x31FF504", Offset = "0x31FF504", VA = "0x31FF504")]
		internal bool _003C_003Em__0(Transform temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4019316")]
	[FieldOffset(Offset = "0xEC")]
	private Dictionary<int, List<Particle>> m_ParticleDic;

	[Token(Token = "0x4019317")]
	[FieldOffset(Offset = "0xF0")]
	private List<Transform> m_RootChildren;

	[Token(Token = "0x4019318")]
	[FieldOffset(Offset = "0xF4")]
	private SortedDictionary<string, Transform> m_ChildSortedDic;

	[Token(Token = "0x4019319")]
	[FieldOffset(Offset = "0xF8")]
	private Vector3 m_currentScale;

	[Token(Token = "0x6017800")]
	[Address(RVA = "0x31FA300", Offset = "0x31FA300", VA = "0x31FA300")]
	public DynamicBoneNet()
	{
	}

	[Token(Token = "0x6017801")]
	[Address(RVA = "0x31FA440", Offset = "0x31FA440", VA = "0x31FA440")]
	private void Start()
	{
	}

	[Token(Token = "0x6017802")]
	[Address(RVA = "0x31FA520", Offset = "0x31FA520", VA = "0x31FA520")]
	private void Update()
	{
	}

	[Token(Token = "0x6017803")]
	[Address(RVA = "0x31FA870", Offset = "0x31FA870", VA = "0x31FA870")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6017804")]
	[Address(RVA = "0x31FA8CC", Offset = "0x31FA8CC", VA = "0x31FA8CC")]
	private void CheckDistance()
	{
	}

	[Token(Token = "0x6017805")]
	[Address(RVA = "0x31FAF90", Offset = "0x31FAF90", VA = "0x31FAF90")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6017806")]
	[Address(RVA = "0x31FAFA0", Offset = "0x31FAFA0", VA = "0x31FAFA0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6017807")]
	[Address(RVA = "0x31FAFB0", Offset = "0x31FAFB0", VA = "0x31FAFB0")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6017808")]
	[Address(RVA = "0x31FAB64", Offset = "0x31FAB64", VA = "0x31FAB64")]
	private void UpdateDynamicBones(float t)
	{
	}

	[Token(Token = "0x6017809")]
	[Address(RVA = "0x31FD2F8", Offset = "0x31FD2F8", VA = "0x31FD2F8", Slot = "4")]
	public override void SetupParticles()
	{
	}

	[Token(Token = "0x601780A")]
	[Address(RVA = "0x31FDD9C", Offset = "0x31FDD9C", VA = "0x31FDD9C")]
	private void AppendParticles(Transform b, int parentIndex, float boneLength, List<Particle> particleList, int listIndex)
	{
	}

	[Token(Token = "0x601780B")]
	[Address(RVA = "0x31FEDBC", Offset = "0x31FEDBC", VA = "0x31FEDBC")]
	private Vector3 LinePointProjection(Vector3 P, Vector3 A, Vector3 B)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601780C")]
	[Address(RVA = "0x31FEF30", Offset = "0x31FEF30", VA = "0x31FEF30", Slot = "5")]
	public override void InitTransforms()
	{
	}

	[Token(Token = "0x601780D")]
	[Address(RVA = "0x31FF1A0", Offset = "0x31FF1A0", VA = "0x31FF1A0", Slot = "6")]
	public override void ResetParticlesPosition()
	{
	}

	[Token(Token = "0x601780E")]
	[Address(RVA = "0x31FB100", Offset = "0x31FB100", VA = "0x31FB100")]
	private void UpdateParticles1()
	{
	}

	[Token(Token = "0x601780F")]
	[Address(RVA = "0x31FB6F4", Offset = "0x31FB6F4", VA = "0x31FB6F4")]
	private void UpdateParticles2()
	{
	}

	[Token(Token = "0x6017810")]
	[Address(RVA = "0x31FC548", Offset = "0x31FC548", VA = "0x31FC548")]
	private void SkipUpdateParticles()
	{
	}

	[Token(Token = "0x6017811")]
	[Address(RVA = "0x31FCDEC", Offset = "0x31FCDEC", VA = "0x31FCDEC")]
	private void ApplyParticlesToTransforms()
	{
	}
}
