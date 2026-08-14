using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000793")]
public class SpawnGroup : MonoBehaviour
{
	[Token(Token = "0x4004EA4")]
	[FieldOffset(Offset = "0xC")]
	public int GroupID;

	[Token(Token = "0x4004EA5")]
	[FieldOffset(Offset = "0x10")]
	public float Speed;

	[Token(Token = "0x4004EA6")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 SpeedDirection;

	[Token(Token = "0x4004EA7")]
	[FieldOffset(Offset = "0x20")]
	public int Num;

	[Token(Token = "0x4004EA8")]
	[FieldOffset(Offset = "0x24")]
	public int Weight;

	[Token(Token = "0x4004EA9")]
	[FieldOffset(Offset = "0x28")]
	public List<SpawnConfig> DropStartPoints;

	[Token(Token = "0x600308C")]
	[Address(RVA = "0x21D763C", Offset = "0x21D763C", VA = "0x21D763C")]
	public SpawnGroup()
	{
	}
}
