using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014D6")]
public class ChummyState
{
	[Token(Token = "0x4008FFE")]
	[FieldOffset(Offset = "0x8")]
	public ulong chummy_id;

	[Token(Token = "0x4008FFF")]
	[FieldOffset(Offset = "0x10")]
	public EChummy.MultiRelationType multi_relation_type;

	[Token(Token = "0x4009000")]
	[FieldOffset(Offset = "0x14")]
	public uint intimacy;

	[Token(Token = "0x4009001")]
	[FieldOffset(Offset = "0x18")]
	public long create_at;

	[Token(Token = "0x4009002")]
	[FieldOffset(Offset = "0x20")]
	public EChummy.RelationState state;

	[Token(Token = "0x4009003")]
	[FieldOffset(Offset = "0x24")]
	public EChummy.Role role;

	[Token(Token = "0x4009004")]
	[FieldOffset(Offset = "0x28")]
	public long state_update_at;

	[Token(Token = "0x6007B2B")]
	[Address(RVA = "0x309B818", Offset = "0x309B818", VA = "0x309B818")]
	public ChummyState()
	{
	}
}
