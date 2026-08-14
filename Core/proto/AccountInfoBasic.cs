using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001368")]
public class AccountInfoBasic
{
	[Token(Token = "0x40088E7")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40088E8")]
	[FieldOffset(Offset = "0x10")]
	public uint account_type;

	[Token(Token = "0x40088E9")]
	[FieldOffset(Offset = "0x14")]
	public string nickname;

	[Token(Token = "0x40088EA")]
	[FieldOffset(Offset = "0x18")]
	public string external_id;

	[Token(Token = "0x40088EB")]
	[FieldOffset(Offset = "0x1C")]
	public string region;

	[Token(Token = "0x40088EC")]
	[FieldOffset(Offset = "0x20")]
	public uint level;

	[Token(Token = "0x40088ED")]
	[FieldOffset(Offset = "0x24")]
	public uint exp;

	[Token(Token = "0x40088EE")]
	[FieldOffset(Offset = "0x28")]
	public uint external_type;

	[Token(Token = "0x40088EF")]
	[FieldOffset(Offset = "0x2C")]
	public string external_name;

	[Token(Token = "0x40088F0")]
	[FieldOffset(Offset = "0x30")]
	public string external_icon;

	[Token(Token = "0x40088F1")]
	[FieldOffset(Offset = "0x34")]
	public uint banner_id;

	[Token(Token = "0x40088F2")]
	[FieldOffset(Offset = "0x38")]
	public uint head_pic;

	[Token(Token = "0x40088F3")]
	[FieldOffset(Offset = "0x3C")]
	public string clan_name;

	[Token(Token = "0x40088F4")]
	[FieldOffset(Offset = "0x40")]
	public uint rank;

	[Token(Token = "0x40088F5")]
	[FieldOffset(Offset = "0x44")]
	public uint ranking_points;

	[Token(Token = "0x40088F6")]
	[FieldOffset(Offset = "0x48")]
	public uint role;

	[Token(Token = "0x40088F7")]
	[FieldOffset(Offset = "0x4C")]
	public bool has_elite_pass;

	[Token(Token = "0x40088F8")]
	[FieldOffset(Offset = "0x50")]
	public uint badge_cnt;

	[Token(Token = "0x40088F9")]
	[FieldOffset(Offset = "0x54")]
	public uint badge_id;

	[Token(Token = "0x40088FA")]
	[FieldOffset(Offset = "0x58")]
	public uint season_id;

	[Token(Token = "0x40088FB")]
	[FieldOffset(Offset = "0x5C")]
	public uint liked;

	[Token(Token = "0x40088FC")]
	[FieldOffset(Offset = "0x60")]
	public bool is_deleted;

	[Token(Token = "0x40088FD")]
	[FieldOffset(Offset = "0x61")]
	public bool show_rank;

	[Token(Token = "0x40088FE")]
	[FieldOffset(Offset = "0x68")]
	public long last_login_at;

	[Token(Token = "0x40088FF")]
	[FieldOffset(Offset = "0x70")]
	public ulong external_uid;

	[Token(Token = "0x4008900")]
	[FieldOffset(Offset = "0x78")]
	public long return_at;

	[Token(Token = "0x4008901")]
	[FieldOffset(Offset = "0x80")]
	public string championship_team_name;

	[Token(Token = "0x4008902")]
	[FieldOffset(Offset = "0x84")]
	public uint championship_team_member_num;

	[Token(Token = "0x4008903")]
	[FieldOffset(Offset = "0x88")]
	public ulong championship_team_id;

	[Token(Token = "0x4008904")]
	[FieldOffset(Offset = "0x90")]
	public uint cs_rank;

	[Token(Token = "0x4008905")]
	[FieldOffset(Offset = "0x94")]
	public uint cs_ranking_points;

	[Token(Token = "0x4008906")]
	[FieldOffset(Offset = "0x98")]
	public uint[] weapon_skin_shows;

	[Token(Token = "0x4008907")]
	[FieldOffset(Offset = "0x9C")]
	public uint pin_id;

	[Token(Token = "0x4008908")]
	[FieldOffset(Offset = "0xA0")]
	public bool is_cs_ranking_ban;

	[Token(Token = "0x4008909")]
	[FieldOffset(Offset = "0xA4")]
	public uint max_rank;

	[Token(Token = "0x400890A")]
	[FieldOffset(Offset = "0xA8")]
	public uint cs_max_rank;

	[Token(Token = "0x400890B")]
	[FieldOffset(Offset = "0xAC")]
	public uint max_ranking_points;

	[Token(Token = "0x400890C")]
	[FieldOffset(Offset = "0xB0")]
	public uint game_bag_show;

	[Token(Token = "0x400890D")]
	[FieldOffset(Offset = "0xB4")]
	public uint peak_rank_pos;

	[Token(Token = "0x400890E")]
	[FieldOffset(Offset = "0xB8")]
	public uint cs_peak_rank_pos;

	[Token(Token = "0x400890F")]
	[FieldOffset(Offset = "0xBC")]
	public AccountPrefers account_prefers;

	[Token(Token = "0x4008910")]
	[FieldOffset(Offset = "0xC0")]
	public uint periodic_ranking_points;

	[Token(Token = "0x4008911")]
	[FieldOffset(Offset = "0xC4")]
	public uint periodic_rank;

	[Token(Token = "0x6007A69")]
	[Address(RVA = "0x3179630", Offset = "0x3179630", VA = "0x3179630")]
	public AccountInfoBasic()
	{
	}
}
