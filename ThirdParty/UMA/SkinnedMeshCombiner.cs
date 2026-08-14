using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003CB6")]
public static class SkinnedMeshCombiner
{
	[Token(Token = "0x2003CB7")]
	public class CombineInstance
	{
		[Token(Token = "0x4019C8E")]
		[FieldOffset(Offset = "0x8")]
		public UMAMeshData meshData;

		[Token(Token = "0x4019C8F")]
		[FieldOffset(Offset = "0xC")]
		public int[] targetSubmeshIndices;

		[Token(Token = "0x60184A9")]
		[Address(RVA = "0x2DEEA58", Offset = "0x2DEEA58", VA = "0x2DEEA58")]
		public CombineInstance()
		{
		}
	}

	[Token(Token = "0x2003CB8")]
	private enum MeshComponents
	{
		[Token(Token = "0x4019C91")]
		none = 0,
		[Token(Token = "0x4019C92")]
		has_normals = 1,
		[Token(Token = "0x4019C93")]
		has_tangents = 2,
		[Token(Token = "0x4019C94")]
		has_colors32 = 4,
		[Token(Token = "0x4019C95")]
		has_uv = 8,
		[Token(Token = "0x4019C96")]
		has_uv2 = 0x10,
		[Token(Token = "0x4019C97")]
		has_uv3 = 0x20,
		[Token(Token = "0x4019C98")]
		has_uv4 = 0x40,
		[Token(Token = "0x4019C99")]
		has_blendShapes = 0x80
	}

	[Token(Token = "0x2003CB9")]
	private class BoneIndexEntry
	{
		[Token(Token = "0x4019C9A")]
		[FieldOffset(Offset = "0x8")]
		public int index;

		[Token(Token = "0x4019C9B")]
		[FieldOffset(Offset = "0xC")]
		public List<int> indices;

		[Token(Token = "0x170019AE")]
		public int Count
		{
			[Token(Token = "0x60184AB")]
			[Address(RVA = "0x2DEE65C", Offset = "0x2DEE65C", VA = "0x2DEE65C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170019AF")]
		public int Item
		{
			[Token(Token = "0x60184AC")]
			[Address(RVA = "0x2DEE584", Offset = "0x2DEE584", VA = "0x2DEE584")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60184AA")]
		[Address(RVA = "0x2DEE7EC", Offset = "0x2DEE7EC", VA = "0x2DEE7EC")]
		public BoneIndexEntry()
		{
		}

		[Token(Token = "0x60184AD")]
		[Address(RVA = "0x2DEE6E4", Offset = "0x2DEE6E4", VA = "0x2DEE6E4")]
		internal void AddIndex(int idx)
		{
		}
	}

	[Token(Token = "0x4019C8A")]
	[FieldOffset(Offset = "0x0")]
	public static bool m_enableNewUMABuild;

	[Token(Token = "0x4019C8B")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<int, BoneIndexEntry> bonesCollection;

	[Token(Token = "0x4019C8C")]
	[FieldOffset(Offset = "0x8")]
	private static List<Matrix4x4> bindPoses;

	[Token(Token = "0x4019C8D")]
	[FieldOffset(Offset = "0xC")]
	private static List<int> bonesList;

	[Token(Token = "0x6018494")]
	[Address(RVA = "0x2DE7688", Offset = "0x2DE7688", VA = "0x2DE7688")]
	public static void BuildBones(UMAMeshData target, CombineInstance[] sources, bool ignoreBlendShapes = false)
	{
	}

	[Token(Token = "0x6018495")]
	[Address(RVA = "0x2DE94C4", Offset = "0x2DE94C4", VA = "0x2DE94C4")]
	public static void CombineMeshes(UMAMeshData target, CombineInstance[] sources, ref List<Vector3> verticesList, ref List<Vector4> tangentsList, ref List<Vector3> normalsList, ref List<Vector2> uvList, ref List<Vector2> uv2List, ref List<List<int>> trianglesList, int maxVertNum, bool ignoreBlendShapes = false, bool needTangent = true)
	{
	}

	[Token(Token = "0x6018496")]
	[Address(RVA = "0x2DE89BC", Offset = "0x2DE89BC", VA = "0x2DE89BC")]
	private static void MergeSortedTransforms(UMATransform[] mergedTransforms, ref int len1, UMATransform[] umaTransforms)
	{
	}

	[Token(Token = "0x6018497")]
	[Address(RVA = "0x2DE81FC", Offset = "0x2DE81FC", VA = "0x2DE81FC")]
	private static void AnalyzeSources(CombineInstance[] sources, int[] subMeshTriangleLength, ref int vertexCount, ref int bindPoseCount, ref int transformHierarchyCount, ref MeshComponents meshComponents, ref int blendShapeCount)
	{
	}

	[Token(Token = "0x6018498")]
	[Address(RVA = "0x2DE8138", Offset = "0x2DE8138", VA = "0x2DE8138")]
	private static int FindTargetSubMeshCount(CombineInstance[] sources)
	{
		return default(int);
	}

	[Token(Token = "0x6018499")]
	[Address(RVA = "0x2DECFDC", Offset = "0x2DECFDC", VA = "0x2DECFDC")]
	private static void BuildBoneWeights(UMAMeshData meshData, int sourceIndex, BoneWeight[] dest, int destIndex, int count, Dictionary<int, BoneIndexEntry> bonesCollection, List<Matrix4x4> bindPosesList, List<int> bonesList, int[] sharedBoneMapping, int[] nonSharedBoneMapping)
	{
	}

	[Token(Token = "0x601849A")]
	[Address(RVA = "0x2DEE180", Offset = "0x2DEE180", VA = "0x2DEE180")]
	public static bool CompareSkinningMatrices(ref Matrix4x4 m1, ref Matrix4x4 m2)
	{
		return default(bool);
	}

	[Token(Token = "0x601849B")]
	[Address(RVA = "0x2DE8EE8", Offset = "0x2DE8EE8", VA = "0x2DE8EE8")]
	private static int TranslateBoneIndex(int index, int[] bonesHashes, Matrix4x4[] bindPoses, Dictionary<int, BoneIndexEntry> bonesCollection, List<Matrix4x4> bindPosesList, List<int> bonesList)
	{
		return default(int);
	}

	[Token(Token = "0x601849C")]
	[Address(RVA = "0x2DEE7F4", Offset = "0x2DEE7F4", VA = "0x2DEE7F4")]
	private static void CopyColorsToColors32(Color[] source, int sourceIndex, Color32[] dest, int destIndex, int count)
	{
	}

	[Token(Token = "0x601849D")]
	[Address(RVA = "0x2DED668", Offset = "0x2DED668", VA = "0x2DED668")]
	private static void FillArray(Vector4[] array, int index, int count, Vector4 value)
	{
	}

	[Token(Token = "0x601849E")]
	[Address(RVA = "0x2DED5DC", Offset = "0x2DED5DC", VA = "0x2DED5DC")]
	private static void FillArray(Vector3[] array, int index, int count, Vector3 value)
	{
	}

	[Token(Token = "0x601849F")]
	[Address(RVA = "0x2DEDB34", Offset = "0x2DEDB34", VA = "0x2DEDB34")]
	private static void FillArray(Vector2[] array, int index, int count, Vector2 value)
	{
	}

	[Token(Token = "0x60184A0")]
	[Address(RVA = "0x2DEE9C8", Offset = "0x2DEE9C8", VA = "0x2DEE9C8")]
	private static void FillArray(Color[] array, int index, int count, Color value)
	{
	}

	[Token(Token = "0x60184A1")]
	[Address(RVA = "0x2DEDBA8", Offset = "0x2DEDBA8", VA = "0x2DEDBA8")]
	private static void FillArray(Color32[] array, int index, int count, Color32 value)
	{
	}

	[Token(Token = "0x60184A2")]
	[Address(RVA = "0x2DEDF94", Offset = "0x2DEDF94", VA = "0x2DEDF94")]
	private static void CopyIntArrayAdd(int[] source, int sourceIndex, int[] dest, int destIndex, int count, int add)
	{
	}

	[Token(Token = "0x60184A3")]
	[Address(RVA = "0x2DEDEBC", Offset = "0x2DEDEBC", VA = "0x2DEDEBC")]
	private static void CopyIntArrayAdd(int[] source, int sourceIndex, List<int> dest, int destIndex, int count, int add)
	{
	}

	[Token(Token = "0x60184A4")]
	[Address(RVA = "0x2DEDDB8", Offset = "0x2DEDDB8", VA = "0x2DEDDB8")]
	private static void CopyByteArrayAdd(byte[] source, int sourceIndex, int[] dest, int destIndex, int count, int add)
	{
	}

	[Token(Token = "0x60184A5")]
	[Address(RVA = "0x2DEDCC0", Offset = "0x2DEDCC0", VA = "0x2DEDCC0")]
	private static void CopyByteArrayAdd(byte[] source, int sourceIndex, List<int> dest, int destIndex, int count, int add)
	{
	}

	[Token(Token = "0x60184A6")]
	private static T[] EnsureArrayLength<T>(T[] oldArray, int newLength)
	{
		return null;
	}

	[Token(Token = "0x60184A7")]
	[Address(RVA = "0x2DED6F4", Offset = "0x2DED6F4", VA = "0x2DED6F4")]
	private static void AddSourceUVToDes(int uvIndex, UMAMeshData sourceMeshData, int vertexCount, int vertexIndex, ref List<Vector2> uvList, Vector2[] uv)
	{
	}
}
