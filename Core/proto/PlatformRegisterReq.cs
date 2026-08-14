using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200139C")]
public class PlatformRegisterReq
{
	[Token(Token = "0x4008A28")]
	[FieldOffset(Offset = "0x8")]
	public string nickname;

	[Token(Token = "0x4008A29")]
	[FieldOffset(Offset = "0xC")]
	public string access_token;

	[Token(Token = "0x4008A2A")]
	[FieldOffset(Offset = "0x10")]
	public string open_id;

	[Token(Token = "0x4008A2B")]
	[FieldOffset(Offset = "0x14")]
	public string region;

	[Token(Token = "0x4008A2C")]
	[FieldOffset(Offset = "0x18")]
	public uint avatar_id;

	[Token(Token = "0x4008A2D")]
	[FieldOffset(Offset = "0x1C")]
	public uint platform_type;

	[Token(Token = "0x4008A2E")]
	[FieldOffset(Offset = "0x20")]
	public uint platform_sdk_id;

	[Token(Token = "0x4008A2F")]
	[FieldOffset(Offset = "0x24")]
	public EAccount.DownloadType source;

	[Token(Token = "0x4008A30")]
	[FieldOffset(Offset = "0x28")]
	public string editor_register_key;

	[Token(Token = "0x4008A31")]
	[FieldOffset(Offset = "0x2C")]
	public EAccount.NewbieChoice newbie_choice;

	[Token(Token = "0x4008A32")]
	[FieldOffset(Offset = "0x30")]
	public byte[] platform_register_info;

	[Token(Token = "0x4008A33")]
	[FieldOffset(Offset = "0x34")]
	public string language;

	[Token(Token = "0x6007A97")]
	[Address(RVA = "0x33DFD0C", Offset = "0x33DFD0C", VA = "0x33DFD0C")]
	public PlatformRegisterReq()
	{
	}
}
