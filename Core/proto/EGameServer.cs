using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200130C")]
public class EGameServer
{
	[Token(Token = "0x200130D")]
	public enum Proto
	{
		[Token(Token = "0x40086E6")]
		Proto_NONE,
		[Token(Token = "0x40086E7")]
		Proto_START_GAMESERVER,
		[Token(Token = "0x40086E8")]
		Proto_UGC_DEBUG_START
	}

	[Token(Token = "0x200130E")]
	public enum ServerStatus
	{
		[Token(Token = "0x40086EA")]
		ServerStatus_NONE,
		[Token(Token = "0x40086EB")]
		ServerStatus_RUNNING,
		[Token(Token = "0x40086EC")]
		ServerStatus_SOFTCLOSED,
		[Token(Token = "0x40086ED")]
		ServerStatus_DOWN
	}

	[Token(Token = "0x200130F")]
	public enum ServerType
	{
		[Token(Token = "0x40086EF")]
		ServerType_NONE,
		[Token(Token = "0x40086F0")]
		ServerType_NORMAL,
		[Token(Token = "0x40086F1")]
		ServerType_UGC,
		[Token(Token = "0x40086F2")]
		ServerType_UGC_DEBUG
	}

	[Token(Token = "0x6007A4A")]
	[Address(RVA = "0x309F2E0", Offset = "0x309F2E0", VA = "0x309F2E0")]
	public EGameServer()
	{
	}
}
