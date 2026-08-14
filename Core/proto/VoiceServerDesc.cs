using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C0C")]
public class VoiceServerDesc
{
	[Token(Token = "0x400B076")]
	[FieldOffset(Offset = "0x8")]
	public string region_server;

	[Token(Token = "0x400B077")]
	[FieldOffset(Offset = "0xC")]
	public string test_server_url;

	[Token(Token = "0x400B078")]
	[FieldOffset(Offset = "0x10")]
	public string live_server_url;

	[Token(Token = "0x6008267")]
	[Address(RVA = "0x33E4F20", Offset = "0x33E4F20", VA = "0x33E4F20")]
	public VoiceServerDesc()
	{
	}
}
