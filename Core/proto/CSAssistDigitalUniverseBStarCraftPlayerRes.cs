using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001972")]
public class CSAssistDigitalUniverseBStarCraftPlayerRes
{
	[Token(Token = "0x4009FD1")]
	[FieldOffset(Offset = "0x8")]
	public ulong next_assist_timestamp;

	[Token(Token = "0x4009FD2")]
	[FieldOffset(Offset = "0x10")]
	public bool daily_token_limit_reached;

	[Token(Token = "0x4009FD3")]
	[FieldOffset(Offset = "0x14")]
	public uint cur_assist_value;

	[Token(Token = "0x4009FD4")]
	[FieldOffset(Offset = "0x18")]
	public uint cur_gravitational_value;

	[Token(Token = "0x6007FCB")]
	[Address(RVA = "0x317DD40", Offset = "0x317DD40", VA = "0x317DD40")]
	public CSAssistDigitalUniverseBStarCraftPlayerRes()
	{
	}
}
