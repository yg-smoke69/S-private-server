using System;
using Il2CppDummyDll;
using message;

[Serializable]
[Token(Token = "0x2001DFE")]
public class SkillSubtitleInfo
{
	[Token(Token = "0x400BE16")]
	[FieldOffset(Offset = "0x8")]
	public OPKPPFDNCMC skillType;

	[Token(Token = "0x400BE17")]
	[FieldOffset(Offset = "0xC")]
	public SubtitleInfo subtitleInfo;

	[Token(Token = "0x6008F8C")]
	[Address(RVA = "0x21D1840", Offset = "0x21D1840", VA = "0x21D1840")]
	public SkillSubtitleInfo()
	{
	}
}
