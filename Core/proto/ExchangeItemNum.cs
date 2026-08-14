using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016EA")]
public class ExchangeItemNum
{
	[Token(Token = "0x40097F0")]
	[FieldOffset(Offset = "0x8")]
	public uint itemId;

	[Token(Token = "0x40097F1")]
	[FieldOffset(Offset = "0xC")]
	public uint num;

	[Token(Token = "0x6007D44")]
	[Address(RVA = "0x309FE04", Offset = "0x309FE04", VA = "0x309FE04")]
	public ExchangeItemNum()
	{
	}
}
