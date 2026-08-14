using System;
using Il2CppDummyDll;

namespace COW;

[Serializable]
[Token(Token = "0x2000817")]
public class MobileReplayHighlightEvent
{
	[Token(Token = "0x40050DF")]
	[FieldOffset(Offset = "0x8")]
	public float StartTime;

	[Token(Token = "0x40050E0")]
	[FieldOffset(Offset = "0xC")]
	public float EndTime;

	[Token(Token = "0x6003362")]
	[Address(RVA = "0x2278834", Offset = "0x2278834", VA = "0x2278834")]
	public MobileReplayHighlightEvent()
	{
	}
}
