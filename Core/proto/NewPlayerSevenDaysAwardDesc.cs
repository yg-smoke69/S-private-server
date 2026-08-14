using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B09")]
public class NewPlayerSevenDaysAwardDesc
{
	[Token(Token = "0x400AA03")]
	[FieldOffset(Offset = "0x8")]
	public uint achievement_id;

	[Token(Token = "0x400AA04")]
	[FieldOffset(Offset = "0xC")]
	public uint day_id;

	[Token(Token = "0x400AA05")]
	[FieldOffset(Offset = "0x10")]
	public uint[] achievement_id_array;

	[Token(Token = "0x400AA06")]
	[FieldOffset(Offset = "0x14")]
	public List<ExchangedAward> awards;

	[Token(Token = "0x400AA07")]
	[FieldOffset(Offset = "0x18")]
	public uint must_finish_count;

	[Token(Token = "0x6008164")]
	[Address(RVA = "0x33DE6C4", Offset = "0x33DE6C4", VA = "0x33DE6C4")]
	public NewPlayerSevenDaysAwardDesc()
	{
	}
}
