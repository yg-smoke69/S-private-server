using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013A0")]
public class PlatformGuestBindReq
{
	[Token(Token = "0x4008A44")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008A45")]
	[FieldOffset(Offset = "0x10")]
	public string region;

	[Token(Token = "0x4008A46")]
	[FieldOffset(Offset = "0x14")]
	public string guest_open_id;

	[Token(Token = "0x4008A47")]
	[FieldOffset(Offset = "0x18")]
	public uint guest_platform_type;

	[Token(Token = "0x4008A48")]
	[FieldOffset(Offset = "0x1C")]
	public string guest_access_token;

	[Token(Token = "0x4008A49")]
	[FieldOffset(Offset = "0x20")]
	public string access_token;

	[Token(Token = "0x4008A4A")]
	[FieldOffset(Offset = "0x24")]
	public string open_id;

	[Token(Token = "0x4008A4B")]
	[FieldOffset(Offset = "0x28")]
	public uint platform_type;

	[Token(Token = "0x4008A4C")]
	[FieldOffset(Offset = "0x2C")]
	public uint platform_sdk_id;

	[Token(Token = "0x4008A4D")]
	[FieldOffset(Offset = "0x30")]
	public ulong uid;

	[Token(Token = "0x4008A4E")]
	[FieldOffset(Offset = "0x38")]
	public string lock_region;

	[Token(Token = "0x4008A4F")]
	[FieldOffset(Offset = "0x3C")]
	public uint client_type;

	[Token(Token = "0x4008A50")]
	[FieldOffset(Offset = "0x40")]
	public string nickname;

	[Token(Token = "0x4008A51")]
	[FieldOffset(Offset = "0x44")]
	public string ip_address;

	[Token(Token = "0x6007A9B")]
	[Address(RVA = "0x33DFA00", Offset = "0x33DFA00", VA = "0x33DFA00")]
	public PlatformGuestBindReq()
	{
	}
}
