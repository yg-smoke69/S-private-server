using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BF2")]
public class MultiIntimacyRankAwardDesc
{
	[Token(Token = "0x400B004")]
	[FieldOffset(Offset = "0x8")]
	public EChummy.MultiRelationType multi_relation_type;

	[Token(Token = "0x400B005")]
	[FieldOffset(Offset = "0xC")]
	public EChummy.Role relation_role;

	[Token(Token = "0x400B006")]
	[FieldOffset(Offset = "0x10")]
	public uint intimacy_rank;

	[Token(Token = "0x400B007")]
	[FieldOffset(Offset = "0x14")]
	public uint intimacy_point;

	[Token(Token = "0x400B008")]
	[FieldOffset(Offset = "0x18")]
	public List<AwardDesc> awards;

	[Token(Token = "0x600824D")]
	[Address(RVA = "0x30A916C", Offset = "0x30A916C", VA = "0x30A916C")]
	public MultiIntimacyRankAwardDesc()
	{
	}
}
