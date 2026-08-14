using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001537")]
public class CSGetWinnerTakesAllInfoRes
{
	[Token(Token = "0x400925E")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x400925F")]
	[FieldOffset(Offset = "0x10")]
	public uint match_num;

	[Token(Token = "0x4009260")]
	[FieldOffset(Offset = "0x14")]
	public uint last_update_at;

	[Token(Token = "0x4009261")]
	[FieldOffset(Offset = "0x18")]
	public WinnerTakesAllDesc wta_desc;

	[Token(Token = "0x4009262")]
	[FieldOffset(Offset = "0x20")]
	public long refresh_at;

	[Token(Token = "0x6007B7F")]
	[Address(RVA = "0x3096700", Offset = "0x3096700", VA = "0x3096700")]
	public CSGetWinnerTakesAllInfoRes()
	{
	}
}
