using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014C3")]
public class EEmulator
{
	[Token(Token = "0x20014C4")]
	public enum MatchMakingMethodType
	{
		[Token(Token = "0x4008FC0")]
		MatchMakingMethodType_USE_NORMAL_POOL,
		[Token(Token = "0x4008FC1")]
		MatchMakingMethodType_USE_EMULATOR_POOL,
		[Token(Token = "0x4008FC2")]
		MatchMakingMethodType_MATCHMAKING_FORBIDDEN
	}

	[Token(Token = "0x6007B24")]
	[Address(RVA = "0x309F2C8", Offset = "0x309F2C8", VA = "0x309F2C8")]
	public EEmulator()
	{
	}
}
