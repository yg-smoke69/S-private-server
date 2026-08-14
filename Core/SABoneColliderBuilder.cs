using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003BDC")]
public class SABoneColliderBuilder : MonoBehaviour
{
	[Token(Token = "0x4019869")]
	[FieldOffset(Offset = "0xC")]
	public SABoneColliderCommon.SABoneColliderBuilderProperty boneColliderBuilderProperty;

	[NonSerialized]
	[Token(Token = "0x401986A")]
	[FieldOffset(Offset = "0x10")]
	public SABoneColliderCommon.SABoneColliderBuilderProperty edittingBoneColliderBuilderProperty;

	[NonSerialized]
	[Token(Token = "0x401986B")]
	[FieldOffset(Offset = "0x14")]
	public bool cleanupModified;

	[NonSerialized]
	[Token(Token = "0x401986C")]
	[FieldOffset(Offset = "0x15")]
	public bool isDebug;

	[Token(Token = "0x170018F8")]
	public SABoneColliderCommon.SplitProperty splitProperty
	{
		[Token(Token = "0x6017E0B")]
		[Address(RVA = "0x316FA38", Offset = "0x316FA38", VA = "0x316FA38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018F9")]
	public SAColliderBuilderCommon.ReducerProperty reducerProperty
	{
		[Token(Token = "0x6017E0C")]
		[Address(RVA = "0x316FA4C", Offset = "0x316FA4C", VA = "0x316FA4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018FA")]
	public SAColliderBuilderCommon.ColliderProperty colliderProperty
	{
		[Token(Token = "0x6017E0D")]
		[Address(RVA = "0x316FA60", Offset = "0x316FA60", VA = "0x316FA60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018FB")]
	public SAColliderBuilderCommon.RigidbodyProperty rigidbodyProperty
	{
		[Token(Token = "0x6017E0E")]
		[Address(RVA = "0x316FA74", Offset = "0x316FA74", VA = "0x316FA74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6017E0A")]
	[Address(RVA = "0x316F8B0", Offset = "0x316F8B0", VA = "0x316F8B0")]
	public SABoneColliderBuilder()
	{
	}
}
