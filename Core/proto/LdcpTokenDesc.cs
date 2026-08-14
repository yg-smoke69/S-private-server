using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B41")]
public class LdcpTokenDesc
{
	[Token(Token = "0x400AB8F")]
	[FieldOffset(Offset = "0x8")]
	public uint token_num;

	[Token(Token = "0x400AB90")]
	[FieldOffset(Offset = "0xC")]
	public uint efficiency;

	[Token(Token = "0x600819C")]
	[Address(RVA = "0x30A4444", Offset = "0x30A4444", VA = "0x30A4444")]
	public LdcpTokenDesc()
	{
	}
}
