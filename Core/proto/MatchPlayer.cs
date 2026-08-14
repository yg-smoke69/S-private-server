using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013E2")]
public class MatchPlayer
{
	[Token(Token = "0x4008B63")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008B64")]
	[FieldOffset(Offset = "0x10")]
	public int ranking_points;

	[Token(Token = "0x4008B65")]
	[FieldOffset(Offset = "0x14")]
	public uint dead_order;

	[Token(Token = "0x4008B66")]
	[FieldOffset(Offset = "0x18")]
	public string nickname;

	[Token(Token = "0x6007AC3")]
	[Address(RVA = "0x30A7B38", Offset = "0x30A7B38", VA = "0x30A7B38")]
	public MatchPlayer()
	{
	}
}
