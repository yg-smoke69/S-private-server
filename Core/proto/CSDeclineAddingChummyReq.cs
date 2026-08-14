using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001938")]
public class CSDeclineAddingChummyReq
{
	[Token(Token = "0x4009F21")]
	[FieldOffset(Offset = "0x8")]
	public ulong applicant_id;

	[Token(Token = "0x4009F22")]
	[FieldOffset(Offset = "0x10")]
	public EChummy.MultiRelationType multi_relation_type;

	[Token(Token = "0x4009F23")]
	[FieldOffset(Offset = "0x14")]
	public EChummy.RequestType request_type;

	[Token(Token = "0x6007F91")]
	[Address(RVA = "0x317F568", Offset = "0x317F568", VA = "0x317F568")]
	public CSDeclineAddingChummyReq()
	{
	}
}
