using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B3F")]
public class AnniversarySettingDesc
{
	[Token(Token = "0x400AB78")]
	[FieldOffset(Offset = "0x8")]
	public uint process_start_timestamp;

	[Token(Token = "0x400AB79")]
	[FieldOffset(Offset = "0xC")]
	public string web_link;

	[Token(Token = "0x400AB7A")]
	[FieldOffset(Offset = "0x10")]
	public uint web_open_timestamp;

	[Token(Token = "0x400AB7B")]
	[FieldOffset(Offset = "0x14")]
	public uint web_close_timestamp;

	[Token(Token = "0x600819A")]
	[Address(RVA = "0x317A8D8", Offset = "0x317A8D8", VA = "0x317A8D8")]
	public AnniversarySettingDesc()
	{
	}
}
