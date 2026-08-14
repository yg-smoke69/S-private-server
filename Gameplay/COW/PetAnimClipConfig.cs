using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Serializable]
[Token(Token = "0x20001F2")]
public class PetAnimClipConfig
{
	[Token(Token = "0x4000BAD")]
	[FieldOffset(Offset = "0x8")]
	public PetActionTag AnimType;

	[Token(Token = "0x4000BAE")]
	[FieldOffset(Offset = "0xC")]
	public AnimationClip AnimClip;

	[Token(Token = "0x6000A23")]
	[Address(RVA = "0x1BF97F4", Offset = "0x1BF97F4", VA = "0x1BF97F4")]
	public PetAnimClipConfig()
	{
	}

	[Token(Token = "0x6000A24")]
	[Address(RVA = "0x1BF97FC", Offset = "0x1BF97FC", VA = "0x1BF97FC")]
	public static implicit operator PetAnimClipInfo(PetAnimClipConfig conf)
	{
		return null;
	}
}
