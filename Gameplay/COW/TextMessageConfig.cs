using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E2E")]
public static class TextMessageConfig
{
	[Token(Token = "0x400BEA7")]
	public const int INVALID_SERVERZONE_ID = 9999;

	[Token(Token = "0x400BEA8")]
	[FieldOffset(Offset = "0x0")]
	public static int ServerZoneID;

	[Token(Token = "0x400BEA9")]
	[FieldOffset(Offset = "0x4")]
	public static string ServerAddr;

	[Token(Token = "0x17000F29")]
	public static bool IsAvailable
	{
		[Token(Token = "0x6009091")]
		[Address(RVA = "0x28A6394", Offset = "0x28A6394", VA = "0x28A6394")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6009090")]
	[Address(RVA = "0x28A61BC", Offset = "0x28A61BC", VA = "0x28A61BC")]
	public static bool IsChatServerValid()
	{
		return default(bool);
	}
}
