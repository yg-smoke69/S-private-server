using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200136A")]
public class AccountInfoWithPresence
{
	[Token(Token = "0x4008918")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008919")]
	[FieldOffset(Offset = "0x10")]
	public uint account_type;

	[Token(Token = "0x400891A")]
	[FieldOffset(Offset = "0x14")]
	public string nickname;

	[Token(Token = "0x400891B")]
	[FieldOffset(Offset = "0x18")]
	public string external_id;

	[Token(Token = "0x400891C")]
	[FieldOffset(Offset = "0x1C")]
	public string external_name;

	[Token(Token = "0x400891D")]
	[FieldOffset(Offset = "0x20")]
	public string region;

	[Token(Token = "0x400891E")]
	[FieldOffset(Offset = "0x24")]
	public string portrait;

	[Token(Token = "0x400891F")]
	[FieldOffset(Offset = "0x28")]
	public uint level;

	[Token(Token = "0x4008920")]
	[FieldOffset(Offset = "0x2C")]
	public uint exp;

	[Token(Token = "0x4008921")]
	[FieldOffset(Offset = "0x30")]
	public long update_time;

	[Token(Token = "0x4008922")]
	[FieldOffset(Offset = "0x38")]
	public AccountInfoWithStats solo_stats;

	[Token(Token = "0x4008923")]
	[FieldOffset(Offset = "0x3C")]
	public AccountInfoWithStats duo_stats;

	[Token(Token = "0x4008924")]
	[FieldOffset(Offset = "0x40")]
	public AccountInfoWithStats quad_stats;

	[Token(Token = "0x4008925")]
	[FieldOffset(Offset = "0x44")]
	public uint external_type;

	[Token(Token = "0x4008926")]
	[FieldOffset(Offset = "0x48")]
	public AccountInfoWithStats solo_ranking_stats;

	[Token(Token = "0x4008927")]
	[FieldOffset(Offset = "0x4C")]
	public AccountInfoWithStats duo_ranking_stats;

	[Token(Token = "0x4008928")]
	[FieldOffset(Offset = "0x50")]
	public AccountInfoWithStats quad_ranking_stats;

	[Token(Token = "0x4008929")]
	[FieldOffset(Offset = "0x54")]
	public uint rank;

	[Token(Token = "0x400892A")]
	[FieldOffset(Offset = "0x58")]
	public uint ranking_points;

	[Token(Token = "0x400892B")]
	[FieldOffset(Offset = "0x5C")]
	public AccountInfoWithStats solo_casual_stats;

	[Token(Token = "0x400892C")]
	[FieldOffset(Offset = "0x60")]
	public AccountInfoWithStats duo_casual_stats;

	[Token(Token = "0x400892D")]
	[FieldOffset(Offset = "0x64")]
	public AccountInfoWithStats quad_casual_stats;

	[Token(Token = "0x400892E")]
	[FieldOffset(Offset = "0x68")]
	public uint banner_id;

	[Token(Token = "0x400892F")]
	[FieldOffset(Offset = "0x6C")]
	public uint head_pic;

	[Token(Token = "0x4008930")]
	[FieldOffset(Offset = "0x70")]
	public string clan_name;

	[Token(Token = "0x4008931")]
	[FieldOffset(Offset = "0x74")]
	public bool has_elite_pass;

	[Token(Token = "0x4008932")]
	[FieldOffset(Offset = "0x78")]
	public uint badge_cnt;

	[Token(Token = "0x4008933")]
	[FieldOffset(Offset = "0x7C")]
	public uint badge_id;

	[Token(Token = "0x4008934")]
	[FieldOffset(Offset = "0x80")]
	public bool is_deleted;

	[Token(Token = "0x4008935")]
	[FieldOffset(Offset = "0x81")]
	public bool show_rank;

	[Token(Token = "0x4008936")]
	[FieldOffset(Offset = "0x88")]
	public long last_login_at;

	[Token(Token = "0x4008937")]
	[FieldOffset(Offset = "0x90")]
	public ulong external_uid;

	[Token(Token = "0x4008938")]
	[FieldOffset(Offset = "0x98")]
	public uint role;

	[Token(Token = "0x4008939")]
	[FieldOffset(Offset = "0x9C")]
	public string championship_team_name;

	[Token(Token = "0x400893A")]
	[FieldOffset(Offset = "0xA0")]
	public uint championship_team_member_num;

	[Token(Token = "0x400893B")]
	[FieldOffset(Offset = "0xA4")]
	public uint friend_intimacy;

	[Token(Token = "0x400893C")]
	[FieldOffset(Offset = "0xA8")]
	public ulong championship_team_id;

	[Token(Token = "0x400893D")]
	[FieldOffset(Offset = "0xB0")]
	public uint cs_rank;

	[Token(Token = "0x400893E")]
	[FieldOffset(Offset = "0xB4")]
	public uint cs_ranking_points;

	[Token(Token = "0x400893F")]
	[FieldOffset(Offset = "0xB8")]
	public uint pin_id;

	[Token(Token = "0x4008940")]
	[FieldOffset(Offset = "0xBC")]
	public AccountInfoWithStats cs_ranking_stats;

	[Token(Token = "0x4008941")]
	[FieldOffset(Offset = "0xC0")]
	public bool is_cs_ranking_ban;

	[Token(Token = "0x4008942")]
	[FieldOffset(Offset = "0xC4")]
	public uint peak_rank_pos;

	[Token(Token = "0x4008943")]
	[FieldOffset(Offset = "0xC8")]
	public uint cs_peak_rank_pos;

	[Token(Token = "0x4008944")]
	[FieldOffset(Offset = "0xCC")]
	public uint periodic_ranking_points;

	[Token(Token = "0x4008945")]
	[FieldOffset(Offset = "0xD0")]
	public uint periodic_rank;

	[Token(Token = "0x6007A6B")]
	[Address(RVA = "0x31797AC", Offset = "0x31797AC", VA = "0x31797AC")]
	public AccountInfoWithPresence()
	{
	}
}
