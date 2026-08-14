using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Serializable]
[Token(Token = "0x20001F6")]
public class PetLobbyBasicActionConfig : ScriptableObject
{
	[Token(Token = "0x4000BBA")]
	[FieldOffset(Offset = "0xC")]
	public AnimationClip[] LobbyAnims;

	[Token(Token = "0x6000A2C")]
	[Address(RVA = "0x1BFDBF0", Offset = "0x1BFDBF0", VA = "0x1BFDBF0")]
	public PetLobbyBasicActionConfig()
	{
	}
}
