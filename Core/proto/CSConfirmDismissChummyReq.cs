using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200193A")]
public class CSConfirmDismissChummyReq
{
	[Token(Token = "0x4009F27")]
	[FieldOffset(Offset = "0x8")]
	public ulong applicant_id;

	[Token(Token = "0x4009F28")]
	[FieldOffset(Offset = "0x10")]
	public EChummy.MultiRelationType multi_relation_type;

	[Token(Token = "0x4009F29")]
	[FieldOffset(Offset = "0x14")]
	public EChummy.RequestType request_type;

	[Token(Token = "0x6007F93")]
	[Address(RVA = "0x317F150", Offset = "0x317F150", VA = "0x317F150")]
	public CSConfirmDismissChummyReq()
	{
	}
}
