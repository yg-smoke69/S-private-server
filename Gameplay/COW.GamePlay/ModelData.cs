using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Serializable]
[Token(Token = "0x200046D")]
public class ModelData
{
	[Token(Token = "0x4003CEE")]
	[FieldOffset(Offset = "0x8")]
	public GameObject parent;

	[Token(Token = "0x4003CEF")]
	[FieldOffset(Offset = "0xC")]
	private Animator animator;

	[Token(Token = "0x6001640")]
	[Address(RVA = "0x1BECE80", Offset = "0x1BECE80", VA = "0x1BECE80")]
	public ModelData()
	{
	}
}
