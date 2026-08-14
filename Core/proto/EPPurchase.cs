using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013DA")]
public class EPPurchase
{
	[Token(Token = "0x20013DB")]
	public enum EPType
	{
		[Token(Token = "0x4008B4D")]
		EPType_NONE,
		[Token(Token = "0x4008B4E")]
		EPType_NORMAL,
		[Token(Token = "0x4008B4F")]
		EPType_BUNDLE
	}

	[Token(Token = "0x6007ABC")]
	[Address(RVA = "0x309F5F0", Offset = "0x309F5F0", VA = "0x309F5F0")]
	public EPPurchase()
	{
	}
}
