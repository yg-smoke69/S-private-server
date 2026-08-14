using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001596")]
public class AccountTypedCupMatchInfo
{
	[Token(Token = "0x400939C")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x400939D")]
	[FieldOffset(Offset = "0x10")]
	public uint cup_type;

	[Token(Token = "0x400939E")]
	[FieldOffset(Offset = "0x14")]
	public uint cup_id;

	[Token(Token = "0x400939F")]
	[FieldOffset(Offset = "0x18")]
	public uint tier;

	[Token(Token = "0x40093A0")]
	[FieldOffset(Offset = "0x1C")]
	public string team_name;

	[Token(Token = "0x40093A1")]
	[FieldOffset(Offset = "0x20")]
	public string country_or_area;

	[Token(Token = "0x40093A2")]
	[FieldOffset(Offset = "0x24")]
	public uint head_pic;

	[Token(Token = "0x40093A3")]
	[FieldOffset(Offset = "0x28")]
	public uint banner_id;

	[Token(Token = "0x40093A4")]
	[FieldOffset(Offset = "0x2C")]
	public bool is_locked;

	[Token(Token = "0x40093A5")]
	[FieldOffset(Offset = "0x30")]
	public ulong captain_id;

	[Token(Token = "0x40093A6")]
	[FieldOffset(Offset = "0x38")]
	public uint member_num;

	[Token(Token = "0x40093A7")]
	[FieldOffset(Offset = "0x3C")]
	public uint win_count;

	[Token(Token = "0x40093A8")]
	[FieldOffset(Offset = "0x40")]
	public ulong[] member_ids;

	[Token(Token = "0x40093A9")]
	[FieldOffset(Offset = "0x44")]
	public bool is_qualified;

	[Token(Token = "0x40093AA")]
	[FieldOffset(Offset = "0x48")]
	public bool[] battle_record;

	[Token(Token = "0x6007BDE")]
	[Address(RVA = "0x3179CE8", Offset = "0x3179CE8", VA = "0x3179CE8")]
	public AccountTypedCupMatchInfo()
	{
	}
}
