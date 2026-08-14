using System;
using Il2CppDummyDll;
using message;

[Serializable]
[Token(Token = "0x200070E")]
public class PVEHyakkiMatchAIHealthConfig
{
	[Token(Token = "0x4004BFB")]
	[FieldOffset(Offset = "0x8")]
	public LAKANBFBEOK AIType;

	[Token(Token = "0x4004BFC")]
	[FieldOffset(Offset = "0xC")]
	public string HealthParams;

	[Token(Token = "0x6002CD4")]
	[Address(RVA = "0x1C7912C", Offset = "0x1C7912C", VA = "0x1C7912C")]
	public PVEHyakkiMatchAIHealthConfig()
	{
	}
}
