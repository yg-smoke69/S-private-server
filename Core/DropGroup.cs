using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000787")]
public class DropGroup : MonoBehaviour
{
	[Token(Token = "0x4004E65")]
	[FieldOffset(Offset = "0xC")]
	public int DropGroupID;

	[Token(Token = "0x4004E66")]
	[FieldOffset(Offset = "0x10")]
	public float Height;

	[Token(Token = "0x4004E67")]
	[FieldOffset(Offset = "0x14")]
	public float Speed;

	[Token(Token = "0x4004E68")]
	[FieldOffset(Offset = "0x18")]
	public int Num;

	[Token(Token = "0x4004E69")]
	[FieldOffset(Offset = "0x1C")]
	public List<DropConfig> DropStartPoints;

	[Token(Token = "0x600305D")]
	[Address(RVA = "0x232485C", Offset = "0x232485C", VA = "0x232485C")]
	public DropGroup()
	{
	}
}
