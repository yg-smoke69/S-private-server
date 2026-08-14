using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Serializable]
[Token(Token = "0x20001C7")]
public class PartyGameShootingTargetTransformConfig : ScriptableObject
{
	[Token(Token = "0x4000AF0")]
	[FieldOffset(Offset = "0xC")]
	public List<PartyGameShootingTargetItem> PartyGameShootingList;

	[Token(Token = "0x600098A")]
	[Address(RVA = "0x28D004C", Offset = "0x28D004C", VA = "0x28D004C")]
	public PartyGameShootingTargetTransformConfig()
	{
	}
}
