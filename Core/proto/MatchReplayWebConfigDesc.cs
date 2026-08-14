using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C2E")]
public class MatchReplayWebConfigDesc
{
	[Token(Token = "0x400B16F")]
	[FieldOffset(Offset = "0x8")]
	public string test_url;

	[Token(Token = "0x400B170")]
	[FieldOffset(Offset = "0xC")]
	public string live_url;

	[Token(Token = "0x400B171")]
	[FieldOffset(Offset = "0x10")]
	public uint timeout;

	[Token(Token = "0x6008292")]
	[Address(RVA = "0x30A7DD8", Offset = "0x30A7DD8", VA = "0x30A7DD8")]
	public MatchReplayWebConfigDesc()
	{
	}
}
