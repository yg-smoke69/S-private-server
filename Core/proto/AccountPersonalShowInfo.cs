using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001392")]
public class AccountPersonalShowInfo
{
	[Token(Token = "0x4008A00")]
	[FieldOffset(Offset = "0x8")]
	public AccountInfoBasic basic_info;

	[Token(Token = "0x4008A01")]
	[FieldOffset(Offset = "0xC")]
	public AvatarProfile profile_info;

	[Token(Token = "0x4008A02")]
	[FieldOffset(Offset = "0x10")]
	public int ranking_leaderboard_pos;

	[Token(Token = "0x4008A03")]
	[FieldOffset(Offset = "0x14")]
	public List<AccountNews> news;

	[Token(Token = "0x4008A04")]
	[FieldOffset(Offset = "0x18")]
	public List<BasicEPInfo> history_ep_info;

	[Token(Token = "0x4008A05")]
	[FieldOffset(Offset = "0x1C")]
	public ClanInfoBasic clan_basic_info;

	[Token(Token = "0x4008A06")]
	[FieldOffset(Offset = "0x20")]
	public AccountInfoBasic captain_basic_info;

	[Token(Token = "0x4008A07")]
	[FieldOffset(Offset = "0x24")]
	public PetInfo pet_info;

	[Token(Token = "0x4008A08")]
	[FieldOffset(Offset = "0x28")]
	public SocialBasicInfo social_info;

	[Token(Token = "0x4008A09")]
	[FieldOffset(Offset = "0x2C")]
	public DiamondCostRes diamond_cost_res;

	[Token(Token = "0x4008A0A")]
	[FieldOffset(Offset = "0x30")]
	public CreditScoreInfoBasic credit_score_info;

	[Token(Token = "0x6007A8E")]
	[Address(RVA = "0x3179A00", Offset = "0x3179A00", VA = "0x3179A00")]
	public AccountPersonalShowInfo()
	{
	}
}
