using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200141E")]
public class EManual
{
	[Token(Token = "0x200141F")]
	public enum State
	{
		[Token(Token = "0x4008C51")]
		State_COLLECTING,
		[Token(Token = "0x4008C52")]
		State_FINISHED,
		[Token(Token = "0x4008C53")]
		State_AWARDED
	}

	[Token(Token = "0x2001420")]
	public enum EventType
	{
		[Token(Token = "0x4008C55")]
		EventType_NONE,
		[Token(Token = "0x4008C56")]
		EventType_WEAPON,
		[Token(Token = "0x4008C57")]
		EventType_MAP,
		[Token(Token = "0x4008C58")]
		EventType_SUP,
		[Token(Token = "0x4008C59")]
		EventType_MOV,
		[Token(Token = "0x4008C5A")]
		EventType_EVE
	}

	[Token(Token = "0x6007AE1")]
	[Address(RVA = "0x309F340", Offset = "0x309F340", VA = "0x309F340")]
	public EManual()
	{
	}
}
