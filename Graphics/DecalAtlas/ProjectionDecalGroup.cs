using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DecalAtlas;

[Token(Token = "0x2003E9F")]
public class ProjectionDecalGroup : DecalGroup
{
	[Serializable]
	[Token(Token = "0x2003EA0")]
	public class DecalData
	{
		[Token(Token = "0x401A738")]
		[FieldOffset(Offset = "0x8")]
		public Vector4[] MainTexRects;

		[Token(Token = "0x401A739")]
		[FieldOffset(Offset = "0xC")]
		public Matrix4x4[] TransformLocalToWorlds;

		[Token(Token = "0x401A73A")]
		[FieldOffset(Offset = "0x10")]
		public Vector4[] RendererWorldToLocalRows;

		[Token(Token = "0x60197A5")]
		[Address(RVA = "0x231F878", Offset = "0x231F878", VA = "0x231F878")]
		public DecalData()
		{
		}
	}

	[Token(Token = "0x401A72F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Vector4[] VERTICES;

	[Token(Token = "0x401A730")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int[] TRIANGLES;

	[Token(Token = "0x401A731")]
	[FieldOffset(Offset = "0x44")]
	private List<Vector3> _RuntimeMeshVertices;

	[Token(Token = "0x401A732")]
	[FieldOffset(Offset = "0x48")]
	private List<int> _RuntimeMeshTriangles;

	[Token(Token = "0x401A733")]
	[FieldOffset(Offset = "0x4C")]
	private List<Vector4> _RuntimeMainTexRects;

	[Token(Token = "0x401A734")]
	[FieldOffset(Offset = "0x50")]
	private List<Vector4> _RuntimeWorldToLocalRow0;

	[Token(Token = "0x401A735")]
	[FieldOffset(Offset = "0x54")]
	private List<Vector4> _RuntimeWorldToLocalRow1;

	[Token(Token = "0x401A736")]
	[FieldOffset(Offset = "0x58")]
	private List<Vector4> _RuntimeWorldToLocalRow2;

	[Token(Token = "0x401A737")]
	[FieldOffset(Offset = "0x5C")]
	public DecalData PersistDecals;

	[Token(Token = "0x60197A0")]
	[Address(RVA = "0x231E0BC", Offset = "0x231E0BC", VA = "0x231E0BC")]
	public ProjectionDecalGroup()
	{
	}

	[Token(Token = "0x60197A1")]
	[Address(RVA = "0x231E0CC", Offset = "0x231E0CC", VA = "0x231E0CC", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60197A2")]
	[Address(RVA = "0x231E6BC", Offset = "0x231E6BC", VA = "0x231E6BC", Slot = "6")]
	public override void DrawDecalMesh()
	{
	}

	[Token(Token = "0x60197A3")]
	[Address(RVA = "0x231E6C0", Offset = "0x231E6C0", VA = "0x231E6C0", Slot = "5")]
	protected override void UpdateDecalMesh(int swapDataIndex)
	{
	}
}
