using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019C1")]
public class PreviewWebDesc
{
	[Token(Token = "0x400A163")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400A164")]
	[FieldOffset(Offset = "0xC")]
	public string web_icon;

	[Token(Token = "0x400A165")]
	[FieldOffset(Offset = "0x10")]
	public string language;

	[Token(Token = "0x400A166")]
	[FieldOffset(Offset = "0x14")]
	public string web_url;

	[Token(Token = "0x6008019")]
	[Address(RVA = "0x33E0164", Offset = "0x33E0164", VA = "0x33E0164")]
	public PreviewWebDesc()
	{
	}
}
