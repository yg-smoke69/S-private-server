using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DecalAtlas;

[Token(Token = "0x2003EA1")]
public class QuadDecalGroup : DecalGroup
{
	[Token(Token = "0x401A73B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector4[] VERTICES;

	[Token(Token = "0x401A73C")]
	[FieldOffset(Offset = "0x4")]
	private static readonly Vector4 Normal;

	[Token(Token = "0x401A73D")]
	[FieldOffset(Offset = "0x14")]
	private static readonly Vector2[] UVS;

	[Token(Token = "0x401A73E")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int[] TRIANGLES;

	[Token(Token = "0x401A73F")]
	[FieldOffset(Offset = "0x44")]
	public List<int> RectIndexes;

	[Token(Token = "0x401A740")]
	[FieldOffset(Offset = "0x48")]
	private List<Vector3> _RuntimeMeshVertices;

	[Token(Token = "0x401A741")]
	[FieldOffset(Offset = "0x4C")]
	private List<Vector3> _RuntimeMeshNormals;

	[Token(Token = "0x401A742")]
	[FieldOffset(Offset = "0x50")]
	private List<int> _RuntimeMeshTriangles;

	[Token(Token = "0x401A743")]
	[FieldOffset(Offset = "0x54")]
	private List<Vector2> _RuntimeMainTexUVs;

	[Token(Token = "0x401A744")]
	[FieldOffset(Offset = "0x58")]
	private List<Vector2> _UVArray;

	[Token(Token = "0x401A745")]
	[FieldOffset(Offset = "0x5C")]
	private List<Vector3> _NormalArray;

	[Token(Token = "0x401A746")]
	[FieldOffset(Offset = "0x60")]
	private List<Vector3> _VerticesArray;

	[Token(Token = "0x401A747")]
	[FieldOffset(Offset = "0x64")]
	private int decalNumLimit;

	[Token(Token = "0x401A748")]
	[FieldOffset(Offset = "0x68")]
	private readonly Vector3 farPos;

	[Token(Token = "0x60197A6")]
	[Address(RVA = "0x231F880", Offset = "0x231F880", VA = "0x231F880")]
	public QuadDecalGroup()
	{
	}

	[Token(Token = "0x60197A7")]
	[Address(RVA = "0x231F8E8", Offset = "0x231F8E8", VA = "0x231F8E8", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60197A8")]
	[Address(RVA = "0x231FB58", Offset = "0x231FB58", VA = "0x231FB58")]
	private void InitRuntimeContainer()
	{
	}

	[Token(Token = "0x60197A9")]
	[Address(RVA = "0x2320204", Offset = "0x2320204", VA = "0x2320204", Slot = "5")]
	protected override void UpdateDecalMesh(int swapDataIndex)
	{
	}

	[Token(Token = "0x60197AA")]
	[Address(RVA = "0x2320FD0", Offset = "0x2320FD0", VA = "0x2320FD0", Slot = "6")]
	public override void DrawDecalMesh()
	{
	}

	[Token(Token = "0x60197AB")]
	[Address(RVA = "0x23202A0", Offset = "0x23202A0", VA = "0x23202A0")]
	private void UpdateMesh(int swapDataIndex)
	{
	}
}
