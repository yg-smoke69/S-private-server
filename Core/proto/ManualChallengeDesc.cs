using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AF0")]
public class ManualChallengeDesc
{
	[Token(Token = "0x400A952")]
	[FieldOffset(Offset = "0x8")]
	public uint event_id;

	[Token(Token = "0x400A953")]
	[FieldOffset(Offset = "0xC")]
	public EManual.EventType Type;

	[Token(Token = "0x400A954")]
	[FieldOffset(Offset = "0x10")]
	public uint param1;

	[Token(Token = "0x400A955")]
	[FieldOffset(Offset = "0x14")]
	public uint param2;

	[Token(Token = "0x600814B")]
	[Address(RVA = "0x30A7850", Offset = "0x30A7850", VA = "0x30A7850")]
	public ManualChallengeDesc()
	{
	}
}
