using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B57")]
public class SupercarRoundAward
{
	[Token(Token = "0x400ABFC")]
	[FieldOffset(Offset = "0x8")]
	public uint round_id;

	[Token(Token = "0x400ABFD")]
	[FieldOffset(Offset = "0xC")]
	public AwardDesc award;

	[Token(Token = "0x60081B2")]
	[Address(RVA = "0x33E2F44", Offset = "0x33E2F44", VA = "0x33E2F44")]
	public SupercarRoundAward()
	{
	}
}
