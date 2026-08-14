using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003FD8")]
public class PerfInfo
{
	[Token(Token = "0x401ADE0")]
	[FieldOffset(Offset = "0x8")]
	public float height;

	[Token(Token = "0x401ADE1")]
	[FieldOffset(Offset = "0xC")]
	public int matNum;

	[Token(Token = "0x401ADE2")]
	[FieldOffset(Offset = "0x10")]
	public HashSet<Material> materials;

	[Token(Token = "0x401ADE3")]
	[FieldOffset(Offset = "0x14")]
	public int drawCallNum;

	[Token(Token = "0x401ADE4")]
	[FieldOffset(Offset = "0x18")]
	public int drawCallNumInTotal;

	[Token(Token = "0x401ADE5")]
	[FieldOffset(Offset = "0x1C")]
	public int tris;

	[Token(Token = "0x401ADE6")]
	[FieldOffset(Offset = "0x20")]
	public int trisInTotal;

	[Token(Token = "0x401ADE7")]
	[FieldOffset(Offset = "0x24")]
	public string hint;

	[Token(Token = "0x401ADE8")]
	[FieldOffset(Offset = "0x28")]
	public int warning;

	[Token(Token = "0x6019FC1")]
	[Address(RVA = "0x1C79C9C", Offset = "0x1C79C9C", VA = "0x1C79C9C")]
	public PerfInfo()
	{
	}
}
