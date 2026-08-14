using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013FD")]
public class RareProbability
{
	[Token(Token = "0x4008BDA")]
	[FieldOffset(Offset = "0x8")]
	public uint rare;

	[Token(Token = "0x4008BDB")]
	[FieldOffset(Offset = "0xC")]
	public uint probability;

	[Token(Token = "0x6007AD3")]
	[Address(RVA = "0x33E0EA8", Offset = "0x33E0EA8", VA = "0x33E0EA8")]
	public RareProbability()
	{
	}
}
