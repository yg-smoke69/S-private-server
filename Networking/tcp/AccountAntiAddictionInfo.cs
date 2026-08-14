using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D98")]
public class AccountAntiAddictionInfo
{
	[Token(Token = "0x400BABA")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cban_mode_003Ek__BackingField;

	[Token(Token = "0x400BABB")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cunban_time_003Ek__BackingField;

	[Token(Token = "0x17000D66")]
	public uint ban_mode
	{
		[Token(Token = "0x6008A90")]
		[Address(RVA = "0x33E6E5C", Offset = "0x33E6E5C", VA = "0x33E6E5C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A91")]
		[Address(RVA = "0x33E6E64", Offset = "0x33E6E64", VA = "0x33E6E64")]
		set
		{
		}
	}

	[Token(Token = "0x17000D67")]
	public uint unban_time
	{
		[Token(Token = "0x6008A92")]
		[Address(RVA = "0x33E6E6C", Offset = "0x33E6E6C", VA = "0x33E6E6C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A93")]
		[Address(RVA = "0x33E6E74", Offset = "0x33E6E74", VA = "0x33E6E74")]
		set
		{
		}
	}

	[Token(Token = "0x6008A8F")]
	[Address(RVA = "0x33E6E54", Offset = "0x33E6E54", VA = "0x33E6E54")]
	public AccountAntiAddictionInfo()
	{
	}
}
