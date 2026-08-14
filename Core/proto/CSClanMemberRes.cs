using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001639")]
public class CSClanMemberRes
{
	[Token(Token = "0x4009574")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x4009575")]
	[FieldOffset(Offset = "0x10")]
	public ulong member_id;

	[Token(Token = "0x4009576")]
	[FieldOffset(Offset = "0x18")]
	public uint member_type;

	[Token(Token = "0x4009577")]
	[FieldOffset(Offset = "0x20")]
	public ulong join_at;

	[Token(Token = "0x4009578")]
	[FieldOffset(Offset = "0x28")]
	public uint honor_point;

	[Token(Token = "0x4009579")]
	[FieldOffset(Offset = "0x2C")]
	public uint race_point;

	[Token(Token = "0x400957A")]
	[FieldOffset(Offset = "0x30")]
	public ulong last_gain_rp_at;

	[Token(Token = "0x6007C83")]
	[Address(RVA = "0x317ED14", Offset = "0x317ED14", VA = "0x317ED14")]
	public CSClanMemberRes()
	{
	}
}
