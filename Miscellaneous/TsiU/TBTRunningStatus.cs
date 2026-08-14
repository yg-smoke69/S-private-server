using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C25")]
public class TBTRunningStatus
{
	[Token(Token = "0x4019A0E")]
	public const int EXECUTING = 0;

	[Token(Token = "0x4019A0F")]
	public const int FINISHED = 1;

	[Token(Token = "0x4019A10")]
	public const int TRANSITION = 2;

	[Token(Token = "0x4019A11")]
	public const int USER_EXECUTING = 100;

	[Token(Token = "0x4019A12")]
	public const int USER_FINISHED = 1000;

	[Token(Token = "0x6018035")]
	[Address(RVA = "0x26416AC", Offset = "0x26416AC", VA = "0x26416AC")]
	public TBTRunningStatus()
	{
	}

	[Token(Token = "0x6018036")]
	[Address(RVA = "0x26416B4", Offset = "0x26416B4", VA = "0x26416B4")]
	public static bool IsOK(int runningStatus)
	{
		return default(bool);
	}

	[Token(Token = "0x6018037")]
	[Address(RVA = "0x26410B0", Offset = "0x26410B0", VA = "0x26410B0")]
	public static bool IsError(int runningStatus)
	{
		return default(bool);
	}

	[Token(Token = "0x6018038")]
	[Address(RVA = "0x263FB1C", Offset = "0x263FB1C", VA = "0x263FB1C")]
	public static bool IsFinished(int runningStatus)
	{
		return default(bool);
	}

	[Token(Token = "0x6018039")]
	[Address(RVA = "0x26416D0", Offset = "0x26416D0", VA = "0x26416D0")]
	public static bool IsExecuting(int runningStatus)
	{
		return default(bool);
	}
}
