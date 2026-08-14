using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001936")]
public class CSRequestAddingChummyReq
{
	[Token(Token = "0x4009F1B")]
	[FieldOffset(Offset = "0x8")]
	public ulong target_id;

	[Token(Token = "0x4009F1C")]
	[FieldOffset(Offset = "0x10")]
	public EChummy.MultiRelationType multi_relation_type;

	[Token(Token = "0x4009F1D")]
	[FieldOffset(Offset = "0x14")]
	public EChummy.RequestType request_type;

	[Token(Token = "0x6007F8F")]
	[Address(RVA = "0x3099530", Offset = "0x3099530", VA = "0x3099530")]
	public CSRequestAddingChummyReq()
	{
	}
}
