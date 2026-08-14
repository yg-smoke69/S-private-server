using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003BD0")]
public class SAColliderBuilderCommon
{
	[Token(Token = "0x2003BD1")]
	public enum ShapeType
	{
		[Token(Token = "0x4019828")]
		None,
		[Token(Token = "0x4019829")]
		Mesh,
		[Token(Token = "0x401982A")]
		Box,
		[Token(Token = "0x401982B")]
		Capsule,
		[Token(Token = "0x401982C")]
		Sphere
	}

	[Token(Token = "0x2003BD2")]
	public enum FitType
	{
		[Token(Token = "0x401982E")]
		Outer,
		[Token(Token = "0x401982F")]
		Inner
	}

	[Token(Token = "0x2003BD3")]
	public enum MeshType
	{
		[Token(Token = "0x4019831")]
		Raw,
		[Token(Token = "0x4019832")]
		ConvexBoxes,
		[Token(Token = "0x4019833")]
		ConvexHull,
		[Token(Token = "0x4019834")]
		Box
	}

	[Token(Token = "0x2003BD4")]
	public enum SliceMode
	{
		[Token(Token = "0x4019836")]
		Auto,
		[Token(Token = "0x4019837")]
		X,
		[Token(Token = "0x4019838")]
		Y,
		[Token(Token = "0x4019839")]
		Z
	}

	[Token(Token = "0x2003BD5")]
	public enum ElementType
	{
		[Token(Token = "0x401983B")]
		X,
		[Token(Token = "0x401983C")]
		XYZ
	}

	[Serializable]
	[Token(Token = "0x2003BD6")]
	public struct Bool3
	{
		[Token(Token = "0x401983D")]
		[FieldOffset(Offset = "0x0")]
		public bool x;

		[Token(Token = "0x401983E")]
		[FieldOffset(Offset = "0x1")]
		public bool y;

		[Token(Token = "0x401983F")]
		[FieldOffset(Offset = "0x2")]
		public bool z;

		[Token(Token = "0x6017DF3")]
		[Address(RVA = "0x93DFE0", Offset = "0x93DFE0", VA = "0x93DFE0")]
		public Bool3(bool x, bool y, bool z)
		{
		}

		[Token(Token = "0x6017DF4")]
		[Address(RVA = "0x93DFF0", Offset = "0x93DFF0", VA = "0x93DFF0")]
		public void SetValue(bool x, bool y, bool z)
		{
		}
	}

	[Token(Token = "0x2003BD7")]
	public enum ColliderToChild
	{
		[Token(Token = "0x4019841")]
		Auto,
		[Token(Token = "0x4019842")]
		On,
		[Token(Token = "0x4019843")]
		Off
	}

	[Serializable]
	[Token(Token = "0x2003BD8")]
	public class ReducerProperty
	{
		[Token(Token = "0x4019844")]
		[FieldOffset(Offset = "0x8")]
		public ShapeType shapeType;

		[Token(Token = "0x4019845")]
		[FieldOffset(Offset = "0xC")]
		public FitType fitType;

		[Token(Token = "0x4019846")]
		[FieldOffset(Offset = "0x10")]
		public MeshType meshType;

		[Token(Token = "0x4019847")]
		[FieldOffset(Offset = "0x14")]
		public int maxTriangles;

		[Token(Token = "0x4019848")]
		[FieldOffset(Offset = "0x18")]
		public SliceMode sliceMode;

		[Token(Token = "0x4019849")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 scale;

		[Token(Token = "0x401984A")]
		[FieldOffset(Offset = "0x28")]
		public ElementType scaleElementType;

		[Token(Token = "0x401984B")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 minThickness;

		[Token(Token = "0x401984C")]
		[FieldOffset(Offset = "0x38")]
		public ElementType minThicknessElementType;

		[Token(Token = "0x401984D")]
		[FieldOffset(Offset = "0x3C")]
		public Bool3 optimizeRotation;

		[Token(Token = "0x401984E")]
		[FieldOffset(Offset = "0x40")]
		public ElementType optimizeRotationElementType;

		[Token(Token = "0x401984F")]
		[FieldOffset(Offset = "0x44")]
		public ColliderToChild colliderToChild;

		[Token(Token = "0x4019850")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 offset;

		[Token(Token = "0x4019851")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 thicknessA;

		[Token(Token = "0x4019852")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 thicknessB;

		[Token(Token = "0x4019853")]
		[FieldOffset(Offset = "0x6C")]
		public bool viewAdvanced;

		[Token(Token = "0x6017DF5")]
		[Address(RVA = "0x21BFCAC", Offset = "0x21BFCAC", VA = "0x21BFCAC")]
		public ReducerProperty()
		{
		}

		[Token(Token = "0x6017DF6")]
		[Address(RVA = "0x21BFE2C", Offset = "0x21BFE2C", VA = "0x21BFE2C")]
		public ReducerProperty ShallowCopy()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2003BD9")]
	public class ColliderProperty
	{
		[Token(Token = "0x4019854")]
		[FieldOffset(Offset = "0x8")]
		public bool convex;

		[Token(Token = "0x4019855")]
		[FieldOffset(Offset = "0x9")]
		public bool isTrigger;

		[Token(Token = "0x4019856")]
		[FieldOffset(Offset = "0xC")]
		public PhysicMaterial material;

		[Token(Token = "0x4019857")]
		[FieldOffset(Offset = "0x10")]
		public bool isCreateAsset;

		[Token(Token = "0x6017DF7")]
		[Address(RVA = "0x21BFBA0", Offset = "0x21BFBA0", VA = "0x21BFBA0")]
		public ColliderProperty()
		{
		}

		[Token(Token = "0x6017DF8")]
		[Address(RVA = "0x21BFBB0", Offset = "0x21BFBB0", VA = "0x21BFBB0")]
		public ColliderProperty ShallowCopy()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2003BDA")]
	public class RigidbodyProperty
	{
		[Token(Token = "0x4019858")]
		[FieldOffset(Offset = "0x8")]
		public float mass;

		[Token(Token = "0x4019859")]
		[FieldOffset(Offset = "0xC")]
		public float drag;

		[Token(Token = "0x401985A")]
		[FieldOffset(Offset = "0x10")]
		public float angularDrag;

		[Token(Token = "0x401985B")]
		[FieldOffset(Offset = "0x14")]
		public bool isKinematic;

		[Token(Token = "0x401985C")]
		[FieldOffset(Offset = "0x15")]
		public bool useGravity;

		[Token(Token = "0x401985D")]
		[FieldOffset(Offset = "0x18")]
		public RigidbodyInterpolation interpolation;

		[Token(Token = "0x401985E")]
		[FieldOffset(Offset = "0x1C")]
		public CollisionDetectionMode collisionDetectionMode;

		[Token(Token = "0x401985F")]
		[FieldOffset(Offset = "0x20")]
		public bool isCreate;

		[Token(Token = "0x4019860")]
		[FieldOffset(Offset = "0x21")]
		public bool viewAdvanced;

		[Token(Token = "0x6017DF9")]
		[Address(RVA = "0x21BFF28", Offset = "0x21BFF28", VA = "0x21BFF28")]
		public RigidbodyProperty()
		{
		}

		[Token(Token = "0x6017DFA")]
		[Address(RVA = "0x21BFF50", Offset = "0x21BFF50", VA = "0x21BFF50")]
		public RigidbodyProperty ShallowCopy()
		{
			return null;
		}
	}

	[Token(Token = "0x6017DF2")]
	[Address(RVA = "0x3170094", Offset = "0x3170094", VA = "0x3170094")]
	public SAColliderBuilderCommon()
	{
	}
}
