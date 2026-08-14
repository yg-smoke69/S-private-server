using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001DB7")]
public class AccountMatchBannedNtf
{
	[Token(Token = "0x400BC5B")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cban_expire_time_003Ek__BackingField;

	[Token(Token = "0x17000F01")]
	public uint ban_expire_time
	{
		[Token(Token = "0x6008DE4")]
		[Address(RVA = "0x33E707C", Offset = "0x33E707C", VA = "0x33E707C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008DE5")]
		[Address(RVA = "0x33E7084", Offset = "0x33E7084", VA = "0x33E7084")]
		set
		{
		}
	}

	[Token(Token = "0x6008DE3")]
	[Address(RVA = "0x33E7074", Offset = "0x33E7074", VA = "0x33E7074")]
	public AccountMatchBannedNtf()
	{
	}
}
