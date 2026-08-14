using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001500")]
public class CSRegisterReq
{
	[Token(Token = "0x4009081")]
	[FieldOffset(Offset = "0x8")]
	public string device_id;

	[Token(Token = "0x4009082")]
	[FieldOffset(Offset = "0xC")]
	public string nickname;

	[Token(Token = "0x4009083")]
	[FieldOffset(Offset = "0x10")]
	public string region;

	[Token(Token = "0x4009084")]
	[FieldOffset(Offset = "0x14")]
	public uint avatar_id;

	[Token(Token = "0x6007B49")]
	[Address(RVA = "0x3098F88", Offset = "0x3098F88", VA = "0x3098F88")]
	public CSRegisterReq()
	{
	}
}
