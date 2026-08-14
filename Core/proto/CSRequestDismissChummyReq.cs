using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001939")]
public class CSRequestDismissChummyReq
{
	[Token(Token = "0x4009F24")]
	[FieldOffset(Offset = "0x8")]
	public ulong target_id;

	[Token(Token = "0x4009F25")]
	[FieldOffset(Offset = "0x10")]
	public EChummy.MultiRelationType multi_relation_type;

	[Token(Token = "0x4009F26")]
	[FieldOffset(Offset = "0x14")]
	public EChummy.RequestType request_type;

	[Token(Token = "0x6007F92")]
	[Address(RVA = "0x3099538", Offset = "0x3099538", VA = "0x3099538")]
	public CSRequestDismissChummyReq()
	{
	}
}
