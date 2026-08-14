using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CF5")]
public class UMASkeleton
{
	[Serializable]
	[Token(Token = "0x2003CF6")]
	public class BoneData
	{
		[Token(Token = "0x4019E2B")]
		[FieldOffset(Offset = "0x8")]
		public int boneNameHash;

		[Token(Token = "0x4019E2C")]
		[FieldOffset(Offset = "0xC")]
		public int parentBoneNameHash;

		[Token(Token = "0x4019E2D")]
		[FieldOffset(Offset = "0x10")]
		public Transform boneTransform;

		[Token(Token = "0x4019E2E")]
		[FieldOffset(Offset = "0x14")]
		public UMATransform umaTransform;

		[Token(Token = "0x4019E2F")]
		[FieldOffset(Offset = "0x18")]
		public Quaternion rotation;

		[Token(Token = "0x4019E30")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4019E31")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 scale;

		[Token(Token = "0x4019E32")]
		[FieldOffset(Offset = "0x40")]
		public int accessedFrame;

		[Token(Token = "0x6018695")]
		[Address(RVA = "0x35E60C0", Offset = "0x35E60C0", VA = "0x35E60C0")]
		public BoneData()
		{
		}
	}

	[Token(Token = "0x2003CF7")]
	private sealed class _003CGetBoneHashes_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>, IFormattable, IComparable
	{
		[Token(Token = "0x4019E33")]
		[FieldOffset(Offset = "0x8")]
		internal Dictionary<int, BoneData>.KeyCollection.Enumerator _0024locvar0;

		[Token(Token = "0x4019E34")]
		[FieldOffset(Offset = "0x1C")]
		internal int _003Chash_003E__1;

		[Token(Token = "0x4019E35")]
		[FieldOffset(Offset = "0x20")]
		internal UMASkeleton _0024this;

		[Token(Token = "0x4019E36")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024current;

		[Token(Token = "0x4019E37")]
		[FieldOffset(Offset = "0x28")]
		internal bool _0024disposing;

		[Token(Token = "0x4019E38")]
		[FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x170019C3")]
		private int System_002ECollections_002EGeneric_002EIEnumerator_003Cint_003E_002ECurrent
		{
			[Token(Token = "0x6018698")]
			[Address(RVA = "0x35E9894", Offset = "0x35E9894", VA = "0x35E9894", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170019C4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6018699")]
			[Address(RVA = "0x35E989C", Offset = "0x35E989C", VA = "0x35E989C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6018696")]
		[Address(RVA = "0x35E6C04", Offset = "0x35E6C04", VA = "0x35E6C04")]
		public _003CGetBoneHashes_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6018697")]
		[Address(RVA = "0x35E96A4", Offset = "0x35E96A4", VA = "0x35E96A4", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601869A")]
		[Address(RVA = "0x35E9910", Offset = "0x35E9910", VA = "0x35E9910", Slot = "9")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601869B")]
		[Address(RVA = "0x35E9990", Offset = "0x35E9990", VA = "0x35E9990", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x601869C")]
		[Address(RVA = "0x35E9A18", Offset = "0x35E9A18", VA = "0x35E9A18", Slot = "4")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x601869D")]
		[Address(RVA = "0x35E9A1C", Offset = "0x35E9A1C", VA = "0x35E9A1C", Slot = "5")]
		private IEnumerator<int> System_002ECollections_002EGeneric_002EIEnumerable_003Cint_003E_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4019E26")]
	[FieldOffset(Offset = "0x8")]
	protected bool updating;

	[Token(Token = "0x4019E27")]
	[FieldOffset(Offset = "0xC")]
	protected int frame;

	[Token(Token = "0x4019E28")]
	[FieldOffset(Offset = "0x10")]
	private int _003CrootBoneHash_003Ek__BackingField;

	[Token(Token = "0x4019E29")]
	[FieldOffset(Offset = "0x14")]
	private List<BoneData> boneHashDataBackup;

	[Token(Token = "0x4019E2A")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, BoneData> boneHashDataLookup;

	[Token(Token = "0x170019BE")]
	public IEnumerable<int> BoneHashes
	{
		[Token(Token = "0x6018668")]
		[Address(RVA = "0x35E5908", Offset = "0x35E5908", VA = "0x35E5908")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019BF")]
	public string[] BoneNames
	{
		[Token(Token = "0x6018669")]
		[Address(RVA = "0x35E5918", Offset = "0x35E5918", VA = "0x35E5918")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019C0")]
	public int rootBoneHash
	{
		[Token(Token = "0x601866A")]
		[Address(RVA = "0x35E5BE4", Offset = "0x35E5BE4", VA = "0x35E5BE4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x601866B")]
		[Address(RVA = "0x35E550C", Offset = "0x35E550C", VA = "0x35E550C")]
		protected set
		{
		}
	}

	[Token(Token = "0x170019C1")]
	public virtual int boneCount
	{
		[Token(Token = "0x601866C")]
		[Address(RVA = "0x35E5BEC", Offset = "0x35E5BEC", VA = "0x35E5BEC", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170019C2")]
	private Dictionary<int, BoneData> boneHashData
	{
		[Token(Token = "0x601866D")]
		[Address(RVA = "0x35E5C6C", Offset = "0x35E5C6C", VA = "0x35E5C6C")]
		get
		{
			return null;
		}
		[Token(Token = "0x601866E")]
		[Address(RVA = "0x35E5514", Offset = "0x35E5514", VA = "0x35E5514")]
		set
		{
		}
	}

	[Token(Token = "0x6018666")]
	[Address(RVA = "0x35E53E4", Offset = "0x35E53E4", VA = "0x35E53E4")]
	public UMASkeleton(Transform rootBone)
	{
	}

	[Token(Token = "0x6018667")]
	[Address(RVA = "0x35E587C", Offset = "0x35E587C", VA = "0x35E587C")]
	protected UMASkeleton()
	{
	}

	[Token(Token = "0x601866F")]
	[Address(RVA = "0x35E5E48", Offset = "0x35E5E48", VA = "0x35E5E48", Slot = "5")]
	public virtual void BeginSkeletonUpdate()
	{
	}

	[Token(Token = "0x6018670")]
	[Address(RVA = "0x35E5E68", Offset = "0x35E5E68", VA = "0x35E5E68", Slot = "6")]
	public virtual void EndSkeletonUpdate()
	{
	}

	[Token(Token = "0x6018671")]
	[Address(RVA = "0x35E60B4", Offset = "0x35E60B4", VA = "0x35E60B4", Slot = "7")]
	public virtual void SetAnimatedBone(int nameHash)
	{
	}

	[Token(Token = "0x6018672")]
	[Address(RVA = "0x35E60B8", Offset = "0x35E60B8", VA = "0x35E60B8", Slot = "8")]
	public virtual void SetAnimatedBoneHierachy(int nameHash)
	{
	}

	[Token(Token = "0x6018673")]
	[Address(RVA = "0x35E60BC", Offset = "0x35E60BC", VA = "0x35E60BC", Slot = "9")]
	public virtual void ClearAnimatedBoneHierachy(int nameHash, bool recursive)
	{
	}

	[Token(Token = "0x6018674")]
	[Address(RVA = "0x35E55CC", Offset = "0x35E55CC", VA = "0x35E55CC")]
	private void AddBonesRecursive(Transform transform)
	{
	}

	[Token(Token = "0x6018675")]
	[Address(RVA = "0x35E61AC", Offset = "0x35E61AC", VA = "0x35E61AC", Slot = "10")]
	protected virtual BoneData GetBone(int nameHash)
	{
		return null;
	}

	[Token(Token = "0x6018676")]
	[Address(RVA = "0x35E624C", Offset = "0x35E624C", VA = "0x35E624C", Slot = "11")]
	public virtual bool HasBone(int nameHash)
	{
		return default(bool);
	}

	[Token(Token = "0x6018677")]
	[Address(RVA = "0x35E62D4", Offset = "0x35E62D4", VA = "0x35E62D4", Slot = "12")]
	public virtual void AddBone(int parentHash, int hash, Transform transform)
	{
	}

	[Token(Token = "0x6018678")]
	[Address(RVA = "0x35E6454", Offset = "0x35E6454", VA = "0x35E6454", Slot = "13")]
	public virtual void AddBone(UMATransform transform)
	{
	}

	[Token(Token = "0x6018679")]
	[Address(RVA = "0x35E672C", Offset = "0x35E672C", VA = "0x35E672C", Slot = "14")]
	public virtual void RemoveBone(int nameHash)
	{
	}

	[Token(Token = "0x601867A")]
	[Address(RVA = "0x35E6808", Offset = "0x35E6808", VA = "0x35E6808", Slot = "15")]
	public virtual bool TryGetBoneTransform(int nameHash, out Transform boneTransform, out bool transformDirty, out int parentBoneNameHash)
	{
		return default(bool);
	}

	[Token(Token = "0x601867B")]
	[Address(RVA = "0x35E696C", Offset = "0x35E696C", VA = "0x35E696C", Slot = "16")]
	public virtual Transform GetBoneTransform(int nameHash)
	{
		return null;
	}

	[Token(Token = "0x601867C")]
	[Address(RVA = "0x35E6A58", Offset = "0x35E6A58", VA = "0x35E6A58", Slot = "17")]
	public virtual GameObject GetBoneGameObject(int nameHash)
	{
		return null;
	}

	[Token(Token = "0x601867D")]
	[Address(RVA = "0x35E6B64", Offset = "0x35E6B64", VA = "0x35E6B64", Slot = "18")]
	protected virtual IEnumerable<int> GetBoneHashes()
	{
		return null;
	}

	[Token(Token = "0x601867E")]
	[Address(RVA = "0x35E591C", Offset = "0x35E591C", VA = "0x35E591C")]
	private string[] GetBoneNames()
	{
		return null;
	}

	[Token(Token = "0x601867F")]
	[Address(RVA = "0x35E6C0C", Offset = "0x35E6C0C", VA = "0x35E6C0C", Slot = "19")]
	public virtual void Set(int nameHash, Vector3 position, Vector3 scale, Quaternion rotation)
	{
	}

	[Token(Token = "0x6018680")]
	[Address(RVA = "0x35E6E2C", Offset = "0x35E6E2C", VA = "0x35E6E2C", Slot = "20")]
	public virtual void SetPosition(int nameHash, Vector3 position)
	{
	}

	[Token(Token = "0x6018681")]
	[Address(RVA = "0x35E6F4C", Offset = "0x35E6F4C", VA = "0x35E6F4C", Slot = "21")]
	public virtual void SetPositionRelative(int nameHash, Vector3 delta)
	{
	}

	[Token(Token = "0x6018682")]
	[Address(RVA = "0x35E70F0", Offset = "0x35E70F0", VA = "0x35E70F0", Slot = "22")]
	public virtual void SetScale(int nameHash, Vector3 scale)
	{
	}

	[Token(Token = "0x6018683")]
	[Address(RVA = "0x35E7210", Offset = "0x35E7210", VA = "0x35E7210", Slot = "23")]
	public virtual void SetScaleRelative(int nameHash, Vector3 scale)
	{
	}

	[Token(Token = "0x6018684")]
	[Address(RVA = "0x35E7390", Offset = "0x35E7390", VA = "0x35E7390", Slot = "24")]
	public virtual void SetRotation(int nameHash, Quaternion rotation)
	{
	}

	[Token(Token = "0x6018685")]
	[Address(RVA = "0x35E74B8", Offset = "0x35E74B8", VA = "0x35E74B8", Slot = "25")]
	public virtual void SetRotationRelative(int nameHash, Quaternion rotation, float weight)
	{
	}

	[Token(Token = "0x6018686")]
	[Address(RVA = "0x35E76D8", Offset = "0x35E76D8", VA = "0x35E76D8", Slot = "26")]
	public virtual void Lerp(int nameHash, Vector3 position, Vector3 scale, Quaternion rotation, float weight)
	{
	}

	[Token(Token = "0x6018687")]
	[Address(RVA = "0x35E7A48", Offset = "0x35E7A48", VA = "0x35E7A48", Slot = "27")]
	public virtual void Morph(int nameHash, Vector3 position, Vector3 scale, Quaternion rotation, float weight)
	{
	}

	[Token(Token = "0x6018688")]
	[Address(RVA = "0x35E7E5C", Offset = "0x35E7E5C", VA = "0x35E7E5C", Slot = "28")]
	public virtual bool Reset(int nameHash)
	{
		return default(bool);
	}

	[Token(Token = "0x6018689")]
	[Address(RVA = "0x35E80FC", Offset = "0x35E80FC", VA = "0x35E80FC", Slot = "29")]
	public virtual void ResetAll()
	{
	}

	[Token(Token = "0x601868A")]
	[Address(RVA = "0x35E8424", Offset = "0x35E8424", VA = "0x35E8424", Slot = "30")]
	public virtual bool Restore(int nameHash)
	{
		return default(bool);
	}

	[Token(Token = "0x601868B")]
	[Address(RVA = "0x35E8688", Offset = "0x35E8688", VA = "0x35E8688", Slot = "31")]
	public virtual void RestoreAll()
	{
	}

	[Token(Token = "0x601868C")]
	[Address(RVA = "0x35E8964", Offset = "0x35E8964", VA = "0x35E8964", Slot = "32")]
	public virtual Vector3 GetPosition(int nameHash)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601868D")]
	[Address(RVA = "0x35E8AC8", Offset = "0x35E8AC8", VA = "0x35E8AC8", Slot = "33")]
	public virtual Vector3 GetScale(int nameHash)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601868E")]
	[Address(RVA = "0x35E8C2C", Offset = "0x35E8C2C", VA = "0x35E8C2C", Slot = "34")]
	public virtual Quaternion GetRotation(int nameHash)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x601868F")]
	[Address(RVA = "0x35E8D90", Offset = "0x35E8D90", VA = "0x35E8D90")]
	public static int StringToHash(string name)
	{
		return default(int);
	}

	[Token(Token = "0x6018690")]
	[Address(RVA = "0x35E8D98", Offset = "0x35E8D98", VA = "0x35E8D98", Slot = "35")]
	public virtual Transform[] HashesToTransforms(int[] boneNameHashes)
	{
		return null;
	}

	[Token(Token = "0x6018691")]
	[Address(RVA = "0x35E8F20", Offset = "0x35E8F20", VA = "0x35E8F20", Slot = "36")]
	public virtual Transform[] HashesToTransforms(List<int> boneNameHashes)
	{
		return null;
	}

	[Token(Token = "0x6018692")]
	[Address(RVA = "0x35E90F0", Offset = "0x35E90F0", VA = "0x35E90F0", Slot = "37")]
	public virtual void EnsureBone(UMATransform umaTransform)
	{
	}

	[Token(Token = "0x6018693")]
	[Address(RVA = "0x35E9300", Offset = "0x35E9300", VA = "0x35E9300", Slot = "38")]
	public virtual void EnsureBoneHierarchy()
	{
	}

	[Token(Token = "0x6018694")]
	[Address(RVA = "0x35E968C", Offset = "0x35E968C", VA = "0x35E968C", Slot = "39")]
	public virtual Quaternion GetTPoseCorrectedRotation(int nameHash, Quaternion tPoseRotation)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}
}
