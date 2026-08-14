using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200161B")]
public class CSReadMailReq
{
	[Token(Token = "0x4009531")]
	[FieldOffset(Offset = "0x8")]
	public ulong[] mail_ids;

	[Token(Token = "0x4009532")]
	[FieldOffset(Offset = "0xC")]
	public uint status;

	[Token(Token = "0x6007C65")]
	[Address(RVA = "0x3098E40", Offset = "0x3098E40", VA = "0x3098E40")]
	public CSReadMailReq()
	{
	}
}
