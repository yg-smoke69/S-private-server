using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002FCD")]
public class Report_CDNDownload
{
	[Token(Token = "0x4012323")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x4012324")]
	[FieldOffset(Offset = "0xC")]
	public string target_url;

	[Token(Token = "0x4012325")]
	[FieldOffset(Offset = "0x10")]
	public string country;

	[Token(Token = "0x4012326")]
	[FieldOffset(Offset = "0x14")]
	public string client_ip;

	[Token(Token = "0x4012327")]
	[FieldOffset(Offset = "0x18")]
	public string network_type;

	[Token(Token = "0x4012328")]
	[FieldOffset(Offset = "0x1C")]
	public string platform;

	[Token(Token = "0x4012329")]
	[FieldOffset(Offset = "0x20")]
	public long response_code;

	[Token(Token = "0x401232A")]
	[FieldOffset(Offset = "0x28")]
	public float req_time;

	[Token(Token = "0x401232B")]
	[FieldOffset(Offset = "0x2C")]
	public string host_ip;

	[Token(Token = "0x6013F8B")]
	[Address(RVA = "0x2406B10", Offset = "0x2406B10", VA = "0x2406B10")]
	public Report_CDNDownload()
	{
	}
}
