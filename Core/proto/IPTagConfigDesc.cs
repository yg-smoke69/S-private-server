using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001ABC")]
public class IPTagConfigDesc
{
	[Token(Token = "0x400A84F")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400A850")]
	[FieldOffset(Offset = "0xC")]
	public string ip_tag_icon;

	[Token(Token = "0x400A851")]
	[FieldOffset(Offset = "0x10")]
	public bool is_hide;

	[Token(Token = "0x400A852")]
	[FieldOffset(Offset = "0x14")]
	public string region;

	[Token(Token = "0x6008119")]
	[Address(RVA = "0x30A3BB4", Offset = "0x30A3BB4", VA = "0x30A3BB4")]
	public IPTagConfigDesc()
	{
	}
}
