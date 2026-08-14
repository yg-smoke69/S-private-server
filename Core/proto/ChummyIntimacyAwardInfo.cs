using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014D8")]
public class ChummyIntimacyAwardInfo
{
	[Token(Token = "0x4009007")]
	[FieldOffset(Offset = "0x8")]
	public ulong chummy_id;

	[Token(Token = "0x4009008")]
	[FieldOffset(Offset = "0x10")]
	public EChummy.MultiRelationType multi_relation_type;

	[Token(Token = "0x4009009")]
	[FieldOffset(Offset = "0x14")]
	public uint rank;

	[Token(Token = "0x400900A")]
	[FieldOffset(Offset = "0x18")]
	public EChummy.Role role;

	[Token(Token = "0x6007B2D")]
	[Address(RVA = "0x309B808", Offset = "0x309B808", VA = "0x309B808")]
	public ChummyIntimacyAwardInfo()
	{
	}
}
