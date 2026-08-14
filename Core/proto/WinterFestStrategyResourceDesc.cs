using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BCF")]
public class WinterFestStrategyResourceDesc
{
	[Token(Token = "0x400AEF6")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AEF7")]
	[FieldOffset(Offset = "0xC")]
	public List<MiniGameItem> cost_items;

	[Token(Token = "0x400AEF8")]
	[FieldOffset(Offset = "0x10")]
	public MiniGameItem product;

	[Token(Token = "0x400AEF9")]
	[FieldOffset(Offset = "0x14")]
	public uint unlock_level;

	[Token(Token = "0x400AEFA")]
	[FieldOffset(Offset = "0x18")]
	public uint[] unlock_last_digits;

	[Token(Token = "0x600822A")]
	[Address(RVA = "0x33E5E4C", Offset = "0x33E5E4C", VA = "0x33E5E4C")]
	public WinterFestStrategyResourceDesc()
	{
	}
}
