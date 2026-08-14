using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017A9")]
public class CSAccountLifeSeasonStatsReq
{
	[Token(Token = "0x4009B0A")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009B0B")]
	[FieldOffset(Offset = "0x10")]
	public uint championship_type;

	[Token(Token = "0x6007E03")]
	[Address(RVA = "0x317D860", Offset = "0x317D860", VA = "0x317D860")]
	public CSAccountLifeSeasonStatsReq()
	{
	}
}
