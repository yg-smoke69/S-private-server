using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013C6")]
public class MatchClientInfo
{
	[Token(Token = "0x4008B02")]
	[FieldOffset(Offset = "0x8")]
	public string tpsdk_str;

	[Token(Token = "0x4008B03")]
	[FieldOffset(Offset = "0xC")]
	public uint start_time;

	[Token(Token = "0x4008B04")]
	[FieldOffset(Offset = "0x10")]
	public byte[] file_exception;

	[Token(Token = "0x4008B05")]
	[FieldOffset(Offset = "0x14")]
	public byte[] lib_result;

	[Token(Token = "0x4008B06")]
	[FieldOffset(Offset = "0x18")]
	public uint exception_count;

	[Token(Token = "0x4008B07")]
	[FieldOffset(Offset = "0x1C")]
	public uint scan_count;

	[Token(Token = "0x4008B08")]
	[FieldOffset(Offset = "0x20")]
	public byte[] native_result;

	[Token(Token = "0x4008B09")]
	[FieldOffset(Offset = "0x24")]
	public string client_version;

	[Token(Token = "0x4008B0A")]
	[FieldOffset(Offset = "0x28")]
	public uint channel_type;

	[Token(Token = "0x4008B0B")]
	[FieldOffset(Offset = "0x2C")]
	public uint architecture_type;

	[Token(Token = "0x6007AB1")]
	[Address(RVA = "0x30A7990", Offset = "0x30A7990", VA = "0x30A7990")]
	public MatchClientInfo()
	{
	}
}
