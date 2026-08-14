using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001321")]
public class EAttendance
{
	[Token(Token = "0x2001322")]
	public enum VeteranRewardStatus
	{
		[Token(Token = "0x4008754")]
		VeteranRewardStatus_NOT_SIGNED,
		[Token(Token = "0x4008755")]
		VeteranRewardStatus_SIGNED,
		[Token(Token = "0x4008756")]
		VeteranRewardStatus_CLAIMED
	}

	[Token(Token = "0x2001323")]
	public enum VeteranClass
	{
		[Token(Token = "0x4008758")]
		VeteranClass_NONE,
		[Token(Token = "0x4008759")]
		VeteranClass_NOMAL,
		[Token(Token = "0x400875A")]
		VeteranClass_SENIOR,
		[Token(Token = "0x400875B")]
		VeteranClass_RICH
	}

	[Token(Token = "0x2001324")]
	public enum VeteranTaskBigPrize
	{
		[Token(Token = "0x400875D")]
		VeteranTaskBigPrize_NOT_AVALIBLE,
		[Token(Token = "0x400875E")]
		VeteranTaskBigPrize_CAN_GET,
		[Token(Token = "0x400875F")]
		VeteranTaskBigPrize_CLAIMED
	}

	[Token(Token = "0x2001325")]
	public enum AttendanceType
	{
		[Token(Token = "0x4008761")]
		AttendanceType_NORMAL,
		[Token(Token = "0x4008762")]
		AttendanceType_TURNTABLE
	}

	[Token(Token = "0x2001326")]
	public enum FestivalAttendanceState
	{
		[Token(Token = "0x4008764")]
		FestivalAttendanceState_NOT_SIGNED = 0,
		[Token(Token = "0x4008765")]
		FestivalAttendanceState_SIGNED = 1,
		[Token(Token = "0x4008766")]
		FestivalAttendanceState_CLAIMED = 3
	}

	[Token(Token = "0x2001327")]
	public enum VeteranAwardType
	{
		[Token(Token = "0x4008768")]
		VeteranAwardType_NONE,
		[Token(Token = "0x4008769")]
		VeteranAwardType_RETURN,
		[Token(Token = "0x400876A")]
		VeteranAwardType_BUNDLE
	}

	[Token(Token = "0x2001328")]
	public enum VeteranTaskClass
	{
		[Token(Token = "0x400876C")]
		VeteranTaskClass_NONE,
		[Token(Token = "0x400876D")]
		VeteranTaskClass_SIMPLE,
		[Token(Token = "0x400876E")]
		VeteranTaskClass_NORMAL,
		[Token(Token = "0x400876F")]
		VeteranTaskClass_HARD
	}

	[Token(Token = "0x2001329")]
	public enum VeteranTaskType
	{
		[Token(Token = "0x4008771")]
		VeteranTaskType_NONE,
		[Token(Token = "0x4008772")]
		VeteranTaskType_NORMAL,
		[Token(Token = "0x4008773")]
		VeteranTaskType_COOPERATION
	}

	[Token(Token = "0x6007A51")]
	[Address(RVA = "0x309F258", Offset = "0x309F258", VA = "0x309F258")]
	public EAttendance()
	{
	}
}
