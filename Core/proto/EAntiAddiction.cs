using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200143E")]
public class EAntiAddiction
{
	[Token(Token = "0x200143F")]
	public enum TotalTimeBanMode
	{
		[Token(Token = "0x4008CFB")]
		TotalTimeBanMode_NONE,
		[Token(Token = "0x4008CFC")]
		TotalTimeBanMode_RANKING,
		[Token(Token = "0x4008CFD")]
		TotalTimeBanMode_ALL,
		[Token(Token = "0x4008CFE")]
		TotalTimeBanMode_WARN
	}

	[Token(Token = "0x2001440")]
	public enum HintType
	{
		[Token(Token = "0x4008D00")]
		HintType_NONE,
		[Token(Token = "0x4008D01")]
		HintType_CONTINUOUS_TIME,
		[Token(Token = "0x4008D02")]
		HintType_TOTAL_TIME,
		[Token(Token = "0x4008D03")]
		HintType_ALL
	}

	[Token(Token = "0x2001441")]
	public enum AgeState
	{
		[Token(Token = "0x4008D05")]
		AgeState_NONE,
		[Token(Token = "0x4008D06")]
		AgeState_CHILD,
		[Token(Token = "0x4008D07")]
		AgeState_TEENAGER,
		[Token(Token = "0x4008D08")]
		AgeState_ADULT,
		[Token(Token = "0x4008D09")]
		AgeState_ALL_PLAYERS
	}

	[Token(Token = "0x6007AF0")]
	[Address(RVA = "0x309F250", Offset = "0x309F250", VA = "0x309F250")]
	public EAntiAddiction()
	{
	}
}
