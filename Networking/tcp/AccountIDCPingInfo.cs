using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001DA2")]
public class AccountIDCPingInfo
{
	[Token(Token = "0x400BBCE")]
	[FieldOffset(Offset = "0x8")]
	private string _003Cidc_003Ek__BackingField;

	[Token(Token = "0x400BBCF")]
	[FieldOffset(Offset = "0xC")]
	private int _003Cping_003Ek__BackingField;

	[Token(Token = "0x17000E7A")]
	public string idc
	{
		[Token(Token = "0x6008CC2")]
		[Address(RVA = "0x33E6FD4", Offset = "0x33E6FD4", VA = "0x33E6FD4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008CC3")]
		[Address(RVA = "0x33E6FCC", Offset = "0x33E6FCC", VA = "0x33E6FCC")]
		set
		{
		}
	}

	[Token(Token = "0x17000E7B")]
	public int ping
	{
		[Token(Token = "0x6008CC4")]
		[Address(RVA = "0x33E6FDC", Offset = "0x33E6FDC", VA = "0x33E6FDC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008CC5")]
		[Address(RVA = "0x33E6FE4", Offset = "0x33E6FE4", VA = "0x33E6FE4")]
		set
		{
		}
	}

	[Token(Token = "0x6008CC1")]
	[Address(RVA = "0x33E6F2C", Offset = "0x33E6F2C", VA = "0x33E6F2C")]
	public AccountIDCPingInfo()
	{
	}
}
