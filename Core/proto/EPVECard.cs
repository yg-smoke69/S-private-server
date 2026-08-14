using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001ADC")]
public class EPVECard
{
	[Token(Token = "0x2001ADD")]
	public enum GeneralType
	{
		[Token(Token = "0x400A8F3")]
		GeneralType_NONE,
		[Token(Token = "0x400A8F4")]
		GeneralType_PROBABLITY,
		[Token(Token = "0x400A8F5")]
		GeneralType_DAILY_LIMIT
	}

	[Token(Token = "0x6008138")]
	[Address(RVA = "0x309F774", Offset = "0x309F774", VA = "0x309F774")]
	public EPVECard()
	{
	}
}
