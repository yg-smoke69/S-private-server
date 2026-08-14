using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BC2")]
public class MocoMonthLevelDesc
{
	[Token(Token = "0x400AEB4")]
	[FieldOffset(Offset = "0x8")]
	public uint level_id;

	[Token(Token = "0x400AEB5")]
	[FieldOffset(Offset = "0xC")]
	public uint time_limit;

	[Token(Token = "0x400AEB6")]
	[FieldOffset(Offset = "0x10")]
	public string first_line;

	[Token(Token = "0x400AEB7")]
	[FieldOffset(Offset = "0x14")]
	public string second_line;

	[Token(Token = "0x400AEB8")]
	[FieldOffset(Offset = "0x18")]
	public string third_line;

	[Token(Token = "0x400AEB9")]
	[FieldOffset(Offset = "0x1C")]
	public string fourth_line;

	[Token(Token = "0x600821D")]
	[Address(RVA = "0x30A8AE0", Offset = "0x30A8AE0", VA = "0x30A8AE0")]
	public MocoMonthLevelDesc()
	{
	}
}
