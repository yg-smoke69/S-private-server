using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013D8")]
public class EPChallenge
{
	[Token(Token = "0x20013D9")]
	public enum AwardType
	{
		[Token(Token = "0x4008B49")]
		AwardType_NONE,
		[Token(Token = "0x4008B4A")]
		AwardType_CHALLENGE,
		[Token(Token = "0x4008B4B")]
		AwardType_DAILY_PROCESS
	}

	[Token(Token = "0x6007ABB")]
	[Address(RVA = "0x309F370", Offset = "0x309F370", VA = "0x309F370")]
	public EPChallenge()
	{
	}
}
