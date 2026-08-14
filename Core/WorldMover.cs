using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using WorldStreamer;

[Token(Token = "0x2003D48")]
public class WorldMover : MonoBehaviour
{
	[Token(Token = "0x4019FDC")]
	[FieldOffset(Offset = "0x0")]
	public static string WORLDMOVERTAG;

	[Token(Token = "0x4019FDD")]
	[FieldOffset(Offset = "0xC")]
	public float xTileRange;

	[Token(Token = "0x4019FDE")]
	[FieldOffset(Offset = "0x10")]
	public float yTileRange;

	[Token(Token = "0x4019FDF")]
	[FieldOffset(Offset = "0x14")]
	public float zTileRange;

	[Token(Token = "0x4019FE0")]
	[FieldOffset(Offset = "0x18")]
	public float xCurrentTile;

	[Token(Token = "0x4019FE1")]
	[FieldOffset(Offset = "0x1C")]
	public float yCurrentTile;

	[Token(Token = "0x4019FE2")]
	[FieldOffset(Offset = "0x20")]
	public float zCurrentTile;

	[Token(Token = "0x4019FE3")]
	[FieldOffset(Offset = "0x24")]
	public Streamer streamerMajor;

	[Token(Token = "0x4019FE4")]
	[FieldOffset(Offset = "0x28")]
	public Streamer[] streamerMinors;

	[Token(Token = "0x4019FE5")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 currentMove;

	[Token(Token = "0x4019FE6")]
	[FieldOffset(Offset = "0x38")]
	public List<Transform> objectsToMove;

	[Token(Token = "0x4019FE7")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 playerPositionMovedLooped;

	[Token(Token = "0x4019FE8")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 worldSize;

	[Token(Token = "0x6018830")]
	[Address(RVA = "0x2A6D868", Offset = "0x2A6D868", VA = "0x2A6D868")]
	public WorldMover()
	{
	}

	[Token(Token = "0x6018831")]
	[Address(RVA = "0x2A6D950", Offset = "0x2A6D950", VA = "0x2A6D950")]
	public void Start()
	{
	}

	[Token(Token = "0x6018832")]
	[Address(RVA = "0x2A6DCB0", Offset = "0x2A6DCB0", VA = "0x2A6DCB0")]
	public void Update()
	{
	}

	[Token(Token = "0x6018833")]
	[Address(RVA = "0x2A6E210", Offset = "0x2A6E210", VA = "0x2A6E210")]
	public void CheckMoverDistance(int xPosCurrent, int yPosCurrent, int zPosCurrent)
	{
	}

	[Token(Token = "0x6018834")]
	[Address(RVA = "0x2A6E37C", Offset = "0x2A6E37C", VA = "0x2A6E37C")]
	private void MoveWorld(int xPosCurrent, int yPosCurrent, int zPosCurrent)
	{
	}

	[Token(Token = "0x6018835")]
	[Address(RVA = "0x2A6EE40", Offset = "0x2A6EE40", VA = "0x2A6EE40")]
	public void MoveObject(Transform objectTransform)
	{
	}

	[Token(Token = "0x6018836")]
	[Address(RVA = "0x2A6EF3C", Offset = "0x2A6EF3C", VA = "0x2A6EF3C")]
	public void AddObjectToMove(Transform objectToMove)
	{
	}

	[Token(Token = "0x6018837")]
	[Address(RVA = "0x2A6E1DC", Offset = "0x2A6E1DC", VA = "0x2A6E1DC")]
	private float modf(float x, float m)
	{
		return default(float);
	}
}
