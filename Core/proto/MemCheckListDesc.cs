using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B05")]
public class MemCheckListDesc
{
	[Token(Token = "0x400A9EC")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x400A9ED")]
	[FieldOffset(Offset = "0x10")]
	public string mem_addr;

	[Token(Token = "0x6008160")]
	[Address(RVA = "0x30A8780", Offset = "0x30A8780", VA = "0x30A8780")]
	public MemCheckListDesc()
	{
	}
}
