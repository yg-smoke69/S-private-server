using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B10")]
public class MTPPrivateUrlDesc
{
	[Token(Token = "0x400AA1D")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400AA1E")]
	[FieldOffset(Offset = "0xC")]
	public string mtp_service_url;

	[Token(Token = "0x400AA1F")]
	[FieldOffset(Offset = "0x10")]
	public string data_proxy_domain;

	[Token(Token = "0x400AA20")]
	[FieldOffset(Offset = "0x14")]
	public string busi_proxy_domain;

	[Token(Token = "0x400AA21")]
	[FieldOffset(Offset = "0x18")]
	public string exp_data_proxy_domain;

	[Token(Token = "0x400AA22")]
	[FieldOffset(Offset = "0x1C")]
	public string exp_busi_proxy_domain;

	[Token(Token = "0x600816B")]
	[Address(RVA = "0x30A7150", Offset = "0x30A7150", VA = "0x30A7150")]
	public MTPPrivateUrlDesc()
	{
	}
}
