using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D2B")]
public class MatchmakingCheckIngamePlayerReq
{
	[Token(Token = "0x400B844")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Csystem_platform_003Ek__BackingField;

	[Token(Token = "0x17000C31")]
	public uint system_platform
	{
		[Token(Token = "0x60087D8")]
		[Address(RVA = "0x435BECC", Offset = "0x435BECC", VA = "0x435BECC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60087D9")]
		[Address(RVA = "0x435BED4", Offset = "0x435BED4", VA = "0x435BED4")]
		set
		{
		}
	}

	[Token(Token = "0x60087D7")]
	[Address(RVA = "0x435BEC4", Offset = "0x435BEC4", VA = "0x435BEC4")]
	public MatchmakingCheckIngamePlayerReq()
	{
	}
}
