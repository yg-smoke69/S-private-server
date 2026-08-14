using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200144E")]
public class ESubscription
{
	[Token(Token = "0x200144F")]
	public enum SubscribeType
	{
		[Token(Token = "0x4008D39")]
		SubscribeType_NONE,
		[Token(Token = "0x4008D3A")]
		SubscribeType_REBATE,
		[Token(Token = "0x4008D3B")]
		SubscribeType_EP,
		[Token(Token = "0x4008D3C")]
		SubscribeType_BUNDLE
	}

	[Token(Token = "0x2001450")]
	public enum PriceType
	{
		[Token(Token = "0x4008D3E")]
		PriceType_NONE,
		[Token(Token = "0x4008D3F")]
		PriceType_WEEK,
		[Token(Token = "0x4008D40")]
		PriceType_MONTH
	}

	[Token(Token = "0x2001451")]
	public enum TagType
	{
		[Token(Token = "0x4008D42")]
		TagType_NONE,
		[Token(Token = "0x4008D43")]
		TagType_LIMITEDTIME,
		[Token(Token = "0x4008D44")]
		TagType_NEW
	}

	[Token(Token = "0x6007AFC")]
	[Address(RVA = "0x309F904", Offset = "0x309F904", VA = "0x309F904")]
	public ESubscription()
	{
	}
}
