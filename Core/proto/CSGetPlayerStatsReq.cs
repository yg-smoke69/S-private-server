using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001517")]
public class CSGetPlayerStatsReq
{
	[Token(Token = "0x40090AF")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40090B0")]
	[FieldOffset(Offset = "0x10")]
	public uint match_mode;

	[Token(Token = "0x6007B60")]
	[Address(RVA = "0x3094980", Offset = "0x3094980", VA = "0x3094980")]
	public CSGetPlayerStatsReq()
	{
	}
}
