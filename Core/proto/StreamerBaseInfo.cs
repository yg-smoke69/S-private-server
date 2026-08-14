using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001771")]
public class StreamerBaseInfo
{
	[Token(Token = "0x4009A4B")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009A4C")]
	[FieldOffset(Offset = "0x10")]
	public string nickname;

	[Token(Token = "0x4009A4D")]
	[FieldOffset(Offset = "0x14")]
	public uint head_pic;

	[Token(Token = "0x4009A4E")]
	[FieldOffset(Offset = "0x18")]
	public uint banner_id;

	[Token(Token = "0x6007DCB")]
	[Address(RVA = "0x33E29E8", Offset = "0x33E29E8", VA = "0x33E29E8")]
	public StreamerBaseInfo()
	{
	}
}
