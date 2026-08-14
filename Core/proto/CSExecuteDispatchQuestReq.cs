using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001682")]
public class CSExecuteDispatchQuestReq
{
	[Token(Token = "0x4009656")]
	[FieldOffset(Offset = "0x8")]
	public uint quest_line;

	[Token(Token = "0x4009657")]
	[FieldOffset(Offset = "0xC")]
	public uint quest_id;

	[Token(Token = "0x4009658")]
	[FieldOffset(Offset = "0x10")]
	public uint[] avatar_ids;

	[Token(Token = "0x6007CCC")]
	[Address(RVA = "0x317FF44", Offset = "0x317FF44", VA = "0x317FF44")]
	public CSExecuteDispatchQuestReq()
	{
	}
}
