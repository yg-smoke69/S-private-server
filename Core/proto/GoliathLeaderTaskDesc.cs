using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B50")]
public class GoliathLeaderTaskDesc
{
	[Token(Token = "0x400ABC9")]
	[FieldOffset(Offset = "0x8")]
	public uint task_id;

	[Token(Token = "0x400ABCA")]
	[FieldOffset(Offset = "0xC")]
	public uint task_weight;

	[Token(Token = "0x60081AB")]
	[Address(RVA = "0x30A2B44", Offset = "0x30A2B44", VA = "0x30A2B44")]
	public GoliathLeaderTaskDesc()
	{
	}
}
