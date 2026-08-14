using System;
using Il2CppDummyDll;
using message;

namespace COW;

[Serializable]
[Token(Token = "0x2000A5E")]
internal class ReplayEvent
{
	[Token(Token = "0x4005BEE")]
	[FieldOffset(Offset = "0x8")]
	public OLDFDLECCBG Event;

	[Token(Token = "0x4005BEF")]
	[FieldOffset(Offset = "0xC")]
	public uint PlayerID;

	[Token(Token = "0x4005BF0")]
	[FieldOffset(Offset = "0x10")]
	public float Time;

	[Token(Token = "0x4005BF1")]
	[FieldOffset(Offset = "0x14")]
	public float FParam;

	[Token(Token = "0x4005BF2")]
	[FieldOffset(Offset = "0x18")]
	public string SParam;

	[Token(Token = "0x6005054")]
	[Address(RVA = "0x2400348", Offset = "0x2400348", VA = "0x2400348")]
	public ReplayEvent()
	{
	}
}
