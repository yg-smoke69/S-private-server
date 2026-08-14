using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001563")]
public class AccountLeaderboardProfile
{
	[Token(Token = "0x40092FD")]
	[FieldOffset(Offset = "0x8")]
	public AccountInfoBasic basic_info;

	[Token(Token = "0x40092FE")]
	[FieldOffset(Offset = "0xC")]
	public AccountInfoWithStats stat;

	[Token(Token = "0x40092FF")]
	[FieldOffset(Offset = "0x10")]
	public uint rank;

	[Token(Token = "0x4009300")]
	[FieldOffset(Offset = "0x14")]
	public uint ranking_points;

	[Token(Token = "0x4009301")]
	[FieldOffset(Offset = "0x18")]
	public byte[] limited_event_info;

	[Token(Token = "0x6007BAB")]
	[Address(RVA = "0x317995C", Offset = "0x317995C", VA = "0x317995C")]
	public AccountLeaderboardProfile()
	{
	}
}
