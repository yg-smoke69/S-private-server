using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BDB")]
public class WorkshopLevelExpDesc
{
	[Token(Token = "0x400AF3F")]
	[FieldOffset(Offset = "0x8")]
	public uint level;

	[Token(Token = "0x400AF40")]
	[FieldOffset(Offset = "0xC")]
	public uint exp;

	[Token(Token = "0x400AF41")]
	[FieldOffset(Offset = "0x10")]
	public List<ExchangedAward> awards;

	[Token(Token = "0x6008236")]
	[Address(RVA = "0x33E6680", Offset = "0x33E6680", VA = "0x33E6680")]
	public WorkshopLevelExpDesc()
	{
	}
}
