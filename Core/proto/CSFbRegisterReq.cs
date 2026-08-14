using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001502")]
public class CSFbRegisterReq
{
	[Token(Token = "0x4009087")]
	[FieldOffset(Offset = "0x8")]
	public string nickname;

	[Token(Token = "0x4009088")]
	[FieldOffset(Offset = "0xC")]
	public string input_token;

	[Token(Token = "0x4009089")]
	[FieldOffset(Offset = "0x10")]
	public string region;

	[Token(Token = "0x400908A")]
	[FieldOffset(Offset = "0x14")]
	public uint avatar_id;

	[Token(Token = "0x6007B4B")]
	[Address(RVA = "0x318046C", Offset = "0x318046C", VA = "0x318046C")]
	public CSFbRegisterReq()
	{
	}
}
