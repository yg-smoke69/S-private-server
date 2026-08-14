using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CEF")]
public class UMAMeshData
{
	[Token(Token = "0x4019DF4")]
	[FieldOffset(Offset = "0x8")]
	public Matrix4x4[] bindPoses;

	[Token(Token = "0x4019DF5")]
	[FieldOffset(Offset = "0xC")]
	public UMABoneWeight[] boneWeights;

	[Token(Token = "0x4019DF6")]
	[FieldOffset(Offset = "0x10")]
	public BoneWeight[] unityBoneWeights;

	[Token(Token = "0x4019DF7")]
	[FieldOffset(Offset = "0x14")]
	public Vector3[] vertices;

	[Token(Token = "0x4019DF8")]
	[FieldOffset(Offset = "0x18")]
	public Vector4[] tangents;

	[Token(Token = "0x4019DF9")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3[] normals;

	[Token(Token = "0x4019DFA")]
	[FieldOffset(Offset = "0x20")]
	public Color32[] colors32;

	[Token(Token = "0x4019DFB")]
	[FieldOffset(Offset = "0x24")]
	public Vector2[] uv;

	[Token(Token = "0x4019DFC")]
	[FieldOffset(Offset = "0x28")]
	public Vector2[] uv2;

	[Token(Token = "0x4019DFD")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2[] uv3;

	[Token(Token = "0x4019DFE")]
	[FieldOffset(Offset = "0x30")]
	public Vector2[] uv4;

	[Token(Token = "0x4019DFF")]
	[FieldOffset(Offset = "0x34")]
	public UMABlendShape[] blendShapes;

	[Token(Token = "0x4019E00")]
	[FieldOffset(Offset = "0x38")]
	public SubMeshTriangles[] submeshes;

	[NonSerialized]
	[Token(Token = "0x4019E01")]
	[FieldOffset(Offset = "0x3C")]
	public Transform[] bones;

	[NonSerialized]
	[Token(Token = "0x4019E02")]
	[FieldOffset(Offset = "0x40")]
	public Transform rootBone;

	[Token(Token = "0x4019E03")]
	[FieldOffset(Offset = "0x44")]
	public UMATransform[] umaBones;

	[Token(Token = "0x4019E04")]
	[FieldOffset(Offset = "0x48")]
	public int umaBoneCount;

	[Token(Token = "0x4019E05")]
	[FieldOffset(Offset = "0x4C")]
	public int rootBoneHash;

	[Token(Token = "0x4019E06")]
	[FieldOffset(Offset = "0x50")]
	public int[] boneNameHashes;

	[Token(Token = "0x4019E07")]
	[FieldOffset(Offset = "0x54")]
	public int subMeshCount;

	[Token(Token = "0x4019E08")]
	[FieldOffset(Offset = "0x58")]
	public int vertexCount;

	[Token(Token = "0x4019E09")]
	[FieldOffset(Offset = "0x5C")]
	public string RootBoneName;

	[Token(Token = "0x4019E0A")]
	[FieldOffset(Offset = "0x60")]
	public bool optimized;

	[Token(Token = "0x4019E0B")]
	[FieldOffset(Offset = "0x64")]
	public uint[] optimizeduv;

	[Token(Token = "0x4019E0C")]
	[FieldOffset(Offset = "0x68")]
	public OptimizedBoneWeight[] optimizedBoneWeights;

	[Token(Token = "0x4019E0D")]
	[FieldOffset(Offset = "0x6C")]
	public OptimizedBoneWeightV2[] optimizedBoneWeightsV2;

	[Token(Token = "0x4019E0E")]
	[FieldOffset(Offset = "0x70")]
	public uint[] optimizedTangents;

	[Token(Token = "0x4019E0F")]
	[FieldOffset(Offset = "0x74")]
	public uint[] optimizedNormals;

	[Token(Token = "0x4019E10")]
	[FieldOffset(Offset = "0x78")]
	public uint[] optimizeduv2;

	[Token(Token = "0x4019E11")]
	[FieldOffset(Offset = "0x7C")]
	public byte[] optimizedVertArray;

	[Token(Token = "0x4019E12")]
	[FieldOffset(Offset = "0x80")]
	public byte[] optimizedNormalArray;

	[Token(Token = "0x4019E13")]
	[FieldOffset(Offset = "0x84")]
	public byte[] optimizedUVArray;

	[Token(Token = "0x4019E14")]
	[FieldOffset(Offset = "0x88")]
	public byte[] optimizedBoneWeightArray;

	[Token(Token = "0x4019E15")]
	[FieldOffset(Offset = "0x8C")]
	public SubMeshTrianglesNew[] optimizedSubMeshArray;

	[NonSerialized]
	[Token(Token = "0x4019E16")]
	public const int EXTRA_BONE_INDEX = 46;

	[NonSerialized]
	[Token(Token = "0x4019E17")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<int, int> BoneNameHashDict;

	[NonSerialized]
	[Token(Token = "0x4019E18")]
	[FieldOffset(Offset = "0x94")]
	private Dictionary<int, Matrix4x4> BindPoseDict;

	[NonSerialized]
	[Token(Token = "0x4019E19")]
	[FieldOffset(Offset = "0x98")]
	private Dictionary<int, UMATransform> BonesDict;

	[Token(Token = "0x4019E1A")]
	[FieldOffset(Offset = "0x9C")]
	public Matrix4x4[] extraBindPoses;

	[Token(Token = "0x4019E1B")]
	[FieldOffset(Offset = "0xA0")]
	public int[] extraBoneNameHashes;

	[Token(Token = "0x4019E1C")]
	[FieldOffset(Offset = "0xA4")]
	public UMATransform[] extraBones;

	[Token(Token = "0x4019E1D")]
	[FieldOffset(Offset = "0xA8")]
	public bool isMale;

	[Token(Token = "0x601861D")]
	[Address(RVA = "0x35E00F4", Offset = "0x35E00F4", VA = "0x35E00F4")]
	public UMAMeshData()
	{
	}

	[Token(Token = "0x601861E")]
	[Address(RVA = "0x35E0160", Offset = "0x35E0160", VA = "0x35E0160")]
	private bool OwnSharedBuffers()
	{
		return default(bool);
	}

	[Token(Token = "0x601861F")]
	[Address(RVA = "0x35E0168", Offset = "0x35E0168", VA = "0x35E0168")]
	public Dictionary<int, int> GetBoneNameHashDict()
	{
		return null;
	}

	[Token(Token = "0x6018620")]
	[Address(RVA = "0x35E0290", Offset = "0x35E0290", VA = "0x35E0290")]
	public Dictionary<int, Matrix4x4> GetBindPoseDict()
	{
		return null;
	}

	[Token(Token = "0x6018621")]
	[Address(RVA = "0x35E04D4", Offset = "0x35E04D4", VA = "0x35E04D4")]
	public Dictionary<int, UMATransform> GetBonesDict()
	{
		return null;
	}

	[Token(Token = "0x6018622")]
	[Address(RVA = "0x35E0654", Offset = "0x35E0654", VA = "0x35E0654")]
	public bool UseShareBones()
	{
		return default(bool);
	}

	[Token(Token = "0x6018623")]
	[Address(RVA = "0x35E067C", Offset = "0x35E067C", VA = "0x35E067C")]
	public int[] GetBoneHashs()
	{
		return null;
	}

	[Token(Token = "0x6018624")]
	[Address(RVA = "0x35E06AC", Offset = "0x35E06AC", VA = "0x35E06AC")]
	public Matrix4x4[] GetBonePoses()
	{
		return null;
	}

	[Token(Token = "0x6018625")]
	[Address(RVA = "0x35E06DC", Offset = "0x35E06DC", VA = "0x35E06DC")]
	public UMATransform[] GetUMABones()
	{
		return null;
	}

	[Token(Token = "0x6018626")]
	[Address(RVA = "0x35E0704", Offset = "0x35E0704", VA = "0x35E0704")]
	public bool ClaimSharedBuffers()
	{
		return default(bool);
	}

	[Token(Token = "0x6018627")]
	[Address(RVA = "0x35E070C", Offset = "0x35E070C", VA = "0x35E070C")]
	public void ReleaseSharedBuffers()
	{
	}

	[Token(Token = "0x6018628")]
	[Address(RVA = "0x35E0710", Offset = "0x35E0710", VA = "0x35E0710")]
	public void PrepareVertexBuffers(int size)
	{
	}

	[Token(Token = "0x6018629")]
	[Address(RVA = "0x35E0884", Offset = "0x35E0884", VA = "0x35E0884")]
	private static Transform RecursiveFindBone(Transform bone, string raceRoot)
	{
		return null;
	}

	[Token(Token = "0x601862A")]
	[Address(RVA = "0x35E09E4", Offset = "0x35E09E4", VA = "0x35E09E4")]
	private Transform FindRoot(Transform rootBone, Transform[] bones)
	{
		return null;
	}

	[Token(Token = "0x601862B")]
	[Address(RVA = "0x35E0BC8", Offset = "0x35E0BC8", VA = "0x35E0BC8")]
	private BoneWeight[] GetBoneWeights()
	{
		return null;
	}

	[Token(Token = "0x601862C")]
	[Address(RVA = "0x35E0C38", Offset = "0x35E0C38", VA = "0x35E0C38")]
	public Vector3[] GetNormals()
	{
		return null;
	}

	[Token(Token = "0x601862D")]
	[Address(RVA = "0x35E0C78", Offset = "0x35E0C78", VA = "0x35E0C78")]
	public Vector3[] GetVertices()
	{
		return null;
	}

	[Token(Token = "0x601862E")]
	[Address(RVA = "0x35E0C80", Offset = "0x35E0C80", VA = "0x35E0C80")]
	public Vector3[] GetVerticesNewAlloc()
	{
		return null;
	}

	[Token(Token = "0x601862F")]
	[Address(RVA = "0x35E0FB4", Offset = "0x35E0FB4", VA = "0x35E0FB4")]
	public void GetVerticesNew(ref Vector3[] dest, int destIndex)
	{
	}

	[Token(Token = "0x6018630")]
	[Address(RVA = "0x35E127C", Offset = "0x35E127C", VA = "0x35E127C")]
	public void GetVerticesNew(List<Vector3> dest, int destIndex)
	{
	}

	[Token(Token = "0x6018631")]
	[Address(RVA = "0x35E1648", Offset = "0x35E1648", VA = "0x35E1648")]
	public Vector3[] GetNormalNew()
	{
		return null;
	}

	[Token(Token = "0x6018632")]
	[Address(RVA = "0x35E18CC", Offset = "0x35E18CC", VA = "0x35E18CC")]
	public Vector2[] GetUVNew()
	{
		return null;
	}

	[Token(Token = "0x6018633")]
	[Address(RVA = "0x35E1B04", Offset = "0x35E1B04", VA = "0x35E1B04")]
	public Vector2[] GetUV2New()
	{
		return null;
	}

	[Token(Token = "0x6018634")]
	[Address(RVA = "0x35E1B7C", Offset = "0x35E1B7C", VA = "0x35E1B7C")]
	public BoneWeight[] GetBoneWeightNew()
	{
		return null;
	}

	[Token(Token = "0x6018635")]
	[Address(RVA = "0x35E1FFC", Offset = "0x35E1FFC", VA = "0x35E1FFC")]
	public SubMeshTriangles[] GetSubMesh()
	{
		return null;
	}

	[Token(Token = "0x6018636")]
	[Address(RVA = "0x35E2004", Offset = "0x35E2004", VA = "0x35E2004")]
	public SubMeshTriangles[] GetSubMeshNew()
	{
		return null;
	}

	[Token(Token = "0x6018637")]
	[Address(RVA = "0x35E22E0", Offset = "0x35E22E0", VA = "0x35E22E0")]
	public bool HasUV()
	{
		return default(bool);
	}

	[Token(Token = "0x6018638")]
	[Address(RVA = "0x35E2318", Offset = "0x35E2318", VA = "0x35E2318")]
	public bool HasUV2()
	{
		return default(bool);
	}

	[Token(Token = "0x6018639")]
	[Address(RVA = "0x35E1AC8", Offset = "0x35E1AC8", VA = "0x35E1AC8")]
	public Vector2[] GetUvs()
	{
		return null;
	}

	[Token(Token = "0x601863A")]
	[Address(RVA = "0x35E1B40", Offset = "0x35E1B40", VA = "0x35E1B40")]
	public Vector2[] GetUv2s()
	{
		return null;
	}

	[Token(Token = "0x601863B")]
	[Address(RVA = "0x35E24A4", Offset = "0x35E24A4", VA = "0x35E24A4")]
	public bool HasNormals()
	{
		return default(bool);
	}

	[Token(Token = "0x601863C")]
	[Address(RVA = "0x35E24D0", Offset = "0x35E24D0", VA = "0x35E24D0")]
	public bool HasTangents()
	{
		return default(bool);
	}

	[Token(Token = "0x601863D")]
	[Address(RVA = "0x35E2514", Offset = "0x35E2514", VA = "0x35E2514")]
	public Vector4[] GetTangents()
	{
		return null;
	}

	[Token(Token = "0x601863E")]
	[Address(RVA = "0x35E2554", Offset = "0x35E2554", VA = "0x35E2554")]
	public void ApplyDataToUnityMesh(SkinnedMeshRenderer renderer, UMASkeleton skeleton, List<Vector3> verticesList, List<Vector4> tangentsList, List<Vector3> normalsList, List<Vector2> uvList, List<Vector2> specialUVList, List<List<int>> trianglesList, List<Vector2> uv2List)
	{
	}

	[Token(Token = "0x601863F")]
	[Address(RVA = "0x35E2C68", Offset = "0x35E2C68", VA = "0x35E2C68")]
	private void CreateTransforms(UMASkeleton skeleton)
	{
	}

	[Token(Token = "0x6018640")]
	[Address(RVA = "0x35E2DC8", Offset = "0x35E2DC8", VA = "0x35E2DC8")]
	private void ApplySharedBuffers(Mesh mesh)
	{
	}

	[Token(Token = "0x6018641")]
	[Address(RVA = "0x35E2DCC", Offset = "0x35E2DCC", VA = "0x35E2DCC")]
	private void ComputeBoneNameHashes(Transform[] bones)
	{
	}

	[Token(Token = "0x6018642")]
	[Address(RVA = "0x35E2EF0", Offset = "0x35E2EF0", VA = "0x35E2EF0")]
	public static implicit operator bool(UMAMeshData obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6018643")]
	[Address(RVA = "0x35E2F0C", Offset = "0x35E2F0C", VA = "0x35E2F0C")]
	public bool Equals(UMAMeshData other)
	{
		return default(bool);
	}

	[Token(Token = "0x6018644")]
	[Address(RVA = "0x35E2FAC", Offset = "0x35E2FAC", VA = "0x35E2FAC", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6018645")]
	[Address(RVA = "0x35E2F5C", Offset = "0x35E2F5C", VA = "0x35E2F5C")]
	public static bool operator ==(UMAMeshData overlay, UMAMeshData obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6018646")]
	[Address(RVA = "0x35E309C", Offset = "0x35E309C", VA = "0x35E309C")]
	public static bool operator !=(UMAMeshData overlay, UMAMeshData obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6018647")]
	[Address(RVA = "0x35E30F4", Offset = "0x35E30F4", VA = "0x35E30F4", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6018648")]
	[Address(RVA = "0x35E1CE0", Offset = "0x35E1CE0", VA = "0x35E1CE0")]
	public static void TranlateBoneWeightArray(ref BoneWeight bw, int sourceIndex, byte[] boneWeightArray, int[] boneMapping)
	{
	}

	[Token(Token = "0x6018649")]
	[Address(RVA = "0x35E30FC", Offset = "0x35E30FC", VA = "0x35E30FC")]
	public static void TranlateBoneWeightToArray(int sourceIndex, byte[] boneWeightArray, ref BoneWeight bw)
	{
	}

	[Token(Token = "0x601864A")]
	[Address(RVA = "0x35E32C8", Offset = "0x35E32C8", VA = "0x35E32C8")]
	public static void UpdateBoneIndexForBoneWightArray(int sourceIndex, byte[] boneWeightArray, int[] boneMapping)
	{
	}

	[Token(Token = "0x601864B")]
	[Address(RVA = "0x35E34E0", Offset = "0x35E34E0", VA = "0x35E34E0")]
	public void TranslateBoneWeight(int boneMapping)
	{
	}

	[Token(Token = "0x601864C")]
	[Address(RVA = "0x35E34E4", Offset = "0x35E34E4", VA = "0x35E34E4")]
	public void OptimizeUMABoneWeights(BoneWeight[] inBoneWeights, UMACompressionMode compressMode)
	{
	}

	[Token(Token = "0x601864D")]
	[Address(RVA = "0x35E3680", Offset = "0x35E3680", VA = "0x35E3680")]
	public void OptimizeUMAVertices(Vector3[] inVertices, UMACompressionMode compressMode)
	{
	}

	[Token(Token = "0x601864E")]
	[Address(RVA = "0x35E3964", Offset = "0x35E3964", VA = "0x35E3964")]
	public void OptimizeUMANormals(Vector3[] inNormals, UMACompressionMode compressMode)
	{
	}

	[Token(Token = "0x601864F")]
	[Address(RVA = "0x35E3BEC", Offset = "0x35E3BEC", VA = "0x35E3BEC")]
	public void OptimizeUMATangents(Vector4[] inTangents, UMACompressionMode compressMode)
	{
	}

	[Token(Token = "0x6018650")]
	[Address(RVA = "0x35E3C0C", Offset = "0x35E3C0C", VA = "0x35E3C0C")]
	public void OptimizeUMAUVs(Vector2[] inUVs, UMACompressionMode compressMode, bool optimizeForUV2 = false)
	{
	}

	[Token(Token = "0x6018651")]
	[Address(RVA = "0x35E3D50", Offset = "0x35E3D50", VA = "0x35E3D50")]
	public void OptimizeUMASubMesh(Mesh sharedMesh, UMACompressionMode compressMode)
	{
	}

	[Token(Token = "0x6018652")]
	[Address(RVA = "0x35E3FD0", Offset = "0x35E3FD0", VA = "0x35E3FD0")]
	public bool OptimizeUMADataHigh()
	{
		return default(bool);
	}
}
