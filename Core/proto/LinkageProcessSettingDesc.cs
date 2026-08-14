using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B16")]
public class LinkageProcessSettingDesc
{
	[Token(Token = "0x400AA44")]
	[FieldOffset(Offset = "0x8")]
	public uint process_id;

	[Token(Token = "0x400AA45")]
	[FieldOffset(Offset = "0x10")]
	public ulong start_value;

	[Token(Token = "0x400AA46")]
	[FieldOffset(Offset = "0x18")]
	public ulong end_value;

	[Token(Token = "0x400AA47")]
	[FieldOffset(Offset = "0x20")]
	public uint time_span;

	[Token(Token = "0x6008171")]
	[Address(RVA = "0x30A6424", Offset = "0x30A6424", VA = "0x30A6424")]
	public LinkageProcessSettingDesc()
	{
	}
}
