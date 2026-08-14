using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x2003F92")]
public class MultiBillboard : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2003F93")]
	public class BindedTransform
	{
		[Token(Token = "0x401AC98")]
		[FieldOffset(Offset = "0x8")]
		public Transform m_Trans;

		[Token(Token = "0x401AC99")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 m_RotationAdjust;

		[Token(Token = "0x401AC9A")]
		[FieldOffset(Offset = "0x18")]
		public bool m_LockPosition;

		[Token(Token = "0x401AC9B")]
		[FieldOffset(Offset = "0x19")]
		public bool m_LockXAxis;

		[Token(Token = "0x401AC9C")]
		[FieldOffset(Offset = "0x1A")]
		public bool m_LockYAxis;

		[Token(Token = "0x401AC9D")]
		[FieldOffset(Offset = "0x1B")]
		public bool m_LockZAxis;

		[NonSerialized]
		[Token(Token = "0x401AC9E")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 m_SavedPos;

		[NonSerialized]
		[Token(Token = "0x401AC9F")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 m_SavedEuler;

		[Token(Token = "0x6019DF9")]
		[Address(RVA = "0x25C68F4", Offset = "0x25C68F4", VA = "0x25C68F4")]
		public BindedTransform()
		{
		}
	}

	[Token(Token = "0x401AC94")]
	[FieldOffset(Offset = "0xC")]
	private bool m_BindSelf;

	[Token(Token = "0x401AC95")]
	[FieldOffset(Offset = "0xD")]
	private bool m_Facing;

	[Token(Token = "0x401AC96")]
	[FieldOffset(Offset = "0x10")]
	private Transform m_TargetTransform;

	[Token(Token = "0x401AC97")]
	[FieldOffset(Offset = "0x14")]
	private List<BindedTransform> m_BindedTransforms;

	[Token(Token = "0x17001C3F")]
	public bool GDPEOFNDMFE
	{
		[Token(Token = "0x6019DF0")]
		[Address(RVA = "0x25C6454", Offset = "0x25C6454", VA = "0x25C6454")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C40")]
	public bool AHGCLDANKNM
	{
		[Token(Token = "0x6019DF1")]
		[Address(RVA = "0x25C645C", Offset = "0x25C645C", VA = "0x25C645C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C41")]
	private Transform LLKBNPFCIAJ
	{
		[Token(Token = "0x6019DF2")]
		[Address(RVA = "0x25C6464", Offset = "0x25C6464", VA = "0x25C6464")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019DEF")]
	[Address(RVA = "0x25C63C0", Offset = "0x25C63C0", VA = "0x25C63C0")]
	public MultiBillboard()
	{
	}

	[Token(Token = "0x6019DF3")]
	[Address(RVA = "0x25C6698", Offset = "0x25C6698", VA = "0x25C6698")]
	private int ECFGPFJPMIO()
	{
		return default(int);
	}

	[Token(Token = "0x6019DF4")]
	[Address(RVA = "0x25C67D0", Offset = "0x25C67D0", VA = "0x25C67D0")]
	private void CJLCKFNGKCJ()
	{
	}

	[Token(Token = "0x6019DF5")]
	[Address(RVA = "0x25C6A10", Offset = "0x25C6A10", VA = "0x25C6A10")]
	private void Start()
	{
	}

	[Token(Token = "0x6019DF6")]
	[Address(RVA = "0x25C6A14", Offset = "0x25C6A14", VA = "0x25C6A14")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6019DF7")]
	[Address(RVA = "0x25C6A18", Offset = "0x25C6A18", VA = "0x25C6A18")]
	private void KEEOBNKMBFJ(BindedTransform EOFBEGAGPHH, Vector3 IPLHPBPHIBI)
	{
	}

	[Token(Token = "0x6019DF8")]
	[Address(RVA = "0x25C700C", Offset = "0x25C700C", VA = "0x25C700C")]
	private void Update()
	{
	}
}
