using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001818")]
public class CSGetGoliathAFKGroupInfoReq
{
	[Token(Token = "0x4009C0F")]
	[FieldOffset(Offset = "0x8")]
	public ulong group_id;

	[Token(Token = "0x4009C10")]
	[FieldOffset(Offset = "0x10")]
	public bool before_start;

	[Token(Token = "0x6007E72")]
	[Address(RVA = "0x3185BA0", Offset = "0x3185BA0", VA = "0x3185BA0")]
	public CSGetGoliathAFKGroupInfoReq()
	{
	}
}
