using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014C1")]
public class WorkshopCommentTag
{
	[Token(Token = "0x4008FB9")]
	[FieldOffset(Offset = "0x8")]
	public uint tag_id;

	[Token(Token = "0x4008FBA")]
	[FieldOffset(Offset = "0xC")]
	public uint tag_num;

	[Token(Token = "0x6007B22")]
	[Address(RVA = "0x33E620C", Offset = "0x33E620C", VA = "0x33E620C")]
	public WorkshopCommentTag()
	{
	}
}
