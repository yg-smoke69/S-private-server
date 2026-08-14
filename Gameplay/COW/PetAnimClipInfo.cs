using System;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Serializable]
[Token(Token = "0x20001F1")]
public class PetAnimClipInfo
{
	[Token(Token = "0x4000BAB")]
	[FieldOffset(Offset = "0x8")]
	public ODFIIFHKNNG AnimType;

	[Token(Token = "0x4000BAC")]
	[FieldOffset(Offset = "0xC")]
	public AnimationClip AnimClip;

	[Token(Token = "0x6000A22")]
	[Address(RVA = "0x1BF9918", Offset = "0x1BF9918", VA = "0x1BF9918")]
	public PetAnimClipInfo()
	{
	}
}
