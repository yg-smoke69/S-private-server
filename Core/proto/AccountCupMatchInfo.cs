using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001595")]
public class AccountCupMatchInfo
{
	[Token(Token = "0x4009396")]
	[FieldOffset(Offset = "0x8")]
	public List<AccountTypedCupMatchInfo> infos;

	[Token(Token = "0x4009397")]
	[FieldOffset(Offset = "0xC")]
	public uint limited_level;

	[Token(Token = "0x4009398")]
	[FieldOffset(Offset = "0x10")]
	public uint limited_rank;

	[Token(Token = "0x4009399")]
	[FieldOffset(Offset = "0x14")]
	public uint upper_limited_level;

	[Token(Token = "0x400939A")]
	[FieldOffset(Offset = "0x18")]
	public uint upper_limited_rank;

	[Token(Token = "0x400939B")]
	[FieldOffset(Offset = "0x1C")]
	public uint player_count_limit;

	[Token(Token = "0x6007BDD")]
	[Address(RVA = "0x31794C4", Offset = "0x31794C4", VA = "0x31794C4")]
	public AccountCupMatchInfo()
	{
	}
}
