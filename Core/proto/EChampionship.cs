using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001421")]
public class EChampionship
{
	[Token(Token = "0x2001422")]
	public enum MemberType
	{
		[Token(Token = "0x4008C5C")]
		MemberType_NONE,
		[Token(Token = "0x4008C5D")]
		MemberType_NORMAL_MEMBER,
		[Token(Token = "0x4008C5E")]
		MemberType_CAPTAIN
	}

	[Token(Token = "0x2001423")]
	public enum TeamUserChangeType
	{
		[Token(Token = "0x4008C60")]
		TeamUserChangeType_NONE,
		[Token(Token = "0x4008C61")]
		TeamUserChangeType_REQUEST,
		[Token(Token = "0x4008C62")]
		TeamUserChangeType_APPROVE_APPLICATION,
		[Token(Token = "0x4008C63")]
		TeamUserChangeType_INVITE,
		[Token(Token = "0x4008C64")]
		TeamUserChangeType_APPROVE_INVITATION,
		[Token(Token = "0x4008C65")]
		TeamUserChangeType_REMOVE,
		[Token(Token = "0x4008C66")]
		TeamUserChangeType_QUIT,
		[Token(Token = "0x4008C67")]
		TeamUserChangeType_AUTO_QUIT
	}

	[Token(Token = "0x2001424")]
	public enum ChampionshipPhase
	{
		[Token(Token = "0x4008C69")]
		ChampionshipPhase_NONE,
		[Token(Token = "0x4008C6A")]
		ChampionshipPhase_TRIAL,
		[Token(Token = "0x4008C6B")]
		ChampionshipPhase_FINAL
	}

	[Token(Token = "0x2001425")]
	public enum TeamScaleType
	{
		[Token(Token = "0x4008C6D")]
		TeamScaleType_NONE,
		[Token(Token = "0x4008C6E")]
		TeamScaleType_SOLO,
		[Token(Token = "0x4008C6F")]
		TeamScaleType_TRIO,
		[Token(Token = "0x4008C70")]
		TeamScaleType_QUINTET
	}

	[Token(Token = "0x6007AE2")]
	[Address(RVA = "0x309F278", Offset = "0x309F278", VA = "0x309F278")]
	public EChampionship()
	{
	}
}
