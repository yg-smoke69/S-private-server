using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D27")]
public class MatchmakingStartNtf
{
	[Token(Token = "0x400B832")]
	[FieldOffset(Offset = "0x8")]
	private uint[] _003Cmap_ids_003Ek__BackingField;

	[Token(Token = "0x400B833")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cgame_mode_003Ek__BackingField;

	[Token(Token = "0x400B834")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cdifficulty_003Ek__BackingField;

	[Token(Token = "0x400B835")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Cmatch_mode_003Ek__BackingField;

	[Token(Token = "0x400B836")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Cavg_wait_time_sec_003Ek__BackingField;

	[Token(Token = "0x17000C1F")]
	public uint[] map_ids
	{
		[Token(Token = "0x60087B0")]
		[Address(RVA = "0x435C488", Offset = "0x435C488", VA = "0x435C488")]
		get
		{
			return null;
		}
		[Token(Token = "0x60087B1")]
		[Address(RVA = "0x435C490", Offset = "0x435C490", VA = "0x435C490")]
		set
		{
		}
	}

	[Token(Token = "0x17000C20")]
	public uint game_mode
	{
		[Token(Token = "0x60087B2")]
		[Address(RVA = "0x435C498", Offset = "0x435C498", VA = "0x435C498")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60087B3")]
		[Address(RVA = "0x435C4A0", Offset = "0x435C4A0", VA = "0x435C4A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C21")]
	public uint difficulty
	{
		[Token(Token = "0x60087B4")]
		[Address(RVA = "0x435C4A8", Offset = "0x435C4A8", VA = "0x435C4A8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60087B5")]
		[Address(RVA = "0x435C4B0", Offset = "0x435C4B0", VA = "0x435C4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C22")]
	public uint match_mode
	{
		[Token(Token = "0x60087B6")]
		[Address(RVA = "0x435C4B8", Offset = "0x435C4B8", VA = "0x435C4B8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60087B7")]
		[Address(RVA = "0x435C4C0", Offset = "0x435C4C0", VA = "0x435C4C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C23")]
	public uint avg_wait_time_sec
	{
		[Token(Token = "0x60087B8")]
		[Address(RVA = "0x435C4C8", Offset = "0x435C4C8", VA = "0x435C4C8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60087B9")]
		[Address(RVA = "0x435C4D0", Offset = "0x435C4D0", VA = "0x435C4D0")]
		set
		{
		}
	}

	[Token(Token = "0x60087AF")]
	[Address(RVA = "0x435C480", Offset = "0x435C480", VA = "0x435C480")]
	public MatchmakingStartNtf()
	{
	}
}
