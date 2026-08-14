using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003CD4")]
public class UMADefaultMeshCombiner : UMAMeshCombiner
{
	[Token(Token = "0x4019D78")]
	[FieldOffset(Offset = "0xC")]
	protected List<SkinnedMeshCombiner.CombineInstance> combinedMeshList;

	[Token(Token = "0x4019D79")]
	[FieldOffset(Offset = "0x10")]
	protected Material[] combinedMaterialList;

	[Token(Token = "0x4019D7A")]
	[FieldOffset(Offset = "0x14")]
	private int atlasResolution;

	[Token(Token = "0x4019D7B")]
	[FieldOffset(Offset = "0x0")]
	public static int MAX_VERT_NUM;

	[Token(Token = "0x4019D7C")]
	[FieldOffset(Offset = "0x18")]
	public List<Vector3> verticesList;

	[Token(Token = "0x4019D7D")]
	[FieldOffset(Offset = "0x1C")]
	public List<Vector4> tangentsList;

	[Token(Token = "0x4019D7E")]
	[FieldOffset(Offset = "0x20")]
	public List<Vector3> normalsList;

	[Token(Token = "0x4019D7F")]
	[FieldOffset(Offset = "0x24")]
	public List<Vector2> uvList;

	[Token(Token = "0x4019D80")]
	[FieldOffset(Offset = "0x28")]
	public List<Vector2> uv2List;

	[Token(Token = "0x4019D81")]
	[FieldOffset(Offset = "0x2C")]
	public List<Vector2> specialUVList;

	[Token(Token = "0x4019D82")]
	[FieldOffset(Offset = "0x30")]
	public List<List<int>> trianglesList;

	[Token(Token = "0x4019D83")]
	[FieldOffset(Offset = "0x34")]
	private string useSpecialUVShaderName;

	[Token(Token = "0x4019D84")]
	[FieldOffset(Offset = "0x38")]
	private string noTangentShaderName;

	[Token(Token = "0x6018591")]
	[Address(RVA = "0x2DFE97C", Offset = "0x2DFE97C", VA = "0x2DFE97C")]
	public UMADefaultMeshCombiner()
	{
	}

	[Token(Token = "0x6018592")]
	[Address(RVA = "0x2DFE9FC", Offset = "0x2DFE9FC", VA = "0x2DFE9FC")]
	public void Start()
	{
	}

	[Token(Token = "0x6018593")]
	[Address(RVA = "0x2DFECF8", Offset = "0x2DFECF8", VA = "0x2DFECF8")]
	protected void EnsureUMADataSetup(UMAData umaData)
	{
	}

	[Token(Token = "0x6018594")]
	[Address(RVA = "0x2DFF728", Offset = "0x2DFF728", VA = "0x2DFF728", Slot = "4")]
	public override void UpdateUMAMesh(bool updatedAtlas, UMAData umaData, int atlasResolution)
	{
	}

	[Token(Token = "0x6018595")]
	[Address(RVA = "0x2DFFDC8", Offset = "0x2DFFDC8", VA = "0x2DFFDC8")]
	protected void BuildCombineInstances(UMAData umaData)
	{
	}

	[Token(Token = "0x6018596")]
	[Address(RVA = "0x2E00208", Offset = "0x2E00208", VA = "0x2E00208")]
	protected bool NeedTangent(UMAData umaData)
	{
		return default(bool);
	}

	[Token(Token = "0x6018597")]
	[Address(RVA = "0x2E00394", Offset = "0x2E00394", VA = "0x2E00394")]
	protected void RecalculateUV(UMAMeshData umaMesh, UMAData umaData)
	{
	}
}
