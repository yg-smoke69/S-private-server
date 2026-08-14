using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D40")]
public class TerrainNeighbours : MonoBehaviour
{
	[Token(Token = "0x4019FC8")]
	[FieldOffset(Offset = "0xC")]
	public List<Terrain> terrainsToOmit;

	[Token(Token = "0x4019FC9")]
	[FieldOffset(Offset = "0x10")]
	public WorldMover worldMover;

	[Token(Token = "0x4019FCA")]
	[FieldOffset(Offset = "0x14")]
	public List<Terrain> _terrains;

	[Token(Token = "0x4019FCB")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int[], Terrain> _terrainDict;

	[Token(Token = "0x4019FCC")]
	[FieldOffset(Offset = "0x1C")]
	private Vector2 firstPosition;

	[Token(Token = "0x4019FCD")]
	[FieldOffset(Offset = "0x24")]
	private int sizeX;

	[Token(Token = "0x4019FCE")]
	[FieldOffset(Offset = "0x28")]
	private int sizeZ;

	[Token(Token = "0x4019FCF")]
	[FieldOffset(Offset = "0x2C")]
	private bool firstPositonSet;

	[Token(Token = "0x6018817")]
	[Address(RVA = "0x21DE5B8", Offset = "0x21DE5B8", VA = "0x21DE5B8")]
	public TerrainNeighbours()
	{
	}

	[Token(Token = "0x6018818")]
	[Address(RVA = "0x21DE644", Offset = "0x21DE644", VA = "0x21DE644")]
	private void Start()
	{
	}

	[Token(Token = "0x6018819")]
	[Address(RVA = "0x21DE648", Offset = "0x21DE648", VA = "0x21DE648")]
	public void CreateNeighbours()
	{
	}
}
