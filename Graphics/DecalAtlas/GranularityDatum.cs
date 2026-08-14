using System;
using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace DecalAtlas;

[Serializable]
[Token(Token = "0x2003E99")]
public class GranularityDatum
{
	[Token(Token = "0x401A712")]
	[FieldOffset(Offset = "0x8")]
	public int Granularity;

	[Token(Token = "0x401A713")]
	[FieldOffset(Offset = "0xC")]
	public float[] DistanceByQuality;

	[Token(Token = "0x401A714")]
	[FieldOffset(Offset = "0x10")]
	public float GridSize;

	[Token(Token = "0x401A715")]
	[FieldOffset(Offset = "0x14")]
	public bool Enabled;

	[Token(Token = "0x401A716")]
	[FieldOffset(Offset = "0x18")]
	public bool[] CellExistances;

	[NonSerialized]
	[Token(Token = "0x401A717")]
	[FieldOffset(Offset = "0x1C")]
	public int[] CellsNeedUpdate;

	[NonSerialized]
	[Token(Token = "0x401A718")]
	[FieldOffset(Offset = "0x20")]
	public List<Vector2Int> VisibleCells;

	[NonSerialized]
	[Token(Token = "0x401A719")]
	[FieldOffset(Offset = "0x24")]
	public byte[][] CellVisibleCorners;

	[NonSerialized]
	[Token(Token = "0x401A71A")]
	[FieldOffset(Offset = "0x28")]
	public Vector2Int CellsXZ;

	[NonSerialized]
	[Token(Token = "0x401A71B")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 CameraLeft;

	[NonSerialized]
	[Token(Token = "0x401A71C")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 CameraRight;

	[Token(Token = "0x601978F")]
	[Address(RVA = "0x231DC8C", Offset = "0x231DC8C", VA = "0x231DC8C")]
	public GranularityDatum(int granularity, float size, float[] distanceByQuality)
	{
	}

	[Token(Token = "0x6019790")]
	[Address(RVA = "0x231A2A0", Offset = "0x231A2A0", VA = "0x231A2A0")]
	public static int DistanceIndexForQuality(GAGILKKDDMJ quality)
	{
		return default(int);
	}

	[Token(Token = "0x6019791")]
	[Address(RVA = "0x231DCBC", Offset = "0x231DCBC", VA = "0x231DCBC")]
	public static float GetDecalVisiablePerCentByQuality(GAGILKKDDMJ quality)
	{
		return default(float);
	}

	[Token(Token = "0x6019792")]
	[Address(RVA = "0x2319FFC", Offset = "0x2319FFC", VA = "0x2319FFC")]
	public void Load(Rect terrainRect)
	{
	}
}
