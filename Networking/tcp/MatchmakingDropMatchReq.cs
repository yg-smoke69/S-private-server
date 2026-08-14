using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D2A")]
public class MatchmakingDropMatchReq
{
	[Token(Token = "0x400B842")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B843")]
	[FieldOffset(Offset = "0x10")]
	private EMatch.GameMode _003Cgame_mode_003Ek__BackingField;

	[Token(Token = "0x17000C2F")]
	public ulong group_id
	{
		[Token(Token = "0x60087D3")]
		[Address(RVA = "0x435BEE4", Offset = "0x435BEE4", VA = "0x435BEE4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60087D4")]
		[Address(RVA = "0x435BEEC", Offset = "0x435BEEC", VA = "0x435BEEC")]
		set
		{
		}
	}

	[Token(Token = "0x17000C30")]
	public EMatch.GameMode game_mode
	{
		[Token(Token = "0x60087D5")]
		[Address(RVA = "0x435BEFC", Offset = "0x435BEFC", VA = "0x435BEFC")]
		get
		{
			return default(EMatch.GameMode);
		}
		[Token(Token = "0x60087D6")]
		[Address(RVA = "0x435BF04", Offset = "0x435BF04", VA = "0x435BF04")]
		set
		{
		}
	}

	[Token(Token = "0x60087D2")]
	[Address(RVA = "0x435BEDC", Offset = "0x435BEDC", VA = "0x435BEDC")]
	public MatchmakingDropMatchReq()
	{
	}
}
