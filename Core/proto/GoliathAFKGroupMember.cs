using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001816")]
public class GoliathAFKGroupMember
{
	[Token(Token = "0x4009C0A")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009C0B")]
	[FieldOffset(Offset = "0x10")]
	public string nickname;

	[Token(Token = "0x4009C0C")]
	[FieldOffset(Offset = "0x14")]
	public bool award_claimed;

	[Token(Token = "0x6007E70")]
	[Address(RVA = "0x30A2A18", Offset = "0x30A2A18", VA = "0x30A2A18")]
	public GoliathAFKGroupMember()
	{
	}
}
