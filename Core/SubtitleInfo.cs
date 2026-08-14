using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2001DFD")]
public class SubtitleInfo
{
	[Token(Token = "0x400BE13")]
	[FieldOffset(Offset = "0x8")]
	public string content;

	[Token(Token = "0x400BE14")]
	[FieldOffset(Offset = "0xC")]
	public string voiceResIDName;

	[Token(Token = "0x400BE15")]
	[FieldOffset(Offset = "0x10")]
	public float duration;

	[Token(Token = "0x6008F8B")]
	[Address(RVA = "0x21DB754", Offset = "0x21DB754", VA = "0x21DB754")]
	public SubtitleInfo()
	{
	}
}
