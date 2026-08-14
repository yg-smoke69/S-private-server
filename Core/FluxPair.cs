using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20007EE")]
public class FluxPair
{
	[Token(Token = "0x4005012")]
	[FieldOffset(Offset = "0x8")]
	public HangString hangstring;

	[Token(Token = "0x4005013")]
	[FieldOffset(Offset = "0xC")]
	public List<string> collidernames;

	[Token(Token = "0x6003216")]
	[Address(RVA = "0x26ADDE4", Offset = "0x26ADDE4", VA = "0x26ADDE4")]
	public FluxPair()
	{
	}
}
