using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BA2")]
public class HurricaneBTeamSettingDesc
{
	[Token(Token = "0x400ADD2")]
	[FieldOffset(Offset = "0x8")]
	public uint max_member_num;

	[Token(Token = "0x400ADD3")]
	[FieldOffset(Offset = "0xC")]
	public uint process_per_level;

	[Token(Token = "0x400ADD4")]
	[FieldOffset(Offset = "0x10")]
	public string invite_bg;

	[Token(Token = "0x400ADD5")]
	[FieldOffset(Offset = "0x14")]
	public uint process_per_loop_reward;

	[Token(Token = "0x400ADD6")]
	[FieldOffset(Offset = "0x18")]
	public EInventory.AwardType award_type;

	[Token(Token = "0x400ADD7")]
	[FieldOffset(Offset = "0x1C")]
	public uint award_id;

	[Token(Token = "0x400ADD8")]
	[FieldOffset(Offset = "0x20")]
	public uint award_num;

	[Token(Token = "0x400ADD9")]
	[FieldOffset(Offset = "0x24")]
	public uint award_expire_time;

	[Token(Token = "0x60081FD")]
	[Address(RVA = "0x30A3604", Offset = "0x30A3604", VA = "0x30A3604")]
	public HurricaneBTeamSettingDesc()
	{
	}
}
