using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CA1")]
public class CreditScoreChangeNtf
{
	[Token(Token = "0x400B553")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Ccredit_score_003Ek__BackingField;

	[Token(Token = "0x400B554")]
	[FieldOffset(Offset = "0xC")]
	private int _003Ccredit_score_delta_003Ek__BackingField;

	[Token(Token = "0x400B555")]
	[FieldOffset(Offset = "0x10")]
	private long _003Cchange_time_stamp_003Ek__BackingField;

	[Token(Token = "0x17000A87")]
	public uint credit_score
	{
		[Token(Token = "0x600841E")]
		[Address(RVA = "0x33E89B0", Offset = "0x33E89B0", VA = "0x33E89B0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600841F")]
		[Address(RVA = "0x33E89B8", Offset = "0x33E89B8", VA = "0x33E89B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000A88")]
	public int credit_score_delta
	{
		[Token(Token = "0x6008420")]
		[Address(RVA = "0x33E89C0", Offset = "0x33E89C0", VA = "0x33E89C0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008421")]
		[Address(RVA = "0x33E89C8", Offset = "0x33E89C8", VA = "0x33E89C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000A89")]
	public long change_time_stamp
	{
		[Token(Token = "0x6008422")]
		[Address(RVA = "0x33E89D0", Offset = "0x33E89D0", VA = "0x33E89D0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008423")]
		[Address(RVA = "0x33E89D8", Offset = "0x33E89D8", VA = "0x33E89D8")]
		set
		{
		}
	}

	[Token(Token = "0x600841D")]
	[Address(RVA = "0x33E89A8", Offset = "0x33E89A8", VA = "0x33E89A8")]
	public CreditScoreChangeNtf()
	{
	}
}
