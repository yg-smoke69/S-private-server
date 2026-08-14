using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016F6")]
public class CSGetEPInfoRes
{
	[Token(Token = "0x400980B")]
	[FieldOffset(Offset = "0x8")]
	public bool owned_pass;

	[Token(Token = "0x400980C")]
	[FieldOffset(Offset = "0xC")]
	public List<RewardStatus> rewards;

	[Token(Token = "0x400980D")]
	[FieldOffset(Offset = "0x10")]
	public List<ChallengeStatus> challenges;

	[Token(Token = "0x400980E")]
	[FieldOffset(Offset = "0x14")]
	public uint ep_event_id;

	[Token(Token = "0x400980F")]
	[FieldOffset(Offset = "0x18")]
	public long start_time;

	[Token(Token = "0x4009810")]
	[FieldOffset(Offset = "0x20")]
	public long end_time;

	[Token(Token = "0x4009811")]
	[FieldOffset(Offset = "0x28")]
	public uint ep_badge;

	[Token(Token = "0x4009812")]
	[FieldOffset(Offset = "0x2C")]
	public uint gold_limit_improved;

	[Token(Token = "0x4009813")]
	[FieldOffset(Offset = "0x30")]
	public uint fp_challenge_item;

	[Token(Token = "0x4009814")]
	[FieldOffset(Offset = "0x34")]
	public bool owned_fp_challenge;

	[Token(Token = "0x4009815")]
	[FieldOffset(Offset = "0x38")]
	public uint purchase_badge_count_today;

	[Token(Token = "0x4009816")]
	[FieldOffset(Offset = "0x3C")]
	public uint week;

	[Token(Token = "0x4009817")]
	[FieldOffset(Offset = "0x40")]
	public long daily_reset_time;

	[Token(Token = "0x4009818")]
	[FieldOffset(Offset = "0x48")]
	public uint epid_preorder;

	[Token(Token = "0x4009819")]
	[FieldOffset(Offset = "0x50")]
	public long ep_preorder_start_time;

	[Token(Token = "0x400981A")]
	[FieldOffset(Offset = "0x58")]
	public long ep_preorder_end_time;

	[Token(Token = "0x400981B")]
	[FieldOffset(Offset = "0x60")]
	public uint daily_challenge_completed_cnt;

	[Token(Token = "0x400981C")]
	[FieldOffset(Offset = "0x64")]
	public uint elite_challenge_completed_cnt;

	[Token(Token = "0x400981D")]
	[FieldOffset(Offset = "0x68")]
	public uint veteran_challenge_completed_cnt;

	[Token(Token = "0x400981E")]
	[FieldOffset(Offset = "0x70")]
	public long subscription_start_time;

	[Token(Token = "0x400981F")]
	[FieldOffset(Offset = "0x78")]
	public long subscription_end_time;

	[Token(Token = "0x4009820")]
	[FieldOffset(Offset = "0x80")]
	public uint purchase_ep_count;

	[Token(Token = "0x4009821")]
	[FieldOffset(Offset = "0x84")]
	public uint ep_max_reward_claimed_badge;

	[Token(Token = "0x4009822")]
	[FieldOffset(Offset = "0x88")]
	public List<DailyQuestRewardsStatus> daily_rewards_status;

	[Token(Token = "0x4009823")]
	[FieldOffset(Offset = "0x8C")]
	public List<WeeklyProcess> weekly_process;

	[Token(Token = "0x4009824")]
	[FieldOffset(Offset = "0x90")]
	public DailyProcess daily_process;

	[Token(Token = "0x4009825")]
	[FieldOffset(Offset = "0x94")]
	public List<EPDailyProcessRewardDesc> daily_process_reward_desc;

	[Token(Token = "0x4009826")]
	[FieldOffset(Offset = "0x98")]
	public uint customized_discount;

	[Token(Token = "0x6007D50")]
	[Address(RVA = "0x3184388", Offset = "0x3184388", VA = "0x3184388")]
	public CSGetEPInfoRes()
	{
	}
}
