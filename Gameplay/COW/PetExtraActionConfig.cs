using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Serializable]
[Token(Token = "0x20001F0")]
public class PetExtraActionConfig : ScriptableObject
{
	[Token(Token = "0x4000BAA")]
	[FieldOffset(Offset = "0xC")]
	public PetAnimClipConfig[] ExtraAnims;

	[Token(Token = "0x6000A21")]
	[Address(RVA = "0x1BFD30C", Offset = "0x1BFD30C", VA = "0x1BFD30C")]
	public PetExtraActionConfig()
	{
	}
}
