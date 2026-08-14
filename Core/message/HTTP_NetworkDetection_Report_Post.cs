using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001C43")]
public class HTTP_NetworkDetection_Report_Post
{
	[Token(Token = "0x400B41B")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x400B41C")]
	[FieldOffset(Offset = "0x10")]
	public byte build_variant_type;

	[Token(Token = "0x400B41D")]
	[FieldOffset(Offset = "0x14")]
	public string region;

	[Token(Token = "0x400B41E")]
	[FieldOffset(Offset = "0x18")]
	public string country;

	[Token(Token = "0x400B41F")]
	[FieldOffset(Offset = "0x1C")]
	public string phone_carrier;

	[Token(Token = "0x400B420")]
	[FieldOffset(Offset = "0x20")]
	public int system_api_level;

	[Token(Token = "0x400B421")]
	[FieldOffset(Offset = "0x24")]
	public string client_ip;

	[Token(Token = "0x400B422")]
	[FieldOffset(Offset = "0x28")]
	public NetworkDetection_ModuleResult[] results;

	[Token(Token = "0x600829A")]
	[Address(RVA = "0x36148F0", Offset = "0x36148F0", VA = "0x36148F0")]
	public HTTP_NetworkDetection_Report_Post()
	{
	}
}
