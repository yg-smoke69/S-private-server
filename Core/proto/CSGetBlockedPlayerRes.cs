using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016A3")]
public class CSGetBlockedPlayerRes
{
	[Token(Token = "0x40096A9")]
	[FieldOffset(Offset = "0x8")]
	public ulong[] blocked_list;

	[Token(Token = "0x6007D04")]
	[Address(RVA = "0x3182428", Offset = "0x3182428", VA = "0x3182428")]
	public CSGetBlockedPlayerRes()
	{
	}
}
