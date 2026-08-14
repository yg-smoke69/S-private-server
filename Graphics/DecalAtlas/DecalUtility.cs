using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DecalAtlas;

[Token(Token = "0x2003E9D")]
public static class DecalUtility
{
	[Token(Token = "0x401A728")]
	[FieldOffset(Offset = "0x0")]
	public static int maxDecalsInCell;

	[Token(Token = "0x401A729")]
	[FieldOffset(Offset = "0x4")]
	private static int _arraySize;

	[Token(Token = "0x401A72A")]
	[FieldOffset(Offset = "0x8")]
	private static byte[,] _array2D;

	[Token(Token = "0x401A72B")]
	[FieldOffset(Offset = "0xC")]
	private static byte _fillInNum;

	[Token(Token = "0x401A72C")]
	[FieldOffset(Offset = "0x10")]
	public static readonly Dictionary<int, GranularityDatum> DefaultGranularityData;

	[Token(Token = "0x401A72D")]
	[FieldOffset(Offset = "0x14")]
	public static readonly Dictionary<int, string> GranumlaritySuffix;

	[Token(Token = "0x6019799")]
	[Address(RVA = "0x231C9C8", Offset = "0x231C9C8", VA = "0x231C9C8")]
	private static void SetSize(int size)
	{
	}

	[Token(Token = "0x601979A")]
	[Address(RVA = "0x2319F14", Offset = "0x2319F14", VA = "0x2319F14")]
	public static void Init(int size)
	{
	}

	[Token(Token = "0x601979B")]
	[Address(RVA = "0x231CAD8", Offset = "0x231CAD8", VA = "0x231CAD8")]
	private static void CalculateLineCells(Vector2 p0, Vector2 p1, int step)
	{
	}

	[Token(Token = "0x601979C")]
	[Address(RVA = "0x231C27C", Offset = "0x231C27C", VA = "0x231C27C")]
	public static byte[,] CalculateCellVisiblity(List<Vector2> points, Vector2Int Offset, int gridSize, int xSize, int zSize)
	{
		return null;
	}

	[Token(Token = "0x601979D")]
	[Address(RVA = "0x231D478", Offset = "0x231D478", VA = "0x231D478")]
	private static void FillInside(int xSize, int zSize)
	{
	}
}
