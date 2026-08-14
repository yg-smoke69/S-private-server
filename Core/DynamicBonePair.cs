using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20007ED")]
public class DynamicBonePair
{
	[Token(Token = "0x4005010")]
	[FieldOffset(Offset = "0x8")]
	public DynamicBone dynamicbone;

	[Token(Token = "0x4005011")]
	[FieldOffset(Offset = "0xC")]
	public List<string> collidernames;

	[Token(Token = "0x6003215")]
	[Address(RVA = "0x31FF594", Offset = "0x31FF594", VA = "0x31FF594")]
	public DynamicBonePair()
	{
	}
}
