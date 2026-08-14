using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D1F")]
public class SceneStreamerInfo : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2003D20")]
	private class MaterialInfo
	{
		[Token(Token = "0x4019EEF")]
		[FieldOffset(Offset = "0x8")]
		public List<int> TextureMatIDList;

		[Token(Token = "0x4019EF0")]
		[FieldOffset(Offset = "0xC")]
		public List<uint> TextureIndexList;

		[Token(Token = "0x4019EF1")]
		[FieldOffset(Offset = "0x10")]
		public List<Texture> Textures;

		[Token(Token = "0x4019EF2")]
		[FieldOffset(Offset = "0x14")]
		public Material OwnedMat;

		[Token(Token = "0x6018775")]
		[Address(RVA = "0x21C4AD0", Offset = "0x21C4AD0", VA = "0x21C4AD0")]
		public MaterialInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003D21")]
	private class MeshInfo
	{
		[Token(Token = "0x4019EF3")]
		[FieldOffset(Offset = "0x8")]
		public uint TargetMeshIndex;

		[Token(Token = "0x4019EF4")]
		[FieldOffset(Offset = "0xC")]
		public Mesh TargetMesh;

		[Token(Token = "0x4019EF5")]
		[FieldOffset(Offset = "0x10")]
		public MeshFilter OwnedMeshFilter;

		[Token(Token = "0x6018776")]
		[Address(RVA = "0x21C4BC4", Offset = "0x21C4BC4", VA = "0x21C4BC4")]
		public MeshInfo()
		{
		}
	}

	[Token(Token = "0x4019EEB")]
	[FieldOffset(Offset = "0xC")]
	private List<MaterialInfo> MaterialInfos;

	[Token(Token = "0x4019EEC")]
	[FieldOffset(Offset = "0x10")]
	private List<MeshInfo> MeshInfos;

	[NonSerialized]
	[Token(Token = "0x4019EED")]
	[FieldOffset(Offset = "0x14")]
	public List<StreamerMeshInfo> OwnedMeshInfos;

	[NonSerialized]
	[Token(Token = "0x4019EEE")]
	[FieldOffset(Offset = "0x18")]
	public List<StreamerTextureInfo> OwnedTextureInfos;

	[Token(Token = "0x6018772")]
	[Address(RVA = "0x21C3E34", Offset = "0x21C3E34", VA = "0x21C3E34")]
	public SceneStreamerInfo()
	{
	}

	[Token(Token = "0x6018773")]
	[Address(RVA = "0x21C3EF4", Offset = "0x21C3EF4", VA = "0x21C3EF4")]
	private void Start()
	{
	}

	[Token(Token = "0x6018774")]
	[Address(RVA = "0x21C47AC", Offset = "0x21C47AC", VA = "0x21C47AC")]
	private void OnDestroy()
	{
	}
}
