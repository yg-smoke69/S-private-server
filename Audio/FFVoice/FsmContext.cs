using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B5A")]
internal class FsmContext
{
	[Token(Token = "0x4019463")]
	[FieldOffset(Offset = "0x8")]
	public bool Return;

	[Token(Token = "0x4019464")]
	[FieldOffset(Offset = "0xC")]
	public int NextState;

	[Token(Token = "0x4019465")]
	[FieldOffset(Offset = "0x10")]
	public Lexer L;

	[Token(Token = "0x4019466")]
	[FieldOffset(Offset = "0x14")]
	public int StateStack;

	[Token(Token = "0x6017A09")]
	[Address(RVA = "0x321890C", Offset = "0x321890C", VA = "0x321890C")]
	public FsmContext()
	{
	}
}
