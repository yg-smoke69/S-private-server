using Il2CppDummyDll;

namespace LitJson;

[Token(Token = "0x2003B89")]
internal class FsmContext
{
	[Token(Token = "0x40195CE")]
	[FieldOffset(Offset = "0x8")]
	public bool Return;

	[Token(Token = "0x40195CF")]
	[FieldOffset(Offset = "0xC")]
	public int NextState;

	[Token(Token = "0x40195D0")]
	[FieldOffset(Offset = "0x10")]
	public Lexer L;

	[Token(Token = "0x40195D1")]
	[FieldOffset(Offset = "0x14")]
	public int StateStack;

	[Token(Token = "0x6017BFD")]
	[Address(RVA = "0x31182F4", Offset = "0x31182F4", VA = "0x31182F4")]
	public FsmContext()
	{
	}
}
