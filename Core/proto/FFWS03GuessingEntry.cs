using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001891")]
public class FFWS03GuessingEntry
{
	[Token(Token = "0x4009D37")]
	[FieldOffset(Offset = "0x8")]
	public uint entry_id;

	[Token(Token = "0x4009D38")]
	[FieldOffset(Offset = "0xC")]
	public uint ai_guess_id;

	[Token(Token = "0x4009D39")]
	[FieldOffset(Offset = "0x10")]
	public uint player_guess_id;

	[Token(Token = "0x4009D3A")]
	[FieldOffset(Offset = "0x14")]
	public ELimitedEvent.FFWSGuessingAwardStatus award_status;

	[Token(Token = "0x6007EEA")]
	[Address(RVA = "0x30A0270", Offset = "0x30A0270", VA = "0x30A0270")]
	public FFWS03GuessingEntry()
	{
	}
}
