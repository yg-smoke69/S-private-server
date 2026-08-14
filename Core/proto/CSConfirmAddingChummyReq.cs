using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001937")]
public class CSConfirmAddingChummyReq
{
	[Token(Token = "0x4009F1E")]
	[FieldOffset(Offset = "0x8")]
	public ulong applicant_id;

	[Token(Token = "0x4009F1F")]
	[FieldOffset(Offset = "0x10")]
	public EChummy.MultiRelationType multi_relation_type;

	[Token(Token = "0x4009F20")]
	[FieldOffset(Offset = "0x14")]
	public EChummy.RequestType request_type;

	[Token(Token = "0x6007F90")]
	[Address(RVA = "0x317F148", Offset = "0x317F148", VA = "0x317F148")]
	public CSConfirmAddingChummyReq()
	{
	}
}
