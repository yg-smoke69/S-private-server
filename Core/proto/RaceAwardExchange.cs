using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200163E")]
public class RaceAwardExchange
{
	[Token(Token = "0x4009589")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x400958A")]
	[FieldOffset(Offset = "0x10")]
	public uint stage;

	[Token(Token = "0x400958B")]
	[FieldOffset(Offset = "0x18")]
	public ulong exchange_at;

	[Token(Token = "0x6007C88")]
	[Address(RVA = "0x33E03B4", Offset = "0x33E03B4", VA = "0x33E03B4")]
	public RaceAwardExchange()
	{
	}
}
