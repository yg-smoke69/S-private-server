using System;
using Il2CppDummyDll;

[Token(Token = "0x2003BC9")]
public class SABoneColliderCommon
{
	[Token(Token = "0x2003BCA")]
	public enum BoneWeightType
	{
		[Token(Token = "0x401980F")]
		Bone2,
		[Token(Token = "0x4019810")]
		Bone4
	}

	[Token(Token = "0x2003BCB")]
	public enum BoneTriangleExtent
	{
		[Token(Token = "0x4019812")]
		Disable,
		[Token(Token = "0x4019813")]
		Vertex2,
		[Token(Token = "0x4019814")]
		Vertex1
	}

	[Serializable]
	[Token(Token = "0x2003BCC")]
	public class BoneProperty
	{
		[Token(Token = "0x4019815")]
		[FieldOffset(Offset = "0x8")]
		public bool recursivery;

		[Token(Token = "0x6017DE9")]
		[Address(RVA = "0x316FA98", Offset = "0x316FA98", VA = "0x316FA98")]
		public BoneProperty()
		{
		}

		[Token(Token = "0x6017DEA")]
		[Address(RVA = "0x316FAA0", Offset = "0x316FAA0", VA = "0x316FAA0")]
		public BoneProperty ShallowCopy()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2003BCD")]
	public class SplitProperty
	{
		[Token(Token = "0x4019816")]
		[FieldOffset(Offset = "0x8")]
		public BoneWeightType boneWeightType;

		[Token(Token = "0x4019817")]
		[FieldOffset(Offset = "0xC")]
		public int boneWeight2;

		[Token(Token = "0x4019818")]
		[FieldOffset(Offset = "0x10")]
		public int boneWeight3;

		[Token(Token = "0x4019819")]
		[FieldOffset(Offset = "0x14")]
		public int boneWeight4;

		[Token(Token = "0x401981A")]
		[FieldOffset(Offset = "0x18")]
		public bool greaterBoneWeight;

		[Token(Token = "0x401981B")]
		[FieldOffset(Offset = "0x1C")]
		public BoneTriangleExtent boneTriangleExtent;

		[Token(Token = "0x6017DEB")]
		[Address(RVA = "0x316FB9C", Offset = "0x316FB9C", VA = "0x316FB9C")]
		public SplitProperty()
		{
		}

		[Token(Token = "0x6017DEC")]
		[Address(RVA = "0x316FD00", Offset = "0x316FD00", VA = "0x316FD00")]
		public SplitProperty ShallowCopy()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2003BCE")]
	public class SABoneColliderProperty
	{
		[Token(Token = "0x401981C")]
		[FieldOffset(Offset = "0x8")]
		public BoneProperty boneProperty;

		[Token(Token = "0x401981D")]
		[FieldOffset(Offset = "0xC")]
		public SplitProperty splitProperty;

		[Token(Token = "0x401981E")]
		[FieldOffset(Offset = "0x10")]
		public SAColliderBuilderCommon.ReducerProperty reducerProperty;

		[Token(Token = "0x401981F")]
		[FieldOffset(Offset = "0x14")]
		public SAColliderBuilderCommon.ColliderProperty colliderProperty;

		[Token(Token = "0x4019820")]
		[FieldOffset(Offset = "0x18")]
		public SAColliderBuilderCommon.RigidbodyProperty rigidbodyProperty;

		[Token(Token = "0x4019821")]
		[FieldOffset(Offset = "0x1C")]
		public bool modifyNameEnabled;

		[Token(Token = "0x6017DED")]
		[Address(RVA = "0x316F090", Offset = "0x316F090", VA = "0x316F090")]
		public SABoneColliderProperty()
		{
		}

		[Token(Token = "0x6017DEE")]
		[Address(RVA = "0x316FF34", Offset = "0x316FF34", VA = "0x316FF34")]
		public SABoneColliderProperty Copy()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2003BCF")]
	public class SABoneColliderBuilderProperty
	{
		[Token(Token = "0x4019822")]
		[FieldOffset(Offset = "0x8")]
		public SplitProperty splitProperty;

		[Token(Token = "0x4019823")]
		[FieldOffset(Offset = "0xC")]
		public SAColliderBuilderCommon.ReducerProperty reducerProperty;

		[Token(Token = "0x4019824")]
		[FieldOffset(Offset = "0x10")]
		public SAColliderBuilderCommon.ColliderProperty colliderProperty;

		[Token(Token = "0x4019825")]
		[FieldOffset(Offset = "0x14")]
		public SAColliderBuilderCommon.RigidbodyProperty rigidbodyProperty;

		[Token(Token = "0x4019826")]
		[FieldOffset(Offset = "0x18")]
		public bool modifyNameEnabled;

		[Token(Token = "0x6017DEF")]
		[Address(RVA = "0x316F928", Offset = "0x316F928", VA = "0x316F928")]
		public SABoneColliderBuilderProperty()
		{
		}

		[Token(Token = "0x6017DF0")]
		[Address(RVA = "0x316FBC8", Offset = "0x316FBC8", VA = "0x316FBC8")]
		public SABoneColliderBuilderProperty Copy()
		{
			return null;
		}

		[Token(Token = "0x6017DF1")]
		[Address(RVA = "0x316FDFC", Offset = "0x316FDFC", VA = "0x316FDFC")]
		public SABoneColliderProperty ToSABoneColliderProperty()
		{
			return null;
		}
	}

	[Token(Token = "0x6017DE8")]
	[Address(RVA = "0x316FA90", Offset = "0x316FA90", VA = "0x316FA90")]
	public SABoneColliderCommon()
	{
	}
}
