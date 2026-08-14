using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CF7")]
public class EGameServerManager
{
	[Token(Token = "0x2001CF8")]
	public enum Proto
	{
		[Token(Token = "0x400B749")]
		Proto_NONE,
		[Token(Token = "0x400B74A")]
		Proto_UGC_DEBUG_START,
		[Token(Token = "0x400B74B")]
		Proto_UGC_DEBUG_SUSS_NTF
	}

	[Token(Token = "0x2001CF9")]
	public enum ErrCode
	{
		[Token(Token = "0x400B74D")]
		ErrCode_SUSS,
		[Token(Token = "0x400B74E")]
		ErrCode_GAMESERVER_DEBUG_ROOMS_LIMIT
	}

	[Token(Token = "0x60086AF")]
	[Address(RVA = "0x33E9034", Offset = "0x33E9034", VA = "0x33E9034")]
	public EGameServerManager()
	{
	}
}
