using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Serializable]
[Token(Token = "0x2000429")]
public class CameraParam
{
	[Token(Token = "0x4003B6E")]
	[FieldOffset(Offset = "0x8")]
	public uint chessType;

	[Token(Token = "0x4003B6F")]
	[FieldOffset(Offset = "0xC")]
	public GameObject point;

	[Token(Token = "0x60014A2")]
	[Address(RVA = "0x1E953DC", Offset = "0x1E953DC", VA = "0x1E953DC")]
	public CameraParam()
	{
	}
}
