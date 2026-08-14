using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200193B")]
public class CSDeclineDismissChummyReq
{
	[Token(Token = "0x4009F2A")]
	[FieldOffset(Offset = "0x8")]
	public ulong applicant_id;

	[Token(Token = "0x4009F2B")]
	[FieldOffset(Offset = "0x10")]
	public EChummy.MultiRelationType multi_relation_type;

	[Token(Token = "0x4009F2C")]
	[FieldOffset(Offset = "0x14")]
	public EChummy.RequestType request_type;

	[Token(Token = "0x6007F94")]
	[Address(RVA = "0x317F570", Offset = "0x317F570", VA = "0x317F570")]
	public CSDeclineDismissChummyReq()
	{
	}
}
