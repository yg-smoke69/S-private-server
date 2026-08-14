using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200181B")]
public class CSJoinGoliathAFKGroupReq
{
	[Token(Token = "0x4009C13")]
	[FieldOffset(Offset = "0x8")]
	public ulong group_id;

	[Token(Token = "0x4009C14")]
	[FieldOffset(Offset = "0x10")]
	public ELimitedEvent.GoliathGroupJoinSource source;

	[Token(Token = "0x6007E75")]
	[Address(RVA = "0x30974E4", Offset = "0x30974E4", VA = "0x30974E4")]
	public CSJoinGoliathAFKGroupReq()
	{
	}
}
