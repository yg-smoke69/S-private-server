using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019D7")]
public class ActivityBingoInfoDesc
{
	[Token(Token = "0x400A217")]
	[FieldOffset(Offset = "0x8")]
	public uint level;

	[Token(Token = "0x400A218")]
	[FieldOffset(Offset = "0xC")]
	public uint key_id;

	[Token(Token = "0x400A219")]
	[FieldOffset(Offset = "0x10")]
	public uint init_key_num;

	[Token(Token = "0x400A21A")]
	[FieldOffset(Offset = "0x14")]
	public uint cost_key_num;

	[Token(Token = "0x400A21B")]
	[FieldOffset(Offset = "0x18")]
	public uint cost_diamond;

	[Token(Token = "0x400A21C")]
	[FieldOffset(Offset = "0x1C")]
	public string start_time;

	[Token(Token = "0x400A21D")]
	[FieldOffset(Offset = "0x20")]
	public string end_time;

	[Token(Token = "0x600802F")]
	[Address(RVA = "0x3179EF0", Offset = "0x3179EF0", VA = "0x3179EF0")]
	public ActivityBingoInfoDesc()
	{
	}
}
