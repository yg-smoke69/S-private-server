using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B8F")]
public class FFWSGuessingAwardDesc
{
	[Token(Token = "0x400AD50")]
	[FieldOffset(Offset = "0x8")]
	public uint session;

	[Token(Token = "0x400AD51")]
	[FieldOffset(Offset = "0xC")]
	public ELimitedEvent.FFWSGuessingAwardType award_enum;

	[Token(Token = "0x400AD52")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400AD53")]
	[FieldOffset(Offset = "0x14")]
	public uint guessing_entries;

	[Token(Token = "0x60081EA")]
	[Address(RVA = "0x30A0480", Offset = "0x30A0480", VA = "0x30A0480")]
	public FFWSGuessingAwardDesc()
	{
	}
}
