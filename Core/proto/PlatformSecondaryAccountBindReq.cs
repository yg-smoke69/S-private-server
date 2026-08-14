using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013A1")]
public class PlatformSecondaryAccountBindReq
{
	[Token(Token = "0x4008A52")]
	[FieldOffset(Offset = "0x8")]
	public string secondary_open_id;

	[Token(Token = "0x4008A53")]
	[FieldOffset(Offset = "0xC")]
	public uint secondary_platform_type;

	[Token(Token = "0x4008A54")]
	[FieldOffset(Offset = "0x10")]
	public string secondary_access_token;

	[Token(Token = "0x4008A55")]
	[FieldOffset(Offset = "0x14")]
	public string access_token;

	[Token(Token = "0x4008A56")]
	[FieldOffset(Offset = "0x18")]
	public uint platform_type;

	[Token(Token = "0x6007A9C")]
	[Address(RVA = "0x33DFE94", Offset = "0x33DFE94", VA = "0x33DFE94")]
	public PlatformSecondaryAccountBindReq()
	{
	}
}
