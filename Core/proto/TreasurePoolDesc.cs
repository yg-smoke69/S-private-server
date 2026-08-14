using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019CC")]
public class TreasurePoolDesc
{
	[Token(Token = "0x400A18D")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A18E")]
	[FieldOffset(Offset = "0xC")]
	public string name;

	[Token(Token = "0x400A18F")]
	[FieldOffset(Offset = "0x10")]
	public string desc;

	[Token(Token = "0x400A190")]
	[FieldOffset(Offset = "0x14")]
	public uint need_daily_score;

	[Token(Token = "0x400A191")]
	[FieldOffset(Offset = "0x18")]
	public uint need_weekly_score;

	[Token(Token = "0x6008024")]
	[Address(RVA = "0x33E3AB0", Offset = "0x33E3AB0", VA = "0x33E3AB0")]
	public TreasurePoolDesc()
	{
	}
}
