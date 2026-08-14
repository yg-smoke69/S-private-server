using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2003DEF")]
public class WwissObjectReferenceUnity : Object
{
	[Token(Token = "0x401A457")]
	[FieldOffset(Offset = "0xC")]
	public WwiseObjectReference refrence;

	[Token(Token = "0x6019340")]
	[Address(RVA = "0x33709DC", Offset = "0x33709DC", VA = "0x33709DC")]
	public WwissObjectReferenceUnity()
	{
	}

	[Token(Token = "0x6019341")]
	[Address(RVA = "0x337010C", Offset = "0x337010C", VA = "0x337010C")]
	public static implicit operator WwissObjectReferenceUnity(WwiseObjectReference object_ref)
	{
		return null;
	}

	[Token(Token = "0x6019342")]
	[Address(RVA = "0x337005C", Offset = "0x337005C", VA = "0x337005C")]
	public static implicit operator WwiseObjectReference(WwissObjectReferenceUnity object_unity)
	{
		return null;
	}
}
