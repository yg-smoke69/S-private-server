using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015CC")]
public class MysteryBonusProbability
{
	[Token(Token = "0x400944E")]
	[FieldOffset(Offset = "0x8")]
	public uint start_stage;

	[Token(Token = "0x400944F")]
	[FieldOffset(Offset = "0xC")]
	public uint end_stage;

	[Token(Token = "0x4009450")]
	[FieldOffset(Offset = "0x10")]
	public uint probability;

	[Token(Token = "0x6007C16")]
	[Address(RVA = "0x30A9634", Offset = "0x30A9634", VA = "0x30A9634")]
	public MysteryBonusProbability()
	{
	}
}
