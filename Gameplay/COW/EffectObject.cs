using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FBD")]
public class EffectObject
{
	[Token(Token = "0x400C718")]
	[FieldOffset(Offset = "0x8")]
	public EEffectType effectType;

	[Token(Token = "0x400C719")]
	[FieldOffset(Offset = "0xC")]
	public bool isLoop;

	[Token(Token = "0x400C71A")]
	[FieldOffset(Offset = "0x10")]
	public GameObject gameObject;

	[Token(Token = "0x6009EB2")]
	[Address(RVA = "0x25218D4", Offset = "0x25218D4", VA = "0x25218D4")]
	public EffectObject()
	{
	}
}
