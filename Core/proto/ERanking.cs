using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001418")]
public class ERanking
{
	[Token(Token = "0x2001419")]
	public enum ActivityType
	{
		[Token(Token = "0x4008C39")]
		ActivityType_NONE,
		[Token(Token = "0x4008C3A")]
		ActivityType_NO_DEDUCT,
		[Token(Token = "0x4008C3B")]
		ActivityType_DOUBLE_RANKING_POINT,
		[Token(Token = "0x4008C3C")]
		ActivityType_DOUBLE_TOKEN
	}

	[Token(Token = "0x200141A")]
	public enum RankingType
	{
		[Token(Token = "0x4008C3E")]
		RankingType_NONE,
		[Token(Token = "0x4008C3F")]
		RankingType_NORMAL,
		[Token(Token = "0x4008C40")]
		RankingType_CS,
		[Token(Token = "0x4008C41")]
		RankingType_PERIODIC
	}

	[Token(Token = "0x6007ADF")]
	[Address(RVA = "0x309F8C4", Offset = "0x309F8C4", VA = "0x309F8C4")]
	public ERanking()
	{
	}
}
