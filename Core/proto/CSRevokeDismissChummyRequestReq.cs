using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200193C")]
public class CSRevokeDismissChummyRequestReq
{
	[Token(Token = "0x4009F2D")]
	[FieldOffset(Offset = "0x8")]
	public ulong target_id;

	[Token(Token = "0x4009F2E")]
	[FieldOffset(Offset = "0x10")]
	public EChummy.MultiRelationType multi_relation_type;

	[Token(Token = "0x6007F95")]
	[Address(RVA = "0x3099548", Offset = "0x3099548", VA = "0x3099548")]
	public CSRevokeDismissChummyRequestReq()
	{
	}
}
