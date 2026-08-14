using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032CA")]
public class RuleMapping
{
	[Token(Token = "0x401355A")]
	[FieldOffset(Offset = "0x8")]
	public string Tab;

	[Token(Token = "0x401355B")]
	[FieldOffset(Offset = "0xC")]
	public string Content;

	[Token(Token = "0x401355C")]
	[FieldOffset(Offset = "0x10")]
	public bool DoLoced;

	[Token(Token = "0x60156CE")]
	[Address(RVA = "0x241BB28", Offset = "0x241BB28", VA = "0x241BB28")]
	public RuleMapping(string tabKey, string contentKey)
	{
	}
}
