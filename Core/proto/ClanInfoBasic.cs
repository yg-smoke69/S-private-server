using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013BA")]
public class ClanInfoBasic
{
	[Token(Token = "0x4008ADE")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x4008ADF")]
	[FieldOffset(Offset = "0x10")]
	public string clan_name;

	[Token(Token = "0x4008AE0")]
	[FieldOffset(Offset = "0x18")]
	public ulong captain_id;

	[Token(Token = "0x4008AE1")]
	[FieldOffset(Offset = "0x20")]
	public uint clan_level;

	[Token(Token = "0x4008AE2")]
	[FieldOffset(Offset = "0x24")]
	public uint capacity;

	[Token(Token = "0x4008AE3")]
	[FieldOffset(Offset = "0x28")]
	public uint member_num;

	[Token(Token = "0x4008AE4")]
	[FieldOffset(Offset = "0x2C")]
	public uint honor_point;

	[Token(Token = "0x6007AA5")]
	[Address(RVA = "0x309BAC4", Offset = "0x309BAC4", VA = "0x309BAC4")]
	public ClanInfoBasic()
	{
	}
}
