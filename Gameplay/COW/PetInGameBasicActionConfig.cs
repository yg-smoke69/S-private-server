using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Serializable]
[Token(Token = "0x20001F4")]
public class PetInGameBasicActionConfig : ScriptableObject
{
	[Token(Token = "0x4000BB3")]
	[FieldOffset(Offset = "0xC")]
	public PetAnimClipInfo[] IngameAnims;

	[Token(Token = "0x6000A28")]
	[Address(RVA = "0x1BFD5D8", Offset = "0x1BFD5D8", VA = "0x1BFD5D8")]
	public PetInGameBasicActionConfig()
	{
	}
}
