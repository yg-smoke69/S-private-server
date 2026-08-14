using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017A8")]
public class CSAccountLifeSeasonStats
{
	[Token(Token = "0x4009B07")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009B08")]
	[FieldOffset(Offset = "0x10")]
	public uint championship_type;

	[Token(Token = "0x4009B09")]
	[FieldOffset(Offset = "0x14")]
	public List<AccountSeasonStats> stats;

	[Token(Token = "0x6007E02")]
	[Address(RVA = "0x317D7D4", Offset = "0x317D7D4", VA = "0x317D7D4")]
	public CSAccountLifeSeasonStats()
	{
	}
}
