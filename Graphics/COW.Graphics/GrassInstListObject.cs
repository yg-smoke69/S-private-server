using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Serializable]
[Token(Token = "0x2003F59")]
public class GrassInstListObject : ScriptableObject
{
	[Token(Token = "0x401AB48")]
	[FieldOffset(Offset = "0xC")]
	public List<GrassInst> m_grassInstList;

	[Token(Token = "0x6019CBA")]
	[Address(RVA = "0x25AA2A4", Offset = "0x25AA2A4", VA = "0x25AA2A4")]
	public GrassInstListObject()
	{
	}
}
