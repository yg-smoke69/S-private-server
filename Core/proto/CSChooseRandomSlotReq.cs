using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200159E")]
public class CSChooseRandomSlotReq
{
	[Token(Token = "0x40093B9")]
	[FieldOffset(Offset = "0x8")]
	public List<RandomSlotInfo> random_slots;

	[Token(Token = "0x40093BA")]
	[FieldOffset(Offset = "0x10")]
	public ulong group_id;

	[Token(Token = "0x6007BE6")]
	[Address(RVA = "0x317E32C", Offset = "0x317E32C", VA = "0x317E32C")]
	public CSChooseRandomSlotReq()
	{
	}
}
