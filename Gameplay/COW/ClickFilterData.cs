using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Serializable]
[Token(Token = "0x2002C5C")]
public class ClickFilterData
{
	[Token(Token = "0x4010EC2")]
	[FieldOffset(Offset = "0x8")]
	public string FilterKey;

	[Token(Token = "0x4010EC3")]
	[FieldOffset(Offset = "0xC")]
	public GameObject FilterGo;

	[Token(Token = "0x601282E")]
	[Address(RVA = "0x172C3F0", Offset = "0x172C3F0", VA = "0x172C3F0")]
	public ClickFilterData(string key, GameObject go)
	{
	}
}
