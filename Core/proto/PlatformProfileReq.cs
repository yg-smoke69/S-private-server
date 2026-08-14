using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200139E")]
public class PlatformProfileReq
{
	[Token(Token = "0x4008A3D")]
	[FieldOffset(Offset = "0x8")]
	public string token;

	[Token(Token = "0x4008A3E")]
	[FieldOffset(Offset = "0xC")]
	public string external_id;

	[Token(Token = "0x4008A3F")]
	[FieldOffset(Offset = "0x10")]
	public uint platform_sdk_id;

	[Token(Token = "0x6007A99")]
	[Address(RVA = "0x33DFBA8", Offset = "0x33DFBA8", VA = "0x33DFBA8")]
	public PlatformProfileReq()
	{
	}
}
