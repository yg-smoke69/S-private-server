using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014D5")]
public class ChummyRequest
{
	[Token(Token = "0x4008FFA")]
	[FieldOffset(Offset = "0x8")]
	public AccountInfoBasic applicant_info;

	[Token(Token = "0x4008FFB")]
	[FieldOffset(Offset = "0x10")]
	public long request_time;

	[Token(Token = "0x4008FFC")]
	[FieldOffset(Offset = "0x18")]
	public uint multi_relation_type;

	[Token(Token = "0x4008FFD")]
	[FieldOffset(Offset = "0x1C")]
	public uint request_type;

	[Token(Token = "0x6007B2A")]
	[Address(RVA = "0x309B810", Offset = "0x309B810", VA = "0x309B810")]
	public ChummyRequest()
	{
	}
}
