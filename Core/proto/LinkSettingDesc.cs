using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A60")]
public class LinkSettingDesc
{
	[Token(Token = "0x400A51C")]
	[FieldOffset(Offset = "0x8")]
	public bool is_open;

	[Token(Token = "0x400A51D")]
	[FieldOffset(Offset = "0xC")]
	public uint open_level;

	[Token(Token = "0x400A51E")]
	[FieldOffset(Offset = "0x10")]
	public bool is_cd;

	[Token(Token = "0x400A51F")]
	[FieldOffset(Offset = "0x14")]
	public uint cd_time;

	[Token(Token = "0x60080B8")]
	[Address(RVA = "0x30A63FC", Offset = "0x30A63FC", VA = "0x30A63FC")]
	public LinkSettingDesc()
	{
	}
}
