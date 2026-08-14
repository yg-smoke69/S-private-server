using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001DAB")]
public class ECreatePlayer
{
	[Token(Token = "0x2001DAC")]
	public enum ErrCode
	{
		[Token(Token = "0x400BC0D")]
		ErrCode_NORMAL,
		[Token(Token = "0x400BC0E")]
		ErrCode_NEGATIVE_GEMS,
		[Token(Token = "0x400BC0F")]
		ErrCode_CSRANKING_BANNED,
		[Token(Token = "0x400BC10")]
		ErrCode_RANKING_BANNED,
		[Token(Token = "0x400BC11")]
		ErrCode_GROUP_BANNED
	}

	[Token(Token = "0x6008D46")]
	[Address(RVA = "0x33E9004", Offset = "0x33E9004", VA = "0x33E9004")]
	public ECreatePlayer()
	{
	}
}
