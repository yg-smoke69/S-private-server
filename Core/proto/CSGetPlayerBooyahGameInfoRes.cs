using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001843")]
public class CSGetPlayerBooyahGameInfoRes
{
	[Token(Token = "0x4009C85")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009C86")]
	[FieldOffset(Offset = "0x10")]
	public uint booyah_wins;

	[Token(Token = "0x4009C87")]
	[FieldOffset(Offset = "0x14")]
	public uint booyah_chess_wins;

	[Token(Token = "0x6007E9D")]
	[Address(RVA = "0x30948CC", Offset = "0x30948CC", VA = "0x30948CC")]
	public CSGetPlayerBooyahGameInfoRes()
	{
	}
}
