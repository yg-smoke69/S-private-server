using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C57")]
public class EAntiAddiction
{
	[Token(Token = "0x2001C58")]
	public enum Proto
	{
		[Token(Token = "0x400B45E")]
		Proto_NONE,
		[Token(Token = "0x400B45F")]
		Proto_HINT_NTF
	}

	[Token(Token = "0x2001C59")]
	public enum ErrCode
	{
		[Token(Token = "0x400B461")]
		ErrCode_SUSS
	}

	[Token(Token = "0x2001C5A")]
	public enum TotalTimeBanMode
	{
		[Token(Token = "0x400B463")]
		TotalTimeBanMode_NONE,
		[Token(Token = "0x400B464")]
		TotalTimeBanMode_RANKING,
		[Token(Token = "0x400B465")]
		TotalTimeBanMode_ALL
	}

	[Token(Token = "0x2001C5B")]
	public enum AgeState
	{
		[Token(Token = "0x400B467")]
		AgeState_NONE,
		[Token(Token = "0x400B468")]
		AgeState_UNDER_AGE,
		[Token(Token = "0x400B469")]
		AgeState_ADULT
	}

	[Token(Token = "0x60082EC")]
	[Address(RVA = "0x33E8FD4", Offset = "0x33E8FD4", VA = "0x33E8FD4")]
	public EAntiAddiction()
	{
	}
}
