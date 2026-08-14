using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BC3")]
public class MocoMonthLevelRandomDesc
{
	[Token(Token = "0x400AEBA")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AEBB")]
	[FieldOffset(Offset = "0xC")]
	public uint lower_bound;

	[Token(Token = "0x400AEBC")]
	[FieldOffset(Offset = "0x10")]
	public uint upper_bound;

	[Token(Token = "0x400AEBD")]
	[FieldOffset(Offset = "0x14")]
	public string level_id;

	[Token(Token = "0x400AEBE")]
	[FieldOffset(Offset = "0x18")]
	public string weight;

	[Token(Token = "0x600821E")]
	[Address(RVA = "0x30A8BA4", Offset = "0x30A8BA4", VA = "0x30A8BA4")]
	public MocoMonthLevelRandomDesc()
	{
	}
}
