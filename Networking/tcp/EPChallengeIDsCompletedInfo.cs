using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CB4")]
public class EPChallengeIDsCompletedInfo
{
	[Token(Token = "0x400B5A2")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cdaily_challenge_completed_cnt_003Ek__BackingField;

	[Token(Token = "0x400B5A3")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Celite_challenge_completed_cnt_003Ek__BackingField;

	[Token(Token = "0x400B5A4")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cveteran_challenge_completed_cnt_003Ek__BackingField;

	[Token(Token = "0x17000AC2")]
	public uint daily_challenge_completed_cnt
	{
		[Token(Token = "0x60084A3")]
		[Address(RVA = "0x33E9094", Offset = "0x33E9094", VA = "0x33E9094")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60084A4")]
		[Address(RVA = "0x33E909C", Offset = "0x33E909C", VA = "0x33E909C")]
		set
		{
		}
	}

	[Token(Token = "0x17000AC3")]
	public uint elite_challenge_completed_cnt
	{
		[Token(Token = "0x60084A5")]
		[Address(RVA = "0x33E90A4", Offset = "0x33E90A4", VA = "0x33E90A4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60084A6")]
		[Address(RVA = "0x33E90AC", Offset = "0x33E90AC", VA = "0x33E90AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000AC4")]
	public uint veteran_challenge_completed_cnt
	{
		[Token(Token = "0x60084A7")]
		[Address(RVA = "0x33E90B4", Offset = "0x33E90B4", VA = "0x33E90B4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60084A8")]
		[Address(RVA = "0x33E90BC", Offset = "0x33E90BC", VA = "0x33E90BC")]
		set
		{
		}
	}

	[Token(Token = "0x60084A2")]
	[Address(RVA = "0x33E908C", Offset = "0x33E908C", VA = "0x33E908C")]
	public EPChallengeIDsCompletedInfo()
	{
	}
}
