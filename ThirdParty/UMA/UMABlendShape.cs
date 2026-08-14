using System;
using Il2CppDummyDll;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CEC")]
public class UMABlendShape
{
	[Token(Token = "0x4019DF2")]
	[FieldOffset(Offset = "0x8")]
	public string shapeName;

	[Token(Token = "0x4019DF3")]
	[FieldOffset(Offset = "0xC")]
	public UMABlendFrame[] frames;

	[Token(Token = "0x601860C")]
	[Address(RVA = "0x2DEDC14", Offset = "0x2DEDC14", VA = "0x2DEDC14")]
	public UMABlendShape()
	{
	}
}
