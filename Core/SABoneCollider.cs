using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003BDB")]
public class SABoneCollider : MonoBehaviour
{
	[Token(Token = "0x4019861")]
	[FieldOffset(Offset = "0xC")]
	public SABoneColliderCommon.SABoneColliderProperty boneColliderProperty;

	[Token(Token = "0x4019862")]
	[FieldOffset(Offset = "0x10")]
	public string defaultName;

	[Token(Token = "0x4019863")]
	[FieldOffset(Offset = "0x14")]
	public SABoneColliderCommon.SABoneColliderProperty defaultBoneColliderProperty;

	[NonSerialized]
	[Token(Token = "0x4019864")]
	[FieldOffset(Offset = "0x18")]
	public SABoneColliderCommon.SABoneColliderProperty edittingBoneColliderProperty;

	[Token(Token = "0x4019865")]
	[FieldOffset(Offset = "0x1C")]
	public bool modified;

	[Token(Token = "0x4019866")]
	[FieldOffset(Offset = "0x1D")]
	public bool modifiedChildren;

	[NonSerialized]
	[Token(Token = "0x4019867")]
	[FieldOffset(Offset = "0x1E")]
	public bool cleanupModified;

	[NonSerialized]
	[Token(Token = "0x4019868")]
	[FieldOffset(Offset = "0x1F")]
	public bool isDebug;

	[Token(Token = "0x170018F1")]
	public SABoneColliderCommon.BoneProperty boneProperty
	{
		[Token(Token = "0x6017DFC")]
		[Address(RVA = "0x316F1C4", Offset = "0x316F1C4", VA = "0x316F1C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018F2")]
	public SABoneColliderCommon.SplitProperty splitProperty
	{
		[Token(Token = "0x6017DFD")]
		[Address(RVA = "0x316F1D8", Offset = "0x316F1D8", VA = "0x316F1D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018F3")]
	public SAColliderBuilderCommon.ReducerProperty reducerProperty
	{
		[Token(Token = "0x6017DFE")]
		[Address(RVA = "0x316F1EC", Offset = "0x316F1EC", VA = "0x316F1EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018F4")]
	public SAColliderBuilderCommon.ColliderProperty colliderProperty
	{
		[Token(Token = "0x6017DFF")]
		[Address(RVA = "0x316F200", Offset = "0x316F200", VA = "0x316F200")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018F5")]
	public SAColliderBuilderCommon.RigidbodyProperty rigidbodyProperty
	{
		[Token(Token = "0x6017E00")]
		[Address(RVA = "0x316F214", Offset = "0x316F214", VA = "0x316F214")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018F6")]
	public bool recursivery
	{
		[Token(Token = "0x6017E01")]
		[Address(RVA = "0x316F228", Offset = "0x316F228", VA = "0x316F228")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170018F7")]
	public bool modifyNameEnalbed
	{
		[Token(Token = "0x6017E02")]
		[Address(RVA = "0x316F250", Offset = "0x316F250", VA = "0x316F250")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6017DFB")]
	[Address(RVA = "0x316EFB0", Offset = "0x316EFB0", VA = "0x316EFB0")]
	public SABoneCollider()
	{
	}

	[Token(Token = "0x6017E03")]
	[Address(RVA = "0x316F270", Offset = "0x316F270", VA = "0x316F270")]
	public void ChangeDefaultName(string defaultName)
	{
	}

	[Token(Token = "0x6017E04")]
	[Address(RVA = "0x316F6CC", Offset = "0x316F6CC", VA = "0x316F6CC")]
	public void ChangeModified(bool modified)
	{
	}

	[Token(Token = "0x6017E05")]
	[Address(RVA = "0x316F74C", Offset = "0x316F74C", VA = "0x316F74C")]
	public void ChangeModifiedChildren(bool modifiedChildren)
	{
	}

	[Token(Token = "0x6017E06")]
	[Address(RVA = "0x316F7CC", Offset = "0x316F7CC", VA = "0x316F7CC")]
	public void ResetModified()
	{
	}

	[Token(Token = "0x6017E07")]
	[Address(RVA = "0x316F84C", Offset = "0x316F84C", VA = "0x316F84C")]
	public void ResetModifyName()
	{
	}

	[Token(Token = "0x6017E08")]
	[Address(RVA = "0x316F488", Offset = "0x316F488", VA = "0x316F488")]
	public string _ComputeModifyName()
	{
		return null;
	}

	[Token(Token = "0x6017E09")]
	[Address(RVA = "0x316F2F0", Offset = "0x316F2F0", VA = "0x316F2F0")]
	public bool _IsModifyName()
	{
		return default(bool);
	}
}
