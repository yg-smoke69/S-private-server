using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A96")]
public class UniversalLinkSettingDesc
{
	[Token(Token = "0x400A67C")]
	[FieldOffset(Offset = "0x8")]
	public string universal_link;

	[Token(Token = "0x400A67D")]
	[FieldOffset(Offset = "0xC")]
	public string deep_link;

	[Token(Token = "0x400A67E")]
	[FieldOffset(Offset = "0x10")]
	public uint start_time;

	[Token(Token = "0x400A67F")]
	[FieldOffset(Offset = "0x14")]
	public uint end_time;

	[Token(Token = "0x60080F3")]
	[Address(RVA = "0x33E4070", Offset = "0x33E4070", VA = "0x33E4070")]
	public UniversalLinkSettingDesc()
	{
	}
}
