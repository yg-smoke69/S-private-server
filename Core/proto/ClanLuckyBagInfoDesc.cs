using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A31")]
public class ClanLuckyBagInfoDesc
{
	[Token(Token = "0x400A403")]
	[FieldOffset(Offset = "0x8")]
	public uint level;

	[Token(Token = "0x400A404")]
	[FieldOffset(Offset = "0xC")]
	public uint double_prob;

	[Token(Token = "0x400A405")]
	[FieldOffset(Offset = "0x10")]
	public uint big_contribute;

	[Token(Token = "0x400A406")]
	[FieldOffset(Offset = "0x14")]
	public uint big_finish;

	[Token(Token = "0x400A407")]
	[FieldOffset(Offset = "0x18")]
	public List<AwardDesc> Award;

	[Token(Token = "0x6008089")]
	[Address(RVA = "0x309BCAC", Offset = "0x309BCAC", VA = "0x309BCAC")]
	public ClanLuckyBagInfoDesc()
	{
	}
}
