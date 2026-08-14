using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001519")]
public class CSGetPlayerTCStatsReq
{
	[Token(Token = "0x40090B4")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40090B5")]
	[FieldOffset(Offset = "0x10")]
	public uint season_id;

	[Token(Token = "0x40090B6")]
	[FieldOffset(Offset = "0x14")]
	public uint game_mode;

	[Token(Token = "0x40090B7")]
	[FieldOffset(Offset = "0x18")]
	public uint match_mode;

	[Token(Token = "0x6007B62")]
	[Address(RVA = "0x3094990", Offset = "0x3094990", VA = "0x3094990")]
	public CSGetPlayerTCStatsReq()
	{
	}
}
