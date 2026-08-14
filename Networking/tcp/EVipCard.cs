using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001DB8")]
public class EVipCard
{
	[Token(Token = "0x2001DB9")]
	public enum Proto
	{
		[Token(Token = "0x400BC5D")]
		Proto_NONE,
		[Token(Token = "0x400BC5E")]
		Proto_PURCHASE_CARD_NTF
	}

	[Token(Token = "0x2001DBA")]
	public enum ErrCode
	{
		[Token(Token = "0x400BC60")]
		ErrCode_SUSS
	}

	[Token(Token = "0x2001DBB")]
	public enum VipCardType
	{
		[Token(Token = "0x400BC62")]
		VipCardType_NONE,
		[Token(Token = "0x400BC63")]
		VipCardType_WEEKLY,
		[Token(Token = "0x400BC64")]
		VipCardType_MONTHLY,
		[Token(Token = "0x400BC65")]
		VipCardType_SVIP
	}

	[Token(Token = "0x6008DE6")]
	[Address(RVA = "0x33E9240", Offset = "0x33E9240", VA = "0x33E9240")]
	public EVipCard()
	{
	}
}
