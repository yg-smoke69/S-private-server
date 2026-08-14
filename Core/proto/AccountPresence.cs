using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200136D")]
public class AccountPresence
{
	[Token(Token = "0x4008950")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008951")]
	[FieldOffset(Offset = "0x10")]
	public string noti_region;

	[Token(Token = "0x4008952")]
	[FieldOffset(Offset = "0x14")]
	public EPresence.AccountPresence presence;

	[Token(Token = "0x4008953")]
	[FieldOffset(Offset = "0x18")]
	public long update_time;

	[Token(Token = "0x4008954")]
	[FieldOffset(Offset = "0x20")]
	public long login_time;

	[Token(Token = "0x4008955")]
	[FieldOffset(Offset = "0x28")]
	public ulong group_id;

	[Token(Token = "0x4008956")]
	[FieldOffset(Offset = "0x30")]
	public string group_region;

	[Token(Token = "0x4008957")]
	[FieldOffset(Offset = "0x34")]
	public string lock_region;

	[Token(Token = "0x4008958")]
	[FieldOffset(Offset = "0x38")]
	public uint match_mode;

	[Token(Token = "0x4008959")]
	[FieldOffset(Offset = "0x3C")]
	public uint game_mode;

	[Token(Token = "0x400895A")]
	[FieldOffset(Offset = "0x40")]
	public uint map_id;

	[Token(Token = "0x6007A6E")]
	[Address(RVA = "0x3179AC8", Offset = "0x3179AC8", VA = "0x3179AC8")]
	public AccountPresence()
	{
	}
}
