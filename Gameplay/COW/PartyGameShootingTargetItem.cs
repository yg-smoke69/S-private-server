using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Serializable]
[Token(Token = "0x20001C6")]
public class PartyGameShootingTargetItem
{
	[Token(Token = "0x4000AED")]
	[FieldOffset(Offset = "0x8")]
	public Vector3 transfrom;

	[Token(Token = "0x4000AEE")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 rotation;

	[Token(Token = "0x4000AEF")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 scale;

	[Token(Token = "0x6000989")]
	[Address(RVA = "0x28D0044", Offset = "0x28D0044", VA = "0x28D0044")]
	public PartyGameShootingTargetItem()
	{
	}
}
