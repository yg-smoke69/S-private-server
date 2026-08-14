using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017A4")]
public class TeamMatchStats
{
	[Token(Token = "0x4009AF2")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009AF3")]
	[FieldOffset(Offset = "0x10")]
	public ulong[] member_account_ids;

	[Token(Token = "0x4009AF4")]
	[FieldOffset(Offset = "0x14")]
	public uint rank;

	[Token(Token = "0x4009AF5")]
	[FieldOffset(Offset = "0x18")]
	public uint kills;

	[Token(Token = "0x4009AF6")]
	[FieldOffset(Offset = "0x1C")]
	public uint damage;

	[Token(Token = "0x4009AF7")]
	[FieldOffset(Offset = "0x20")]
	public uint moving_distance;

	[Token(Token = "0x4009AF8")]
	[FieldOffset(Offset = "0x24")]
	public uint revival_count;

	[Token(Token = "0x4009AF9")]
	[FieldOffset(Offset = "0x28")]
	public uint survival_time;

	[Token(Token = "0x4009AFA")]
	[FieldOffset(Offset = "0x2C")]
	public uint headshot_kills;

	[Token(Token = "0x4009AFB")]
	[FieldOffset(Offset = "0x30")]
	public uint birth_island_quit;

	[Token(Token = "0x4009AFC")]
	[FieldOffset(Offset = "0x34")]
	public uint knockdown_count;

	[Token(Token = "0x4009AFD")]
	[FieldOffset(Offset = "0x38")]
	public uint team_count;

	[Token(Token = "0x4009AFE")]
	[FieldOffset(Offset = "0x3C")]
	public uint direct_kills;

	[Token(Token = "0x6007DFE")]
	[Address(RVA = "0x33E34D4", Offset = "0x33E34D4", VA = "0x33E34D4")]
	public TeamMatchStats()
	{
	}
}
