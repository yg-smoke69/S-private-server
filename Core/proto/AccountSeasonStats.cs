using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017AB")]
public class AccountSeasonStats
{
	[Token(Token = "0x4009B12")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009B13")]
	[FieldOffset(Offset = "0x10")]
	public uint championship_type;

	[Token(Token = "0x4009B14")]
	[FieldOffset(Offset = "0x14")]
	public uint championship_id;

	[Token(Token = "0x4009B15")]
	[FieldOffset(Offset = "0x18")]
	public uint score;

	[Token(Token = "0x4009B16")]
	[FieldOffset(Offset = "0x1C")]
	public uint pos;

	[Token(Token = "0x6007E05")]
	[Address(RVA = "0x3179CD8", Offset = "0x3179CD8", VA = "0x3179CD8")]
	public AccountSeasonStats()
	{
	}
}
