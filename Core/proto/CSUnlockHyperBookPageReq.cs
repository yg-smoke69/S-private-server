using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200198C")]
public class CSUnlockHyperBookPageReq
{
	[Token(Token = "0x400A00F")]
	[FieldOffset(Offset = "0x8")]
	public uint book_id;

	[Token(Token = "0x400A010")]
	[FieldOffset(Offset = "0xC")]
	public uint sort_id;

	[Token(Token = "0x6007FE7")]
	[Address(RVA = "0x309A49C", Offset = "0x309A49C", VA = "0x309A49C")]
	public CSUnlockHyperBookPageReq()
	{
	}
}
