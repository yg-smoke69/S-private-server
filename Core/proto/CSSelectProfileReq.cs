using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200166C")]
public class CSSelectProfileReq
{
	[Token(Token = "0x4009625")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x4009626")]
	[FieldOffset(Offset = "0x10")]
	public ulong group_id;

	[Token(Token = "0x6007CB6")]
	[Address(RVA = "0x3099774", Offset = "0x3099774", VA = "0x3099774")]
	public CSSelectProfileReq()
	{
	}
}
