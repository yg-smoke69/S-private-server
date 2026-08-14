using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200181F")]
public class CSClaimGoliathAFKGroupAwardsReq
{
	[Token(Token = "0x4009C18")]
	[FieldOffset(Offset = "0x8")]
	public ulong group_id;

	[Token(Token = "0x4009C19")]
	[FieldOffset(Offset = "0x10")]
	public string language;

	[Token(Token = "0x6007E79")]
	[Address(RVA = "0x317E728", Offset = "0x317E728", VA = "0x317E728")]
	public CSClaimGoliathAFKGroupAwardsReq()
	{
	}
}
