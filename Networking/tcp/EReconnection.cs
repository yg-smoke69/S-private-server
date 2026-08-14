using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D83")]
public class EReconnection
{
	[Token(Token = "0x2001D84")]
	public enum Proto
	{
		[Token(Token = "0x400BA85")]
		Proto_NONE,
		[Token(Token = "0x400BA86")]
		Proto_CHECK,
		[Token(Token = "0x400BA87")]
		Proto_CLEAR,
		[Token(Token = "0x400BA88")]
		Proto_GAMEINFO,
		[Token(Token = "0x400BA89")]
		Proto_ROOMINFO
	}

	[Token(Token = "0x6008A22")]
	[Address(RVA = "0x33E9218", Offset = "0x33E9218", VA = "0x33E9218")]
	public EReconnection()
	{
	}
}
